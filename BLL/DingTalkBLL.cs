using System;
using System.Linq;
using NetSDK.DingTalk;
using NetSDK.DingTalk.DataContracts;

namespace OUDAL
{
    public class DingTalkBLL
    {
        private Context db = new Context();

        #region 同步考勤数据

        /// <summary>
        /// 同步考勤数据
        /// </summary>
        public void SyncKaoQin()
        {
            //获取上个月第一天
            var dateFrom = DateTime.Today;
            dateFrom = new DateTime(dateFrom.Year, dateFrom.Month, 1).AddDays(-1);
            dateFrom = new DateTime(dateFrom.Year, dateFrom.Month, 1);

            var config = db.DingTalkKaoQin.FirstOrDefault(n => n.id == 0);

            if (config == null)
            {
                config = new DingTalkKaoQin { id = 0, workDate = dateFrom };
                db.DingTalkKaoQin.Add(config);
            }
            else
            {
                if (config.workDate > dateFrom)
                {
                    //前次同步的最后一天可以重复，防止数据不完整
                    dateFrom = config.workDate.Value.Date;
                }
            }

            //-------获取钉钉数据(每次只能取7天范围内的)-----------------

            var unixExpoch = new DateTime(1970, 1, 1).AddHours(8);
            var corpClient = GetCorpClient();

            for (var i = 0; i < 10 && dateFrom < DateTime.Today; i++)
            {
                var dateTo = dateFrom.AddDays(6);

                if (dateTo >= DateTime.Today)
                {
                    dateTo = DateTime.Today.AddDays(-1);
                }

                var results = corpClient.GetAttendanceList(dateFrom, dateTo).OrderBy(n => n.id);

                foreach (var r in results)
                {
                    if (db.DingTalkKaoQin.Any(n => n.id == r.id)) continue;

                    switch (r.checkType)
                    {
                        case "OnDuty":
                            r.checkType = "上班";
                            break;
                        case "OffDuty":
                            r.checkType = "下班";
                            break;
                    }
                    switch (r.timeResult)
                    {
                        case "Normal":
                            r.timeResult = "正常";
                            break;
                        case "Early":
                            r.timeResult = "早退";
                            break;
                        case "Late":
                            r.timeResult = "迟到";
                            break;
                        case "SeriousLate":
                            r.timeResult = "严重迟到";
                            break;
                        case "NotSigned":
                            r.timeResult = "未打卡";
                            break;
                    }
                    switch (r.locationResult)
                    {
                        case "Normal":
                            r.locationResult = "范围内";
                            break;
                        case "Outside":
                            r.locationResult = "范围外";
                            break;
                        case "NotSigned":
                            r.locationResult = "未打卡";
                            break;
                    }
                    //---钉钉考勤---
                    var dkqData = new DingTalkKaoQin
                    {
                        id = r.id,
                        approveId = r.approveId,
                        approveResult = r.approveResult,
                        baseCheckTime = unixExpoch.AddMilliseconds(r.baseCheckTime),
                        checkType = r.checkType,
                        groupId = r.groupId,
                        locationResult = r.locationResult,
                        planId = r.planId,
                        recordId = r.recordId,
                        sourceType = r.sourceType,
                        timeResult = r.timeResult,
                        userCheckTime = unixExpoch.AddMilliseconds(r.userCheckTime),
                        userId = r.userId,
                        workDate = unixExpoch.AddMilliseconds(r.workDate)
                    };
                    db.DingTalkKaoQin.Add(dkqData);

                    //---考勤雇员---
                    var query = from a in db.GuYuanUser
                                join b in db.DingTalkUser on a.Guid equals b.Guid
                                where b.userid == r.userId
                                select a;
                    var gyUser = query.FirstOrDefault() ?? SyncUser(r.userId);

                    //---雇员考勤表---
                    var gykqData = new GuYuanKaoQin
                    {
                        checkResult = r.timeResult,
                        checkTime = dkqData.userCheckTime,
                        checkType = r.checkType,
                        guyuanId = gyUser.id,
                        guyuanName = gyUser.Name,
                        workDate = dkqData.workDate,
                        externalId = r.id.ToString()
                    };

                    db.GuYuanKaoQin.Add(gykqData);
                }

                config.workDate = dateTo;
                db.SaveChanges();

                dateFrom = dateTo.AddDays(1);
            }
        }

        #endregion

        #region 同步部门信息

        /// <summary>
        /// 同步部门信息
        /// </summary>
        /// <returns></returns>
        public int SyncDepartment()
        {
            var corpClient = GetCorpClient();
            var allDep = corpClient.GetAllDepartment();
            foreach (var dep in allDep)
            {
                var data = db.GuYuanDepartment.FirstOrDefault(n => n.DingId == dep.id);
                if (data == null)
                {
                    data = new GuYuanDepartment
                    {
                        createdate = DateTime.Now,
                        DingId = dep.id,
                        DingParentId = dep.parentid,
                        DepartmentName = dep.name,
                        OptId = 0,
                        OptName = "钉钉同步"
                    };
                    db.GuYuanDepartment.Add(data);
                }
                else
                {
                    data.DepartmentName = dep.name;
                    data.OptName = "钉钉同步";
                }
            }
            return db.SaveChanges();
        }

        /// <summary>
        /// 同步单个部门
        /// </summary>
        /// <param name="dingId"></param>
        /// <returns></returns>
        private static GuYuanDepartment SyncDepartment(long dingId)
        {
            var db = new Context();
            var corpClient = GetCorpClient();
            var dep = corpClient.GetDepartment(dingId);
            var dbData = db.GuYuanDepartment.FirstOrDefault(n => n.DingId == dep.id);
            if (dbData == null)
            {
                dbData = new GuYuanDepartment
                {
                    createdate = DateTime.Now,
                    DingId = dep.id,
                    DingParentId = dep.parentid,
                    DepartmentName = dep.name,
                    OptId = 0,
                    OptName = "钉钉同步"
                };
                db.GuYuanDepartment.Add(dbData);
            }
            else
            {
                dbData.DepartmentName = dep.name;
                dbData.OptName = "钉钉同步";
            }
            db.SaveChanges();
            return dbData;
        }

        #endregion

        #region 同步员工信息

        /// <summary>
        /// 同步部门成员信息
        /// </summary>
        public void SyncUser()
        {
            var corpClient = GetCorpClient();
            var allUser = corpClient.GetAllUser();

            foreach (var user in allUser)
            {
                SetLocalUser(user, db);
            }
            db.SaveChanges();
        }

        private static GuYuanUser SyncUser(string dingUserId)
        {
            GuYuanUser gyUser = null;

            try
            {
                var db = new Context();
                var corpClient = GetCorpClient();
                var dingUser = corpClient.GetUser(dingUserId);
                gyUser = SetLocalUser(dingUser, db);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return gyUser ?? new GuYuanUser { Name = "未知" };
        }

        private static GuYuanUser SetLocalUser(User dingUser, Context db)
        {
            GuYuanUser dbGyUser = null;

            //--钉钉员工表--

            var dbDingUser = db.DingTalkUser.FirstOrDefault(n => n.userid == dingUser.userid);

            if (dbDingUser == null)
            {
                dbDingUser = new DingTalkUser { Guid = Guid.NewGuid() };
                dbDingUser = db.DingTalkUser.Add(dbDingUser);
                dbGyUser = db.GuYuanUser.FirstOrDefault(n => n.Phone == dingUser.mobile);
            }
            else
            {
                dbGyUser = db.GuYuanUser.FirstOrDefault(n => n.Guid == dbDingUser.Guid);
            }

            db.Entry(dbDingUser).CurrentValues.SetValues(dingUser);

            //--雇员所在部门--

            GuYuanDepartment gyDep = null;

            if (dingUser.department?.Any() == true)
            {
                var depId = dingUser.department.First();
                gyDep = db.GuYuanDepartment.FirstOrDefault(n => n.DingId == depId) ?? SyncDepartment(depId);
            }

            //--雇员信息表--

            if (dbGyUser == null)
            {
                dbGyUser = new GuYuanUser
                {
                    DepartmentName = gyDep?.DepartmentName,
                    OptName = "钉钉同步",
                    OptId = 0,
                    Name = dingUser.name,
                    createdate = DateTime.Now,
                    PositionName = dingUser.position,
                    projectid = gyDep?.ProjectId,
                    ProjectName = gyDep?.ProjectName,
                    Guid = dbDingUser.Guid,
                    Phone = dingUser.mobile
                };
                db.GuYuanUser.Add(dbGyUser);
            }
            else
            {
                dbGyUser.DepartmentName = gyDep?.DepartmentName;
                dbGyUser.OptName = "钉钉同步";
                dbGyUser.Name = dingUser.name;
                dbGyUser.PositionName = dingUser.position;
                dbGyUser.projectid = gyDep?.ProjectId;
                dbGyUser.ProjectName = gyDep?.ProjectName;
                dbGyUser.Phone = dingUser.mobile;
            }

            return dbGyUser;
        }

        #endregion

        #region 发送钉钉消息

        /// <summary>
        /// 发送钉钉消息,返回错误信息
        /// </summary>
        /// <param name="message">钉钉消息</param>
        /// <param name="mobiles">要发送的钉钉用户手机号码集合</param>
        /// <returns>错误信息</returns>
        public string SendMessage(string message, params string[] mobiles)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentNullException(nameof(message));
            }

            if (mobiles == null || !mobiles.Any())
            {
                throw new ArgumentNullException(nameof(mobiles));
            }
            var error = string.Empty;
            var set = new System.Collections.Generic.HashSet<string>(mobiles);
            var datas = db.DingTalkUser.Where(n => set.Contains(n.mobile)).Select(n => new dduser { mobile = n.mobile, userid = n.userid }).ToArray();
            if (datas.Any())
            {
                var touser = string.Join("|", datas.Select(n => n.userid));
                var corpClient = GetCorpClient();
                var result = corpClient.SendMessage(new SendMessageRequest
                {
                    touser = touser,
                    message = new TextMessage { text = new TextMessageBody { content = message } },
                    agentid = "50287940"//喜喜系统通知的agentid
                });
                if (!string.IsNullOrWhiteSpace(result.invaliduser))
                {
                    var invalidusers = result.invaliduser.Split('|');
                    var invalidMobiles = datas.Where(n => invalidusers.Contains(n.userid));
                    error += $"无效的userid：{Newtonsoft.Json.JsonConvert.SerializeObject(invalidMobiles)};";
                }
                if (!string.IsNullOrWhiteSpace(result.forbiddenUserId))
                {
                    var invalidusers = result.forbiddenUserId.Split('|');
                    var invalidMobiles = datas.Where(n => invalidusers.Contains(n.userid));
                    error += $"因发送消息过于频繁或超量而被流控禁止发送的userid：{Newtonsoft.Json.JsonConvert.SerializeObject(invalidMobiles)};";
                }
            }
            foreach (var data in datas)
            {
                set.Remove(data.mobile);
            }
            if (set.Any())
            {
                error = $"根据手机号码[{string.Join(",", set)}]没有找到钉钉用户;" + error;
            }
            return error;
        }

        class dduser
        {
            public string mobile { get; set; }

            public string userid { get; set; }
        }

        #endregion

        static readonly bool useSes = false;

        public static CorpClient GetCorpClient()
        {
            return useSes ?
                new CorpClient("ding7fa9f03b22d0cff4", "Gf3dbLXynUbmhQjDJxYIW0gm5MWUr9dmM7U90TWD8KlgKcGZQMYXDFtqMhNRGp76") :
                new CorpClient("dinga304e9a0e21eb12835c2f4657eb6378f", "V-CJuamUlvJi-0kMofpvgLr12j3jU5aaC7ZnwVuKkBjjENguEmTHNtCt5s2lF5bu");
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using OUDAL.ModelBase;
using OUDAL.BLL;
namespace OUDAL
{
    public partial class GuYuanKaoQinBLL
    {
        private Context db = new Context();

        public GuYuanKaoQin UpdateSingle(int id, GuYuanKaoQinReq data)
        {
            GuYuanKaoQin model = db.GuYuanKaoQin.Find(id);
            SetGuYuanKaoQin(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public GuYuanKaoQin SetGuYuanKaoQin(GuYuanKaoQin model, GuYuanKaoQinReq data)
        {
            if (data.guyuanId != null) model.guyuanId = data.guyuanId.Value;
            if (!string.IsNullOrEmpty(data.guyuanName)) model.guyuanName = data.guyuanName;
            if (data.workDate != null && data.workDate != DateTime.MinValue && data.workDate != SqlDateTime.MinValue.Value) model.workDate = data.workDate.Value;
            if (!string.IsNullOrEmpty(data.checkType)) model.checkType = data.checkType;
            if (!string.IsNullOrEmpty(data.checkResult)) model.checkResult = data.checkResult;
            if (data.checkTime != null && data.checkTime != DateTime.MinValue && data.checkTime != SqlDateTime.MinValue.Value) model.checkTime = data.checkTime.Value;

            return model;
        }

        /// <summary>
        /// 查询GuYuanKaoQin
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<GuYuanKaoQin> SearchList(GuYuanKaoQinReq req)
        {
            var query = from source in db.GuYuanKaoQin select source;
            if (req.guyuanId != null) query = query.Where(d => d.guyuanId == req.guyuanId);
            if (!string.IsNullOrEmpty(req.guyuanName)) query = query.Where(d => d.guyuanName.Contains(req.guyuanName));
            if (req.workDateStart != DateTime.MinValue && req.workDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.workDate >= req.workDateStart); if (req.workDateEnd != DateTime.MinValue && req.workDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime workDateTemp = req.workDateEnd.AddDays(1);
                query = query.Where(d => d.workDate < workDateTemp);
            }
            if (!string.IsNullOrEmpty(req.checkType)) query = query.Where(d => d.checkType.Contains(req.checkType));
            if (!string.IsNullOrEmpty(req.checkResult)) query = query.Where(d => d.checkResult.Contains(req.checkResult));
            if (req.checkTimeStart != DateTime.MinValue && req.checkTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.checkTime >= req.checkTimeStart); if (req.checkTimeEnd != DateTime.MinValue && req.checkTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime checkTimeTemp = req.checkTimeEnd.AddDays(1);
                query = query.Where(d => d.checkTime < checkTimeTemp);
            }
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<GuYuanKaoQin> retListResult = query.ToSearchList(req);
            return retListResult;
        }

        public SearchListResult<GuYuanMonthKaoQin> SearchMonthList(GuYuanKaoQinReq req)
        {
            var now = DateTime.Now;
            DateTime startDate = Convert.ToDateTime(now.Year + "-" + now.Month + "-01");
            if (!string.IsNullOrWhiteSpace(req.Month))
            {
                startDate = Convert.ToDateTime(req.Month + "-01");
            }
            DateTime endDate = startDate.AddMonths(1);

            GuYuanUserReq gyReq = new GuYuanUserReq();
            gyReq.Name = req.guyuanName;
            var query = from source in db.GuYuanUser
                        select source;
            if (!string.IsNullOrEmpty(req.guyuanName)) query = query.Where(d => d.Name.Contains(req.guyuanName));

            if (req.rows == 0)
            {
                req.rows = 100000;
            }
            if (req.page <= 0)
            {
                req.page = 1;
            }

            SearchListResult<GuYuanUser> gyList = new SearchListResult<GuYuanUser>();
            gyList.records = query.Count();
            gyList.rows = query.ToList().Skip((req.page - 1) * req.rows).Take(req.rows).ToList();
            gyList.page = req.page;
            gyList.total = (gyList.records - 1) / req.rows + 1;

            List<GuYuanMonthKaoQin> monthKaoqinList = new List<GuYuanMonthKaoQin>();

            var kqList = db.GuYuanKaoQin.Where(x => x.workDate >= startDate && x.workDate < endDate);

            foreach (var item in gyList.rows)
            {
                var guYuanId = item.id;
                var guYuanName = item.Name;
                var chidaoFenZhong = 0;
                var chidaoCiShu = 0;
                var chidaolongCiShu = 0;
                var zaotuiFenZhong = 0;
                var zaotuiCiShu = 0;
                var zaotuilongCiShu = 0;
                var kuanggongFenZhong = 0;
                var kuanggongCiShu = 0;
                var externalId = "";
                var KuangGongGongShi = 0;
                var kqListByGY = kqList.Where(x => x.guyuanId == item.id).ToList();

                var kqList2 = kqListByGY.Where(x => x.checkResult == "迟到" || x.checkResult == "早退").ToList();
                foreach (var kq in kqList2)
                {
                    DateTime wDate = Convert.ToDateTime(kq.workDate);
                    DateTime shangbanDate = Convert.ToDateTime(wDate.ToString("yyyy-MM-dd") + " 09:00:00");
                    DateTime xiabanDate = Convert.ToDateTime(wDate.ToString("yyyy-MM-dd") + " 18:00:00");
                    if (kq.checkResult == "迟到")
                    {
                        if ((Convert.ToDateTime(kq.checkTime) - shangbanDate).TotalMinutes > 30)
                        {
                            chidaolongCiShu += 1;
                        }
                        else
                        {
                            chidaoCiShu += 1;
                        }


                        chidaoFenZhong += (int)(Convert.ToDateTime(kq.checkTime) - shangbanDate).TotalMinutes;
                    }
                    else if (kq.checkResult == "早退")
                    {
                        if ((xiabanDate - Convert.ToDateTime(kq.checkTime)).TotalMinutes > 30)
                        {
                            zaotuilongCiShu += 1;
                        }
                        else
                        {
                            zaotuiCiShu += 1;
                        }
                        zaotuiFenZhong += (int)(xiabanDate - Convert.ToDateTime(kq.checkTime)).TotalMinutes;
                    }
                    externalId = kq.externalId;
                }

                kqList2 = kqListByGY.Where(x => x.checkResult == "未打卡").OrderBy(x => x.workDate).ToList();
                string oldDate = string.Empty;
                kqList2.ForEach(d =>
                {
                    string newDate = Convert.ToDateTime(d.workDate).ToString("yyyy-MM-dd");
                    if (oldDate != newDate)
                    {
                        var kq = kqList2.FirstOrDefault(x => x.workDate == d.workDate && x.id != d.id);
                        if (kq == null)
                        {
                            if (d.checkType == "上班")
                            {
                                chidaolongCiShu += 1;
                            }
                            else
                            {
                                zaotuilongCiShu += 1;
                            }
                        }
                        else
                        {
                            kuanggongCiShu += 1;
                        }
                        oldDate = newDate;
                    }
                    else
                    {

                    }
                });
                GuYuanMonthKaoQin monthKaoqin = new GuYuanMonthKaoQin
                {
                    guyuanId = guYuanId,
                    guyuanName = guYuanName,
                    ChiDaoCiShu = chidaoCiShu,
                    ChiDaoFenzhong = chidaoFenZhong,
                    ZaoTuiCiShu = zaotuiCiShu,
                    ZaoTuiFenzhong = zaotuiFenZhong,
                    KuangGongCiShu = kuanggongCiShu,
                    KuangGongGongShi = kuanggongCiShu * 8,
                    Month = startDate.Year + "-" + startDate.Month,
                    externalId = externalId,
                    ChiDaoLongCiShu = chidaolongCiShu,
                    ZaoTuiLongCiShu = zaotuilongCiShu
                };
                monthKaoqinList.Add(monthKaoqin);
            }

            SearchListResult<GuYuanMonthKaoQin> retListResult = new SearchListResult<GuYuanMonthKaoQin>();
            retListResult.records = gyList.records;
            retListResult.rows = monthKaoqinList;
            retListResult.page = gyList.page;
            retListResult.total = gyList.total;
            return retListResult;
        }
    }
}

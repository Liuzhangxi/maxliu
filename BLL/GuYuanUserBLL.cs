


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
    public partial class GuYuanUserBLL
    {
        private Context db = new Context();

        public GuYuanUser UpdateSingle(int id, GuYuanUserReq data)
        {
            GuYuanUser model = db.GuYuanUser.Find(id);
            SetGuYuanUser(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public GuYuanUser SetGuYuanUser(GuYuanUser model, GuYuanUserReq data)
        {
            if (!string.IsNullOrEmpty(data.DepartmentName)) model.DepartmentName = data.DepartmentName;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (data.createdate != null && data.createdate != DateTime.MinValue && data.createdate != SqlDateTime.MinValue.Value) model.createdate = data.createdate.Value;
            if (!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
            if (!string.IsNullOrEmpty(data.PositionName)) model.PositionName = data.PositionName;
            if (!string.IsNullOrEmpty(data.Sex)) model.Sex = data.Sex;
            if (data.OnboardDate != null && data.OnboardDate != DateTime.MinValue && data.OnboardDate != SqlDateTime.MinValue.Value) model.OnboardDate = data.OnboardDate.Value;
            if (data.FullMemberDate != null && data.FullMemberDate != DateTime.MinValue && data.FullMemberDate != SqlDateTime.MinValue.Value) model.FullMemberDate = data.FullMemberDate.Value;
            if (!string.IsNullOrEmpty(data.Nationality)) model.Nationality = data.Nationality;
            if (!string.IsNullOrEmpty(data.Polity)) model.Polity = data.Polity;
            if (data.Birthday != null && data.Birthday != DateTime.MinValue && data.Birthday != SqlDateTime.MinValue.Value) model.Birthday = data.Birthday.Value;
            if (!string.IsNullOrEmpty(data.IDCard)) model.IDCard = data.IDCard;
            if (data.Age != null) model.Age = data.Age.Value;
            if (!string.IsNullOrEmpty(data.Phone)) model.Phone = data.Phone;
            if (!string.IsNullOrEmpty(data.Marry)) model.Marry = data.Marry;
            if (!string.IsNullOrEmpty(data.Education)) model.Education = data.Education;
            if (!string.IsNullOrEmpty(data.EmergencyName)) model.EmergencyName = data.EmergencyName;
            if (!string.IsNullOrEmpty(data.EmergencyRelation)) model.EmergencyRelation = data.EmergencyRelation;
            if (!string.IsNullOrEmpty(data.EmergencyPhone)) model.EmergencyPhone = data.EmergencyPhone;
            if (!string.IsNullOrEmpty(data.YongGongType)) model.YongGongType = data.YongGongType;
            if (data.ContractExpireDate != null && data.ContractExpireDate != DateTime.MinValue && data.ContractExpireDate != SqlDateTime.MinValue.Value) model.ContractExpireDate = data.ContractExpireDate.Value;
            if (data.ContractMoney != null) model.ContractMoney = data.ContractMoney.Value;
            if (!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;
            if (!string.IsNullOrEmpty(data.HuJi)) model.HuJi = data.HuJi;
            if (!string.IsNullOrEmpty(data.CurrentLiving)) model.CurrentLiving = data.CurrentLiving;
            if (!string.IsNullOrEmpty(data.HuJiLiving)) model.HuJiLiving = data.HuJiLiving;
            if (!string.IsNullOrEmpty(data.HuJiType)) model.HuJiType = data.HuJiType;
            if (!string.IsNullOrEmpty(data.SheBaoType)) model.SheBaoType = data.SheBaoType;
            if (data.BaseSheBaoMoney != null) model.BaseSheBaoMoney = data.BaseSheBaoMoney.Value;
            if (data.SheBaoStartDate != null && data.SheBaoStartDate != DateTime.MinValue && data.SheBaoStartDate != SqlDateTime.MinValue.Value) model.SheBaoStartDate = data.SheBaoStartDate.Value;
            if (!string.IsNullOrEmpty(data.GongJiJingNumber)) model.GongJiJingNumber = data.GongJiJingNumber;
            if (!string.IsNullOrEmpty(data.HeTongQiXian)) model.HeTongQiXian = data.HeTongQiXian;
            if (!string.IsNullOrEmpty(data.WorkAge)) model.WorkAge = data.WorkAge;
            if (!string.IsNullOrEmpty(data.BankCard)) model.BankCard = data.BankCard;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (!string.IsNullOrEmpty(data.FuZhuangChiCun)) model.FuZhuangChiCun = data.FuZhuangChiCun;
            if (!string.IsNullOrEmpty(data.XieMa)) model.XieMa = data.XieMa;
            if (data.JinShengDate != null && data.JinShengDate != DateTime.MinValue && data.JinShengDate != SqlDateTime.MinValue.Value) model.JinShengDate = data.JinShengDate.Value;
            if (data.LiZhiDate != null && data.LiZhiDate != DateTime.MinValue && data.LiZhiDate != SqlDateTime.MinValue.Value) model.LiZhiDate = data.LiZhiDate.Value;

            return model;
        }

        /// <summary>
        /// 查询GuYuanUser
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<GuYuanUser> SearchList(GuYuanUserReq req)
        {
            var query = from source in db.GuYuanUser
                        select source;
            if (!string.IsNullOrEmpty(req.DepartmentName)) query = query.Where(d => d.DepartmentName.Contains(req.DepartmentName));
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (req.createdateStart != DateTime.MinValue && req.createdateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateStart);
            if (req.createdateEnd != DateTime.MinValue && req.createdateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate <= req.createdateEnd);
            if (!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
            if (!string.IsNullOrEmpty(req.PositionName)) query = query.Where(d => d.PositionName.Contains(req.PositionName));
            if (!string.IsNullOrEmpty(req.Sex)) query = query.Where(d => d.Sex.Contains(req.Sex));
            if (req.OnboardDateStart != DateTime.MinValue && req.OnboardDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.OnboardDate >= req.OnboardDateStart);
            if (req.OnboardDateEnd != DateTime.MinValue && req.OnboardDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.OnboardDate <= req.OnboardDateEnd);
            if (req.FullMemberDateStart != DateTime.MinValue && req.FullMemberDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.FullMemberDate >= req.FullMemberDateStart);
            if (req.FullMemberDateEnd != DateTime.MinValue && req.FullMemberDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.FullMemberDate <= req.FullMemberDateEnd);
            if (!string.IsNullOrEmpty(req.Nationality)) query = query.Where(d => d.Nationality.Contains(req.Nationality));
            if (!string.IsNullOrEmpty(req.Polity)) query = query.Where(d => d.Polity.Contains(req.Polity));
            if (req.BirthdayStart != DateTime.MinValue && req.BirthdayStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.Birthday >= req.BirthdayStart);
            if (req.BirthdayEnd != DateTime.MinValue && req.BirthdayEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.Birthday <= req.BirthdayEnd);
            if (!string.IsNullOrEmpty(req.IDCard)) query = query.Where(d => d.IDCard.Contains(req.IDCard));
            if (req.Age != null) query = query.Where(d => d.Age == req.Age);
            if (!string.IsNullOrEmpty(req.Phone)) query = query.Where(d => d.Phone.Contains(req.Phone));
            if (!string.IsNullOrEmpty(req.Marry)) query = query.Where(d => d.Marry.Contains(req.Marry));
            if (!string.IsNullOrEmpty(req.Education)) query = query.Where(d => d.Education.Contains(req.Education));
            if (!string.IsNullOrEmpty(req.EmergencyName)) query = query.Where(d => d.EmergencyName.Contains(req.EmergencyName));
            if (!string.IsNullOrEmpty(req.EmergencyRelation)) query = query.Where(d => d.EmergencyRelation.Contains(req.EmergencyRelation));
            if (!string.IsNullOrEmpty(req.EmergencyPhone)) query = query.Where(d => d.EmergencyPhone.Contains(req.EmergencyPhone));
            if (!string.IsNullOrEmpty(req.YongGongType)) query = query.Where(d => d.YongGongType.Contains(req.YongGongType));
            if (req.ContractExpireDateStart != DateTime.MinValue && req.ContractExpireDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ContractExpireDate >= req.ContractExpireDateStart);
            if (req.ContractExpireDateEnd != DateTime.MinValue && req.ContractExpireDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ContractExpireDate <= req.ContractExpireDateEnd);
            if (req.ContractMoney != null) query = query.Where(d => d.ContractMoney == req.ContractMoney);
            if (!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));
            if (!string.IsNullOrEmpty(req.HuJi)) query = query.Where(d => d.HuJi.Contains(req.HuJi));
            if (!string.IsNullOrEmpty(req.CurrentLiving)) query = query.Where(d => d.CurrentLiving.Contains(req.CurrentLiving));
            if (!string.IsNullOrEmpty(req.HuJiLiving)) query = query.Where(d => d.HuJiLiving.Contains(req.HuJiLiving));
            if (!string.IsNullOrEmpty(req.HuJiType)) query = query.Where(d => d.HuJiType.Contains(req.HuJiType));
            if (!string.IsNullOrEmpty(req.SheBaoType)) query = query.Where(d => d.SheBaoType.Contains(req.SheBaoType));
            if (req.BaseSheBaoMoney != null) query = query.Where(d => d.BaseSheBaoMoney == req.BaseSheBaoMoney);
            if (req.SheBaoStartDateStart != DateTime.MinValue && req.SheBaoStartDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.SheBaoStartDate >= req.SheBaoStartDateStart);
            if (req.SheBaoStartDateEnd != DateTime.MinValue && req.SheBaoStartDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.SheBaoStartDate <= req.SheBaoStartDateEnd);
            if (!string.IsNullOrEmpty(req.GongJiJingNumber)) query = query.Where(d => d.GongJiJingNumber.Contains(req.GongJiJingNumber));
            if (!string.IsNullOrEmpty(req.HeTongQiXian)) query = query.Where(d => d.HeTongQiXian.Contains(req.HeTongQiXian));
            if (!string.IsNullOrEmpty(req.WorkAge)) query = query.Where(d => d.WorkAge.Contains(req.WorkAge));
            if (!string.IsNullOrEmpty(req.BankCard)) query = query.Where(d => d.BankCard.Contains(req.BankCard));
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.projectid == req.projectid);
            if (!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (!string.IsNullOrEmpty(req.FuZhuangChiCun)) query = query.Where(d => d.FuZhuangChiCun.Contains(req.FuZhuangChiCun));
            if (!string.IsNullOrEmpty(req.XieMa)) query = query.Where(d => d.XieMa.Contains(req.XieMa));
            if (req.JinShengDateStart != DateTime.MinValue && req.JinShengDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.JinShengDate >= req.JinShengDateStart);
            if (req.JinShengDateEnd != DateTime.MinValue && req.JinShengDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.JinShengDate <= req.JinShengDateEnd);
            if (req.LiZhiDateStart != DateTime.MinValue && req.LiZhiDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.LiZhiDate >= req.LiZhiDateStart);
            if (req.LiZhiDateEnd != DateTime.MinValue && req.LiZhiDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.LiZhiDate <= req.LiZhiDateEnd);


            if (req.projectid == 0)
            {
                var depList = db.Departments.Where(x => x.DepartmentType == "加盟店").ToList();
                List<int> depIds = new List<int>();

                foreach (var dep in depList) {
                    depIds.Add(dep.Id);
                }

                query = query.Where(x => !depIds.Contains((int)x.projectid));
            }

            if (req.isHr == 0)
            {
                query = query.Where(d => d.DepartmentName.Contains("护理部"));
            }
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<GuYuanUser> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

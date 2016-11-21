


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
    public partial class MenDianFeeBLL
    {
        private Context db = new Context();

        public MenDianFee UpdateSingle(int id, MenDianFeeReq data)
        {
            MenDianFee model = db.MenDianFee.Find(id);
            SetMenDianFee(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="model"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public MenDianFee SetMenDianFee(MenDianFee model, MenDianFeeReq data)
        {
            if (data.feiYongMoney != null) model.feiYongMoney = data.feiYongMoney.Value;
            if (!string.IsNullOrEmpty(data.info)) model.info = data.info;
            if (data.payDate != null && data.payDate != DateTime.MinValue && data.payDate != SqlDateTime.MinValue.Value) model.payDate = data.payDate.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optId != null) model.optId = data.optId.Value;
            if (data.createdate != null && data.createdate != DateTime.MinValue && data.createdate != SqlDateTime.MinValue.Value) model.createdate = data.createdate.Value;
            if (!string.IsNullOrEmpty(data.checkName)) model.checkName = data.checkName;
            if (data.checkId != null) model.checkId = data.checkId.Value;
            if (data.checkDate != null && data.checkDate != DateTime.MinValue && data.checkDate != SqlDateTime.MinValue.Value) model.checkDate = data.checkDate.Value;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.projectName)) model.projectName = data.projectName;
            if (!string.IsNullOrEmpty(data.category)) model.category = data.category;
            if (!string.IsNullOrEmpty(data.fkFangShi)) model.fkFangShi = data.fkFangShi;

            if (data.JiaoGeId != null) model.JiaoGeId = data.JiaoGeId.Value;
            
            return model;
        }

        /// <summary>
        /// 查询MenDianFee
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<MenDianFee> SearchList(MenDianFeeReq req)
        {
            var query = from source in db.MenDianFee select source;
            if (req.feiYongMoney != null) query = query.Where(d => d.feiYongMoney == req.feiYongMoney);
            if (!string.IsNullOrEmpty(req.info)) query = query.Where(d => d.info.Contains(req.info));
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optId != null) query = query.Where(d => d.optId == req.optId);
            if (req.JiaoGeId != null) query = query.Where(d => d.JiaoGeId == req.JiaoGeId);
            if (req.createdateStart != DateTime.MinValue && req.createdateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.createdate >= req.createdateStart);
            if (req.createdateEnd != DateTime.MinValue && req.createdateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime createdateTemp = req.createdateEnd.AddDays(1);
                query = query.Where(d => d.createdate < createdateTemp);
            }
            //收款时间
            if (req.payDateStart != DateTime.MinValue && req.payDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.payDate >= req.payDateStart);
            if (req.payDateEnd != DateTime.MinValue && req.payDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime payDateTemp = req.payDateEnd.AddDays(1);
                query = query.Where(d => d.payDate < payDateTemp);
            }


            if (!string.IsNullOrEmpty(req.checkName)) query = query.Where(d => d.checkName.Contains(req.checkName));
            if (req.checkId != null) query = query.Where(d => d.checkId == req.checkId);
            if (req.checkDateStart != DateTime.MinValue && req.checkDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.checkDate >= req.checkDateStart); if (req.checkDateEnd != DateTime.MinValue && req.checkDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime checkDateTemp = req.checkDateEnd.AddDays(1);
                query = query.Where(d => d.checkDate < checkDateTemp);
            }
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid != null && projectids.Contains(d.projectid.Value));
            }
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.projectid == req.projectid); if (!string.IsNullOrEmpty(req.projectName)) query = query.Where(d => d.projectName.Contains(req.projectName));
            if (!string.IsNullOrEmpty(req.category)) query = query.Where(d => d.category.Contains(req.category));
            if (!string.IsNullOrEmpty(req.fkFangShi)) query = query.Where(d => d.fkFangShi.Contains(req.fkFangShi));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<MenDianFee> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

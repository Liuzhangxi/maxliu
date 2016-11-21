


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
    public partial class JiaoGeFeeBLL
    {
        private Context db = new Context();

        public JiaoGeFee UpdateSingle(int id, JiaoGeFeeReq data)
        {
            JiaoGeFee model = db.JiaoGeFee.Find(id);
            SetJiaoGeFee(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JiaoGeFee SetJiaoGeFee(JiaoGeFee model, JiaoGeFeeReq data)
        {
            if (!string.IsNullOrEmpty(data.SearchDateInfo)) model.SearchDateInfo = data.SearchDateInfo;
            if (!string.IsNullOrEmpty(data.ShouKuanInfos)) model.ShouKuanInfos = data.ShouKuanInfos;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (data.CheckerId != null) model.CheckerId = data.CheckerId.Value;
            if (!string.IsNullOrEmpty(data.CheckerName)) model.CheckerName = data.CheckerName;
            if (data.CreaterId != null) model.CreaterId = data.CreaterId.Value;
            if (!string.IsNullOrEmpty(data.CreaterName)) model.CreaterName = data.CreaterName;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (data.CheckDate != null && data.CheckDate != DateTime.MinValue &&
                data.CheckDate != SqlDateTime.MinValue.Value) model.CheckDate = data.CheckDate.Value;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue &&
                data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (data.BeiYongMoney != null) model.BeiYongMoney = data.BeiYongMoney.Value;
            return model;
        }

        /// <summary>
        /// 查询JiaoGeFee
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<JiaoGeFee> SearchList(JiaoGeFeeReq req)
        {
            var query = from source in db.JiaoGeFee select source;
            if (!string.IsNullOrEmpty(req.SearchDateInfo))
                query = query.Where(d => d.SearchDateInfo.Contains(req.SearchDateInfo));
            if (!string.IsNullOrEmpty(req.ShouKuanInfos))
                query = query.Where(d => d.ShouKuanInfos.Contains(req.ShouKuanInfos));
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (req.CheckerId != null) query = query.Where(d => d.CheckerId == req.CheckerId);
            if (!string.IsNullOrEmpty(req.CheckerName))
                query = query.Where(d => d.CheckerName.Contains(req.CheckerName));
            if (req.CreaterId != null) query = query.Where(d => d.CreaterId == req.CreaterId);
            if (!string.IsNullOrEmpty(req.CreaterName))
                query = query.Where(d => d.CreaterName.Contains(req.CreaterName));
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids =
                    req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => Convert.ToInt32(s))
                        .ToList();
                query = query.Where(d => d.projectid != null && projectids.Contains(d.projectid.Value));
            }
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.projectid == req.projectid);
            if (!string.IsNullOrEmpty(req.ProjectName))
                query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (req.CheckDateStart != DateTime.MinValue && req.CheckDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CheckDate >= req.CheckDateStart);
            if (req.CheckDateEnd != DateTime.MinValue && req.CheckDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime CheckDateTemp = req.CheckDateEnd.AddDays(1);
                query = query.Where(d => d.CheckDate < CheckDateTemp);
            }
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateStart);
            if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime CreateDateTemp = req.CreateDateEnd.AddDays(1);
                query = query.Where(d => d.CreateDate < CreateDateTemp);
            }
            if (req.BeiYongMoney != null && req.BeiYongMoney != 0) query = query.Where(d => d.BeiYongMoney == req.BeiYongMoney);

            query = query.Where(d => d.ValidState != "InValid");
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<JiaoGeFee> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

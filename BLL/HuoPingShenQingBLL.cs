


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
    public partial class HuoPingShenQingBLL
    {
        private Context db = new Context();

        public HuoPingShenQing UpdateSingle(int id, HuoPingShenQingReq data)
        {
            HuoPingShenQing model = db.HuoPingShenQing.Find(id);
            SetHuoPingShenQing(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public HuoPingShenQing SetHuoPingShenQing(HuoPingShenQing model, HuoPingShenQingReq data)
        {
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (data.HuoPingCount != null) model.HuoPingCount = data.HuoPingCount.Value;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.OptDateTime != null && data.OptDateTime != DateTime.MinValue && data.OptDateTime != SqlDateTime.MinValue.Value) model.OptDateTime = data.OptDateTime.Value;
            if (!string.IsNullOrEmpty(data.ServerMonth)) model.ServerMonth = data.ServerMonth;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;

            return model;
        }

        /// <summary>
        /// 查询HuoPingShenQing
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingShenQing> SearchList(HuoPingShenQingReq req)
        {
            var query = from source in db.HuoPingShenQing select source;
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid != null && projectids.Contains(d.projectid.Value));
            }
            if (!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (req.HuoPingCount != null) query = query.Where(d => d.HuoPingCount == req.HuoPingCount);
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.OptDateTimeStart != DateTime.MinValue && req.OptDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.OptDateTime >= req.OptDateTimeStart); if (req.OptDateTimeEnd != DateTime.MinValue && req.OptDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime OptDateTimeTemp = req.OptDateTimeEnd.AddDays(1);
                query = query.Where(d => d.OptDateTime < OptDateTimeTemp);
            }
            if (!string.IsNullOrEmpty(req.ServerMonth)) query = query.Where(d => d.ServerMonth.Contains(req.ServerMonth));
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));

            if (req.projectid != null)
            {
                if (req.projectid > 0)
                    query = query.Where(x => x.projectid == req.projectid);
            }


            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<HuoPingShenQing> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

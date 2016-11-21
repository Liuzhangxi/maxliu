


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
    public partial class HeTongServiceModelBLL
    {
        private Context db = new Context();

        public HeTongServiceModel UpdateSingle(int id, HeTongServiceModelReq data)
        {
            HeTongServiceModel model = db.HeTongServiceModel.Find(id);
            SetHeTongServiceModel(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public HeTongServiceModel SetHeTongServiceModel(HeTongServiceModel model, HeTongServiceModelReq data)
        {
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (data.optid != null) model.optid = data.optid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (!string.IsNullOrEmpty(data.state)) model.state = data.state;
            if (!string.IsNullOrEmpty(data.ServerName)) model.ServerName = data.ServerName;
            if (data.lastupdateid != null) model.lastupdateid = data.lastupdateid.Value;
            if (!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;

            return model;
        }

        /// <summary>
        /// 查询HeTongServiceModel
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HeTongServiceModel> SearchList(HeTongServiceModelReq req)
        {
            var query = from source in db.HeTongServiceModel select source;
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid != null && projectids.Contains(d.projectid.Value));
            }
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.projectid == req.projectid); if (!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (req.optid != null) query = query.Where(d => d.optid == req.optid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (!string.IsNullOrEmpty(req.state)) query = query.Where(d => d.state.Contains(req.state));
            if (!string.IsNullOrEmpty(req.ServerName)) query = query.Where(d => d.ServerName.Contains(req.ServerName));
            if (req.lastupdateid != null) query = query.Where(d => d.lastupdateid == req.lastupdateid);
            if (!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<HeTongServiceModel> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

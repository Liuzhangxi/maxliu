


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
    public partial class CanOtherInfoBLL
    { 
        private Context db = new Context();

        public CanOtherInfo UpdateSingle(int id, CanOtherInfoReq data)
        { 
            CanOtherInfo model = db.CanOtherInfo.Find(id);
            SetCanOtherInfo(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  CanOtherInfo SetCanOtherInfo(CanOtherInfo model, CanOtherInfoReq data)
        {
             if(data.ServerDate != null && data.ServerDate != DateTime.MinValue && data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
if(data.JiaWuCanCount != null) model.JiaWuCanCount = data.JiaWuCanCount.Value;
if(data.JiaWanCanCount != null) model.JiaWanCanCount = data.JiaWanCanCount.Value;
if(data.YuanWuCanCount != null) model.YuanWuCanCount = data.YuanWuCanCount.Value;
if(data.YuanWanCanCount != null) model.YuanWanCanCount = data.YuanWanCanCount.Value;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
if(data.Createdate != null && data.Createdate != DateTime.MinValue && data.Createdate != SqlDateTime.MinValue.Value) model.Createdate = data.Createdate.Value;
if(data.optid != null) model.optid = data.optid.Value;
if(!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
 
            return model;
        }

        /// <summary>
        /// 查询CanOtherInfo
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<CanOtherInfo> SearchList(CanOtherInfoReq req)
        {
            var query = from source in db.CanOtherInfo select source;
            if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime ServerDateTemp = req.ServerDateEnd.AddDays(1);
query = query.Where(d => d.ServerDate < ServerDateTemp);}if(req.JiaWuCanCount != null) query = query.Where(d => d.JiaWuCanCount == req.JiaWuCanCount);
if(req.JiaWanCanCount != null) query = query.Where(d => d.JiaWanCanCount == req.JiaWanCanCount);
if(req.YuanWuCanCount != null) query = query.Where(d => d.YuanWuCanCount == req.YuanWuCanCount);
if(req.YuanWanCanCount != null) query = query.Where(d => d.YuanWanCanCount == req.YuanWanCanCount);
 if (!string.IsNullOrEmpty(req.projectids))
            {
                            List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s=>Convert.ToInt32(s)).ToList();
                            query = query.Where(d => d.projectid !=null && projectids.Contains(d.projectid.Value));
            }
if (req.projectid!=null && req.projectid!=0) query = query.Where(d => d.projectid==req.projectid);if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if (req.CreatedateStart != DateTime.MinValue && req.CreatedateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.Createdate >= req.CreatedateStart);if (req.CreatedateEnd != DateTime.MinValue && req.CreatedateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime CreatedateTemp = req.CreatedateEnd.AddDays(1);
query = query.Where(d => d.Createdate < CreatedateTemp);}if(req.optid != null) query = query.Where(d => d.optid == req.optid);
if(!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<CanOtherInfo> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

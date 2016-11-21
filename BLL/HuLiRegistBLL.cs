


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
    public partial class HuLiRegistBLL
    { 
        private Context db = new Context();

        public HuLiRegist UpdateSingle(int id, HuLiRegistReq data)
        { 
            HuLiRegist model = db.HuLiRegist.Find(id);
            SetHuLiRegist(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HuLiRegist SetHuLiRegist(HuLiRegist model, HuLiRegistReq data)
        {
             if(data.StartDate != null && data.StartDate != DateTime.MinValue && data.StartDate != SqlDateTime.MinValue.Value) model.StartDate = data.StartDate.Value;
if(data.EndDate != null && data.EndDate != DateTime.MinValue && data.EndDate != SqlDateTime.MinValue.Value) model.EndDate = data.EndDate.Value;
if(!string.IsNullOrEmpty(data.ServerType)) model.ServerType = data.ServerType;
if(data.PareCount != null) model.PareCount = data.PareCount.Value;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.createdate != null && data.createdate != DateTime.MinValue && data.createdate != SqlDateTime.MinValue.Value) model.createdate = data.createdate.Value;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(data.ServerDate != null && data.ServerDate != DateTime.MinValue && data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
 
            return model;
        }

        /// <summary>
        /// 查询HuLiRegist
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuLiRegist> SearchList(HuLiRegistReq req)
        {
            var query = from source in db.HuLiRegist select source;
            if (req.StartDateStart != DateTime.MinValue && req.StartDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.StartDate >= req.StartDateStart);
if (req.StartDateEnd != DateTime.MinValue && req.StartDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.StartDate <= req.StartDateEnd);
if (req.EndDateStart != DateTime.MinValue && req.EndDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.EndDate >= req.EndDateStart);
if (req.EndDateEnd != DateTime.MinValue && req.EndDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.EndDate <= req.EndDateEnd);
if(!string.IsNullOrEmpty(req.ServerType)) query = query.Where(d => d.ServerType.Contains(req.ServerType));
if(req.PareCount != null) query = query.Where(d => d.PareCount == req.PareCount);
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.createdateStart != DateTime.MinValue && req.createdateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateStart);
if (req.createdateEnd != DateTime.MinValue && req.createdateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate <= req.createdateEnd);
 if (!string.IsNullOrEmpty(req.projectids))
{
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s=>Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid !=null && projectids.Contains(d.projectid.Value));
}if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);
if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate <= req.ServerDateEnd);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HuLiRegist> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

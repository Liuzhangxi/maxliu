


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
    public partial class KeRenPeiCanBLL
    { 
        private Context db = new Context();

        public KeRenPeiCan UpdateSingle(int id, KeRenPeiCanReq data)
        { 
            KeRenPeiCan model = db.KeRenPeiCan.Find(id);
            SetKeRenPeiCan(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  KeRenPeiCan SetKeRenPeiCan(KeRenPeiCan model, KeRenPeiCanReq data)
        {
             if(!string.IsNullOrEmpty(data.CaiPuIds)) model.CaiPuIds = data.CaiPuIds;
if(data.DietSpecialId != null) model.DietSpecialId = data.DietSpecialId.Value;
if(!string.IsNullOrEmpty(data.LunchSpecial)) model.LunchSpecial = data.LunchSpecial;
if(!string.IsNullOrEmpty(data.SupperSpecial)) model.SupperSpecial = data.SupperSpecial;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.OptId != null) model.OptId = data.OptId.Value;
 
            return model;
        }

        /// <summary>
        /// 查询KeRenPeiCan
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<KeRenPeiCan> SearchList(KeRenPeiCanReq req)
        {
            var query = from source in db.KeRenPeiCan select source;
            if(!string.IsNullOrEmpty(req.CaiPuIds)) query = query.Where(d => d.CaiPuIds.Contains(req.CaiPuIds));
if(req.DietSpecialId != null) query = query.Where(d => d.DietSpecialId == req.DietSpecialId);
if(!string.IsNullOrEmpty(req.LunchSpecial)) query = query.Where(d => d.LunchSpecial.Contains(req.LunchSpecial));
if(!string.IsNullOrEmpty(req.SupperSpecial)) query = query.Where(d => d.SupperSpecial.Contains(req.SupperSpecial));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<KeRenPeiCan> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}




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
    public partial class HeTongServiceBLL
    { 
        private Context db = new Context();

        public HeTongService UpdateSingle(int id, HeTongServiceReq data)
        { 
            HeTongService model = db.HeTongService.Find(id);
            SetHeTongService(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HeTongService SetHeTongService(HeTongService model, HeTongServiceReq data)
        {
             if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(data.ServerCount != null) model.ServerCount = data.ServerCount.Value;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(!string.IsNullOrEmpty(data.CreateName)) model.CreateName = data.CreateName;
if(data.CreateId != null) model.CreateId = data.CreateId.Value;
if(!string.IsNullOrEmpty(data.UpdateUserName)) model.UpdateUserName = data.UpdateUserName;
if(data.UpdateUserId != null) model.UpdateUserId = data.UpdateUserId.Value;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(data.UpdateDate != null && data.UpdateDate != DateTime.MinValue && data.UpdateDate != SqlDateTime.MinValue.Value) model.UpdateDate = data.UpdateDate.Value;
if(data.HeTongId != null) model.HeTongId = data.HeTongId.Value;
if(!string.IsNullOrEmpty(data.HeTongNumber)) model.HeTongNumber = data.HeTongNumber;
if(!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;
 
            return model;
        }

        /// <summary>
        /// 查询HeTongService
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HeTongService> SearchList(HeTongServiceReq req)
        {
            var query = from source in db.HeTongService select source;
            if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(req.ServerCount != null) query = query.Where(d => d.ServerCount == req.ServerCount);
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime CreateDateTemp = req.CreateDateEnd.AddDays(1);
query = query.Where(d => d.CreateDate < CreateDateTemp);}if(!string.IsNullOrEmpty(req.CreateName)) query = query.Where(d => d.CreateName.Contains(req.CreateName));
if(req.CreateId != null) query = query.Where(d => d.CreateId == req.CreateId);
if(!string.IsNullOrEmpty(req.UpdateUserName)) query = query.Where(d => d.UpdateUserName.Contains(req.UpdateUserName));
if(req.UpdateUserId != null) query = query.Where(d => d.UpdateUserId == req.UpdateUserId);
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if (req.UpdateDateStart != DateTime.MinValue && req.UpdateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.UpdateDate >= req.UpdateDateStart);if (req.UpdateDateEnd != DateTime.MinValue && req.UpdateDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime UpdateDateTemp = req.UpdateDateEnd.AddDays(1);
query = query.Where(d => d.UpdateDate < UpdateDateTemp);}if(req.HeTongId != null) query = query.Where(d => d.HeTongId == req.HeTongId);
if(!string.IsNullOrEmpty(req.HeTongNumber)) query = query.Where(d => d.HeTongNumber.Contains(req.HeTongNumber));
if(!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HeTongService> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

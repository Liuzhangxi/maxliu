


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
    public partial class KeMuBLL
    { 
        private Context db = new Context();

        public KeMu UpdateSingle(int id, KeMuReq data)
        { 
            KeMu model = db.KeMu.Find(id);
            SetKeMu(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  KeMu SetKeMu(KeMu model, KeMuReq data)
        {
             if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
 
            return model;
        }

        /// <summary>
        /// 查询KeMu
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<KeMu> SearchList(KeMuReq req)
        {
            var query = from source in db.KeMu select source;
            if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime CreateDateTemp = req.CreateDateEnd.AddDays(1);
query = query.Where(d => d.CreateDate < CreateDateTemp);}if(!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState.Contains(req.ValidState));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<KeMu> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

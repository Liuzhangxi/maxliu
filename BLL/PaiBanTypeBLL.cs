


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
    public partial class PaiBanTypeBLL
    { 
        private Context db = new Context();

        public PaiBanType UpdateSingle(int id, PaiBanTypeReq data)
        { 
            PaiBanType model = db.PaiBanType.Find(id);
            SetPaiBanType(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  PaiBanType SetPaiBanType(PaiBanType model, PaiBanTypeReq data)
        {
             if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(data.Hours != null) model.Hours = data.Hours.Value;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
if(data.FromHour != null) model.FromHour = data.FromHour.Value;
if(data.ToHour != null) model.ToHour = data.ToHour.Value;
if(!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
 
            return model;
        }

        /// <summary>
        /// 查询PaiBanType
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<PaiBanType> SearchList(PaiBanTypeReq req)
        {
            var query = from source in db.PaiBanType select source;
            if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(req.Hours != null) query = query.Where(d => d.Hours == req.Hours);
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectid == req.projectid);
if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if(req.FromHour != null) query = query.Where(d => d.FromHour == req.FromHour);
if(req.ToHour != null) query = query.Where(d => d.ToHour == req.ToHour);
if(!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState==req.ValidState);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<PaiBanType> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

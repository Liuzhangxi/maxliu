


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
    public partial class CaipuModelBLL
    { 
        private Context db = new Context();

        public CaipuModel UpdateSingle(int id, CaipuModelReq data)
        { 
            CaipuModel model = db.CaipuModel.Find(id);
            SetCaipuModel(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  CaipuModel SetCaipuModel(CaipuModel model, CaipuModelReq data)
        {
             if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(!string.IsNullOrEmpty(data.CaiType)) model.CaiType = data.CaiType;
if(!string.IsNullOrEmpty(data.CanType)) model.CanType = data.CanType;
if(data.Step != null) model.Step = data.Step.Value;
//if(!string.IsNullOrEmpty(data.Peiliao))
                model.Peiliao = data.Peiliao;
if(!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(!string.IsNullOrEmpty(data.Type)) model.Type = data.Type;
if(!string.IsNullOrEmpty(data.ServerWeekDay)) model.ServerWeekDay = data.ServerWeekDay;

//if(!string.IsNullOrEmpty(data.Gongxiao))
                model.Gongxiao = data.Gongxiao;
            if (data.TypeId != null) model.TypeId = data.TypeId.Value;
            
            return model;
        }

        /// <summary>
        /// 查询CaipuModel
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<CaipuModel> SearchList(CaipuModelReq req)
        {
            var query = from source in db.CaipuModel select source;
            if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(!string.IsNullOrEmpty(req.CaiType)) query = query.Where(d => d.CaiType.Contains(req.CaiType));
if(!string.IsNullOrEmpty(req.CanType)) query = query.Where(d => d.CanType.Contains(req.CanType));
if(req.Step != null) query = query.Where(d => d.Step == req.Step);
if(!string.IsNullOrEmpty(req.Peiliao)) query = query.Where(d => d.Peiliao.Contains(req.Peiliao));
if(!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState.Contains(req.ValidState));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(!string.IsNullOrEmpty(req.Type)) query = query.Where(d => d.Type.Contains(req.Type));
if(!string.IsNullOrEmpty(req.ServerWeekDay)) query = query.Where(d => d.ServerWeekDay.Contains(req.ServerWeekDay));
if(!string.IsNullOrEmpty(req.Gongxiao)) query = query.Where(d => d.Gongxiao.Contains(req.Gongxiao));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<CaipuModel> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

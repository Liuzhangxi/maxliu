


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
    public partial class CaipuModelTypeBLL
    { 
        private Context db = new Context();

        public CaipuModelType UpdateSingle(int id, CaipuModelTypeReq data)
        { 
            CaipuModelType model = db.CaipuModelType.Find(id);
            SetCaipuModelType(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  CaipuModelType SetCaipuModelType(CaipuModelType model, CaipuModelTypeReq data)
        {
             if(!string.IsNullOrEmpty(data.TypeName)) model.TypeName = data.TypeName;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.createdate != null && data.createdate != DateTime.MinValue && data.createdate != SqlDateTime.MinValue.Value) model.createdate = data.createdate.Value;
if(!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
 
            return model;
        }

        /// <summary>
        /// 查询CaipuModelType
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<CaipuModelType> SearchList(CaipuModelTypeReq req)
        {
            var query = from source in db.CaipuModelType select source;
            if(!string.IsNullOrEmpty(req.TypeName)) query = query.Where(d => d.TypeName.Contains(req.TypeName));
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectid == req.projectid);
if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.createdateStart != DateTime.MinValue && req.createdateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateStart);
if (req.createdateEnd != DateTime.MinValue && req.createdateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateEnd);
if(!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState.Contains(req.ValidState));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<CaipuModelType> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

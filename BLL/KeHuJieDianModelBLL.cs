


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
    public partial class KeHuJieDianModelBLL
    { 
        private Context db = new Context();

        public KeHuJieDianModel UpdateSingle(int id, KeHuJieDianModelReq data)
        { 
            KeHuJieDianModel model = db.KeHuJieDianModel.Find(id);
            SetKeHuJieDianModel(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  KeHuJieDianModel SetKeHuJieDianModel(KeHuJieDianModel model, KeHuJieDianModelReq data)
        {
             if(data.JdClassID != null) model.JdClassID = data.JdClassID.Value;
if(!string.IsNullOrEmpty(data.JdName)) model.JdName = data.JdName;
if(data.JdPaiXu != null) model.JdPaiXu = data.JdPaiXu.Value;
if(data.JdStateID != null) model.JdStateID = data.JdStateID.Value;
if(!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
if(data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
if(!string.IsNullOrEmpty(data.KeHuUploadFileState)) model.KeHuUploadFileState = data.KeHuUploadFileState;
if(!string.IsNullOrEmpty(data.JdSpecialState)) model.JdSpecialState = data.JdSpecialState;
 
            return model;
        }

        /// <summary>
        /// 查询KeHuJieDianModel
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<KeHuJieDianModel> SearchList(KeHuJieDianModelReq req)
        {
            var query = from source in db.KeHuJieDianModel select source;
            if(req.JdClassID != null) query = query.Where(d => d.JdClassID == req.JdClassID);
if(!string.IsNullOrEmpty(req.JdName)) query = query.Where(d => d.JdName.Contains(req.JdName));
if(req.JdPaiXu != null) query = query.Where(d => d.JdPaiXu == req.JdPaiXu);
if(req.JdStateID != null) query = query.Where(d => d.JdStateID == req.JdStateID);
if(!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart);if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value) 
{
 DateTime optDateTimeTemp = req.optDateTimeEnd.AddDays(1);
query = query.Where(d => d.optDateTime < optDateTimeTemp);}if(!string.IsNullOrEmpty(req.KeHuUploadFileState)) query = query.Where(d => d.KeHuUploadFileState.Contains(req.KeHuUploadFileState));
if(!string.IsNullOrEmpty(req.JdSpecialState)) query = query.Where(d => d.JdSpecialState.Contains(req.JdSpecialState));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<KeHuJieDianModel> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

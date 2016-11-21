


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
    public partial class JmsFileBLL
    { 
        private Context db = new Context();

        public JmsFile UpdateSingle(int id, JmsFileReq data)
        { 
            JmsFile model = db.JmsFile.Find(id);
            SetJmsFile(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  JmsFile SetJmsFile(JmsFile model, JmsFileReq data)
        {
             if(data.DirectoryId != null) model.DirectoryId = data.DirectoryId.Value;
if(!string.IsNullOrEmpty(data.DirectoryName)) model.DirectoryName = data.DirectoryName;
if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(!string.IsNullOrEmpty(data.ZhengLiState)) model.ZhengLiState = data.ZhengLiState;
if(data.OptDateTime != null && data.OptDateTime != DateTime.MinValue && data.OptDateTime != SqlDateTime.MinValue.Value) model.OptDateTime = data.OptDateTime.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(data.JmsId != null) model.JmsId = data.JmsId.Value;
if(!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
if(!string.IsNullOrEmpty(data.FileAbsolutePath)) model.FileAbsolutePath = data.FileAbsolutePath;
if(!string.IsNullOrEmpty(data.FileRelatePath)) model.FileRelatePath = data.FileRelatePath;
if(!string.IsNullOrEmpty(data.Type)) model.Type = data.Type;
 
            return model;
        }

        //private SearchListResult<Z> SearchList<T,Z>(T dic)
        //{
        //    Type t = typeof(T);
        //    T entity = new T();
        //    var fields = t.GetProperties();

        //    string val = string.Empty;
        //    object obj = null;
        //    foreach (var field in fields)
        //    {
        //        if (!dic.Keys.Contains(field.Name))
        //            continue;
        //        val = dic[field.Name];
        //        //非泛型
        //        if (!field.PropertyType.IsGenericType)
        //            obj = string.IsNullOrEmpty(val) ? null : Convert.ChangeType(val, field.PropertyType);
        //        else //泛型Nullable<>
        //        {
        //            Type genericTypeDefinition = field.PropertyType.GetGenericTypeDefinition();
        //            if (genericTypeDefinition == typeof(Nullable<>))
        //            {
        //                obj = string.IsNullOrEmpty(val)
        //                  ? null
        //                  : Convert.ChangeType(val, Nullable.GetUnderlyingType(field.PropertyType));
        //            }
        //        }
        //        field.SetValue(entity, obj, null);
        //    }
        //    //var query = from source in db.JmsFile select source;
        //    SearchListResult<Z> retListResult = query.ToSearchList(req);
        //    return retListResult;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<JmsFile> SearchList(JmsFileReq req)
        {
            var query = from source in db.JmsFile select source;
            if(req.DirectoryId != null) query = query.Where(d => d.DirectoryId == req.DirectoryId);
if(!string.IsNullOrEmpty(req.DirectoryName)) query = query.Where(d => d.DirectoryName.Contains(req.DirectoryName));
if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(!string.IsNullOrEmpty(req.ZhengLiState)) query = query.Where(d => d.ZhengLiState.Contains(req.ZhengLiState));
if (req.OptDateTimeStart != DateTime.MinValue && req.OptDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.OptDateTime >= req.OptDateTimeStart);
if (req.OptDateTimeEnd != DateTime.MinValue && req.OptDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.OptDateTime >= req.OptDateTimeEnd);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(req.JmsId != null) query = query.Where(d => d.JmsId == req.JmsId);
if(!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
if(!string.IsNullOrEmpty(req.FileAbsolutePath)) query = query.Where(d => d.FileAbsolutePath.Contains(req.FileAbsolutePath));
if(!string.IsNullOrEmpty(req.FileRelatePath)) query = query.Where(d => d.FileRelatePath.Contains(req.FileRelatePath));
if(!string.IsNullOrEmpty(req.Type)) query = query.Where(d => d.Type.Contains(req.Type));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<JmsFile> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

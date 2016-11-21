


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
    public partial class JmsDirectoryBLL
    { 
        private Context db = new Context();

        public JmsDirectory UpdateSingle(int id, JmsDirectoryReq data)
        { 
            JmsDirectory model = db.JmsDirectory.Find(id);
            SetJmsDirectory(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  JmsDirectory SetJmsDirectory(JmsDirectory model, JmsDirectoryReq data)
        {
             if(data.ParentId != null) model.ParentId = data.ParentId.Value;
if(!string.IsNullOrEmpty(data.ParentName)) model.ParentName = data.ParentName;
if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(!string.IsNullOrEmpty(data.Right)) model.Right = data.Right;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(!string.IsNullOrEmpty(data.DirectoryPath)) model.DirectoryPath = data.DirectoryPath;
if(!string.IsNullOrEmpty(data.JmsUploadClassState)) model.JmsUploadClassState = data.JmsUploadClassState;
if(data.JmsId != null) model.JmsId = data.JmsId.Value;
if(!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
 
            return model;
        }

        public SearchListResult<JmsDirectory> SearchList(JmsDirectoryReq req)
        {
            var query = from source in db.JmsDirectory select source;
            if(req.ParentId != null) query = query.Where(d => d.ParentId == req.ParentId);
if(!string.IsNullOrEmpty(req.ParentName)) query = query.Where(d => d.ParentName.Contains(req.ParentName));
if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(!string.IsNullOrEmpty(req.Right)) query = query.Where(d => d.Right.Contains(req.Right));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(!string.IsNullOrEmpty(req.DirectoryPath)) query = query.Where(d => d.DirectoryPath.Contains(req.DirectoryPath));
if(!string.IsNullOrEmpty(req.JmsUploadClassState)) query = query.Where(d => d.JmsUploadClassState.Contains(req.JmsUploadClassState));
if(req.JmsId != null) query = query.Where(d => d.JmsId == req.JmsId);
if(!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<JmsDirectory> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

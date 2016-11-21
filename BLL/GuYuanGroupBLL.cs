


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
    public partial class GuYuanGroupBLL
    { 
        private Context db = new Context();

        public GuYuanGroup UpdateSingle(int id, GuYuanGroupReq data)
        { 
            GuYuanGroup model = db.GuYuanGroup.Find(id);
            SetGuYuanGroup(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  GuYuanGroup SetGuYuanGroup(GuYuanGroup model, GuYuanGroupReq data)
        {
             if(data.Departmentid != null) model.Departmentid = data.Departmentid.Value;
if(!string.IsNullOrEmpty(data.DepartmentName)) model.DepartmentName = data.DepartmentName;
if(!string.IsNullOrEmpty(data.GroupName)) model.GroupName = data.GroupName;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(data.createdate != null && data.createdate != DateTime.MinValue && data.createdate != SqlDateTime.MinValue.Value) model.createdate = data.createdate.Value;
if(data.projectid != null) model.ProjectId = data.projectid.Value;
 
            return model;
        }

        /// <summary>
        /// 查询GuYuanGroup
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<GuYuanGroup> SearchList(GuYuanGroupReq req)
        {
            var query = from source in db.GuYuanGroup select source;
            if(req.Departmentid != null) query = query.Where(d => d.Departmentid == req.Departmentid);
if(!string.IsNullOrEmpty(req.DepartmentName)) query = query.Where(d => d.DepartmentName.Contains(req.DepartmentName));
if(!string.IsNullOrEmpty(req.GroupName)) query = query.Where(d => d.GroupName.Contains(req.GroupName));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if (req.createdateStart != DateTime.MinValue && req.createdateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateStart);
if (req.createdateEnd != DateTime.MinValue && req.createdateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateEnd);
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.ProjectId == req.projectid);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<GuYuanGroup> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

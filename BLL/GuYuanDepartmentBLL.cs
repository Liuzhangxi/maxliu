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
    public partial class GuYuanDepartmentBLL
    {
        private Context db = new Context();

        public GuYuanDepartment UpdateSingle(int id, GuYuanDepartmentReq data)
        {
            GuYuanDepartment model = db.GuYuanDepartment.Find(id);
            SetGuYuanDepartment(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public GuYuanDepartment SetGuYuanDepartment(GuYuanDepartment model, GuYuanDepartmentReq data)
        {
            if (!string.IsNullOrEmpty(data.DepartmentName)) model.DepartmentName = data.DepartmentName;
            if (data.projectid != null) model.ProjectId = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (data.createdate != null && data.createdate != DateTime.MinValue && data.createdate != SqlDateTime.MinValue.Value) model.createdate = data.createdate.Value;

            return model;
        }

        /// <summary>
        /// 查询GuYuanDepartment
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<GuYuanDepartment> SearchList(GuYuanDepartmentReq req)
        {
            var query = from source in db.GuYuanDepartment select source;
            if (!string.IsNullOrEmpty(req.DepartmentName)) query = query.Where(d => d.DepartmentName.Contains(req.DepartmentName));
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.ProjectId == req.projectid);
            if (!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (req.createdateStart != DateTime.MinValue && req.createdateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateStart);
            if (req.createdateEnd != DateTime.MinValue && req.createdateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.createdate >= req.createdateEnd);

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<GuYuanDepartment> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

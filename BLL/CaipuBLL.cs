


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
    public partial class CaipuBLL
    {
        private Context db = new Context();

        public Caipu UpdateSingle(int id, CaipuReq data)
        {
            Caipu model = db.Caipu.Find(id);
            SetCaipu(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public Caipu SetCaipu(Caipu model, CaipuReq data)
        {
            if (!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
            if (!string.IsNullOrEmpty(data.CaiType)) model.CaiType = data.CaiType;
            if (!string.IsNullOrEmpty(data.CanType)) model.CanType = data.CanType;
            if (data.Step!=null) model.Step = data.Step;
            if (!string.IsNullOrEmpty(data.Peiliao)) model.Peiliao = data.Peiliao;
            if (data.ServerDate != null && data.ServerDate != DateTime.MinValue &&
                data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
            if (data.Createdate != null && data.Createdate != DateTime.MinValue &&
                data.Createdate != SqlDateTime.MinValue.Value) model.Createdate = data.Createdate.Value;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (!string.IsNullOrEmpty(data.Gongxiao)) model.Gongxiao = data.Gongxiao;
            if (data.projectid != null) model.ProjectId = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;

            if (data.SaveId != null) model.SaveId = data.SaveId.Value;
            if (!string.IsNullOrEmpty(data.SaveName)) model.SaveName = data.SaveName;
            if (data.StartPersonId != null) model.StartPersonId = data.StartPersonId.Value;
            if (!string.IsNullOrEmpty(data.StartPersonName)) model.StartPersonName = data.StartPersonName;
            if (data.SpecialCustomerId != null) model.SpecialCustomerId = data.SpecialCustomerId.Value;
            if (!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
            
            return model;
        }

        /// <summary>
        /// 查询Caipu
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<Caipu> SearchList(CaipuReq req)
        {
            var query = from source in db.Caipu select source;
            if (!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
            if (!string.IsNullOrEmpty(req.CaiType)) query = query.Where(d => d.CaiType.Contains(req.CaiType));
            if (!string.IsNullOrEmpty(req.CanType)) query = query.Where(d => d.CanType.Contains(req.CanType));
            if (null!=req.Step) query = query.Where(d => d.Step.Equals(req.Step));

            if (!string.IsNullOrEmpty(req.Peiliao)) query = query.Where(d => d.Peiliao.Contains(req.Peiliao));
            if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.ServerDate >= req.ServerDateStart);
            if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.ServerDate >= req.ServerDateEnd);
            if (req.CreatedateStart != DateTime.MinValue && req.CreatedateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.Createdate >= req.CreatedateStart);
            if (req.CreatedateEnd != DateTime.MinValue && req.CreatedateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.Createdate >= req.CreatedateEnd);
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (!string.IsNullOrEmpty(req.Gongxiao)) query = query.Where(d => d.Gongxiao.Contains(req.Gongxiao));
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.ProjectId == req.projectid);
            if (!string.IsNullOrEmpty(req.ProjectName))
                query = query.Where(d => d.ProjectName.Contains(req.ProjectName));

            if (!string.IsNullOrEmpty(req.StartPersonName)) query = query.Where(d => d.StartPersonName.Contains(req.StartPersonName));
            if (null != req.StartPersonId) query = query.Where(d => d.StartPersonId.Equals(req.StartPersonId));

            if (!string.IsNullOrEmpty(req.SaveName)) query = query.Where(d => d.SaveName.Contains(req.SaveName));
            if (null != req.SaveId) query = query.Where(d => d.SaveId.Equals(req.SaveId));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<Caipu> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

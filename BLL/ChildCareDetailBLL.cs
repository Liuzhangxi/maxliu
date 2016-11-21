


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
    public partial class ChildCareDetailBLL
    { 
        private Context db = new Context();

        public ChildCareDetail UpdateSingle(int id, ChildCareDetailReq data)
        { 
            ChildCareDetail model = db.ChildCareDetail.Find(id);
            SetChildCareDetail(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  ChildCareDetail SetChildCareDetail(ChildCareDetail model, ChildCareDetailReq data)
        {
             if(!string.IsNullOrEmpty(data.Time)) model.Time = data.Time;
if(data.SelfWeiCount != null) model.SelfWeiCount = data.SelfWeiCount.Value;
if(data.MomMilk != null) model.MomMilk = data.MomMilk.Value;
if(data.FormulaMilk != null) model.FormulaMilk = data.FormulaMilk.Value;
if(!string.IsNullOrEmpty(data.WeiYao)) model.WeiYao = data.WeiYao;
if(data.WeiShui != null) model.WeiShui = data.WeiShui.Value;
if(!string.IsNullOrEmpty(data.DaBian)) model.DaBian = data.DaBian;
if(!string.IsNullOrEmpty(data.XiaoBian)) model.XiaoBian = data.XiaoBian;
if(data.SignUserId != null) model.SignUserId = data.SignUserId.Value;
if(!string.IsNullOrEmpty(data.SignUserName)) model.SignUserName = data.SignUserName;
if(!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.ServerDate != null && data.ServerDate != DateTime.MinValue && data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(data.KeHuid != null) model.KeHuid = data.KeHuid.Value;
if(!string.IsNullOrEmpty(data.KeHuName)) model.KeHuName = data.KeHuName;
if(!string.IsNullOrEmpty(data.ChildDesc)) model.ChildDesc = data.ChildDesc;
if(data.ChildCareId != null) model.ChildCareId = data.ChildCareId.Value;
 
            return model;
        }

        /// <summary>
        /// 查询ChildCareDetail
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<ChildCareDetail> SearchList(ChildCareDetailReq req)
        {
            var query = from source in db.ChildCareDetail select source;
            if(!string.IsNullOrEmpty(req.Time)) query = query.Where(d => d.Time.Contains(req.Time));
if(req.SelfWeiCount != null) query = query.Where(d => d.SelfWeiCount == req.SelfWeiCount);
if(req.MomMilk != null) query = query.Where(d => d.MomMilk == req.MomMilk);
if(req.FormulaMilk != null) query = query.Where(d => d.FormulaMilk == req.FormulaMilk);
if(!string.IsNullOrEmpty(req.WeiYao)) query = query.Where(d => d.WeiYao.Contains(req.WeiYao));
if(req.WeiShui != null) query = query.Where(d => d.WeiShui == req.WeiShui);
if(!string.IsNullOrEmpty(req.DaBian)) query = query.Where(d => d.DaBian.Contains(req.DaBian));
if(!string.IsNullOrEmpty(req.XiaoBian)) query = query.Where(d => d.XiaoBian.Contains(req.XiaoBian));
if(req.SignUserId != null) query = query.Where(d => d.SignUserId == req.SignUserId);
if(!string.IsNullOrEmpty(req.SignUserName)) query = query.Where(d => d.SignUserName.Contains(req.SignUserName));
if(!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);
if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate <= req.ServerDateEnd);
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectid == req.projectid);
if(req.KeHuid != null) query = query.Where(d => d.KeHuid == req.KeHuid);
if(!string.IsNullOrEmpty(req.KeHuName)) query = query.Where(d => d.KeHuName.Contains(req.KeHuName));
if(!string.IsNullOrEmpty(req.ChildDesc)) query = query.Where(d => d.ChildDesc.Contains(req.ChildDesc));
if(req.ChildCareId != null) query = query.Where(d => d.ChildCareId == req.ChildCareId);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<ChildCareDetail> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using OUDAL.ModelBase;
using OUDAL.BLL;
using OUDAL.Model;

namespace OUDAL
{
    public partial class ChildCareMainBLL
    {
        private Context db = new Context();

        public ChildCareMain UpdateSingle(int id, ChildCareMainReq data)
        {
            ChildCareMain model = db.ChildCareMain.Find(id);
            SetChildCareMain(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public ChildCareMain SetChildCareMain(ChildCareMain model, ChildCareMainReq data)
        {
            if (data.ServerDate != null && data.ServerDate != DateTime.MinValue &&
                data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
            if (data.Temperature != null) model.Temperature = data.Temperature.Value;
            if (data.Weight != null) model.Weight = data.Weight.Value;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (!string.IsNullOrEmpty(data.ChildDesc)) model.ChildDesc = data.ChildDesc;
            if (data.KhId != null) model.KhId = data.KhId.Value;
            if (!string.IsNullOrEmpty(data.KhName)) model.KhName = data.KhName;

            return model;
        }

        /// <summary>
        /// 查询ChildCareMain
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<ChildCareMain> SearchList(ChildCareMainReq req)
        {
            var query = from source in db.ChildCareMain select source;
            if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.ServerDate >= req.ServerDateStart);
            if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.ServerDate <= req.ServerDateEnd);
            if (req.Temperature != null) query = query.Where(d => d.Temperature == req.Temperature);
            if (req.Weight != null) query = query.Where(d => d.Weight == req.Weight);
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (!string.IsNullOrEmpty(req.ChildDesc)) query = query.Where(d => d.ChildDesc.Contains(req.ChildDesc));
            if (req.KhId != null) query = query.Where(d => d.KhId == req.KhId);
            if (!string.IsNullOrEmpty(req.KhName)) query = query.Where(d => d.KhName.Contains(req.KhName));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<ChildCareMain> retListResult = query.ToSearchList(req);
            return retListResult;
        }

        public SearchListResult<ChildCarePare> SearchPareList(ChildCareMainReq req)
        {
            ChildCareMainBLL bll = new ChildCareMainBLL();

            var query = (from ccd in db.ChildCareDetail
                         join cm in db.ChildCareMain on ccd.ChildCareId equals cm.id
                         select new ChildCarePare { ChildCareMain = cm, ChildCareDetail = ccd });

            if (!string.IsNullOrEmpty(req.KhName))
                query = query.Where(d => d.ChildCareMain.KhName.Contains(req.KhName));

            if (req.KhId != null)
                query = query.Where(d => d.ChildCareMain.KhId == req.KhId);

            if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime tempend = req.ServerDateEnd.AddDays(1);
                query = query.Where(d => d.ChildCareMain.ServerDate < tempend);
            }
            if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value)
            {
                query = query.Where(d => d.ChildCareMain.ServerDate >= req.ServerDateStart);
            }
            if (req.projectid != null && req.projectid != 0)
            {
                query = query.Where(d => d.ChildCareMain.projectid == req.projectid);
            }
            //所有数据都为空的不需要出来
            query = query.Where(d => d.ChildCareDetail.FormulaMilk!=null || !string.IsNullOrEmpty(d.ChildCareDetail.DaBian)
            || d.ChildCareDetail.MomMilk!=null || d.ChildCareDetail.WeiShui!=null || !string.IsNullOrEmpty(d.ChildCareDetail.WeiYao)
            || !string.IsNullOrEmpty(d.ChildCareDetail.XiaoBian) || d.ChildCareDetail.SelfWeiCount!=null
            || !string.IsNullOrEmpty(d.ChildCareDetail.Mark));

            query = query.OrderBy(q => q.ChildCareMain.KhName);
            SearchListResult<ChildCarePare> retListResult = query.OrderByDescending(n=>n.ChildCareMain.ServerDate).ToSearchList(req,false);
            return retListResult;
        }

    }
}

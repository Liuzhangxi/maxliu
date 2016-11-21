


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
    public partial class PingXiangInfoBLL
    {
        private Context db = new Context();

        public PingXiangInfo UpdateSingle(int id, PingXiangInfoReq data)
        {
            PingXiangInfo model = db.PingXiangInfo.Find(id);
            SetPingXiangInfo(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public PingXiangInfo SetPingXiangInfo(PingXiangInfo model, PingXiangInfoReq data)
        {
            if (!string.IsNullOrEmpty(data.PingXiangName)) model.PingXiangName = data.PingXiangName;
            if (!string.IsNullOrEmpty(data.GongXiao)) model.GongXiao = data.GongXiao;
            if (!string.IsNullOrEmpty(data.ShouFeiType)) model.ShouFeiType = data.ShouFeiType;
            if (!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;

            if (!string.IsNullOrEmpty(data.ManagerType)) model.ManagerType = data.ManagerType;
            return model;
        }

        /// <summary>
        /// 查询PingXiangInfo
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<PingXiangInfo> SearchList(PingXiangInfoReq req)
        {
            var query = from source in db.PingXiangInfo select source;
            if (!string.IsNullOrEmpty(req.PingXiangName)) query = query.Where(d => d.PingXiangName.Contains(req.PingXiangName));
            if (!string.IsNullOrEmpty(req.GongXiao)) query = query.Where(d => d.GongXiao.Contains(req.GongXiao));
            if (!string.IsNullOrEmpty(req.ShouFeiType))
            {
                query = query.Where(d => d.ShouFeiType.Contains(req.ShouFeiType));
            }

            if (!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState.Contains(req.ValidState));
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
            if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime tempdate = req.CreateDateEnd.Date.AddDays(1);
                query = query.Where(d => d.CreateDate < tempdate);
            }
            if (!string.IsNullOrEmpty(req.ManagerType))
            {
                query = query.Where(d => d.ManagerType.Contains(req.ManagerType));
            }
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<PingXiangInfo> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

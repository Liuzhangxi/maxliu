


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
    public partial class RoomInfoBLL
    {
        private Context db = new Context();

        public RoomInfo UpdateSingle(int id, RoomInfoReq data)
        {
            RoomInfo model = db.RoomInfo.Find(id);
            SetRoomInfo(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public RoomInfo SetRoomInfo(RoomInfo model, RoomInfoReq data)
        {
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue &&
                data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (!string.IsNullOrEmpty(data.FangXing)) model.FangXing = data.FangXing;
            if (!string.IsNullOrEmpty(data.FangHao)) model.FangHao = data.FangHao;
            if (!string.IsNullOrEmpty(data.ChaoXiang)) model.ChaoXiang = data.ChaoXiang;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (!string.IsNullOrEmpty(data.Owner)) model.Owner = data.Owner;
            if (!string.IsNullOrEmpty(data.ChuangXing)) model.ChuangXing = data.ChuangXing;
            if (data.FloorId != null) model.FloorId = data.FloorId.Value;
            if (!string.IsNullOrEmpty(data.FloorName)) model.FloorName = data.FloorName;


            //if (data.ValidToDate != null && data.ValidToDate != DateTime.MinValue &&
            //    data.ValidToDate != SqlDateTime.MinValue.Value) model.ValidToDate = data.ValidToDate.Value;
            //if (data.ValidFromDate != null && data.ValidFromDate != DateTime.MinValue &&
            //    data.ValidFromDate != SqlDateTime.MinValue.Value) model.ValidFromDate = data.ValidFromDate.Value;


            return model;
        }

        /// <summary>
        /// 查询RoomInfo
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<RoomInfo> SearchList(RoomInfoReq req)
        {
            var query = from source in db.RoomInfo select source;
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateStart);
            if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
            if (!string.IsNullOrEmpty(req.FangXing)) query = query.Where(d => d.FangXing.Contains(req.FangXing));
            if (!string.IsNullOrEmpty(req.FangHao)) query = query.Where(d => d.FangHao.Contains(req.FangHao));
            if (!string.IsNullOrEmpty(req.ChaoXiang)) query = query.Where(d => d.ChaoXiang.Contains(req.ChaoXiang));
            if (req.projectid != null) query = query.Where(d => d.projectid == req.projectid);
            if (!string.IsNullOrEmpty(req.ProjectName))
                query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (!string.IsNullOrEmpty(req.Owner)) query = query.Where(d => d.Owner.Contains(req.Owner));
            if (!string.IsNullOrEmpty(req.ChuangXing)) query = query.Where(d => d.ChuangXing.Contains(req.ChuangXing));
            if (req.FloorId != null) query = query.Where(d => d.FloorId == req.FloorId);
            if (!string.IsNullOrEmpty(req.FloorName)) query = query.Where(d => d.FloorName.Contains(req.FloorName));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<RoomInfo> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}




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
    public partial class RoomCheckInBLL
    {
        private Context db = new Context();

        public RoomCheckIn UpdateSingle(int id, RoomCheckInReq data)
        {
            RoomCheckIn model = db.RoomCheckIn.Find(id);
            SetRoomCheckIn(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public RoomCheckIn SetRoomCheckIn(RoomCheckIn model, RoomCheckInReq data)
        {
            if (data.RoomId != null) model.RoomId = data.RoomId.Value;
            if (data.StartDate != null && data.StartDate != DateTime.MinValue &&
                data.StartDate != SqlDateTime.MinValue.Value) model.StartDate = data.StartDate.Value;
            if (data.EndDate != null && data.EndDate != DateTime.MinValue && data.EndDate != SqlDateTime.MinValue.Value)
                model.EndDate = data.EndDate.Value;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (data.KeHuId != null) model.KeHuId = data.KeHuId.Value;
            if (!string.IsNullOrEmpty(data.KeHuName)) model.KeHuName = data.KeHuName;
            if (!string.IsNullOrEmpty(data.RoomDesc)) model.RoomDesc = data.RoomDesc;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue &&
                data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (!string.IsNullOrEmpty(data.Remark)) model.Remark = data.Remark;
            if (data.FloorId != null) model.FloorId = data.FloorId.Value;
            if (!string.IsNullOrEmpty(data.SwitchRoomTag)) model.SwitchRoomTag = data.SwitchRoomTag;

            if (data.PreRoomCheckInId != null) model.PreRoomCheckInId = data.PreRoomCheckInId.Value; 
            if (data.InitialHeTongId != null) model.InitialHeTongId = data.InitialHeTongId.Value;
            if (!string.IsNullOrEmpty(data.SwitchRoomDesc)) model.SwitchRoomDesc = data.SwitchRoomDesc;
            
            return model;
        }

        /// <summary>
        /// 查询RoomCheckIn
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<RoomCheckIn> SearchList(RoomCheckInReq req)
        {
            var query = from source in db.RoomCheckIn select source;
            if (req.RoomId != null) query = query.Where(d => d.RoomId == req.RoomId);
            if (req.StartDateStart != DateTime.MinValue && req.StartDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.StartDate >= req.StartDateStart);
            if (req.StartDateEnd != DateTime.MinValue && req.StartDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.StartDate >= req.StartDateEnd);
            if (req.EndDateStart != DateTime.MinValue && req.EndDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.EndDate >= req.EndDateStart);
            if (req.EndDateEnd != DateTime.MinValue && req.EndDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.EndDate >= req.EndDateEnd);
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (req.KeHuId != null) query = query.Where(d => d.KeHuId == req.KeHuId);
            if (!string.IsNullOrEmpty(req.KeHuName)) query = query.Where(d => d.KeHuName.Contains(req.KeHuName));
            if (!string.IsNullOrEmpty(req.RoomDesc)) query = query.Where(d => d.RoomDesc.Contains(req.RoomDesc));
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateStart);
            if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
            if (!string.IsNullOrEmpty(req.Remark)) query = query.Where(d => d.Remark.Contains(req.Remark));
            if (req.FloorId != null) query = query.Where(d => d.FloorId == req.FloorId);
            if (!string.IsNullOrEmpty(req.SwitchRoomDesc)) query = query.Where(d => d.SwitchRoomDesc.Contains(req.SwitchRoomDesc));
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<RoomCheckIn> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

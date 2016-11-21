


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
    public partial class FloorInfoBLL
    { 
        private Context db = new Context();

        public FloorInfo UpdateSingle(int id, FloorInfoReq data)
        { 
            FloorInfo model = db.FloorInfo.Find(id);
            SetFloorInfo(model, data); 
            db.SaveChanges();
            return model;
        }
        #region Custom
        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public FloorInfo SetFloorInfo(FloorInfo model, FloorInfoReq data)
        {
            if (data.projectid != null && data.projectid!=0) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (!string.IsNullOrEmpty(data.FloorNumber)) model.FloorNumber = data.FloorNumber;
            if (data.RoomCount != null) model.RoomCount = data.RoomCount.Value;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (!string.IsNullOrEmpty(data.FloorName)) model.FloorName = data.FloorName;
            if (!string.IsNullOrEmpty(data.WuYeClass)) model.WuYeClass = data.WuYeClass;
            if ( data.TotalLayer!=null) model.TotalLayer = data.TotalLayer.Value;
            
            return model;
        }
        /// <summary>
        /// 查询FloorInfo
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<FloorInfo> SearchList(FloorInfoReq req)
        {
            var query = from source in db.FloorInfo select source;
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.projectid == req.projectid);

            if (!string.IsNullOrEmpty(req.ProjectName))
            {
                string[] pNames = req.ProjectName.Split(","[0]);
                query = query.Where(d => pNames.Contains(d.ProjectName));
            }

            if (!string.IsNullOrEmpty(req.FloorNumber)) query = query.Where(d => d.FloorNumber.Contains(req.FloorNumber));
            if (req.RoomCount != null) query = query.Where(d => d.RoomCount == req.RoomCount);
            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
            if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
            if (!string.IsNullOrEmpty(req.FloorName)) query = query.Where(d => d.FloorName.Contains(req.FloorName));
            if (!string.IsNullOrEmpty(req.WuYeClass)) query = query.Where(d => d.WuYeClass.Contains(req.WuYeClass));
            if (req.TotalLayer!=null) query = query.Where(d => d.TotalLayer==req.TotalLayer.Value);

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<FloorInfo> retListResult = query.ToSearchList(req);
            return retListResult;
        }
        #endregion



    }
}

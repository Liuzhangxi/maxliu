


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
    public partial class CustomerPingXiangBLL
    {
        private Context db = new Context();

        public CustomerPingXiang UpdateSingle(int id, CustomerPingXiangReq data)
        {
            CustomerPingXiang model = db.CustomerPingXiang.Find(id);
            SetCustomerPingXiang(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public CustomerPingXiang SetCustomerPingXiang(CustomerPingXiang model, CustomerPingXiangReq data)
        {
            if (data.KhId != null) model.KhId = data.KhId.Value;
            if (!string.IsNullOrEmpty(data.KhName)) model.KhName = data.KhName;
            if (!string.IsNullOrEmpty(data.PingXiangName)) model.PingXiangName = data.PingXiangName;
            if (!string.IsNullOrEmpty(data.GongXiao)) model.GongXiao = data.GongXiao;
            if (data.EatStart != null && data.EatStart != DateTime.MinValue &&
                data.EatStart != SqlDateTime.MinValue.Value) model.EatStart = data.EatStart.Value;
            if (data.EatEnd != null && data.EatEnd != DateTime.MinValue && data.EatEnd != SqlDateTime.MinValue.Value)
                model.EatEnd = data.EatEnd.Value;
            if (!string.IsNullOrEmpty(data.PeiLiao)) model.PeiLiao = data.PeiLiao;
            if (!string.IsNullOrEmpty(data.Desc)) model.Desc = data.Desc;
            if (data.projectid != null) model.ProjectId = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue &&
                data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (data.RoomId != null) model.RoomId = data.RoomId.Value;
            if (!string.IsNullOrEmpty(data.RoomNumber)) model.RoomNumber = data.RoomNumber;
            if (data.PingXiangId != null) model.PingXiangId = data.PingXiangId.Value;
            return model;
        }

        /// <summary>
        /// 查询CustomerPingXiang
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<CustomerPingXiang> SearchList(CustomerPingXiangReq req)
        {
            var query = from source in db.CustomerPingXiang select source;
            if (req.KhId != null) query = query.Where(d => d.KhId == req.KhId);
            if (!string.IsNullOrEmpty(req.KhName)) query = query.Where(d => d.KhName.Contains(req.KhName));
            if (!string.IsNullOrEmpty(req.PingXiangName))
                query = query.Where(d => d.PingXiangName.Contains(req.PingXiangName));
            if (!string.IsNullOrEmpty(req.GongXiao)) query = query.Where(d => d.GongXiao.Contains(req.GongXiao));
            if (req.EatStartStart != DateTime.MinValue && req.EatStartStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.EatStart >= req.EatStartStart);
            if (req.EatStartEnd != DateTime.MinValue && req.EatStartEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.EatStart <= req.EatStartEnd);
            if (req.EatEndStart != DateTime.MinValue && req.EatEndStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.EatEnd >= req.EatEndStart);
            if (req.EatEndEnd != DateTime.MinValue && req.EatEndEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.EatEnd <= req.EatEndEnd);
            if (!string.IsNullOrEmpty(req.PeiLiao)) query = query.Where(d => d.PeiLiao.Contains(req.PeiLiao));
            if (!string.IsNullOrEmpty(req.Desc)) query = query.Where(d => d.Desc.Contains(req.Desc));
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.ProjectId == req.projectid);
            if (!string.IsNullOrEmpty(req.ProjectName))
                query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState.Contains(req.ValidState));
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateStart);
            if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
            if (req.RoomId != null) query = query.Where(d => d.RoomId == req.RoomId);
            if (!string.IsNullOrEmpty(req.RoomNumber)) query = query.Where(d => d.RoomNumber.Contains(req.RoomNumber));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<CustomerPingXiang> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

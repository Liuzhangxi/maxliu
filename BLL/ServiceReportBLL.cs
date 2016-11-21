


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
    public partial class ServiceReportBLL
    { 
        private Context db = new Context();

        public ServiceReport UpdateSingle(int id, ServiceReportReq data)
        { 
            ServiceReport model = db.ServiceReport.Find(id);
            SetServiceReport(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  ServiceReport SetServiceReport(ServiceReport model, ServiceReportReq data)
        {
             if(!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;
if(data.ServerDate != null && data.ServerDate != DateTime.MinValue && data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
if(data.RoomId != null) model.RoomId = data.RoomId.Value;
if(!string.IsNullOrEmpty(data.RoomNumber)) model.RoomNumber = data.RoomNumber;
if(!string.IsNullOrEmpty(data.KeHuName)) model.KeHuName = data.KeHuName;
if(data.KeHuId != null) model.KeHuId = data.KeHuId.Value;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(data.projectid != null) model.ProjectId = data.projectid.Value;
 
            return model;
        }

        /// <summary>
        /// 查询ServiceReport
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<ServiceReport> SearchList(ServiceReportReq req)
        {
            var query = from source in db.ServiceReport select source;
            if(!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));
if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime ServerDateTemp = req.ServerDateEnd.AddDays(1);
query = query.Where(d => d.ServerDate < ServerDateTemp);}if(req.RoomId != null) query = query.Where(d => d.RoomId == req.RoomId);
if(!string.IsNullOrEmpty(req.RoomNumber)) query = query.Where(d => d.RoomNumber.Contains(req.RoomNumber));
if(!string.IsNullOrEmpty(req.KeHuName)) query = query.Where(d => d.KeHuName.Contains(req.KeHuName));
if(req.KeHuId != null) query = query.Where(d => d.KeHuId == req.KeHuId);
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime CreateDateTemp = req.CreateDateEnd.AddDays(1);
query = query.Where(d => d.CreateDate < CreateDateTemp);}if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.ProjectId == req.projectid);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<ServiceReport> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

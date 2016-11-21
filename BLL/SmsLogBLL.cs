


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
    public partial class SmsLogBLL
    { 
        private Context db = new Context();

        public SmsLog UpdateSingle(int id, SmsLogReq data)
        { 
            SmsLog model = db.SmsLog.Find(id);
            SetSmsLog(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  SmsLog SetSmsLog(SmsLog model, SmsLogReq data)
        {
             if(!string.IsNullOrEmpty(data.Type)) model.Type = data.Type;
if(data.RefId != null) model.RefId = data.RefId.Value;
if(data.SendDate != null && data.SendDate != DateTime.MinValue && data.SendDate != SqlDateTime.MinValue.Value) model.SendDate = data.SendDate.Value;
if(!string.IsNullOrEmpty(data.Result)) model.Result = data.Result;
if(!string.IsNullOrEmpty(data.SmsMsg)) model.SmsMsg = data.SmsMsg;
if(!string.IsNullOrEmpty(data.RetCode)) model.RetCode = data.RetCode;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ToPhones)) model.ToPhones = data.ToPhones;
if(!string.IsNullOrEmpty(data.RefTitle)) model.RefTitle = data.RefTitle;
 
            return model;
        }

        /// <summary>
        /// 查询SmsLog
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<SmsLog> SearchList(SmsLogReq req)
        {
            var query = from source in db.SmsLog select source;
            if(!string.IsNullOrEmpty(req.Type)) query = query.Where(d => d.Type.Contains(req.Type));
if(req.RefId != null) query = query.Where(d => d.RefId == req.RefId);
if (req.SendDateStart != DateTime.MinValue && req.SendDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.SendDate >= req.SendDateStart);
if (req.SendDateEnd != DateTime.MinValue && req.SendDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.SendDate >= req.SendDateEnd);
if(!string.IsNullOrEmpty(req.Result)) query = query.Where(d => d.Result.Contains(req.Result));
if(!string.IsNullOrEmpty(req.SmsMsg)) query = query.Where(d => d.SmsMsg.Contains(req.SmsMsg));
if(!string.IsNullOrEmpty(req.RetCode)) query = query.Where(d => d.RetCode.Contains(req.RetCode));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectid == req.projectid);
if(!string.IsNullOrEmpty(req.ToPhones)) query = query.Where(d => d.ToPhones.Contains(req.ToPhones));
if(!string.IsNullOrEmpty(req.RefTitle)) query = query.Where(d => d.RefTitle.Contains(req.RefTitle));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<SmsLog> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

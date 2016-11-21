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
    public class AccessLogsBLL
    {
        //public int Id { get; set; }
        //public int KeyId { get; set; }
        ////对字符串主键的表
        //[MaxLength(50)]
        //public string Code { get; set; }
        //[MaxLength(50)]
        //public string AccessClass { get; set; }
        //[MaxLength(50)]
        //public string AccessAction { get; set; }
        //[MaxLength(500)]
        //public string AccessInfo { get; set; }
        //public DateTime AccessTime { get; set; }
        //public string AccessPerson { get; set; }
        private Context db = new Context();

        public AccessLogs UpdateSingle(int id, AccessLogs data)
        { 
            AccessLogs model = db.AccessLogs.Find(id);
            SetAccessLogs(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  AccessLogs SetAccessLogs(AccessLogs old, AccessLogs data)
        {
            if (!string.IsNullOrEmpty(data.Code)) old.Code = data.Code;
            if (!string.IsNullOrEmpty(data.AccessClass)) old.AccessClass = data.AccessClass;
            if (!string.IsNullOrEmpty(data.AccessAction)) old.AccessAction = data.AccessAction;
            if (!string.IsNullOrEmpty(data.AccessInfo)) old.AccessInfo = data.AccessInfo;
            if (data.AccessTime != DateTime.MinValue && data.AccessTime != SqlDateTime.MinValue.Value)
                old.AccessTime = data.AccessTime;
            if (!string.IsNullOrEmpty(data.AccessPerson)) old.AccessPerson = data.AccessPerson;
            return old;
        }

        public SearchListResult<AccessLogs> SearchList(AccessLogsReq req)
        {
            var query = from accesslog in db.AccessLogs select accesslog; 

            if (req.KeyId != null) query = query.Where(d => d.KeyId == req.KeyId);
            if (!string.IsNullOrEmpty(req.Code)) query = query.Where(d => d.Code.Contains(req.Code));
            if (!string.IsNullOrEmpty(req.AccessClass)) query = query.Where(d => d.AccessClass.Contains(req.AccessClass));
            if (!string.IsNullOrEmpty(req.AccessAction)) query = query.Where(d => d.AccessAction.Contains(req.AccessAction));
            if (!string.IsNullOrEmpty(req.AccessInfo)) query = query.Where(d => d.AccessInfo.Contains(req.AccessInfo));
            if (req.AccessTimeStart != DateTime.MinValue && req.AccessTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.AccessTime >= req.AccessTimeStart);
            if (req.AccessTimeEnd != DateTime.MinValue && req.AccessTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.AccessTime >= req.AccessTimeEnd);
            if (!string.IsNullOrEmpty(req.AccessPerson)) query = query.Where(d => d.AccessPerson.Contains(req.AccessPerson));


            query = query.OrderByDescending(d => d.Id);
            SearchListResult<AccessLogs> retListResult = query.ToSearchList(req); 
            return retListResult;
        }

        public static void AddLogAndSave(Context db, string person, int id, string logClass, string logAction, string info)
        {
            AccessLogs a = new AccessLogs();
            a.KeyId = id;
            a.AccessClass = logClass;
            a.AccessAction = logAction;
            a.AccessInfo = info;
            a.AccessTime = DateTime.Now;
            a.AccessPerson = person;
            db.AccessLogs.Add(a);
            db.SaveChanges();
        }
      
        public static void AddLogAndSave(Context db, string person, string code, string logClass, string logAction, string info)
        {
            AccessLogs a = new AccessLogs();
            a.Code = code;
            a.AccessClass = logClass;
            a.AccessAction = logAction;
            a.AccessInfo = info;
            a.AccessTime = DateTime.Now;
            a.AccessPerson = person;
            db.AccessLogs.Add(a);
            db.SaveChanges();
        }
        public static void AddLog(Context db, string person, string code, string logClass, string logAction, string info)
        {
            AccessLogs a = new AccessLogs();
            a.Code = code;
            a.AccessClass = logClass;
            a.AccessAction = logAction;
            a.AccessInfo = info;
            a.AccessTime = DateTime.Now;
            a.AccessPerson = person;
            db.AccessLogs.Add(a);
        }
        public static void AddLog(Context db, string person, int id, string logClass, string logAction, string info)
        {
            AccessLogs a = new AccessLogs();
            a.KeyId = id;
            a.AccessClass = logClass;
            a.AccessAction = logAction;
            a.AccessInfo = info;
            a.AccessTime = DateTime.Now;
            a.AccessPerson = person;
            db.AccessLogs.Add(a);
        }
       
    }
}




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
    public partial class DietDayNoteBLL
    { 
        private Context db = new Context();

        public DietDayNote UpdateSingle(int id, DietDayNoteReq data)
        { 
            DietDayNote model = db.DietDayNote.Find(id);
            SetDietDayNote(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  DietDayNote SetDietDayNote(DietDayNote model, DietDayNoteReq data)
        {
             if(data.ServerDate != null && data.ServerDate != DateTime.MinValue && data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
if(data.LunchEmployeeCount != null) model.LunchEmployeeCount = data.LunchEmployeeCount.Value;
if(data.SupperEmployeeCount != null) model.SupperEmployeeCount = data.SupperEmployeeCount.Value;
if(!string.IsNullOrEmpty(data.LunchNote)) model.LunchNote = data.LunchNote;
if(!string.IsNullOrEmpty(data.SupperNote)) model.SupperNote = data.SupperNote;
if(!string.IsNullOrEmpty(data.OtherNote)) model.OtherNote = data.OtherNote;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.projectid != null) model.projectid = data.projectid.Value;
 
            return model;
        }

        /// <summary>
        /// 查询DietDayNote
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<DietDayNote> SearchList(DietDayNoteReq req)
        {
            var query = from source in db.DietDayNote select source;
            if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);
if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateEnd);
if(req.LunchEmployeeCount != null) query = query.Where(d => d.LunchEmployeeCount == req.LunchEmployeeCount);
if(req.SupperEmployeeCount != null) query = query.Where(d => d.SupperEmployeeCount == req.SupperEmployeeCount);
if(!string.IsNullOrEmpty(req.LunchNote)) query = query.Where(d => d.LunchNote.Contains(req.LunchNote));
if(!string.IsNullOrEmpty(req.SupperNote)) query = query.Where(d => d.SupperNote.Contains(req.SupperNote));
if(!string.IsNullOrEmpty(req.OtherNote)) query = query.Where(d => d.OtherNote.Contains(req.OtherNote));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectid == req.projectid);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<DietDayNote> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}




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
    public partial class StudentBLL
    { 
        private Context db = new Context();

        public Student UpdateSingle(int id, StudentReq data)
        { 
            Student model = db.Student.Find(id);
            SetStudent(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  Student SetStudent(Student model, StudentReq data)
        {
             if(!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;
if(!string.IsNullOrEmpty(data.Phone)) model.Phone = data.Phone;
if(!string.IsNullOrEmpty(data.JobPosition)) model.JobPosition = data.JobPosition;
if(data.JmsId != null) model.JmsId = data.JmsId.Value;
if(!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
if(data.TrainingStart != null && data.TrainingStart != DateTime.MinValue && data.TrainingStart != SqlDateTime.MinValue.Value) model.TrainingStart = data.TrainingStart.Value;
if(data.TrainingFinish != null && data.TrainingFinish != DateTime.MinValue && data.TrainingFinish != SqlDateTime.MinValue.Value) model.TrainingFinish = data.TrainingFinish.Value;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(data.UpdateDate != null && data.UpdateDate != DateTime.MinValue && data.UpdateDate != SqlDateTime.MinValue.Value) model.UpdateDate = data.UpdateDate.Value;
if(!string.IsNullOrEmpty(data.Note)) model.Note = data.Note;
 
            return model;
        }

        /// <summary>
        /// 查询Student
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<Student> SearchList(StudentReq req)
        {
            var query = from source in db.Student select source;
            if(!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
if(!string.IsNullOrEmpty(req.Phone)) query = query.Where(d => d.Phone.Contains(req.Phone));
if(!string.IsNullOrEmpty(req.JobPosition)) query = query.Where(d => d.JobPosition.Contains(req.JobPosition));
if(req.JmsId != null) query = query.Where(d => d.JmsId == req.JmsId);
if(!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
if (req.TrainingStartStart != DateTime.MinValue && req.TrainingStartStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.TrainingStart >= req.TrainingStartStart);
if (req.TrainingStartEnd != DateTime.MinValue && req.TrainingStartEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.TrainingStart >= req.TrainingStartEnd);
if (req.TrainingFinishStart != DateTime.MinValue && req.TrainingFinishStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.TrainingFinish >= req.TrainingFinishStart);
if (req.TrainingFinishEnd != DateTime.MinValue && req.TrainingFinishEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.TrainingFinish >= req.TrainingFinishEnd);
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
if (req.UpdateDateStart != DateTime.MinValue && req.UpdateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.UpdateDate >= req.UpdateDateStart);
if (req.UpdateDateEnd != DateTime.MinValue && req.UpdateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.UpdateDate >= req.UpdateDateEnd);
if(!string.IsNullOrEmpty(req.Note)) query = query.Where(d => d.Note.Contains(req.Note));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<Student> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

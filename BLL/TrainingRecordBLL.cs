


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
    public partial class TrainingRecordBLL
    { 
        private Context db = new Context();

        public TrainingRecord UpdateSingle(int id, TrainingRecordReq data)
        { 
            TrainingRecord model = db.TrainingRecord.Find(id);
            SetTrainingRecord(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  TrainingRecord SetTrainingRecord(TrainingRecord model, TrainingRecordReq data)
        {
             if(data.WeekNumber != null) model.WeekNumber = data.WeekNumber.Value;
if(!string.IsNullOrEmpty(data.DayClass)) model.DayClass = data.DayClass;
if(!string.IsNullOrEmpty(data.TrainContent)) model.TrainContent = data.TrainContent;
if(!string.IsNullOrEmpty(data.ZhangWoQingKuang)) model.ZhangWoQingKuang = data.ZhangWoQingKuang;
if(!string.IsNullOrEmpty(data.StudentFeedBack)) model.StudentFeedBack = data.StudentFeedBack;
if(!string.IsNullOrEmpty(data.TeacherFeedBack)) model.TeacherFeedBack = data.TeacherFeedBack;
if(!string.IsNullOrEmpty(data.TrainPlace)) model.TrainPlace = data.TrainPlace;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.StudentId != null) model.StudentId = data.StudentId.Value;
if(!string.IsNullOrEmpty(data.StudentName)) model.StudentName = data.StudentName;
 
            return model;
        }

        /// <summary>
        /// 查询TrainingRecord
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<TrainingRecord> SearchList(TrainingRecordReq req)
        {
            var query = from source in db.TrainingRecord select source;
            if(req.WeekNumber != null) query = query.Where(d => d.WeekNumber == req.WeekNumber);
if(!string.IsNullOrEmpty(req.DayClass)) query = query.Where(d => d.DayClass.Contains(req.DayClass));
if(!string.IsNullOrEmpty(req.TrainContent)) query = query.Where(d => d.TrainContent.Contains(req.TrainContent));
if(!string.IsNullOrEmpty(req.ZhangWoQingKuang)) query = query.Where(d => d.ZhangWoQingKuang.Contains(req.ZhangWoQingKuang));
if(!string.IsNullOrEmpty(req.StudentFeedBack)) query = query.Where(d => d.StudentFeedBack.Contains(req.StudentFeedBack));
if(!string.IsNullOrEmpty(req.TeacherFeedBack)) query = query.Where(d => d.TeacherFeedBack.Contains(req.TeacherFeedBack));
if(!string.IsNullOrEmpty(req.TrainPlace)) query = query.Where(d => d.TrainPlace.Contains(req.TrainPlace));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateEnd);
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.StudentId != null) query = query.Where(d => d.StudentId == req.StudentId);
if(!string.IsNullOrEmpty(req.StudentName)) query = query.Where(d => d.StudentName.Contains(req.StudentName));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<TrainingRecord> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

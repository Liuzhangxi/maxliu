


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
    public partial class PaiBanBLL
    { 
        private Context db = new Context();

        public PaiBan UpdateSingle(int id, PaiBanReq data)
        { 
            PaiBan model = db.PaiBan.Find(id);
            SetPaiBan(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public PaiBan SetPaiBan(PaiBan model, PaiBanReq data)
        {
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue &&
                data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (data.EmployeeId != null) model.EmployeeId = data.EmployeeId.Value;
            if (!string.IsNullOrEmpty(data.EmployeeName)) model.EmployeeName = data.EmployeeName;
            if (!string.IsNullOrEmpty(data.BanType)) model.BanType = data.BanType;
            if (data.BanHours != null) model.BanHours = data.BanHours.Value;
            if (data.ServerDate != null && data.ServerDate != DateTime.MinValue &&
                data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
            if (data.AddHours != null) model.AddHours = data.AddHours.Value;
           // if (!string.IsNullOrEmpty(data.DayType))
                model.DayType = data.DayType;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (data.BanTypeId != null) model.BanTypeId = data.BanTypeId.Value;
            if (data.WashHead != null) model.WashHead = data.WashHead.Value;
            if (data.WashBody != null) model.WashBody = data.WashBody.Value;
            if (data.KaiNai != null) model.KaiNai = data.KaiNai.Value;
           // if (!string.IsNullOrEmpty(data.KaiNaiFree))
                model.KaiNaiFree = data.KaiNaiFree;
            //if (!string.IsNullOrEmpty(data.KuangGong))
                model.KuangGong = data.KuangGong;
           if (data.ChiDao != null)  model.ChiDao = data.ChiDao.Value;
            //if (!string.IsNullOrEmpty(data.QueKa))
                model.QueKa = data.QueKa;
            if (data.JiangLi != null) model.JiangLi = data.JiangLi.Value;
            //if (!string.IsNullOrEmpty(data.Mark))
                model.Mark = data.Mark;
            if (data.HolidayHours != null) model.HolidayHours = data.HolidayHours;
            if (!string.IsNullOrEmpty(data.State)) model.State = data.State;
            if (null != data.QinJiaHours) model.QinJiaHours = data.QinJiaHours;
            if (!string.IsNullOrEmpty(data.QinJiaType)) model.QinJiaType = data.QinJiaType;
            
            return model;
        }

        /// <summary>
        /// 查询PaiBan
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<PaiBan> SearchList(PaiBanReq req)
        {
            var query = from source in db.PaiBan select source;
            if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate <= req.CreateDateEnd);
if(req.EmployeeId != null) query = query.Where(d => d.EmployeeId == req.EmployeeId);
if(!string.IsNullOrEmpty(req.EmployeeName)) query = query.Where(d => d.EmployeeName.Contains(req.EmployeeName));
if(!string.IsNullOrEmpty(req.BanType)) query = query.Where(d => d.BanType.Contains(req.BanType));
if(req.BanHours != null) query = query.Where(d => d.BanHours == req.BanHours);
if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);
if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate <= req.ServerDateEnd);
if(req.AddHours != null) query = query.Where(d => d.AddHours == req.AddHours);
if(!string.IsNullOrEmpty(req.DayType)) query = query.Where(d => d.DayType.Contains(req.DayType));
if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectid == req.projectid);
if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if(req.BanTypeId != null) query = query.Where(d => d.BanTypeId == req.BanTypeId);
if(req.WashHead != null) query = query.Where(d => d.WashHead == req.WashHead);
if(req.WashBody != null) query = query.Where(d => d.WashBody == req.WashBody);
if(req.KaiNai != null) query = query.Where(d => d.KaiNai == req.KaiNai);
if(!string.IsNullOrEmpty(req.KaiNaiFree)) query = query.Where(d => d.KaiNaiFree.Contains(req.KaiNaiFree));
if(!string.IsNullOrEmpty(req.KuangGong)) query = query.Where(d => d.KuangGong.Contains(req.KuangGong));
if(req.ChiDao != null) query = query.Where(d => d.ChiDao == req.ChiDao);
if(!string.IsNullOrEmpty(req.QueKa)) query = query.Where(d => d.QueKa.Contains(req.QueKa));
if(req.JiangLi != null) query = query.Where(d => d.JiangLi == req.JiangLi);
if(!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));

            if (!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<PaiBan> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

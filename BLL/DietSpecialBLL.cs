


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
    public partial class DietSpecialBLL
    { 
        private Context db = new Context();

        public DietSpecial UpdateSingle(int id, DietSpecialReq data)
        { 
            DietSpecial model = db.DietSpecial.Find(id);
            SetDietSpecial(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public DietSpecial SetDietSpecial(DietSpecial model, DietSpecialReq data)
        {
            if (data.ServerDate != null && data.ServerDate != DateTime.MinValue &&
                data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
            if (data.RoomId != null) model.RoomId = data.RoomId.Value;
            if (!string.IsNullOrEmpty(data.RoomNumber)) model.RoomNumber = data.RoomNumber;
            if (data.KeHuId != null) model.KeHuId = data.KeHuId.Value;
            if (!string.IsNullOrEmpty(data.KeHuName)) model.KeHuName = data.KeHuName;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.Createdate != null && data.Createdate != DateTime.MinValue &&
                data.Createdate != SqlDateTime.MinValue.Value) model.Createdate = data.Createdate.Value;

            if (!string.IsNullOrEmpty(data.SelectDiet))
            {
                if (data.IsAppend != null)
                {
                    if (data.IsAppend.Value)
                    {
                        if (model.SelectDiet.IndexOf(data.SelectDiet) < 0)
                        {
                            if (!string.IsNullOrEmpty(model.SelectDiet))
                                model.SelectDiet += ",";
                            model.SelectDiet += data.SelectDiet;
                        }
                    }
                    else
                    {
                        if (model.SelectDiet.IndexOf(data.SelectDiet) >= 0)
                        {
                            model.SelectDiet = model.SelectDiet.Replace("," + data.SelectDiet, "");
                            model.SelectDiet = model.SelectDiet.Replace(data.SelectDiet, "");
                        }
                    }
                }
                else
                {
                    model.SelectDiet = data.SelectDiet;
                }

            }

            if (!string.IsNullOrEmpty(data.OtherDiet)) model.OtherDiet = data.OtherDiet;
            //if (!string.IsNullOrEmpty(data.Desc))
                model.Desc = data.Desc;
            if (!string.IsNullOrEmpty(data.JiShiDesc)) model.JiShiDesc = data.JiShiDesc;
            if (data.projectid != null) model.ProjectId = data.projectid.Value;

            if (data.SaveId != null) model.SaveId = data.SaveId.Value;
            if (!string.IsNullOrEmpty(data.SaveName)) model.SaveName = data.SaveName;
            if (data.StartPersonId != null) model.StartPersonId = data.StartPersonId.Value;
            if (!string.IsNullOrEmpty(data.StartPersonName)) model.StartPersonName = data.StartPersonName;
            if (data.SetStep != null) model.SetStep = data.SetStep.Value;

            if (!string.IsNullOrEmpty(data.CenterCheckState)) model.CenterCheckState = data.CenterCheckState;
            if (data.CenterCheckDate != null) model.CenterCheckDate = data.CenterCheckDate;
            if (data.CenterCheckPersonId != null) model.CenterCheckPersonId = data.CenterCheckPersonId;
            if (!string.IsNullOrEmpty(data.CenterCheckPersonName)) model.CenterCheckPersonName = data.CenterCheckPersonName;

            if (!string.IsNullOrEmpty(data.MenDianCheckState))
            { 
                model.MenDianCheckState = data.MenDianCheckState;
            }
            if (data.MDCheckDate != null) model.MDCheckDate = data.MDCheckDate;
            if (data.MDCheckPersonId != null) model.MDCheckPersonId = data.MDCheckPersonId;
            if (!string.IsNullOrEmpty(data.MDCheckPersonName)) model.MDCheckPersonName = data.MDCheckPersonName;
            return model;
        }

        /// <summary>
        /// 查询DietSpecial
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<DietSpecial> SearchList(DietSpecialReq req)
        {
            var query = from source in db.DietSpecial select source;
            if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);
if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateEnd);
if(req.RoomId != null) query = query.Where(d => d.RoomId == req.RoomId);
if(!string.IsNullOrEmpty(req.RoomNumber)) query = query.Where(d => d.RoomNumber.Contains(req.RoomNumber));
if(req.KeHuId != null) query = query.Where(d => d.KeHuId == req.KeHuId);
if(!string.IsNullOrEmpty(req.KeHuName)) query = query.Where(d => d.KeHuName.Contains(req.KeHuName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreatedateStart != DateTime.MinValue && req.CreatedateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.Createdate >= req.CreatedateStart);
if (req.CreatedateEnd != DateTime.MinValue && req.CreatedateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.Createdate >= req.CreatedateEnd);
if(!string.IsNullOrEmpty(req.SelectDiet)) query = query.Where(d => d.SelectDiet.Contains(req.SelectDiet));
if(!string.IsNullOrEmpty(req.OtherDiet)) query = query.Where(d => d.OtherDiet.Contains(req.OtherDiet));
if(!string.IsNullOrEmpty(req.Desc)) query = query.Where(d => d.Desc.Contains(req.Desc));
if(!string.IsNullOrEmpty(req.JiShiDesc)) query = query.Where(d => d.JiShiDesc.Contains(req.JiShiDesc));
            if (req.projectid != null) query = query.Where(d => d.ProjectId == req.projectid);

            if (!string.IsNullOrEmpty(req.StartPersonName)) query = query.Where(d => d.StartPersonName.Contains(req.StartPersonName));
            if (null != req.StartPersonId) query = query.Where(d => d.StartPersonId.Equals(req.StartPersonId));

            if (!string.IsNullOrEmpty(req.SaveName)) query = query.Where(d => d.SaveName.Contains(req.SaveName));
            if (null != req.SaveId) query = query.Where(d => d.SaveId.Equals(req.SaveId));
            if (!string.IsNullOrEmpty(req.CenterCheckState)) query = query.Where(d => d.CenterCheckState.Contains(req.CenterCheckState));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<DietSpecial> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

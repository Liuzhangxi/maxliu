


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
    public partial class DayTypeBLL
    { 
        private Context db = new Context();

        public DayType UpdateSingle(int id, DayTypeReq data)
        { 
            DayType model = db.DayType.Find(id);
            SetDayType(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  DayType SetDayType(DayType model, DayTypeReq data)
        {
           //  if(!string.IsNullOrEmpty(data.DayTypeName))
                model.DayTypeName = data.DayTypeName;
if(data.ServerDate != null && data.ServerDate != DateTime.MinValue && data.ServerDate != SqlDateTime.MinValue.Value) model.ServerDate = data.ServerDate.Value;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
if(!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
if(data.projectid != null) model.projectid = data.projectid.Value;
 
            return model;
        }

        /// <summary>
        /// 查询DayType
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<DayType> SearchList(DayTypeReq req)
        {
            var query = from source in db.DayType select source;
            if(!string.IsNullOrEmpty(req.DayTypeName)) query = query.Where(d => d.DayTypeName.Contains(req.DayTypeName));
if (req.ServerDateStart != DateTime.MinValue && req.ServerDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate >= req.ServerDateStart);
if (req.ServerDateEnd != DateTime.MinValue && req.ServerDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ServerDate <= req.ServerDateEnd);
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart);
if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate <= req.CreateDateEnd);
if(!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState.Contains(req.ValidState));
 if (!string.IsNullOrEmpty(req.projectids))
{
                List<int?> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(
                    s =>
                    {
                        int? temp;
                        temp = Convert.ToInt32(s);
                        return temp;
                    }).ToList();
                query = query.Where(d => projectids.Contains(d.projectid));
}
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<DayType> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

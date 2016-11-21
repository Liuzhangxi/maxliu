


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
    public partial class HuoPingOutBLL
    { 
        private Context db = new Context();

        public HuoPingOut UpdateSingle(int id, HuoPingOutReq data)
        { 
            HuoPingOut model = db.HuoPingOut.Find(id);
            SetHuoPingOut(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HuoPingOut SetHuoPingOut(HuoPingOut model, HuoPingOutReq data)
        {
             if(data.HuoPingId != null) model.HuoPingId = data.HuoPingId.Value;
if(!string.IsNullOrEmpty(data.HuoPingName)) model.HuoPingName = data.HuoPingName;
if(data.Stock != null) model.Stock = data.Stock.Value;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.MonthNeed != null) model.MonthNeed = data.MonthNeed.Value;
if(data.WeekOne != null) model.WeekOne = data.WeekOne.Value;
if(data.WeekTwo != null) model.WeekTwo = data.WeekTwo.Value;
if(data.WeekThree != null) model.WeekThree = data.WeekThree.Value;
if(data.WeekFour != null) model.WeekFour = data.WeekFour.Value;
if(data.WeekFive != null) model.WeekFive = data.WeekFive.Value;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;
if(!string.IsNullOrEmpty(data.ServerMonth)) model.ServerMonth = data.ServerMonth;
 
            return model;
        }

        /// <summary>
        /// 查询HuoPingOut
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingOut> SearchList(HuoPingOutReq req)
        {
            var query = from source in db.HuoPingOut select source;
            if(req.HuoPingId != null) query = query.Where(d => d.HuoPingId == req.HuoPingId);
if(!string.IsNullOrEmpty(req.HuoPingName)) query = query.Where(d => d.HuoPingName.Contains(req.HuoPingName));
if(req.Stock != null) query = query.Where(d => d.Stock == req.Stock);
 if (!string.IsNullOrEmpty(req.projectids))
{
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s=>Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid !=null && projectids.Contains(d.projectid.Value));
}if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.MonthNeed != null) query = query.Where(d => d.MonthNeed == req.MonthNeed);
if(req.WeekOne != null) query = query.Where(d => d.WeekOne == req.WeekOne);
if(req.WeekTwo != null) query = query.Where(d => d.WeekTwo == req.WeekTwo);
if(req.WeekThree != null) query = query.Where(d => d.WeekThree == req.WeekThree);
if(req.WeekFour != null) query = query.Where(d => d.WeekFour == req.WeekFour);
if(req.WeekFive != null) query = query.Where(d => d.WeekFive == req.WeekFive);
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));
if(!string.IsNullOrEmpty(req.ServerMonth)) query = query.Where(d => d.ServerMonth.Contains(req.ServerMonth));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HuoPingOut> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

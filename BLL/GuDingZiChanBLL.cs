


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
    public partial class guDingZiChanBLL
    { 
        private Context db = new Context();

        public guDingZiChan UpdateSingle(int id, guDingZiChanReq data)
        { 
            guDingZiChan model = db.guDingZiChan.Find(id);
            SetguDingZiChan(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  guDingZiChan SetguDingZiChan(guDingZiChan model, guDingZiChanReq data)
        {
             if(!string.IsNullOrEmpty(data.companyName)) model.companyName = data.companyName;
if(!string.IsNullOrEmpty(data.ziChanTitle)) model.ziChanTitle = data.ziChanTitle;
if(data.pandianDateTime != null && data.pandianDateTime != DateTime.MinValue && data.pandianDateTime != SqlDateTime.MinValue.Value) model.pandianDateTime = data.pandianDateTime.Value;
if(!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
if(data.optId != null) model.optId = data.optId.Value;
if(data.createDate != null && data.createDate != DateTime.MinValue && data.createDate != SqlDateTime.MinValue.Value) model.createDate = data.createDate.Value;
if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
if(!string.IsNullOrEmpty(data.state)) model.state = data.state;
 
            return model;
        }

        /// <summary>
        /// 查询guDingZiChan
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<guDingZiChan> SearchList(guDingZiChanReq req)
        {
            var query = from source in db.guDingZiChan select source;
            if(!string.IsNullOrEmpty(req.companyName)) query = query.Where(d => d.companyName.Contains(req.companyName));
if(!string.IsNullOrEmpty(req.ziChanTitle)) query = query.Where(d => d.ziChanTitle.Contains(req.ziChanTitle));
if (req.pandianDateTimeStart != DateTime.MinValue && req.pandianDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.pandianDateTime >= req.pandianDateTimeStart);if (req.pandianDateTimeEnd != DateTime.MinValue && req.pandianDateTimeEnd != SqlDateTime.MinValue.Value) 
{
 DateTime pandianDateTimeTemp = req.pandianDateTimeEnd.AddDays(1);
query = query.Where(d => d.pandianDateTime < pandianDateTimeTemp);}if(!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
if(req.optId != null) query = query.Where(d => d.optId == req.optId);
if (req.createDateStart != DateTime.MinValue && req.createDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createDate >= req.createDateStart);if (req.createDateEnd != DateTime.MinValue && req.createDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime createDateTemp = req.createDateEnd.AddDays(1);
query = query.Where(d => d.createDate < createDateTemp);} if (!string.IsNullOrEmpty(req.projectids))
{
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s=>Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid !=null && projectids.Contains(d.projectid.Value));
}if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if(!string.IsNullOrEmpty(req.state)) query = query.Where(d => d.state.Contains(req.state));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<guDingZiChan> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

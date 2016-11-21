


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
    public partial class CaiJinInfoBLL
    { 
        private Context db = new Context();

        public CaiJinInfo UpdateSingle(int id, CaiJinInfoReq data)
        { 
            CaiJinInfo model = db.CaiJinInfo.Find(id);
            SetCaiJinInfo(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  CaiJinInfo SetCaiJinInfo(CaiJinInfo model, CaiJinInfoReq data)
        {
             if(data.projectid != null) model.projectid = data.projectid.Value;
if(!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
if(data.caijinMoney != null) model.caijinMoney = data.caijinMoney.Value;
if(data.optId != null) model.optId = data.optId.Value;
if(!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
if(data.createDate != null && data.createDate != DateTime.MinValue && data.createDate != SqlDateTime.MinValue.Value) model.createDate = data.createDate.Value;
if(data.checkId != null) model.checkId = data.checkId.Value;
if(!string.IsNullOrEmpty(data.checkName)) model.checkName = data.checkName;
if(data.checkDate != null && data.checkDate != DateTime.MinValue && data.checkDate != SqlDateTime.MinValue.Value) model.checkDate = data.checkDate.Value;
if(data.serverDate != null && data.serverDate != DateTime.MinValue && data.serverDate != SqlDateTime.MinValue.Value) model.serverDate = data.serverDate.Value;
 
            return model;
        }

        /// <summary>
        /// 查询CaiJinInfo
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<CaiJinInfo> SearchList(CaiJinInfoReq req)
        {
            var query = from source in db.CaiJinInfo select source;
             if (!string.IsNullOrEmpty(req.projectids))
            {
                            List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s=>Convert.ToInt32(s)).ToList();
                            query = query.Where(d => d.projectid !=null && projectids.Contains(d.projectid.Value));
            }
if (req.projectid!=null && req.projectid!=0) query = query.Where(d => d.projectid==req.projectid);if(!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
if(req.caijinMoney != null) query = query.Where(d => d.caijinMoney == req.caijinMoney);
if(req.optId != null) query = query.Where(d => d.optId == req.optId);
if(!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
if (req.createDateStart != DateTime.MinValue && req.createDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createDate >= req.createDateStart);if (req.createDateEnd != DateTime.MinValue && req.createDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime createDateTemp = req.createDateEnd.AddDays(1);
query = query.Where(d => d.createDate < createDateTemp);}if(req.checkId != null) query = query.Where(d => d.checkId == req.checkId);
if(!string.IsNullOrEmpty(req.checkName)) query = query.Where(d => d.checkName.Contains(req.checkName));
if (req.checkDateStart != DateTime.MinValue && req.checkDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.checkDate >= req.checkDateStart);if (req.checkDateEnd != DateTime.MinValue && req.checkDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime checkDateTemp = req.checkDateEnd.AddDays(1);
query = query.Where(d => d.checkDate < checkDateTemp);}if (req.serverDateStart != DateTime.MinValue && req.serverDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.serverDate >= req.serverDateStart);if (req.serverDateEnd != DateTime.MinValue && req.serverDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime serverDateTemp = req.serverDateEnd.AddDays(1);
query = query.Where(d => d.serverDate < serverDateTemp);} 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<CaiJinInfo> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

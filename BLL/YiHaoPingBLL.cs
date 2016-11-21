


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
    public partial class YiHaoPingBLL
    {
        private Context db = new Context();

        public YiHaoPing UpdateSingle(int id, YiHaoPingReq data)
        {
            YiHaoPing model = db.YiHaoPing.Find(id);
            SetYiHaoPing(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public YiHaoPing SetYiHaoPing(YiHaoPing model, YiHaoPingReq data)
        {
            if (data.HPId != null) model.HPId = data.HPId.Value;
            if (!string.IsNullOrEmpty(data.HPName)) model.HPName = data.HPName;
            if (data.shenqingNum != null) model.shenqingNum = data.shenqingNum.Value;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.shenqingRen)) model.shenqingRen = data.shenqingRen;
            if (!string.IsNullOrEmpty(data.shenpiRen)) model.shenpiRen = data.shenpiRen;
            if (!string.IsNullOrEmpty(data.lingliaoRen)) model.lingliaoRen = data.lingliaoRen;
            if (data.shenqingDate != null && data.shenqingDate != DateTime.MinValue && data.shenqingDate != SqlDateTime.MinValue.Value) model.shenqingDate = data.shenqingDate.Value;
            if (data.shenPiDate != null && data.shenPiDate != DateTime.MinValue && data.shenPiDate != SqlDateTime.MinValue.Value) model.shenPiDate = data.shenPiDate.Value;
            if (data.lingliaoDate != null && data.lingliaoDate != DateTime.MinValue && data.lingliaoDate != SqlDateTime.MinValue.Value) model.lingliaoDate = data.lingliaoDate.Value;
            if (data.lingliaoRenId != null) model.lingliaoRenId = data.lingliaoRenId.Value;
            if (data.shenpiRenId != null) model.shenpiRenId = data.shenpiRenId.Value;
            if (data.shenqingRenId != null) model.shenqingRenId = data.shenqingRenId.Value;
            if (!string.IsNullOrEmpty(data.projectName)) model.projectName = data.projectName;
            if (!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;

            return model;
        }

        /// <summary>
        /// 查询YiHaoPing
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<YiHaoPing> SearchList(YiHaoPingReq req)
        {
            var query = from source in db.YiHaoPing
                        join hp in db.HuoPing on source.HPId equals hp.id
                        select source;

            if (req.HPId != null) query = query.Where(d => d.HPId == req.HPId);
            if (!string.IsNullOrEmpty(req.HPName)) query = query.Where(d => d.HPName.Contains(req.HPName));
            if (req.shenqingNum != null) query = query.Where(d => d.shenqingNum == req.shenqingNum);
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid != null && projectids.Contains(d.projectid.Value));
            }
            if (!string.IsNullOrEmpty(req.shenqingRen)) query = query.Where(d => d.shenqingRen.Contains(req.shenqingRen));
            if (!string.IsNullOrEmpty(req.shenpiRen)) query = query.Where(d => d.shenpiRen.Contains(req.shenpiRen));
            if (!string.IsNullOrEmpty(req.lingliaoRen)) query = query.Where(d => d.lingliaoRen.Contains(req.lingliaoRen));
            if (req.shenqingDateStart != DateTime.MinValue && req.shenqingDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.shenqingDate >= req.shenqingDateStart); if (req.shenqingDateEnd != DateTime.MinValue && req.shenqingDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime shengqingDateTemp = req.shenqingDateEnd.AddDays(1);
                query = query.Where(d => d.shenqingDate < shengqingDateTemp);
            }
            if (req.shenPiDateStart != DateTime.MinValue && req.shenPiDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.shenPiDate >= req.shenPiDateStart); if (req.shenPiDateEnd != DateTime.MinValue && req.shenPiDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime shenPiDateTemp = req.shenPiDateEnd.AddDays(1);
                query = query.Where(d => d.shenPiDate < shenPiDateTemp);
            }
            if (req.lingliaoDateStart != DateTime.MinValue && req.lingliaoDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.lingliaoDate >= req.lingliaoDateStart); if (req.lingliaoDateEnd != DateTime.MinValue && req.lingliaoDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime lingliaoDateTemp = req.lingliaoDateEnd.AddDays(1);
                query = query.Where(d => d.lingliaoDate < lingliaoDateTemp);
            }
            if (req.lingliaoRenId != null) query = query.Where(d => d.lingliaoRenId == req.lingliaoRenId);
            if (req.shenpiRenId != null) query = query.Where(d => d.shenpiRenId == req.shenpiRenId);
            if (req.shenqingRenId != null) query = query.Where(d => d.shenqingRenId == req.shenqingRenId);
            if (!string.IsNullOrEmpty(req.projectName)) query = query.Where(d => d.projectName.Contains(req.projectName));

            if (!string.IsNullOrEmpty(req.yihaoPingState)) { query = query.Where(d => d.yihaoPingState.Contains(req.yihaoPingState)); }
            else
            {
                if (req.yihaoPingState != "无效") query = query.Where(d => d.yihaoPingState != "无效");
            }

            if (!string.IsNullOrEmpty(req.yihaoPingLingLiaoState))
            {
                if (req.yihaoPingLingLiaoState == "待领料")
                {
                    query = query.Where(d => d.shenpiRen == "" || d.shenpiRen == null);
                }
                else if (req.yihaoPingLingLiaoState == "已领料")
                {
                    query = query.Where(d => d.shenpiRen != "");
                }
                else if (req.yihaoPingLingLiaoState == "已作废")
                {
                    query = query.Where(d => d.yihaoPingState == "无效");
                }
            }
            else
            {
                query = query.Where(d => d.shenpiRen == "" || d.shenpiRen == null);
            }


            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<YiHaoPing> retListResult = query.ToSearchList(req);

            foreach (var yhp in retListResult.rows)
            {
                var hp = db.HuoPing.Find(yhp.HPId);
                yhp.CurStock = hp.CurStock;
            }

            return retListResult;
        }
    }
}

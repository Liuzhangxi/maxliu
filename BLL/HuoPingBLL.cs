


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
    public partial class HuoPingBLL
    {
        private Context db = new Context();

        public HuoPing UpdateSingle(int id, HuoPingReq data)
        {
            HuoPing model = db.HuoPing.Find(id);
            SetHuoPing(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public HuoPing SetHuoPing(HuoPing model, HuoPingReq data)
        {
            if (!string.IsNullOrEmpty(data.Name)) model.Name = data.Name;

            if (!string.IsNullOrEmpty(data.HuoPingImg)) model.HuoPingImg = data.HuoPingImg;

            if (!string.IsNullOrEmpty(data.SingleDesc)) model.SingleDesc = data.SingleDesc;
            if (data.SingleCount != null) model.SingleCount = data.SingleCount.Value;
            if (!string.IsNullOrEmpty(data.UseUnit)) model.UseUnit = data.UseUnit;
            if (data.DayUseCount != null) model.DayUseCount = data.DayUseCount.Value;
            if (!string.IsNullOrEmpty(data.UseType)) model.UseType = data.UseType;
            if (!string.IsNullOrEmpty(data.Mark)) model.Mark = data.Mark;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.ProjectName)) model.ProjectName = data.ProjectName;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (data.CreateDate != null && data.CreateDate != DateTime.MinValue && data.CreateDate != SqlDateTime.MinValue.Value) model.CreateDate = data.CreateDate.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.SinglePrice != null) model.SinglePrice = data.SinglePrice.Value;
            if (!string.IsNullOrEmpty(data.Supplier)) model.Supplier = data.Supplier;
            if (data.CurStock != null) model.CurStock = data.CurStock.Value;
            if (!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
            if (!string.IsNullOrEmpty(data.PinPai)) model.PinPai = data.PinPai;
            if (!string.IsNullOrEmpty(data.ChangjiaXinghao)) model.ChangjiaXinghao = data.ChangjiaXinghao;
            if (!string.IsNullOrEmpty(data.HuoPinLeixing)) model.HuoPinLeixing = data.HuoPinLeixing;

            if (!string.IsNullOrEmpty(data.lianXiRenPhone)) model.lianXiRenPhone = data.lianXiRenPhone;
            if (!string.IsNullOrEmpty(data.lianXiRenName)) model.lianXiRenName = data.lianXiRenName;

            return model;
        }

        /// <summary>
        /// 查询HuoPing
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPing> SearchList(HuoPingReq req)
        {
            var query = from source in db.HuoPing select source;


            if (!string.IsNullOrEmpty(req.Name)) query = query.Where(d => d.Name.Contains(req.Name));
            if (!string.IsNullOrEmpty(req.SingleDesc)) query = query.Where(d => d.SingleDesc.Contains(req.SingleDesc));
            if (req.SingleCount != null) query = query.Where(d => d.SingleCount == req.SingleCount);
            if (req.DayUseCount != null) query = query.Where(d => d.DayUseCount == req.DayUseCount);
            if (!string.IsNullOrEmpty(req.UseType)) query = query.Where(d => d.UseType.Contains(req.UseType));
            if (!string.IsNullOrEmpty(req.Mark)) query = query.Where(d => d.Mark.Contains(req.Mark));
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();
                query = query.Where(d => d.projectid != null && projectids.Contains(d.projectid.Value));
            }
            if (!string.IsNullOrEmpty(req.ProjectName)) query = query.Where(d => d.ProjectName.Contains(req.ProjectName));
            if (req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
            if (req.CreateDateStart != DateTime.MinValue && req.CreateDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CreateDate >= req.CreateDateStart); if (req.CreateDateEnd != DateTime.MinValue && req.CreateDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime CreateDateTemp = req.CreateDateEnd.AddDays(1);
                query = query.Where(d => d.CreateDate < CreateDateTemp);
            }
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.SinglePrice != null) query = query.Where(d => d.SinglePrice == req.SinglePrice);
            if (!string.IsNullOrEmpty(req.Supplier)) query = query.Where(d => d.Supplier.Contains(req.Supplier));
            if (req.CurStock != null) query = query.Where(d => d.CurStock == req.CurStock);
            if (!string.IsNullOrEmpty(req.ValidState)) query = query.Where(d => d.ValidState == req.ValidState);
            else query = query.Where(d => d.ValidState == "Valid");

            if (!string.IsNullOrEmpty(req.HuoPinLeixing)) query = query.Where(d => d.HuoPinLeixing.Contains(req.HuoPinLeixing));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<HuoPing> retListResult = query.ToSearchList(req);

            var now = DateTime.Now;
            var startTime = Convert.ToDateTime(now.Year + "-" + now.Month + "-01");
            var endTime = startTime.AddMonths(1);
            foreach (var hp in retListResult.rows)
            {
                var hpShenqingNum = db.YiHaoPing.Where(x => x.HPId == hp.id && x.yihaoPingState == "有效" && x.shenqingDate >= startTime && x.shenqingDate < endTime).Sum(x => x.shenqingNum);
                hp.CurMonthNum = hpShenqingNum ?? 0;
            }
            return retListResult;
        }
    }
}

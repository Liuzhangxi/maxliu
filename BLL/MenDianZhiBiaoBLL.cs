


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
    public partial class MenDianZhiBiaoBLL
    {
        private Context db = new Context();

        public MenDianZhiBiao UpdateSingle(int id, MenDianZhiBiaoReq data)
        {
            MenDianZhiBiao model = db.MenDianZhiBiao.Find(id);
            SetMenDianZhiBiao(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public MenDianZhiBiao SetMenDianZhiBiao(MenDianZhiBiao model, MenDianZhiBiaoReq data)
        {
            if (data.yueXiaoShou != null) model.yueXiaoShou = data.yueXiaoShou.Value;
            if (data.jianyeMoney != null) model.jianyeMoney = data.jianyeMoney.Value;
            if (data.DingdanCount != null) model.DingdanCount = data.DingdanCount.Value;
            if (data.canguanCount != null) model.canguanCount = data.canguanCount.Value;
            if (!string.IsNullOrEmpty(data.zhibiaoYear)) model.zhibiaoYear = data.zhibiaoYear;
            if (!string.IsNullOrEmpty(data.zhibiaoStateID)) model.zhibiaoStateID = data.zhibiaoStateID;
            if (data.projectid != null) model.projectid = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;

            return model;
        }

        /// <summary>
        /// 查询MenDianZhiBiao
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<MenDianZhiBiao> SearchList(MenDianZhiBiaoReq req)
        {
            var query = from source in db.MenDianZhiBiao select source;
            if (req.yueXiaoShou != null) query = query.Where(d => d.yueXiaoShou == req.yueXiaoShou);
            if (req.jianyeMoney != null) query = query.Where(d => d.jianyeMoney == req.jianyeMoney);
            if (req.DingdanCount != null) query = query.Where(d => d.DingdanCount == req.DingdanCount);
            if (req.canguanCount != null) query = query.Where(d => d.canguanCount == req.canguanCount);
            if (!string.IsNullOrEmpty(req.zhibiaoYear)) query = query.Where(d => d.zhibiaoYear.Contains(req.zhibiaoYear));
            if (!string.IsNullOrEmpty(req.zhibiaoStateID)) query = query.Where(d => d.zhibiaoStateID.Contains(req.zhibiaoStateID));
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.projectid == req.projectid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart); if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime optDateTimeTemp = req.optDateTimeEnd.AddDays(1);
                query = query.Where(d => d.optDateTime < optDateTimeTemp);
            }
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<MenDianZhiBiao> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

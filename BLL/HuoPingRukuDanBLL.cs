


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
    public partial class HuoPingRukuDanBLL
    {
        private Context db = new Context();

        public HuoPingRukuDan UpdateSingle(int id, HuoPingRukuDanReq data)
        {
            HuoPingRukuDan model = db.HuoPingRukuDan.Find(id);
            SetHuoPingRukuDan(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public HuoPingRukuDan SetHuoPingRukuDan(HuoPingRukuDan model, HuoPingRukuDanReq data)
        {
            if (!string.IsNullOrEmpty(data.RuKuDanBianHao)) model.RuKuDanBianHao = data.RuKuDanBianHao;
            if (data.HPCount != null) model.HPCount = data.HPCount.Value;
            if (data.HPZhongLei != null) model.HPZhongLei = data.HPZhongLei.Value;
            if (data.HPZongJia != null) model.HPZongJia = data.HPZongJia.Value;
            if (!string.IsNullOrEmpty(data.RuKuDanState)) model.RuKuDanState = data.RuKuDanState;
            if (data.RuKuDate != null && data.RuKuDate != DateTime.MinValue && data.RuKuDate != SqlDateTime.MinValue.Value) model.RuKuDate = data.RuKuDate.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (data.RuKuDanLeiXing != null) model.RuKuDanLeiXing = data.RuKuDanLeiXing.Value;
            if (data.CaiGouDanId != null) model.CaiGouDanId = data.CaiGouDanId.Value;

            return model;
        }

        /// <summary>
        /// 查询HuoPingRukuDan
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingRukuDan> SearchList(HuoPingRukuDanReq req)
        {
            var query = from source in db.HuoPingRukuDan select source;
            if (!string.IsNullOrEmpty(req.RuKuDanBianHao)) query = query.Where(d => d.RuKuDanBianHao.Contains(req.RuKuDanBianHao));
            if (req.HPCount != null) query = query.Where(d => d.HPCount == req.HPCount);
            if (req.HPZhongLei != null) query = query.Where(d => d.HPZhongLei == req.HPZhongLei);
            if (req.HPZongJia != null) query = query.Where(d => d.HPZongJia == req.HPZongJia);
            if (!string.IsNullOrEmpty(req.RuKuDanState)) query = query.Where(d => d.RuKuDanState.Contains(req.RuKuDanState));
            if (req.RuKuDateStart != DateTime.MinValue && req.RuKuDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.RuKuDate >= req.RuKuDateStart); if (req.RuKuDateEnd != DateTime.MinValue && req.RuKuDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime RuKuDateTemp = req.RuKuDateEnd.AddDays(1);
                query = query.Where(d => d.RuKuDate < RuKuDateTemp);
            }
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart); if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime optDateTimeTemp = req.optDateTimeEnd.AddDays(1);
                query = query.Where(d => d.optDateTime < optDateTimeTemp);
            }
            if (req.RuKuDanLeiXing != null) query = query.Where(d => d.RuKuDanLeiXing == req.RuKuDanLeiXing);
            if (req.CaiGouDanId != null) query = query.Where(d => d.CaiGouDanId == req.CaiGouDanId);

            if (req.RuKuDanLeiXing != null) query = query.Where(d => d.RuKuDanLeiXing == req.RuKuDanLeiXing);

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "Id";
                req.sord = "desc";
            }
            SearchListResult<HuoPingRukuDan> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

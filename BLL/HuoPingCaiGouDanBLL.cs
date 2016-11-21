


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
    public partial class HuoPingCaiGouDanBLL
    {
        private Context db = new Context();

        public HuoPingCaiGouDan UpdateSingle(int id, HuoPingCaiGouDanReq data)
        {
            HuoPingCaiGouDan model = db.HuoPingCaiGouDan.Find(id);
            SetHuoPingCaiGouDan(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public HuoPingCaiGouDan SetHuoPingCaiGouDan(HuoPingCaiGouDan model, HuoPingCaiGouDanReq data)
        {
            if (!string.IsNullOrEmpty(data.CaiGouDanBianHao)) model.CaiGouDanBianHao = data.CaiGouDanBianHao;
            if (data.HPCount != null) model.HPCount = data.HPCount.Value;
            if (data.HPZhongLei != null) model.HPZhongLei = data.HPZhongLei.Value;
            if (data.HPZongJia != null) model.HPZongJia = data.HPZongJia.Value;
            if (!string.IsNullOrEmpty(data.CaiGouDanState)) model.CaiGouDanState = data.CaiGouDanState;
            if (data.CaiGouDate != null && data.CaiGouDate != DateTime.MinValue && data.CaiGouDate != SqlDateTime.MinValue.Value) model.CaiGouDate = data.CaiGouDate.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;

            return model;
        }

        /// <summary>
        /// 查询HuoPingCaiGouDan
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingCaiGouDan> SearchList(HuoPingCaiGouDanReq req)
        {
            var query = from source in db.HuoPingCaiGouDan select source;
            if (!string.IsNullOrEmpty(req.CaiGouDanBianHao)) query = query.Where(d => d.CaiGouDanBianHao.Contains(req.CaiGouDanBianHao));
            if (req.HPCount != null) query = query.Where(d => d.HPCount == req.HPCount);
            if (req.HPZhongLei != null) query = query.Where(d => d.HPZhongLei == req.HPZhongLei);
            if (req.HPZongJia != null) query = query.Where(d => d.HPZongJia == req.HPZongJia);
            if (!string.IsNullOrEmpty(req.CaiGouDanState)) query = query.Where(d => d.CaiGouDanState.Contains(req.CaiGouDanState));
            if (req.CaiGouDateStart != DateTime.MinValue && req.CaiGouDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CaiGouDate >= req.CaiGouDateStart); if (req.CaiGouDateEnd != DateTime.MinValue && req.CaiGouDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime CaiGouDateTemp = req.CaiGouDateEnd.AddDays(1);
                query = query.Where(d => d.CaiGouDate < CaiGouDateTemp);
            }
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart); if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime optDateTimeTemp = req.optDateTimeEnd.AddDays(1);
                query = query.Where(d => d.optDateTime < optDateTimeTemp);
            }
            if (req.CaiGouDanLeiXing != null) { query = query.Where(d => d.CaiGouDanLeiXing == req.CaiGouDanLeiXing); }


            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "Id";
                req.sord = "desc";
            }
            SearchListResult<HuoPingCaiGouDan> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

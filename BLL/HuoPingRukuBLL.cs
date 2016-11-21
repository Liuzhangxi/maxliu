


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
    public partial class HuoPingRukuBLL
    { 
        private Context db = new Context();

        public HuoPingRuku UpdateSingle(int id, HuoPingRukuReq data)
        { 
            HuoPingRuku model = db.HuoPingRuku.Find(id);
            SetHuoPingRuku(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HuoPingRuku SetHuoPingRuku(HuoPingRuku model, HuoPingRukuReq data)
        {
             if(data.HPId != null) model.HPId = data.HPId.Value;
if(!string.IsNullOrEmpty(data.HPName)) model.HPName = data.HPName;
if(data.SinglePrice != null) model.SinglePrice = data.SinglePrice.Value;
if(!string.IsNullOrEmpty(data.Supplier)) model.Supplier = data.Supplier;
if(!string.IsNullOrEmpty(data.ChangjiaXinghao)) model.ChangjiaXinghao = data.ChangjiaXinghao;
if(!string.IsNullOrEmpty(data.RuKuDanBianHao)) model.RuKuDanBianHao = data.RuKuDanBianHao;
if(data.rukuShuLiang != null) model.rukuShuLiang = data.rukuShuLiang.Value;
if(!string.IsNullOrEmpty(data.rukuRen)) model.rukuRen = data.rukuRen;
if(data.rukuDate != null && data.rukuDate != DateTime.MinValue && data.rukuDate != SqlDateTime.MinValue.Value) model.rukuDate = data.rukuDate.Value;
if(!string.IsNullOrEmpty(data.rukuState)) model.rukuState = data.rukuState;
if(data.caigouId != null) model.caigouId = data.caigouId.Value;
if(!string.IsNullOrEmpty(data.CaiGouDanBianHao)) model.CaiGouDanBianHao = data.CaiGouDanBianHao;
if(data.rukuJinEr != null) model.rukuJinEr = data.rukuJinEr.Value;
 
            return model;
        }

        /// <summary>
        /// 查询HuoPingRuku
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingRuku> SearchList(HuoPingRukuReq req)
        {
            var query = from source in db.HuoPingRuku select source;
            if(req.HPId != null) query = query.Where(d => d.HPId == req.HPId);
if(!string.IsNullOrEmpty(req.HPName)) query = query.Where(d => d.HPName.Contains(req.HPName));
if(req.SinglePrice != null) query = query.Where(d => d.SinglePrice == req.SinglePrice);
if(!string.IsNullOrEmpty(req.Supplier)) query = query.Where(d => d.Supplier.Contains(req.Supplier));
if(!string.IsNullOrEmpty(req.ChangjiaXinghao)) query = query.Where(d => d.ChangjiaXinghao.Contains(req.ChangjiaXinghao));
if(!string.IsNullOrEmpty(req.RuKuDanBianHao)) query = query.Where(d => d.RuKuDanBianHao.Contains(req.RuKuDanBianHao));
if(req.rukuShuLiang != null) query = query.Where(d => d.rukuShuLiang == req.rukuShuLiang);
if(!string.IsNullOrEmpty(req.rukuRen)) query = query.Where(d => d.rukuRen.Contains(req.rukuRen));
if (req.rukuDateStart != DateTime.MinValue && req.rukuDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.rukuDate >= req.rukuDateStart);if (req.rukuDateEnd != DateTime.MinValue && req.rukuDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime rukuDateTemp = req.rukuDateEnd.AddDays(1);
query = query.Where(d => d.rukuDate < rukuDateTemp);}if(!string.IsNullOrEmpty(req.rukuState)) query = query.Where(d => d.rukuState.Contains(req.rukuState));
if(req.caigouId != null) query = query.Where(d => d.caigouId == req.caigouId);
if(!string.IsNullOrEmpty(req.CaiGouDanBianHao)) query = query.Where(d => d.CaiGouDanBianHao.Contains(req.CaiGouDanBianHao));
if(req.rukuJinEr != null) query = query.Where(d => d.rukuJinEr == req.rukuJinEr);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HuoPingRuku> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

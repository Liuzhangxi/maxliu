


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
    public partial class HuoPingCaiGouBLL
    { 
        private Context db = new Context();

        public HuoPingCaiGou UpdateSingle(int id, HuoPingCaiGouReq data)
        { 
            HuoPingCaiGou model = db.HuoPingCaiGou.Find(id);
            SetHuoPingCaiGou(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HuoPingCaiGou SetHuoPingCaiGou(HuoPingCaiGou model, HuoPingCaiGouReq data)
        {
             if(data.HPId != null) model.HPId = data.HPId.Value;
if(!string.IsNullOrEmpty(data.HPName)) model.HPName = data.HPName;
if(data.SinglePrice != null) model.SinglePrice = data.SinglePrice.Value;
if(!string.IsNullOrEmpty(data.Supplier)) model.Supplier = data.Supplier;
if(!string.IsNullOrEmpty(data.ChangjiaXinghao)) model.ChangjiaXinghao = data.ChangjiaXinghao;
if(!string.IsNullOrEmpty(data.PinPai)) model.PinPai = data.PinPai;
if(!string.IsNullOrEmpty(data.CaiGouDanBianHao)) model.CaiGouDanBianHao = data.CaiGouDanBianHao;
if(data.caigouNum != null) model.caigouNum = data.caigouNum.Value;
if(!string.IsNullOrEmpty(data.caigouRen)) model.caigouRen = data.caigouRen;
if(data.caigouDate != null && data.caigouDate != DateTime.MinValue && data.caigouDate != SqlDateTime.MinValue.Value) model.caigouDate = data.caigouDate.Value;
if(!string.IsNullOrEmpty(data.shenpiRen)) model.shenpiRen = data.shenpiRen;
if(data.shenpiDate != null && data.shenpiDate != DateTime.MinValue && data.shenpiDate != SqlDateTime.MinValue.Value) model.shenpiDate = data.shenpiDate.Value;
if(!string.IsNullOrEmpty(data.caigouState)) model.caigouState = data.caigouState;
if(data.rukuId != null) model.rukuId = data.rukuId.Value;
if(data.caigoudanId != null) model.caigoudanId = data.caigoudanId.Value;
 
            return model;
        }

        /// <summary>
        /// 查询HuoPingCaiGou
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingCaiGou> SearchList(HuoPingCaiGouReq req)
        {
            var query = from source in db.HuoPingCaiGou select source;
            if(req.HPId != null) query = query.Where(d => d.HPId == req.HPId);
if(!string.IsNullOrEmpty(req.HPName)) query = query.Where(d => d.HPName.Contains(req.HPName));
if(req.SinglePrice != null) query = query.Where(d => d.SinglePrice == req.SinglePrice);
if(!string.IsNullOrEmpty(req.Supplier)) query = query.Where(d => d.Supplier.Contains(req.Supplier));
if(!string.IsNullOrEmpty(req.ChangjiaXinghao)) query = query.Where(d => d.ChangjiaXinghao.Contains(req.ChangjiaXinghao));
if(!string.IsNullOrEmpty(req.PinPai)) query = query.Where(d => d.PinPai.Contains(req.PinPai));
if(!string.IsNullOrEmpty(req.CaiGouDanBianHao)) query = query.Where(d => d.CaiGouDanBianHao.Contains(req.CaiGouDanBianHao));
if(req.caigouNum != null) query = query.Where(d => d.caigouNum == req.caigouNum);
if(!string.IsNullOrEmpty(req.caigouRen)) query = query.Where(d => d.caigouRen.Contains(req.caigouRen));
if (req.caigouDateStart != DateTime.MinValue && req.caigouDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.caigouDate >= req.caigouDateStart);if (req.caigouDateEnd != DateTime.MinValue && req.caigouDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime caigouDateTemp = req.caigouDateEnd.AddDays(1);
query = query.Where(d => d.caigouDate < caigouDateTemp);}if(!string.IsNullOrEmpty(req.shenpiRen)) query = query.Where(d => d.shenpiRen.Contains(req.shenpiRen));
if (req.shenpiDateStart != DateTime.MinValue && req.shenpiDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.shenpiDate >= req.shenpiDateStart);if (req.shenpiDateEnd != DateTime.MinValue && req.shenpiDateEnd != SqlDateTime.MinValue.Value) 
{
 DateTime shenpiDateTemp = req.shenpiDateEnd.AddDays(1);
query = query.Where(d => d.shenpiDate < shenpiDateTemp);}if(!string.IsNullOrEmpty(req.caigouState)) query = query.Where(d => d.caigouState.Contains(req.caigouState));
if(req.rukuId != null) query = query.Where(d => d.rukuId == req.rukuId);
if(req.caigoudanId != null) query = query.Where(d => d.caigoudanId == req.caigoudanId);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HuoPingCaiGou> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

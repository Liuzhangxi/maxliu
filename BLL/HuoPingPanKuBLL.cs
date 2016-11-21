


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
    public partial class HuoPingPanKuBLL
    { 
        private Context db = new Context();

        public HuoPingPanKu UpdateSingle(int id, HuoPingPanKuReq data)
        { 
            HuoPingPanKu model = db.HuoPingPanKu.Find(id);
            SetHuoPingPanKu(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HuoPingPanKu SetHuoPingPanKu(HuoPingPanKu model, HuoPingPanKuReq data)
        {
             if(data.HPId != null) model.HPId = data.HPId.Value;
if(!string.IsNullOrEmpty(data.HPName)) model.HPName = data.HPName;
if(data.SinglePrice != null) model.SinglePrice = data.SinglePrice.Value;
if(!string.IsNullOrEmpty(data.Supplier)) model.Supplier = data.Supplier;
if(!string.IsNullOrEmpty(data.ChangjiaXinghao)) model.ChangjiaXinghao = data.ChangjiaXinghao;
if(!string.IsNullOrEmpty(data.PinPai)) model.PinPai = data.PinPai;
if(data.CurKuCun != null) model.CurKuCun = data.CurKuCun.Value;
if(data.PanKuNum != null) model.PanKuNum = data.PanKuNum.Value;
if(data.ChaYiNum != null) model.ChaYiNum = data.ChaYiNum.Value;
if(!string.IsNullOrEmpty(data.PanKuRen)) model.PanKuRen = data.PanKuRen;
if(!string.IsNullOrEmpty(data.PanKuDate)) model.PanKuDate = data.PanKuDate;
if(!string.IsNullOrEmpty(data.PanKuState)) model.PanKuState = data.PanKuState;
 
            return model;
        }

        /// <summary>
        /// 查询HuoPingPanKu
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingPanKu> SearchList(HuoPingPanKuReq req)
        {
            var query = from source in db.HuoPingPanKu select source;
            if(req.HPId != null) query = query.Where(d => d.HPId == req.HPId);
if(!string.IsNullOrEmpty(req.HPName)) query = query.Where(d => d.HPName.Contains(req.HPName));
if(req.SinglePrice != null) query = query.Where(d => d.SinglePrice == req.SinglePrice);
if(!string.IsNullOrEmpty(req.Supplier)) query = query.Where(d => d.Supplier.Contains(req.Supplier));
if(!string.IsNullOrEmpty(req.ChangjiaXinghao)) query = query.Where(d => d.ChangjiaXinghao.Contains(req.ChangjiaXinghao));
if(!string.IsNullOrEmpty(req.PinPai)) query = query.Where(d => d.PinPai.Contains(req.PinPai));
if(req.CurKuCun != null) query = query.Where(d => d.CurKuCun == req.CurKuCun);
if(req.PanKuNum != null) query = query.Where(d => d.PanKuNum == req.PanKuNum);
if(req.ChaYiNum != null) query = query.Where(d => d.ChaYiNum == req.ChaYiNum);
if(!string.IsNullOrEmpty(req.PanKuRen)) query = query.Where(d => d.PanKuRen.Contains(req.PanKuRen));
if(!string.IsNullOrEmpty(req.PanKuDate)) query = query.Where(d => d.PanKuDate.Contains(req.PanKuDate));
if(!string.IsNullOrEmpty(req.PanKuState)) query = query.Where(d => d.PanKuState.Contains(req.PanKuState));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HuoPingPanKu> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

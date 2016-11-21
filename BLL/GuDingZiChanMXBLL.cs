


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
    public partial class guDingZiChanMXBLL
    {
        private Context db = new Context();

        public guDingZiChanMX UpdateSingle(int id, guDingZiChanMXReq data)
        {
            guDingZiChanMX model = db.guDingZiChanMX.Find(id);
            SetguDingZiChanMX(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public guDingZiChanMX SetguDingZiChanMX(guDingZiChanMX model, guDingZiChanMXReq data)
        {
            if (data.GuDingId != null) model.GuDingId = data.GuDingId.Value;
            if (!string.IsNullOrEmpty(data.zichanNum)) model.zichanNum = data.zichanNum;
            if (!string.IsNullOrEmpty(data.zichanName)) model.zichanName = data.zichanName;
            if (!string.IsNullOrEmpty(data.zichanPinPai)) model.zichanPinPai = data.zichanPinPai;
            if (!string.IsNullOrEmpty(data.zichanChangJia)) model.zichanChangJia = data.zichanChangJia;
            if (!string.IsNullOrEmpty(data.changjiaNum)) model.changjiaNum = data.changjiaNum;
            if (data.zichanShulia != null) model.zichanShulia = data.zichanShulia.Value;
            if (data.zichanSingle != null) model.zichanSingle = data.zichanSingle.Value;
            if (data.zichanJi != null) model.zichanJi = data.zichanJi.Value;
            if (!string.IsNullOrEmpty(data.zichanDiDian)) model.zichanDiDian = data.zichanDiDian;
            if (!string.IsNullOrEmpty(data.zichanUserName)) model.zichanUserName = data.zichanUserName;
            if (data.zichanUserId != null) model.zichanUserId = data.zichanUserId.Value;
            if (!string.IsNullOrEmpty(data.zichanCaiGouName)) model.zichanCaiGouName = data.zichanCaiGouName;
            if (data.zichanCaiGouId != null) model.zichanCaiGouId = data.zichanCaiGouId.Value;
            if (data.zichanGouRuDate != null && data.zichanGouRuDate != DateTime.MinValue && data.zichanGouRuDate != SqlDateTime.MinValue.Value) model.zichanGouRuDate = data.zichanGouRuDate.Value;
            if (!string.IsNullOrEmpty(data.zichanBeiZhu)) model.zichanBeiZhu = data.zichanBeiZhu;
            if (!string.IsNullOrEmpty(data.zichanBuChong)) model.zichanBuChong = data.zichanBuChong;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optId != null) model.optId = data.optId.Value;
            if (data.createDateTime != null && data.createDateTime != DateTime.MinValue && data.createDateTime != SqlDateTime.MinValue.Value) model.createDateTime = data.createDateTime.Value;
            if (!string.IsNullOrEmpty(data.state)) model.state = data.state;

            return model;
        }

        /// <summary>
        /// 查询guDingZiChanMX
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<guDingZiChanMX> SearchList(guDingZiChanMXReq req)
        {
            var query = from source in db.guDingZiChanMX select source;

            if (req.GuDingId != null) query = query.Where(d => d.GuDingId == req.GuDingId);
            if (!string.IsNullOrEmpty(req.zichanNum)) query = query.Where(d => d.zichanNum.Contains(req.zichanNum));
            if (!string.IsNullOrEmpty(req.zichanName)) query = query.Where(d => d.zichanName.Contains(req.zichanName));
            if (!string.IsNullOrEmpty(req.zichanPinPai)) query = query.Where(d => d.zichanPinPai.Contains(req.zichanPinPai));
            if (!string.IsNullOrEmpty(req.zichanChangJia)) query = query.Where(d => d.zichanChangJia.Contains(req.zichanChangJia));
            if (!string.IsNullOrEmpty(req.changjiaNum)) query = query.Where(d => d.changjiaNum.Contains(req.changjiaNum));
            if (req.zichanShulia != null) query = query.Where(d => d.zichanShulia == req.zichanShulia);
            if (req.zichanSingle != null) query = query.Where(d => d.zichanSingle == req.zichanSingle);
            if (req.zichanJi != null) query = query.Where(d => d.zichanJi == req.zichanJi);
            if (!string.IsNullOrEmpty(req.zichanDiDian)) query = query.Where(d => d.zichanDiDian.Contains(req.zichanDiDian));
            if (!string.IsNullOrEmpty(req.zichanUserName)) query = query.Where(d => d.zichanUserName.Contains(req.zichanUserName));
            if (req.zichanUserId != null) query = query.Where(d => d.zichanUserId == req.zichanUserId);
            if (!string.IsNullOrEmpty(req.zichanCaiGouName)) query = query.Where(d => d.zichanCaiGouName.Contains(req.zichanCaiGouName));
            if (req.zichanCaiGouId != null) query = query.Where(d => d.zichanCaiGouId == req.zichanCaiGouId);
            if (req.zichanGouRuDateStart != DateTime.MinValue && req.zichanGouRuDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.zichanGouRuDate >= req.zichanGouRuDateStart); if (req.zichanGouRuDateEnd != DateTime.MinValue && req.zichanGouRuDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime zichanGouRuDateTemp = req.zichanGouRuDateEnd.AddDays(1);
                query = query.Where(d => d.zichanGouRuDate < zichanGouRuDateTemp);
            }
            if (!string.IsNullOrEmpty(req.zichanBeiZhu)) query = query.Where(d => d.zichanBeiZhu.Contains(req.zichanBeiZhu));
            if (!string.IsNullOrEmpty(req.zichanBuChong)) query = query.Where(d => d.zichanBuChong.Contains(req.zichanBuChong));
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optId != null) query = query.Where(d => d.optId == req.optId);
            if (req.createDateTimeStart != DateTime.MinValue && req.createDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.createDateTime >= req.createDateTimeStart); if (req.createDateTimeEnd != DateTime.MinValue && req.createDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime createDateTimeTemp = req.createDateTimeEnd.AddDays(1);
                query = query.Where(d => d.createDateTime < createDateTimeTemp);
            }
            if (!string.IsNullOrEmpty(req.state)) query = query.Where(d => d.state.Contains(req.state));

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<guDingZiChanMX> retListResult = query.ToSearchList(req);
            return retListResult;
        }


        public SearchListResult<guDingZiChanMXBig> SearchListBig(guDingZiChanMXReq req)
        {
            var query = from mx in db.guDingZiChanMX
                        join zc in db.guDingZiChan on mx.GuDingId equals zc.id orderby mx.id descending 
                        select new guDingZiChanMXBig { guDingZiChanMX = mx, guDingZiChan = zc };

            if (req.GuDingId != null) query = query.Where(d => d.guDingZiChanMX.GuDingId == req.GuDingId);
            if (!string.IsNullOrEmpty(req.zichanNum)) query = query.Where(d => d.guDingZiChanMX.zichanNum.Contains(req.zichanNum));
            if (!string.IsNullOrEmpty(req.zichanName)) query = query.Where(d => d.guDingZiChanMX.zichanName.Contains(req.zichanName));
            if (!string.IsNullOrEmpty(req.zichanPinPai)) query = query.Where(d => d.guDingZiChanMX.zichanPinPai.Contains(req.zichanPinPai));
            if (!string.IsNullOrEmpty(req.zichanChangJia)) query = query.Where(d => d.guDingZiChanMX.zichanChangJia.Contains(req.zichanChangJia));
            if (!string.IsNullOrEmpty(req.changjiaNum)) query = query.Where(d => d.guDingZiChanMX.changjiaNum.Contains(req.changjiaNum));
            if (req.zichanShulia != null) query = query.Where(d => d.guDingZiChanMX.zichanShulia == req.zichanShulia);
            if (req.zichanSingle != null) query = query.Where(d => d.guDingZiChanMX.zichanSingle == req.zichanSingle);
            if (req.zichanJi != null) query = query.Where(d => d.guDingZiChanMX.zichanJi == req.zichanJi);
            if (!string.IsNullOrEmpty(req.zichanDiDian)) query = query.Where(d => d.guDingZiChanMX.zichanDiDian.Contains(req.zichanDiDian));
            if (!string.IsNullOrEmpty(req.zichanUserName)) query = query.Where(d => d.guDingZiChanMX.zichanUserName.Contains(req.zichanUserName));
            if (req.zichanUserId != null) query = query.Where(d => d.guDingZiChanMX.zichanUserId == req.zichanUserId);
            if (!string.IsNullOrEmpty(req.zichanCaiGouName)) query = query.Where(d => d.guDingZiChanMX.zichanCaiGouName.Contains(req.zichanCaiGouName));
            if (req.zichanCaiGouId != null) query = query.Where(d => d.guDingZiChanMX.zichanCaiGouId == req.zichanCaiGouId);
            if (req.zichanGouRuDateStart != DateTime.MinValue && req.zichanGouRuDateStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.guDingZiChanMX.zichanGouRuDate >= req.zichanGouRuDateStart); if (req.zichanGouRuDateEnd != DateTime.MinValue && req.zichanGouRuDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime zichanGouRuDateTemp = req.zichanGouRuDateEnd.AddDays(1);
                query = query.Where(d => d.guDingZiChanMX.zichanGouRuDate < zichanGouRuDateTemp);
            }
            if (!string.IsNullOrEmpty(req.zichanBeiZhu)) query = query.Where(d => d.guDingZiChanMX.zichanBeiZhu.Contains(req.zichanBeiZhu));
            if (!string.IsNullOrEmpty(req.zichanBuChong)) query = query.Where(d => d.guDingZiChanMX.zichanBuChong.Contains(req.zichanBuChong));
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.guDingZiChanMX.optName.Contains(req.optName));
            if (req.optId != null) query = query.Where(d => d.guDingZiChanMX.optId == req.optId);
            if (req.createDateTimeStart != DateTime.MinValue && req.createDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.guDingZiChanMX.createDateTime >= req.createDateTimeStart); if (req.createDateTimeEnd != DateTime.MinValue && req.createDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime createDateTimeTemp = req.createDateTimeEnd.AddDays(1);
                query = query.Where(d => d.guDingZiChanMX.createDateTime < createDateTimeTemp);
            }
            if (!string.IsNullOrEmpty(req.state)) query = query.Where(d => d.guDingZiChanMX.state.Contains(req.state));

            //if (string.IsNullOrEmpty(req.sidx))
            //{
            //    req.sidx = "guDingZiChanMX.id";
            //    req.sord = "desc";
            //}
            //query = query.OrderByDescending(n => n.guDingZiChanMX.id);

            SearchListResult<guDingZiChanMXBig> retListResult = query.ToSearchList(req,false);
            return retListResult;
        }
    }
}

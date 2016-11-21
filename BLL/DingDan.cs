using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using OUDAL.ModelBase;
using OUDAL.BLL;
using OUDAL.Model.Sales;

namespace OUDAL
{
    public class DingDanBLL
    {
        private YueSaoErpContext db = new YueSaoErpContext();

        public DingDan UpdateSingle(int id, DingDan data)
        {
            DingDan model = db.DingDan.Find(id);
            SetDingDan(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public DingDan SetDingDan(DingDan model, DingDan data)
        {
            if (!string.IsNullOrEmpty(data.DDName)) model.DDName = data.DDName;
            if (!string.IsNullOrEmpty(data.DDNumber)) model.DDNumber = data.DDNumber;
            if (data.ysID != null) model.ysID = data.ysID;
            if (!string.IsNullOrEmpty(data.DDStateID)) model.DDStateID = data.DDStateID;
            if (!string.IsNullOrEmpty(data.DDInfos)) model.DDInfos = data.DDInfos;
            if (data.DDCompanyID != null) model.DDCompanyID = data.DDCompanyID;
            if (!string.IsNullOrEmpty(data.DDLaiYuanID)) model.DDLaiYuanID = data.DDLaiYuanID;
            if (data.DDFuWuXiangMuID != null) model.DDFuWuXiangMuID = data.DDFuWuXiangMuID;
            if (!string.IsNullOrEmpty(data.DDFuWuAddress)) model.DDFuWuAddress = data.DDFuWuAddress;
            if (data.DDFuWuYuYueBeginTime != DateTime.MinValue && data.DDFuWuYuYueBeginTime != SqlDateTime.MinValue.Value) model.DDFuWuYuYueBeginTime = data.DDFuWuYuYueBeginTime;
            if (data.DDFuWuYuYueEndTime != DateTime.MinValue && data.DDFuWuYuYueEndTime != SqlDateTime.MinValue.Value) model.DDFuWuYuYueEndTime = data.DDFuWuYuYueEndTime;
            if (data.DDFuWuBeginTime != DateTime.MinValue && data.DDFuWuBeginTime != SqlDateTime.MinValue.Value) model.DDFuWuBeginTime = data.DDFuWuBeginTime;
            if (data.DDFuWuEndTime != DateTime.MinValue && data.DDFuWuEndTime != SqlDateTime.MinValue.Value) model.DDFuWuEndTime = data.DDFuWuEndTime;
            if (!string.IsNullOrEmpty(data.DDKeFuComments)) model.DDKeFuComments = data.DDKeFuComments;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.DDCreateTime != DateTime.MinValue && data.DDCreateTime != SqlDateTime.MinValue.Value) model.DDCreateTime = data.DDCreateTime;
            if (!string.IsNullOrEmpty(data.DDYeWuName)) model.DDYeWuName = data.DDYeWuName;
            if (!string.IsNullOrEmpty(data.CustomName)) model.CustomName = data.CustomName;
            if (!string.IsNullOrEmpty(data.ysName)) model.ysName = data.ysName;
            if (!string.IsNullOrEmpty(data.DDFuWuXiangMuName)) model.DDFuWuXiangMuName = data.DDFuWuXiangMuName;
            if (data.ProjectId != null) model.ProjectId = data.ProjectId;
            if (!string.IsNullOrEmpty(data.DDLianXiRen)) model.DDLianXiRen = data.DDLianXiRen;
            if (!string.IsNullOrEmpty(data.DDLianXiRenPhone)) model.DDLianXiRenPhone = data.DDLianXiRenPhone;
            if (data.parentDDID != null) model.parentDDID = data.parentDDID;
            if (data.YongjinMoney != null) model.YongjinMoney = data.YongjinMoney;
            if (!string.IsNullOrEmpty(data.YunxingCheckedName)) model.YunxingCheckedName = data.YunxingCheckedName;
            if (data.YunxingCheckedDateTime != DateTime.MinValue && data.YunxingCheckedDateTime != SqlDateTime.MinValue.Value) model.YunxingCheckedDateTime = data.YunxingCheckedDateTime;
            if (!string.IsNullOrEmpty(data.ZongCaiCheckedName)) model.ZongCaiCheckedName = data.ZongCaiCheckedName;
            if (data.ZongCaiCheckedDateTime != DateTime.MinValue && data.ZongCaiCheckedDateTime != SqlDateTime.MinValue.Value) model.ZongCaiCheckedDateTime = data.ZongCaiCheckedDateTime;
            if (!string.IsNullOrEmpty(data.CaiWuZhiFuName)) model.CaiWuZhiFuName = data.CaiWuZhiFuName;
            if (data.CaiWuZhiFuDateTime != DateTime.MinValue && data.CaiWuZhiFuDateTime != SqlDateTime.MinValue.Value) model.CaiWuZhiFuDateTime = data.CaiWuZhiFuDateTime;
            if (!string.IsNullOrEmpty(data.CaiWuZhifFuPingZhen)) model.CaiWuZhifFuPingZhen = data.CaiWuZhifFuPingZhen;
            if (!string.IsNullOrEmpty(data.YongjinState)) model.YongjinState = data.YongjinState;
            if (data.DingdanStateDateTime != DateTime.MinValue && data.DingdanStateDateTime != SqlDateTime.MinValue.Value) model.DingdanStateDateTime = data.DingdanStateDateTime;
            if (!string.IsNullOrEmpty(data.DDBaoXianHao)) model.DDBaoXianHao = data.DDBaoXianHao;
            if (!string.IsNullOrEmpty(data.DDFuWuDian)) model.DDFuWuDian = data.DDFuWuDian;

            return model;
        }
        private readonly Context _dbys = new Context();
        public SearchListResult<DingDan> SearchList(string projectName, DingDanReq req)
        {
            var query = from source in db.DingDan select source;
            //  if(req.CustomId != null) query = query.Where(d => d.CustomId == req.CustomId);
            if (!string.IsNullOrEmpty(req.DDName)) query = query.Where(d => d.DDName.Contains(req.DDName));
            if (!string.IsNullOrEmpty(req.DDNumber)) query = query.Where(d => d.DDNumber.Contains(req.DDNumber));

            if (req.DDMoeny != null) query = query.Where(d => d.DDMoeny == req.DDMoeny);
            if (req.DDRealMoney != null) query = query.Where(d => d.DDRealMoney == req.DDRealMoney);
            if (req.DDDingJin != null) query = query.Where(d => d.DDDingJin == req.DDDingJin);
            if (req.DDYuFu != null) query = query.Where(d => d.DDYuFu == req.DDYuFu);
            if (req.DDYuKuan != null) query = query.Where(d => d.DDYuKuan == req.DDYuKuan);
            if (req.ysID != null) query = query.Where(d => d.ysID == req.ysID);
            if (!string.IsNullOrEmpty(req.DDStateID)) query = query.Where(d => d.DDStateID.Contains(req.DDStateID));
            if (!string.IsNullOrEmpty(req.DDInfos)) query = query.Where(d => d.DDInfos.Contains(req.DDInfos));
            if (req.DDCompanyID != null) query = query.Where(d => d.DDCompanyID == req.DDCompanyID);
            if (!string.IsNullOrEmpty(req.DDLaiYuanID)) query = query.Where(d => d.DDLaiYuanID.Contains(req.DDLaiYuanID));
            if (req.DDFuWuXiangMuID != null) query = query.Where(d => d.DDFuWuXiangMuID == req.DDFuWuXiangMuID);
            if (!string.IsNullOrEmpty(req.DDFuWuAddress)) query = query.Where(d => d.DDFuWuAddress.Contains(req.DDFuWuAddress));
            if (req.DDFuWuYuYueBeginTimeStart != DateTime.MinValue && req.DDFuWuYuYueBeginTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuYuYueBeginTime >= req.DDFuWuYuYueBeginTimeStart);
            if (req.DDFuWuYuYueBeginTimeEnd != DateTime.MinValue && req.DDFuWuYuYueBeginTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuYuYueBeginTime >= req.DDFuWuYuYueBeginTimeEnd);
            if (req.DDFuWuYuYueEndTimeStart != DateTime.MinValue && req.DDFuWuYuYueEndTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuYuYueEndTime >= req.DDFuWuYuYueEndTimeStart);
            if (req.DDFuWuYuYueEndTimeEnd != DateTime.MinValue && req.DDFuWuYuYueEndTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuYuYueEndTime >= req.DDFuWuYuYueEndTimeEnd);
            if (req.DDFuWuBeginTimeStart != DateTime.MinValue && req.DDFuWuBeginTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuBeginTime >= req.DDFuWuBeginTimeStart);
            if (req.DDFuWuBeginTimeEnd != DateTime.MinValue && req.DDFuWuBeginTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuBeginTime >= req.DDFuWuBeginTimeEnd);
            if (req.DDFuWuEndTimeStart != DateTime.MinValue && req.DDFuWuEndTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuEndTime >= req.DDFuWuEndTimeStart);
            if (req.DDFuWuEndTimeEnd != DateTime.MinValue && req.DDFuWuEndTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDFuWuEndTime >= req.DDFuWuEndTimeEnd);
            if (!string.IsNullOrEmpty(req.DDKeFuComments)) query = query.Where(d => d.DDKeFuComments.Contains(req.DDKeFuComments));
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
            if (req.DDCreateTimeStart != DateTime.MinValue && req.DDCreateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDCreateTime >= req.DDCreateTimeStart);
            if (req.DDCreateTimeEnd != DateTime.MinValue && req.DDCreateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.DDCreateTime <= req.DDCreateTimeEnd);
            if (!string.IsNullOrEmpty(req.DDYeWuName)) query = query.Where(d => d.DDYeWuName.Contains(req.DDYeWuName));
            if (!string.IsNullOrWhiteSpace(projectName))
            {
                var sales = _dbys.SalesTable.Where(n => n.salesDepart == projectName).Select(n => n.salesName).ToList();

                query = query.Where(d => sales.Contains(d.DDYeWuName));
            }
            if (!string.IsNullOrEmpty(req.CustomName)) query = query.Where(d => d.CustomName.Contains(req.CustomName));
            if (!string.IsNullOrEmpty(req.ysName)) query = query.Where(d => d.ysName.Contains(req.ysName));
            if (!string.IsNullOrEmpty(req.DDFuWuXiangMuName)) query = query.Where(d => d.DDFuWuXiangMuName.Contains(req.DDFuWuXiangMuName));
            if (req.PayStatus != null) query = query.Where(d => d.PayStatus == req.PayStatus);
            //if (req.ProjectId != null) query = query.Where(d => d.ProjectId == req.ProjectId);
            if (!string.IsNullOrEmpty(req.DDLianXiRen)) query = query.Where(d => d.DDLianXiRen.Contains(req.DDLianXiRen));
            if (!string.IsNullOrEmpty(req.DDLianXiRenPhone)) query = query.Where(d => d.DDLianXiRenPhone.Contains(req.DDLianXiRenPhone));
            if (req.parentDDID != null) query = query.Where(d => d.parentDDID == req.parentDDID);
            if (req.DDPingJiaState != null) query = query.Where(d => d.DDPingJiaState == req.DDPingJiaState);
            if (req.YongjinMoney != null) query = query.Where(d => d.YongjinMoney == req.YongjinMoney);
            if (!string.IsNullOrEmpty(req.YunxingCheckedName)) query = query.Where(d => d.YunxingCheckedName.Contains(req.YunxingCheckedName));
            if (req.YunxingCheckedDateTimeStart != DateTime.MinValue && req.YunxingCheckedDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.YunxingCheckedDateTime >= req.YunxingCheckedDateTimeStart);
            if (req.YunxingCheckedDateTimeEnd != DateTime.MinValue && req.YunxingCheckedDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.YunxingCheckedDateTime >= req.YunxingCheckedDateTimeEnd);
            if (!string.IsNullOrEmpty(req.ZongCaiCheckedName)) query = query.Where(d => d.ZongCaiCheckedName.Contains(req.ZongCaiCheckedName));
            if (req.ZongCaiCheckedDateTimeStart != DateTime.MinValue && req.ZongCaiCheckedDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ZongCaiCheckedDateTime >= req.ZongCaiCheckedDateTimeStart);
            if (req.ZongCaiCheckedDateTimeEnd != DateTime.MinValue && req.ZongCaiCheckedDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ZongCaiCheckedDateTime >= req.ZongCaiCheckedDateTimeEnd);
            if (!string.IsNullOrEmpty(req.CaiWuZhiFuName)) query = query.Where(d => d.CaiWuZhiFuName.Contains(req.CaiWuZhiFuName));
            if (req.CaiWuZhiFuDateTimeStart != DateTime.MinValue && req.CaiWuZhiFuDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.CaiWuZhiFuDateTime >= req.CaiWuZhiFuDateTimeStart);
            if (req.CaiWuZhiFuDateTimeEnd != DateTime.MinValue && req.CaiWuZhiFuDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.CaiWuZhiFuDateTime >= req.CaiWuZhiFuDateTimeEnd);
            if (!string.IsNullOrEmpty(req.CaiWuZhifFuPingZhen)) query = query.Where(d => d.CaiWuZhifFuPingZhen.Contains(req.CaiWuZhifFuPingZhen));
            if (!string.IsNullOrEmpty(req.YongjinState)) query = query.Where(d => d.YongjinState.Contains(req.YongjinState));
            if (req.DingdanStateDateTimeStart != DateTime.MinValue && req.DingdanStateDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.DingdanStateDateTime >= req.DingdanStateDateTimeStart);
            if (req.DingdanStateDateTimeEnd != DateTime.MinValue && req.DingdanStateDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.DingdanStateDateTime >= req.DingdanStateDateTimeEnd);
            if (!string.IsNullOrEmpty(req.DDBaoXianHao)) query = query.Where(d => d.DDBaoXianHao.Contains(req.DDBaoXianHao));
            if (!string.IsNullOrEmpty(req.DDFuWuDian)) query = query.Where(d => d.DDFuWuDian.Contains(req.DDFuWuDian));

            // query = query.OrderByDescending(d => d.id);

            //req.sidx = "DDFuWuDian";
            //eval("var a=111");
            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            //query.OrderByDescending(d => req.sidx);

            //IOrderedQueryable<DingDan> dingdanQuery =  BllExtension.OrderingHelper(query,req.sidx,req.sord=="desc",false);
            //db.Database.Log = log => System.Diagnostics.Debug.WriteLine(log);
            SearchListResult<DingDan> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }



}

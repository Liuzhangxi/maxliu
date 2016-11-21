using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using OUDAL.ModelBase;
using OUDAL.BLL;
using OUDAL.Model;

namespace OUDAL
{
    public class KhHeTongBLL
    {
        private Context db = new Context();
        private YueSaoErpContext sesdb = new YueSaoErpContext();
        public KhHeTong UpdateSingle(int id, KhHeTongReq data, out string error)
        {
            KhHeTong model = db.KhHeTong.Find(id);
            error = CheckKeTongSave(model, data);
            bool canUpdate = string.IsNullOrEmpty(error);
            if (!canUpdate) return model;
            SetKhHeTong(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 返回错误，为空正确
        /// </summary>
        /// <param name="model"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public string CheckKeTongSave(KhHeTong model, KhHeTongReq data)
        {
            bool canUpdate = true;
            string error = "";
            if (model.KhHTStateID == 1 && data.KhHTStateID == 2)
            {
                //从有效变到无效时，要做判断
                List<DDShouKuan> skList = db.DDShouKuan.Where(d => d.HeTongID == model.id).ToList();
                skList.ForEach(s =>
                {
                    if (s.SKState == "已付")
                    {

                        canUpdate = false;
                    }
                });

                if (!canUpdate)
                {
                    error = "有已付订单，必须调整成取消才能变为无效";
                }
            }
            return error;
        }
        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public KhHeTong SetKhHeTong(KhHeTong model, KhHeTongReq data)
        {
            if (data.KhID != null)//添加订单来源
            {
                var kehu = db.KeHu.FirstOrDefault(n => n.id == data.KhID);
                if (kehu != null)
                {
                    var seskh = sesdb.Seskehu.FirstOrDefault(n => n.id == kehu.sesKHID);
                    if (seskh != null && model.DDLaiYuanID == null) model.DDLaiYuanID = seskh.KhLaiYuan;
                }

                model.KhID = data.KhID.Value;
            }
            if (!string.IsNullOrEmpty(data.KhName)) model.KhName = data.KhName;
            if (!string.IsNullOrEmpty(data.KhPhone)) model.KhPhone = data.KhPhone;
            if (data.KhYuChanQi != null && data.KhYuChanQi != DateTime.MinValue &&
                data.KhYuChanQi != SqlDateTime.MinValue.Value) model.KhYuChanQi = data.KhYuChanQi.Value;
            if (!string.IsNullOrEmpty(data.KhHTNumber)) model.KhHTNumber = data.KhHTNumber;
            if (!string.IsNullOrEmpty(data.KhHTSerialNumber)) model.KhHTSerialNumber = data.KhHTSerialNumber;
            if (!string.IsNullOrEmpty(data.KhHTName)) model.KhHTName = data.KhHTName;
            if (!string.IsNullOrEmpty(data.KhHTHouseStyle)) model.KhHTHouseStyle = data.KhHTHouseStyle;
            if (!string.IsNullOrEmpty(data.KhHTHouseNumber)) model.KhHTHouseNumber = data.KhHTHouseNumber;
            if (data.KhHTLiveDays != null) model.KhHTLiveDays = data.KhHTLiveDays.Value;
            if (data.KhHTDingJin != null) model.KhHTDingJin = data.KhHTDingJin.Value;
            if (data.KhHTWeiKuan != null) model.KhHTWeiKuan = data.KhHTWeiKuan.Value;
            if (data.KhHTTotalMoney != null) model.KhHTTotalMoney = data.KhHTTotalMoney.Value;
            if (data.KhHTZheKouMoney != null) model.KhHTZheKouMoney = data.KhHTZheKouMoney.Value;
            if (data.KhHTRuZhuDate != null && data.KhHTRuZhuDate != DateTime.MinValue &&
                data.KhHTRuZhuDate != SqlDateTime.MinValue.Value) model.KhHTRuZhuDate = data.KhHTRuZhuDate.Value;
            if (data.KhHTChuSuoDate != null && data.KhHTChuSuoDate != DateTime.MinValue &&
                data.KhHTChuSuoDate != SqlDateTime.MinValue.Value) model.KhHTChuSuoDate = data.KhHTChuSuoDate.Value;
            if (data.KhHTMuYingBaoXian != null) model.KhHTMuYingBaoXian = data.KhHTMuYingBaoXian.Value;
            if (!string.IsNullOrEmpty(data.KhHTXieYiShiXiang)) model.KhHTXieYiShiXiang = data.KhHTXieYiShiXiang;
            if (data.KhHTStateID != null) model.KhHTStateID = data.KhHTStateID.Value;
            if (!string.IsNullOrEmpty(data.KhHTSales)) model.KhHTSales = data.KhHTSales;
            if (data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (data.KhRoomId != null) model.KhRoomId = data.KhRoomId;
            if (data.ChildCount != null) model.ChildCount = data.ChildCount;
            if (data.SignDateTime != null) model.SignDateTime = data.SignDateTime;
            if (data.KhHTSalesID != null) model.KhHTSalesID = data.KhHTSalesID;
            if (data.KhHTSalesSystemId != null) model.KhHTSalesSystemId = data.KhHTSalesSystemId;

            return model;
        }

        public SearchListResult<KhHeTong> SearchList(KhHeTongReq req, out HeTongSum sum)
        {
            var query = from source in db.KhHeTong select source;
            if (req.KhID != null) query = query.Where(d => d.KhID == req.KhID);
            if (!string.IsNullOrEmpty(req.KhName)) query = query.Where(d => d.KhName.Contains(req.KhName));
            if (!string.IsNullOrEmpty(req.KhPhone)) query = query.Where(d => d.KhPhone.Contains(req.KhPhone));
            if (req.KhYuChanQiStart != DateTime.MinValue && req.KhYuChanQiStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhYuChanQi >= req.KhYuChanQiStart);
            if (req.KhYuChanQiEnd != DateTime.MinValue && req.KhYuChanQiEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhYuChanQi >= req.KhYuChanQiEnd);
            if (!string.IsNullOrEmpty(req.KhHTNumber)) query = query.Where(d => d.KhHTNumber.Contains(req.KhHTNumber));
            if (!string.IsNullOrEmpty(req.KhHTSerialNumber))
                query = query.Where(d => d.KhHTSerialNumber.Contains(req.KhHTSerialNumber));
            if (!string.IsNullOrEmpty(req.KhHTName)) query = query.Where(d => d.KhHTName.Contains(req.KhHTName));
            if (!string.IsNullOrEmpty(req.KhHTHouseStyle))
                query = query.Where(d => d.KhHTHouseStyle.Contains(req.KhHTHouseStyle));
            if (!string.IsNullOrEmpty(req.KhHTHouseNumber))
                query = query.Where(d => d.KhHTHouseNumber.Contains(req.KhHTHouseNumber));
            if (req.KhHTLiveDays != null) query = query.Where(d => d.KhHTLiveDays == req.KhHTLiveDays);
            if (req.KhHTDingJin != null) query = query.Where(d => d.KhHTDingJin == req.KhHTDingJin);
            if (req.KhHTWeiKuan != null) query = query.Where(d => d.KhHTWeiKuan == req.KhHTWeiKuan);
            if (req.KhHTTotalMoney != null) query = query.Where(d => d.KhHTTotalMoney == req.KhHTTotalMoney);
            if (req.KhHTZheKouMoney != null) query = query.Where(d => d.KhHTZheKouMoney == req.KhHTZheKouMoney);
            if (req.KhHTRuZhuDateStart != DateTime.MinValue && req.KhHTRuZhuDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhHTRuZhuDate >= req.KhHTRuZhuDateStart);
            if (req.KhHTRuZhuDateEnd != DateTime.MinValue && req.KhHTRuZhuDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhHTRuZhuDate >= req.KhHTRuZhuDateEnd);
            if (req.KhHTChuSuoDateStart != DateTime.MinValue && req.KhHTChuSuoDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhHTChuSuoDate >= req.KhHTChuSuoDateStart);
            if (req.KhHTChuSuoDateEnd != DateTime.MinValue && req.KhHTChuSuoDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhHTChuSuoDate >= req.KhHTChuSuoDateEnd);
            if (req.KhHTMuYingBaoXian != null) query = query.Where(d => d.KhHTMuYingBaoXian == req.KhHTMuYingBaoXian);
            if (!string.IsNullOrEmpty(req.KhHTXieYiShiXiang))
                query = query.Where(d => d.KhHTXieYiShiXiang.Contains(req.KhHTXieYiShiXiang));
            if (req.KhHTStateID != null)
            {
                query = query.Where(d => d.KhHTStateID == req.KhHTStateID);
            }
            else
            {
                query = query.Where(d => d.KhHTStateID == 1);
            }

            if (!string.IsNullOrEmpty(req.KhHTSales)) query = query.Where(d => d.KhHTSales.Contains(req.KhHTSales));

            if (req.KhHTSalesID != null)
            {
                query = query.Where(d => d.KhHTSalesID == req.KhHTSalesID);
            }

            if (req.KhHTSalesSystemId != null)
            {
                query = query.Where(d => d.KhHTSalesSystemId == req.KhHTSalesSystemId);
            }

            if (req.projectid != null && req.projectid.Value != 0)
                query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> projectids = req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();
                query = query.Where(d => projectids.Contains(d.ProjectID));
            }



            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime optEndTemp = req.optDateTimeEnd.AddDays(1);
                query = query.Where(d => d.optDateTime < optEndTemp);
            }
            if (!string.IsNullOrEmpty(req.ProjectName))
            {
                string[] pnameStrings = req.ProjectName.Split(","[0]);
                query = query.Where(d => pnameStrings.Contains(d.ProjectName));
            }
            if (req.ChildCount != null) query = query.Where(d => d.ChildCount == req.ChildCount);

            if (req.SignDateTimeStart != DateTime.MinValue && req.SignDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.SignDateTime >= req.SignDateTimeStart);

            if (req.SignDateTimeEnd != DateTime.MinValue && req.SignDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                var singDateTimeEnd = req.SignDateTimeEnd.AddDays(1);
                query = query.Where(d => d.SignDateTime < singDateTimeEnd);
            }


            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            sum = new HeTongSum();
            if (query.Any())
            {
                sum.DingJin = query.Sum(q => q.KhHTDingJin); //
                sum.BaoXian = query.Select(q => q.KhHTMuYingBaoXian ?? 0).Sum(); //Sum(q => q.KhHTMuYingBaoXian??0);
                sum.TotalMoney = query.Select(q => q.KhHTTotalMoney).Sum(); //Sum(q => q.KhHTTotalMoney);
                sum.WeiKuan = query.Select(q => q.KhHTWeiKuan).Sum(); //Sum(q => q.KhHTWeiKuan);
                sum.ZheKouMoney = query.Select(q => q.KhHTZheKouMoney).Sum(); //Sum(q => q.KhHTZheKouMoney);
            }
            SearchListResult<KhHeTong> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

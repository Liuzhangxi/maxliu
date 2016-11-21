using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Common.Utilities.Algorithm;
using OUDAL.ModelBase;
using OUDAL.BLL;
using OUDAL.Model;

namespace OUDAL
{
    public class KeHuBLL
    {
        private Context db = new Context();

        public KeHu UpdateSingle(int id, KeHuReq data)
        {
            KeHu model = db.KeHu.Find(id);
            SetKeHu(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public KeHu SetKeHu(KeHu model, KeHuReq data)
        {
            if (!string.IsNullOrEmpty(data.KhName)) model.KhName = data.KhName;
            if (!string.IsNullOrEmpty(data.KhPhone)) model.KhPhone = data.KhPhone;
            if (data.KhYuChanQi != null && data.KhYuChanQi != DateTime.MinValue &&
                data.KhYuChanQi != SqlDateTime.MinValue.Value) model.KhYuChanQi = data.KhYuChanQi.Value;
            if (!string.IsNullOrEmpty(data.KhHospital)) model.KhHospital = data.KhHospital;
            if (!string.IsNullOrEmpty(data.KhIDCardNumber)) model.KhIDCardNumber = data.KhIDCardNumber;
            if (!string.IsNullOrEmpty(data.KhAddress)) model.KhAddress = data.KhAddress;
            if (!string.IsNullOrEmpty(data.KhFamilyName)) model.KhFamilyName = data.KhFamilyName;
            if (!string.IsNullOrEmpty(data.KhFamilyPhone)) model.KhFamilyPhone = data.KhFamilyPhone;
            if (!string.IsNullOrEmpty(data.KhFamilyShouRu)) model.KhFamilyShouRu = data.KhFamilyShouRu;
            if (!string.IsNullOrEmpty(data.KhXueXing)) model.KhXueXing = data.KhXueXing;
            if (!string.IsNullOrEmpty(data.KhXingZuo)) model.KhXingZuo = data.KhXingZuo;
            if (!string.IsNullOrEmpty(data.KhXingGe)) model.KhXingGe = data.KhXingGe;
            if (!string.IsNullOrEmpty(data.KhGuanZhuWangZhan)) model.KhGuanZhuWangZhan = data.KhGuanZhuWangZhan;
            if (!string.IsNullOrEmpty(data.KhXiuXianFangShi)) model.KhXiuXianFangShi = data.KhXiuXianFangShi;
            if (!string.IsNullOrEmpty(data.KhYinShiXiGuan)) model.KhYinShiXiGuan = data.KhYinShiXiGuan;
            if (!string.IsNullOrEmpty(data.KhGuoMinLeiFood)) model.KhGuoMinLeiFood = data.KhGuoMinLeiFood;
            if (!string.IsNullOrEmpty(data.KhFamilyYCBS)) model.KhFamilyYCBS = data.KhFamilyYCBS;
            if (!string.IsNullOrEmpty(data.KhQiTaBingLi)) model.KhQiTaBingLi = data.KhQiTaBingLi;
            if (!string.IsNullOrEmpty(data.KhSales)) model.KhSales = data.KhSales;
 if(data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.KhRemarks)) model.KhRemarks = data.KhRemarks;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (!string.IsNullOrEmpty(data.ValidState)) model.ValidState = data.ValidState;
            if (data.KhSalesId!=null) model.KhSalesId = data.KhSalesId;
            if ( data.KhSalesSystemId!=null) model.KhSalesSystemId = data.KhSalesSystemId;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;

            if (!string.IsNullOrEmpty(data.KhState)) model.KhState = data.KhState;
            return model;
        }

        //同步喜喜会所客户到扫e嫂客户表（设置此客户为喜喜VIP并同步会所信息）
        public Seskehu SyncXixiKhToSes(KeHu xxKh)
        {
            var ysDb = new YueSaoErpContext();
            var ysKh = ysDb.Seskehu.FirstOrDefault(n => n.KhPhoneNumber == xxKh.KhPhone || n.KeFuKhPhoneNumber == xxKh.KhPhone);
            if (ysKh == null)
            {
                var huisuoId = ysDb.yuezihuiSuoInfo.Where(n => n.xixiHuisuoId == xxKh.ProjectID).Select(n => n.id).FirstOrDefault();

                if (xxKh != null)
                    ysKh = new Seskehu
                    {
                        FuWuYueSaoID = 0,
                        FuWuYueSaoName = string.Empty,
                        huisuoID = huisuoId,
                        KeFuKhPhoneNumber = xxKh.KhPhone,
                        KhAddress = xxKh.KhAddress,
                        KhAge = 30,
                        KhBabyMonth = 0,
                        KhCallClassName = string.Empty,
                        KhCallDateTime = null,
                        KhCity = string.Empty,
                        KhClassName = "会所客户",
                        KhCreateTime = DateTime.Now,
                        KhCreateTimeEnd = DateTime.Now,
                        KhCreateTimeStart = DateTime.Now,
                        KhInfos = xxKh.KhRemarks,
                        KhLaiYuan = xxKh.KhSales,
                        KhName = xxKh.KhName,
                        KhPhoneNumber = xxKh.KhPhone,
                        KhPsd = BinaryUtil.Md5(xxKh.KhPhone).Substring(6, 20),
                        KhPsdNew = string.Empty,
                        KhState = string.Empty,
                        KhWeiXin = string.Empty,
                        KhWeiXinID = string.Empty,
                        KhYeWu = string.Empty,
                        KhYuChanHospital = xxKh.KhHospital,
                        KhYuChanHospitalAddress = string.Empty,
                        KhYuChanQi =xxKh.KhYuChanQi,
                        KhYuChanQiEnd = DateTime.Now,
                        KhYuChanQiStart = DateTime.Now,
                        OptName = xxKh.optName,
                        ProjectId = 1, //默认为上海
                        SalesName = xxKh.KhSales,
                        xixiVip = 1
                    };

                ysDb.Seskehu.Add(ysKh);
            }
            else
            {
                ysKh.xixiVip = 1;
                ysKh.huisuoID =
                    ysDb.yuezihuiSuoInfo.Where(n => n.xixiHuisuoId == xxKh.ProjectID).Select(n => n.id).FirstOrDefault();
                if (string.IsNullOrWhiteSpace(ysKh.KhPhoneNumber))
                {
                    ysKh.KhPhoneNumber = ysKh.KeFuKhPhoneNumber;
                    ysKh.KhPsd = BinaryUtil.Md5(ysKh.KeFuKhPhoneNumber).Substring(6, 20);
                }
                ysKh.KhName = xxKh.KhName;
            }
            ysDb.SaveChanges();
            return ysKh;
        }



        public SearchListResult<KeHuRoom> SearchKhRoom(KeHuReq req,IQueryable<KeHuRoom> query)
        {
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> intproList =
                     req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                         .Select(p => Convert.ToInt32(p))
                         .ToList();
                query = query.Where(q => intproList.Contains(q.Kehu.ProjectID));
            }

            if (!string.IsNullOrEmpty(req.KhName)) query = query.Where(d => d.Kehu.KhName.Contains(req.KhName));
            if (!string.IsNullOrEmpty(req.KhPhone)) query = query.Where(d => d.Kehu.KhPhone.Contains(req.KhPhone));
            if (req.KhYuChanQiStart != DateTime.MinValue && req.KhYuChanQiStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.Kehu.KhYuChanQi >= req.KhYuChanQiStart);
            if (req.KhYuChanQiEnd != DateTime.MinValue && req.KhYuChanQiEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.Kehu.KhYuChanQi >= req.KhYuChanQiEnd);
            if (!string.IsNullOrEmpty(req.KhHospital)) query = query.Where(d => d.Kehu.KhHospital.Contains(req.KhHospital));
            if (!string.IsNullOrEmpty(req.KhIDCardNumber))
                query = query.Where(d => d.Kehu.KhIDCardNumber.Contains(req.KhIDCardNumber));
            if (!string.IsNullOrEmpty(req.KhAddress)) query = query.Where(d => d.Kehu.KhAddress.Contains(req.KhAddress));
            if (!string.IsNullOrEmpty(req.KhFamilyName))
                query = query.Where(d => d.Kehu.KhFamilyName.Contains(req.KhFamilyName));
            if (!string.IsNullOrEmpty(req.KhFamilyPhone))
                query = query.Where(d => d.Kehu.KhFamilyPhone.Contains(req.KhFamilyPhone));
            if (!string.IsNullOrEmpty(req.KhFamilyShouRu))
                query = query.Where(d => d.Kehu.KhFamilyShouRu.Contains(req.KhFamilyShouRu));
            if (!string.IsNullOrEmpty(req.KhXueXing)) query = query.Where(d => d.Kehu.KhXueXing.Contains(req.KhXueXing));
            if (!string.IsNullOrEmpty(req.KhXingZuo)) query = query.Where(d => d.Kehu.KhXingZuo.Contains(req.KhXingZuo));
            if (!string.IsNullOrEmpty(req.KhXingGe)) query = query.Where(d => d.Kehu.KhXingGe.Contains(req.KhXingGe));
            if (!string.IsNullOrEmpty(req.KhGuanZhuWangZhan))
                query = query.Where(d => d.Kehu.KhGuanZhuWangZhan.Contains(req.KhGuanZhuWangZhan));
            if (!string.IsNullOrEmpty(req.KhXiuXianFangShi))
                query = query.Where(d => d.Kehu.KhXiuXianFangShi.Contains(req.KhXiuXianFangShi));
            if (!string.IsNullOrEmpty(req.KhYinShiXiGuan))
                query = query.Where(d => d.Kehu.KhYinShiXiGuan.Contains(req.KhYinShiXiGuan));
            if (!string.IsNullOrEmpty(req.KhGuoMinLeiFood))
                query = query.Where(d => d.Kehu.KhGuoMinLeiFood.Contains(req.KhGuoMinLeiFood));
            if (!string.IsNullOrEmpty(req.KhFamilyYCBS))
                query = query.Where(d => d.Kehu.KhFamilyYCBS.Contains(req.KhFamilyYCBS));
            if (!string.IsNullOrEmpty(req.KhQiTaBingLi))
                query = query.Where(d => d.Kehu.KhQiTaBingLi.Contains(req.KhQiTaBingLi));
            if (!string.IsNullOrEmpty(req.KhSales)) query = query.Where(d => d.Kehu.KhSales.Contains(req.KhSales));

            if (!string.IsNullOrEmpty(req.ValidState))
                query = query.Where(d => d.Kehu.ValidState==req.ValidState);
            if (!string.IsNullOrEmpty(req.RoomNumber))
            {
                query = query.Where(q => q.RoomInfo.FangHao.Contains(req.RoomNumber));
            }

            SearchListResult<KeHuRoom> retListResult = new SearchListResult<KeHuRoom>();
            retListResult.records = query.Count();
            retListResult.rows = query.Skip((req.page - 1) * req.rows).Take(req.rows).ToList();
            retListResult.page = req.page;
            retListResult.total = (retListResult.records - 1) / req.rows + 1;

          //  SearchListResult<KeHu> retListResult = query.ToSearchList(req);
            return retListResult;
        } 

        public SearchListResult<KeHu> SearchList(KeHuReq req)
        {
            var query = from source in db.KeHu select source;
            if (!string.IsNullOrEmpty(req.KhName)) query = query.Where(d => d.KhName.Contains(req.KhName));
            if (!string.IsNullOrEmpty(req.KhPhone)) query = query.Where(d => d.KhPhone.Contains(req.KhPhone));
            if (req.KhYuChanQiStart != DateTime.MinValue && req.KhYuChanQiStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhYuChanQi >= req.KhYuChanQiStart);
            if (req.KhYuChanQiEnd != DateTime.MinValue && req.KhYuChanQiEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.KhYuChanQi >= req.KhYuChanQiEnd);
            if (!string.IsNullOrEmpty(req.KhHospital)) query = query.Where(d => d.KhHospital.Contains(req.KhHospital));
            if (!string.IsNullOrEmpty(req.KhIDCardNumber))
                query = query.Where(d => d.KhIDCardNumber.Contains(req.KhIDCardNumber));
            if (!string.IsNullOrEmpty(req.KhAddress)) query = query.Where(d => d.KhAddress.Contains(req.KhAddress));
            if (!string.IsNullOrEmpty(req.KhFamilyName))
                query = query.Where(d => d.KhFamilyName.Contains(req.KhFamilyName));
            if (!string.IsNullOrEmpty(req.KhFamilyPhone))
                query = query.Where(d => d.KhFamilyPhone.Contains(req.KhFamilyPhone));
            if (!string.IsNullOrEmpty(req.KhFamilyShouRu))
                query = query.Where(d => d.KhFamilyShouRu.Contains(req.KhFamilyShouRu));
            if (!string.IsNullOrEmpty(req.KhXueXing)) query = query.Where(d => d.KhXueXing.Contains(req.KhXueXing));
            if (!string.IsNullOrEmpty(req.KhXingZuo)) query = query.Where(d => d.KhXingZuo.Contains(req.KhXingZuo));
            if (!string.IsNullOrEmpty(req.KhXingGe)) query = query.Where(d => d.KhXingGe.Contains(req.KhXingGe));
            if (!string.IsNullOrEmpty(req.KhGuanZhuWangZhan))
                query = query.Where(d => d.KhGuanZhuWangZhan.Contains(req.KhGuanZhuWangZhan));
            if (!string.IsNullOrEmpty(req.KhXiuXianFangShi))
                query = query.Where(d => d.KhXiuXianFangShi.Contains(req.KhXiuXianFangShi));
            if (!string.IsNullOrEmpty(req.KhYinShiXiGuan))
                query = query.Where(d => d.KhYinShiXiGuan.Contains(req.KhYinShiXiGuan));
            if (!string.IsNullOrEmpty(req.KhGuoMinLeiFood))
                query = query.Where(d => d.KhGuoMinLeiFood.Contains(req.KhGuoMinLeiFood));
            if (!string.IsNullOrEmpty(req.KhFamilyYCBS))
                query = query.Where(d => d.KhFamilyYCBS.Contains(req.KhFamilyYCBS));
            if (!string.IsNullOrEmpty(req.KhQiTaBingLi))
                query = query.Where(d => d.KhQiTaBingLi.Contains(req.KhQiTaBingLi));
            if (!string.IsNullOrEmpty(req.KhSales)) query = query.Where(d => d.KhSales.Contains(req.KhSales));
            if (req.projectid != null && req.projectid.Value != 0)
                query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.ValidState))
            {
                if(req.ValidState=="有效")
                    query = query.Where(d => d.ValidState != "无效");
                else
                {
                    query = query.Where(d => d.ValidState == req.ValidState);
                }
               
            }
            if (!string.IsNullOrEmpty(req.projectids))
            {
                List<int> intproList =
                    req.projectids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(p => Convert.ToInt32(p))
                        .ToList();

                query = query.Where(d => intproList.Contains(d.ProjectID));
            }



            if (!string.IsNullOrEmpty(req.KhRemarks)) query = query.Where(d => d.KhRemarks.Contains(req.KhRemarks));
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);

            if (!string.IsNullOrEmpty(req.ProjectName))
            {
                string[] pnameStrings = req.ProjectName.Split(","[0]);
                query = query.Where(d => pnameStrings.Contains(d.ProjectName));
            }

            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<KeHu> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}




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
    public class DDShouKuanBLL
    {
        private Context db = new Context();
        //public decimal GetCacheSKByProject(int projectid)
        //{
        //   List<DDShouKuan> ddShouKuans = db.DDShouKuan.Where(d => d.SKFangShi == "现金" && d.ProjectID == projectid && d.SKState != "InValid").ToList();
        //    return ddShouKuans.Sum(d => d.SKMoney);
        //}
        //public decimal GetBankSKByProject(int projectid)
        //{
        //    List<DDShouKuan> ddShouKuans = db.DDShouKuan.Where(d => d.SKFangShi != "现金" && d.ProjectID == projectid && d.SKState != "InValid").ToList();
        //    return ddShouKuans.Sum(d => d.SKMoney);
        //}
        public DDShouKuan UpdateSingle(int id, DDShouKuanReq data)
        {
            DDShouKuan model = db.DDShouKuan.Find(id);
            SetDDShouKuan(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public DDShouKuan SetDDShouKuan(DDShouKuan model, DDShouKuanReq data)
        {
            if (data.HeTongID != null) model.HeTongID = data.HeTongID.Value;
            if (!string.IsNullOrEmpty(data.HeTongNumber)) model.HeTongNumber = data.HeTongNumber;
            if (!string.IsNullOrEmpty(data.HeTongName)) model.HeTongName = data.HeTongName;
            if (data.KhID != null) model.KhID = data.KhID.Value;
            if (!string.IsNullOrEmpty(data.KhName)) model.KhName = data.KhName;
            if (!string.IsNullOrEmpty(data.SKName)) model.SKName = data.SKName;
            if (data.SKMoney != null) model.SKMoney = data.SKMoney.Value;
            if (!string.IsNullOrEmpty(data.SKPayOnlieNumber)) model.SKPayOnlieNumber = data.SKPayOnlieNumber;
            if (data.SKDateTime != null && data.SKDateTime != DateTime.MinValue &&
                data.SKDateTime != SqlDateTime.MinValue.Value) model.SKDateTime = data.SKDateTime.Value;
            //if (!string.IsNullOrEmpty(data.SKInfos))
                model.SKInfos = data.SKInfos;
            if (!string.IsNullOrEmpty(data.ServerMsg)) model.ServerMsg = data.ServerMsg;
            if (data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;

            if (!string.IsNullOrEmpty(data.SKClass)) model.SKClass = data.SKClass;
            if (!string.IsNullOrEmpty(data.SKState)) model.SKState = data.SKState;
            if (!string.IsNullOrEmpty(data.SKFangShi)) model.SKFangShi = data.SKFangShi;
            if (!string.IsNullOrEmpty(data.SKNumber)) model.SKNumber = data.SKNumber;
            if (data.JiaoGeId != null) model.JiaoGeId = data.JiaoGeId.Value;
            
            return model;
        }

        public SearchListResult<DDShouKuan> SearchList(DDShouKuanReq req,out ShouKuanSum sum,bool isFromJiaoge=false)
        {
            var query = from source in db.DDShouKuan select source;
            if (req.HeTongID != null) query = query.Where(d => d.HeTongID == req.HeTongID);
            if (!string.IsNullOrEmpty(req.HeTongNumber))
                query = query.Where(d => d.HeTongNumber.Contains(req.HeTongNumber));
            if (!string.IsNullOrEmpty(req.HeTongName)) query = query.Where(d => d.HeTongName.Contains(req.HeTongName));
            if (req.KhID != null) query = query.Where(d => d.KhID == req.KhID);
            if (!string.IsNullOrEmpty(req.KhName)) query = query.Where(d => d.KhName.Contains(req.KhName));
            if (!string.IsNullOrEmpty(req.SKName)) query = query.Where(d => d.SKName.Contains(req.SKName));
            if (req.SKMoney != null) query = query.Where(d => d.SKMoney == req.SKMoney);

            if (!string.IsNullOrEmpty(req.SKPayOnlieNumber))
                query = query.Where(d => d.SKPayOnlieNumber.Contains(req.SKPayOnlieNumber));
            if (req.SKDateTimeStart != DateTime.MinValue && req.SKDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.SKDateTime >= req.SKDateTimeStart);
            if (req.SKDateTimeEnd != DateTime.MinValue && req.SKDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.SKDateTime <= req.SKDateTimeEnd);

            if (!string.IsNullOrEmpty(req.SKInfos)) query = query.Where(d => d.SKInfos.Contains(req.SKInfos));
            if (req.projectid != null && req.projectid.Value != 0)
                query = query.Where(d => d.ProjectID == req.projectid);
         

            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);

            if (!string.IsNullOrEmpty(req.SKClass)) query = query.Where(d => d.SKClass.Contains(req.SKClass));
            if (!string.IsNullOrEmpty(req.SKState))
            {
                query = query.Where(d => d.SKState==req.SKState);
            }
            else
            {
                query = query.Where(d => d.SKState == "已付");
            }
            if (!string.IsNullOrEmpty(req.SKFangShi)) query = query.Where(d => d.SKFangShi.Contains(req.SKFangShi));
            if (!string.IsNullOrEmpty(req.SKNumber)) query = query.Where(d => d.SKNumber.Contains(req.SKNumber));

          
                 if (!string.IsNullOrEmpty(req.projectids))
            {
                string[] idStrings = req.projectids.Split(","[0]);
                query = query.Where(d => idStrings.Contains(d.ProjectID.ToString()));
            }
            if (!string.IsNullOrEmpty(req.ProjectName))
            {
                string[] pnameStrings = req.ProjectName.Split(","[0]);
                query = query.Where(d => pnameStrings.Contains(d.ProjectName));
            }
            if (req.JiaoGeId != null && req.JiaoGeId.Value != 0)
                query = query.Where(d => d.JiaoGeId == req.JiaoGeId);
            if (isFromJiaoge)
            {
                query = query.Where(d => d.SKMoney > 0 );
            }
            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<DDShouKuan> retListResult = query.ToSearchList(req);

            sum = new ShouKuanSum();
            if (query.Any())
            {
                sum.SkJing = query.Sum(q => q.SKMoney); // 
            }
            return retListResult;
        }
    }
}

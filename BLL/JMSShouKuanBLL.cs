


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
    public partial class JMSShouKuanBLL
    {
        private Context db = new Context();

        public JMSShouKuan UpdateSingle(int id, JMSShouKuanReq data)
        {
            JMSShouKuan model = db.JMSShouKuan.Find(id);
            SetJMSShouKuan(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSShouKuan SetJMSShouKuan(JMSShouKuan model, JMSShouKuanReq data)
        {
            if (data.JmsShouKuanRuleId != null) model.JmsShouKuanRuleId = data.JmsShouKuanRuleId.Value;
            if (!string.IsNullOrEmpty(data.ShouKuanType)) model.ShouKuanType = data.ShouKuanType;
            if (data.ShouKuanMoney != null) model.ShouKuanMoney = data.ShouKuanMoney.Value;
            if (data.ShouKuanTime != null && data.ShouKuanTime != DateTime.MinValue &&
                data.ShouKuanTime != SqlDateTime.MinValue.Value) model.ShouKuanTime = data.ShouKuanTime.Value;
            if (!string.IsNullOrEmpty(data.ShouKuanState)) model.ShouKuanState = data.ShouKuanState;
            if (data.ShouKuanConfirmerId != null) model.ShouKuanConfirmerId = data.ShouKuanConfirmerId.Value;
            if (!string.IsNullOrEmpty(data.ShouKuanConfirmerName))
                model.ShouKuanConfirmerName = data.ShouKuanConfirmerName;
            if (data.ShouKuanConfirmDate != null && data.ShouKuanConfirmDate != DateTime.MinValue &&
                data.ShouKuanConfirmDate != SqlDateTime.MinValue.Value)
                model.ShouKuanConfirmDate = data.ShouKuanConfirmDate.Value;
            if (data.OptId != null) model.OptId = data.OptId.Value;
            if (!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
            if (data.Createdate != null && data.Createdate != DateTime.MinValue &&
                data.Createdate != SqlDateTime.MinValue.Value) model.Createdate = data.Createdate.Value;

            return model;
        }

        /// <summary>
        /// 查询JMSShouKuan
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<ShouKuanInfo> SearchList(JMSShouKuanReq req)
        {

            var query = from source in db.JMSShouKuan
                join rule in db.JMSShouKuanRule on source.JmsShouKuanRuleId equals rule.id
                select new ShouKuanInfo {JMSShouKuan = source, JMSShouKuanRule = rule};
            if (!string.IsNullOrEmpty(req.JmsIds))
            {
                List<int> intJids = req.JmsIds.Split(","[0]).Select(d=>Convert.ToInt32(d)).ToList();
                    query = from source in db.JMSShouKuan join rule in db.JMSShouKuanRule on source.JmsShouKuanRuleId equals rule.id where intJids.Contains( rule.JmsId.Value) select new ShouKuanInfo { JMSShouKuan = source, JMSShouKuanRule = rule };

            }
              
            if (req.JmsShouKuanRuleId != null) query = query.Where(d => d.JMSShouKuan.JmsShouKuanRuleId == req.JmsShouKuanRuleId);
            if (!string.IsNullOrEmpty(req.ShouKuanType))
            {
                List<string> shoukuanTypes =  req.ShouKuanType.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                    query = query.Where(d => shoukuanTypes.Contains(d.JMSShouKuan.ShouKuanType));
            }
            if (req.ShouKuanMoney != null) query = query.Where(d => d.JMSShouKuan.ShouKuanMoney == req.ShouKuanMoney);
            if (req.ShouKuanTimeStart != DateTime.MinValue && req.ShouKuanTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.JMSShouKuan.ShouKuanTime >= req.ShouKuanTimeStart);
            if (req.ShouKuanTimeEnd != DateTime.MinValue && req.ShouKuanTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.JMSShouKuan.ShouKuanTime >= req.ShouKuanTimeEnd);
            if (!string.IsNullOrEmpty(req.ShouKuanState))
                query = query.Where(d => d.JMSShouKuan.ShouKuanState.Contains(req.ShouKuanState));
            if (req.ShouKuanConfirmerId != null)
                query = query.Where(d => d.JMSShouKuan.ShouKuanConfirmerId == req.ShouKuanConfirmerId);
            if (!string.IsNullOrEmpty(req.ShouKuanConfirmerName))
                query = query.Where(d => d.JMSShouKuan.ShouKuanConfirmerName.Contains(req.ShouKuanConfirmerName));
            if (req.ShouKuanConfirmDateStart != DateTime.MinValue &&
                req.ShouKuanConfirmDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.JMSShouKuan.ShouKuanConfirmDate >= req.ShouKuanConfirmDateStart);
            if (req.ShouKuanConfirmDateEnd != DateTime.MinValue &&
                req.ShouKuanConfirmDateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.JMSShouKuan.ShouKuanConfirmDate >= req.ShouKuanConfirmDateEnd);
           
            if (!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.JMSShouKuan.OptName.Contains(req.OptName));
            if (req.CreatedateStart != DateTime.MinValue && req.CreatedateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.JMSShouKuan.Createdate >= req.CreatedateStart);
            if (req.CreatedateEnd != DateTime.MinValue && req.CreatedateEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.JMSShouKuan.Createdate >= req.CreatedateEnd);

            #region 数据权限 
            if (req.OptId != null && req.OptId.Value != 0)
            {
                //组长能看到所有，
                List<int> subUserIds = DepartmentBLL.GetSubSystemUsers(req.OptId.Value);
                query = query.Where(d => d.JMSShouKuan.OptId == null || subUserIds.Contains(d.JMSShouKuan.OptId.Value));
            }
            #endregion
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "JMSShouKuan";
                req.sord = "desc";
            }
           
            SearchListResult<ShouKuanInfo> retListResult = query.ToSearchShouKuanInfoList(req);
            return retListResult;
        }
    }
}

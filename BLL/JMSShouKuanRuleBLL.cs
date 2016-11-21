


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
    public partial class JMSShouKuanRuleBLL
    { 
        private Context db = new Context();

        public JMSShouKuanRule UpdateSingle(int id, JMSShouKuanRuleReq data)
        { 
            JMSShouKuanRule model = db.JMSShouKuanRule.Find(id);
            SetJMSShouKuanRule(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  JMSShouKuanRule SetJMSShouKuanRule(JMSShouKuanRule model, JMSShouKuanRuleReq data)
        {
             if(data.JmsId != null) model.JmsId = data.JmsId.Value;
if(!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
if(!string.IsNullOrEmpty(data.JmsClassName)) model.JmsClassName = data.JmsClassName;
if(!string.IsNullOrEmpty(data.ShouKuanType)) model.ShouKuanType = data.ShouKuanType;
if(data.ShouKuanMoney != null) model.ShouKuanMoney = data.ShouKuanMoney.Value;
if(data.StartTime != null && data.StartTime != DateTime.MinValue && data.StartTime != SqlDateTime.MinValue.Value) model.StartTime = data.StartTime.Value;
if(data.ShouKuanTime != null && data.ShouKuanTime != DateTime.MinValue && data.ShouKuanTime != SqlDateTime.MinValue.Value) model.ShouKuanTime = data.ShouKuanTime.Value;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.Createtime != null && data.Createtime != DateTime.MinValue && data.Createtime != SqlDateTime.MinValue.Value) model.Createtime = data.Createtime.Value;
 
            return model;
        }

        /// <summary>
        /// 查询JMSShouKuanRule
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<JMSShouKuanRule> SearchList(JMSShouKuanRuleReq req)
        {
            var query = from source in db.JMSShouKuanRule select source;
            if(req.JmsId != null) query = query.Where(d => d.JmsId == req.JmsId);
if(!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
if(!string.IsNullOrEmpty(req.JmsClassName)) query = query.Where(d => d.JmsClassName.Contains(req.JmsClassName));
if(!string.IsNullOrEmpty(req.ShouKuanType)) query = query.Where(d => d.ShouKuanType.Contains(req.ShouKuanType));
if(req.ShouKuanMoney != null) query = query.Where(d => d.ShouKuanMoney == req.ShouKuanMoney);
if (req.StartTimeStart != DateTime.MinValue && req.StartTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.StartTime >= req.StartTimeStart);
if (req.StartTimeEnd != DateTime.MinValue && req.StartTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.StartTime >= req.StartTimeEnd);
if (req.ShouKuanTimeStart != DateTime.MinValue && req.ShouKuanTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.ShouKuanTime >= req.ShouKuanTimeStart);
if (req.ShouKuanTimeEnd != DateTime.MinValue && req.ShouKuanTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.ShouKuanTime >= req.ShouKuanTimeEnd);
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if (req.CreatetimeStart != DateTime.MinValue && req.CreatetimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.Createtime >= req.CreatetimeStart);
if (req.CreatetimeEnd != DateTime.MinValue && req.CreatetimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.Createtime >= req.CreatetimeEnd);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<JMSShouKuanRule> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

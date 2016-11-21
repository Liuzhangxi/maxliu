


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
    public class JMSJieDianMXObjBLL
    {
        private Context db = new Context();

        public JMSJieDianMXObj UpdateSingle(int id, JMSJieDianMXObjReq data)
        {
            JMSJieDianMXObj model = db.JMSJieDianMXObj.Find(id);
            SetJMSJieDianMXObj(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSJieDianMXObj SetJMSJieDianMXObj(JMSJieDianMXObj model, JMSJieDianMXObjReq data)
        {
            if (data.JmsID != null) model.JmsID = data.JmsID.Value;
            if (data.JdClassModelID != null) model.JdClassModelID = data.JdClassModelID.Value;
            if (!string.IsNullOrEmpty(data.JdClassModelName)) model.JdClassModelName = data.JdClassModelName;
            if (data.JdModelID != null) model.JdModelID = data.JdModelID.Value;
            if (!string.IsNullOrEmpty(data.JdModelName)) model.JdModelName = data.JdModelName;
            if (data.JdMXModelID != null) model.JdMXModelID = data.JdMXModelID.Value;
            if (!string.IsNullOrEmpty(data.JdMXModelName)) model.JdMXModelName = data.JdMXModelName;
            if (!string.IsNullOrEmpty(data.JdMXFuJianFileClass)) model.JdMXFuJianFileClass = data.JdMXFuJianFileClass;
            if (!string.IsNullOrEmpty(data.JdMXFuJianJiaMengClass))
                model.JdMXFuJianJiaMengClass = data.JdMXFuJianJiaMengClass;
            if (!string.IsNullOrEmpty(data.xxJdMXFuJianUrl)) model.xxJdMXFuJianUrl = data.xxJdMXFuJianUrl;
            if (!string.IsNullOrEmpty(data.JmsUpFileUrl)) model.JmsUpFileUrl = data.JmsUpFileUrl;
            if (data.JdMXStateID != null) model.JdMXStateID = data.JdMXStateID.Value;
            if (data.JmsJdMXConfirmID != null) model.JmsJdMXConfirmID = data.JmsJdMXConfirmID.Value;
            if (data.xxJdMXConfirmID != null) model.xxJdMXConfirmID = data.xxJdMXConfirmID.Value;
            if (data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;

           
            return model;
        }

        public SearchListResult<JMSJieDianMXObj> SearchList(JMSJieDianMXObjReq req)
        {
            var query = from source in db.JMSJieDianMXObj select source;
            if (req.JmsID != null) query = query.Where(d => d.JmsID == req.JmsID);
            if (req.JdClassModelID != null) query = query.Where(d => d.JdClassModelID == req.JdClassModelID);
            if (!string.IsNullOrEmpty(req.JdClassModelName))
                query = query.Where(d => d.JdClassModelName.Contains(req.JdClassModelName));
            if (req.JdModelID != null) query = query.Where(d => d.JdModelID == req.JdModelID);
            if (!string.IsNullOrEmpty(req.JdModelName))
                query = query.Where(d => d.JdModelName.Contains(req.JdModelName));
            if (req.JdMXModelID != null) query = query.Where(d => d.JdMXModelID == req.JdMXModelID);
            if (!string.IsNullOrEmpty(req.JdMXModelName))
                query = query.Where(d => d.JdMXModelName.Contains(req.JdMXModelName));
            if (!string.IsNullOrEmpty(req.JdMXFuJianFileClass))
                query = query.Where(d => d.JdMXFuJianFileClass.Contains(req.JdMXFuJianFileClass));
            if (!string.IsNullOrEmpty(req.JdMXFuJianJiaMengClass))
                query = query.Where(d => d.JdMXFuJianJiaMengClass.Contains(req.JdMXFuJianJiaMengClass));
            if (!string.IsNullOrEmpty(req.xxJdMXFuJianUrl))
                query = query.Where(d => d.xxJdMXFuJianUrl.Contains(req.xxJdMXFuJianUrl));
            if (!string.IsNullOrEmpty(req.JmsUpFileUrl))
                query = query.Where(d => d.JmsUpFileUrl.Contains(req.JmsUpFileUrl));
            if (req.JdMXStateID != null) query = query.Where(d => d.JdMXStateID == req.JdMXStateID);
            if (req.JmsJdMXConfirmID != null) query = query.Where(d => d.JmsJdMXConfirmID == req.JmsJdMXConfirmID);
            if (req.xxJdMXConfirmID != null) query = query.Where(d => d.xxJdMXConfirmID == req.xxJdMXConfirmID);
            if (req.projectid != null && req.projectid.Value != 0)
                query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);
           
            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<JMSJieDianMXObj> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

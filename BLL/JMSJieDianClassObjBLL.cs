


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
    public class JMSJieDianClassObjBLL
    {
        private Context db = new Context();

        public JMSJieDianClassObj UpdateSingle(int id, JMSJieDianClassObjReq data)
        {
            JMSJieDianClassObj model = db.JMSJieDianClassObj.Find(id);
            SetJMSJieDianClassObj(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSJieDianClassObj SetJMSJieDianClassObj(JMSJieDianClassObj model, JMSJieDianClassObjReq data)
        {
            if (data.JmsID != null) model.JmsID = data.JmsID.Value;
            if (!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
            if (data.JdClassModelID != null) model.JdClassModelID = data.JdClassModelID.Value;
            if (!string.IsNullOrEmpty(data.JdClassModelName)) model.JdClassModelName = data.JdClassModelName;
            if (data.JdClassPaiXu != null) model.JdClassPaiXu = data.JdClassPaiXu.Value;
            if (data.JdClassStateID != null) model.JdClassStateID = data.JdClassStateID.Value;
            if (data.JdClassConfirmID != null) model.JdClassConfirmID = data.JdClassConfirmID.Value;
            if (data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (!string.IsNullOrEmpty(data.JdSpecialState)) model.JdSpecialState = data.JdSpecialState;
            if (!string.IsNullOrEmpty(data.JdSpecialOptName)) model.JdSpecialOptName = data.JdSpecialOptName;
            return model;
        }

        public SearchListResult<JMSJieDianClassObj> SearchList(JMSJieDianClassObjReq req)
        {
            var query = from source in db.JMSJieDianClassObj select source;
            if (req.JmsID != null) query = query.Where(d => d.JmsID == req.JmsID);
            if (!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
            if (req.JdClassModelID != null) query = query.Where(d => d.JdClassModelID == req.JdClassModelID);
            if (!string.IsNullOrEmpty(req.JdClassModelName))
                query = query.Where(d => d.JdClassModelName.Contains(req.JdClassModelName));
            if (req.JdClassPaiXu != null) query = query.Where(d => d.JdClassPaiXu == req.JdClassPaiXu);
            if (req.JdClassStateID != null) query = query.Where(d => d.JdClassStateID == req.JdClassStateID);
            if (req.JdClassConfirmID != null) query = query.Where(d => d.JdClassConfirmID == req.JdClassConfirmID);
            if (req.projectid != null && req.projectid.Value != 0)
                query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);

            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<JMSJieDianClassObj> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

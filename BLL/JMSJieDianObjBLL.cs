


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
    public class JMSJieDianObjBLL
    {
        private Context db = new Context();

        public JMSJieDianObj UpdateSingle(int id, JMSJieDianObjReq data)
        {
            JMSJieDianObj model = db.JMSJieDianObj.Find(id);
            SetJMSJieDianObj(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSJieDianObj SetJMSJieDianObj(JMSJieDianObj model, JMSJieDianObjReq data)
        {
            if (data.JmsID != null) model.JmsID = data.JmsID.Value;
            if (!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
            if (data.JdClassModelID != null) model.JdClassModelID = data.JdClassModelID.Value;
            if (!string.IsNullOrEmpty(data.JdClassModelName)) model.JdClassModelName = data.JdClassModelName;
            if (data.JdModelID != null) model.JdModelID = data.JdModelID.Value;
            if (!string.IsNullOrEmpty(data.JdModelName)) model.JdModelName = data.JdModelName;
            if (data.JdPaiXu != null) model.JdPaiXu = data.JdPaiXu.Value;
            if (data.JdStateID != null) model.JdStateID = data.JdStateID.Value;
            if (data.jmsJDConfirmID != null) model.jmsJDConfirmID = data.jmsJDConfirmID.Value;
            if (data.xxJDConfirmID != null) model.xxJDConfirmID = data.xxJDConfirmID.Value;

            if (data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (!string.IsNullOrEmpty(data.JmsUploadFileState)) model.JmsUploadFileState = data.JmsUploadFileState;
            if (!string.IsNullOrEmpty(data.JmsFinishState)) model.JmsFinishState = data.JmsFinishState;
            if (!string.IsNullOrEmpty(data.JdSpecialState)) model.JdSpecialState = data.JdSpecialState;
            if (!string.IsNullOrEmpty(data.JdSpecialOptName)) model.JdSpecialOptName = data.JdSpecialOptName;
            if (data.LastGenzhongDate != null && data.LastGenzhongDate != DateTime.MinValue &&  data.LastGenzhongDate != SqlDateTime.MinValue.Value)
                model.LastGenzhongDate = data.LastGenzhongDate.Value;
            
            return model;
        }

        public SearchListResult<JMSJieDianObj> SearchList(JMSJieDianObjReq req)
        {
            var query = from source in db.JMSJieDianObj select source;
            if (req.JmsID != null) query = query.Where(d => d.JmsID == req.JmsID);
            if (!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
            if (req.JdClassModelID != null) query = query.Where(d => d.JdClassModelID == req.JdClassModelID);
            if (!string.IsNullOrEmpty(req.JdClassModelName))
                query = query.Where(d => d.JdClassModelName.Contains(req.JdClassModelName));
            if (req.JdModelID != null) query = query.Where(d => d.JdModelID == req.JdModelID);
            if (!string.IsNullOrEmpty(req.JdModelName))
                query = query.Where(d => d.JdModelName.Contains(req.JdModelName));
            if (req.JdPaiXu != null) query = query.Where(d => d.JdPaiXu == req.JdPaiXu);
            if (req.JdStateID != null) query = query.Where(d => d.JdStateID == req.JdStateID);
            if (req.xxJDConfirmID != null) query = query.Where(d => d.xxJDConfirmID == req.xxJDConfirmID);
            if (req.jmsJDConfirmID != null) query = query.Where(d => d.jmsJDConfirmID == req.jmsJDConfirmID);
            if (req.projectid != null && req.projectid.Value != 0) query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);

            if (!string.IsNullOrEmpty(req.JmsFinishState)) query = query.Where(d => d.JmsFinishState.Contains(req.JmsFinishState));

            if (!string.IsNullOrEmpty(req.JmsUploadFileState)) query = query.Where(d => d.JmsUploadFileState.Contains(req.JmsUploadFileState));

            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<JMSJieDianObj> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

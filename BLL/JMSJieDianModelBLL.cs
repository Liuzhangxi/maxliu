


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
    public class JMSJieDianModelBLL
    {
        private Context db = new Context();

        public JMSJieDianModel UpdateSingle(int id, JMSJieDianModelReq data)
        {
            JMSJieDianModel model = db.JMSJieDianModel.Find(id);
            SetJMSJieDianModel(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSJieDianModel SetJMSJieDianModel(JMSJieDianModel model, JMSJieDianModelReq data)
        {
            if (data.JdClassID != null) model.JdClassID = data.JdClassID.Value;
            if (!string.IsNullOrEmpty(data.JdName)) model.JdName = data.JdName;
            if (data.JdPaiXu != null) model.JdPaiXu = data.JdPaiXu.Value;
            if (data.JdStateID != null) model.JdStateID = data.JdStateID.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (!string.IsNullOrEmpty(data.JmsUploadFileState)) model.JmsUploadFileState = data.JmsUploadFileState;
            return model;
        }

        public SearchListResult<JMSJieDianModel> SearchList(JMSJieDianModelReq req)
        {
            var query = from source in db.JMSJieDianModel select source;
            if (req.JdClassID != null) query = query.Where(d => d.JdClassID == req.JdClassID);
            if (!string.IsNullOrEmpty(req.JdName)) query = query.Where(d => d.JdName.Contains(req.JdName));
            if (req.JdPaiXu != null) query = query.Where(d => d.JdPaiXu == req.JdPaiXu);
            if (req.JdStateID != null) query = query.Where(d => d.JdStateID == req.JdStateID);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != null && req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != null && req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);
            if (!string.IsNullOrEmpty(req.JmsUploadFileState)) query = query.Where(d => d.JmsUploadFileState.Contains(req.JmsUploadFileState));

            query = query.Where(d => d.JdSpecialState == null || d.JdSpecialState == "");
            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<JMSJieDianModel> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

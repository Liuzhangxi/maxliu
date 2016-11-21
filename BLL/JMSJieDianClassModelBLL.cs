


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
    public class JMSJieDianClassModelBLL
    {
        private Context db = new Context();

        public JMSJieDianClassModel UpdateSingle(int id, JMSJieDianClassModelReq data)
        {
            JMSJieDianClassModel model = db.JMSJieDianClassModel.Find(id);
            SetJMSJieDianClassModel(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSJieDianClassModel SetJMSJieDianClassModel(JMSJieDianClassModel model, JMSJieDianClassModelReq data)
        {
            if (!string.IsNullOrEmpty(data.JdClassName)) model.JdClassName = data.JdClassName;
            if (data.JdClassPaiXu != null) model.JdClassPaiXu = data.JdClassPaiXu.Value;
            if (data.JdClassStateID != null) model.JdClassStateID = data.JdClassStateID.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;

            return model;
        }

        public SearchListResult<JMSJieDianClassModel> SearchList(JMSJieDianClassModelReq req)
        {
            var query = from source in db.JMSJieDianClassModel select source;
            if (req.id != 0) query = query.Where(d => d.id == req.id);
            if (!string.IsNullOrEmpty(req.JdClassName)) query = query.Where(d => d.JdClassName.Contains(req.JdClassName));
            if (req.JdClassPaiXu != null) query = query.Where(d => d.JdClassPaiXu == req.JdClassPaiXu);
            if (req.JdClassStateID != null) query = query.Where(d => d.JdClassStateID == req.JdClassStateID);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);

            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";

            query = query.Where(d => d.JdSpecialState == null || d.JdSpecialState == "");
            SearchListResult<JMSJieDianClassModel> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

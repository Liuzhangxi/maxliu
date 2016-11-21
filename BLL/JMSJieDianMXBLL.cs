


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
    public class JMSJieDianMXModelBLL
    {
        private Context db = new Context();

        public JMSJieDianMXModel UpdateSingle(int id, JMSJieDianMXModelReq data)
        {
            JMSJieDianMXModel model = db.JMSJieDianMXModel.Find(id);
            SetJMSJieDianMXModel(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSJieDianMXModel SetJMSJieDianMXModel(JMSJieDianMXModel model, JMSJieDianMXModelReq data)
        {
            if (data.JdClassID != null) model.JdClassID = data.JdClassID.Value;
            if (data.JdID != null) model.JdID = data.JdID.Value;
            if (!string.IsNullOrEmpty(data.JdMXName)) model.JdMXName = data.JdMXName;
            if (!string.IsNullOrEmpty(data.JdMXFuJianUrl)) model.JdMXFuJianUrl = data.JdMXFuJianUrl;
            if (!string.IsNullOrEmpty(data.JdMXFuJianFileClass)) model.JdMXFuJianFileClass = data.JdMXFuJianFileClass;
            if (!string.IsNullOrEmpty(data.JdMXFuJianJiaMengClass)) model.JdMXFuJianJiaMengClass = data.JdMXFuJianJiaMengClass;
            if (data.JdMXStateID != null) model.JdMXStateID = data.JdMXStateID.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
         
            return model;
        }

        public SearchListResult<JMSJieDianMXModel> SearchList(JMSJieDianMXModelReq req)
        {
            var query = from source in db.JMSJieDianMXModel select source;

            if (!string.IsNullOrEmpty(req.JdClassIDStr))
            {
                string[] cids = req.JdClassIDStr.Split(","[0]);
                query = query.Where(d => cids.Contains( d.JdClassID+""));
            }
            if (req.JdClassID != null) query = query.Where(d => d.JdClassID == req.JdClassID);
            if (req.JdID != null) query = query.Where(d => d.JdID == req.JdID);
            if (!string.IsNullOrEmpty(req.JdMXName)) query = query.Where(d => d.JdMXName.Contains(req.JdMXName));
            if (!string.IsNullOrEmpty(req.JdMXFuJianUrl)) query = query.Where(d => d.JdMXFuJianUrl.Contains(req.JdMXFuJianUrl));
            if (!string.IsNullOrEmpty(req.JdMXFuJianFileClass)) query = query.Where(d => d.JdMXFuJianFileClass.Contains(req.JdMXFuJianFileClass));
            if (!string.IsNullOrEmpty(req.JdMXFuJianJiaMengClass)) query = query.Where(d => d.JdMXFuJianJiaMengClass.Contains(req.JdMXFuJianJiaMengClass));
            if (req.JdMXStateID != null) query = query.Where(d => d.JdMXStateID == req.JdMXStateID);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);
          
            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<JMSJieDianMXModel> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

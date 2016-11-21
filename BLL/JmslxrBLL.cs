


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
    public class JMSLXRBLL
    {
        private Context db = new Context();

        public JMSLXR UpdateSingle(int id, JMSLXRReq data)
        {
            JMSLXR model = db.JMSLXR.Find(id);
            SetJMSLXR(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JMSLXR SetJMSLXR(JMSLXR model, JMSLXRReq data)
        {
            if (!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
            if (!string.IsNullOrEmpty(data.LxrName)) model.LxrName = data.LxrName;
            if (!string.IsNullOrEmpty(data.LxrSex)) model.LxrSex = data.LxrSex;
            if (!string.IsNullOrEmpty(data.LxrPhone)) model.LxrPhone = data.LxrPhone;
            if (!string.IsNullOrEmpty(data.LxrWeiXin)) model.LxrWeiXin = data.LxrWeiXin;
            if (!string.IsNullOrEmpty(data.LxrQQ)) model.LxrQQ = data.LxrQQ;
            if (!string.IsNullOrEmpty(data.LxrMail)) model.LxrMail = data.LxrMail;
            if (!string.IsNullOrEmpty(data.LxrZhiWu)) model.LxrZhiWu = data.LxrZhiWu;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.JmsID != null) model.JmsID = data.JmsID.Value;
            if (data.LxrStateID != null) model.LxrStateID = data.LxrStateID.Value;

            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (!string.IsNullOrEmpty(data.LxrPwd)) model.LxrPwd = data.LxrPwd;
            return model;
        }

        public SearchListResult<JMSLXR> SearchList(JMSLXRReq req)
        {
            var query = from source in db.JMSLXR select source;
            if (req.JmsID != null) query = query.Where(d => d.JmsID == req.JmsID);
            if (!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
            if (!string.IsNullOrEmpty(req.LxrName)) query = query.Where(d => d.LxrName.Contains(req.LxrName));
            if (!string.IsNullOrEmpty(req.LxrSex)) query = query.Where(d => d.LxrSex.Contains(req.LxrSex));
            if (!string.IsNullOrEmpty(req.LxrPhone)) query = query.Where(d => d.LxrPhone.Contains(req.LxrPhone));
            if (!string.IsNullOrEmpty(req.LxrWeiXin)) query = query.Where(d => d.LxrWeiXin.Contains(req.LxrWeiXin));
            if (!string.IsNullOrEmpty(req.LxrQQ)) query = query.Where(d => d.LxrQQ.Contains(req.LxrQQ));
            if (!string.IsNullOrEmpty(req.LxrMail)) query = query.Where(d => d.LxrMail.Contains(req.LxrMail));
            if (!string.IsNullOrEmpty(req.LxrZhiWu)) query = query.Where(d => d.LxrZhiWu.Contains(req.LxrZhiWu));
            if (req.LxrStateID != null) query = query.Where(d => d.LxrStateID == req.LxrStateID);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);
            #region 数据权限 
            if (req.optId != null && req.optId.Value != 0)
            {
                //组长能看到所有，
                List<int> subUserIds = DepartmentBLL.GetSubSystemUsers(req.optId.Value);
                query = query.Where(d => d.optId == null || subUserIds.Contains(d.optId.Value));
            }
            #endregion
            if (string.IsNullOrEmpty(req.sidx))
                req.sidx = "id";
            SearchListResult<JMSLXR> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}




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
    public class JMSGengZongBLL
    {
        private Context db = new Context();

        public JMSGengZong UpdateSingle(int id, JMSGengZongReq data)
        {
            JMSGengZong model = db.JMSGengZong.Find(id);
            SetJMSGengZong(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary> 
        /// <returns></returns>
        public JMSGengZong SetJMSGengZong(JMSGengZong model, JMSGengZongReq data)
        {
            if (!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
            if (!string.IsNullOrEmpty(data.LxrName)) model.LxrName = data.LxrName;
            if (!string.IsNullOrEmpty(data.GenzongInfo)) model.GenzongInfo = data.GenzongInfo;
            if (data.GengzongDateTime != DateTime.MinValue && data.GengzongDateTime != SqlDateTime.MinValue.Value)  model.GengzongDateTime = data.GengzongDateTime;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.GenzongStateID!=null) model.GenzongStateID = data.GenzongStateID.Value;
            if (data.JmsID != null) model.JmsID = data.JmsID.Value;
            if (data.LxrID!= null) model.LxrID = data.LxrID.Value;
            if (data.optDateTime !=null && data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value)  model.optDateTime = data.optDateTime.Value;

            return model;
        }

        public SearchListResult<JMSGengZong> SearchList(JMSGengZongReq req, int? UserId = 0)
        {
            var query = from source in db.JMSGengZong select source;

            //join jms in db.JiaMengShangInfo on source.JmsID equals jms.id
            //            into tempgz from jms in tempgz.DefaultIfEmpty()

            if (req.JmsID != null) query = query.Where(d => d.JmsID == req.JmsID);
            if (!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
            if (req.LxrID != null) query = query.Where(d => d.LxrID == req.LxrID);
            if (!string.IsNullOrEmpty(req.LxrName)) query = query.Where(d => d.LxrName.Contains(req.LxrName));
            if (!string.IsNullOrEmpty(req.GenzongInfo))
                query = query.Where(d => d.GenzongInfo.Contains(req.GenzongInfo));
            if (req.GengzongDateTimeStart != DateTime.MinValue &&
                req.GengzongDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.GengzongDateTime >= req.GengzongDateTimeStart);
            if (req.GengzongDateTimeEnd != DateTime.MinValue && req.GengzongDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.GengzongDateTime >= req.GengzongDateTimeEnd);
            if (req.GenzongStateID != null) query = query.Where(d => d.GenzongStateID == req.GenzongStateID);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeEnd);

            //数据权限
            if (UserId != null && UserId.Value != 0)
            {
                //组长能看到所有，
                List<int> subUserIds = DepartmentBLL.GetSubSystemUsers(UserId.Value);
                query = query.Where(d => d.optId == null || subUserIds.Contains(d.optId.Value));
            }

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sord = "desc";
                req.sidx = "id";
            }
            SearchListResult<JMSGengZong> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

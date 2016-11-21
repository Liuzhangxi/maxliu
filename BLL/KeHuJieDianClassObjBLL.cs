


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
    public partial class KeHuJieDianClassObjBLL
    {
        private Context db = new Context();

        public KeHuJieDianClassObj UpdateSingle(int id, KeHuJieDianClassObjReq data)
        {
            KeHuJieDianClassObj model = db.KeHuJieDianClassObj.Find(id);
            SetKeHuJieDianClassObj(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public KeHuJieDianClassObj SetKeHuJieDianClassObj(KeHuJieDianClassObj model, KeHuJieDianClassObjReq data)
        {
            if (data.KeHuID != null) model.KeHuID = data.KeHuID.Value;
            if (!string.IsNullOrEmpty(data.KeHuName)) model.KeHuName = data.KeHuName;
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
            if (data.HeTongId != null) model.HeTongId = data.HeTongId.Value;

            return model;
        }

        /// <summary>
        /// 查询KeHuJieDianClassObj
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<KeHuJieDianClassObj> SearchList(KeHuJieDianClassObjReq req)
        {
            var query = from source in db.KeHuJieDianClassObj select source;
            if (req.KeHuID != null) query = query.Where(d => d.KeHuID == req.KeHuID);
            if (!string.IsNullOrEmpty(req.KeHuName)) query = query.Where(d => d.KeHuName.Contains(req.KeHuName));
            if (req.JdClassModelID != null) query = query.Where(d => d.JdClassModelID == req.JdClassModelID);
            if (!string.IsNullOrEmpty(req.JdClassModelName))
                query = query.Where(d => d.JdClassModelName.Contains(req.JdClassModelName));
            if (req.JdClassPaiXu != null) query = query.Where(d => d.JdClassPaiXu == req.JdClassPaiXu);
            if (req.JdClassStateID != null) query = query.Where(d => d.JdClassStateID == req.JdClassStateID);
            if (req.JdClassConfirmID != null) query = query.Where(d => d.JdClassConfirmID == req.JdClassConfirmID);
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime optDateTimeTemp = req.optDateTimeEnd.AddDays(1);
                query = query.Where(d => d.optDateTime < optDateTimeTemp);
            }
            if (!string.IsNullOrEmpty(req.JdSpecialState))
                query = query.Where(d => d.JdSpecialState.Contains(req.JdSpecialState));
            if (!string.IsNullOrEmpty(req.JdSpecialOptName))
                query = query.Where(d => d.JdSpecialOptName.Contains(req.JdSpecialOptName));
             
            if (req.HeTongId != null) query = query.Where(d => d.HeTongId == req.HeTongId);

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<KeHuJieDianClassObj> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

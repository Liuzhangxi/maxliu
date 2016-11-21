


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
    public partial class KeHuJieDianObjBLL
    {
        private Context db = new Context();

        public KeHuJieDianObj UpdateSingle(int id, KeHuJieDianObjReq data)
        {
            KeHuJieDianObj model = db.KeHuJieDianObj.Find(id);
            SetKeHuJieDianObj(model, data);
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public KeHuJieDianObj SetKeHuJieDianObj(KeHuJieDianObj model, KeHuJieDianObjReq data)
        {
            if (data.KeHuID != null) model.KeHuID = data.KeHuID.Value;
            if (!string.IsNullOrEmpty(data.KeHuName)) model.KeHuName = data.KeHuName;
            if (data.JdClassModelID != null) model.JdClassModelID = data.JdClassModelID.Value;
            if (!string.IsNullOrEmpty(data.JdClassModelName)) model.JdClassModelName = data.JdClassModelName;
            if (data.JdModelID != null) model.JdModelID = data.JdModelID.Value;
            if (!string.IsNullOrEmpty(data.JdModelName)) model.JdModelName = data.JdModelName;
            if (data.JdPaiXu != null) model.JdPaiXu = data.JdPaiXu.Value;
            if (data.JdStateID != null) model.JdStateID = data.JdStateID.Value;
            if (data.projectid != null) model.ProjectID = data.projectid.Value;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (data.optDateTime != null && data.optDateTime != DateTime.MinValue &&
                data.optDateTime != SqlDateTime.MinValue.Value) model.optDateTime = data.optDateTime.Value;
            if (!string.IsNullOrEmpty(data.KeHuUploadFileState)) model.KeHuUploadFileState = data.KeHuUploadFileState;
            if (!string.IsNullOrEmpty(data.KeHuFinishState)) model.KeHuFinishState = data.KeHuFinishState;
            if (!string.IsNullOrEmpty(data.JdSpecialState)) model.JdSpecialState = data.JdSpecialState;
            if (!string.IsNullOrEmpty(data.JdSpecialOptName)) model.JdSpecialOptName = data.JdSpecialOptName;
            if (data.LastGenzhongDate != null && data.LastGenzhongDate != DateTime.MinValue &&
                data.LastGenzhongDate != SqlDateTime.MinValue.Value)
                model.LastGenzhongDate = data.LastGenzhongDate.Value;
            if (!string.IsNullOrEmpty(data.GenzongState)) model.GenzongState = data.GenzongState;
            if (data.HeTongId != null) model.HeTongId = data.HeTongId.Value;
            return model;
        }

        /// <summary>
        /// 查询KeHuJieDianObj
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<KeHuJieDianObj> SearchList(KeHuJieDianObjReq req)
        {
            var query = from source in db.KeHuJieDianObj select source;
            if (req.KeHuID != null) query = query.Where(d => d.KeHuID == req.KeHuID);
            if (!string.IsNullOrEmpty(req.KeHuName)) query = query.Where(d => d.KeHuName.Contains(req.KeHuName));
            if (req.JdClassModelID != null) query = query.Where(d => d.JdClassModelID == req.JdClassModelID);
            if (!string.IsNullOrEmpty(req.JdClassModelName))
                query = query.Where(d => d.JdClassModelName.Contains(req.JdClassModelName));
            if (req.JdModelID != null) query = query.Where(d => d.JdModelID == req.JdModelID);
            if (!string.IsNullOrEmpty(req.JdModelName))
                query = query.Where(d => d.JdModelName.Contains(req.JdModelName));
            if (req.JdPaiXu != null) query = query.Where(d => d.JdPaiXu == req.JdPaiXu);
            if (req.JdStateID != null) query = query.Where(d => d.JdStateID == req.JdStateID);
            if (req.projectid != null && req.projectid != 0) query = query.Where(d => d.ProjectID == req.projectid);
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
            {
                DateTime optDateTimeTemp = req.optDateTimeEnd.AddDays(1);
                query = query.Where(d => d.optDateTime < optDateTimeTemp);
            }
            if (!string.IsNullOrEmpty(req.KeHuUploadFileState))
                query = query.Where(d => d.KeHuUploadFileState.Contains(req.KeHuUploadFileState));
            if (!string.IsNullOrEmpty(req.KeHuFinishState))
                query = query.Where(d => d.KeHuFinishState.Contains(req.KeHuFinishState));
            if (!string.IsNullOrEmpty(req.JdSpecialState))
                query = query.Where(d => d.JdSpecialState.Contains(req.JdSpecialState));
            if (!string.IsNullOrEmpty(req.JdSpecialOptName))
                query = query.Where(d => d.JdSpecialOptName.Contains(req.JdSpecialOptName));
            if (req.LastGenzhongDateStart != DateTime.MinValue &&
                req.LastGenzhongDateStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.LastGenzhongDate >= req.LastGenzhongDateStart);
            if (req.LastGenzhongDateEnd != DateTime.MinValue && req.LastGenzhongDateEnd != SqlDateTime.MinValue.Value)
            {
                DateTime LastGenzhongDateTemp = req.LastGenzhongDateEnd.AddDays(1);
                query = query.Where(d => d.LastGenzhongDate < LastGenzhongDateTemp);
            }
            if (!string.IsNullOrEmpty(req.GenzongState))
                query = query.Where(d => d.GenzongState.Contains(req.GenzongState));

            if (req.HeTongId != null) query = query.Where(d => d.HeTongId == req.HeTongId);

            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<KeHuJieDianObj> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

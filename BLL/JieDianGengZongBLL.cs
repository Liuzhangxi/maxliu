


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
    public partial class JieDianGengZongBLL
    { 
        private Context db = new Context();

        public JieDianGengZong UpdateSingle(int id, JieDianGengZongReq data)
        { 
            JieDianGengZong model = db.JieDianGengZong.Find(id);
            SetJieDianGengZong(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  JieDianGengZong SetJieDianGengZong(JieDianGengZong model, JieDianGengZongReq data)
        {
             if(data.jdid != null) model.jdid = data.jdid.Value;
if(!string.IsNullOrEmpty(data.jdName)) model.jdName = data.jdName;
if(!string.IsNullOrEmpty(data.OptName)) model.OptName = data.OptName;
if(data.OptId != null) model.OptId = data.OptId.Value;
if(data.OptDateTime != null && data.OptDateTime != DateTime.MinValue && data.OptDateTime != SqlDateTime.MinValue.Value) model.OptDateTime = data.OptDateTime.Value;
if(!string.IsNullOrEmpty(data.Desc)) model.Desc = data.Desc;
if(!string.IsNullOrEmpty(data.State)) model.State = data.State;
 
            return model;
        }

        public SearchListResult<JieDianGengZong> SearchList(JieDianGengZongReq req)
        {
            var query = from source in db.JieDianGengZong select source;
            if(req.jdid != null) query = query.Where(d => d.jdid == req.jdid);
if(!string.IsNullOrEmpty(req.jdName)) query = query.Where(d => d.jdName.Contains(req.jdName));
if(!string.IsNullOrEmpty(req.OptName)) query = query.Where(d => d.OptName.Contains(req.OptName));
if(req.OptId != null) query = query.Where(d => d.OptId == req.OptId);
if (req.OptDateTimeStart != DateTime.MinValue && req.OptDateTimeStart != SqlDateTime.MinValue.Value) query = query.Where(d => d.OptDateTime >= req.OptDateTimeStart);
if (req.OptDateTimeEnd != DateTime.MinValue && req.OptDateTimeEnd != SqlDateTime.MinValue.Value) query = query.Where(d => d.OptDateTime >= req.OptDateTimeEnd);
if(!string.IsNullOrEmpty(req.Desc)) query = query.Where(d => d.Desc.Contains(req.Desc));
if(!string.IsNullOrEmpty(req.State)) query = query.Where(d => d.State.Contains(req.State));
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<JieDianGengZong> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

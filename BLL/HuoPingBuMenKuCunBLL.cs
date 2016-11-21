


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
    public partial class HuoPingBuMenKuCunBLL
    { 
        private Context db = new Context();

        public HuoPingBuMenKuCun UpdateSingle(int id, HuoPingBuMenKuCunReq data)
        { 
            HuoPingBuMenKuCun model = db.HuoPingBuMenKuCun.Find(id);
            SetHuoPingBuMenKuCun(model, data); 
            db.SaveChanges();
            return model;
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public  HuoPingBuMenKuCun SetHuoPingBuMenKuCun(HuoPingBuMenKuCun model, HuoPingBuMenKuCunReq data)
        {
             if(data.projectId != null) model.projectId = data.projectId.Value;
if(!string.IsNullOrEmpty(data.projectName)) model.projectName = data.projectName;
if(data.HPId != null) model.HPId = data.HPId.Value;
if(!string.IsNullOrEmpty(data.HPName)) model.HPName = data.HPName;
if(data.CurStock != null) model.CurStock = data.CurStock.Value;
 
            return model;
        }

        /// <summary>
        /// 查询HuoPingBuMenKuCun
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public SearchListResult<HuoPingBuMenKuCun> SearchList(HuoPingBuMenKuCunReq req)
        {
            var query = from source in db.HuoPingBuMenKuCun select source;
            if(req.projectid != null && req.projectid !=0 ) query = query.Where(d => d.projectId == req.projectid);
if(!string.IsNullOrEmpty(req.projectName)) query = query.Where(d => d.projectName.Contains(req.projectName));
if(req.HPId != null) query = query.Where(d => d.HPId == req.HPId);
if(!string.IsNullOrEmpty(req.HPName)) query = query.Where(d => d.HPName.Contains(req.HPName));
if(req.CurStock != null) query = query.Where(d => d.CurStock == req.CurStock);
 
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }    
            SearchListResult<HuoPingBuMenKuCun> retListResult = query.ToSearchList(req); 
            return retListResult;
        } 
    }
}

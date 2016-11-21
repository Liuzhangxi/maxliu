


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
    public class JiaMengShangInfoBLL
    {
        private Context db = new Context();

        public JiaMengShangInfo UpdateSingle(int id, JiaMengShangInfoReq data)
        {
            JiaMengShangInfo model = db.JiaMengShangInfo.Find(id);
            SetJiaMengShangInfo(model, data);
            db.SaveChanges();
            return model;
        }

        void SetJMSShouKuanRule(JiaMengShangInfo model,int optId,string optName,string shoukuantype)
        {
            JMSShouKuanRule souKuanRule = new JMSShouKuanRule();
            souKuanRule.JmsId = model.id;
            souKuanRule.Createtime = DateTime.Now;
            souKuanRule.JmsName = model.JmsName;
            souKuanRule.JmsClassName = model.JmsClassName;
            souKuanRule.OptId = optId;
            souKuanRule.OptName = optName;
            souKuanRule.State = "未收";
            
            souKuanRule.ShouKuanType = shoukuantype;//"意向金";
            souKuanRule.projectid = model.ProjectID;
            db.JMSShouKuanRule.Add(souKuanRule);
        }

        /// <summary>
        /// 设置model，如果不为空就设置,如果为空则和之前一样
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public JiaMengShangInfo SetJiaMengShangInfo(JiaMengShangInfo model, JiaMengShangInfoReq data,int optId=0,string optName="")
        {
            if (!string.IsNullOrEmpty(data.JmsName)) model.JmsName = data.JmsName;
            if (!string.IsNullOrEmpty(data.JmsPhone)) model.JmsPhone = data.JmsPhone;
            if (data.JmsStateID != null) model.JmsStateID = data.JmsStateID.Value;
            if (data.JieDianTbStateID != null) model.JieDianTbStateID = data.JieDianTbStateID.Value;
            if (!string.IsNullOrEmpty(data.JmsQuDaoLaiYuan)) model.JmsQuDaoLaiYuan = data.JmsQuDaoLaiYuan;
            if (!string.IsNullOrEmpty(data.JmsWeiXinHao)) model.JmsWeiXinHao = data.JmsWeiXinHao;
            if (!string.IsNullOrEmpty(data.JmsMail)) model.JmsMail = data.JmsMail;
            if (!string.IsNullOrEmpty(data.JmsArea)) model.JmsArea = data.JmsArea;
            if (!string.IsNullOrEmpty(data.JmsAddress)) model.JmsAddress = data.JmsAddress;
            if (!string.IsNullOrEmpty(data.JmsConShiHangYe)) model.JmsConShiHangYe = data.JmsConShiHangYe;
            if (!string.IsNullOrEmpty(data.JmsGuDongGouCheng)) model.JmsGuDongGouCheng = data.JmsGuDongGouCheng;
            if (!string.IsNullOrEmpty(data.JmsYiXiang)) model.JmsYiXiang = data.JmsYiXiang;
            if (!string.IsNullOrEmpty(data.JmsHasWuYe)) model.JmsHasWuYe = data.JmsHasWuYe;
            if (!string.IsNullOrEmpty(data.JmsWuYeClass)) model.JmsWuYeClass = data.JmsWuYeClass;
            if (!string.IsNullOrEmpty(data.JmsWuYeQuYu)) model.JmsWuYeQuYu = data.JmsWuYeQuYu;
            if (!string.IsNullOrEmpty(data.JmsZiJinYuSuan)) model.JmsZiJinYuSuan = data.JmsZiJinYuSuan;
            if (!string.IsNullOrEmpty(data.JmsHeZuoModel)) model.JmsHeZuoModel = data.JmsHeZuoModel;
            if (!string.IsNullOrEmpty(data.JmsXiaoFeiLi)) model.JmsXiaoFeiLi = data.JmsXiaoFeiLi;
            if (!string.IsNullOrEmpty(data.JmsYZHSShuLiang)) model.JmsYZHSShuLiang = data.JmsYZHSShuLiang;
            if (!string.IsNullOrEmpty(data.JmsYZHSJunJia)) model.JmsYZHSJunJia = data.JmsYZHSJunJia;
            if (!string.IsNullOrEmpty(data.JmsYongYouZiYuan)) model.JmsYongYouZiYuan = data.JmsYongYouZiYuan;
            if (!string.IsNullOrEmpty(data.JmsVisitedXiXi)) model.JmsVisitedXiXi = data.JmsVisitedXiXi;
            if (!string.IsNullOrEmpty(data.optName)) model.optName = data.optName;
            if (!string.IsNullOrEmpty(data.JmsTelPhone)) model.JmsTelPhone = data.JmsTelPhone;

            
            if (!string.IsNullOrEmpty(data.JmsClassName))
            {
                if (data.JmsClassName != model.JmsClassName)
                {
                    //更新加盟商类型时新增 收款规则
                    //先删除之前的
                   var toRemove = db.JMSShouKuanRule.Where(rule => rule.JmsId == model.id);
                    db.JMSShouKuanRule.RemoveRange(toRemove);
                    model.JmsClassName = data.JmsClassName;

                    if (data.JmsClassName.IndexOf("品牌加盟") >= 0 || data.JmsClassName.IndexOf("委托管理") >= 0)
                    {
                        //品牌加盟和委托管理类的加盟商自动生成意向金、尾款、保证金和管理费四类收款
                        SetJMSShouKuanRule(model, optId, optName, "意向金");
                        SetJMSShouKuanRule(model, optId, optName, "尾款");
                        SetJMSShouKuanRule(model, optId, optName, "保证金");
                        SetJMSShouKuanRule(model, optId, optName, "管理费");
                    }
                    else if (data.JmsClassName.IndexOf("技术加盟") >= 0 )
                    {
                        //技术加盟类的加盟商自动生成意向金和尾款两类收款
                        SetJMSShouKuanRule(model, optId, optName, "意向金");
                        SetJMSShouKuanRule(model, optId, optName, "尾款");
                    }
                 
                }
            }
            if (!string.IsNullOrEmpty(data.JmsCity)) model.JmsCity = data.JmsCity;
            if (!string.IsNullOrEmpty(data.JmsProvince)) model.JmsProvince = data.JmsProvince;
            if (!string.IsNullOrEmpty(data.JmsHasVisitOther)) model.JmsHasVisitOther = data.JmsHasVisitOther;
            if (data.SaleId != null) model.SaleId = data.SaleId;
            if (!string.IsNullOrEmpty(data.SaleName)) model.SaleName = data.SaleName;

            if (data.optDateTime!=null&&data.optDateTime != DateTime.MinValue && data.optDateTime != SqlDateTime.MinValue.Value)
                model.optDateTime = data.optDateTime.Value;
            
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"></param>
        /// <param name="isSign">是否签约加盟商</param>
        /// <returns></returns>
        public SearchListResult<JiaMengShangInfo> SearchList(JiaMengShangInfoReq req,int? UserId=0, bool? isSign=null)
        {
#if DEBUG
            db.Database.Log = (log) => { System.Diagnostics.Debug.WriteLine(log); };
#endif
            var query = from source in db.JiaMengShangInfo select source;
            if(req.id!=0) query = query.Where(d => d.id.Equals(req.id));
            if (req.JieDianTbStateID != null) query = query.Where(d => d.JieDianTbStateID==req.JieDianTbStateID.Value);
            if (!string.IsNullOrEmpty(req.JmsName)) query = query.Where(d => d.JmsName.Contains(req.JmsName));
            if (!string.IsNullOrEmpty(req.JmsPhone)) query = query.Where(d => d.JmsPhone.Contains(req.JmsPhone));
            if (req.JmsStateID != null)
            {
                query = query.Where(d => d.JmsStateID == req.JmsStateID);
            }
            else
            {
                query = query.Where(d => d.JmsStateID != 3);
            }
            if (!string.IsNullOrEmpty(req.JmsQuDaoLaiYuan))
                query = query.Where(d => d.JmsQuDaoLaiYuan.Contains(req.JmsQuDaoLaiYuan));
            if (!string.IsNullOrEmpty(req.JmsWeiXinHao))
                query = query.Where(d => d.JmsWeiXinHao.Contains(req.JmsWeiXinHao));
            if (!string.IsNullOrEmpty(req.JmsMail)) query = query.Where(d => d.JmsMail.Contains(req.JmsMail));
            if (!string.IsNullOrEmpty(req.JmsCity)) query = query.Where(d => d.JmsCity.Contains(req.JmsCity));
            if (!string.IsNullOrEmpty(req.JmsAddress)) query = query.Where(d => d.JmsAddress.Contains(req.JmsAddress));
            if (!string.IsNullOrEmpty(req.JmsConShiHangYe))
                query = query.Where(d => d.JmsConShiHangYe.Contains(req.JmsConShiHangYe));
            if (!string.IsNullOrEmpty(req.JmsGuDongGouCheng))
                query = query.Where(d => d.JmsGuDongGouCheng.Contains(req.JmsGuDongGouCheng));
            if (!string.IsNullOrEmpty(req.JmsYiXiang)) query = query.Where(d => d.JmsYiXiang.Contains(req.JmsYiXiang));
            if (!string.IsNullOrEmpty(req.JmsHasWuYe)) query = query.Where(d => d.JmsHasWuYe.Contains(req.JmsHasWuYe));
            if (!string.IsNullOrEmpty(req.JmsWuYeClass))
                query = query.Where(d => d.JmsWuYeClass.Contains(req.JmsWuYeClass));
            if (!string.IsNullOrEmpty(req.JmsWuYeQuYu))
                query = query.Where(d => d.JmsWuYeQuYu.Contains(req.JmsWuYeQuYu));
            if (!string.IsNullOrEmpty(req.JmsZiJinYuSuan))
                query = query.Where(d => d.JmsZiJinYuSuan.Contains(req.JmsZiJinYuSuan));
            if (!string.IsNullOrEmpty(req.JmsHeZuoModel))
                query = query.Where(d => d.JmsHeZuoModel.Contains(req.JmsHeZuoModel));
            if (!string.IsNullOrEmpty(req.JmsXiaoFeiLi))
                query = query.Where(d => d.JmsXiaoFeiLi.Contains(req.JmsXiaoFeiLi));
            if (!string.IsNullOrEmpty(req.JmsYZHSShuLiang))
                query = query.Where(d => d.JmsYZHSShuLiang.Contains(req.JmsYZHSShuLiang));
            if (!string.IsNullOrEmpty(req.JmsYZHSJunJia))
                query = query.Where(d => d.JmsYZHSJunJia.Contains(req.JmsYZHSJunJia));
            if (!string.IsNullOrEmpty(req.JmsYongYouZiYuan))
                query = query.Where(d => d.JmsYongYouZiYuan.Contains(req.JmsYongYouZiYuan));
            if (!string.IsNullOrEmpty(req.JmsVisitedXiXi))
                query = query.Where(d => d.JmsVisitedXiXi.Contains(req.JmsVisitedXiXi));
            if (!string.IsNullOrEmpty(req.optName)) query = query.Where(d => d.optName.Contains(req.optName));
            if (req.optDateTimeStart!=null&&req.optDateTimeStart != DateTime.MinValue && req.optDateTimeStart != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime >= req.optDateTimeStart);
            if (req.optDateTimeEnd != null && req.optDateTimeEnd != DateTime.MinValue && req.optDateTimeEnd != SqlDateTime.MinValue.Value)
                query = query.Where(d => d.optDateTime <= req.optDateTimeEnd);
            //if (!string.IsNullOrEmpty(req.JmsCity))
            //    query = query.Where(d => d.JmsVisitedXiXi.Contains(req.JmsCity));
            //if (!string.IsNullOrEmpty(req.JmsProvince))
            //    query = query.Where(d => d.JmsVisitedXiXi.Contains(req.JmsProvince));

            if (!string.IsNullOrEmpty(req.JmsClassName))
                query = query.Where(d => d.JmsClassName.Contains(req.JmsClassName));

            if (!string.IsNullOrEmpty(req.JmsHasVisitOther))
                query = query.Where(d => d.JmsHasVisitOther.Contains(req.JmsHasVisitOther));

            //数据权限
            if (UserId != null && UserId.Value != 0)
            {
                //组长能看到所有，
               List<int> subUserIds = DepartmentBLL.GetSubSystemUsers(UserId.Value);
                query = query.Where(d => d.SaleId==null || subUserIds.Contains(d.SaleId.Value));
            }
            if (!string.IsNullOrEmpty(req.SaleName))
                query = query.Where(d => d.SaleName.Contains(req.SaleName));
            if (req.SaleId != null) query = query.Where(d => d.SaleId == req.SaleId.Value);

            if (!string.IsNullOrEmpty(req.JmsTelPhone))
                query = query.Where(d => d.JmsTelPhone.Contains(req.JmsTelPhone));

            if (isSign == null)
            {
               
            }
            else
            {
                if (isSign.Value)
                {
                    query = query.Where(d => d.JmsClassName != "" && d.JmsClassName != null);
                }
                else
                {
                    query = query.Where(d => d.JmsClassName == "" || d.JmsClassName == null);
                }
            }
            if (string.IsNullOrEmpty(req.sidx))
            {
                req.sidx = "id";
                req.sord = "desc";
            }
            SearchListResult<JiaMengShangInfo> retListResult = query.ToSearchList(req);
            return retListResult;
        }
    }
}

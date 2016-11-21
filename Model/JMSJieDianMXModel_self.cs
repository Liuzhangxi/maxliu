using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL
{
    public partial class JMSJieDianMXObj
    {
        public static JMSJieDianMXObj TranferModelToObj(JMSJieDianMXModel model, int jmsId, string jmsName,
            int projectId, string className = "", string modelname = "")
        {
            JMSJieDianMXObj obj = new JMSJieDianMXObj();
            obj.JdClassModelID = model.JdClassID;
            if (className == "" || modelname == "")
            {
                using (Context db = new Context())
                {
                    obj.JdClassModelName = db.JMSJieDianClassModel.Find(model.JdClassID).JdClassName;
                    obj.JdModelName = db.JMSJieDianModel.Find(model.JdID).JdName;
                }
            }
            else
            {
                obj.JdModelName = modelname;
                obj.JdClassModelName = className;
            } 
            obj.JdModelID = model.JdID;
            obj.JdMXModelName = model.JdMXName;
            obj.JmsID = jmsId;
            obj.JdMXFuJianFileClass = model.JdMXFuJianFileClass;
            obj.JdMXFuJianJiaMengClass = model.JdMXFuJianJiaMengClass;
            obj.JdMXModelID = model.id;
            obj.JdMXModelName = model.JdMXName;
            obj.JdMXStateID = model.JdMXStateID;
          

            obj.xxJdMXFuJianUrl = model.JdMXFuJianUrl;

            //可空
            //obj.JmsUpFileUrl = model.JdMXFuJianUrl; 
            obj.ProjectID = projectId;
            return obj;
        }
    }
}

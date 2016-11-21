



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using OUDAL.ModelBase;
namespace OUDAL
{
    public partial class JMSJieDianModel 
    {
        [NotMapped]
        public List<JMSJieDianMXModel> JmsJieDianMxs { get; set; } 
    
    }

    public partial class JMSJieDianObj
    {
        [NotMapped]
        public List<JMSJieDianMXObj> JmsJieDianMxs { get; set; }

        public static JMSJieDianObj TranferModelToObj(JMSJieDianModel model,int jmsId,string jmsName,int projectId)
        {
            JMSJieDianObj obj = new JMSJieDianObj();
            obj.JdModelName = model.JdName;
            obj.JdClassModelID = model.JdClassID;
            //obj.JdClassModelName=model.
            obj.JdModelID = model.id;
            obj.JdPaiXu= model.JdPaiXu;
            obj.JmsID = jmsId;
            obj.JmsName = jmsName;
            obj.ProjectID = projectId;
            obj.JmsUploadFileState = model.JmsUploadFileState;
            using (Context db = new Context())
            {
                obj.JdClassModelName = db.JMSJieDianClassModel.Find(model.JdClassID).JdClassName;
            }

            return obj;
        }
    }
}

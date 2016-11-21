using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL
{
    [Serializable]
    public class JMSJieDianEntity
    {
        public List<JMSJieDianClassModel> ModelClasses { get; set; }
         
    }

    [Serializable]
    public class JMSJieDianEntityObj
    {
        public List<JMSJieDianClassObj> JieDianClassObjs { get; set; } 
        public int JMSId { get; set; }
    }
}

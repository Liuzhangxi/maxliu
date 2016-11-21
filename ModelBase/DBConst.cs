using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.ModelBase
{
    public class DBConst
    {
        const string YueSaoErpKeyName = "YueSaoErp";
        const string YZHSErpKeyName = "YZHSERP";

        public static string YueSaoErpConnectString{get{return ConfigurationManager.ConnectionStrings[YueSaoErpKeyName] + ""; } }
        public static string YZHSErpConnectString { get { return ConfigurationManager.ConnectionStrings[YZHSErpKeyName] + ""; } }
    }
}

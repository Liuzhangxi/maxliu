using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.Model
{
    public class ShouKuanInfo
    {
        public JMSShouKuan JMSShouKuan { get; set; }
        public JMSShouKuanRule JMSShouKuanRule { get; set; }
    }

    public class DingDanHome
    {
        public KhHeTong KhHeTong { get; set; }
        public KeHu KeHu { get; set; }
        public DDShouKuan DDShouKuan { get; set; }
    }
}

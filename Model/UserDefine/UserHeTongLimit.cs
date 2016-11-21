using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.Model
{
    public class ShouKuanSum
    {
        public decimal? SkJing { get; set; }
    }
    public class HeTongSum
    {
        public decimal? DingJin { get; set; }
        public decimal? WeiKuan { get; set; }
        public decimal? TotalMoney { get; set; }
        public decimal? ZheKouMoney { get; set; }
        public decimal? BaoXian { get; set; }
    }

    /// <summary>
    /// 合同期限描述
    /// </summary>
    public class UserHeTongLimit
    {
        public int HeTongTime { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
    }
}

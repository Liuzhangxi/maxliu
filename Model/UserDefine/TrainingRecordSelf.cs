using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL
{
    public partial class TrainingRecord
    {
        List<DayClassInfo> dayClassInfos = new List<DayClassInfo>();

        [NotMapped]
        public List<DayClassInfo> ReadClassInfos
        {
            get
            {
                List<DayClassInfo> u = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DayClassInfo>>(DayClass);
                //7天不全
                if (u != null && u.Count > 0)
                {
                    while (u.Count < 7)
                    {
                        u.Add(new DayClassInfo());
                    }
                }

                return u;
            }
        }

        [NotMapped]
        public List<DayClassInfo> DayClassInfos
        {
            get
            { 
                return dayClassInfos;
            }
            set
            {
                dayClassInfos = value;
            }
        }

        public static string SetStringDayClass(List<DayClassInfo> input)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(input);
        }
    }

    public class DayClassInfo
    {
        public DateTime Day { get; set; }
        /// <summary>
        /// 排班名
        /// </summary>
        public string ClassName { get; set; }
    }
}

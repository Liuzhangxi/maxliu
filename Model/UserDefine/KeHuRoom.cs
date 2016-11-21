using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.Model
{
    public class MomChildPare
    {
        //public int MomCount { get; set; }
        public int ChildCount
        {
            get
            {
                int count = 0;
                if (KhHeTongs != null)
                {
                      KhHeTongs.ForEach(k =>
                      {
                          count += k.ChildCount??0;
                      });
                }
                return count;
            }
        }

        public List<KhHeTong> KhHeTongs { get; set; }
        public List<RoomCheckInData> RoomCheckIns { get; set; }

        /// <summary>
        /// 当月夜间数
        /// </summary>
        public int JianCount(int year, int month)
        {
            int total = 0;
            if (RoomCheckIns != null)
            { 
                DateTime fromDay = new DateTime(year, month, 1);
                DateTime toDay = fromDay.AddMonths(1).Subtract(new TimeSpan(1, 0, 0));
                RoomCheckIns.ForEach(r =>
                {
                    if ( r.RoomCheckIn == null || r.RoomCheckIn.EndDate == null || r.RoomCheckIn.StartDate == null || r.RoomCheckIn.State=="其他")
                    {

                    }
                    else
                    {
                        DateTime startDay = r.RoomCheckIn.StartDate.Value;
                        DateTime endDay = r.RoomCheckIn.EndDate.Value;
                        int plusDay = 0;
                        if (r.RoomCheckIn.StartDate.Value < fromDay)
                        {
                            //plusDay = 1;
                            startDay = fromDay;
                        }
                        if (r.RoomCheckIn.EndDate.Value > toDay)
                        {
                            plusDay = 1;
                            endDay = toDay;
                        }
                        total += endDay.Subtract(startDay).Days + plusDay;
                    }

                });
            }
            return total;
        }

        public int MomCount
        {
            get
            {
                if (RoomCheckIns != null)
                {
                  List<int?> ss=  RoomCheckIns.Select(r => r.RoomCheckIn.KeHuId).Distinct().ToList();
                   return ss.Count;
                }
                return 0;
            }
        }

        //public int Month { get; set; }
    }

    public class ChildCarePare
    {
        public ChildCareMain ChildCareMain { get; set; }
        public ChildCareDetail ChildCareDetail { get; set; }
    }
    public class ChildCareList
    {
        public ChildCareMain ChildCareMain { get; set; }
        public List<ChildCareDetail> ChildCareDetails { get; set; } 
    }
    public class RoomCheckInHeTong
    {
        public RoomInfo RoomInfo { get; set; }
        public RoomCheckIn RoomCheckIn { get; set; }
        public KhHeTong KhHeTong { get; set; }
    }
    public class KeHuRoom
    {
        public RoomCheckIn RoomCheckIn { get; set; }
        public KeHu Kehu{ get; set; }
        public RoomInfo RoomInfo { get; set; }
    }
}

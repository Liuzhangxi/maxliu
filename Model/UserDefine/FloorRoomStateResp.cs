using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.Model
{
    public class JiaQiType
    {
        public string Name { get; set; }
        /// <summary>
        /// 系数
        /// </summary>
        public decimal RelationFactor { get; set; }



    }

    public class RoomCheckInData
    {
        public RoomCheckIn RoomCheckIn { get; set; }
        public RoomInfo RoomInfo { get; set; }
    }

    public class FloorRoomStateResp
    {
        public List<RoomInfoResp> RoomInfos { get; set; }


        //public List<RoomCheckIn> RoomCheckIns{ get; set; }

        public int Year { get; set; }
        public int Month { get; set; }

    }



    public class RoomInfoResp
    {
       public RoomInfo RoomInfo { get; set; }
        public List<RoomCheckIn> RoomCheckIns { get; set; }
    }

}

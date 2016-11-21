



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
    ///################################################################################################
    /// <summary>
    /// <para>摘要：RoomCheckInModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：RoomCheckIn
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>RoomId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>3</td><td>StartDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>开始入住日期</td></tr>
    /// <tr valign="top"><td>4</td><td>EndDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>结束入住日期</td></tr>
    /// <tr valign="top"><td>5</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>6</td><td>KeHuId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户ID</td></tr>
    /// <tr valign="top"><td>7</td><td>KeHuName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名</td></tr>
    /// <tr valign="top"><td>8</td><td>RoomDesc</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>入住房间描述</td></tr>
    /// <tr valign="top"><td>9</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>录入人名</td></tr>
    /// <tr valign="top"><td>10</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>录入人id</td></tr>
    ///    <tr valign="top"><td>10</td><td>FloorId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>FloorIdid</td></tr>
    /// <tr valign="top"><td>11</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>12</td><td>Remark</td><td>nvarchar</td><td>750</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("RoomCheckIn")]
    [Serializable]
    public partial class RoomCheckIn
    {
        [NotMapped]
        public string CheckOutDesc {
            get
            {
                //是否退房
                DateTime date = DateTime.Now.Date;
                date = date.AddHours(12);//中午12点后
                if (EndDate.Value.Date < DateTime.Now.Date ||
                    (EndDate.Value.Date == DateTime.Now.Date && DateTime.Now > date)
                    )
                {
                    if (State == "已入住")
                    {
                        return "已退房";
                    }
                }

                return "";
            }
        }

        /// <summary>
        /// 房态交替描述
        /// </summary>
        [NotMapped]
        public string RoomStateSwitchDesc { get; set; }
        /// <summary>
        /// 是否和之前房态有同一天的时间
        /// </summary>
        [NotMapped]
        public bool IsSameDayWithPre { get; set; }
        /// <summary>
        /// 房态交替标签L/C之类
        /// </summary>
        [NotMapped]
        public string RoomStateSwitch { get; set; }

        /// <summary>
        /// 房态中是否已经设置过
        /// </summary>
        [NotMapped]
        public bool IsSetRoomState { get; set; }
        [NotMapped]
        [DisplayName("初始合同录入天数")]
        public int   HeTongDays { get; set; }

        /// <summary>
        /// 如果是暂定房换过来的FromRoomDesc就为空
        /// </summary>
        [DisplayName("前房描述")]
        public string FromRoomDesc { get; set; }

        [DisplayName("换房描述")]
        public string SwitchRoomDesc { get; set; }
        
        [DisplayName("有效状态")]
        public string ValidState { get; set; }
        [DisplayName("换房前房间id")]
       
        public int? PreRoomCheckInId { get; set; }
        public static string LogClass = "入住信息";
        /// <summary>
        /// 先前的房态id
        /// </summary>
        [NotMapped]
        public int? PreFangTaiId { get; set; }

        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("换房标签")]
        public string SwitchRoomTag { get; set; }

        [DisplayName("初始合同")]
        public int? InitialHeTongId { get; set; }

        public int FloorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private int _id;

        /// <summary>
        /// 
        /// </summary>
        [Key]

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }



        /// <summary>
        /// 
        /// </summary>
        private int? _RoomId;

        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RoomId")]

        public int? RoomId
        {
            set { _RoomId = value; }
            get { return _RoomId; }
        }



        /// <summary>
        /// 开始入住日期
        /// </summary>
        private DateTime? _StartDate = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 开始入住日期
        /// </summary>
        [DisplayName("开始入住日期")]

        public DateTime? StartDate
        {
            set { _StartDate = value; }
            get { return _StartDate; }
        }

        private DateTime _StartDateStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime StartDateStart
        {
            set { _StartDateStart = value; }
            get { return _StartDateStart; }
        }

        private DateTime _StartDateEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime StartDateEnd
        {
            set { _StartDateEnd = value; }
            get { return _StartDateEnd; }
        }


        /// <summary>
        /// 结束入住日期
        /// </summary>
        private DateTime? _EndDate = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 结束入住日期
        /// </summary>
        [DisplayName("结束入住日期")]

        public DateTime? EndDate
        {
            set { _EndDate = value; }
            get { return _EndDate; }
        }

        private DateTime _EndDateStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime EndDateStart
        {
            set { _EndDateStart = value; }
            get { return _EndDateStart; }
        }

        private DateTime _EndDateEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime EndDateEnd
        {
            set { _EndDateEnd = value; }
            get { return _EndDateEnd; }
        }


        /// <summary>
        /// 状态
        /// </summary>
        private string _State = "";

        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态")]

        public string State
        {
            set { _State = value; }
            get { return _State; }
        }



        /// <summary>
        /// 客户ID
        /// </summary>
        private int? _KeHuId;

        /// <summary>
        /// 客户ID
        /// </summary>
        [DisplayName("客户ID")]

        public int? KeHuId
        {
            set { _KeHuId = value; }
            get { return _KeHuId; }
        }



        /// <summary>
        /// 客户名
        /// </summary>
        private string _KeHuName = "";

        /// <summary>
        /// 客户名
        /// </summary>
        [DisplayName("客户名")]

        public string KeHuName
        {
            set { _KeHuName = value; }
            get { return _KeHuName; }
        }



        /// <summary>
        /// 入住房间描述
        /// </summary>
        private string _RoomDesc = "";

        /// <summary>
        /// 入住房间描述
        /// </summary>
        [DisplayName("入住房间描述")]

        public string RoomDesc
        {
            set { _RoomDesc = value; }
            get { return _RoomDesc; }
        }



        /// <summary>
        /// 录入人名
        /// </summary>
        private string _OptName = "";

        /// <summary>
        /// 录入人名
        /// </summary>
        [DisplayName("录入人名")]

        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }



        /// <summary>
        /// 录入人id
        /// </summary>
        private int? _OptId;

        /// <summary>
        /// 录入人id
        /// </summary>
        [DisplayName("录入人id")]

        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }



        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _CreateDate = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]

        public DateTime? CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }

        private DateTime _CreateDateStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime CreateDateStart
        {
            set { _CreateDateStart = value; }
            get { return _CreateDateStart; }
        }

        private DateTime _CreateDateEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime CreateDateEnd
        {
            set { _CreateDateEnd = value; }
            get { return _CreateDateEnd; }
        }


        /// <summary>
        /// 备注
        /// </summary>
        private string _Remark = "";

        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]

        public string Remark
        {
            set { _Remark = value; }
            get { return _Remark; }
        }




        #endregion ----------------------------------------------------------------------
    }

    public partial class RoomCheckInReq : BaseSearchReq
    {
        [DisplayName("换房描述")]
        public string SwitchRoomDesc { get; set; }
        [DisplayName("有效状态")]
        public string ValidState { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        public int? PreRoomCheckInId { get; set; }

        [DisplayName("换房标签")]
        public string SwitchRoomTag { get; set; }

        [DisplayName("初始合同")]
        public int? InitialHeTongId { get; set; }
        public int? FloorId { get; set; }

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 
        /// </summary> 
        public int? RoomId { get; set; }


        /// <summary>
        /// 开始入住日期
        /// </summary> 
        public DateTime? StartDate { get; set; }

        private DateTime _StartDateStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime StartDateStart
        {
            set { _StartDateStart = value; }
            get { return _StartDateStart; }
        }

        private DateTime _StartDateEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime StartDateEnd
        {
            set { _StartDateEnd = value; }
            get { return _StartDateEnd; }
        }

        /// <summary>
        /// 结束入住日期
        /// </summary> 
        public DateTime? EndDate { get; set; }

        private DateTime _EndDateStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime EndDateStart
        {
            set { _EndDateStart = value; }
            get { return _EndDateStart; }
        }

        private DateTime _EndDateEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime EndDateEnd
        {
            set { _EndDateEnd = value; }
            get { return _EndDateEnd; }
        }

        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get; set; }


        /// <summary>
        /// 客户ID
        /// </summary> 
        public int? KeHuId { get; set; }


        /// <summary>
        /// 客户名
        /// </summary> 
        public string KeHuName { get; set; }


        /// <summary>
        /// 入住房间描述
        /// </summary> 
        public string RoomDesc { get; set; }


        /// <summary>
        /// 录入人名
        /// </summary> 
        public string OptName { get; set; }


        /// <summary>
        /// 录入人id
        /// </summary> 
        public int? OptId { get; set; }


        /// <summary>
        /// 创建时间_createdate
        /// </summary> 
        public DateTime? CreateDate { get; set; }

        private DateTime _CreateDateStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime CreateDateStart
        {
            set { _CreateDateStart = value; }
            get { return _CreateDateStart; }
        }

        private DateTime _CreateDateEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime CreateDateEnd
        {
            set { _CreateDateEnd = value; }
            get { return _CreateDateEnd; }
        }

        /// <summary>
        /// 备注
        /// </summary> 
        public string Remark { get; set; }




        #endregion ----------------------------------------------------------------------
    }

}

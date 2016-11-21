using System.ComponentModel;
using System.Data.SqlTypes;
using OUDAL.ModelBase;

namespace OUDAL.Model.Sales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesKeHuFangWen")]
    [Serializable]
    public partial class SalesKeHuFangWen
    {

        public static string LogClass = "SalesKeHuFangWen";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("喜喜门店")]
        public int? xixiProjectID { get; set; }

        [DisplayName("查看人")]
        public string clickedName { get; set; }

        [DisplayName("查看时间")]
        public DateTime? clickedDateTime { get; set; }


        [DisplayName("所属项目公司ID")]
        public int? projectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public string visitedDateTimeDesc
        {
            //get { return visitedDateTime.ToString("yyyy-MM-dd HH:mm"); }
            get { return visitedDateTime == null ? string.Empty : visitedDateTime.Value.ToString("yyyy-MM-dd HH:mm"); }
        }

        [DisplayName("状态")]
        [NotMapped]
        public string fangWenStateIDDesc
        {
            get
            {
                switch (fangWenStateID)
                {
                    case 2:
                        return "无效";
                    default: return "有效";
                }
            }
        }

        [NotMapped]
        public string KeFuKhPhoneNumber { get; set; }

        [NotMapped]
        public string salesPhone { get; set; }


        [DisplayName("状态")]
        public int fangWenStateID { get; set; }


        [DisplayName("到访地址")]
        [Required]
        public string visitedAddress { get; set; }

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
        /// 客户ID
        /// </summary>
        private int _kHID;
        /// <summary>
        /// 客户ID
        /// </summary>
        [DisplayName("客户ID")]
        public int kHID
        {
            set { _kHID = value; }
            get { return _kHID; }
        }





        /// <summary>
        /// 客户名字
        /// </summary>
        private string _KHName = "";
        /// <summary>
        /// 客户名字
        /// </summary>
        [DisplayName("客户名字")]
        [Required]
        public string KHName
        {
            set { _KHName = value; }
            get { return _KHName; }
        }





        /// <summary>
        /// 销售ID
        /// </summary>
        private int _SalesID;
        /// <summary>
        /// 销售ID
        /// </summary>
        [DisplayName("销售员ID")]
        [Required]
        public int SalesID
        {
            set { _SalesID = value; }
            get { return _SalesID; }
        }





        /// <summary>
        /// 销售名字
        /// </summary>
        private string _SalesName = "";
        /// <summary>
        /// 销售名字
        /// </summary>
        [DisplayName("销售员名字")]
        [Required]
        public string SalesName
        {
            set { _SalesName = value; }
            get { return _SalesName; }
        }





        /// <summary>
        /// 到访时间
        /// </summary>
        private DateTime? _visitedDateTime;
        /// <summary>
        /// 到访时间
        /// </summary>
        [DisplayName("到访时间")]
        public DateTime? visitedDateTime
        {
            set { _visitedDateTime = value; }
            get { return _visitedDateTime; }
        }

        private DateTime? _visitedDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime? visitedDateTimeStart
        {
            set { _visitedDateTimeStart = value; }
            get { return _visitedDateTimeStart; }
        }
        private DateTime? _visitedDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime? visitedDateTimeEnd
        {
            set { _visitedDateTimeEnd = value; }
            get { return _visitedDateTimeEnd; }
        }




        /// <summary>
        /// 客户备注信息
        /// </summary>
        private string _KeHuInfo = "";
        /// <summary>
        /// 客户备注信息
        /// </summary>
        [DisplayName("客户备注信息")]
        [Required]
        public string KeHuInfo
        {
            set { _KeHuInfo = value; }
            get { return _KeHuInfo; }
        }





        /// <summary>
        /// 操作人
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }





        /// <summary>
        /// 操作时间
        /// </summary>
        private DateTime _optDateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]
        public DateTime optDateTime
        {
            set { _optDateTime = value; }
            get { return _optDateTime; }
        }

        private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeStart
        {
            set { _optDateTimeStart = value; }
            get { return _optDateTimeStart; }
        }
        private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeEnd
        {
            set { _optDateTimeEnd = value; }
            get { return _optDateTimeEnd; }
        }

        public int? hetongID { get; set; }


        public int? KeHuYiXiangStateID { get; set; }


        #endregion ----------------------------------------------------------------------
    }

    public class saleskehufangwenRes
    {
        public SalesKeHuFangWen saleskehufangwen { get; set; }
        public yixiangKehuView kehu { get; set; }
        //public SalesKeHuGenZhong genzhong { get; set; }

        public SalesKeHuGenZhongRes gz2 { get; set; }
    }
    public partial class SalesKeHuFangWenReq : BaseSearchReq
    {
        /// <summary>
        /// 是否签单
        /// </summary>
        public string isQianDan { get; set; }
        /// <summary>
        /// 客户来源
        /// </summary>
        public string Qudao { get; set; }
        public string KhPhoneNumber { get; set; }

        //public int? projectID { get; set; }

        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// seed
        /// </summary> 
        public int id
        {
            get;
            set;
        }
        /// <summary>
        /// 客户ID
        /// </summary> 
        public int kHID
        {
            get;
            set;
        }
        /// <summary>
        /// 客户名字
        /// </summary> 
        public string KHName
        {
            get;
            set;
        }
        /// <summary>
        /// 销售ID
        /// </summary> 
        public int SalesID
        {
            get;
            set;
        }
        /// <summary>
        /// 销售名字
        /// </summary> 
        public string SalesName
        {
            get;
            set;
        }
        /// <summary>
        /// 到访时间
        /// </summary> 
        public DateTime? visitedDateTime
        {
            get;
            set;
        }
        /// <summary>
        /// 到访地址
        /// </summary> 
        public string visitedAddress
        {
            get;
            set;
        }
        /// <summary>
        /// 客户备注信息
        /// </summary> 
        public string KeHuInfo
        {
            get;
            set;
        }
        /// <summary>
        /// 访问记录状态 1有效 2无效
        /// </summary> 
        public int fangWenStateID
        {
            get;
            set;
        }
        /// <summary>
        /// 操作人
        /// </summary> 
        public string optName
        {
            get;
            set;
        }
        /// <summary>
        /// 操作时间
        /// </summary> 
        public DateTime optDateTime
        {
            get;
            set;
        }


        public DateTime? DateFromoptDateTime
        {
            get;
            set;
        }

        public DateTime? DateTooptDateTime
        {
            get;
            set;
        }

        public DateTime? DateFromvisitedDateTime
        {
            get;
            set;
        }

        public DateTime? DateTovisitedDateTime
        {
            get;
            set;
        }
        #endregion ----------------------------------------------------------------------
    }

}

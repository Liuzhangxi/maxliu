using System.ComponentModel;
using System.Data.SqlTypes;

namespace OUDAL.Model.Sales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class SalesKeHuGenZhongRes
    {
        public int? xixiProjectId { get; set; }
        public int khfangWenID { get; set; }
        public string isQianYue { get; set; }
        public int? Projectid { get; set; }
        public int KhId { get; set; }
    }


    [Table("SalesKeHuGenZhong")]
    public partial class SalesKeHuGenZhong
    {
        public static string LogClass = "SalesKeHuGenZhong";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("喜喜门店")]
        public int? xixiProjectID { get; set; }

        [NotMapped]
        public string visitedDateTimeDesc
        {
            //get { return visitedDateTime.ToString("yyyy-MM-dd HH:mm"); }
            get { return visitedDateTime == null ? string.Empty : visitedDateTime.Value.ToString("yyyy-MM-dd HH:mm"); }
        }

        [DisplayName("所属项目公司ID")]
        public int? projectID { get; set; }
        /// <summary>
        /// seed
        /// </summary>
        private int _id;
        /// <summary>
        /// seed
        /// </summary>
        [Key]
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }





        /// <summary>
        /// 访问ID
        /// </summary>
        private int _khfangWenID;
        /// <summary>
        /// 访问ID
        /// </summary>
        [DisplayName("访问ID")]
        public int khfangWenID
        {
            set { _khfangWenID = value; }
            get { return _khfangWenID; }
        }





        /// <summary>
        /// 客户ID
        /// </summary>
        private int _khID;
        /// <summary>
        /// 客户ID
        /// </summary>
        [DisplayName("客户ID")]
        public int khID
        {
            set { _khID = value; }
            get { return _khID; }
        }





        /// <summary>
        /// 客户名称
        /// </summary>
        private string _khName = "";
        /// <summary>
        /// 客户名称
        /// </summary>
        [DisplayName("客户名称")]
        public string khName
        {
            set { _khName = value; }
            get { return _khName; }
        }





        /// <summary>
        /// 销售员ID
        /// </summary>
        private int _SalesID;
        /// <summary>
        /// 销售员ID
        /// </summary>
        [DisplayName("销售员ID")]
        public int SalesID
        {
            set { _SalesID = value; }
            get { return _SalesID; }
        }





        /// <summary>
        /// 销售员名称
        /// </summary>
        private string _SalesName = "";
        /// <summary>
        /// 销售员名称
        /// </summary>
        [DisplayName("销售员名称")]
        public string SalesName
        {
            set { _SalesName = value; }
            get { return _SalesName; }
        }





        /// <summary>
        /// 客户是否到店
        /// </summary>
        private string _isDaoDian = "";
        /// <summary>
        /// 客户是否到店
        /// </summary>
        [DisplayName("客户是否到店")]
        public string isDaoDian
        {
            set { _isDaoDian = value; }
            get { return _isDaoDian; }
        }





        /// <summary>
        /// 客户是否签约
        /// </summary>
        private string _isQianYue = "";
        /// <summary>
        /// 客户是否签约
        /// </summary>
        [DisplayName("客户是否签约")]
        public string isQianYue
        {
            set { _isQianYue = value; }
            get { return _isQianYue; }
        }





        /// <summary>
        /// 跟踪情况
        /// </summary>
        private string _GenZongInfo = "";
        /// <summary>
        /// 跟踪情况
        /// </summary>
        [DisplayName("跟踪情况")]
        public string GenZongInfo
        {
            set { _GenZongInfo = value; }
            get { return _GenZongInfo; }
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

        private DateTime _visitedDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime visitedDateTimeStart
        {
            set { _visitedDateTimeStart = value; }
            get { return _visitedDateTimeStart; }
        }
        private DateTime _visitedDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime visitedDateTimeEnd
        {
            set { _visitedDateTimeEnd = value; }
            get { return _visitedDateTimeEnd; }
        }




        /// <summary>
        /// 记录建立时间
        /// </summary>
        private DateTime _createDateTime;
        /// <summary>
        /// 记录建立时间
        /// </summary>
        [DisplayName("记录建立时间")]
        public DateTime createDateTime
        {
            set { _createDateTime = value; }
            get { return _createDateTime; }
        }

        private DateTime _createDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime createDateTimeStart
        {
            set { _createDateTimeStart = value; }
            get { return _createDateTimeStart; }
        }
        private DateTime _createDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime createDateTimeEnd
        {
            set { _createDateTimeEnd = value; }
            get { return _createDateTimeEnd; }
        }

        public int? GenZongStateID { get; set; }

        public int? GenZongYiXiangStateID { get; set; }

        #endregion ----------------------------------------------------------------------
    }
}

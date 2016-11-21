



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
    /// <para>摘要：YiHaoPingModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：YiHaoPing
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>HPId</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>货品ID</td></tr>
    /// <tr valign="top"><td>3</td><td>HPName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名称</td></tr>
    /// <tr valign="top"><td>4</td><td>shenqingNum</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>申请数量</td></tr>
    /// <tr valign="top"><td>5</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>申请部门_projectid</td></tr>
    /// <tr valign="top"><td>6</td><td>shenqingRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>申请人_optname</td></tr>
    /// <tr valign="top"><td>7</td><td>shenpiRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审批人</td></tr>
    /// <tr valign="top"><td>8</td><td>lingliaoRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>领料人</td></tr>
    /// <tr valign="top"><td>9</td><td>shenqingDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>申请日期_createdate</td></tr>
    /// <tr valign="top"><td>10</td><td>shenPiDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>审批日期</td></tr>
    /// <tr valign="top"><td>11</td><td>lingliaoDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>领料日期</td></tr>
    /// <tr valign="top"><td>12</td><td>lingliaoRenId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>13</td><td>shenpiRenId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>14</td><td>shenqingRenId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>申请人_optid</td></tr>
    /// <tr valign="top"><td>15</td><td>projectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("YiHaoPing")]
    [Serializable]
    public partial class YiHaoPing
    {

        public static string LogClass = "易耗品";
        #region -  公共属性  ------------------------------------------------------------

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
        /// 货品ID
        /// </summary>
        private int _HPId;
        /// <summary>
        /// 货品ID
        /// </summary>
        [DisplayName("货品")]
        [Required]
        public int HPId
        {
            set { _HPId = value; }
            get { return _HPId; }
        }



        /// <summary>
        /// 货品名称
        /// </summary>
        private string _HPName = "";
        /// <summary>
        /// 货品名称
        /// </summary>
        [DisplayName("货品名称")]

        public string HPName
        {
            set { _HPName = value; }
            get { return _HPName; }
        }



        /// <summary>
        /// 申请数量
        /// </summary>
        private int? _shenqingNum;
        /// <summary>
        /// 申请数量
        /// </summary>
        [DisplayName("申请数量")]

        public int? shenqingNum
        {
            set { _shenqingNum = value; }
            get { return _shenqingNum; }
        }



        /// <summary>
        /// 申请部门_projectid
        /// </summary>
        private int? _projectid;
        /// <summary>
        /// 申请部门_projectid
        /// </summary>
        [DisplayName("申请部门")]

        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }



        /// <summary>
        /// 申请人_optname
        /// </summary>
        private string _shenqingRen = "";
        /// <summary>
        /// 申请人_optname
        /// </summary>
        [DisplayName("申请人")]

        public string shenqingRen
        {
            set { _shenqingRen = value; }
            get { return _shenqingRen; }
        }



        /// <summary>
        /// 审批人
        /// </summary>
        private string _shenpiRen = "";
        /// <summary>
        /// 审批人
        /// </summary>
        [DisplayName("审批人")]

        public string shenpiRen
        {
            set { _shenpiRen = value; }
            get { return _shenpiRen; }
        }



        /// <summary>
        /// 领料人
        /// </summary>
        private string _lingliaoRen = "";
        /// <summary>
        /// 领料人
        /// </summary>
        [DisplayName("领料人")]

        public string lingliaoRen
        {
            set { _lingliaoRen = value; }
            get { return _lingliaoRen; }
        }



        /// <summary>
        /// 申请日期_createdate
        /// </summary>
        private DateTime? _shenqingDate;
        /// <summary>
        /// 申请日期_createdate
        /// </summary>
        [DisplayName("申请日期")]

        public DateTime? shenqingDate
        {
            set { _shenqingDate = value; }
            get { return _shenqingDate; }
        }

        private DateTime _shenqingDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenqingDateStart
        {
            set { _shenqingDateStart = value; }
            get { return _shenqingDateStart; }
        }
        private DateTime _shenqingDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenqingDateEnd
        {
            set { _shenqingDateEnd = value; }
            get { return _shenqingDateEnd; }
        }


        /// <summary>
        /// 审批日期
        /// </summary>
        private DateTime? _shenPiDate;
        /// <summary>
        /// 审批日期
        /// </summary>
        [DisplayName("审批日期")]

        public DateTime? shenPiDate
        {
            set { _shenPiDate = value; }
            get { return _shenPiDate; }
        }

        private DateTime _shenPiDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenPiDateStart
        {
            set { _shenPiDateStart = value; }
            get { return _shenPiDateStart; }
        }
        private DateTime _shenPiDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenPiDateEnd
        {
            set { _shenPiDateEnd = value; }
            get { return _shenPiDateEnd; }
        }


        /// <summary>
        /// 领料日期
        /// </summary>
        private DateTime? _lingliaoDate;
        /// <summary>
        /// 领料日期
        /// </summary>
        [DisplayName("领料日期")]

        public DateTime? lingliaoDate
        {
            set { _lingliaoDate = value; }
            get { return _lingliaoDate; }
        }

        private DateTime _lingliaoDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime lingliaoDateStart
        {
            set { _lingliaoDateStart = value; }
            get { return _lingliaoDateStart; }
        }
        private DateTime _lingliaoDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime lingliaoDateEnd
        {
            set { _lingliaoDateEnd = value; }
            get { return _lingliaoDateEnd; }
        }


        /// <summary>
        /// 
        /// </summary>
        private int? _lingliaoRenId;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("lingliaoRenId")]

        public int? lingliaoRenId
        {
            set { _lingliaoRenId = value; }
            get { return _lingliaoRenId; }
        }



        /// <summary>
        /// 
        /// </summary>
        private int? _shenpiRenId;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("shenpiRenId")]

        public int? shenpiRenId
        {
            set { _shenpiRenId = value; }
            get { return _shenpiRenId; }
        }



        /// <summary>
        /// 申请人_optid
        /// </summary>
        private int? _shenqingRenId;
        /// <summary>
        /// 申请人_optid
        /// </summary>
        [DisplayName("申请人")]

        public int? shenqingRenId
        {
            set { _shenqingRenId = value; }
            get { return _shenqingRenId; }
        }



        /// <summary>
        /// 门店名_projectname
        /// </summary>
        private string _projectName = "";
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        [DisplayName("门店名")]

        public string projectName
        {
            set { _projectName = value; }
            get { return _projectName; }
        }

        [DisplayName("申请备注")]
        public string Mark { get; set; }

        [DisplayName("状态")]
        public string yihaoPingState { get; set; }

        /// <summary>
        /// 当前库存
        /// </summary>
        [NotMapped]
        public decimal? CurStock { get; set; }

        [NotMapped]
        public string HuoPinLeixing { get; set; }
        #endregion ----------------------------------------------------------------------
    }

    public partial class YiHaoPingReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 货品ID
        /// </summary> 
        public int? HPId { get; set; }


        /// <summary>
        /// 货品名称
        /// </summary> 
        public string HPName { get; set; }


        /// <summary>
        /// 申请数量
        /// </summary> 
        public int? shenqingNum { get; set; }


        /// <summary>
        /// 申请人_optname
        /// </summary> 
        public string shenqingRen { get; set; }


        /// <summary>
        /// 审批人
        /// </summary> 
        public string shenpiRen { get; set; }


        /// <summary>
        /// 领料人
        /// </summary> 
        public string lingliaoRen { get; set; }


        /// <summary>
        /// 申请日期_createdate
        /// </summary> 
        public DateTime? shenqingDate { get; set; }

        private DateTime _shenqingDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenqingDateStart
        {
            set { _shenqingDateStart = value; }
            get { return _shenqingDateStart; }
        }
        private DateTime _shenqingDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenqingDateEnd
        {
            set { _shenqingDateEnd = value; }
            get { return _shenqingDateEnd; }
        }

        /// <summary>
        /// 审批日期
        /// </summary> 
        public DateTime? shenPiDate { get; set; }

        private DateTime _shenPiDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenPiDateStart
        {
            set { _shenPiDateStart = value; }
            get { return _shenPiDateStart; }
        }
        private DateTime _shenPiDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime shenPiDateEnd
        {
            set { _shenPiDateEnd = value; }
            get { return _shenPiDateEnd; }
        }

        /// <summary>
        /// 领料日期
        /// </summary> 
        public DateTime? lingliaoDate { get; set; }

        private DateTime _lingliaoDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime lingliaoDateStart
        {
            set { _lingliaoDateStart = value; }
            get { return _lingliaoDateStart; }
        }
        private DateTime _lingliaoDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime lingliaoDateEnd
        {
            set { _lingliaoDateEnd = value; }
            get { return _lingliaoDateEnd; }
        }

        /// <summary>
        /// 
        /// </summary> 
        public int? lingliaoRenId { get; set; }


        /// <summary>
        /// 
        /// </summary> 
        public int? shenpiRenId { get; set; }


        /// <summary>
        /// 申请人_optid
        /// </summary> 
        public int? shenqingRenId { get; set; }


        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string projectName { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Mark { get; set; }

        public string yihaoPingState { get; set; }

        public string HuoPinLeixing { get; set; }

        public decimal? CurStock { get; set; }

        /// <summary>
        /// 易耗品领料状态
        /// </summary>
        public string yihaoPingLingLiaoState { get; set; }
        #endregion ----------------------------------------------------------------------
    }

}

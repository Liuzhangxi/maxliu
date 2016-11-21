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
    /// <para>摘要：HuoPingModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：HuoPing
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名</td></tr>
    /// <tr valign="top"><td>3</td><td>SingleDesc</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>单位描述</td></tr>
    /// <tr valign="top"><td>4</td><td>SingleCount</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>单位数量</td></tr>
    /// <tr valign="top"><td>5</td><td>DayUseCount</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>用量</td></tr>
    /// <tr valign="top"><td>6</td><td>UseType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>使用类型(门店/宝宝)</td></tr>
    /// <tr valign="top"><td>7</td><td>Mark</td><td>nvarchar</td><td>950</td><td></td><td></td><td></td><td>√</td><td></td><td>备注_kindeditor</td></tr>
    /// <tr valign="top"><td>8</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>9</td><td>ProjectName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>10</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>11</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>12</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>13</td><td>SinglePrice</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>单价</td></tr>
    /// <tr valign="top"><td>14</td><td>Supplier</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>供应商</td></tr>
    /// <tr valign="top"><td>15</td><td>CurStock</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>现库存量</td></tr>
    /// <tr valign="top"><td>16</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态_validstate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("HuoPing")]
    [Serializable]
    public partial class HuoPing
    {

        public static string LogClass = "货品信息";
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
        /// 货品名
        /// </summary>
        private string _Name = "";
        /// <summary>
        /// 货品名
        /// </summary>
        [DisplayName("货品名")]

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }



        /// <summary>
        /// 单位描述
        /// </summary>
        private string _SingleDesc = "";
        /// <summary>
        /// 单位描述
        /// </summary>
        [DisplayName("单位描述")]

        public string SingleDesc
        {
            set { _SingleDesc = value; }
            get { return _SingleDesc; }
        }



        /// <summary>
        /// 单位数量
        /// </summary>
        private decimal? _SingleCount;
        /// <summary>
        /// 单位数量
        /// </summary>
        [DisplayName("单位数量")]

        public decimal? SingleCount
        {
            set { _SingleCount = value; }
            get { return _SingleCount; }
        }


        /// <summary>
        /// 用量（天/月）
        /// </summary>
        private string _UseUnit;
        /// <summary>
        /// 用量（天/月）
        /// </summary>
        [DisplayName("用量（天/月）")]

        public string UseUnit
        {
            set { _UseUnit = value; }
            get { return _UseUnit; }
        }


        /// <summary>
        /// 用量
        /// </summary>
        private decimal? _DayUseCount;
        /// <summary>
        /// 用量
        /// </summary>
        [DisplayName("用量")]

        public decimal? DayUseCount
        {
            set { _DayUseCount = value; }
            get { return _DayUseCount; }
        }



        /// <summary>
        /// 服务对象
        /// </summary>
        private string _UseType = "";
        /// <summary>
        /// 服务对象
        /// </summary>
        [DisplayName("服务对象")]

        public string UseType
        {
            set { _UseType = value; }
            get { return _UseType; }
        }



        /// <summary>
        /// 备注_kindeditor
        /// </summary>
        private string _Mark = "";
        /// <summary>
        /// 备注_kindeditor
        /// </summary>
        [DisplayName("备注")]

        public string Mark
        {
            set { _Mark = value; }
            get { return _Mark; }
        }



        /// <summary>
        /// 公司部门_projectid
        /// </summary>
        private int? _projectid;
        /// <summary>
        /// 公司部门_projectid
        /// </summary>
        [DisplayName("公司部门")]

        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }



        /// <summary>
        /// 门店名_projectname
        /// </summary>
        private string _ProjectName = "";
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        [DisplayName("门店名")]

        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }



        /// <summary>
        /// 操作人_optid
        /// </summary>
        private int? _OptId;
        /// <summary>
        /// 操作人_optid
        /// </summary>
        [DisplayName("操作人")]

        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }



        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _CreateDate;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]

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
        /// 操作人名_optname
        /// </summary>
        private string _OptName = "";
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        [DisplayName("操作人名")]

        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }



        /// <summary>
        /// 单价
        /// </summary>
        private decimal? _SinglePrice;
        /// <summary>
        /// 单价
        /// </summary>
        [DisplayName("单价")]

        public decimal? SinglePrice
        {
            set { _SinglePrice = value; }
            get { return _SinglePrice; }
        }



        /// <summary>
        /// 供应商
        /// </summary>
        private string _Supplier = "";
        /// <summary>
        /// 供应商
        /// </summary>
        [DisplayName("供应商")]

        public string Supplier
        {
            set { _Supplier = value; }
            get { return _Supplier; }
        }



        /// <summary>
        /// 现库存量
        /// </summary>
        private decimal? _CurStock;
        /// <summary>
        /// 现库存量
        /// </summary>
        [DisplayName("现库存量")]

        public decimal? CurStock
        {
            set { _CurStock = value; }
            get { return _CurStock; }
        }



        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        private string _ValidState = "";
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        [DisplayName("有效状态")]

        public string ValidState
        {
            set { _ValidState = value; }
            get { return _ValidState; }
        }

        [NotMapped]
        public int HPOutId { get; set; }

        [NotMapped]
        public decimal? MonthNeed
        {
            get; set;
        }

        [NotMapped]
        public decimal? MonthNeedDetail
        {
            get; set;
        }

        [NotMapped]
        public decimal? WeekOne
        {
            get; set;
        }

        [NotMapped]
        public decimal? WeekTwo
        {
            get; set;
        }

        [NotMapped]
        public decimal? WeekThree
        {
            get; set;
        }

        [NotMapped]
        public decimal? WeekFour
        {
            get; set;
        }

        [NotMapped]
        public string HPOutMark
        {
            get; set;
        }

        [NotMapped]
        public decimal? HPOutStock { get; set; }

        [NotMapped]
        public DateTime? OptDateTime { get; set; }

        [NotMapped]
        public string State { get; set; }

        [DisplayName("品牌")]
        public string PinPai { get; set; }

        [DisplayName("厂家型号")]
        public string ChangjiaXinghao { get; set; }

        [DisplayName("货品类型")]
        public string HuoPinLeixing { get; set; }

        [DisplayName("货品图片")]
        public string HuoPingImg { get; set; }

        [DisplayName("本月申请数")]
        [NotMapped]
        public int CurMonthNum { get; set; }

        [DisplayName("联系人姓名")]
        public string lianXiRenName { get; set; }

        [DisplayName("联系人电话")]
        public string lianXiRenPhone { get; set; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class HuoPingReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 货品名
        /// </summary> 
        public string Name { get; set; }


        /// <summary>
        /// 单位描述
        /// </summary> 
        public string SingleDesc { get; set; }


        /// <summary>
        /// 单位数量
        /// </summary> 
        public decimal? SingleCount { get; set; }

        /// <summary>
        /// 用量类型（天/月）
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 用量
        /// </summary> 
        public decimal? DayUseCount { get; set; }


        /// <summary>
        /// 使用类型(门店/宝宝)
        /// </summary> 
        public string UseType { get; set; }


        /// <summary>
        /// 备注_kindeditor
        /// </summary> 
        public string Mark { get; set; }


        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string ProjectName { get; set; }


        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get; set; }


        /// <summary>
        /// 创建日期_createdate
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
        /// 操作人名_optname
        /// </summary> 
        public string OptName { get; set; }


        /// <summary>
        /// 单价
        /// </summary> 
        public decimal? SinglePrice { get; set; }


        /// <summary>
        /// 供应商
        /// </summary> 
        public string Supplier { get; set; }


        /// <summary>
        /// 现库存量
        /// </summary> 
        public decimal? CurStock { get; set; }


        /// <summary>
        /// 有效状态_validstate
        /// </summary> 
        public string ValidState { get; set; }



        /// <summary>
        /// 品牌
        /// </summary>
        public string PinPai { get; set; }

        /// <summary>
        /// 厂家型号
        /// </summary>
        public string ChangjiaXinghao { get; set; }

        /// <summary>
        /// 货品类型：（通用，门店用品，行政易耗品）
        /// </summary>
        public string HuoPinLeixing { get; set; }

        /// <summary>
        ///货品图片
        /// </summary>
        public string HuoPingImg { get; set; }

        /// <summary>
        /// 本月申请数
        /// </summary>
        [NotMapped]
        public int CurMonthNum { get; set; }


        public string lianXiRenName { get; set; }

        public string lianXiRenPhone { get; set; }
        #endregion ----------------------------------------------------------------------
    }

}

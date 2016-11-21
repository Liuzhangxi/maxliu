



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
    /// <para>摘要：HuoPingCaiGouDanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：HuoPingCaiGouDan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>Id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>CaiGouDanBianHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>采购单编号</td></tr>
    /// <tr valign="top"><td>3</td><td>HPCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品数量</td></tr>
    /// <tr valign="top"><td>4</td><td>HPZhongLei</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品种类</td></tr>
    /// <tr valign="top"><td>5</td><td>HPZongJia</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>货品总价</td></tr>
    /// <tr valign="top"><td>6</td><td>CaiGouDanState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>采购单状态（代确认；已确认；已作废）</td></tr>
    /// <tr valign="top"><td>7</td><td>CaiGouDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>采购日期</td></tr>
    /// <tr valign="top"><td>8</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>9</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>操作时间</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("HuoPingCaiGouDan")]
    [Serializable]
    public partial class HuoPingCaiGouDan
    {

        public static string LogClass = "货品采购单";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        private int _Id;
        /// <summary>
        /// 
        /// </summary>
        [Key]

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }



        /// <summary>
        /// 采购单编号
        /// </summary>
        private string _CaiGouDanBianHao = "";
        /// <summary>
        /// 采购单编号
        /// </summary>
        [DisplayName("采购单编号")]

        public string CaiGouDanBianHao
        {
            set { _CaiGouDanBianHao = value; }
            get { return _CaiGouDanBianHao; }
        }



        /// <summary>
        /// 货品数量
        /// </summary>
        private int? _HPCount;
        /// <summary>
        /// 货品数量
        /// </summary>
        [DisplayName("货品数量")]

        public int? HPCount
        {
            set { _HPCount = value; }
            get { return _HPCount; }
        }



        /// <summary>
        /// 货品种类
        /// </summary>
        private int? _HPZhongLei;
        /// <summary>
        /// 货品种类
        /// </summary>
        [DisplayName("货品种类")]

        public int? HPZhongLei
        {
            set { _HPZhongLei = value; }
            get { return _HPZhongLei; }
        }



        /// <summary>
        /// 货品总价
        /// </summary>
        private decimal? _HPZongJia;
        /// <summary>
        /// 货品总价
        /// </summary>
        [DisplayName("货品总价")]

        public decimal? HPZongJia
        {
            set { _HPZongJia = value; }
            get { return _HPZongJia; }
        }



        /// <summary>
        /// 采购单状态（待确认；已确认；已作废）
        /// </summary>
        private string _CaiGouDanState = "";
        /// <summary>
        /// 采购单状态（待确认；已确认；已作废）
        /// </summary>
        [DisplayName("采购单状态（待确认；已确认；已作废）")]

        public string CaiGouDanState
        {
            set { _CaiGouDanState = value; }
            get { return _CaiGouDanState; }
        }



        /// <summary>
        /// 采购日期
        /// </summary>
        private DateTime? _CaiGouDate;
        /// <summary>
        /// 采购日期
        /// </summary>
        [DisplayName("采购日期")]

        public DateTime? CaiGouDate
        {
            set { _CaiGouDate = value; }
            get { return _CaiGouDate; }
        }

        private DateTime _CaiGouDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime CaiGouDateStart
        {
            set { _CaiGouDateStart = value; }
            get { return _CaiGouDateStart; }
        }
        private DateTime _CaiGouDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime CaiGouDateEnd
        {
            set { _CaiGouDateEnd = value; }
            get { return _CaiGouDateEnd; }
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
        private DateTime? _optDateTime;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]

        public DateTime? optDateTime
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

        /// <summary>
        /// 采购单类型：1:行政易耗品；2：门店
        /// </summary>
        [DisplayName("采购单类型")]
        public int? CaiGouDanLeiXing { get; set; }
        #endregion ----------------------------------------------------------------------
    }

    public partial class HuoPingCaiGouDanReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int Id { get; set; }


        /// <summary>
        /// 采购单编号
        /// </summary> 
        public string CaiGouDanBianHao { get; set; }


        /// <summary>
        /// 货品数量
        /// </summary> 
        public int? HPCount { get; set; }


        /// <summary>
        /// 货品种类
        /// </summary> 
        public int? HPZhongLei { get; set; }


        /// <summary>
        /// 货品总价
        /// </summary> 
        public decimal? HPZongJia { get; set; }


        /// <summary>
        /// 采购单状态（待确认；已确认；已作废）
        /// </summary> 
        public string CaiGouDanState { get; set; }


        /// <summary>
        /// 采购日期
        /// </summary> 
        public DateTime? CaiGouDate { get; set; }

        private DateTime _CaiGouDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime CaiGouDateStart
        {
            set { _CaiGouDateStart = value; }
            get { return _CaiGouDateStart; }
        }
        private DateTime _CaiGouDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime CaiGouDateEnd
        {
            set { _CaiGouDateEnd = value; }
            get { return _CaiGouDateEnd; }
        }

        /// <summary>
        /// 操作人
        /// </summary> 
        public string optName { get; set; }


        /// <summary>
        /// 操作时间
        /// </summary> 
        public DateTime? optDateTime { get; set; }

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


        /// <summary>
        /// 采购单类型：1:行政易耗品；2：门店
        /// </summary>
        [DisplayName("采购单类型")]
        public int? CaiGouDanLeiXing { get; set; }
        #endregion ----------------------------------------------------------------------
    }

}





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
    /// <para>摘要：HuoPingRukuModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：HuoPingRuku
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>HPId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品ID</td></tr>
    /// <tr valign="top"><td>3</td><td>HPName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名称</td></tr>
    /// <tr valign="top"><td>4</td><td>SinglePrice</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>单价</td></tr>
    /// <tr valign="top"><td>5</td><td>Supplier</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>供应商</td></tr>
    /// <tr valign="top"><td>6</td><td>ChangjiaXinghao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>厂商型号</td></tr>
    /// <tr valign="top"><td>7</td><td>RuKuDanBianHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>入库编号</td></tr>
    /// <tr valign="top"><td>8</td><td>rukuShuLiang</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>入库数量</td></tr>
    /// <tr valign="top"><td>9</td><td>rukuRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>入库人</td></tr>
    /// <tr valign="top"><td>10</td><td>rukuDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>入库时间</td></tr>
    /// <tr valign="top"><td>11</td><td>rukuState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>入库状态（有效，无效）</td></tr>
    /// <tr valign="top"><td>12</td><td>caigouId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>采购ID</td></tr>
    /// <tr valign="top"><td>13</td><td>CaiGouDanBianHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>采购编号</td></tr>
    /// <tr valign="top"><td>14</td><td>rukuJinEr</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("HuoPingRuku")]
    [Serializable]
    public partial class HuoPingRuku
    {

        public static string LogClass = "货品入库";
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
        private int? _HPId;
        /// <summary>
        /// 货品ID
        /// </summary>
        [DisplayName("货品ID")]

        public int? HPId
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
        /// 厂商型号
        /// </summary>
        private string _ChangjiaXinghao = "";
        /// <summary>
        /// 厂商型号
        /// </summary>
        [DisplayName("厂商型号")]

        public string ChangjiaXinghao
        {
            set { _ChangjiaXinghao = value; }
            get { return _ChangjiaXinghao; }
        }



        /// <summary>
        /// 入库编号
        /// </summary>
        private string _RuKuDanBianHao = "";
        /// <summary>
        /// 入库编号
        /// </summary>
        [DisplayName("入库编号")]

        public string RuKuDanBianHao
        {
            set { _RuKuDanBianHao = value; }
            get { return _RuKuDanBianHao; }
        }



        /// <summary>
        /// 入库数量
        /// </summary>
        private decimal? _rukuShuLiang;
        /// <summary>
        /// 入库数量
        /// </summary>
        [DisplayName("入库数量")]

        public decimal? rukuShuLiang
        {
            set { _rukuShuLiang = value; }
            get { return _rukuShuLiang; }
        }



        /// <summary>
        /// 入库人
        /// </summary>
        private string _rukuRen = "";
        /// <summary>
        /// 入库人
        /// </summary>
        [DisplayName("入库人")]

        public string rukuRen
        {
            set { _rukuRen = value; }
            get { return _rukuRen; }
        }



        /// <summary>
        /// 入库时间
        /// </summary>
        private DateTime? _rukuDate;
        /// <summary>
        /// 入库时间
        /// </summary>
        [DisplayName("入库时间")]

        public DateTime? rukuDate
        {
            set { _rukuDate = value; }
            get { return _rukuDate; }
        }

        private DateTime _rukuDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime rukuDateStart
        {
            set { _rukuDateStart = value; }
            get { return _rukuDateStart; }
        }
        private DateTime _rukuDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime rukuDateEnd
        {
            set { _rukuDateEnd = value; }
            get { return _rukuDateEnd; }
        }


        /// <summary>
        /// 入库状态（有效，无效）
        /// </summary>
        private string _rukuState = "";
        /// <summary>
        /// 入库状态（有效，无效）
        /// </summary>
        [DisplayName("入库状态（有效，无效）")]

        public string rukuState
        {
            set { _rukuState = value; }
            get { return _rukuState; }
        }



        /// <summary>
        /// 采购ID
        /// </summary>
        private int? _caigouId;
        /// <summary>
        /// 采购ID
        /// </summary>
        [DisplayName("采购ID")]

        public int? caigouId
        {
            set { _caigouId = value; }
            get { return _caigouId; }
        }



        /// <summary>
        /// 采购编号
        /// </summary>
        private string _CaiGouDanBianHao = "";
        /// <summary>
        /// 采购编号
        /// </summary>
        [DisplayName("采购编号")]

        public string CaiGouDanBianHao
        {
            set { _CaiGouDanBianHao = value; }
            get { return _CaiGouDanBianHao; }
        }



        /// <summary>
        /// 
        /// </summary>
        private decimal? _rukuJinEr;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("rukuJinEr")]

        public decimal? rukuJinEr
        {
            set { _rukuJinEr = value; }
            get { return _rukuJinEr; }
        }

        /// <summary>
        /// 入库单Id
        /// </summary>
        public int? rukudanId { get; set; }

        /// <summary>
        /// 入库单类型
        /// </summary>
        public int? RuKuLeiXing { get; set; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class HuoPingRukuReq : BaseSearchReq
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
        /// 单价
        /// </summary> 
        public decimal? SinglePrice { get; set; }


        /// <summary>
        /// 供应商
        /// </summary> 
        public string Supplier { get; set; }


        /// <summary>
        /// 厂商型号
        /// </summary> 
        public string ChangjiaXinghao { get; set; }


        /// <summary>
        /// 入库编号
        /// </summary> 
        public string RuKuDanBianHao { get; set; }


        /// <summary>
        /// 入库数量
        /// </summary> 
        public decimal? rukuShuLiang { get; set; }


        /// <summary>
        /// 入库人
        /// </summary> 
        public string rukuRen { get; set; }


        /// <summary>
        /// 入库时间
        /// </summary> 
        public DateTime? rukuDate { get; set; }

        private DateTime _rukuDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime rukuDateStart
        {
            set { _rukuDateStart = value; }
            get { return _rukuDateStart; }
        }
        private DateTime _rukuDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime rukuDateEnd
        {
            set { _rukuDateEnd = value; }
            get { return _rukuDateEnd; }
        }

        /// <summary>
        /// 入库状态（有效，无效）
        /// </summary> 
        public string rukuState { get; set; }


        /// <summary>
        /// 采购ID
        /// </summary> 
        public int? caigouId { get; set; }


        /// <summary>
        /// 采购编号
        /// </summary> 
        public string CaiGouDanBianHao { get; set; }


        /// <summary>
        /// 
        /// </summary> 
        public decimal? rukuJinEr { get; set; }


        /// <summary>
        /// 入库单Id
        /// </summary>
        public int? rukudanId { get; set; }

        /// <summary>
        /// 入库单类型
        /// </summary>
        public int? RuKuLeiXing { get; set; }

        #endregion ----------------------------------------------------------------------
    }

}

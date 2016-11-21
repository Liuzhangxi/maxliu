



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
    /// <para>摘要：HuoPingCaiGouModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HuoPingCaiGou
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>HPId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品ID</td></tr>
    /// <tr valign="top"><td>3</td><td>HPName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名称</td></tr>
    /// <tr valign="top"><td>4</td><td>SinglePrice</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>单价</td></tr>
    /// <tr valign="top"><td>5</td><td>Supplier</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>供应商</td></tr>
    /// <tr valign="top"><td>6</td><td>ChangjiaXinghao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>厂商型号</td></tr>
    /// <tr valign="top"><td>7</td><td>PinPai</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>品牌</td></tr>
    /// <tr valign="top"><td>8</td><td>CaiGouDanBianHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>9</td><td>caigouNum</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>采购数量</td></tr>
    /// <tr valign="top"><td>10</td><td>caigouRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>采购人</td></tr>
    /// <tr valign="top"><td>11</td><td>caigouDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>采购时间</td></tr>
    /// <tr valign="top"><td>12</td><td>shenpiRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审核人</td></tr>
    /// <tr valign="top"><td>13</td><td>shenpiDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>审核时间</td></tr>
    /// <tr valign="top"><td>14</td><td>caigouState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>采购状态（有效，无效）</td></tr>
    /// <tr valign="top"><td>15</td><td>rukuId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>入库ID</td></tr>
    /// <tr valign="top"><td>16</td><td>caigoudanId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>采购单Id</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HuoPingCaiGou")]
    [Serializable]
    public partial class HuoPingCaiGou 
    {
    
        public static string LogClass = "货品采购";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        private int _id ;
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
        private int? _HPId ;
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
        private string _HPName  = "";
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
        private decimal? _SinglePrice ;
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
        private string _Supplier  = "";
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
        private string _ChangjiaXinghao  = "";
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
        /// 品牌
        /// </summary>
        private string _PinPai  = "";
        /// <summary>
        /// 品牌
        /// </summary>
        [DisplayName("品牌")]
        
        public string PinPai
        {
            set { _PinPai = value; }
            get { return _PinPai; }
        }



        /// <summary>
        /// 采购单编号
        /// </summary>
        private string _CaiGouDanBianHao  = "";
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("采购单编号")]
        
        public string CaiGouDanBianHao
        {
            set { _CaiGouDanBianHao = value; }
            get { return _CaiGouDanBianHao; }
        }
        
         
        
        /// <summary>
        /// 采购数量
        /// </summary>
        private int? _caigouNum ;
        /// <summary>
        /// 采购数量
        /// </summary>
        [DisplayName("采购数量")]
        
        public int? caigouNum
        {
            set { _caigouNum = value; }
            get { return _caigouNum; }
        }
        
         
        
        /// <summary>
        /// 采购人
        /// </summary>
        private string _caigouRen  = "";
        /// <summary>
        /// 采购人
        /// </summary>
        [DisplayName("采购人")]
        
        public string caigouRen
        {
            set { _caigouRen = value; }
            get { return _caigouRen; }
        }
        
         
        
        /// <summary>
        /// 采购时间
        /// </summary>
        private DateTime? _caigouDate ;
        /// <summary>
        /// 采购时间
        /// </summary>
        [DisplayName("采购时间")]
        
        public DateTime? caigouDate
        {
            set { _caigouDate = value; }
            get { return _caigouDate; }
        }
        
        private DateTime _caigouDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime caigouDateStart
{
set { _caigouDateStart = value; }
get{ return _caigouDateStart; }
}
 private DateTime _caigouDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime caigouDateEnd
{
set { _caigouDateEnd = value; }
get{ return _caigouDateEnd; }
}
  
        
        /// <summary>
        /// 审核人
        /// </summary>
        private string _shenpiRen  = "";
        /// <summary>
        /// 审核人
        /// </summary>
        [DisplayName("审核人")]
        
        public string shenpiRen
        {
            set { _shenpiRen = value; }
            get { return _shenpiRen; }
        }
        
         
        
        /// <summary>
        /// 审核时间
        /// </summary>
        private DateTime? _shenpiDate ;
        /// <summary>
        /// 审核时间
        /// </summary>
        [DisplayName("审核时间")]
        
        public DateTime? shenpiDate
        {
            set { _shenpiDate = value; }
            get { return _shenpiDate; }
        }
        
        private DateTime _shenpiDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime shenpiDateStart
{
set { _shenpiDateStart = value; }
get{ return _shenpiDateStart; }
}
 private DateTime _shenpiDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime shenpiDateEnd
{
set { _shenpiDateEnd = value; }
get{ return _shenpiDateEnd; }
}
  
        
        /// <summary>
        /// 采购状态（有效，无效）
        /// </summary>
        private string _caigouState  = "";
        /// <summary>
        /// 采购状态（有效，无效）
        /// </summary>
        [DisplayName("采购状态（有效，无效）")]
        
        public string caigouState
        {
            set { _caigouState = value; }
            get { return _caigouState; }
        }
        
         
        
        /// <summary>
        /// 入库ID
        /// </summary>
        private int? _rukuId ;
        /// <summary>
        /// 入库ID
        /// </summary>
        [DisplayName("入库ID")]
        
        public int? rukuId
        {
            set { _rukuId = value; }
            get { return _rukuId; }
        }
        
         
        
        /// <summary>
        /// 采购单Id
        /// </summary>
        private int? _caigoudanId ;
        /// <summary>
        /// 采购单Id
        /// </summary>
        [DisplayName("采购单Id")]
        
        public int? caigoudanId
        {
            set { _caigoudanId = value; }
            get { return _caigoudanId; }
        }
        
        [NotMapped]
         public string jiliangDanWei { get; set; }
        
        [NotMapped]
        public int isRuKu { get; set; }

        /// <summary>
        /// 采购明细类型：1:行政易耗品；2：门店
        /// </summary>
        [DisplayName("采购明细类型")]
        public int? CaiGouLeiXing { get; set; }

        /// <summary>
        /// 已入库数量
        /// </summary>
        [NotMapped]
        public decimal yiRukuShuLiang { get; set; }
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class HuoPingCaiGouReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 货品ID
        /// </summary> 
        public int? HPId { get;set; } 
	
          
        /// <summary>
        /// 货品名称
        /// </summary> 
        public string HPName { get;set; } 
	
          
        /// <summary>
        /// 单价
        /// </summary> 
        public decimal? SinglePrice { get;set; } 
	
          
        /// <summary>
        /// 供应商
        /// </summary> 
        public string Supplier { get;set; } 
	
          
        /// <summary>
        /// 厂商型号
        /// </summary> 
        public string ChangjiaXinghao { get;set; } 
	
          
        /// <summary>
        /// 品牌
        /// </summary> 
        public string PinPai { get;set; }


        /// <summary>
        /// 采购单编号
        /// </summary> 
        public string CaiGouDanBianHao { get;set; } 
	
          
        /// <summary>
        /// 采购数量
        /// </summary> 
        public int? caigouNum { get;set; } 
	
          
        /// <summary>
        /// 采购人
        /// </summary> 
        public string caigouRen { get;set; } 
	
          
        /// <summary>
        /// 采购时间
        /// </summary> 
        public DateTime? caigouDate { get;set; } 
	
          private DateTime _caigouDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime caigouDateStart
{
set { _caigouDateStart = value; }
get{ return _caigouDateStart; }
}
 private DateTime _caigouDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime caigouDateEnd
{
set { _caigouDateEnd = value; }
get{ return _caigouDateEnd; }
}
 
        /// <summary>
        /// 审核人
        /// </summary> 
        public string shenpiRen { get;set; } 
	
          
        /// <summary>
        /// 审核时间
        /// </summary> 
        public DateTime? shenpiDate { get;set; } 
	
          private DateTime _shenpiDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime shenpiDateStart
{
set { _shenpiDateStart = value; }
get{ return _shenpiDateStart; }
}
 private DateTime _shenpiDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime shenpiDateEnd
{
set { _shenpiDateEnd = value; }
get{ return _shenpiDateEnd; }
}
 
        /// <summary>
        /// 采购状态（有效，无效）
        /// </summary> 
        public string caigouState { get;set; } 
	
          
        /// <summary>
        /// 入库ID
        /// </summary> 
        public int? rukuId { get;set; } 
	
          
        /// <summary>
        /// 采购单Id
        /// </summary> 
        public int? caigoudanId { get;set; }


        /// <summary>
        /// 采购明细类型：1:行政易耗品；2：门店
        /// </summary>
        [DisplayName("采购明细类型")]
        public int? CaiGouLeiXing { get; set; }

        /// <summary>
        /// 已入库数量
        /// </summary>
        public decimal yiRukuShuLiang { get; set; }
        #endregion ----------------------------------------------------------------------
    } 
    
}

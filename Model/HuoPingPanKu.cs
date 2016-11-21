



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
    /// <para>摘要：HuoPingPanKuModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HuoPingPanKu
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>HPId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品ID</td></tr>
    /// <tr valign="top"><td>3</td><td>HPName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名称</td></tr>
    /// <tr valign="top"><td>4</td><td>SinglePrice</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>单价</td></tr>
    /// <tr valign="top"><td>5</td><td>Supplier</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>供应商</td></tr>
    /// <tr valign="top"><td>6</td><td>ChangjiaXinghao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>厂商型号</td></tr>
    /// <tr valign="top"><td>7</td><td>PinPai</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>品牌</td></tr>
    /// <tr valign="top"><td>8</td><td>CurKuCun</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>当前库存</td></tr>
    /// <tr valign="top"><td>9</td><td>PanKuNum</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>盘库后数</td></tr>
    /// <tr valign="top"><td>10</td><td>ChaYiNum</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>差异数</td></tr>
    /// <tr valign="top"><td>11</td><td>PanKuRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>盘库人</td></tr>
    /// <tr valign="top"><td>12</td><td>PanKuDate</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>盘库时间</td></tr>
    /// <tr valign="top"><td>13</td><td>PanKuState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>盘库状态（有效，无效）</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HuoPingPanKu")]
    [Serializable]
    public partial class HuoPingPanKu 
    {
    
        public static string LogClass = "货品盘库";
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
        /// 当前库存
        /// </summary>
        private int? _CurKuCun ;
        /// <summary>
        /// 当前库存
        /// </summary>
        [DisplayName("当前库存")]
        
        public int? CurKuCun
        {
            set { _CurKuCun = value; }
            get { return _CurKuCun; }
        }
        
         
        
        /// <summary>
        /// 盘库后数
        /// </summary>
        private int? _PanKuNum ;
        /// <summary>
        /// 盘库后数
        /// </summary>
        [DisplayName("盘库后数")]
        
        public int? PanKuNum
        {
            set { _PanKuNum = value; }
            get { return _PanKuNum; }
        }
        
         
        
        /// <summary>
        /// 差异数
        /// </summary>
        private int? _ChaYiNum ;
        /// <summary>
        /// 差异数
        /// </summary>
        [DisplayName("差异数")]
        
        public int? ChaYiNum
        {
            set { _ChaYiNum = value; }
            get { return _ChaYiNum; }
        }
        
         
        
        /// <summary>
        /// 盘库人
        /// </summary>
        private string _PanKuRen  = "";
        /// <summary>
        /// 盘库人
        /// </summary>
        [DisplayName("盘库人")]
        
        public string PanKuRen
        {
            set { _PanKuRen = value; }
            get { return _PanKuRen; }
        }
        
         
        
        /// <summary>
        /// 盘库时间
        /// </summary>
        private string _PanKuDate  = "";
        /// <summary>
        /// 盘库时间
        /// </summary>
        [DisplayName("盘库时间")]
        
        public string PanKuDate
        {
            set { _PanKuDate = value; }
            get { return _PanKuDate; }
        }
        
         
        
        /// <summary>
        /// 盘库状态（有效，无效）
        /// </summary>
        private string _PanKuState  = "";
        /// <summary>
        /// 盘库状态（有效，无效）
        /// </summary>
        [DisplayName("盘库状态（有效，无效）")]
        
        public string PanKuState
        {
            set { _PanKuState = value; }
            get { return _PanKuState; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class HuoPingPanKuReq:BaseSearchReq
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
        /// 当前库存
        /// </summary> 
        public int? CurKuCun { get;set; } 
	
          
        /// <summary>
        /// 盘库后数
        /// </summary> 
        public int? PanKuNum { get;set; } 
	
          
        /// <summary>
        /// 差异数
        /// </summary> 
        public int? ChaYiNum { get;set; } 
	
          
        /// <summary>
        /// 盘库人
        /// </summary> 
        public string PanKuRen { get;set; } 
	
          
        /// <summary>
        /// 盘库时间
        /// </summary> 
        public string PanKuDate { get;set; } 
	
          
        /// <summary>
        /// 盘库状态（有效，无效）
        /// </summary> 
        public string PanKuState { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

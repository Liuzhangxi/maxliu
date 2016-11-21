



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
    /// <para>摘要：DDShouKuanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：DDShouKuan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>HeTongID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>合同ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>HeTongNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>合同编号</td></tr>
    /// <tr valign="top"><td>4</td><td>HeTongName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>合同名称</td></tr>
    /// <tr valign="top"><td>5</td><td>KhID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>客户ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>6</td><td>KhName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>客户名字</td></tr>
    /// <tr valign="top"><td>7</td><td>SKName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>收款名称</td></tr>
    /// <tr valign="top"><td>8</td><td>SKMoney</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td></td><td></td><td>收款金额</td></tr>
    /// <tr valign="top"><td>9</td><td>SKClass</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>收款类型ID</td></tr>
    /// <tr valign="top"><td>10</td><td>SKPayOnlieNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>第三方支付的返回的流水号_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>11</td><td>SKDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>收款时间</td></tr>
    /// <tr valign="top"><td>12</td><td>SKStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>收款状态</td></tr>
    /// <tr valign="top"><td>13</td><td>SKInfos</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>收款说明_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>14</td><td>ProjectID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>所属项目公司Id</td></tr>
    /// <tr valign="top"><td>15</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>16</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("DDShouKuan")]
    [Serializable]
    public partial class DDShouKuan 
    {
    
        public static string LogClass = "收款表";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("交割单")]
        public int? JiaoGeId { get; set; }

        [DisplayName("服务项情况说明")]
        public string ServerMsg { get; set; }
        
        [DisplayName("收款方式")]
        public string SKFangShi { get; set; }
        [DisplayName("收款编号")]
        public string SKNumber { get; set; }
        /// <summary>
        /// seed
        /// </summary>
        private int _id ;
        /// <summary>
        /// seed
        /// </summary>
        [Key]
         [Required]
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        
         
        
        /// <summary>
        /// 合同ID_listhidden_searchhidden
        /// </summary>
        private int _HeTongID ;
        /// <summary>
        /// 合同ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("合同ID")]
         [Required]
        public int HeTongID
        {
            set { _HeTongID = value; }
            get { return _HeTongID; }
        }
        
         
        
        /// <summary>
        /// 合同编号
        /// </summary>
        private string _HeTongNumber  = "";
        /// <summary>
        /// 合同编号
        /// </summary>
        [DisplayName("合同编号")]
        public string HeTongNumber
        {
            set { _HeTongNumber = value; }
            get { return _HeTongNumber; }
        }
        
         
        
        /// <summary>
        /// 合同名称
        /// </summary>
        private string _HeTongName  = "";
        /// <summary>
        /// 合同名称
        /// </summary>
        [DisplayName("合同名称")]
        public string HeTongName
        {
            set { _HeTongName = value; }
            get { return _HeTongName; }
        }
        
         
        
        /// <summary>
        /// 客户ID_listhidden_searchhidden
        /// </summary>
        private int _KhID ;
        /// <summary>
        /// 客户ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("客户ID")]
         [Required]
        public int KhID
        {
            set { _KhID = value; }
            get { return _KhID; }
        }
        
         
        
        /// <summary>
        /// 客户名字
        /// </summary>
        private string _KhName  = "";
        /// <summary>
        /// 客户名字
        /// </summary>
        [DisplayName("客户名字")]
         [Required]
        public string KhName
        {
            set { _KhName = value; }
            get { return _KhName; }
        }
        
         
        
        /// <summary>
        /// 收款名称
        /// </summary>
        private string _SKName  = "";
        /// <summary>
        /// 收款名称
        /// </summary>
        [DisplayName("收款名称")]
        public string SKName
        {
            set { _SKName = value; }
            get { return _SKName; }
        }
        
         
        
        /// <summary>
        /// 收款金额
        /// </summary>
        private decimal _SKMoney ;
        /// <summary>
        /// 收款金额
        /// </summary>
        [DisplayName("收款金额")]
         [Required]
        public decimal SKMoney
        {
            set { _SKMoney = value; }
            get { return _SKMoney; }
        }
        
         
        
        /// <summary>
      
        [DisplayName("收款类型")]
         [Required]
        public string SKClass { get; set; }
        
         
        
        /// <summary>
        /// 第三方支付的返回的流水号_listhidden_searchhidden
        /// </summary>
        private string _SKPayOnlieNumber  = "";
        /// <summary>
        /// 第三方支付的返回的流水号_listhidden_searchhidden
        /// </summary>
        [DisplayName("第三方支付的返回的流水号")]
        
        public string SKPayOnlieNumber
        {
            set { _SKPayOnlieNumber = value; }
            get { return _SKPayOnlieNumber; }
        }
        
         
        
        /// <summary>
        /// 收款时间
        /// </summary>
        private DateTime _SKDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 收款时间
        /// </summary>
        [DisplayName("收款时间")]
         [Required]
        public DateTime SKDateTime
        {
            set { _SKDateTime = value; }
            get { return _SKDateTime; }
        }
        
        private DateTime _SKDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SKDateTimeStart
{
set { _SKDateTimeStart = value; }
get{ return _SKDateTimeStart; }
}
 private DateTime _SKDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SKDateTimeEnd
{
set { _SKDateTimeEnd = value; }
get{ return _SKDateTimeEnd; }
}
  
        
        
        /// <summary>
        /// 收款状态
        /// </summary>
        [DisplayName("收款状态")]
         [Required]
        public string SKState { get; set; }
        
         
        
        /// <summary>
        /// 收款说明_listhidden_searchhidden
        /// </summary>
        private string _SKInfos  = "";
        /// <summary>
        /// 收款说明_listhidden_searchhidden
        /// </summary>
        [DisplayName("收款说明")]
        
        public string SKInfos
        {
            set { _SKInfos = value; }
            get { return _SKInfos; }
        }
        
         
        
        /// <summary>
        /// 所属项目公司Id
        /// </summary>
        private int _ProjectID ;
        /// <summary>
        /// 所属项目公司Id
        /// </summary>
        [DisplayName("所属门店")]
         [Required]
        public int ProjectID
        {
            set { _ProjectID = value; }
            get { return _ProjectID; }
        }

        public string ProjectName { get; set; } 
        
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        [DisplayName("操作人")]
         [Required]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 操作时间_createdate_listhidden_searchhidden
        /// </summary>
        private DateTime _optDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间_createdate_listhidden_searchhidden
        /// </summary>
        [DisplayName("操作时间")]
         [Required]
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
get{ return _optDateTimeStart; }
}
 private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeEnd
{
set { _optDateTimeEnd = value; }
get{ return _optDateTimeEnd; }
}

        public int? CheckerId { get; set; }


        public string CheckerName { get; set; }

        public DateTime? CheckerDate { get; set; }

        public string CheckState { get; set; }


        #endregion ----------------------------------------------------------------------
    }

    public partial class DDShouKuanReq:BaseSearchReq
    {
        [DisplayName("交割单")]
        public int? JiaoGeId { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("服务项情况说明")]
        public string ServerMsg { get; set; }
        public string ProjectName { get; set; }
        [DisplayName("收款方式")]
        public string SKFangShi { get; set; }
        [DisplayName("收款编号")]
        public string SKNumber { get; set; }
        /// <summary>
        /// seed
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 合同ID_listhidden_searchhidden
        /// </summary> 
        public int? HeTongID { get;set; } 
	
          
        /// <summary>
        /// 合同编号
        /// </summary> 
        public string HeTongNumber { get;set; } 
	
          
        /// <summary>
        /// 合同名称
        /// </summary> 
        public string HeTongName { get;set; } 
	
          
        /// <summary>
        /// 客户ID_listhidden_searchhidden
        /// </summary> 
        public int? KhID { get;set; } 
	
          
        /// <summary>
        /// 客户名字
        /// </summary> 
        public string KhName { get;set; } 
	
          
        /// <summary>
        /// 收款名称
        /// </summary> 
        public string SKName { get;set; } 
	
          
        /// <summary>
        /// 收款金额
        /// </summary> 
        public decimal? SKMoney { get;set; } 
	
          
        /// <summary>
        /// 收款类型ID
        /// </summary> 
        public string SKClass { get;set; } 
	
          
        /// <summary>
        /// 第三方支付的返回的流水号_listhidden_searchhidden
        /// </summary> 
        public string SKPayOnlieNumber { get;set; } 
	
          
        /// <summary>
        /// 收款时间
        /// </summary> 
        public DateTime? SKDateTime { get;set; } 
	
          private DateTime _SKDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SKDateTimeStart
{
set { _SKDateTimeStart = value; }
get{ return _SKDateTimeStart; }
}
 private DateTime _SKDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SKDateTimeEnd
{
set { _SKDateTimeEnd = value; }
get{ return _SKDateTimeEnd; }
}
 
        /// <summary>
        /// 收款状态
        /// </summary> 
        public string SKState { get;set; } 
	
          
        /// <summary>
        /// 收款说明_listhidden_searchhidden
        /// </summary> 
        public string SKInfos { get;set; } 
	
          
        /// <summary>
        /// 所属项目公司Id
        /// </summary> 
        //public int? ProjectID { get;set; } 
	
          
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 操作时间_createdate_listhidden_searchhidden
        /// </summary> 
        public DateTime? optDateTime { get;set; } 
	
          private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeStart
{
set { _optDateTimeStart = value; }
get{ return _optDateTimeStart; }
}
 private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeEnd
{
set { _optDateTimeEnd = value; }
get{ return _optDateTimeEnd; }
}
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}





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
    /// <para>摘要：ChildCareMainModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：ChildCareMain
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>日期</td></tr>
    /// <tr valign="top"><td>3</td><td>Temperature</td><td>decimal</td><td>9</td><td>18,1</td><td></td><td></td><td>√</td><td></td><td>体温</td></tr>
    /// <tr valign="top"><td>4</td><td>Weight</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>体重</td></tr>
    /// <tr valign="top"><td>5</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>6</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>7</td><td>ChildDesc</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>宝标签</td></tr>
    /// <tr valign="top"><td>8</td><td>KhId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户</td></tr>
    /// <tr valign="top"><td>9</td><td>KhName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("ChildCareMain")]
    [Serializable]
    public partial class ChildCareMain 
    {
    
        public static string LogClass = "宝宝护理";
        #region -  公共属性  ------------------------------------------------------------
        public int? projectid { get; set; }
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
        /// 日期
        /// </summary>
        private DateTime? _ServerDate ;
        /// <summary>
        /// 日期
        /// </summary>
        [DisplayName("日期")]
        
        public DateTime? ServerDate
        {
            set { _ServerDate = value; }
            get { return _ServerDate; }
        }
        
        private DateTime _ServerDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateStart
{
set { _ServerDateStart = value; }
get{ return _ServerDateStart; }
}
 private DateTime _ServerDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateEnd
{
set { _ServerDateEnd = value; }
get{ return _ServerDateEnd; }
}
  
        
        /// <summary>
        /// 体温
        /// </summary>
        private decimal? _Temperature ;
        /// <summary>
        /// 体温
        /// </summary>
        [DisplayName("体温")]
        
        public decimal? Temperature
        {
            set { _Temperature = value; }
            get { return _Temperature; }
        }
        
         
        
        /// <summary>
        /// 体重
        /// </summary>
        private decimal? _Weight ;
        /// <summary>
        /// 体重
        /// </summary>
        [DisplayName("体重")]
        
        public decimal? Weight
        {
            set { _Weight = value; }
            get { return _Weight; }
        }
        
         
        
        /// <summary>
        /// 操作人_optid
        /// </summary>
        private int? _OptId ;
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
        /// 操作人名_optname
        /// </summary>
        private string _OptName  = "";
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
        /// 宝标签
        /// </summary>
        private string _ChildDesc  = "";
        /// <summary>
        /// 宝标签
        /// </summary>
        [DisplayName("宝标签")]
        
        public string ChildDesc
        {
            set { _ChildDesc = value; }
            get { return _ChildDesc; }
        }
        
         
        
        /// <summary>
        /// 客户
        /// </summary>
        private int? _KhId ;
        /// <summary>
        /// 客户
        /// </summary>
        [DisplayName("客户")]
        
        public int? KhId
        {
            set { _KhId = value; }
            get { return _KhId; }
        }
        
         
        
        /// <summary>
        /// 客户名
        /// </summary>
        private string _KhName  = "";
        /// <summary>
        /// 客户名
        /// </summary>
        [DisplayName("客户名")]
        
        public string KhName
        {
            set { _KhName = value; }
            get { return _KhName; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class ChildCareMainReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        public int? projectid { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 日期
        /// </summary> 
        public DateTime? ServerDate { get;set; } 
	
          private DateTime _ServerDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateStart
{
set { _ServerDateStart = value; }
get{ return _ServerDateStart; }
}
 private DateTime _ServerDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateEnd
{
set { _ServerDateEnd = value; }
get{ return _ServerDateEnd; }
}
 
        /// <summary>
        /// 体温
        /// </summary> 
        public decimal? Temperature { get;set; } 
	
          
        /// <summary>
        /// 体重
        /// </summary> 
        public decimal? Weight { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 宝标签
        /// </summary> 
        public string ChildDesc { get;set; } 
	
          
        /// <summary>
        /// 客户
        /// </summary> 
        public int? KhId { get;set; } 
	
          
        /// <summary>
        /// 客户名
        /// </summary> 
        public string KhName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

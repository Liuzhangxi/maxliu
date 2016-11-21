



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
    /// <para>摘要：HuoPingShenQingModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HuoPingShenQing
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>3</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>4</td><td>HuoPingCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品数量</td></tr>
    /// <tr valign="top"><td>5</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>6</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>7</td><td>OptDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>操作时间</td></tr>
    /// <tr valign="top"><td>8</td><td>ServerMonth</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>月份</td></tr>
    /// <tr valign="top"><td>9</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审批状态</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HuoPingShenQing")]
    [Serializable]
    public partial class HuoPingShenQing 
    {
    
        public static string LogClass = "HuoPingShenQing";
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
        /// 门店_projectid
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 门店_projectid
        /// </summary>
        [DisplayName("门店")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        private string _ProjectName  = "";
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
        /// 货品数量
        /// </summary>
        private int? _HuoPingCount ;
        /// <summary>
        /// 货品数量
        /// </summary>
        [DisplayName("货品数量")]
        
        public int? HuoPingCount
        {
            set { _HuoPingCount = value; }
            get { return _HuoPingCount; }
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
        /// 操作时间
        /// </summary>
        private DateTime? _OptDateTime ;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]
        
        public DateTime? OptDateTime
        {
            set { _OptDateTime = value; }
            get { return _OptDateTime; }
        }
        
        private DateTime _OptDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeStart
{
set { _OptDateTimeStart = value; }
get{ return _OptDateTimeStart; }
}
 private DateTime _OptDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeEnd
{
set { _OptDateTimeEnd = value; }
get{ return _OptDateTimeEnd; }
}
  
        
        /// <summary>
        /// 月份
        /// </summary>
        private string _ServerMonth  = "";
        /// <summary>
        /// 月份
        /// </summary>
        [DisplayName("月份")]
        
        public string ServerMonth
        {
            set { _ServerMonth = value; }
            get { return _ServerMonth; }
        }
        
         
        
        /// <summary>
        /// 审批状态
        /// </summary>
        private string _State  = "";
        /// <summary>
        /// 审批状态
        /// </summary>
        [DisplayName("审批状态")]
        
        public string State
        {
            set { _State = value; }
            get { return _State; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class HuoPingShenQingReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 货品数量
        /// </summary> 
        public int? HuoPingCount { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 操作时间
        /// </summary> 
        public DateTime? OptDateTime { get;set; } 
	
          private DateTime _OptDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeStart
{
set { _OptDateTimeStart = value; }
get{ return _OptDateTimeStart; }
}
 private DateTime _OptDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeEnd
{
set { _OptDateTimeEnd = value; }
get{ return _OptDateTimeEnd; }
}
 
        /// <summary>
        /// 月份
        /// </summary> 
        public string ServerMonth { get;set; } 
	
          
        /// <summary>
        /// 审批状态
        /// </summary> 
        public string State { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

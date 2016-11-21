



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
    /// <para>摘要：HuLiRegistModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HuLiRegist
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>StartDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>开始时间</td></tr>
    /// <tr valign="top"><td>3</td><td>EndDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>结束时间</td></tr>
    /// <tr valign="top"><td>4</td><td>ServerType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>服务类型</td></tr>
    /// <tr valign="top"><td>5</td><td>PareCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户数</td></tr>
    /// <tr valign="top"><td>6</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>7</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>8</td><td>createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>9</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>项目_projectid</td></tr>
    /// <tr valign="top"><td>10</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>服务时间</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HuLiRegist")]
    [Serializable]
    public partial class HuLiRegist 
    {
    
        public static string LogClass = "护理登记";
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
        /// 开始时间
        /// </summary>
        private DateTime? _StartDate ;
        /// <summary>
        /// 开始时间
        /// </summary>
        [DisplayName("开始时间")]
        
        public DateTime? StartDate
        {
            set { _StartDate = value; }
            get { return _StartDate; }
        }
        
        private DateTime _StartDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartDateStart
{
set { _StartDateStart = value; }
get{ return _StartDateStart; }
}
 private DateTime _StartDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartDateEnd
{
set { _StartDateEnd = value; }
get{ return _StartDateEnd; }
}
  
        
        /// <summary>
        /// 结束时间
        /// </summary>
        private DateTime? _EndDate ;
        /// <summary>
        /// 结束时间
        /// </summary>
        [DisplayName("结束时间")]
        
        public DateTime? EndDate
        {
            set { _EndDate = value; }
            get { return _EndDate; }
        }
        
        private DateTime _EndDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EndDateStart
{
set { _EndDateStart = value; }
get{ return _EndDateStart; }
}
 private DateTime _EndDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EndDateEnd
{
set { _EndDateEnd = value; }
get{ return _EndDateEnd; }
}
  
        
        /// <summary>
        /// 服务类型
        /// </summary>
        private string _ServerType  = "";
        /// <summary>
        /// 服务类型
        /// </summary>
        [DisplayName("服务类型")]
        
        public string ServerType
        {
            set { _ServerType = value; }
            get { return _ServerType; }
        }
        
         
        
        /// <summary>
        /// 客户数
        /// </summary>
        private int? _PareCount ;
        /// <summary>
        /// 客户数
        /// </summary>
        [DisplayName("客户数")]
        
        public int? PareCount
        {
            set { _PareCount = value; }
            get { return _PareCount; }
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
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _createdate ;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]
        
        public DateTime? createdate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        
        private DateTime _createdateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateStart
{
set { _createdateStart = value; }
get{ return _createdateStart; }
}
 private DateTime _createdateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateEnd
{
set { _createdateEnd = value; }
get{ return _createdateEnd; }
}
  
        
        /// <summary>
        /// 项目_projectid
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 项目_projectid
        /// </summary>
        [DisplayName("项目")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 服务时间
        /// </summary>
        private DateTime? _ServerDate ;
        /// <summary>
        /// 服务时间
        /// </summary>
        [DisplayName("服务时间")]
        
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
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class HuLiRegistReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 开始时间
        /// </summary> 
        public DateTime? StartDate { get;set; } 
	
          private DateTime _StartDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartDateStart
{
set { _StartDateStart = value; }
get{ return _StartDateStart; }
}
 private DateTime _StartDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartDateEnd
{
set { _StartDateEnd = value; }
get{ return _StartDateEnd; }
}
 
        /// <summary>
        /// 结束时间
        /// </summary> 
        public DateTime? EndDate { get;set; } 
	
          private DateTime _EndDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EndDateStart
{
set { _EndDateStart = value; }
get{ return _EndDateStart; }
}
 private DateTime _EndDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EndDateEnd
{
set { _EndDateEnd = value; }
get{ return _EndDateEnd; }
}
 
        /// <summary>
        /// 服务类型
        /// </summary> 
        public string ServerType { get;set; } 
	
          
        /// <summary>
        /// 客户数
        /// </summary> 
        public int? PareCount { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建时间_createdate
        /// </summary> 
        public DateTime? createdate { get;set; } 
	
          private DateTime _createdateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateStart
{
set { _createdateStart = value; }
get{ return _createdateStart; }
}
 private DateTime _createdateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateEnd
{
set { _createdateEnd = value; }
get{ return _createdateEnd; }
}
 
        /// <summary>
        /// 服务时间
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
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

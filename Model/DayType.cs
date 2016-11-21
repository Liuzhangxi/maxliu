



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
    /// <para>摘要：DayTypeModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：DayType
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>DayTypeName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>日期类型(假期)</td></tr>
    /// <tr valign="top"><td>3</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>日期</td></tr>
    /// <tr valign="top"><td>4</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者_optid</td></tr>
    /// <tr valign="top"><td>5</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名_optname</td></tr>
    /// <tr valign="top"><td>6</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>7</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态_validstate</td></tr>
    /// <tr valign="top"><td>8</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>项目_projectid</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("DayType")]
    [Serializable]
    public partial class DayType 
    {
    
        public static string LogClass = "日期类型信息";
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
        /// 日期类型(假期)
        /// </summary>
        private string _DayTypeName  = "";
        /// <summary>
        /// 日期类型(假期)
        /// </summary>
        [DisplayName("日期类型(假期)")]
        
        public string DayTypeName
        {
            set { _DayTypeName = value; }
            get { return _DayTypeName; }
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
        /// 操作者_optid
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作者_optid
        /// </summary>
        [DisplayName("操作者")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作者名_optname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作者名_optname
        /// </summary>
        [DisplayName("操作者名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _CreateDate ;
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
get{ return _CreateDateStart; }
}
 private DateTime _CreateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateEnd
{
set { _CreateDateEnd = value; }
get{ return _CreateDateEnd; }
}
  
        
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        private string _ValidState  = "";
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        [DisplayName("有效状态")]
        
        public string ValidState
        {
            set { _ValidState = value; }
            get { return _ValidState; }
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
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class DayTypeReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 日期类型(假期)
        /// </summary> 
        public string DayTypeName { get;set; } 
	
          
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
        /// 操作者_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作者名_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
        /// </summary> 
        public DateTime? CreateDate { get;set; } 
	
          private DateTime _CreateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateStart
{
set { _CreateDateStart = value; }
get{ return _CreateDateStart; }
}
 private DateTime _CreateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateEnd
{
set { _CreateDateEnd = value; }
get{ return _CreateDateEnd; }
}
 
        /// <summary>
        /// 有效状态_validstate
        /// </summary> 
        public string ValidState { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

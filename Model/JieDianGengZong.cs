



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
    /// <para>摘要：JieDianGengZongModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JieDianGengZong
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>jdid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>跟踪节点id</td></tr>
    /// <tr valign="top"><td>3</td><td>jdName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>跟踪节点名</td></tr>
    /// <tr valign="top"><td>4</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员</td></tr>
    /// <tr valign="top"><td>5</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>6</td><td>OptDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>7</td><td>Desc</td><td>nvarchar</td><td>500</td><td></td><td></td><td></td><td>√</td><td></td><td>描述</td></tr>
    /// <tr valign="top"><td>8</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("JieDianGengZong")]
    [Serializable]
    public partial class JieDianGengZong 
    {
    
        public static string LogClass = "节点跟踪";
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
        /// 跟踪节点id
        /// </summary>
        private int? _jdid ;
        /// <summary>
        /// 跟踪节点id
        /// </summary>
        [DisplayName("跟踪节点id")]
        
        public int? jdid
        {
            set { _jdid = value; }
            get { return _jdid; }
        }
        
         
        
        /// <summary>
        /// 跟踪节点名
        /// </summary>
        private string _jdName  = "";
        /// <summary>
        /// 跟踪节点名
        /// </summary>
        [DisplayName("跟踪节点名")]
        
        public string jdName
        {
            set { _jdName = value; }
            get { return _jdName; }
        }
        
         
        
        /// <summary>
        /// 操作员
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作员
        /// </summary>
        [DisplayName("操作员")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OptId")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _OptDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
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
        /// 描述
        /// </summary>
        private string _Desc  = "";
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("描述")]
        
        public string Desc
        {
            set { _Desc = value; }
            get { return _Desc; }
        }
        
         
        
        /// <summary>
        /// 状态
        /// </summary>
        private string _State  = "";
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态")]
        
        public string State
        {
            set { _State = value; }
            get { return _State; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JieDianGengZongReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 跟踪节点id
        /// </summary> 
        public int? jdid { get;set; } 
	
          
        /// <summary>
        /// 跟踪节点名
        /// </summary> 
        public string jdName { get;set; } 
	
          
        /// <summary>
        /// 操作员
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
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
        /// 描述
        /// </summary> 
        public string Desc { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

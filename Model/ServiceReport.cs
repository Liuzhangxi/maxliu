



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
    /// <para>摘要：ServiceReportModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：ServiceReport
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Mark</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>内容</td></tr>
    /// <tr valign="top"><td>3</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>服务日期</td></tr>
    /// <tr valign="top"><td>4</td><td>RoomId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>房间信息</td></tr>
    /// <tr valign="top"><td>5</td><td>RoomNumber</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>房号</td></tr>
    /// <tr valign="top"><td>6</td><td>KeHuName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名</td></tr>
    /// <tr valign="top"><td>7</td><td>KeHuId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户</td></tr>
    /// <tr valign="top"><td>8</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>9</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者_optid</td></tr>
    /// <tr valign="top"><td>10</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optname</td></tr>
    /// <tr valign="top"><td>11</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>记录创建时间_createdate</td></tr>
    /// <tr valign="top"><td>12</td><td>ProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店信息</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("ServiceReport")]
    [Serializable]
    public partial class ServiceReport 
    {
    
        public static string LogClass = "客服报表";
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
        /// 内容
        /// </summary>
        private string _Mark  = "";
        /// <summary>
        /// 内容
        /// </summary>
        [DisplayName("内容")]
        
        public string Mark
        {
            set { _Mark = value; }
            get { return _Mark; }
        }
        
         
        
        /// <summary>
        /// 服务日期
        /// </summary>
        private DateTime? _ServerDate ;
        /// <summary>
        /// 服务日期
        /// </summary>
        [DisplayName("服务日期")]
        
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
        /// 房间信息
        /// </summary>
        private int? _RoomId ;
        /// <summary>
        /// 房间信息
        /// </summary>
        [DisplayName("房间信息")]
        
        public int? RoomId
        {
            set { _RoomId = value; }
            get { return _RoomId; }
        }
        
         
        
        /// <summary>
        /// 房号
        /// </summary>
        private string _RoomNumber  = "";
        /// <summary>
        /// 房号
        /// </summary>
        [DisplayName("房号")]
        
        public string RoomNumber
        {
            set { _RoomNumber = value; }
            get { return _RoomNumber; }
        }
        
         
        
        /// <summary>
        /// 客户名
        /// </summary>
        private string _KeHuName  = "";
        /// <summary>
        /// 客户名
        /// </summary>
        [DisplayName("客户名")]
        
        public string KeHuName
        {
            set { _KeHuName = value; }
            get { return _KeHuName; }
        }
        
         
        
        /// <summary>
        /// 客户
        /// </summary>
        private int? _KeHuId ;
        /// <summary>
        /// 客户
        /// </summary>
        [DisplayName("客户")]
        
        public int? KeHuId
        {
            set { _KeHuId = value; }
            get { return _KeHuId; }
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
        /// 操作人_optname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人_optname
        /// </summary>
        [DisplayName("操作人")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 记录创建时间_createdate
        /// </summary>
        private DateTime? _CreateDate ;
        /// <summary>
        /// 记录创建时间_createdate
        /// </summary>
        [DisplayName("记录创建时间")]
        
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
        /// 门店信息
        /// </summary>
        private int? _ProjectId ;
        /// <summary>
        /// 门店信息
        /// </summary>
        [DisplayName("门店信息")]
        
        public int? ProjectId
        {
            set { _ProjectId = value; }
            get { return _ProjectId; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class ServiceReportReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 内容
        /// </summary> 
        public string Mark { get;set; } 
	
          
        /// <summary>
        /// 服务日期
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
        /// 房间信息
        /// </summary> 
        public int? RoomId { get;set; } 
	
          
        /// <summary>
        /// 房号
        /// </summary> 
        public string RoomNumber { get;set; } 
	
          
        /// <summary>
        /// 客户名
        /// </summary> 
        public string KeHuName { get;set; } 
	
          
        /// <summary>
        /// 客户
        /// </summary> 
        public int? KeHuId { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 操作者_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 记录创建时间_createdate
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
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}





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
    /// <para>摘要：CustomerPingXiangModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：CustomerPingXiang
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>KhId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户</td></tr>
    /// <tr valign="top"><td>3</td><td>KhName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名</td></tr>
    /// <tr valign="top"><td>4</td><td>PingXiangName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>品项名</td></tr>
    /// <tr valign="top"><td>5</td><td>GongXiao</td><td>nvarchar</td><td>450</td><td></td><td></td><td></td><td>√</td><td></td><td>功效</td></tr>
    /// <tr valign="top"><td>6</td><td>EatStart</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>食用开始时间</td></tr>
    /// <tr valign="top"><td>7</td><td>EatEnd</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>食用结束时间</td></tr>
    /// <tr valign="top"><td>8</td><td>PeiLiao</td><td>nvarchar</td><td>350</td><td></td><td></td><td></td><td>√</td><td></td><td>配料</td></tr>
    /// <tr valign="top"><td>9</td><td>Desc</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>食用说明</td></tr>
    /// <tr valign="top"><td>10</td><td>ProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>项目</td></tr>
    /// <tr valign="top"><td>11</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>项目名</td></tr>
    /// <tr valign="top"><td>12</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态</td></tr>
    /// <tr valign="top"><td>13</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者</td></tr>
    /// <tr valign="top"><td>14</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名</td></tr>
    /// <tr valign="top"><td>15</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>16</td><td>RoomId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>17</td><td>RoomNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>房间号</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("CustomerPingXiang")]
    [Serializable]
    public partial class CustomerPingXiang 
    {
    
        public static string LogClass = "客人食疗信息";
        #region -  公共属性  ------------------------------------------------------------

        [DisplayName("品项")]
        public int PingXiangId { get; set; }
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
        
         
        
        /// <summary>
        /// 品项名
        /// </summary>
        private string _PingXiangName  = "";
        /// <summary>
        /// 品项名
        /// </summary>
        [DisplayName("品项名")]
        
        public string PingXiangName
        {
            set { _PingXiangName = value; }
            get { return _PingXiangName; }
        }
        
         
        
        /// <summary>
        /// 功效
        /// </summary>
        private string _GongXiao  = "";
        /// <summary>
        /// 功效
        /// </summary>
        [DisplayName("功效")]
        
        public string GongXiao
        {
            set { _GongXiao = value; }
            get { return _GongXiao; }
        }
        
         
        
        /// <summary>
        /// 食用开始时间
        /// </summary>
        private DateTime _EatStart;
        /// <summary>
        /// 食用开始时间
        /// </summary>
        [DisplayName("食用开始时间")]
        
        public DateTime EatStart
        {
            set { _EatStart = value; }
            get { return _EatStart; }
        }
        
        private DateTime _EatStartStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatStartStart
{
set { _EatStartStart = value; }
get{ return _EatStartStart; }
}
 private DateTime _EatStartEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatStartEnd
{
set { _EatStartEnd = value; }
get{ return _EatStartEnd; }
}
  
        
        /// <summary>
        /// 食用结束时间
        /// </summary>
        private DateTime _EatEnd ;
        /// <summary>
        /// 食用结束时间
        /// </summary>
        [DisplayName("食用结束时间")]
        
        public DateTime EatEnd
        {
            set { _EatEnd = value; }
            get { return _EatEnd; }
        }
        
        private DateTime _EatEndStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatEndStart
{
set { _EatEndStart = value; }
get{ return _EatEndStart; }
}
 private DateTime _EatEndEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatEndEnd
{
set { _EatEndEnd = value; }
get{ return _EatEndEnd; }
}
  
        
        /// <summary>
        /// 配料
        /// </summary>
        private string _PeiLiao  = "";
        /// <summary>
        /// 配料
        /// </summary>
        [DisplayName("配料")]
        
        public string PeiLiao
        {
            set { _PeiLiao = value; }
            get { return _PeiLiao; }
        }
        
         
        
        /// <summary>
        /// 食用说明
        /// </summary>
        private string _Desc  = "";
        /// <summary>
        /// 食用说明
        /// </summary>
        [DisplayName("食用说明")]
        
        public string Desc
        {
            set { _Desc = value; }
            get { return _Desc; }
        }
        
         
        
        /// <summary>
        /// 项目
        /// </summary>
        private int? _ProjectId ;
        /// <summary>
        /// 项目
        /// </summary>
        [DisplayName("项目")]
        
        public int? ProjectId
        {
            set { _ProjectId = value; }
            get { return _ProjectId; }
        }
        
         
        
        /// <summary>
        /// 项目名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 项目名
        /// </summary>
        [DisplayName("所属门店")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 有效状态
        /// </summary>
        private string _ValidState  = "";
        /// <summary>
        /// 有效状态
        /// </summary>
        [DisplayName("有效状态")]
        
        public string ValidState
        {
            set { _ValidState = value; }
            get { return _ValidState; }
        }
        
         
        
        /// <summary>
        /// 操作者
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作者
        /// </summary>
        [DisplayName("操作者")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作者名
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作者名
        /// </summary>
        [DisplayName("操作者名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _CreateDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]
        
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
        /// 
        /// </summary>
        private int? _RoomId ;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RoomId")]
        
        public int? RoomId
        {
            set { _RoomId = value; }
            get { return _RoomId; }
        }
        
         
        
        /// <summary>
        /// 房间号
        /// </summary>
        private string _RoomNumber  = "";
        /// <summary>
        /// 房间号
        /// </summary>
        [DisplayName("房间号")]
        
        public string RoomNumber
        {
            set { _RoomNumber = value; }
            get { return _RoomNumber; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class CustomerPingXiangReq:BaseSearchReq
    {
        [DisplayName("品相")]
        public int? PingXiangId { get; set; }
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 客户
        /// </summary> 
        public int? KhId { get;set; } 
	
          
        /// <summary>
        /// 客户名
        /// </summary> 
        public string KhName { get;set; } 
	
          
        /// <summary>
        /// 品项名
        /// </summary> 
        public string PingXiangName { get;set; } 
	
          
        /// <summary>
        /// 功效
        /// </summary> 
        public string GongXiao { get;set; } 
	
          
        /// <summary>
        /// 食用开始时间
        /// </summary> 
        public DateTime? EatStart { get;set; } 
	
          private DateTime _EatStartStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatStartStart
{
set { _EatStartStart = value; }
get{ return _EatStartStart; }
}
 private DateTime _EatStartEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatStartEnd
{
set { _EatStartEnd = value; }
get{ return _EatStartEnd; }
}
 
        /// <summary>
        /// 食用结束时间
        /// </summary> 
        public DateTime? EatEnd { get;set; } 
	
          private DateTime _EatEndStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatEndStart
{
set { _EatEndStart = value; }
get{ return _EatEndStart; }
}
 private DateTime _EatEndEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime EatEndEnd
{
set { _EatEndEnd = value; }
get{ return _EatEndEnd; }
}
 
        /// <summary>
        /// 配料
        /// </summary> 
        public string PeiLiao { get;set; } 
	
          
        /// <summary>
        /// 食用说明
        /// </summary> 
        public string Desc { get;set; } 
	
          
        /// <summary>
        /// 项目名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 有效状态
        /// </summary> 
        public string ValidState { get;set; } 
	
          
        /// <summary>
        /// 操作者
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作者名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建时间_createdate
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
        /// 
        /// </summary> 
        public int? RoomId { get;set; } 
	
          
        /// <summary>
        /// 房间号
        /// </summary> 
        public string RoomNumber { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

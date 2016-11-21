



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using DataAnnotationsExtensions;
using OUDAL.ModelBase;
namespace OUDAL
{
    ///################################################################################################
    /// <summary>
    /// <para>摘要：FloorInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：FloorInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>3</td><td>ProjectName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>项目名</td></tr>
    /// <tr valign="top"><td>4</td><td>FloorNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>楼层号</td></tr>
    /// <tr valign="top"><td>5</td><td>RoomCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>拥有房间数</td></tr>
    /// <tr valign="top"><td>6</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>7</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>8</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>9</td><td>FloorName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>楼名</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("FloorInfo")]
    [Serializable]
    public partial class FloorInfo 
    {
    
        public static string LogClass = "楼信息";
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
        /// 
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 所属项目 所属门店
        /// </summary>
        [DisplayName("所属门店")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 项目名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 项目名
        /// </summary>
        [DisplayName("项目名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 楼层号
        /// </summary>
        private string _FloorNumber  = "";
        /// <summary>
        /// 楼层号
        /// </summary>
        [DisplayName("所在楼层号")]
     

        public string FloorNumber
        {
            set { _FloorNumber = value; }
            get { return _FloorNumber; }
        }



        /// <summary>
        /// 拥有房间数
        /// </summary>
       
        private int _RoomCount ;
        /// <summary>
        /// 拥有房间数
        /// </summary>
        [DisplayName("每层房间数")]
        [Min(1, ErrorMessage = "每层房间数至少为1")]
       

        public int RoomCount
        {
            set { _RoomCount = value; }
            get { return _RoomCount; }
        }
        [DisplayName("总层数")]
        [Min(1, ErrorMessage = "总层数至少为1")]
        public int TotalLayer { get; set; }

        [DisplayName("物业类型")]
        public string WuYeClass { get; set; }

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
        /// 操作人
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("创建人")]
        
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
        /// 楼名
        /// </summary>
        private string _FloorName  = "";
        /// <summary>
        /// 楼名
        /// </summary>
        [DisplayName("楼名")]
        
        public string FloorName
        {
            set { _FloorName = value; }
            get { return _FloorName; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class FloorInfoReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        public int? TotalLayer { get; set; }

        [DisplayName("物业类型")]
        public string WuYeClass { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
 
	
          
        /// <summary>
        /// 项目名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 楼层号
        /// </summary> 
        public string FloorNumber { get;set; } 
	
          
        /// <summary>
        /// 拥有房间数
        /// </summary> 
        public int? RoomCount { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 操作人
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
        /// 楼名
        /// </summary> 
        public string FloorName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

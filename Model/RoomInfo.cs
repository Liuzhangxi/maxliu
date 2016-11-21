



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
    /// <para>摘要：RoomInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：RoomInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>3</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者</td></tr>
    /// <tr valign="top"><td>4</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>5</td><td>FangXing</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>房型</td></tr>
    /// <tr valign="top"><td>6</td><td>FangHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>房号</td></tr>
    /// <tr valign="top"><td>7</td><td>ChaoXiang</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>朝向</td></tr>
    /// <tr valign="top"><td>8</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>所属项目ID</td></tr>
    /// <tr valign="top"><td>9</td><td>ProjectName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>所属项目名</td></tr>
    /// <tr valign="top"><td>10</td><td>Owner</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>所属人(喜喜/酒店)</td></tr>
    /// <tr valign="top"><td>11</td><td>ChuangXing</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>床型</td></tr>
    /// <tr valign="top"><td>12</td><td>FloorId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>楼层ID</td></tr>
    /// <tr valign="top"><td>13</td><td>FloorName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>楼层名</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("RoomInfo")]
    [Serializable]
    public partial class RoomInfo 
    {
    
        public static string LogClass = "房间信息";
        #region -  公共属性  ------------------------------------------------------------
      
        /// 是否有重叠
        /// </summary>
        [NotMapped]
        public bool IsConflict { get; set; }

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
        /// 操作者
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作者
        /// </summary>
        [DisplayName("操作者")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _CreateDate  = SqlDateTime.MinValue.Value;
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
        /// 房型
        /// </summary>
        private string _FangXing  = "";
        /// <summary>
        /// 房型
        /// </summary>
        [DisplayName("房型")]
        
        public string FangXing
        {
            set { _FangXing = value; }
            get { return _FangXing; }
        }
        
         
        
        /// <summary>
        /// 房号
        /// </summary>
        private string _FangHao  = "";
        /// <summary>
        /// 房号
        /// </summary>
        [DisplayName("房号")]
        
        public string FangHao
        {
            set { _FangHao = value; }
            get { return _FangHao; }
        }
        
         
        
        /// <summary>
        /// 朝向
        /// </summary>
        private string _ChaoXiang  = "";
        /// <summary>
        /// 朝向
        /// </summary>
        [DisplayName("朝向")]
        
        public string ChaoXiang
        {
            set { _ChaoXiang = value; }
            get { return _ChaoXiang; }
        }



        /// <summary>
        /// 所属门店
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 所属门店
        /// </summary>
        [DisplayName("所属门店")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 所属项目名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 所属门店名
        /// </summary>
        [DisplayName("所属门店名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 所属人(喜喜/酒店)
        /// </summary>
        private string _Owner  = "";
        /// <summary>
        /// 所属人(喜喜/酒店)
        /// </summary>
        [DisplayName("所属人(喜喜/酒店)")]
        
        public string Owner
        {
            set { _Owner = value; }
            get { return _Owner; }
        }
        
         
        
        /// <summary>
        /// 床型
        /// </summary>
        private string _ChuangXing  = "";
        /// <summary>
        /// 床型
        /// </summary>
        [DisplayName("床型")]
        
        public string ChuangXing
        {
            set { _ChuangXing = value; }
            get { return _ChuangXing; }
        }
        
         
        
        /// <summary>
        /// 楼层ID
        /// </summary>
        private int? _FloorId ;
        /// <summary>
        /// 楼层ID
        /// </summary>
        [DisplayName("楼层ID")]
        
        public int? FloorId
        {
            set { _FloorId = value; }
            get { return _FloorId; }
        }
        
         
        
        /// <summary>
        /// 楼层名
        /// </summary>
        private string _FloorName  = "";
        /// <summary>
        /// 楼层名
        /// </summary>
        [DisplayName("楼层名")]
        
        public string FloorName
        {
            set { _FloorName = value; }
            get { return _FloorName; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class RoomInfoReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        //[DisplayName("有效日止")]
        //public DateTime? ValidToDate { get; set; }
        //[DisplayName("有效日起")]
        //public DateTime? ValidFromDate { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 操作者
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
        /// 房型
        /// </summary> 
        public string FangXing { get;set; } 
	
          
        /// <summary>
        /// 房号
        /// </summary> 
        public string FangHao { get;set; } 
	
          
        /// <summary>
        /// 朝向
        /// </summary> 
        public string ChaoXiang { get;set; }


        /// <summary>
        /// 所属门店名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 所属人(喜喜/酒店)
        /// </summary> 
        public string Owner { get;set; } 
	
          
        /// <summary>
        /// 床型
        /// </summary> 
        public string ChuangXing { get;set; } 
	
          
        /// <summary>
        /// 楼层ID
        /// </summary> 
        public int? FloorId { get;set; } 
	
          
        /// <summary>
        /// 楼层名
        /// </summary> 
        public string FloorName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

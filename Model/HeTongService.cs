



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
    /// <para>摘要：HeTongServiceModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HeTongService
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>服务名</td></tr>
    /// <tr valign="top"><td>3</td><td>ServerCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>服务次数</td></tr>
    /// <tr valign="top"><td>4</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>5</td><td>CreateName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>创建者名_optname</td></tr>
    /// <tr valign="top"><td>6</td><td>CreateId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>创建者_optid</td></tr>
    /// <tr valign="top"><td>7</td><td>UpdateUserName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>更新用户名</td></tr>
    /// <tr valign="top"><td>8</td><td>UpdateUserId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>更新用户</td></tr>
    /// <tr valign="top"><td>9</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态_listhidden</td></tr>
    /// <tr valign="top"><td>10</td><td>UpdateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>更新时间_listhidden_updatehidden_updatedate</td></tr>
    /// <tr valign="top"><td>11</td><td>HeTongId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>合同</td></tr>
    /// <tr valign="top"><td>12</td><td>HeTongNumber</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>合同编号</td></tr>
    /// <tr valign="top"><td>13</td><td>Mark</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HeTongService")]
    [Serializable]
    public partial class HeTongService 
    {
    
        public static string LogClass = "合同服务明细";
        #region -  公共属性  ------------------------------------------------------------
        public int? ServerModelId { get; set; }
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
        /// 服务名
        /// </summary>
        private string _Name  = "";
        /// <summary>
        /// 服务名
        /// </summary>
        [DisplayName("服务名")]
        
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        
         
        
        /// <summary>
        /// 服务次数
        /// </summary>
        private int? _ServerCount ;
        /// <summary>
        /// 服务次数
        /// </summary>
        [DisplayName("服务次数")]
        
        public int? ServerCount
        {
            set { _ServerCount = value; }
            get { return _ServerCount; }
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
        /// 创建者名_optname
        /// </summary>
        private string _CreateName  = "";
        /// <summary>
        /// 创建者名_optname
        /// </summary>
        [DisplayName("创建者名")]
        
        public string CreateName
        {
            set { _CreateName = value; }
            get { return _CreateName; }
        }
        
         
        
        /// <summary>
        /// 创建者_optid
        /// </summary>
        private int? _CreateId ;
        /// <summary>
        /// 创建者_optid
        /// </summary>
        [DisplayName("创建者")]
        
        public int? CreateId
        {
            set { _CreateId = value; }
            get { return _CreateId; }
        }
        
         
        
        /// <summary>
        /// 更新用户名
        /// </summary>
        private string _UpdateUserName  = "";
        /// <summary>
        /// 更新用户名
        /// </summary>
        [DisplayName("更新用户名")]
        
        public string UpdateUserName
        {
            set { _UpdateUserName = value; }
            get { return _UpdateUserName; }
        }
        
         
        
        /// <summary>
        /// 更新用户
        /// </summary>
        private int? _UpdateUserId ;
        /// <summary>
        /// 更新用户
        /// </summary>
        [DisplayName("更新用户")]
        
        public int? UpdateUserId
        {
            set { _UpdateUserId = value; }
            get { return _UpdateUserId; }
        }
        
         
        
        /// <summary>
        /// 状态_listhidden
        /// </summary>
        private string _State  = "";
        /// <summary>
        /// 状态_listhidden
        /// </summary>
        [DisplayName("状态")]
        
        public string State
        {
            set { _State = value; }
            get { return _State; }
        }
        
         
        
        /// <summary>
        /// 更新时间_listhidden_updatehidden_updatedate
        /// </summary>
        private DateTime? _UpdateDate ;
        /// <summary>
        /// 更新时间_listhidden_updatehidden_updatedate
        /// </summary>
        [DisplayName("更新时间")]
        
        public DateTime? UpdateDate
        {
            set { _UpdateDate = value; }
            get { return _UpdateDate; }
        }
        
        private DateTime _UpdateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateStart
{
set { _UpdateDateStart = value; }
get{ return _UpdateDateStart; }
}
 private DateTime _UpdateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateEnd
{
set { _UpdateDateEnd = value; }
get{ return _UpdateDateEnd; }
}
  
        
        /// <summary>
        /// 合同
        /// </summary>
        private int? _HeTongId ;
        /// <summary>
        /// 合同
        /// </summary>
        [DisplayName("合同")]
        
        public int? HeTongId
        {
            set { _HeTongId = value; }
            get { return _HeTongId; }
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
        /// 备注
        /// </summary>
        private string _Mark  = "";
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        
        public string Mark
        {
            set { _Mark = value; }
            get { return _Mark; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class HeTongServiceReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 服务名
        /// </summary> 
        public string Name { get;set; } 
	
          
        /// <summary>
        /// 服务次数
        /// </summary> 
        public int? ServerCount { get;set; } 
	
          
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
        /// 创建者名_optname
        /// </summary> 
        public string CreateName { get;set; } 
	
          
        /// <summary>
        /// 创建者_optid
        /// </summary> 
        public int? CreateId { get;set; } 
	
          
        /// <summary>
        /// 更新用户名
        /// </summary> 
        public string UpdateUserName { get;set; } 
	
          
        /// <summary>
        /// 更新用户
        /// </summary> 
        public int? UpdateUserId { get;set; } 
	
          
        /// <summary>
        /// 状态_listhidden
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 更新时间_listhidden_updatehidden_updatedate
        /// </summary> 
        public DateTime? UpdateDate { get;set; } 
	
          private DateTime _UpdateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateStart
{
set { _UpdateDateStart = value; }
get{ return _UpdateDateStart; }
}
 private DateTime _UpdateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateEnd
{
set { _UpdateDateEnd = value; }
get{ return _UpdateDateEnd; }
}
 
        /// <summary>
        /// 合同
        /// </summary> 
        public int? HeTongId { get;set; } 
	
          
        /// <summary>
        /// 合同编号
        /// </summary> 
        public string HeTongNumber { get;set; } 
	
          
        /// <summary>
        /// 备注
        /// </summary> 
        public string Mark { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

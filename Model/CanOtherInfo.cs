



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
    /// <para>摘要：CanOtherInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：CanOtherInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>服务日期</td></tr>
    /// <tr valign="top"><td>3</td><td>JiaWuCanCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>家属午餐数量</td></tr>
    /// <tr valign="top"><td>4</td><td>JiaWanCanCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>家属晚餐数量</td></tr>
    /// <tr valign="top"><td>5</td><td>YuanWuCanCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>员工午餐数量</td></tr>
    /// <tr valign="top"><td>6</td><td>YuanWanCanCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>员工晚餐数量</td></tr>
    /// <tr valign="top"><td>7</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>8</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>9</td><td>Createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>10</td><td>optid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者_optid</td></tr>
    /// <tr valign="top"><td>11</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名_optname</td></tr>
    /// <tr valign="top"><td>12</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态_validstate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("CanOtherInfo")]
    [Serializable]
    public partial class CanOtherInfo 
    {
    
        public static string LogClass = "工作餐信息";
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
        /// 家属午餐数量
        /// </summary>
        private int? _JiaWuCanCount ;
        /// <summary>
        /// 家属午餐数量
        /// </summary>
        [DisplayName("家属午餐数量")]
        
        public int? JiaWuCanCount
        {
            set { _JiaWuCanCount = value; }
            get { return _JiaWuCanCount; }
        }
        
         
        
        /// <summary>
        /// 家属晚餐数量
        /// </summary>
        private int? _JiaWanCanCount ;
        /// <summary>
        /// 家属晚餐数量
        /// </summary>
        [DisplayName("家属晚餐数量")]
        
        public int? JiaWanCanCount
        {
            set { _JiaWanCanCount = value; }
            get { return _JiaWanCanCount; }
        }
        
         
        
        /// <summary>
        /// 员工午餐数量
        /// </summary>
        private int? _YuanWuCanCount ;
        /// <summary>
        /// 员工午餐数量
        /// </summary>
        [DisplayName("员工午餐数量")]
        
        public int? YuanWuCanCount
        {
            set { _YuanWuCanCount = value; }
            get { return _YuanWuCanCount; }
        }
        
         
        
        /// <summary>
        /// 员工晚餐数量
        /// </summary>
        private int? _YuanWanCanCount ;
        /// <summary>
        /// 员工晚餐数量
        /// </summary>
        [DisplayName("员工晚餐数量")]
        
        public int? YuanWanCanCount
        {
            set { _YuanWanCanCount = value; }
            get { return _YuanWanCanCount; }
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
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _Createdate ;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
        public DateTime? Createdate
        {
            set { _Createdate = value; }
            get { return _Createdate; }
        }
        
        private DateTime _CreatedateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateStart
{
set { _CreatedateStart = value; }
get{ return _CreatedateStart; }
}
 private DateTime _CreatedateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateEnd
{
set { _CreatedateEnd = value; }
get{ return _CreatedateEnd; }
}
  
        
        /// <summary>
        /// 操作者_optid
        /// </summary>
        private int? _optid ;
        /// <summary>
        /// 操作者_optid
        /// </summary>
        [DisplayName("操作者")]
        
        public int? optid
        {
            set { _optid = value; }
            get { return _optid; }
        }
        
         
        
        /// <summary>
        /// 操作者名_optname
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作者名_optname
        /// </summary>
        [DisplayName("操作者名")]
        
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        private string _State  = "";
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        [DisplayName("有效状态")]
        
        public string State
        {
            set { _State = value; }
            get { return _State; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class CanOtherInfoReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
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
        /// 家属午餐数量
        /// </summary> 
        public int? JiaWuCanCount { get;set; } 
	
          
        /// <summary>
        /// 家属晚餐数量
        /// </summary> 
        public int? JiaWanCanCount { get;set; } 
	
          
        /// <summary>
        /// 员工午餐数量
        /// </summary> 
        public int? YuanWuCanCount { get;set; } 
	
          
        /// <summary>
        /// 员工晚餐数量
        /// </summary> 
        public int? YuanWanCanCount { get;set; } 
	
          
        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
        /// </summary> 
        public DateTime? Createdate { get;set; } 
	
          private DateTime _CreatedateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateStart
{
set { _CreatedateStart = value; }
get{ return _CreatedateStart; }
}
 private DateTime _CreatedateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateEnd
{
set { _CreatedateEnd = value; }
get{ return _CreatedateEnd; }
}
 
        /// <summary>
        /// 操作者_optid
        /// </summary> 
        public int? optid { get;set; } 
	
          
        /// <summary>
        /// 操作者名_optname
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 有效状态_validstate
        /// </summary> 
        public string State { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

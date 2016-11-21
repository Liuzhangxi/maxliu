



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
    /// <para>摘要：guDingZiChanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：guDingZiChan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>companyName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>公司名</td></tr>
    /// <tr valign="top"><td>3</td><td>ziChanTitle</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>标题</td></tr>
    /// <tr valign="top"><td>4</td><td>pandianDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>盘点时间</td></tr>
    /// <tr valign="top"><td>5</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>6</td><td>optId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>7</td><td>createDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>8</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>所属门店_projectid</td></tr>
    /// <tr valign="top"><td>9</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>所属门店名_projectname</td></tr>
    /// <tr valign="top"><td>10</td><td>state</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("guDingZiChan")]
    [Serializable]
    public partial class guDingZiChan 
    {
    
        public static string LogClass = "固定资产";
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
        /// 公司名
        /// </summary>
        private string _companyName  = "";
        /// <summary>
        /// 公司名
        /// </summary>
        [DisplayName("公司名")]
        
        public string companyName
        {
            set { _companyName = value; }
            get { return _companyName; }
        }
        
         
        
        /// <summary>
        /// 标题
        /// </summary>
        private string _ziChanTitle  = "";
        /// <summary>
        /// 标题
        /// </summary>
        [DisplayName("标题")]
        
        public string ziChanTitle
        {
            set { _ziChanTitle = value; }
            get { return _ziChanTitle; }
        }
        
         
        
        /// <summary>
        /// 盘点时间
        /// </summary>
        private DateTime? _pandianDateTime ;
        /// <summary>
        /// 盘点时间
        /// </summary>
        [DisplayName("盘点时间")]
        
        public DateTime? pandianDateTime
        {
            set { _pandianDateTime = value; }
            get { return _pandianDateTime; }
        }
        
        private DateTime _pandianDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime pandianDateTimeStart
{
set { _pandianDateTimeStart = value; }
get{ return _pandianDateTimeStart; }
}
 private DateTime _pandianDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime pandianDateTimeEnd
{
set { _pandianDateTimeEnd = value; }
get{ return _pandianDateTimeEnd; }
}
  
        
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        [DisplayName("操作人名")]
        
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 操作人_optid
        /// </summary>
        private int? _optId ;
        /// <summary>
        /// 操作人_optid
        /// </summary>
        [DisplayName("操作人")]
        
        public int? optId
        {
            set { _optId = value; }
            get { return _optId; }
        }
        
         
        
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _createDate ;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]
        
        public DateTime? createDate
        {
            set { _createDate = value; }
            get { return _createDate; }
        }
        
        private DateTime _createDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateStart
{
set { _createDateStart = value; }
get{ return _createDateStart; }
}
 private DateTime _createDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateEnd
{
set { _createDateEnd = value; }
get{ return _createDateEnd; }
}
  
        
        /// <summary>
        /// 所属门店_projectid
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 所属门店_projectid
        /// </summary>
        [DisplayName("所属门店")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 所属门店名_projectname
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 所属门店名_projectname
        /// </summary>
        [DisplayName("所属门店名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 状态
        /// </summary>
        private string _state  = "";
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态")]
        
        public string state
        {
            set { _state = value; }
            get { return _state; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class guDingZiChanReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 公司名
        /// </summary> 
        public string companyName { get;set; } 
	
          
        /// <summary>
        /// 标题
        /// </summary> 
        public string ziChanTitle { get;set; } 
	
          
        /// <summary>
        /// 盘点时间
        /// </summary> 
        public DateTime? pandianDateTime { get;set; } 
	
          private DateTime _pandianDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime pandianDateTimeStart
{
set { _pandianDateTimeStart = value; }
get{ return _pandianDateTimeStart; }
}
 private DateTime _pandianDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime pandianDateTimeEnd
{
set { _pandianDateTimeEnd = value; }
get{ return _pandianDateTimeEnd; }
}
 
        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? optId { get;set; } 
	
          
        /// <summary>
        /// 创建时间_createdate
        /// </summary> 
        public DateTime? createDate { get;set; } 
	
          private DateTime _createDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateStart
{
set { _createDateStart = value; }
get{ return _createDateStart; }
}
 private DateTime _createDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateEnd
{
set { _createDateEnd = value; }
get{ return _createDateEnd; }
}
 
        /// <summary>
        /// 所属门店名_projectname
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string state { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

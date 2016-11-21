



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
    /// <para>摘要：CaiJinInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：CaiJinInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>3</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>4</td><td>caijinMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>彩金</td></tr>
    /// <tr valign="top"><td>5</td><td>optId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>6</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optname</td></tr>
    /// <tr valign="top"><td>7</td><td>createDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>8</td><td>checkId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>审核员</td></tr>
    /// <tr valign="top"><td>9</td><td>checkName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审核人名</td></tr>
    /// <tr valign="top"><td>10</td><td>checkDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>审核日期</td></tr>
    /// <tr valign="top"><td>11</td><td>serverDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>日期</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("CaiJinInfo")]
    [Serializable]
    public partial class CaiJinInfo 
    {
    
        public static string LogClass = "菜金信息";
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
        /// 菜金
        /// </summary>
        private decimal? _caijinMoney ;
        /// <summary>
        /// 菜金
        /// </summary>
        [DisplayName("菜金")]
        
        public decimal? caijinMoney
        {
            set { _caijinMoney = value; }
            get { return _caijinMoney; }
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
        /// 操作人_optname
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作人_optname
        /// </summary>
        [DisplayName("操作人")]
        
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _createDate ;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
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
        /// 审核员
        /// </summary>
        private int? _checkId ;
        /// <summary>
        /// 审核员
        /// </summary>
        [DisplayName("审核员")]
        
        public int? checkId
        {
            set { _checkId = value; }
            get { return _checkId; }
        }
        
         
        
        /// <summary>
        /// 审核人名
        /// </summary>
        private string _checkName  = "";
        /// <summary>
        /// 审核人名
        /// </summary>
        [DisplayName("审核人名")]
        
        public string checkName
        {
            set { _checkName = value; }
            get { return _checkName; }
        }
        
         
        
        /// <summary>
        /// 审核日期
        /// </summary>
        private DateTime? _checkDate ;
        /// <summary>
        /// 审核日期
        /// </summary>
        [DisplayName("审核日期")]
        
        public DateTime? checkDate
        {
            set { _checkDate = value; }
            get { return _checkDate; }
        }
        
        private DateTime _checkDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime checkDateStart
{
set { _checkDateStart = value; }
get{ return _checkDateStart; }
}
 private DateTime _checkDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime checkDateEnd
{
set { _checkDateEnd = value; }
get{ return _checkDateEnd; }
}
  
        
        /// <summary>
        /// 日期
        /// </summary>
        private DateTime? _serverDate ;
        /// <summary>
        /// 日期
        /// </summary>
        [DisplayName("服务日期")]
        
        public DateTime? serverDate
        {
            set { _serverDate = value; }
            get { return _serverDate; }
        }
        
        private DateTime _serverDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime serverDateStart
{
set { _serverDateStart = value; }
get{ return _serverDateStart; }
}
 private DateTime _serverDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime serverDateEnd
{
set { _serverDateEnd = value; }
get{ return _serverDateEnd; }
}
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class CaiJinInfoReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 彩金
        /// </summary> 
        public decimal? caijinMoney { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? optId { get;set; } 
	
          
        /// <summary>
        /// 操作人_optname
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
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
        /// 审核员
        /// </summary> 
        public int? checkId { get;set; } 
	
          
        /// <summary>
        /// 审核人名
        /// </summary> 
        public string checkName { get;set; } 
	
          
        /// <summary>
        /// 审核日期
        /// </summary> 
        public DateTime? checkDate { get;set; } 
	
          private DateTime _checkDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime checkDateStart
{
set { _checkDateStart = value; }
get{ return _checkDateStart; }
}
 private DateTime _checkDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime checkDateEnd
{
set { _checkDateEnd = value; }
get{ return _checkDateEnd; }
}
 
        /// <summary>
        /// 日期
        /// </summary> 
        public DateTime? serverDate { get;set; } 
	
          private DateTime _serverDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime serverDateStart
{
set { _serverDateStart = value; }
get{ return _serverDateStart; }
}
 private DateTime _serverDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime serverDateEnd
{
set { _serverDateEnd = value; }
get{ return _serverDateEnd; }
}
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

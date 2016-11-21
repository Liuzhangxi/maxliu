



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
    /// <para>摘要：JMSShouKuanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JMSShouKuan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>JmsShouKuanRuleId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商收款规则_listhidden_createhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>ShouKuanType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>收款类型</td></tr>
    /// <tr valign="top"><td>4</td><td>ShouKuanMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>收款金额</td></tr>
    /// <tr valign="top"><td>5</td><td>ShouKuanTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>收款时间</td></tr>
    /// <tr valign="top"><td>6</td><td>ShouKuanState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>收款状态</td></tr>
    /// <tr valign="top"><td>7</td><td>ShouKuanConfirmerId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>收款确认人</td></tr>
    /// <tr valign="top"><td>8</td><td>ShouKuanConfirmerName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>收款确认人名</td></tr>
    /// <tr valign="top"><td>9</td><td>ShouKuanConfirmDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>收款确认时间</td></tr>
    /// <tr valign="top"><td>10</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>11</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名</td></tr>
    /// <tr valign="top"><td>12</td><td>Createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>操作时间_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("JMSShouKuan")]
    [Serializable]
    public partial class JMSShouKuan 
    {
    
        public static string LogClass = "实际收款信息";
        #region -  公共属性  ------------------------------------------------------------
        [NotMapped]
        public string JmsName { get; set; }
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
        /// 加盟商收款规则_listhidden_createhidden
        /// </summary>
        private int? _JmsShouKuanRuleId ;
        /// <summary>
        /// 加盟商收款规则_listhidden_createhidden
        /// </summary>
        [DisplayName("加盟商收款规则")]
        
        public int? JmsShouKuanRuleId
        {
            set { _JmsShouKuanRuleId = value; }
            get { return _JmsShouKuanRuleId; }
        }
        
         
        
        /// <summary>
        /// 收款类型
        /// </summary>
        private string _ShouKuanType  = "";
        /// <summary>
        /// 收款类型
        /// </summary>
        [DisplayName("收款类型")]
        
        public string ShouKuanType
        {
            set { _ShouKuanType = value; }
            get { return _ShouKuanType; }
        }
        
         
        
        /// <summary>
        /// 收款金额
        /// </summary>
        private decimal? _ShouKuanMoney ;
        /// <summary>
        /// 收款金额
        /// </summary>
        [DisplayName("收款金额")]
        [DataAnnotationsExtensions.Numeric(ErrorMessage = "请输入正确金额")]
        public decimal? ShouKuanMoney
        {
            set { _ShouKuanMoney = value; }
            get { return _ShouKuanMoney; }
        }
        
         
        
        /// <summary>
        /// 收款时间
        /// </summary>
        private DateTime? _ShouKuanTime;
        /// <summary>
        /// 收款时间
        /// </summary>
        [DisplayName("收款时间")]
        
        public DateTime? ShouKuanTime
        {
            set { _ShouKuanTime = value; }
            get { return _ShouKuanTime; }
        }
        
        private DateTime _ShouKuanTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanTimeStart
{
set { _ShouKuanTimeStart = value; }
get{ return _ShouKuanTimeStart; }
}
 private DateTime _ShouKuanTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanTimeEnd
{
set { _ShouKuanTimeEnd = value; }
get{ return _ShouKuanTimeEnd; }
}
  
        
        /// <summary>
        /// 收款状态
        /// </summary>
        private string _ShouKuanState  = "";
        /// <summary>
        /// 收款状态
        /// </summary>
        [DisplayName("收款状态")]
        
        public string ShouKuanState
        {
            set { _ShouKuanState = value; }
            get { return _ShouKuanState; }
        }
        
         
        
        /// <summary>
        /// 收款确认人
        /// </summary>
        private int? _ShouKuanConfirmerId ;
        /// <summary>
        /// 收款确认人
        /// </summary>
        [DisplayName("收款确认人")]
        
        public int? ShouKuanConfirmerId
        {
            set { _ShouKuanConfirmerId = value; }
            get { return _ShouKuanConfirmerId; }
        }
        
         
        
        /// <summary>
        /// 收款确认人名
        /// </summary>
        private string _ShouKuanConfirmerName  = "";
        /// <summary>
        /// 收款确认人名
        /// </summary>
        [DisplayName("收款确认人名")]
        
        public string ShouKuanConfirmerName
        {
            set { _ShouKuanConfirmerName = value; }
            get { return _ShouKuanConfirmerName; }
        }
        
         
        
        /// <summary>
        /// 收款确认时间
        /// </summary>
        private DateTime? _ShouKuanConfirmDate;
        /// <summary>
        /// 收款确认时间
        /// </summary>
        [DisplayName("收款确认时间")]
        
        public DateTime? ShouKuanConfirmDate
        {
            set { _ShouKuanConfirmDate = value; }
            get { return _ShouKuanConfirmDate; }
        }
        
        private DateTime _ShouKuanConfirmDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanConfirmDateStart
{
set { _ShouKuanConfirmDateStart = value; }
get{ return _ShouKuanConfirmDateStart; }
}
 private DateTime _ShouKuanConfirmDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanConfirmDateEnd
{
set { _ShouKuanConfirmDateEnd = value; }
get{ return _ShouKuanConfirmDateEnd; }
}
  
        
        /// <summary>
        /// 操作人
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作人名
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人名
        /// </summary>
        [DisplayName("操作人名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        private DateTime? _Createdate ;
        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        [DisplayName("操作时间")]
        
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
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JMSShouKuanReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        public string JmsIds { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 加盟商收款规则_listhidden_createhidden
        /// </summary> 
        public int? JmsShouKuanRuleId { get;set; } 
	
          
        /// <summary>
        /// 收款类型
        /// </summary> 
        public string ShouKuanType { get;set; } 
	
          
        /// <summary>
        /// 收款金额
        /// </summary> 
        public decimal? ShouKuanMoney { get;set; } 
	
          
        /// <summary>
        /// 收款时间
        /// </summary> 
        public DateTime? ShouKuanTime { get;set; } 
	
          private DateTime _ShouKuanTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanTimeStart
{
set { _ShouKuanTimeStart = value; }
get{ return _ShouKuanTimeStart; }
}
 private DateTime _ShouKuanTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanTimeEnd
{
set { _ShouKuanTimeEnd = value; }
get{ return _ShouKuanTimeEnd; }
}
 
        /// <summary>
        /// 收款状态
        /// </summary> 
        public string ShouKuanState { get;set; } 
	
          
        /// <summary>
        /// 收款确认人
        /// </summary> 
        public int? ShouKuanConfirmerId { get;set; } 
	
          
        /// <summary>
        /// 收款确认人名
        /// </summary> 
        public string ShouKuanConfirmerName { get;set; } 
	
          
        /// <summary>
        /// 收款确认时间
        /// </summary> 
        public DateTime? ShouKuanConfirmDate { get;set; } 
	
          private DateTime _ShouKuanConfirmDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanConfirmDateStart
{
set { _ShouKuanConfirmDateStart = value; }
get{ return _ShouKuanConfirmDateStart; }
}
 private DateTime _ShouKuanConfirmDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ShouKuanConfirmDateEnd
{
set { _ShouKuanConfirmDateEnd = value; }
get{ return _ShouKuanConfirmDateEnd; }
}
 
        /// <summary>
        /// 操作人
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 操作时间_createdate
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
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

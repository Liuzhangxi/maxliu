



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
    /// <para>摘要：JMSShouKuanRuleModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JMSShouKuanRule
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>JmsId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商</td></tr>
    /// <tr valign="top"><td>3</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商名</td></tr>
    /// <tr valign="top"><td>4</td><td>JmsClassName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟类型</td></tr>
    /// <tr valign="top"><td>5</td><td>ShouKuanType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>收款类型</td></tr>
    /// <tr valign="top"><td>6</td><td>ShouKuanMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>收款金额</td></tr>
    /// <tr valign="top"><td>7</td><td>StartTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>启动时间</td></tr>
    /// <tr valign="top"><td>8</td><td>ShouKuanTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>收款时间</td></tr>
    /// <tr valign="top"><td>9</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>10</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>11</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名</td></tr>
    /// <tr valign="top"><td>12</td><td>Createtime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>操作时间_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JMSShouKuanRule")]
    [Serializable]
    public partial class JMSShouKuanRule 
    {
    
        public static string LogClass = "加盟商收款规则";
        #region -  公共属性  ------------------------------------------------------------
        public int? projectid { get; set; }
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
        /// 加盟商
        /// </summary>
        private int? _JmsId ;
        /// <summary>
        /// 加盟商
        /// </summary>
        [DisplayName("加盟商")]
        
        public int? JmsId
        {
            set { _JmsId = value; }
            get { return _JmsId; }
        }
        
         
        
        /// <summary>
        /// 加盟商名
        /// </summary>
        private string _JmsName  = "";
        /// <summary>
        /// 加盟商名
        /// </summary>
        [DisplayName("加盟商名")]
        
        public string JmsName
        {
            set { _JmsName = value; }
            get { return _JmsName; }
        }
        
         
        
        /// <summary>
        /// 加盟类型
        /// </summary>
        private string _JmsClassName  = "";
        /// <summary>
        /// 加盟类型
        /// </summary>
        [DisplayName("加盟类型")]
        
        public string JmsClassName
        {
            set { _JmsClassName = value; }
            get { return _JmsClassName; }
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
        
        public decimal? ShouKuanMoney
        {
            set { _ShouKuanMoney = value; }
            get { return _ShouKuanMoney; }
        }
        
         
        
        /// <summary>
        /// 启动时间
        /// </summary>
        private DateTime? _StartTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 启动时间
        /// </summary>
        [DisplayName("启动时间")]
        
        public DateTime? StartTime
        {
            set { _StartTime = value; }
            get { return _StartTime; }
        }
        
        private DateTime _StartTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartTimeStart
{
set { _StartTimeStart = value; }
get{ return _StartTimeStart; }
}
 private DateTime _StartTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartTimeEnd
{
set { _StartTimeEnd = value; }
get{ return _StartTimeEnd; }
}
  
        
        /// <summary>
        /// 收款时间
        /// </summary>
        private DateTime? _ShouKuanTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 收款提醒时间
        /// </summary>
        [DisplayName("收款提醒时间")]
        
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
        private DateTime? _Createtime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        [DisplayName("操作时间")]
        
        public DateTime? Createtime
        {
            set { _Createtime = value; }
            get { return _Createtime; }
        }
        
        private DateTime _CreatetimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatetimeStart
{
set { _CreatetimeStart = value; }
get{ return _CreatetimeStart; }
}
 private DateTime _CreatetimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatetimeEnd
{
set { _CreatetimeEnd = value; }
get{ return _CreatetimeEnd; }
}
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JMSShouKuanRuleReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 加盟商
        /// </summary> 
        public int? JmsId { get;set; } 
	
          
        /// <summary>
        /// 加盟商名
        /// </summary> 
        public string JmsName { get;set; } 
	
          
        /// <summary>
        /// 加盟类型
        /// </summary> 
        public string JmsClassName { get;set; } 
	
          
        /// <summary>
        /// 收款类型
        /// </summary> 
        public string ShouKuanType { get;set; } 
	
          
        /// <summary>
        /// 收款金额
        /// </summary> 
        public decimal? ShouKuanMoney { get;set; } 
	
          
        /// <summary>
        /// 启动时间
        /// </summary> 
        public DateTime? StartTime { get;set; } 
	
          private DateTime _StartTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartTimeStart
{
set { _StartTimeStart = value; }
get{ return _StartTimeStart; }
}
 private DateTime _StartTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime StartTimeEnd
{
set { _StartTimeEnd = value; }
get{ return _StartTimeEnd; }
}
 
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
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
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
        public DateTime? Createtime { get;set; } 
	
          private DateTime _CreatetimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatetimeStart
{
set { _CreatetimeStart = value; }
get{ return _CreatetimeStart; }
}
 private DateTime _CreatetimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatetimeEnd
{
set { _CreatetimeEnd = value; }
get{ return _CreatetimeEnd; }
}
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

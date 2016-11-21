



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
    /// <para>摘要：SmsLogModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：SmsLog
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Type</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>发送类型</td></tr>
    /// <tr valign="top"><td>3</td><td>RefId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>相关表主键</td></tr>
    /// <tr valign="top"><td>4</td><td>SendDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>发送时间</td></tr>
    /// <tr valign="top"><td>5</td><td>Result</td><td>nvarchar</td><td>450</td><td></td><td></td><td></td><td>√</td><td></td><td>结果</td></tr>
    /// <tr valign="top"><td>6</td><td>SmsMsg</td><td>nvarchar</td><td>450</td><td></td><td></td><td></td><td>√</td><td></td><td>发送短信信息</td></tr>
    /// <tr valign="top"><td>7</td><td>RetCode</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>短信接口返回int值</td></tr>
    /// <tr valign="top"><td>8</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>9</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>10</td><td>ToPhones</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>发至手机号</td></tr>
    /// <tr valign="top"><td>11</td><td>RefTitle</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("SmsLog")]
    [Serializable]
    public partial class SmsLog 
    {
    
        public static string LogClass = "短信发送日志";
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
        /// 发送类型
        /// </summary>
        private string _Type  = "";
        /// <summary>
        /// 发送类型
        /// </summary>
        [DisplayName("发送类型")]
        
        public string Type
        {
            set { _Type = value; }
            get { return _Type; }
        }
        
         
        
        /// <summary>
        /// 相关表主键
        /// </summary>
        private int? _RefId ;
        /// <summary>
        /// 相关表主键
        /// </summary>
        [DisplayName("相关表主键")]
        
        public int? RefId
        {
            set { _RefId = value; }
            get { return _RefId; }
        }
        
         
        
        /// <summary>
        /// 发送时间
        /// </summary>
        private DateTime? _SendDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 发送时间
        /// </summary>
        [DisplayName("发送时间")]
        
        public DateTime? SendDate
        {
            set { _SendDate = value; }
            get { return _SendDate; }
        }
        
        private DateTime _SendDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SendDateStart
{
set { _SendDateStart = value; }
get{ return _SendDateStart; }
}
 private DateTime _SendDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SendDateEnd
{
set { _SendDateEnd = value; }
get{ return _SendDateEnd; }
}
  
        
        /// <summary>
        /// 结果
        /// </summary>
        private string _Result  = "";
        /// <summary>
        /// 结果
        /// </summary>
        [DisplayName("结果")]
        
        public string Result
        {
            set { _Result = value; }
            get { return _Result; }
        }
        
         
        
        /// <summary>
        /// 发送短信信息
        /// </summary>
        private string _SmsMsg  = "";
        /// <summary>
        /// 发送短信信息
        /// </summary>
        [DisplayName("发送短信信息")]
        
        public string SmsMsg
        {
            set { _SmsMsg = value; }
            get { return _SmsMsg; }
        }
        
         
        
        /// <summary>
        /// 短信接口返回int值
        /// </summary>
        private string _RetCode  = "";
        /// <summary>
        /// 短信接口返回int值
        /// </summary>
        [DisplayName("短信接口返回int值")]
        
        public string RetCode
        {
            set { _RetCode = value; }
            get { return _RetCode; }
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
        /// 
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("projectid")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 发至手机号
        /// </summary>
        private string _ToPhones  = "";
        /// <summary>
        /// 发至手机号
        /// </summary>
        [DisplayName("发至手机号")]
        
        public string ToPhones
        {
            set { _ToPhones = value; }
            get { return _ToPhones; }
        }
        
         
        
        /// <summary>
        /// 
        /// </summary>
        private string _RefTitle  = "";
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RefTitle")]
        
        public string RefTitle
        {
            set { _RefTitle = value; }
            get { return _RefTitle; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class SmsLogReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 发送类型
        /// </summary> 
        public string Type { get;set; } 
	
          
        /// <summary>
        /// 相关表主键
        /// </summary> 
        public int? RefId { get;set; } 
	
          
        /// <summary>
        /// 发送时间
        /// </summary> 
        public DateTime? SendDate { get;set; } 
	
          private DateTime _SendDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SendDateStart
{
set { _SendDateStart = value; }
get{ return _SendDateStart; }
}
 private DateTime _SendDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime SendDateEnd
{
set { _SendDateEnd = value; }
get{ return _SendDateEnd; }
}
 
        /// <summary>
        /// 结果
        /// </summary> 
        public string Result { get;set; } 
	
          
        /// <summary>
        /// 发送短信信息
        /// </summary> 
        public string SmsMsg { get;set; } 
	
          
        /// <summary>
        /// 短信接口返回int值
        /// </summary> 
        public string RetCode { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 发至手机号
        /// </summary> 
        public string ToPhones { get;set; } 
	
          
        /// <summary>
        /// 
        /// </summary> 
        public string RefTitle { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

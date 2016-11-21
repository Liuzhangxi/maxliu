



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
    /// <para>摘要：JMSLXRModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JMSLXR
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JmsID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>加盟商ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟商名称</td></tr>
    /// <tr valign="top"><td>4</td><td>LxrName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>联系人名字</td></tr>
    /// <tr valign="top"><td>5</td><td>LxrSex</td><td>nvarchar</td><td>10</td><td></td><td></td><td></td><td>√</td><td></td><td>联系人性别_searchhidden</td></tr>
    /// <tr valign="top"><td>6</td><td>LxrPhone</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>联系人电话</td></tr>
    /// <tr valign="top"><td>7</td><td>LxrWeiXin</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>联系人微信号_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>8</td><td>LxrQQ</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>联系人QQ_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>9</td><td>LxrMail</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>联系人Mail_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>10</td><td>LxrZhiWu</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>联系人职务_searchhidden</td></tr>
    /// <tr valign="top"><td>11</td><td>LxrStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>联系人状态 </td></tr>
    /// <tr valign="top"><td>12</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>13</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_listhidden_searchhidden_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("JMSLXR")]
    [Serializable]
    public partial class JMSLXR 
    {
    
        public static string LogClass = "加盟商联系人表";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("来源")]
        public string FromType { get; set; }

        [DisplayName("联系人登录密码")]
        [Required]
        public string LxrPwd { get; set; }
        /// <summary>
        /// seed
        /// </summary>
        private int _id ;
        /// <summary>
        /// seed
        /// </summary>
        [Key] 
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        
         
        
        /// <summary>
        /// 加盟商ID_listhidden_searchhidden
        /// </summary>
        private int _JmsID ;
        /// <summary>
        /// 加盟商ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟商ID")]
         [Required]
        public int JmsID
        {
            set { _JmsID = value; }
            get { return _JmsID; }
        }
        
         
        
        /// <summary>
        /// 加盟商名称
        /// </summary>
        private string _JmsName  = "";
        /// <summary>
        /// 加盟商名称
        /// </summary>
        [DisplayName("加盟商名称")]
         [Required]
        public string JmsName
        {
            set { _JmsName = value; }
            get { return _JmsName; }
        }
        
         
        
        /// <summary>
        /// 联系人名字
        /// </summary>
        private string _LxrName  = "";
        /// <summary>
        /// 联系人名字
        /// </summary>
        [DisplayName("联系人名字")]
         [Required]
        public string LxrName
        {
            set { _LxrName = value; }
            get { return _LxrName; }
        }
        
         
        
        /// <summary>
        /// 联系人性别_searchhidden
        /// </summary>
        private string _LxrSex  = "";
        /// <summary>
        /// 联系人性别_searchhidden
        /// </summary>
        [DisplayName("联系人性别")]
        
        public string LxrSex
        {
            set { _LxrSex = value; }
            get { return _LxrSex; }
        }
        
         
        
        /// <summary>
        /// 联系人电话
        /// </summary>
        private string _LxrPhone  = "";
        /// <summary>
        /// 联系人电话
        /// </summary>
        [DisplayName("联系人电话")]
         [Required]
        public string LxrPhone
        {
            set { _LxrPhone = value; }
            get { return _LxrPhone; }
        }
        
         
        
        /// <summary>
        /// 联系人微信号_listhidden_searchhidden
        /// </summary>
        private string _LxrWeiXin  = "";
        /// <summary>
        /// 联系人微信号_listhidden_searchhidden
        /// </summary>
        [DisplayName("联系人微信号")]
        
        public string LxrWeiXin
        {
            set { _LxrWeiXin = value; }
            get { return _LxrWeiXin; }
        }
        
         
        
        /// <summary>
        /// 联系人QQ_listhidden_searchhidden
        /// </summary>
        private string _LxrQQ  = "";
        /// <summary>
        /// 联系人QQ_listhidden_searchhidden
        /// </summary>
        [DisplayName("联系人QQ")]
        
        public string LxrQQ
        {
            set { _LxrQQ = value; }
            get { return _LxrQQ; }
        }
        
         
        
        /// <summary>
        /// 联系人Mail_listhidden_searchhidden
        /// </summary>
        private string _LxrMail  = "";
        /// <summary>
        /// 联系人Mail_listhidden_searchhidden
        /// </summary>
        [DisplayName("联系人Mail")]
        
        public string LxrMail
        {
            set { _LxrMail = value; }
            get { return _LxrMail; }
        }
        
         
        
        /// <summary>
        /// 联系人职务_searchhidden
        /// </summary>
        private string _LxrZhiWu  = "";
        /// <summary>
        /// 联系人职务_searchhidden
        /// </summary>
        [DisplayName("联系人职务")]
        
        public string LxrZhiWu
        {
            set { _LxrZhiWu = value; }
            get { return _LxrZhiWu; }
        }
        
         
        
        /// <summary>
        /// 联系人状态 
        /// </summary>
        private int _LxrStateID ;
        /// <summary>
        /// 联系人状态 
        /// </summary>
        [DisplayName("联系人状态 ")]
         [Required]
        public int LxrStateID
        {
            set { _LxrStateID = value; }
            get { return _LxrStateID; }
        }

        [DisplayName("操作人")]
        
        public int? optId { get; set; }

        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        [DisplayName("操作人名")]
         [Required]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 操作时间_listhidden_searchhidden_createdate
        /// </summary>
        private DateTime _optDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间_listhidden_searchhidden_createdate
        /// </summary>
        [DisplayName("操作时间")]
         [Required]
        public DateTime optDateTime
        {
            set { _optDateTime = value; }
            get { return _optDateTime; }
        }
        
        private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeStart
{
set { _optDateTimeStart = value; }
get{ return _optDateTimeStart; }
}
 private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeEnd
{
set { _optDateTimeEnd = value; }
get{ return _optDateTimeEnd; }
}
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JMSLXRReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("来源")]
        public string FromType { get; set; }

        [DisplayName("操作人")]

        public int? optId { get; set; }
        /// <summary>
        /// seed
        /// </summary> 
        public int id { get;set; } 
	
        public string LxrPwd { get; set; }

        /// <summary>
        /// 加盟商ID_listhidden_searchhidden
        /// </summary> 
        public int? JmsID { get;set; } 
	
          
        /// <summary>
        /// 加盟商名称
        /// </summary> 
        public string JmsName { get;set; } 
	
          
        /// <summary>
        /// 联系人名字
        /// </summary> 
        public string LxrName { get;set; } 
	
          
        /// <summary>
        /// 联系人性别_searchhidden
        /// </summary> 
        public string LxrSex { get;set; } 
	
          
        /// <summary>
        /// 联系人电话
        /// </summary> 
        public string LxrPhone { get;set; } 
	
          
        /// <summary>
        /// 联系人微信号_listhidden_searchhidden
        /// </summary> 
        public string LxrWeiXin { get;set; } 
	
          
        /// <summary>
        /// 联系人QQ_listhidden_searchhidden
        /// </summary> 
        public string LxrQQ { get;set; } 
	
          
        /// <summary>
        /// 联系人Mail_listhidden_searchhidden
        /// </summary> 
        public string LxrMail { get;set; } 
	
          
        /// <summary>
        /// 联系人职务_searchhidden
        /// </summary> 
        public string LxrZhiWu { get;set; } 
	
          
        /// <summary>
        /// 联系人状态 
        /// </summary> 
        public int? LxrStateID { get;set; } 
	
          
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 操作时间_listhidden_searchhidden_createdate
        /// </summary> 
        public DateTime? optDateTime { get;set; } 
	
          private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeStart
{
set { _optDateTimeStart = value; }
get{ return _optDateTimeStart; }
}
 private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeEnd
{
set { _optDateTimeEnd = value; }
get{ return _optDateTimeEnd; }
}
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

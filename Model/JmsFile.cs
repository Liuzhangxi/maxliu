



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
    /// <para>摘要：JmsFileModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JmsFile
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>DirectoryId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>文件夹id</td></tr>
    /// <tr valign="top"><td>3</td><td>DirectoryName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>文件夹名称</td></tr>
    /// <tr valign="top"><td>4</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>名称</td></tr>
    /// <tr valign="top"><td>5</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>6</td><td>ZhengLiState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>是否被整理</td></tr>
    /// <tr valign="top"><td>7</td><td>OptDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>8</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>9</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人Id</td></tr>
    /// <tr valign="top"><td>10</td><td>JmsId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>11</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商名称</td></tr>
    /// <tr valign="top"><td>12</td><td>FileAbsolutePath</td><td>nvarchar</td><td>250</td><td></td><td></td><td></td><td>√</td><td></td><td>附件绝对地址</td></tr>
    /// <tr valign="top"><td>13</td><td>FileRelatePath</td><td>nvarchar</td><td>250</td><td></td><td></td><td></td><td>√</td><td></td><td>附件相对地址</td></tr>
    /// <tr valign="top"><td>14</td><td>Type</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>上传类型</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("JmsFile")]
    [Serializable]
    public partial class JmsFile 
    {
    
        public static string LogClass = "文件表";
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
        /// 文件夹id
        /// </summary>
        private int? _DirectoryId ;
        /// <summary>
        /// 文件夹id
        /// </summary>
        [DisplayName("文件夹id")]
        
        public int? DirectoryId
        {
            set { _DirectoryId = value; }
            get { return _DirectoryId; }
        }
        
         
        
        /// <summary>
        /// 文件夹名称
        /// </summary>
        private string _DirectoryName  = "";
        /// <summary>
        /// 文件夹名称
        /// </summary>
        [DisplayName("文件夹名称")]
        
        public string DirectoryName
        {
            set { _DirectoryName = value; }
            get { return _DirectoryName; }
        }
        
         
        
        /// <summary>
        /// 名称
        /// </summary>
        private string _Name  = "";
        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("名称")]
        
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
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
        /// 是否被整理
        /// </summary>
        private string _ZhengLiState  = "";
        /// <summary>
        /// 是否被整理
        /// </summary>
        [DisplayName("是否被整理")]
        
        public string ZhengLiState
        {
            set { _ZhengLiState = value; }
            get { return _ZhengLiState; }
        }
        
         
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _OptDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
        public DateTime? OptDateTime
        {
            set { _OptDateTime = value; }
            get { return _OptDateTime; }
        }
        
        private DateTime _OptDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeStart
{
set { _OptDateTimeStart = value; }
get{ return _OptDateTimeStart; }
}
 private DateTime _OptDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeEnd
{
set { _OptDateTimeEnd = value; }
get{ return _OptDateTimeEnd; }
}
  
        
        /// <summary>
        /// 操作人
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 操作人Id
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作人Id
        /// </summary>
        [DisplayName("操作人Id")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 
        /// </summary>
        private int? _JmsId ;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("JmsId")]
        
        public int? JmsId
        {
            set { _JmsId = value; }
            get { return _JmsId; }
        }
        
         
        
        /// <summary>
        /// 加盟商名称
        /// </summary>
        private string _JmsName  = "";
        /// <summary>
        /// 加盟商名称
        /// </summary>
        [DisplayName("加盟商名称")]
        
        public string JmsName
        {
            set { _JmsName = value; }
            get { return _JmsName; }
        }
        
         
        
        /// <summary>
        /// 附件绝对地址
        /// </summary>
        private string _FileAbsolutePath  = "";
        /// <summary>
        /// 附件绝对地址
        /// </summary>
        [DisplayName("附件绝对地址")]
        
        public string FileAbsolutePath
        {
            set { _FileAbsolutePath = value; }
            get { return _FileAbsolutePath; }
        }
        
         
        
        /// <summary>
        /// 附件相对地址
        /// </summary>
        private string _FileRelatePath  = "";
        /// <summary>
        /// 附件相对地址
        /// </summary>
        [DisplayName("附件相对地址")]
        
        public string FileRelatePath
        {
            set { _FileRelatePath = value; }
            get { return _FileRelatePath; }
        }
        
         
        
        /// <summary>
        /// 上传类型
        /// </summary>
        private string _Type  = "";
        /// <summary>
        /// 上传类型
        /// </summary>
        [DisplayName("上传类型")]
        
        public string Type
        {
            set { _Type = value; }
            get { return _Type; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JmsFileReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 文件夹id
        /// </summary> 
        public int? DirectoryId { get;set; } 
	
          
        /// <summary>
        /// 文件夹名称
        /// </summary> 
        public string DirectoryName { get;set; } 
	
          
        /// <summary>
        /// 名称
        /// </summary> 
        public string Name { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 是否被整理
        /// </summary> 
        public string ZhengLiState { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
        /// </summary> 
        public DateTime? OptDateTime { get;set; } 
	
          private DateTime _OptDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeStart
{
set { _OptDateTimeStart = value; }
get{ return _OptDateTimeStart; }
}
 private DateTime _OptDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime OptDateTimeEnd
{
set { _OptDateTimeEnd = value; }
get{ return _OptDateTimeEnd; }
}
 
        /// <summary>
        /// 操作人
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 操作人Id
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 
        /// </summary> 
        public int? JmsId { get;set; } 
	
          
        /// <summary>
        /// 加盟商名称
        /// </summary> 
        public string JmsName { get;set; } 
	
          
        /// <summary>
        /// 附件绝对地址
        /// </summary> 
        public string FileAbsolutePath { get;set; } 
	
          
        /// <summary>
        /// 附件相对地址
        /// </summary> 
        public string FileRelatePath { get;set; } 
	
          
        /// <summary>
        /// 上传类型
        /// </summary> 
        public string Type { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}





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
    /// <para>摘要：JmsDirectoryModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JmsDirectory
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>ParentId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>父节点Id</td></tr>
    /// <tr valign="top"><td>3</td><td>ParentName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>父节点名</td></tr>
    /// <tr valign="top"><td>4</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>名称</td></tr>
    /// <tr valign="top"><td>5</td><td>Right</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>需要权限(公共、门店和临时文件夹)</td></tr>
    /// <tr valign="top"><td>6</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>7</td><td>DirectoryPath</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>文件夹路径前缀</td></tr>
    /// <tr valign="top"><td>8</td><td>JmsUploadClassState</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟类型</td></tr>
    /// <tr valign="top"><td>9</td><td>JmsId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>10</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商名称</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("JmsDirectory")]
    [Serializable]
    public partial class JmsDirectory 
    {
    
        public static string LogClass = "文件夹表";
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
        /// 父节点Id
        /// </summary>
        private int? _ParentId ;
        /// <summary>
        /// 父节点Id
        /// </summary>
        [DisplayName("父节点Id")]
        
        public int? ParentId
        {
            set { _ParentId = value; }
            get { return _ParentId; }
        }
        
         
        
        /// <summary>
        /// 父节点名
        /// </summary>
        private string _ParentName  = "";
        /// <summary>
        /// 父节点名
        /// </summary>
        [DisplayName("父节点名")]
        
        public string ParentName
        {
            set { _ParentName = value; }
            get { return _ParentName; }
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
        /// 需要权限(公共、门店和临时文件夹)
        /// </summary>
        private string _Right  = "";
        /// <summary>
        /// 需要权限(公共、门店和临时文件夹)
        /// </summary>
        [DisplayName("需要权限(公共、门店和临时文件夹)")]
        
        public string Right
        {
            set { _Right = value; }
            get { return _Right; }
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
        /// 文件夹路径前缀
        /// </summary>
        private string _DirectoryPath  = "";
        /// <summary>
        /// 文件夹路径前缀
        /// </summary>
        [DisplayName("文件夹路径前缀")]
        
        public string DirectoryPath
        {
            set { _DirectoryPath = value; }
            get { return _DirectoryPath; }
        }
        
         
        
        /// <summary>
        /// 加盟类型
        /// </summary>
        private string _JmsUploadClassState  = "";
        /// <summary>
        /// 加盟类型
        /// </summary>
        [DisplayName("加盟类型")]
        
        public string JmsUploadClassState
        {
            set { _JmsUploadClassState = value; }
            get { return _JmsUploadClassState; }
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
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JmsDirectoryReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 父节点Id
        /// </summary> 
        public int? ParentId { get;set; } 
	
          
        /// <summary>
        /// 父节点名
        /// </summary> 
        public string ParentName { get;set; } 
	
          
        /// <summary>
        /// 名称
        /// </summary> 
        public string Name { get;set; } 
	
          
        /// <summary>
        /// 需要权限(公共、门店和临时文件夹)
        /// </summary> 
        public string Right { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 文件夹路径前缀
        /// </summary> 
        public string DirectoryPath { get;set; } 
	
          
        /// <summary>
        /// 加盟类型
        /// </summary> 
        public string JmsUploadClassState { get;set; } 
	
          
        /// <summary>
        /// 
        /// </summary> 
        public int? JmsId { get;set; } 
	
          
        /// <summary>
        /// 加盟商名称
        /// </summary> 
        public string JmsName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

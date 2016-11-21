



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
    /// <para>摘要：HeTongServiceModelModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HeTongServiceModel
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>3</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>4</td><td>optid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者id_optid</td></tr>
    /// <tr valign="top"><td>5</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者_optname</td></tr>
    /// <tr valign="top"><td>6</td><td>state</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态_validstate</td></tr>
    /// <tr valign="top"><td>7</td><td>ServerName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>服务名</td></tr>
    /// <tr valign="top"><td>8</td><td>lastupdateid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>更新用户</td></tr>
    /// <tr valign="top"><td>9</td><td>Mark</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HeTongServiceModel")]
    [Serializable]
    public partial class HeTongServiceModel 
    {
    
        public static string LogClass = "合同服务模版";
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
        /// 操作者id_optid
        /// </summary>
        private int? _optid ;
        /// <summary>
        /// 操作者id_optid
        /// </summary>
        [DisplayName("操作者id")]
        
        public int? optid
        {
            set { _optid = value; }
            get { return _optid; }
        }
        
         
        
        /// <summary>
        /// 操作者_optname
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作者_optname
        /// </summary>
        [DisplayName("操作者")]
        
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        private string _state  = "";
        /// <summary>
        /// 有效状态_validstate
        /// </summary>
        [DisplayName("有效状态")]
        
        public string state
        {
            set { _state = value; }
            get { return _state; }
        }
        
         
        
        /// <summary>
        /// 服务名
        /// </summary>
        private string _ServerName  = "";
        /// <summary>
        /// 服务名
        /// </summary>
        [DisplayName("服务名")]
        
        public string ServerName
        {
            set { _ServerName = value; }
            get { return _ServerName; }
        }
        
         
        
        /// <summary>
        /// 更新用户
        /// </summary>
        private int? _lastupdateid ;
        /// <summary>
        /// 更新用户
        /// </summary>
        [DisplayName("更新用户")]
        
        public int? lastupdateid
        {
            set { _lastupdateid = value; }
            get { return _lastupdateid; }
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
    
    public partial class HeTongServiceModelReq:BaseSearchReq
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
        /// 操作者id_optid
        /// </summary> 
        public int? optid { get;set; } 
	
          
        /// <summary>
        /// 操作者_optname
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 有效状态_validstate
        /// </summary> 
        public string state { get;set; } 
	
          
        /// <summary>
        /// 服务名
        /// </summary> 
        public string ServerName { get;set; } 
	
          
        /// <summary>
        /// 更新用户
        /// </summary> 
        public int? lastupdateid { get;set; } 
	
          
        /// <summary>
        /// 备注
        /// </summary> 
        public string Mark { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

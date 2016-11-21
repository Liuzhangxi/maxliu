



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
    /// <para>摘要：PaiBanTypeModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：PaiBanType
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Name</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>排班名称</td></tr>
    /// <tr valign="top"><td>3</td><td>Hours</td><td>decimal</td><td>9</td><td>18,1</td><td></td><td></td><td>√</td><td></td><td>小时数</td></tr>
    /// <tr valign="top"><td>4</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>5</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optname</td></tr>
    /// <tr valign="top"><td>6</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>项目id</td></tr>
    /// <tr valign="top"><td>7</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>项目名</td></tr>
    /// <tr valign="top"><td>8</td><td>FromHour</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>排班起始小时数(24小时制)</td></tr>
    /// <tr valign="top"><td>9</td><td>ToHour</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>排班结束小时数(24小时制)</td></tr>
    /// <tr valign="top"><td>10</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>是否有效_validstate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("PaiBanType")]
    [Serializable]
    public partial class PaiBanType 
    {
    
        public static string LogClass = "排班类型";
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
        /// 排班名称
        /// </summary>
        private string _Name  = "";
        /// <summary>
        /// 排班名称
        /// </summary>
        [DisplayName("排班名称")]
        
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        
         
        
        /// <summary>
        /// 小时数
        /// </summary>
        private decimal? _Hours ;
        /// <summary>
        /// 小时数
        /// </summary>
        [DisplayName("小时数")]
        
        public decimal? Hours
        {
            set { _Hours = value; }
            get { return _Hours; }
        }
        
         
        
        /// <summary>
        /// 操作人_optid
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作人_optid
        /// </summary>
        [DisplayName("操作人")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作人_optname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人_optname
        /// </summary>
        [DisplayName("操作人")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 项目id
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 项目id
        /// </summary>
        [DisplayName("门店信息")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 项目名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 项目名
        /// </summary>
        [DisplayName("项目名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 排班起始小时数(24小时制)
        /// </summary>
        private decimal? _FromHour ;
        /// <summary>
        /// 排班起始小时数(24小时制)
        /// </summary>
        [DisplayName("排班起始时间(24小时制)")]
        
        public decimal? FromHour
        {
            set { _FromHour = value; }
            get { return _FromHour; }
        }
        
         
        
        /// <summary>
        /// 排班结束小时数(24小时制)
        /// </summary>
        private decimal? _ToHour ;
        /// <summary>
        /// 排班结束小时数(24小时制)
        /// </summary>
        [DisplayName("排班结束时间(24小时制)")]
        
        public decimal? ToHour
        {
            set { _ToHour = value; }
            get { return _ToHour; }
        }
        
         
        
        /// <summary>
        /// 是否有效_validstate
        /// </summary>
        private string _ValidState  = "";
        /// <summary>
        /// 是否有效_validstate
        /// </summary>
        [DisplayName("是否有效")]
        
        public string ValidState
        {
            set { _ValidState = value; }
            get { return _ValidState; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class PaiBanTypeReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 排班名称
        /// </summary> 
        public string Name { get;set; } 
	
          
        /// <summary>
        /// 小时数
        /// </summary> 
        public decimal? Hours { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 项目名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 排班起始小时数(24小时制)
        /// </summary> 
        public decimal? FromHour { get;set; } 
	
          
        /// <summary>
        /// 排班结束小时数(24小时制)
        /// </summary> 
        public decimal? ToHour { get;set; } 
	
          
        /// <summary>
        /// 是否有效_validstate
        /// </summary> 
        public string ValidState { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}





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
    /// <para>摘要：PingXiangInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：PingXiangInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>PingXiangName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>品相名</td></tr>
    /// <tr valign="top"><td>3</td><td>GongXiao</td><td>nvarchar</td><td>450</td><td></td><td></td><td></td><td>√</td><td></td><td>功效</td></tr>
    /// <tr valign="top"><td>4</td><td>ShouFeiType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>收费类型</td></tr>
    /// <tr valign="top"><td>5</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态</td></tr>
    /// <tr valign="top"><td>6</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者</td></tr>
    /// <tr valign="top"><td>7</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名</td></tr>
    /// <tr valign="top"><td>8</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("PingXiangInfo")]
    [Serializable]
    public partial class PingXiangInfo 
    {
    
        public static string LogClass = "食疗品项";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("管理方")]
        public string ManagerType { get; set; }

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
        /// 品相名
        /// </summary>
        private string _PingXiangName  = "";
        /// <summary>
        /// 品项名
        /// </summary>
        [DisplayName("品项名")]
        
        public string PingXiangName
        {
            set { _PingXiangName = value; }
            get { return _PingXiangName; }
        }
        
         
        
        /// <summary>
        /// 功效
        /// </summary>
        private string _GongXiao  = "";
        /// <summary>
        /// 功效
        /// </summary>
        [DisplayName("功效")]
        
        public string GongXiao
        {
            set { _GongXiao = value; }
            get { return _GongXiao; }
        }
        
         
        
        /// <summary>
        /// 收费类型
        /// </summary>
        private string _ShouFeiType  = "";
        /// <summary>
        /// 收费类型
        /// </summary>
        [DisplayName("收费类型")]
        
        public string ShouFeiType
        {
            set { _ShouFeiType = value; }
            get { return _ShouFeiType; }
        }
        
         
        
        /// <summary>
        /// 有效状态
        /// </summary>
        private string _ValidState  = "";
        /// <summary>
        /// 有效状态
        /// </summary>
        [DisplayName("有效状态")]
        
        public string ValidState
        {
            set { _ValidState = value; }
            get { return _ValidState; }
        }
        
         
        
        /// <summary>
        /// 操作者
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作者
        /// </summary>
        [DisplayName("操作者")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作者名
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作者名
        /// </summary>
        [DisplayName("操作者名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _CreateDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]
        
        public DateTime? CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }
        
        private DateTime _CreateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateStart
{
set { _CreateDateStart = value; }
get{ return _CreateDateStart; }
}
 private DateTime _CreateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateEnd
{
set { _CreateDateEnd = value; }
get{ return _CreateDateEnd; }
}
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class PingXiangInfoReq:BaseSearchReq
    {
        [DisplayName("管理方")]
        public string ManagerType { get; set; }
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; }


        /// <summary>
        /// 品项名
        /// </summary> 
        public string PingXiangName { get;set; } 
	
          
        /// <summary>
        /// 功效
        /// </summary> 
        public string GongXiao { get;set; } 
	
          
        /// <summary>
        /// 收费类型
        /// </summary> 
        public string ShouFeiType { get;set; } 
	
          
        /// <summary>
        /// 有效状态
        /// </summary> 
        public string ValidState { get;set; } 
	
          
        /// <summary>
        /// 操作者
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作者名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建时间_createdate
        /// </summary> 
        public DateTime? CreateDate { get;set; } 
	
          private DateTime _CreateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateStart
{
set { _CreateDateStart = value; }
get{ return _CreateDateStart; }
}
 private DateTime _CreateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreateDateEnd
{
set { _CreateDateEnd = value; }
get{ return _CreateDateEnd; }
}
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

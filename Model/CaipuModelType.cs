



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
    /// <para>摘要：CaipuModelTypeModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：CaipuModelType
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>TypeName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>类型名</td></tr>
    /// <tr valign="top"><td>3</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店</td></tr>
    /// <tr valign="top"><td>4</td><td>ProjectName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名</td></tr>
    /// <tr valign="top"><td>5</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员_isoptid</td></tr>
    /// <tr valign="top"><td>6</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员名_isoptname</td></tr>
    /// <tr valign="top"><td>7</td><td>createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>8</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>是否有效</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("CaipuModelType")]
    [Serializable]
    public partial class CaipuModelType 
    {
    
        public static string LogClass = "菜谱模版类型";
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
        /// 类型名
        /// </summary>
        private string _TypeName  = "";
        /// <summary>
        /// 类型名
        /// </summary>
        [DisplayName("类型名")]
        
        public string TypeName
        {
            set { _TypeName = value; }
            get { return _TypeName; }
        }
        
         
        
        /// <summary>
        /// 门店
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 门店
        /// </summary>
        [DisplayName("门店")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 门店名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 门店名
        /// </summary>
        [DisplayName("门店名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 操作员_isoptid
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作员_isoptid
        /// </summary>
        [DisplayName("操作员")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作员名_isoptname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作员名_isoptname
        /// </summary>
        [DisplayName("操作员名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _createdate ;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
        public DateTime? createdate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        
        private DateTime _createdateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateStart
{
set { _createdateStart = value; }
get{ return _createdateStart; }
}
 private DateTime _createdateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateEnd
{
set { _createdateEnd = value; }
get{ return _createdateEnd; }
}
  
        
        /// <summary>
        /// 是否有效
        /// </summary>
        private string _ValidState  = "";
        /// <summary>
        /// 是否有效
        /// </summary>
        [DisplayName("是否有效")]
        
        public string ValidState
        {
            set { _ValidState = value; }
            get { return _ValidState; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class CaipuModelTypeReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 类型名
        /// </summary> 
        public string TypeName { get;set; } 
	
          
        /// <summary>
        /// 门店名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 操作员_isoptid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作员名_isoptname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
        /// </summary> 
        public DateTime? createdate { get;set; } 
	
          private DateTime _createdateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateStart
{
set { _createdateStart = value; }
get{ return _createdateStart; }
}
 private DateTime _createdateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createdateEnd
{
set { _createdateEnd = value; }
get{ return _createdateEnd; }
}
 
        /// <summary>
        /// 是否有效
        /// </summary> 
        public string ValidState { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}





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
    /// <para>摘要：GuYuanGroupModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：GuYuanGroup
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Departmentid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>部门</td></tr>
    /// <tr valign="top"><td>3</td><td>DepartmentName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>部门名</td></tr>
    /// <tr valign="top"><td>4</td><td>GroupName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>组名</td></tr>
    /// <tr valign="top"><td>5</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>6</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员名</td></tr>
    /// <tr valign="top"><td>7</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员</td></tr>
    /// <tr valign="top"><td>8</td><td>createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>9</td><td>ProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("GuYuanGroup")]
    [Serializable]
    public partial class GuYuanGroup 
    {
    
        public static string LogClass = "雇员组";
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
        /// 部门
        /// </summary>
        private int? _Departmentid ;
        /// <summary>
        /// 部门
        /// </summary>
        [DisplayName("部门")]
        
        public int? Departmentid
        {
            set { _Departmentid = value; }
            get { return _Departmentid; }
        }
        
         
        
        /// <summary>
        /// 部门名
        /// </summary>
        private string _DepartmentName  = "";
        /// <summary>
        /// 部门名
        /// </summary>
        [DisplayName("部门名")]
        
        public string DepartmentName
        {
            set { _DepartmentName = value; }
            get { return _DepartmentName; }
        }
        
         
        
        /// <summary>
        /// 组名
        /// </summary>
        private string _GroupName  = "";
        /// <summary>
        /// 组名
        /// </summary>
        [DisplayName("组名")]
        
        public string GroupName
        {
            set { _GroupName = value; }
            get { return _GroupName; }
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
        /// 操作员名
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作员名
        /// </summary>
        [DisplayName("操作员名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 操作员
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作员
        /// </summary>
        [DisplayName("操作员")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _createdate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]
        
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
        /// 门店
        /// </summary>
        private int? _ProjectId ;
        /// <summary>
        /// 门店
        /// </summary>
        [DisplayName("门店")]
        
        public int? ProjectId
        {
            set { _ProjectId = value; }
            get { return _ProjectId; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class GuYuanGroupReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 部门
        /// </summary> 
        public int? Departmentid { get;set; } 
	
          
        /// <summary>
        /// 部门名
        /// </summary> 
        public string DepartmentName { get;set; } 
	
          
        /// <summary>
        /// 组名
        /// </summary> 
        public string GroupName { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 操作员名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 操作员
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 创建时间_createdate
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
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}





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
    /// <para>摘要：DietDayNoteModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：DietDayNote
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>ServerDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>服务日期</td></tr>
    /// <tr valign="top"><td>3</td><td>LunchEmployeeCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>午餐员工数</td></tr>
    /// <tr valign="top"><td>4</td><td>SupperEmployeeCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>晚餐员工数</td></tr>
    /// <tr valign="top"><td>5</td><td>LunchNote</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>午餐备注</td></tr>
    /// <tr valign="top"><td>6</td><td>SupperNote</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>晚餐备注</td></tr>
    /// <tr valign="top"><td>7</td><td>OtherNote</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>其他备注</td></tr>
    /// <tr valign="top"><td>8</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>9</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者</td></tr>
    /// <tr valign="top"><td>10</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名</td></tr>
    /// <tr valign="top"><td>11</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("DietDayNote")]
    [Serializable]
    public partial class DietDayNote 
    {
    
        public static string LogClass = "每日饮食说明";
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
        /// 服务日期
        /// </summary>
        private DateTime? _ServerDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 服务日期
        /// </summary>
        [DisplayName("服务日期")]
        
        public DateTime? ServerDate
        {
            set { _ServerDate = value; }
            get { return _ServerDate; }
        }
        
        private DateTime _ServerDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateStart
{
set { _ServerDateStart = value; }
get{ return _ServerDateStart; }
}
 private DateTime _ServerDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateEnd
{
set { _ServerDateEnd = value; }
get{ return _ServerDateEnd; }
}
  
        
        /// <summary>
        /// 午餐员工数
        /// </summary>
        private int? _LunchEmployeeCount ;
        /// <summary>
        /// 午餐员工数
        /// </summary>
        [DisplayName("午餐员工数")]
        
        public int? LunchEmployeeCount
        {
            set { _LunchEmployeeCount = value; }
            get { return _LunchEmployeeCount; }
        }
        
         
        
        /// <summary>
        /// 晚餐员工数
        /// </summary>
        private int? _SupperEmployeeCount ;
        /// <summary>
        /// 晚餐员工数
        /// </summary>
        [DisplayName("晚餐员工数")]
        
        public int? SupperEmployeeCount
        {
            set { _SupperEmployeeCount = value; }
            get { return _SupperEmployeeCount; }
        }
        
         
        
        /// <summary>
        /// 午餐备注
        /// </summary>
        private string _LunchNote  = "";
        /// <summary>
        /// 午餐备注
        /// </summary>
        [DisplayName("午餐备注")]
        
        public string LunchNote
        {
            set { _LunchNote = value; }
            get { return _LunchNote; }
        }
        
         
        
        /// <summary>
        /// 晚餐备注
        /// </summary>
        private string _SupperNote  = "";
        /// <summary>
        /// 晚餐备注
        /// </summary>
        [DisplayName("晚餐备注")]
        
        public string SupperNote
        {
            set { _SupperNote = value; }
            get { return _SupperNote; }
        }
        
         
        
        /// <summary>
        /// 其他备注
        /// </summary>
        private string _OtherNote  = "";
        /// <summary>
        /// 其他备注
        /// </summary>
        [DisplayName("其他备注")]
        
        public string OtherNote
        {
            set { _OtherNote = value; }
            get { return _OtherNote; }
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
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class DietDayNoteReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 服务日期
        /// </summary> 
        public DateTime? ServerDate { get;set; } 
	
          private DateTime _ServerDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateStart
{
set { _ServerDateStart = value; }
get{ return _ServerDateStart; }
}
 private DateTime _ServerDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ServerDateEnd
{
set { _ServerDateEnd = value; }
get{ return _ServerDateEnd; }
}
 
        /// <summary>
        /// 午餐员工数
        /// </summary> 
        public int? LunchEmployeeCount { get;set; } 
	
          
        /// <summary>
        /// 晚餐员工数
        /// </summary> 
        public int? SupperEmployeeCount { get;set; } 
	
          
        /// <summary>
        /// 午餐备注
        /// </summary> 
        public string LunchNote { get;set; } 
	
          
        /// <summary>
        /// 晚餐备注
        /// </summary> 
        public string SupperNote { get;set; } 
	
          
        /// <summary>
        /// 其他备注
        /// </summary> 
        public string OtherNote { get;set; } 
	
          
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
 
        /// <summary>
        /// 操作者
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作者名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

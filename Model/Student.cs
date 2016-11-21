



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using OUDAL.ModelBase;
namespace OUDAL
{
    ///################################################################################################
    /// <summary>
    /// <para>摘要：StudentModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：Student
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>学员姓名</td></tr>
    /// <tr valign="top"><td>3</td><td>Phone</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>电话</td></tr>
    /// <tr valign="top"><td>4</td><td>JobPosition</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>所在岗位</td></tr>
    /// <tr valign="top"><td>5</td><td>JmsId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商</td></tr>
    /// <tr valign="top"><td>6</td><td>JmsName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商名</td></tr>
    /// <tr valign="top"><td>7</td><td>TrainingStart</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>训练开始日期</td></tr>
    /// <tr valign="top"><td>8</td><td>TrainingFinish</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>训练结束日期</td></tr>
    /// <tr valign="top"><td>9</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>10</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者</td></tr>
    /// <tr valign="top"><td>11</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名</td></tr>
    /// <tr valign="top"><td>12</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>13</td><td>UpdateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>更新日期_updatedate</td></tr>
    /// <tr valign="top"><td>14</td><td>Note</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>阶段总结</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("Student")]
    [Serializable]
    public partial class Student 
    {
    
        public static string LogClass = "学员表";
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
        /// 学员姓名
        /// </summary>
        private string _Name  = "";
        /// <summary>
        /// 学员姓名
        /// </summary>
        [DisplayName("学员姓名")]
        
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        
         
        
        /// <summary>
        /// 电话
        /// </summary>
        private string _Phone  = "";
        /// <summary>
        /// 电话
        /// </summary>
        [DisplayName("电话")]
        //[Phone(ErrorMessage = "请输入正确手机号")]
        //[RegularExpression(@"/^1[3|4|5|7|8]\d{9}$",ErrorMessage = "请正确输入手机号")]
        //[Remote(“CheckUserName”, “Account”, ErrorMessage = "该姓名已存在")]
        //[DataTyle(DataType.MultilineText)]//数据显示为多文本
        public string Phone
        {
            set { _Phone = value; }
            get { return _Phone; }
        }
        
         
        
        /// <summary>
        /// 所在岗位
        /// </summary>
        private string _JobPosition  = "";
        /// <summary>
        /// 所在岗位
        /// </summary>
        [DisplayName("所在岗位")]
        
        public string JobPosition
        {
            set { _JobPosition = value; }
            get { return _JobPosition; }
        }
        
         
        
        /// <summary>
        /// 加盟商
        /// </summary>
        private int? _JmsId ;
        /// <summary>
        /// 加盟商
        /// </summary>
        [DisplayName("加盟商")]
        
        public int? JmsId
        {
            set { _JmsId = value; }
            get { return _JmsId; }
        }
        
         
        
        /// <summary>
        /// 加盟商名
        /// </summary>
        private string _JmsName  = "";
        /// <summary>
        /// 加盟商名
        /// </summary>
        [DisplayName("加盟商名")]
        
        public string JmsName
        {
            set { _JmsName = value; }
            get { return _JmsName; }
        }
        
         
        
        /// <summary>
        /// 训练开始日期
        /// </summary>
        private DateTime? _TrainingStart  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 训练开始日期
        /// </summary>
        [DisplayName("培训开始日期")]
        
        public DateTime? TrainingStart
        {
            set { _TrainingStart = value; }
            get { return _TrainingStart; }
        }
        
        private DateTime _TrainingStartStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingStartStart
{
set { _TrainingStartStart = value; }
get{ return _TrainingStartStart; }
}
 private DateTime _TrainingStartEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingStartEnd
{
set { _TrainingStartEnd = value; }
get{ return _TrainingStartEnd; }
}
  
        
        /// <summary>
        /// 训练结束日期
        /// </summary>
        private DateTime? _TrainingFinish  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 训练结束日期
        /// </summary>
        [DisplayName("培训结束日期")]
        
        public DateTime? TrainingFinish
        {
            set { _TrainingFinish = value; }
            get { return _TrainingFinish; }
        }
        
        private DateTime _TrainingFinishStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingFinishStart
{
set { _TrainingFinishStart = value; }
get{ return _TrainingFinishStart; }
}
 private DateTime _TrainingFinishEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingFinishEnd
{
set { _TrainingFinishEnd = value; }
get{ return _TrainingFinishEnd; }
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
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _CreateDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
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
        /// 更新日期_updatedate
        /// </summary>
        private DateTime? _UpdateDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 更新日期_updatedate
        /// </summary>
        [DisplayName("更新日期")]
        
        public DateTime? UpdateDate
        {
            set { _UpdateDate = value; }
            get { return _UpdateDate; }
        }
        
        private DateTime _UpdateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateStart
{
set { _UpdateDateStart = value; }
get{ return _UpdateDateStart; }
}
 private DateTime _UpdateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateEnd
{
set { _UpdateDateEnd = value; }
get{ return _UpdateDateEnd; }
}
  
        
        /// <summary>
        /// 阶段总结
        /// </summary>
        private string _Note  = "";
        /// <summary>
        /// 阶段总结
        /// </summary>
        [DisplayName("阶段总结")]
        
        public string Note
        {
            set { _Note = value; }
            get { return _Note; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class StudentReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 学员姓名
        /// </summary> 
        public string Name { get;set; } 
	
          
        /// <summary>
        /// 电话
        /// </summary> 
        public string Phone { get;set; } 
	
          
        /// <summary>
        /// 所在岗位
        /// </summary> 
        public string JobPosition { get;set; } 
	
          
        /// <summary>
        /// 加盟商
        /// </summary> 
        public int? JmsId { get;set; } 
	
          
        /// <summary>
        /// 加盟商名
        /// </summary> 
        public string JmsName { get;set; } 
	
          
        /// <summary>
        /// 训练开始日期
        /// </summary> 
        public DateTime? TrainingStart { get;set; } 
	
          private DateTime _TrainingStartStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingStartStart
{
set { _TrainingStartStart = value; }
get{ return _TrainingStartStart; }
}
 private DateTime _TrainingStartEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingStartEnd
{
set { _TrainingStartEnd = value; }
get{ return _TrainingStartEnd; }
}
 
        /// <summary>
        /// 训练结束日期
        /// </summary> 
        public DateTime? TrainingFinish { get;set; } 
	
          private DateTime _TrainingFinishStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingFinishStart
{
set { _TrainingFinishStart = value; }
get{ return _TrainingFinishStart; }
}
 private DateTime _TrainingFinishEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime TrainingFinishEnd
{
set { _TrainingFinishEnd = value; }
get{ return _TrainingFinishEnd; }
}
 
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 操作者
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作者名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
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
        /// 更新日期_updatedate
        /// </summary> 
        public DateTime? UpdateDate { get;set; } 
	
          private DateTime _UpdateDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateStart
{
set { _UpdateDateStart = value; }
get{ return _UpdateDateStart; }
}
 private DateTime _UpdateDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime UpdateDateEnd
{
set { _UpdateDateEnd = value; }
get{ return _UpdateDateEnd; }
}
 
        /// <summary>
        /// 阶段总结
        /// </summary> 
        public string Note { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

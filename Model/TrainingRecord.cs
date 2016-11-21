



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
    /// <para>摘要：TrainingRecordModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：TrainingRecord
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>WeekNumber</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>周数</td></tr>
    /// <tr valign="top"><td>3</td><td>DayClass</td><td>nvarchar</td><td>650</td><td></td><td></td><td></td><td>√</td><td></td><td>日期排班信息</td></tr>
    /// <tr valign="top"><td>4</td><td>TrainContent</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>培训内容</td></tr>
    /// <tr valign="top"><td>5</td><td>ZhangWoQingKuang</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>掌握情况</td></tr>
    /// <tr valign="top"><td>6</td><td>StudentFeedBack</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>学院反馈</td></tr>
    /// <tr valign="top"><td>7</td><td>TeacherFeedBack</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>老师反馈</td></tr>
    /// <tr valign="top"><td>8</td><td>TrainPlace</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>培训地点</td></tr>
    /// <tr valign="top"><td>9</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>10</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>11</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员</td></tr>
    /// <tr valign="top"><td>12</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员名</td></tr>
    /// <tr valign="top"><td>13</td><td>StudentId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>学员名</td></tr>
    /// <tr valign="top"><td>14</td><td>StudentName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>学员名称</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("TrainingRecord")]
    [Serializable]
    public partial class TrainingRecord 
    {
    
        public static string LogClass = "培训记录";
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
        /// 周数
        /// </summary>
        private int? _WeekNumber ;
        /// <summary>
        /// 周数
        /// </summary>
        [DisplayName("周数")]
        
        public int? WeekNumber
        {
            set { _WeekNumber = value; }
            get { return _WeekNumber; }
        }
        
         
        
        /// <summary>
        /// 日期排班信息
        /// </summary>
        private string _DayClass  = "";
        /// <summary>
        /// 日期排班信息
        /// </summary>
        [DisplayName("日期排班信息")]
        
        public string DayClass
        {
            set { _DayClass = value; }
            get { return _DayClass; }
        }
        
         
        
        /// <summary>
        /// 培训内容
        /// </summary>
        private string _TrainContent  = "";
        /// <summary>
        /// 培训内容
        /// </summary>
        [DisplayName("培训内容")]
        
        public string TrainContent
        {
            set { _TrainContent = value; }
            get { return _TrainContent; }
        }
        
         
        
        /// <summary>
        /// 掌握情况
        /// </summary>
        private string _ZhangWoQingKuang  = "";
        /// <summary>
        /// 掌握情况
        /// </summary>
        [DisplayName("掌握情况")]
        
        public string ZhangWoQingKuang
        {
            set { _ZhangWoQingKuang = value; }
            get { return _ZhangWoQingKuang; }
        }
        
         
        
        /// <summary>
        /// 学院反馈
        /// </summary>
        private string _StudentFeedBack  = "";
        /// <summary>
        /// 学院反馈
        /// </summary>
        [DisplayName("学院反馈")]
        
        public string StudentFeedBack
        {
            set { _StudentFeedBack = value; }
            get { return _StudentFeedBack; }
        }
        
         
        
        /// <summary>
        /// 老师反馈
        /// </summary>
        private string _TeacherFeedBack  = "";
        /// <summary>
        /// 老师反馈
        /// </summary>
        [DisplayName("老师反馈")]
        
        public string TeacherFeedBack
        {
            set { _TeacherFeedBack = value; }
            get { return _TeacherFeedBack; }
        }
        
         
        
        /// <summary>
        /// 培训地点
        /// </summary>
        private string _TrainPlace  = "";
        /// <summary>
        /// 培训地点
        /// </summary>
        [DisplayName("培训地点")]
        
        public string TrainPlace
        {
            set { _TrainPlace = value; }
            get { return _TrainPlace; }
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
        /// 学员名
        /// </summary>
        private int? _StudentId ;
        /// <summary>
        /// 学员名
        /// </summary>
        [DisplayName("学员名")]
        
        public int? StudentId
        {
            set { _StudentId = value; }
            get { return _StudentId; }
        }
        
         
        
        /// <summary>
        /// 学员名称
        /// </summary>
        private string _StudentName  = "";
        /// <summary>
        /// 学员名称
        /// </summary>
        [DisplayName("学员名称")]
        
        public string StudentName
        {
            set { _StudentName = value; }
            get { return _StudentName; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class TrainingRecordReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 周数
        /// </summary> 
        public int? WeekNumber { get;set; } 
	
          
        /// <summary>
        /// 日期排班信息
        /// </summary> 
        public string DayClass { get;set; } 
	
          
        /// <summary>
        /// 培训内容
        /// </summary> 
        public string TrainContent { get;set; } 
	
          
        /// <summary>
        /// 掌握情况
        /// </summary> 
        public string ZhangWoQingKuang { get;set; } 
	
          
        /// <summary>
        /// 学院反馈
        /// </summary> 
        public string StudentFeedBack { get;set; } 
	
          
        /// <summary>
        /// 老师反馈
        /// </summary> 
        public string TeacherFeedBack { get;set; } 
	
          
        /// <summary>
        /// 培训地点
        /// </summary> 
        public string TrainPlace { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
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
        /// 操作员
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作员名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 学员名
        /// </summary> 
        public int? StudentId { get;set; } 
	
          
        /// <summary>
        /// 学员名称
        /// </summary> 
        public string StudentName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

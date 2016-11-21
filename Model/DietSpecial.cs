



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
    /// <para>摘要：DietSpecialModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：DietSpecial
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>日期</td></tr>
    /// <tr valign="top"><td>3</td><td>RoomId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>房间</td></tr>
    /// <tr valign="top"><td>4</td><td>RoomNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>房号</td></tr>
    /// <tr valign="top"><td>5</td><td>KeHuId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户</td></tr>
    /// <tr valign="top"><td>6</td><td>KeHuName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名</td></tr>
    /// <tr valign="top"><td>7</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员</td></tr>
    /// <tr valign="top"><td>8</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员名</td></tr>
    /// <tr valign="top"><td>9</td><td>Createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>10</td><td>SelectDiet</td><td>nvarchar</td><td>450</td><td></td><td></td><td></td><td>√</td><td></td><td>选中饮食</td></tr>
    /// <tr valign="top"><td>11</td><td>OtherDiet</td><td>nvarchar</td><td>350</td><td></td><td></td><td></td><td>√</td><td></td><td>其他</td></tr>
    /// <tr valign="top"><td>12</td><td>Desc</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>特殊饮食-说明</td></tr>
    /// <tr valign="top"><td>13</td><td>JiShiDesc</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>忌食</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("DietSpecial")]
    [Serializable]
    public partial class DietSpecial 
    {
    
        public static string LogClass = "忌食名单";
        #region -  公共属性  ------------------------------------------------------------

        [NotMapped]
        public string ProjectName
        {
            get
            {
                if (ProjectId == null || ProjectId.Value == 0)
                {
                    return "";
                }
               return DepartmentBLL.GetNameById(ProjectId.Value);
            }
        }

        /// <summary>
            /// 门店确认状态
            /// </summary>
            [DisplayName("门店检查状态")]
        public string MenDianCheckState { get; set; }
        [DisplayName("门店通过时间")]
        public DateTime? MDCheckDate { get; set; }
        [DisplayName("门店通过人")]
        public int? MDCheckPersonId { get; set; }

        [DisplayName("门店通过人名")]
        public string MDCheckPersonName { get; set; }
        [DisplayName("中央检查状态")]
        public string CenterCheckState { get; set; }
        [DisplayName("中央通过时间")]
        public DateTime? CenterCheckDate { get; set; }
        [DisplayName("中央通过人")]
        public int? CenterCheckPersonId { get; set; }

        [DisplayName("中央通过人名")]
        public string CenterCheckPersonName { get; set; }



        [DisplayName("设置的阶段名")]
        public int? SetStep { get; set; }

        public string StepName
        {
            get
            {
                if (SetStep == null) return "";
                return GetStepName(SetStep.Value);
            }
        }

        public static string GetStepName(int step)
        {
            switch (step)
            {
                case 1: return "第一阶段";
                case 2: return "第二阶段";
                case 3: return "第三阶段"; 
            }
            return step.ToString();
        }


        [DisplayName("对应入住信息")]
        public int? RoomCheckInId { get; set; }

        [DisplayName("保存时间")]
        public DateTime? SaveDate { get; set; }

        [DisplayName("启动时间")]
        public DateTime? StartDate { get; set; }
        public int? SaveId { get; set; }
        [DisplayName("保存人名")]
        public string SaveName { get; set; }
        public int? StartPersonId { get; set; }
        [DisplayName("启动人名")]
        public string StartPersonName { get; set; }
        /// <summary>
        /// 客户起始入住日期
        /// todo 需要赋值
        /// </summary>
       
        public DateTime? CustomerStart { get; set; }
     

        public int? ProjectId { get; set; }
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
        /// 日期
        /// </summary>
        private DateTime? _ServerDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 日期
        /// </summary>
        [DisplayName("日期")]
        
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
        /// 房间
        /// </summary>
        private int? _RoomId ;
        /// <summary>
        /// 房间
        /// </summary>
        [DisplayName("房间")]
        
        public int? RoomId
        {
            set { _RoomId = value; }
            get { return _RoomId; }
        }
        
         
        
        /// <summary>
        /// 房号
        /// </summary>
        private string _RoomNumber  = "";
        /// <summary>
        /// 房号
        /// </summary>
        [DisplayName("房号")]
        
        public string RoomNumber
        {
            set { _RoomNumber = value; }
            get { return _RoomNumber; }
        }
        
         
        
        /// <summary>
        /// 客户
        /// </summary>
        private int? _KeHuId ;
        /// <summary>
        /// 客户
        /// </summary>
        [DisplayName("客户")]
        
        public int? KeHuId
        {
            set { _KeHuId = value; }
            get { return _KeHuId; }
        }
        
         
        
        /// <summary>
        /// 客户名
        /// </summary>
        private string _KeHuName  = "";
        /// <summary>
        /// 客户名
        /// </summary>
        [DisplayName("客户名")]
        
        public string KeHuName
        {
            set { _KeHuName = value; }
            get { return _KeHuName; }
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
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _Createdate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]
        
        public DateTime? Createdate
        {
            set { _Createdate = value; }
            get { return _Createdate; }
        }
        
        private DateTime _CreatedateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateStart
{
set { _CreatedateStart = value; }
get{ return _CreatedateStart; }
}
 private DateTime _CreatedateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateEnd
{
set { _CreatedateEnd = value; }
get{ return _CreatedateEnd; }
}
  
        
        /// <summary>
        /// 选中饮食
        /// </summary>
        private string _SelectDiet  = "";
        /// <summary>
        /// 选中饮食
        /// </summary>
        [DisplayName("选中饮食")]
        
        public string SelectDiet
        {
            set { _SelectDiet = value; }
            get { return _SelectDiet; }
        }
        
         
        
        /// <summary>
        /// 其他
        /// </summary>
        private string _OtherDiet  = "";
        /// <summary>
        /// 其他
        /// </summary>
        [DisplayName("其他")]
        
        public string OtherDiet
        {
            set { _OtherDiet = value; }
            get { return _OtherDiet; }
        }
        
         
        
        /// <summary>
        /// 特殊饮食-说明
        /// </summary>
        private string _Desc  = "";
        /// <summary>
        /// 特殊饮食-说明
        /// </summary>
        [DisplayName("特殊饮食-说明")]
        
        public string Desc
        {
            set { _Desc = value; }
            get { return _Desc; }
        }
        
         
        
        /// <summary>
        /// 忌食
        /// </summary>
        private string _JiShiDesc  = "";
        /// <summary>
        /// 忌食
        /// </summary>
        [DisplayName("忌食")]
        
        public string JiShiDesc
        {
            set { _JiShiDesc = value; }
            get { return _JiShiDesc; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class DietSpecialReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        /// <summary>
        /// 门店确认状态
        /// </summary>
        [DisplayName("门店检查状态")]
        public string MenDianCheckState { get; set; }
        [DisplayName("门店通过时间")]
        public DateTime? MDCheckDate { get; set; }
        [DisplayName("门店通过人")]
        public int? MDCheckPersonId { get; set; }

        [DisplayName("门店通过人名")]
        public string MDCheckPersonName { get; set; }
        [DisplayName("中央检查状态")]
        public string CenterCheckState { get; set; }
        [DisplayName("中央通过时间")]
        public DateTime? CenterCheckDate { get; set; }
        [DisplayName("中央通过人")]
        public int? CenterCheckPersonId { get; set; }

        [DisplayName("中央通过人名")]
        public string CenterCheckPersonName { get; set; }


        [DisplayName("检查状态")]
        public string CheckState { get; set; }
        public int? SetStep { get; set; }
        [DisplayName("保存时间")]
        public DateTime? SaveDate { get; set; }

        [DisplayName("启动时间")]
        public DateTime? StartDate { get; set; }
        public int? SaveId { get; set; }
        [DisplayName("保存人名")]
        public string SaveName { get; set; }
        public int? StartPersonId { get; set; }
        [DisplayName("启动人名")]
        public string StartPersonName { get; set; }
        [NotMapped]
        public bool? IsAppend { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 日期
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
        /// 房间
        /// </summary> 
        public int? RoomId { get;set; } 
	
          
        /// <summary>
        /// 房号
        /// </summary> 
        public string RoomNumber { get;set; } 
	
          
        /// <summary>
        /// 客户
        /// </summary> 
        public int? KeHuId { get;set; } 
	
          
        /// <summary>
        /// 客户名
        /// </summary> 
        public string KeHuName { get;set; } 
	
          
        /// <summary>
        /// 操作员
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作员名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 创建日期_createdate
        /// </summary> 
        public DateTime? Createdate { get;set; } 
	
          private DateTime _CreatedateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateStart
{
set { _CreatedateStart = value; }
get{ return _CreatedateStart; }
}
 private DateTime _CreatedateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CreatedateEnd
{
set { _CreatedateEnd = value; }
get{ return _CreatedateEnd; }
}
 
        /// <summary>
        /// 选中饮食
        /// </summary> 
        public string SelectDiet { get;set; } 
	
          
        /// <summary>
        /// 其他
        /// </summary> 
        public string OtherDiet { get;set; } 
	
          
        /// <summary>
        /// 特殊饮食-说明
        /// </summary> 
        public string Desc { get;set; } 
	
          
        /// <summary>
        /// 忌食
        /// </summary> 
        public string JiShiDesc { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

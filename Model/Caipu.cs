



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
    /// <para>摘要：CaipuModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：Caipu
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>名称</td></tr>
    /// <tr valign="top"><td>3</td><td>CaiType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>菜汤种类</td></tr>
    /// <tr valign="top"><td>4</td><td>CanType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>餐类型</td></tr>
    /// <tr valign="top"><td>5</td><td>Step</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>阶段</td></tr>
    /// <tr valign="top"><td>6</td><td>Peiliao</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>配料</td></tr>
    /// <tr valign="top"><td>7</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>生效日期</td></tr>
    /// <tr valign="top"><td>8</td><td>Createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>9</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员</td></tr>
    /// <tr valign="top"><td>10</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员名</td></tr>
    /// <tr valign="top"><td>11</td><td>Gongxiao</td><td>nvarchar</td><td>450</td><td></td><td></td><td></td><td>√</td><td></td><td>功效</td></tr>
    /// <tr valign="top"><td>12</td><td>ProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>适用门店</td></tr>
    /// <tr valign="top"><td>13</td><td>ProjectName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>适用门店名</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("Caipu")]
    [Serializable]
    public partial class Caipu 
    {
        
        public static string LogClass = "菜谱";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("有效状态")]
        public string ValidState { get; set; }
        [DisplayName("专享客人的id")]
        public int? SpecialCustomerId { get; set; }

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
        /// 菜汤种类
        /// </summary>
        private string _CaiType  = "";
        /// <summary>
        /// 菜汤种类
        /// </summary>
        [DisplayName("菜汤种类")]
        
        public string CaiType
        {
            set { _CaiType = value; }
            get { return _CaiType; }
        }
        
         
        
        /// <summary>
        /// 餐类型
        /// </summary>
        private string _CanType  = "";
        /// <summary>
        /// 餐类型
        /// </summary>
        [DisplayName("餐类型")]
        
        public string CanType
        {
            set { _CanType = value; }
            get { return _CanType; }
        }
        
         
        
        /// <summary>
        /// 阶段
        /// </summary>
      
        /// <summary>
        /// 阶段
        /// </summary>
        [DisplayName("阶段")]
        
        public int? Step { get; set; }
        
         
        
        /// <summary>
        /// 配料
        /// </summary>
        private string _Peiliao  = "";
        /// <summary>
        /// 配料
        /// </summary>
        [DisplayName("配料")]
        
        public string Peiliao
        {
            set { _Peiliao = value; }
            get { return _Peiliao; }
        }
        
         
        
        /// <summary>
        /// 生效日期
        /// </summary>
        private DateTime? _ServerDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 生效日期
        /// </summary>
        [DisplayName("生效日期")]
        
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
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _Createdate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]
        
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
        /// 功效
        /// </summary>
        private string _Gongxiao  = "";
        /// <summary>
        /// 功效
        /// </summary>
        [DisplayName("功效")]
        
        public string Gongxiao
        {
            set { _Gongxiao = value; }
            get { return _Gongxiao; }
        }
        
         
        
        /// <summary>
        /// 适用门店
        /// </summary>
        private int? _ProjectId ;
        /// <summary>
        /// 适用门店
        /// </summary>
        [DisplayName("适用门店")]
        
        public int? ProjectId
        {
            set { _ProjectId = value; }
            get { return _ProjectId; }
        }
        
         
        
        /// <summary>
        /// 适用门店名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 适用门店名
        /// </summary>
        [DisplayName("适用门店名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class CaipuReq:BaseSearchReq
    {
        [DisplayName("有效状态")]
        public string ValidState { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("专享客人的id")]
        public int? SpecialCustomerId { get; set; }
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
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 名称
        /// </summary> 
        public string Name { get;set; } 
	
          
        /// <summary>
        /// 菜汤种类
        /// </summary> 
        public string CaiType { get;set; } 
	
          
        /// <summary>
        /// 餐类型
        /// </summary> 
        public string CanType { get;set; } 
	
          
        /// <summary>
        /// 阶段
        /// </summary> 
        public int? Step { get;set; } 
	
          
        /// <summary>
        /// 配料
        /// </summary> 
        public string Peiliao { get;set; } 
	
          
        /// <summary>
        /// 生效日期
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
        /// 创建时间_createdate
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
        /// 操作员
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作员名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 功效
        /// </summary> 
        public string Gongxiao { get;set; } 
	
          
        /// <summary>
        /// 适用门店名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

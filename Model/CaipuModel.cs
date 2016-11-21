



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
    /// <para>摘要：CaipuModelModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：CaipuModel
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>菜品名</td></tr>
    /// <tr valign="top"><td>3</td><td>CaiType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>菜汤种类</td></tr>
    /// <tr valign="top"><td>4</td><td>CanType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>餐类型</td></tr>
    /// <tr valign="top"><td>5</td><td>Step</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>阶段</td></tr>
    /// <tr valign="top"><td>6</td><td>Peiliao</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>配料</td></tr>
    /// <tr valign="top"><td>7</td><td>ValidState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>有效状态</td></tr>
    /// <tr valign="top"><td>8</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员_optid</td></tr>
    /// <tr valign="top"><td>9</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员_optname</td></tr>
    /// <tr valign="top"><td>10</td><td>Type</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>类型</td></tr>
    /// <tr valign="top"><td>11</td><td>ServerWeekDay</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>服务星期数</td></tr>
    /// <tr valign="top"><td>12</td><td>Gongxiao</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>功效</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("CaipuModel")]
    [Serializable]
    public partial class CaipuModel 
    {
    
        public static string LogClass = "菜谱模版";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("菜谱类型关联")]
        public int TypeId { get; set; }
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
        /// 菜品名
        /// </summary>
        private string _Name  = "";
        /// <summary>
        /// 菜品名
        /// </summary>
        [DisplayName("菜品名")]
        
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
        private int? _Step ;
        /// <summary>
        /// 阶段
        /// </summary>
        [DisplayName("阶段")]
        
        public int? Step
        {
            set { _Step = value; }
            get { return _Step; }
        }
        
         
        
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
        /// 操作员_optid
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作员_optid
        /// </summary>
        [DisplayName("操作员")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作员_optname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作员_optname
        /// </summary>
        [DisplayName("操作员")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 类型
        /// </summary>
        private string _Type  = "";
        /// <summary>
        /// 类型
        /// </summary>
        [DisplayName("类型")]
        
        public string Type
        {
            set { _Type = value; }
            get { return _Type; }
        }
        
         
        
        /// <summary>
        /// 服务星期数
        /// </summary>
        private string _ServerWeekDay  = "";
        /// <summary>
        /// 服务星期数
        /// </summary>
        [DisplayName("服务星期数")]
        
        public string ServerWeekDay
        {
            set { _ServerWeekDay = value; }
            get { return _ServerWeekDay; }
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
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class CaipuModelReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("菜谱类型关联")]
        public int? TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 菜品名
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
        /// 有效状态
        /// </summary> 
        public string ValidState { get;set; } 
	
          
        /// <summary>
        /// 操作员_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作员_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 类型
        /// </summary> 
        public string Type { get;set; } 
	
          
        /// <summary>
        /// 服务星期数
        /// </summary> 
        public string ServerWeekDay { get;set; } 
	
          
        /// <summary>
        /// 功效
        /// </summary> 
        public string Gongxiao { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

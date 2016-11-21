



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using OUDAL.ModelBase;
namespace OUDAL
{
    ///################################################################################################
    /// <summary>
    /// <para>摘要：KeRenPeiCanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：KeRenPeiCan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>CaiPuIds</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>菜谱数据</td></tr>
    /// <tr valign="top"><td>3</td><td>DietSpecialId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户信息</td></tr>
    /// <tr valign="top"><td>4</td><td>LunchSpecial</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>午餐特殊要求</td></tr>
    /// <tr valign="top"><td>5</td><td>SupperSpecial</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>晚餐特殊要求</td></tr>
    /// <tr valign="top"><td>6</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建_createdate</td></tr>
    /// <tr valign="top"><td>7</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名</td></tr>
    /// <tr valign="top"><td>8</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("KeRenPeiCan")]
    [Serializable]
    public partial class KeRenPeiCan 
    {
    
        public static string LogClass = "客人配餐";
        #region -  公共属性  ------------------------------------------------------------

        [NotMapped]
        public List<int> CaiPuIdsInt
        {
            get
            {
                if (string.IsNullOrEmpty(CaiPuIds)) return new List<int>();
                return CaiPuIds.Split(","[0]).Select(c => Convert.ToInt32(c)).ToList();
            }
        }

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
        /// 菜谱数据
        /// </summary>
        private string _CaiPuIds  = "";
        /// <summary>
        /// 菜谱数据
        /// </summary>
        [DisplayName("菜谱数据")]
        
        public string CaiPuIds
        {
            set { _CaiPuIds = value; }
            get { return _CaiPuIds; }
        }
        
         
        
        /// <summary>
        /// 客户信息
        /// </summary>
        private int? _DietSpecialId ;
        /// <summary>
        /// 客户信息
        /// </summary>
        [DisplayName("客户信息")]
        
        public int? DietSpecialId
        {
            set { _DietSpecialId = value; }
            get { return _DietSpecialId; }
        }
        
         
        
        /// <summary>
        /// 午餐特殊要求
        /// </summary>
        private string _LunchSpecial  = "";
        /// <summary>
        /// 午餐特殊要求
        /// </summary>
        [DisplayName("午餐特殊要求")]
        
        public string LunchSpecial
        {
            set { _LunchSpecial = value; }
            get { return _LunchSpecial; }
        }
        
         
        
        /// <summary>
        /// 晚餐特殊要求
        /// </summary>
        private string _SupperSpecial  = "";
        /// <summary>
        /// 晚餐特殊要求
        /// </summary>
        [DisplayName("晚餐特殊要求")]
        
        public string SupperSpecial
        {
            set { _SupperSpecial = value; }
            get { return _SupperSpecial; }
        }
        
         
        
        /// <summary>
        /// 创建_createdate
        /// </summary>
        private DateTime? _CreateDate  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 创建_createdate
        /// </summary>
        [DisplayName("创建")]
        
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
        /// 操作人名
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人名
        /// </summary>
        [DisplayName("操作人名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 操作人
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class KeRenPeiCanReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 菜谱数据
        /// </summary> 
        public string CaiPuIds { get;set; } 
	
          
        /// <summary>
        /// 客户信息
        /// </summary> 
        public int? DietSpecialId { get;set; } 
	
          
        /// <summary>
        /// 午餐特殊要求
        /// </summary> 
        public string LunchSpecial { get;set; } 
	
          
        /// <summary>
        /// 晚餐特殊要求
        /// </summary> 
        public string SupperSpecial { get;set; } 
	
          
        /// <summary>
        /// 创建_createdate
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
        /// 操作人名
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 操作人
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

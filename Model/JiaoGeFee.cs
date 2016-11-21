



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
    /// <para>摘要：JiaoGeFeeModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：JiaoGeFee
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>SearchDateInfo</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>查询时间</td></tr>
    /// <tr valign="top"><td>3</td><td>ShouKuanInfos</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>收款信息</td></tr>
    /// <tr valign="top"><td>4</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>5</td><td>CheckerId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>审核人</td></tr>
    /// <tr valign="top"><td>6</td><td>CheckerName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审核人名</td></tr>
    /// <tr valign="top"><td>7</td><td>CreaterId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>创建者_optid</td></tr>
    /// <tr valign="top"><td>8</td><td>CreaterName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>创建人_optname</td></tr>
    /// <tr valign="top"><td>9</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>10</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>11</td><td>CheckDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>审核日期</td></tr>
    /// <tr valign="top"><td>12</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("JiaoGeFee")]
    [Serializable]
    public partial class JiaoGeFee 
    {
    
        public static string LogClass = "交割金";
        [NotMapped]
        public List<DDShouKuan> DdShouKuans
        {
            get
            {
                List<DDShouKuan> ddList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DDShouKuan>>(ShouKuanInfos);
                return ddList;
            }
        }

        #region -  公共属性  ------------------------------------------------------------
        public string ValidState { get; set; }

        [DisplayName("多余备用金")]
        public decimal? BeiYongMoney { get; set; }
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
        /// 查询时间
        /// </summary>
        private string _SearchDateInfo  = "";
        /// <summary>
        /// 查询时间
        /// </summary>
        [DisplayName("查询时间")]
        
        public string SearchDateInfo
        {
            set { _SearchDateInfo = value; }
            get { return _SearchDateInfo; }
        }
        
         
        
        /// <summary>
        /// 收款信息
        /// </summary>
        private string _ShouKuanInfos  = "";
        /// <summary>
        /// 收款信息
        /// </summary>
        [DisplayName("收款信息")]
        
        public string ShouKuanInfos
        {
            set { _ShouKuanInfos = value; }
            get { return _ShouKuanInfos; }
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
        /// 审核人
        /// </summary>
        private int? _CheckerId ;
        /// <summary>
        /// 审核人
        /// </summary>
        [DisplayName("确认人")]
        
        public int? CheckerId
        {
            set { _CheckerId = value; }
            get { return _CheckerId; }
        }
        
         
        
        /// <summary>
        /// 审核人名
        /// </summary>
        private string _CheckerName  = "";
        /// <summary>
        /// 审核人名
        /// </summary>
        [DisplayName("确认人名")]
        
        public string CheckerName
        {
            set { _CheckerName = value; }
            get { return _CheckerName; }
        }
        
         
        
        /// <summary>
        /// 创建者_optid
        /// </summary>
        private int? _CreaterId ;
        /// <summary>
        /// 创建者_optid
        /// </summary>
        [DisplayName("创建者")]
        
        public int? CreaterId
        {
            set { _CreaterId = value; }
            get { return _CreaterId; }
        }
        
         
        
        /// <summary>
        /// 创建人_optname
        /// </summary>
        private string _CreaterName  = "";
        /// <summary>
        /// 创建人_optname
        /// </summary>
        [DisplayName("创建人")]
        
        public string CreaterName
        {
            set { _CreaterName = value; }
            get { return _CreaterName; }
        }
        
         
        
        /// <summary>
        /// 门店_projectid
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 门店_projectid
        /// </summary>
        [DisplayName("门店")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        [DisplayName("门店名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 审核日期
        /// </summary>
        private DateTime? _CheckDate ;
        /// <summary>
        /// 审核日期
        /// </summary>
        [DisplayName("确认交割日期")]
        
        public DateTime? CheckDate
        {
            set { _CheckDate = value; }
            get { return _CheckDate; }
        }
        
        private DateTime _CheckDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CheckDateStart
{
set { _CheckDateStart = value; }
get{ return _CheckDateStart; }
}
 private DateTime _CheckDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CheckDateEnd
{
set { _CheckDateEnd = value; }
get{ return _CheckDateEnd; }
}
  
        
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _CreateDate ;
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
  
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JiaoGeFeeReq:BaseSearchReq
    {
        public string ValidState { get; set; }
        [DisplayName("多余备用金")]
        public decimal? BeiYongMoney { get; set; }
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 查询时间
        /// </summary> 
        public string SearchDateInfo { get;set; } 
	
          
        /// <summary>
        /// 收款信息
        /// </summary> 
        public string ShouKuanInfos { get;set; } 
	
          
        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get;set; } 
	
          
        /// <summary>
        /// 审核人
        /// </summary> 
        public int? CheckerId { get;set; } 
	
          
        /// <summary>
        /// 审核人名
        /// </summary> 
        public string CheckerName { get;set; } 
	
          
        /// <summary>
        /// 创建者_optid
        /// </summary> 
        public int? CreaterId { get;set; } 
	
          
        /// <summary>
        /// 创建人_optname
        /// </summary> 
        public string CreaterName { get;set; } 
	
          
        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 审核日期
        /// </summary> 
        public DateTime? CheckDate { get;set; } 
	
          private DateTime _CheckDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CheckDateStart
{
set { _CheckDateStart = value; }
get{ return _CheckDateStart; }
}
 private DateTime _CheckDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CheckDateEnd
{
set { _CheckDateEnd = value; }
get{ return _CheckDateEnd; }
}
 
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
 
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

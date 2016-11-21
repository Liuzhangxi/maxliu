



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
    /// <para>摘要：ChildCareDetailModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：ChildCareDetail
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>Time</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>时间</td></tr>
    /// <tr valign="top"><td>3</td><td>SelfWeiCount</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>亲喂(次)</td></tr>
    /// <tr valign="top"><td>4</td><td>MomMilk</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>母乳(ml)</td></tr>
    /// <tr valign="top"><td>5</td><td>FormulaMilk</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>配方(ml)</td></tr>
    /// <tr valign="top"><td>6</td><td>WeiYao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>喂药</td></tr>
    /// <tr valign="top"><td>7</td><td>WeiShui</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>喂水(ml)</td></tr>
    /// <tr valign="top"><td>8</td><td>DaBian</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>大便</td></tr>
    /// <tr valign="top"><td>9</td><td>XiaoBian</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>小便</td></tr>
    /// <tr valign="top"><td>10</td><td>SignUserId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>签名用户</td></tr>
    /// <tr valign="top"><td>11</td><td>SignUserName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>签名用户名</td></tr>
    /// <tr valign="top"><td>12</td><td>Mark</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// <tr valign="top"><td>13</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者_optid</td></tr>
    /// <tr valign="top"><td>14</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者名_optname</td></tr>
    /// <tr valign="top"><td>15</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>服务日期</td></tr>
    /// <tr valign="top"><td>16</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>17</td><td>KeHuid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户</td></tr>
    /// <tr valign="top"><td>18</td><td>KeHuName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名</td></tr>
    /// <tr valign="top"><td>19</td><td>ChildDesc</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>小孩描述</td></tr>
    /// <tr valign="top"><td>20</td><td>ChildCareId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("ChildCareDetail")]
    [Serializable]
    public partial class ChildCareDetail 
    {
    
        public static string LogClass = "宝宝护理明细";
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
        /// 时间
        /// </summary>
        private string _Time  = "";
        /// <summary>
        /// 时间
        /// </summary>
        [DisplayName("时间")]
        
        public string Time
        {
            set { _Time = value; }
            get { return _Time; }
        }
        
         
        
        /// <summary>
        /// 亲喂(次)
        /// </summary>
        private int? _SelfWeiCount ;
        /// <summary>
        /// 亲喂(次)
        /// </summary>
        [DisplayName("亲喂(次)")]
        
        public int? SelfWeiCount
        {
            set { _SelfWeiCount = value; }
            get { return _SelfWeiCount; }
        }
        
         
        
        /// <summary>
        /// 母乳(ml)
        /// </summary>
        private int? _MomMilk ;
        /// <summary>
        /// 母乳(ml)
        /// </summary>
        [DisplayName("母乳(ml)")]
        
        public int? MomMilk
        {
            set { _MomMilk = value; }
            get { return _MomMilk; }
        }
        
         
        
        /// <summary>
        /// 配方(ml)
        /// </summary>
        private int? _FormulaMilk ;
        /// <summary>
        /// 配方(ml)
        /// </summary>
        [DisplayName("配方(ml)")]
        
        public int? FormulaMilk
        {
            set { _FormulaMilk = value; }
            get { return _FormulaMilk; }
        }
        
         
        
        /// <summary>
        /// 喂药
        /// </summary>
        private string _WeiYao  = "";
        /// <summary>
        /// 喂药
        /// </summary>
        [DisplayName("喂药")]
        
        public string WeiYao
        {
            set { _WeiYao = value; }
            get { return _WeiYao; }
        }
        
         
        
        /// <summary>
        /// 喂水(ml)
        /// </summary>
        private int? _WeiShui ;
        /// <summary>
        /// 喂水(ml)
        /// </summary>
        [DisplayName("喂水(ml)")]
        
        public int? WeiShui
        {
            set { _WeiShui = value; }
            get { return _WeiShui; }
        }
        
         
        
        /// <summary>
        /// 大便
        /// </summary>
        private string _DaBian  = "";
        /// <summary>
        /// 大便
        /// </summary>
        [DisplayName("大便")]
        
        public string DaBian
        {
            set { _DaBian = value; }
            get { return _DaBian; }
        }
        
         
        
        /// <summary>
        /// 小便
        /// </summary>
        private string _XiaoBian  = "";
        /// <summary>
        /// 小便
        /// </summary>
        [DisplayName("小便")]
        
        public string XiaoBian
        {
            set { _XiaoBian = value; }
            get { return _XiaoBian; }
        }
        
         
        
        /// <summary>
        /// 签名用户
        /// </summary>
        private int? _SignUserId ;
        /// <summary>
        /// 签名用户
        /// </summary>
        [DisplayName("签名用户")]
        
        public int? SignUserId
        {
            set { _SignUserId = value; }
            get { return _SignUserId; }
        }
        
         
        
        /// <summary>
        /// 签名用户名
        /// </summary>
        private string _SignUserName  = "";
        /// <summary>
        /// 签名用户名
        /// </summary>
        [DisplayName("签名用户名")]
        
        public string SignUserName
        {
            set { _SignUserName = value; }
            get { return _SignUserName; }
        }
        
         
        
        /// <summary>
        /// 备注
        /// </summary>
        private string _Mark  = "";
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        
        public string Mark
        {
            set { _Mark = value; }
            get { return _Mark; }
        }
        
         
        
        /// <summary>
        /// 操作者_optid
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作者_optid
        /// </summary>
        [DisplayName("操作者")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作者名_optname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作者名_optname
        /// </summary>
        [DisplayName("操作者名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 服务日期
        /// </summary>
        private DateTime? _ServerDate ;
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
        
         
        
        /// <summary>
        /// 客户
        /// </summary>
        private int? _KeHuid ;
        /// <summary>
        /// 客户
        /// </summary>
        [DisplayName("客户")]
        
        public int? KeHuid
        {
            set { _KeHuid = value; }
            get { return _KeHuid; }
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
        /// 小孩描述
        /// </summary>
        private string _ChildDesc  = "";
        /// <summary>
        /// 小孩描述
        /// </summary>
        [DisplayName("小孩描述")]
        
        public string ChildDesc
        {
            set { _ChildDesc = value; }
            get { return _ChildDesc; }
        }
        
         
        
        /// <summary>
        /// 
        /// </summary>
        private int? _ChildCareId ;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ChildCareId")]
        
        public int? ChildCareId
        {
            set { _ChildCareId = value; }
            get { return _ChildCareId; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class ChildCareDetailReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 时间
        /// </summary> 
        public string Time { get;set; } 
	
          
        /// <summary>
        /// 亲喂(次)
        /// </summary> 
        public int? SelfWeiCount { get;set; } 
	
          
        /// <summary>
        /// 母乳(ml)
        /// </summary> 
        public int? MomMilk { get;set; } 
	
          
        /// <summary>
        /// 配方(ml)
        /// </summary> 
        public int? FormulaMilk { get;set; } 
	
          
        /// <summary>
        /// 喂药
        /// </summary> 
        public string WeiYao { get;set; } 
	
          
        /// <summary>
        /// 喂水(ml)
        /// </summary> 
        public int? WeiShui { get;set; } 
	
          
        /// <summary>
        /// 大便
        /// </summary> 
        public string DaBian { get;set; } 
	
          
        /// <summary>
        /// 小便
        /// </summary> 
        public string XiaoBian { get;set; } 
	
          
        /// <summary>
        /// 签名用户
        /// </summary> 
        public int? SignUserId { get;set; } 
	
          
        /// <summary>
        /// 签名用户名
        /// </summary> 
        public string SignUserName { get;set; } 
	
          
        /// <summary>
        /// 备注
        /// </summary> 
        public string Mark { get;set; } 
	
          
        /// <summary>
        /// 操作者_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作者名_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
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
        /// 客户
        /// </summary> 
        public int? KeHuid { get;set; } 
	
          
        /// <summary>
        /// 客户名
        /// </summary> 
        public string KeHuName { get;set; } 
	
          
        /// <summary>
        /// 小孩描述
        /// </summary> 
        public string ChildDesc { get;set; } 
	
          
        /// <summary>
        /// 
        /// </summary> 
        public int? ChildCareId { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

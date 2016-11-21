



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using DataAnnotationsExtensions;
using OUDAL.ModelBase;
namespace OUDAL
{
    ///################################################################################################
    /// <summary>
    /// <para>摘要：PaiBanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：PaiBan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>3</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>4</td><td>CreateDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>5</td><td>EmployeeId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>雇员</td></tr>
    /// <tr valign="top"><td>6</td><td>EmployeeName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>雇员名</td></tr>
    /// <tr valign="top"><td>7</td><td>BanType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>排班类型名</td></tr>
    /// <tr valign="top"><td>8</td><td>BanHours</td><td>decimal</td><td>9</td><td>18,1</td><td></td><td></td><td>√</td><td></td><td>基础小时数</td></tr>
    /// <tr valign="top"><td>9</td><td>ServerDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>服务日期</td></tr>
    /// <tr valign="top"><td>10</td><td>AddHours</td><td>decimal</td><td>9</td><td>18,1</td><td></td><td></td><td>√</td><td></td><td>增减小时数</td></tr>
    /// <tr valign="top"><td>11</td><td>DayType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>日类型(节假日，普通)</td></tr>
    /// <tr valign="top"><td>12</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>项目</td></tr>
    /// <tr valign="top"><td>13</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>项目名</td></tr>
    /// <tr valign="top"><td>14</td><td>BanTypeId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>排班类型</td></tr>
    /// <tr valign="top"><td>15</td><td>WashHead</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>洗头</td></tr>
    /// <tr valign="top"><td>16</td><td>WashBody</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>擦身</td></tr>
    /// <tr valign="top"><td>17</td><td>KaiNai</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>开奶收费</td></tr>
    /// <tr valign="top"><td>18</td><td>KaiNaiFree</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>免费开奶</td></tr>
    /// <tr valign="top"><td>19</td><td>KuangGong</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>矿工</td></tr>
    /// <tr valign="top"><td>20</td><td>ChiDao</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>迟到</td></tr>
    /// <tr valign="top"><td>21</td><td>QueKa</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>缺卡</td></tr>
    /// <tr valign="top"><td>22</td><td>JiangLi</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>奖励</td></tr>
    /// <tr valign="top"><td>23</td><td>Mark</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("PaiBan")]
    [Serializable]
    public partial class PaiBan 
    {
        [DisplayName("请假小时数")]
        [Min(0)]
        public decimal? QinJiaHours { get; set; }
        [DisplayName("假期类型")]
        public string QinJiaType { get; set; }

        [DisplayName("状态")]
        public string State { get; set; }
        public static string LogClass = "排班信息";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("假日小时数")]
        public decimal? HolidayHours { get; set; }
        [DisplayName("正常工作小时数")]
        public decimal? NormalHours { get; set; }
        
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
        /// 操作人_optid
        /// </summary>
        private int? _OptId ;
        /// <summary>
        /// 操作人_optid
        /// </summary>
        [DisplayName("操作人")]
        
        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }
        
         
        
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        [DisplayName("操作人名")]
        
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _CreateDate ;
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
        /// 雇员
        /// </summary>
        private int? _EmployeeId ;
        /// <summary>
        /// 雇员
        /// </summary>
        [DisplayName("雇员")]
        
        public int? EmployeeId
        {
            set { _EmployeeId = value; }
            get { return _EmployeeId; }
        }
        
         
        
        /// <summary>
        /// 雇员名
        /// </summary>
        private string _EmployeeName  = "";
        /// <summary>
        /// 雇员名
        /// </summary>
        [DisplayName("雇员名")]
        
        public string EmployeeName
        {
            set { _EmployeeName = value; }
            get { return _EmployeeName; }
        }
        
         
        
        /// <summary>
        /// 排班类型名
        /// </summary>
        private string _BanType  = "";
        /// <summary>
        /// 排班类型名
        /// </summary>
        [DisplayName("排班类型名")]
        
        public string BanType
        {
            set { _BanType = value; }
            get { return _BanType; }
        }
        
         
        
        /// <summary>
        /// 基础小时数
        /// </summary>
        private decimal? _BanHours ;
        /// <summary>
        /// 基础小时数
        /// </summary>
        [DisplayName("基础小时数")]
        
        public decimal? BanHours
        {
            set { _BanHours = value; }
            get { return _BanHours; }
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
        /// 增减小时数
        /// </summary>
        private decimal? _AddHours ;
        /// <summary>
        /// 增减小时数
        /// </summary>
        [DisplayName("增减小时数")]
        
        public decimal? AddHours
        {
            set { _AddHours = value; }
            get { return _AddHours; }
        }
        
         
        
        /// <summary>
        /// 日类型(节假日，普通)
        /// </summary>
        private string _DayType  = "";
        /// <summary>
        /// 日类型(节假日，普通)
        /// </summary>
        [DisplayName("日类型(节假日，普通)")]
        
        public string DayType
        {
            set { _DayType = value; }
            get { return _DayType; }
        }
        
         
        
        /// <summary>
        /// 项目
        /// </summary>
        private int? _projectid ;
        /// <summary>
        /// 项目
        /// </summary>
        [DisplayName("项目")]
        
        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }
        
         
        
        /// <summary>
        /// 项目名
        /// </summary>
        private string _ProjectName  = "";
        /// <summary>
        /// 项目名
        /// </summary>
        [DisplayName("项目名")]
        
        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }
        
         
        
        /// <summary>
        /// 排班类型
        /// </summary>
        private int? _BanTypeId ;
        /// <summary>
        /// 排班类型
        /// </summary>
        [DisplayName("排班类型")]
        
        public int? BanTypeId
        {
            set { _BanTypeId = value; }
            get { return _BanTypeId; }
        }
        
         
        
        /// <summary>
        /// 洗头
        /// </summary>
        private int? _WashHead ;
        /// <summary>
        /// 洗头
        /// </summary>
        [DisplayName("洗头")]
        
        public int? WashHead
        {
            set { _WashHead = value; }
            get { return _WashHead; }
        }
        
         
        
        /// <summary>
        /// 擦身
        /// </summary>
        private int? _WashBody ;
        /// <summary>
        /// 擦身
        /// </summary>
        [DisplayName("擦身")]
        
        public int? WashBody
        {
            set { _WashBody = value; }
            get { return _WashBody; }
        }
        
         
        
        /// <summary>
        /// 开奶收费
        /// </summary>
        private decimal? _KaiNai ;
        /// <summary>
        /// 开奶收费
        /// </summary>
        [DisplayName("开奶收费")]
        
        public decimal? KaiNai
        {
            set { _KaiNai = value; }
            get { return _KaiNai; }
        }
        
         
        
        /// <summary>
        /// 免费开奶
        /// </summary>
        private string _KaiNaiFree  = "";
        /// <summary>
        /// 免费开奶
        /// </summary>
        [DisplayName("免费开奶")]
        
        public string KaiNaiFree
        {
            set { _KaiNaiFree = value; }
            get { return _KaiNaiFree; }
        }



        /// <summary>
        /// 旷工
        /// </summary>
        private string _KuangGong  = "";
        /// <summary>
        /// 旷工
        /// </summary>
        [DisplayName("旷工")]
        
        public string KuangGong
        {
            set { _KuangGong = value; }
            get { return _KuangGong; }
        }
        
         
        
        /// <summary>
        /// 迟到
        /// </summary>
        private decimal? _ChiDao ;
        /// <summary>
        /// 迟到
        /// </summary>
        [DisplayName("迟到")]
        
        public decimal? ChiDao
        {
            set { _ChiDao = value; }
            get { return _ChiDao; }
        }
        
         
        
        /// <summary>
        /// 缺卡
        /// </summary>
        private string _QueKa  = "";
        /// <summary>
        /// 缺卡
        /// </summary>
        [DisplayName("缺卡")]
        
        public string QueKa
        {
            set { _QueKa = value; }
            get { return _QueKa; }
        }
        
         
        
        /// <summary>
        /// 奖励
        /// </summary>
        private decimal? _JiangLi ;
        /// <summary>
        /// 奖励
        /// </summary>
        [DisplayName("奖励")]
        
        public decimal? JiangLi
        {
            set { _JiangLi = value; }
            get { return _JiangLi; }
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
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class PaiBanReq:BaseSearchReq
    {
        [DisplayName("请假小时数")]
        public decimal? QinJiaHours { get; set; }
        [DisplayName("假期类型")]
        public string QinJiaType { get; set; }
        public string State { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        public decimal? HolidayHours { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get;set; } 
	
          
        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string OptName { get;set; } 
	
          
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
        /// 雇员
        /// </summary> 
        public int? EmployeeId { get;set; } 
	
          
        /// <summary>
        /// 雇员名
        /// </summary> 
        public string EmployeeName { get;set; } 
	
          
        /// <summary>
        /// 排班类型名
        /// </summary> 
        public string BanType { get;set; } 
	
          
        /// <summary>
        /// 基础小时数
        /// </summary> 
        public decimal? BanHours { get;set; } 
	
          
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
        /// 增减小时数
        /// </summary> 
        public decimal? AddHours { get;set; } 
	
          
        /// <summary>
        /// 日类型(节假日，普通)
        /// </summary> 
        public string DayType { get;set; } 
	
          
        /// <summary>
        /// 项目名
        /// </summary> 
        public string ProjectName { get;set; } 
	
          
        /// <summary>
        /// 排班类型
        /// </summary> 
        public int? BanTypeId { get;set; } 
	
          
        /// <summary>
        /// 洗头
        /// </summary> 
        public int? WashHead { get;set; } 
	
          
        /// <summary>
        /// 擦身
        /// </summary> 
        public int? WashBody { get;set; } 
	
          
        /// <summary>
        /// 开奶收费
        /// </summary> 
        public decimal? KaiNai { get;set; } 
	
          
        /// <summary>
        /// 免费开奶
        /// </summary> 
        public string KaiNaiFree { get;set; } 
	
          
        /// <summary>
        /// 矿工
        /// </summary> 
        public string KuangGong { get;set; } 
	
          
        /// <summary>
        /// 迟到
        /// </summary> 
        public decimal? ChiDao { get;set; } 
	
          
        /// <summary>
        /// 缺卡
        /// </summary> 
        public string QueKa { get;set; } 
	
          
        /// <summary>
        /// 奖励
        /// </summary> 
        public decimal? JiangLi { get;set; } 
	
          
        /// <summary>
        /// 备注
        /// </summary> 
        public string Mark { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

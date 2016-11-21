



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
    /// <para>摘要：KhHeTongModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：KhHeTong
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>KhID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>客户ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>KhName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>客户名字</td></tr>
    /// <tr valign="top"><td>4</td><td>KhPhone</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>客户联系电话_searchhidden</td></tr>
    /// <tr valign="top"><td>5</td><td>KhYuChanQi</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>预产期_searchhidden</td></tr>
    /// <tr valign="top"><td>6</td><td>KhHTNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>合同编号</td></tr>
    /// <tr valign="top"><td>7</td><td>KhHTSerialNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>合同序列号_searchhidden</td></tr>
    /// <tr valign="top"><td>8</td><td>KhHTName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>合同名称</td></tr>
    /// <tr valign="top"><td>9</td><td>KhHTHouseStyle</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>合同房型</td></tr>
    /// <tr valign="top"><td>10</td><td>KhHTHouseNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>合同房号_searchhidden</td></tr>
    /// <tr valign="top"><td>11</td><td>KhHTLiveDays</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>入住天数</td></tr>
    /// <tr valign="top"><td>12</td><td>KhHTDingJin</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td></td><td></td><td>合同定金_searchhidden</td></tr>
    /// <tr valign="top"><td>13</td><td>KhHTWeiKuan</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td></td><td></td><td>合同尾款_searchhidden</td></tr>
    /// <tr valign="top"><td>14</td><td>KhHTTotalMoney</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td></td><td></td><td>合同总价</td></tr>
    /// <tr valign="top"><td>15</td><td>KhHTZheKouMoney</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td></td><td></td><td>合同折扣价_searchhidden</td></tr>
    /// <tr valign="top"><td>16</td><td>KhHTRuZhuDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>入住日期</td></tr>
    /// <tr valign="top"><td>17</td><td>KhHTChuSuoDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>出所日期</td></tr>
    /// <tr valign="top"><td>18</td><td>KhHTMuYingBaoXian</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td>√</td><td></td><td>母婴保险价格_searchhidden</td></tr>
    /// <tr valign="top"><td>19</td><td>KhHTXieYiShiXiang</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>协议事项_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>20</td><td>KhHTStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>合同状态</td></tr>
    /// <tr valign="top"><td>21</td><td>KhHTSales</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>销售顾问_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>22</td><td>ProjectID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>所属项目公司Id</td></tr>
    /// <tr valign="top"><td>23</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>24</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("KhHeTong")]
    [Serializable]
    public partial class KhHeTong
    {

        public static string LogClass = "客户合同表";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("服务节点状态")]
        public string JieDianCheckState { get; set; }

        [DisplayName("合同确认状态")]
        public string ServerCheckState { get; set; }

        [DisplayName("订单来源")]
        public string DDLaiYuanID { get; set; }



        [DisplayName("销售的系统ID")]
        public int? KhHTSalesSystemId { get; set; }

        [DisplayName("销售人员")]
        public int? KhHTSalesID { get; set; }

        [DisplayName("签约时间")]
        public DateTime? SignDateTime { get; set; }
        [DisplayName("宝宝个数")]
        [Min(0)]
        public int? ChildCount { get; set; }


        [DisplayName("房间")]
        public int? KhRoomId { get; set; }
        /// <summary>
        /// seed
        /// </summary>
        private int _id;
        /// <summary>
        /// seed
        /// </summary>
        [Key]
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }



        /// <summary>
        /// 客户ID_listhidden_searchhidden
        /// </summary>
        private int _KhID;
        /// <summary>
        /// 客户ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("客户ID")]
        [Required]
        public int KhID
        {
            set { _KhID = value; }
            get { return _KhID; }
        }



        /// <summary>
        /// 客户名字
        /// </summary>
        private string _KhName = "";
        /// <summary>
        /// 客户名字
        /// </summary>
        [DisplayName("客户名字")]
        [Required]
        public string KhName
        {
            set { _KhName = value; }
            get { return _KhName; }
        }



        /// <summary>
        /// 客户联系电话_searchhidden
        /// </summary>
        private string _KhPhone = "";
        /// <summary>
        /// 客户联系电话_searchhidden
        /// </summary>
        [DisplayName("客户联系电话")]
        [Required]
        public string KhPhone
        {
            set { _KhPhone = value; }
            get { return _KhPhone; }
        }



        /// <summary>
        /// 预产期_searchhidden
        /// </summary>
        private DateTime _KhYuChanQi = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 预产期_searchhidden
        /// </summary>
        [DisplayName("预产期")]
        [Required]
        public DateTime KhYuChanQi
        {
            set { _KhYuChanQi = value; }
            get { return _KhYuChanQi; }
        }

        private DateTime _KhYuChanQiStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhYuChanQiStart
        {
            set { _KhYuChanQiStart = value; }
            get { return _KhYuChanQiStart; }
        }
        private DateTime _KhYuChanQiEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhYuChanQiEnd
        {
            set { _KhYuChanQiEnd = value; }
            get { return _KhYuChanQiEnd; }
        }


        /// <summary>
        /// 合同编号
        /// </summary>
        private string _KhHTNumber = "";
        /// <summary>
        /// 合同编号
        /// </summary>
        [DisplayName("合同编号")]

        public string KhHTNumber
        {
            set { _KhHTNumber = value; }
            get { return _KhHTNumber; }
        }



        /// <summary>
        /// 合同序列号_searchhidden
        /// </summary>
        private string _KhHTSerialNumber = "";
        /// <summary>
        /// 合同序列号_searchhidden
        /// </summary>
        [DisplayName("合同序列号")]

        public string KhHTSerialNumber
        {
            set { _KhHTSerialNumber = value; }
            get { return _KhHTSerialNumber; }
        }



        /// <summary>
        /// 合同名称
        /// </summary>
        private string _KhHTName = "";
        /// <summary>
        /// 合同名称
        /// </summary>
        [DisplayName("合同名称")]

        public string KhHTName
        {
            set { _KhHTName = value; }
            get { return _KhHTName; }
        }



        /// <summary>
        /// 合同房型
        /// </summary>
        private string _KhHTHouseStyle = "";
        /// <summary>
        /// 合同房型
        /// </summary>
        [DisplayName("合同房型")]
        [Required]
        public string KhHTHouseStyle
        {
            set { _KhHTHouseStyle = value; }
            get { return _KhHTHouseStyle; }
        }



        /// <summary>
        /// 合同房号_searchhidden
        /// </summary>
        private string _KhHTHouseNumber = "";
        /// <summary>
        /// 合同房号_searchhidden
        /// </summary>
        [DisplayName("合同房号")]

        public string KhHTHouseNumber
        {
            set { _KhHTHouseNumber = value; }
            get { return _KhHTHouseNumber; }
        }



        /// <summary>
        /// 入住天数
        /// </summary>
        private int _KhHTLiveDays;
        /// <summary>
        /// 入住天数
        /// </summary>
        [DisplayName("入住天数")]
        [Required]
        public int KhHTLiveDays
        {
            set { _KhHTLiveDays = value; }
            get { return _KhHTLiveDays; }
        }



        /// <summary>
        /// 合同定金_searchhidden
        /// </summary>
        private decimal _KhHTDingJin;
        /// <summary>
        /// 合同定金_searchhidden
        /// </summary>
        [DisplayName("合同定金")]
        [Required]
        public decimal KhHTDingJin
        {
            set { _KhHTDingJin = value; }
            get { return _KhHTDingJin; }
        }



        /// <summary>
        /// 合同尾款_searchhidden
        /// </summary>
        private decimal _KhHTWeiKuan;
        /// <summary>
        /// 合同尾款_searchhidden
        /// </summary>
        [DisplayName("合同尾款")]
        [Required]
        public decimal KhHTWeiKuan
        {
            set { _KhHTWeiKuan = value; }
            get { return _KhHTWeiKuan; }
        }



        /// <summary>
        /// 合同总价
        /// </summary>
        private decimal _KhHTTotalMoney;
        /// <summary>
        /// 合同总价
        /// </summary>
        [DisplayName("合同实际价")]
        [Required]
        public decimal KhHTTotalMoney
        {
            set { _KhHTTotalMoney = value; }
            get { return _KhHTTotalMoney; }
        }



        /// <summary>
        /// 合同折扣价_searchhidden
        /// </summary>
        private decimal _KhHTZheKouMoney;
        /// <summary>
        /// 合同套餐价
        /// </summary>
        [DisplayName("合同套餐价")]
        [Required]
        public decimal KhHTZheKouMoney
        {
            set { _KhHTZheKouMoney = value; }
            get { return _KhHTZheKouMoney; }
        }



        /// <summary>
        /// 入住日期
        /// </summary>
        private DateTime _KhHTRuZhuDate;
        /// <summary>
        /// 入住日期
        /// </summary>
        [DisplayName("入住日期")]
        [Required]
        public DateTime KhHTRuZhuDate
        {
            set { _KhHTRuZhuDate = value; }
            get { return _KhHTRuZhuDate; }
        }

        private DateTime _KhHTRuZhuDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTRuZhuDateStart
        {
            set { _KhHTRuZhuDateStart = value; }
            get { return _KhHTRuZhuDateStart; }
        }
        private DateTime _KhHTRuZhuDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTRuZhuDateEnd
        {
            set { _KhHTRuZhuDateEnd = value; }
            get { return _KhHTRuZhuDateEnd; }
        }


        /// <summary>
        /// 出所日期
        /// </summary>
        private DateTime _KhHTChuSuoDate;
        /// <summary>
        /// 出所日期
        /// </summary>
        [DisplayName("出所日期")]
        [Required]
        public DateTime KhHTChuSuoDate
        {
            set { _KhHTChuSuoDate = value; }
            get { return _KhHTChuSuoDate; }
        }

        private DateTime _KhHTChuSuoDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTChuSuoDateStart
        {
            set { _KhHTChuSuoDateStart = value; }
            get { return _KhHTChuSuoDateStart; }
        }
        private DateTime _KhHTChuSuoDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTChuSuoDateEnd
        {
            set { _KhHTChuSuoDateEnd = value; }
            get { return _KhHTChuSuoDateEnd; }
        }


        /// <summary>
        /// 母婴保险价格_searchhidden
        /// </summary>
        private decimal? _KhHTMuYingBaoXian;
        /// <summary>
        /// 母婴保险价格_searchhidden
        /// </summary>
        [DisplayName("母婴保险价格")]

        public decimal? KhHTMuYingBaoXian
        {
            set { _KhHTMuYingBaoXian = value; }
            get { return _KhHTMuYingBaoXian; }
        }



        /// <summary>
        /// 协议事项_listhidden_searchhidden
        /// </summary>
        private string _KhHTXieYiShiXiang = "";
        /// <summary>
        /// 协议事项_listhidden_searchhidden
        /// </summary>
        [DisplayName("协议事项")]

        public string KhHTXieYiShiXiang
        {
            set { _KhHTXieYiShiXiang = value; }
            get { return _KhHTXieYiShiXiang; }
        }



        /// <summary>
        /// 合同状态
        /// </summary>
        private int _KhHTStateID;
        /// <summary>
        /// 合同状态
        /// </summary>
        [DisplayName("合同状态")]
        [Required]
        public int KhHTStateID
        {
            set { _KhHTStateID = value; }
            get { return _KhHTStateID; }
        }



        /// <summary>
        /// 销售顾问_listhidden_searchhidden
        /// </summary>
        private string _KhHTSales = "";
        /// <summary>
        /// 销售顾问_listhidden_searchhidden
        /// </summary>
        [DisplayName("销售顾问")]

        public string KhHTSales
        {
            set { _KhHTSales = value; }
            get { return _KhHTSales; }
        }



        /// <summary>
        /// 所属项目公司Id
        /// </summary>
        private int _ProjectID;
        /// <summary>
        /// 所属项目公司Id
        /// </summary>
        [DisplayName("所属门店")]
        [Required]
        public int ProjectID
        {
            set { _ProjectID = value; }
            get { return _ProjectID; }
        }
        [DisplayName("所属门店名")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        [DisplayName("操作人")]
        [Required]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }



        /// <summary>
        /// 操作时间_createdate_listhidden_searchhidden
        /// </summary>
        private DateTime _optDateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间_createdate_listhidden_searchhidden
        /// </summary>
        [DisplayName("操作时间")]
        [Required]
        public DateTime optDateTime
        {
            set { _optDateTime = value; }
            get { return _optDateTime; }
        }

        private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeStart
        {
            set { _optDateTimeStart = value; }
            get { return _optDateTimeStart; }
        }
        private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeEnd
        {
            set { _optDateTimeEnd = value; }
            get { return _optDateTimeEnd; }
        }



        #endregion ----------------------------------------------------------------------
    }

    public partial class KhHeTongReq : BaseSearchReq
    {
        [DisplayName("节点确认状态")]
        public string JieDianCheckState { get; set; }

        [DisplayName("订单来源")]
        public string DDLaiYuanID { get; set; }
        [DisplayName("销售的系统ID")]
        public int? KhHTSalesSystemId { get; set; }

        [DisplayName("销售人员表ID")]
        public int? KhHTSalesID { get; set; }
        private DateTime _SignDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime SignDateTimeStart
        {
            set { _SignDateTimeStart = value; }
            get { return _SignDateTimeStart; }
        }
        private DateTime _SignDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime SignDateTimeEnd
        {
            set { _SignDateTimeEnd = value; }
            get { return _SignDateTimeEnd; }
        }


        [DisplayName("签约时间")]
        public DateTime? SignDateTime { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("宝宝个数")]
        public int? ChildCount { get; set; }
        public string projectids { get; set; }
        [DisplayName("房间")]
        public int? KhRoomId { get; set; }
        public string ProjectName { get; set; }
        /// <summary>
        /// seed
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 客户ID_listhidden_searchhidden
        /// </summary> 
        public int? KhID { get; set; }


        /// <summary>
        /// 客户名字
        /// </summary> 
        public string KhName { get; set; }


        /// <summary>
        /// 客户联系电话_searchhidden
        /// </summary> 
        public string KhPhone { get; set; }


        /// <summary>
        /// 预产期_searchhidden
        /// </summary> 
        public DateTime? KhYuChanQi { get; set; }

        private DateTime _KhYuChanQiStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhYuChanQiStart
        {
            set { _KhYuChanQiStart = value; }
            get { return _KhYuChanQiStart; }
        }
        private DateTime _KhYuChanQiEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhYuChanQiEnd
        {
            set { _KhYuChanQiEnd = value; }
            get { return _KhYuChanQiEnd; }
        }

        /// <summary>
        /// 合同编号
        /// </summary> 
        public string KhHTNumber { get; set; }


        /// <summary>
        /// 合同序列号_searchhidden
        /// </summary> 
        public string KhHTSerialNumber { get; set; }


        /// <summary>
        /// 合同名称
        /// </summary> 
        public string KhHTName { get; set; }


        /// <summary>
        /// 合同房型
        /// </summary> 
        public string KhHTHouseStyle { get; set; }


        /// <summary>
        /// 合同房号_searchhidden
        /// </summary> 
        public string KhHTHouseNumber { get; set; }


        /// <summary>
        /// 入住天数
        /// </summary> 
        public int? KhHTLiveDays { get; set; }


        /// <summary>
        /// 合同定金_searchhidden
        /// </summary> 
        public decimal? KhHTDingJin { get; set; }


        /// <summary>
        /// 合同尾款_searchhidden
        /// </summary> 
        public decimal? KhHTWeiKuan { get; set; }


        /// <summary>
        /// 合同总价
        /// </summary> 
        public decimal? KhHTTotalMoney { get; set; }


        /// <summary>
        /// 合同折扣价_searchhidden
        /// </summary> 
        public decimal? KhHTZheKouMoney { get; set; }


        /// <summary>
        /// 入住日期
        /// </summary> 
        public DateTime? KhHTRuZhuDate { get; set; }

        private DateTime _KhHTRuZhuDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTRuZhuDateStart
        {
            set { _KhHTRuZhuDateStart = value; }
            get { return _KhHTRuZhuDateStart; }
        }
        private DateTime _KhHTRuZhuDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTRuZhuDateEnd
        {
            set { _KhHTRuZhuDateEnd = value; }
            get { return _KhHTRuZhuDateEnd; }
        }

        /// <summary>
        /// 出所日期
        /// </summary> 
        public DateTime? KhHTChuSuoDate { get; set; }

        private DateTime _KhHTChuSuoDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTChuSuoDateStart
        {
            set { _KhHTChuSuoDateStart = value; }
            get { return _KhHTChuSuoDateStart; }
        }
        private DateTime _KhHTChuSuoDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhHTChuSuoDateEnd
        {
            set { _KhHTChuSuoDateEnd = value; }
            get { return _KhHTChuSuoDateEnd; }
        }

        /// <summary>
        /// 母婴保险价格_searchhidden
        /// </summary> 
        public decimal? KhHTMuYingBaoXian { get; set; }


        /// <summary>
        /// 协议事项_listhidden_searchhidden
        /// </summary> 
        public string KhHTXieYiShiXiang { get; set; }


        /// <summary>
        /// 合同状态
        /// </summary> 
        public int? KhHTStateID { get; set; }


        /// <summary>
        /// 销售顾问_listhidden_searchhidden
        /// </summary> 
        public string KhHTSales { get; set; }


        /// <summary>
        /// 所属项目公司Id
        /// </summary> 
        //public int? ProjectID { get;set; } 


        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary> 
        public string optName { get; set; }


        /// <summary>
        /// 操作时间_createdate_listhidden_searchhidden
        /// </summary> 
        public DateTime? optDateTime { get; set; }

        private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeStart
        {
            set { _optDateTimeStart = value; }
            get { return _optDateTimeStart; }
        }
        private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeEnd
        {
            set { _optDateTimeEnd = value; }
            get { return _optDateTimeEnd; }
        }



        #endregion ----------------------------------------------------------------------
    }

}

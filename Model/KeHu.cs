



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
    /// <para>摘要：KeHuModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：KeHu
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>KhName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>客户名字</td></tr>
    /// <tr valign="top"><td>3</td><td>KhPhone</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>客户联系电话</td></tr>
    /// <tr valign="top"><td>4</td><td>KhYuChanQi</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>预产期</td></tr>
    /// <tr valign="top"><td>5</td><td>KhHospital</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>生产医院_searchhidden</td></tr>
    /// <tr valign="top"><td>6</td><td>KhIDCardNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>身份证号码_searchhidden</td></tr>
    /// <tr valign="top"><td>7</td><td>KhAddress</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>家庭住址_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>8</td><td>KhFamilyName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>家属姓名_searchhidden</td></tr>
    /// <tr valign="top"><td>9</td><td>KhFamilyPhone</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>家属手机_searchhidden</td></tr>
    /// <tr valign="top"><td>10</td><td>KhFamilyShouRu</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>家庭年收入_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>11</td><td>KhXueXing</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>血型_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>12</td><td>KhXingZuo</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>星座_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>13</td><td>KhXingGe</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>性格_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>14</td><td>KhGuanZhuWangZhan</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>关注网站_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>15</td><td>KhXiuXianFangShi</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>休闲方式_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>16</td><td>KhYinShiXiGuan</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>饮食习惯_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>17</td><td>KhGuoMinLeiFood</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>忌口或过敏类食物_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>18</td><td>KhFamilyYCBS</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>家庭遗传病史_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>19</td><td>KhQiTaBingLi</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>其他病例_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>20</td><td>KhSales</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>销售顾问_searchhidden</td></tr>
    /// <tr valign="top"><td>21</td><td>ProjectID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>所属项目公司Id</td></tr>
    /// <tr valign="top"><td>22</td><td>KhRemarks</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>备注_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>23</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>24</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("KeHu")]
    [Serializable]
    public partial class KeHu
    {
        [DisplayName("ses客户")]
        public int? sesKHID { get; set; }

        [DisplayName("客户状态")]
        public string ValidState { get; set; }
        [NotMapped]
        public string RoomNumberTemp { get; set; }

        [NotMapped]
        public int? RoomIdTemp { get; set; }

        public static string LogClass = "客户信息表";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("系统销售")]
        public int? KhSalesSystemId { get; set; }
        [DisplayName("销售顾问")]
        public int? KhSalesId { get; set; }
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
        /// 客户联系电话
        /// </summary>
        private string _KhPhone = "";
        /// <summary>
        /// 客户联系电话
        /// </summary>
        [DisplayName("客户联系电话")]
        [Required]
        public string KhPhone
        {
            set { _KhPhone = value; }
            get { return _KhPhone; }
        }



        /// <summary>
        /// 预产期
        /// </summary>
        private DateTime _KhYuChanQi;
        /// <summary>
        /// 预产期
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
        /// 生产医院_searchhidden
        /// </summary>
        private string _KhHospital = "";
        /// <summary>
        /// 生产医院_searchhidden
        /// </summary>
        [DisplayName("生产医院")]

        public string KhHospital
        {
            set { _KhHospital = value; }
            get { return _KhHospital; }
        }



        /// <summary>
        /// 身份证号码_searchhidden
        /// </summary>
        private string _KhIDCardNumber = "";
        /// <summary>
        /// 身份证号码_searchhidden
        /// </summary>
        [DisplayName("身份证号码")]
        public string KhIDCardNumber
        {
            set { _KhIDCardNumber = value; }
            get { return _KhIDCardNumber; }
        }



        /// <summary>
        /// 家庭住址_listhidden_searchhidden
        /// </summary>
        private string _KhAddress = "";
        /// <summary>
        /// 家庭住址_listhidden_searchhidden
        /// </summary>
        [DisplayName("家庭住址")]

        public string KhAddress
        {
            set { _KhAddress = value; }
            get { return _KhAddress; }
        }



        /// <summary>
        /// 家属姓名_searchhidden
        /// </summary>
        private string _KhFamilyName = "";
        /// <summary>
        /// 家属姓名_searchhidden
        /// </summary>
        [DisplayName("家属姓名")]
        public string KhFamilyName
        {
            set { _KhFamilyName = value; }
            get { return _KhFamilyName; }
        }



        /// <summary>
        /// 家属手机_searchhidden
        /// </summary>
        private string _KhFamilyPhone = "";
        /// <summary>
        /// 家属手机_searchhidden
        /// </summary>
        [DisplayName("家属手机")]
        public string KhFamilyPhone
        {
            set { _KhFamilyPhone = value; }
            get { return _KhFamilyPhone; }
        }



        /// <summary>
        /// 家庭年收入_listhidden_searchhidden
        /// </summary>
        private string _KhFamilyShouRu = "";
        /// <summary>
        /// 家庭年收入_listhidden_searchhidden
        /// </summary>
        [DisplayName("家庭年收入")]

        public string KhFamilyShouRu
        {
            set { _KhFamilyShouRu = value; }
            get { return _KhFamilyShouRu; }
        }



        /// <summary>
        /// 血型_listhidden_searchhidden
        /// </summary>
        private string _KhXueXing = "";
        /// <summary>
        /// 血型_listhidden_searchhidden
        /// </summary>
        [DisplayName("血型")]

        public string KhXueXing
        {
            set { _KhXueXing = value; }
            get { return _KhXueXing; }
        }



        /// <summary>
        /// 星座_listhidden_searchhidden
        /// </summary>
        private string _KhXingZuo = "";
        /// <summary>
        /// 星座_listhidden_searchhidden
        /// </summary>
        [DisplayName("星座")]

        public string KhXingZuo
        {
            set { _KhXingZuo = value; }
            get { return _KhXingZuo; }
        }



        /// <summary>
        /// 性格_listhidden_searchhidden
        /// </summary>
        private string _KhXingGe = "";
        /// <summary>
        /// 性格_listhidden_searchhidden
        /// </summary>
        [DisplayName("性格")]

        public string KhXingGe
        {
            set { _KhXingGe = value; }
            get { return _KhXingGe; }
        }



        /// <summary>
        /// 关注网站_listhidden_searchhidden
        /// </summary>
        private string _KhGuanZhuWangZhan = "";
        /// <summary>
        /// 关注网站_listhidden_searchhidden
        /// </summary>
        [DisplayName("关注网站")]

        public string KhGuanZhuWangZhan
        {
            set { _KhGuanZhuWangZhan = value; }
            get { return _KhGuanZhuWangZhan; }
        }



        /// <summary>
        /// 休闲方式_listhidden_searchhidden
        /// </summary>
        private string _KhXiuXianFangShi = "";
        /// <summary>
        /// 休闲方式_listhidden_searchhidden
        /// </summary>
        [DisplayName("休闲方式")]

        public string KhXiuXianFangShi
        {
            set { _KhXiuXianFangShi = value; }
            get { return _KhXiuXianFangShi; }
        }



        /// <summary>
        /// 饮食习惯_listhidden_searchhidden
        /// </summary>
        private string _KhYinShiXiGuan = "";
        /// <summary>
        /// 饮食习惯_listhidden_searchhidden
        /// </summary>
        [DisplayName("饮食习惯")]

        public string KhYinShiXiGuan
        {
            set { _KhYinShiXiGuan = value; }
            get { return _KhYinShiXiGuan; }
        }



        /// <summary>
        /// 忌口或过敏类食物_listhidden_searchhidden
        /// </summary>
        private string _KhGuoMinLeiFood = "";
        /// <summary>
        /// 忌口或过敏类食物_listhidden_searchhidden
        /// </summary>
        [DisplayName("忌口或过敏类食物")]

        public string KhGuoMinLeiFood
        {
            set { _KhGuoMinLeiFood = value; }
            get { return _KhGuoMinLeiFood; }
        }



        /// <summary>
        /// 家庭遗传病史_listhidden_searchhidden
        /// </summary>
        private string _KhFamilyYCBS = "";
        /// <summary>
        /// 家庭遗传病史_listhidden_searchhidden
        /// </summary>
        [DisplayName("家庭遗传病史")]

        public string KhFamilyYCBS
        {
            set { _KhFamilyYCBS = value; }
            get { return _KhFamilyYCBS; }
        }



        /// <summary>
        /// 其他病例_listhidden_searchhidden
        /// </summary>
        private string _KhQiTaBingLi = "";
        /// <summary>
        /// 其他病例_listhidden_searchhidden
        /// </summary>
        [DisplayName("其他病例")]

        public string KhQiTaBingLi
        {
            set { _KhQiTaBingLi = value; }
            get { return _KhQiTaBingLi; }
        }



        /// <summary>
        /// 销售顾问_searchhidden
        /// </summary>
        private string _KhSales = "";
        /// <summary>
        /// 销售顾问_searchhidden
        /// </summary>
        [DisplayName("销售顾问")]

        public string KhSales
        {
            set { _KhSales = value; }
            get { return _KhSales; }
        }



        /// <summary>
        /// 所属门店Id
        /// </summary>
        private int _ProjectID;
        /// <summary>
        /// 所属项目公司Id
        /// </summary>
        [DisplayName("所属分公司")]
        [Required]
        public int ProjectID
        {
            set { _ProjectID = value; }
            get { return _ProjectID; }
        }

        public string ProjectName { get; set; }

        [DisplayName("客户状态")]
        [Required]
        public string KhState { set; get; }

        /// <summary>
        /// 备注_listhidden_searchhidden
        /// </summary>
        private string _KhRemarks = "";
        /// <summary>
        /// 备注_listhidden_searchhidden
        /// </summary>
        [DisplayName("备注")]

        public string KhRemarks
        {
            set { _KhRemarks = value; }
            get { return _KhRemarks; }
        }



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

    public partial class KeHuReq : BaseSearchReq
    {
        [DisplayName("ses客户")]
        public int? sesKHID { get; set; }
        public string ValidState { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("系统销售")]
        public int? KhSalesSystemId { get; set; }
        [DisplayName("销售员")]
        public int? KhSalesId { get; set; }

        public string RoomNumber { get; set; }
        public string projectids { get; set; }
        public DateTime? SeachDate { get; set; }
        /// <summary>
        /// seed
        /// </summary> 
        public int id { get; set; }

        public string ProjectName { get; set; }
        /// <summary>
        /// 客户名字
        /// </summary> 
        public string KhName { get; set; }


        /// <summary>
        /// 客户联系电话
        /// </summary> 
        public string KhPhone { get; set; }


        /// <summary>
        /// 预产期
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
        /// 生产医院_searchhidden
        /// </summary> 
        public string KhHospital { get; set; }


        /// <summary>
        /// 身份证号码_searchhidden
        /// </summary> 
        public string KhIDCardNumber { get; set; }


        /// <summary>
        /// 家庭住址_listhidden_searchhidden
        /// </summary> 
        public string KhAddress { get; set; }


        /// <summary>
        /// 家属姓名_searchhidden
        /// </summary> 
        public string KhFamilyName { get; set; }


        /// <summary>
        /// 家属手机_searchhidden
        /// </summary> 
        public string KhFamilyPhone { get; set; }


        /// <summary>
        /// 家庭年收入_listhidden_searchhidden
        /// </summary> 
        public string KhFamilyShouRu { get; set; }


        /// <summary>
        /// 血型_listhidden_searchhidden
        /// </summary> 
        public string KhXueXing { get; set; }


        /// <summary>
        /// 星座_listhidden_searchhidden
        /// </summary> 
        public string KhXingZuo { get; set; }


        /// <summary>
        /// 性格_listhidden_searchhidden
        /// </summary> 
        public string KhXingGe { get; set; }


        /// <summary>
        /// 关注网站_listhidden_searchhidden
        /// </summary> 
        public string KhGuanZhuWangZhan { get; set; }


        /// <summary>
        /// 休闲方式_listhidden_searchhidden
        /// </summary> 
        public string KhXiuXianFangShi { get; set; }


        /// <summary>
        /// 饮食习惯_listhidden_searchhidden
        /// </summary> 
        public string KhYinShiXiGuan { get; set; }


        /// <summary>
        /// 忌口或过敏类食物_listhidden_searchhidden
        /// </summary> 
        public string KhGuoMinLeiFood { get; set; }


        /// <summary>
        /// 家庭遗传病史_listhidden_searchhidden
        /// </summary> 
        public string KhFamilyYCBS { get; set; }


        /// <summary>
        /// 其他病例_listhidden_searchhidden
        /// </summary> 
        public string KhQiTaBingLi { get; set; }


        /// <summary>
        /// 销售顾问_searchhidden
        /// </summary> 
        public string KhSales { get; set; }

        public string KhState { set; get; }


        /// <summary>
        /// 所属项目公司Id
        /// </summary> 
        //public int? ProjectID { get;set; } 


        /// <summary>
        /// 备注_listhidden_searchhidden
        /// </summary> 
        public string KhRemarks { get; set; }


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

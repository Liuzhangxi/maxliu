



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OUDAL
{
    ///################################################################################################
    /// <summary>
    /// <para>摘要：kehuModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：kehu
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>CustomId</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>KhName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名字</td></tr>
    /// <tr valign="top"><td>3</td><td>KhPsd</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户密码</td></tr>
    /// <tr valign="top"><td>4</td><td>KhPhoneNumber</td><td>nvarchar</td><td>20</td><td></td><td></td><td></td><td>√</td><td></td><td>客户手机号 (作为登录帐号)</td></tr>
    /// <tr valign="top"><td>5</td><td>KhYuChanQi</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>客户预产期</td></tr>
    /// <tr valign="top"><td>6</td><td>KhYuChanHospital</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户预产医院</td></tr>
    /// <tr valign="top"><td>7</td><td>KhYuChanHospitalAddress</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户预产医院地址</td></tr>
    /// <tr valign="top"><td>8</td><td>KhCity</td><td>nvarchar</td><td>10</td><td></td><td></td><td></td><td>√</td><td></td><td>客户地区（省）</td></tr>
    /// <tr valign="top"><td>9</td><td>KhAddress</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户详细地址</td></tr>
    /// <tr valign="top"><td>10</td><td>KhAge</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户年龄</td></tr>
    /// <tr valign="top"><td>11</td><td>KhInfos</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>客户备注信息</td></tr>
    /// <tr valign="top"><td>12</td><td>KhWeiXinID</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户微信ID 绑定微信号</td></tr>
    /// <tr valign="top"><td>13</td><td>KhCreateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td>(getdate())</td><td>客户创建日期_createdate</td></tr>
    /// <tr valign="top"><td>14</td><td>OptName</td><td>nvarchar</td><td>10</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>15</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("kehu")]
    [Serializable]
    public partial class Seskehu
    {

        public static string LogClass = "客户信息";
        #region -  公共属性  ------------------------------------------------------------
        [NotMapped]
        public string KhPsdNew { get; set; }

        [DisplayName("客户类型")]
        public string KhClassName { get; set; }

        [DisplayName("客户呼叫类型")]
        public string KhCallClassName { get; set; }

        [DisplayName("客户呼入/呼出时间登记")]
        public DateTime? KhCallDateTime { get; set; }



        [DisplayName("服务月嫂ID")]
        public int? FuWuYueSaoID { get; set; }

        [DisplayName("服务月嫂名")]
        public string FuWuYueSaoName { get; set; }


        [DisplayName("所属项目公司")]
        public int? ProjectId { get; set; }

        [DisplayName("客户状态")]
        public string KhState { get; set; }
        [DisplayName("客户业务负责人")]
        public string KhYeWu { get; set; }

        [DisplayName("客户微信号")]
        public string KhWeiXin { get; set; }
        [DisplayName("客户宝宝月龄")]
        public int? KhBabyMonth { get; set; }

        [DisplayName("客户来源")]
        public string KhLaiYuan { get; set; }

        [Required]
        [DisplayName("客服填写客户联系手机号")]
        public string KeFuKhPhoneNumber { get; set; }

        /// <summary>
        /// 客户名字
        /// </summary>
        private string _KhName = "";
        /// <summary>
        /// 客户名字
        /// </summary>
        [DisplayName("客户名字")]
        public string KhName
        {
            set { _KhName = value; }
            get { return _KhName; }
        }





        /// <summary>
        /// 客户密码
        /// </summary>
        private string _KhPsd = "";
        /// <summary>
        /// 客户密码
        /// </summary>
        [DisplayName("客户密码")]
        public string KhPsd
        {
            set { _KhPsd = value; }
            get { return _KhPsd; }
        }





        /// <summary>
        /// 客户手机号 (作为登录帐号)
        /// </summary>
        private string _KhPhoneNumber = "";
        /// <summary>
        /// 客户手机号 (作为登录帐号)
        /// </summary>
        [DisplayName("客户手机号 (作为登录帐号)")]
        public string KhPhoneNumber
        {
            set { _KhPhoneNumber = value; }
            get { return _KhPhoneNumber; }
        }





        /// <summary>
        /// 客户预产期
        /// </summary>
        //private DateTime? _KhYuChanQi = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 客户预产期
        /// </summary>
        [DisplayName("客户预产期")]
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
        /// 客户预产医院
        /// </summary>
        private string _KhYuChanHospital = "";
        /// <summary>
        /// 客户预产医院
        /// </summary>
        [DisplayName("客户预产医院")]
        public string KhYuChanHospital
        {
            set { _KhYuChanHospital = value; }
            get { return _KhYuChanHospital; }
        }





        /// <summary>
        /// 客户预产医院地址
        /// </summary>
        private string _KhYuChanHospitalAddress = "";
        /// <summary>
        /// 客户预产医院地址
        /// </summary>
        [DisplayName("客户预产医院地址")]
        public string KhYuChanHospitalAddress
        {
            set { _KhYuChanHospitalAddress = value; }
            get { return _KhYuChanHospitalAddress; }
        }





        /// <summary>
        /// 客户地区（省）
        /// </summary>
        private string _KhCity = "";
        /// <summary>
        /// 客户地区（省）
        /// </summary>
        [DisplayName("客户地区（省）")]
        public string KhCity
        {
            set { _KhCity = value; }
            get { return _KhCity; }
        }





        /// <summary>
        /// 客户详细地址
        /// </summary>
        private string _KhAddress = "";
        /// <summary>
        /// 客户详细地址
        /// </summary>
        [DisplayName("客户详细地址")]
        public string KhAddress
        {
            set { _KhAddress = value; }
            get { return _KhAddress; }
        }





        /// <summary>
        /// 客户年龄
        /// </summary>
        private int? _KhAge;
        /// <summary>
        /// 客户年龄
        /// </summary>
        [DisplayName("客户年龄")]
        public int? KhAge
        {
            set { _KhAge = value; }
            get { return _KhAge; }
        }





        /// <summary>
        /// 客户备注信息
        /// </summary>
        private string _KhInfos = "";
        /// <summary>
        /// 客户备注信息
        /// </summary>
        [DisplayName("客户备注信息")]
        public string KhInfos
        {
            set { _KhInfos = value; }
            get { return _KhInfos; }
        }





        /// <summary>
        /// 客户微信ID 绑定微信号
        /// </summary>
        private string _KhWeiXinID = "";
        /// <summary>
        /// 客户微信ID 绑定微信号
        /// </summary>
        [DisplayName("客户微信ID 绑定微信号")]
        public string KhWeiXinID
        {
            set { _KhWeiXinID = value; }
            get { return _KhWeiXinID; }
        }





        /// <summary>
        /// 客户创建日期_createdate
        /// </summary>
        //private DateTime? _KhCreateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 客户创建日期_createdate
        /// </summary>
        [DisplayName("客户创建日期")]
        public DateTime? KhCreateTime { get; set; }


        private DateTime _KhCreateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhCreateTimeStart
        {
            set { _KhCreateTimeStart = value; }
            get { return _KhCreateTimeStart; }
        }
        private DateTime _KhCreateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime KhCreateTimeEnd
        {
            set { _KhCreateTimeEnd = value; }
            get { return _KhCreateTimeEnd; }
        }




        /// <summary>
        /// 操作人
        /// </summary>
        private string _OptName = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }





        /// <summary>
        /// 
        /// </summary>
        private int _id;
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
        /// 是否为喜喜会所用户
        /// </summary>
        [DisplayName("是否为喜喜会所用户")]
        public int? xixiVip
        {
            get; set;
        }

        /// <summary>
        /// 所在会所ID
        /// </summary>
        [DisplayName("所在会所")]
        public int? huisuoID
        {
            get; set;
        }

        [DisplayName("销售名称")]
        [NotMapped]
        public string SalesName
        {
            get; set;
        }
        public int? KhJiFen { get; set; }
        #endregion ----------------------------------------------------------------------
    }


    public partial class SeskehuReq
    {

        #region -  公共属性  ------------------------------------------------------------
        public string IsHongDongReg { get; set; }
        public int? KhprojectId { get; set; }

        [DisplayName("客户类型")]
        public string KhClassName { get; set; }

        [DisplayName("客户呼叫类型")]
        public string KhCallClassName { get; set; }

        [DisplayName("客户呼入/呼出时间登记")]
        public DateTime? KhCallDateTime { get; set; }



        [DisplayName("服务月嫂ID")]
        public int? FuWuYueSaoID { get; set; }

        [DisplayName("服务月嫂名")]
        public string FuWuYueSaoName { get; set; }


        [DisplayName("所属项目公司")]
        public int? ProjectId { get; set; }

        [DisplayName("客户状态")]
        public string KhState { get; set; }
        [DisplayName("客户业务负责人")]
        public string KhYeWu { get; set; }

        [DisplayName("客户微信号")]
        public string KhWeiXin { get; set; }
        [DisplayName("客户宝宝月龄")]
        public int? KhBabyMonth { get; set; }

        [DisplayName("客户来源")]
        public string KhLaiYuan { get; set; }

        [Required]
        [DisplayName("客服填写客户联系手机号")]
        public string KeFuKhPhoneNumber { get; set; }

        /// <summary>
        /// 客户名字
        /// </summary>
        private string _KhName = "";
        /// <summary>
        /// 客户名字
        /// </summary>
        [DisplayName("客户名字")]
        public string KhName
        {
            set { _KhName = value; }
            get { return _KhName; }
        }





        /// <summary>
        /// 客户密码
        /// </summary>
        private string _KhPsd = "";
        /// <summary>
        /// 客户密码
        /// </summary>
        [DisplayName("客户密码")]
        public string KhPsd
        {
            set { _KhPsd = value; }
            get { return _KhPsd; }
        }





        /// <summary>
        /// 客户手机号 (作为登录帐号)
        /// </summary>
        private string _KhPhoneNumber = "";
        /// <summary>
        /// 客户手机号 (作为登录帐号)
        /// </summary>
        [DisplayName("客户手机号 (作为登录帐号)")]
        public string KhPhoneNumber
        {
            set { _KhPhoneNumber = value; }
            get { return _KhPhoneNumber; }
        }





        /// <summary>
        /// 客户预产期
        /// </summary>
        //private DateTime? _KhYuChanQi = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 客户预产期
        /// </summary>
        [DisplayName("客户预产期")]
        public DateTime? KhYuChanQi { get; set; }

        private DateTime _KhYuChanQiStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime DateFromKhYuChanQi
        {
            set { _KhYuChanQiStart = value; }
            get { return _KhYuChanQiStart; }
        }
        private DateTime _KhYuChanQiEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime DateToKhYuChanQi
        {
            set { _KhYuChanQiEnd = value; }
            get { return _KhYuChanQiEnd; }
        }




        /// <summary>
        /// 客户预产医院
        /// </summary>
        private string _KhYuChanHospital = "";
        /// <summary>
        /// 客户预产医院
        /// </summary>
        [DisplayName("客户预产医院")]
        public string KhYuChanHospital
        {
            set { _KhYuChanHospital = value; }
            get { return _KhYuChanHospital; }
        }





        /// <summary>
        /// 客户预产医院地址
        /// </summary>
        private string _KhYuChanHospitalAddress = "";
        /// <summary>
        /// 客户预产医院地址
        /// </summary>
        [DisplayName("客户预产医院地址")]
        public string KhYuChanHospitalAddress
        {
            set { _KhYuChanHospitalAddress = value; }
            get { return _KhYuChanHospitalAddress; }
        }





        /// <summary>
        /// 客户地区（省）
        /// </summary>
        private string _KhCity = "";
        /// <summary>
        /// 客户地区（省）
        /// </summary>
        [DisplayName("客户地区（省）")]
        public string KhCity
        {
            set { _KhCity = value; }
            get { return _KhCity; }
        }





        /// <summary>
        /// 客户详细地址
        /// </summary>
        private string _KhAddress = "";
        /// <summary>
        /// 客户详细地址
        /// </summary>
        [DisplayName("客户详细地址")]
        public string KhAddress
        {
            set { _KhAddress = value; }
            get { return _KhAddress; }
        }





        /// <summary>
        /// 客户年龄
        /// </summary>
        private int? _KhAge;
        /// <summary>
        /// 客户年龄
        /// </summary>
        [DisplayName("客户年龄")]
        public int? KhAge
        {
            set { _KhAge = value; }
            get { return _KhAge; }
        }





        /// <summary>
        /// 客户备注信息
        /// </summary>
        private string _KhInfos = "";
        /// <summary>
        /// 客户备注信息
        /// </summary>
        [DisplayName("客户备注信息")]
        public string KhInfos
        {
            set { _KhInfos = value; }
            get { return _KhInfos; }
        }





        /// <summary>
        /// 客户微信ID 绑定微信号
        /// </summary>
        private string _KhWeiXinID = "";
        /// <summary>
        /// 客户微信ID 绑定微信号
        /// </summary>
        [DisplayName("客户微信ID 绑定微信号")]
        public string KhWeiXinID
        {
            set { _KhWeiXinID = value; }
            get { return _KhWeiXinID; }
        }





        /// <summary>
        /// 客户创建日期_createdate
        /// </summary>
        //private DateTime? _KhCreateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 客户创建日期_createdate
        /// </summary>
        [DisplayName("客户创建日期")]
        public DateTime? KhCreateTime { get; set; }


        private DateTime _KhCreateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime DateFromKhCreateTime
        {
            set { _KhCreateTimeStart = value; }
            get { return _KhCreateTimeStart; }
        }
        private DateTime _KhCreateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime DateToKhCreateTime
        {
            set { _KhCreateTimeEnd = value; }
            get { return _KhCreateTimeEnd; }
        }




        /// <summary>
        /// 操作人
        /// </summary>
        private string _OptName = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }





        /// <summary>
        /// 
        /// </summary>
        private int _id;
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }




        /// <summary>
        /// 是否为喜喜会所用户
        /// </summary>
        [DisplayName("是否为喜喜会所用户")]
        public int? xixiVip
        {
            get; set;
        }

        /// <summary>
        /// 所在会所ID
        /// </summary>
        [DisplayName("所在会所")]
        public int? huisuoID
        {
            get; set;
        }


        [DisplayName("销售名称")]
        [NotMapped]
        public string SalesName
        {
            get; set;
        }

        [DisplayName("客户积分")]
        public int? KhJiFen { get; set; }
        #endregion ----------------------------------------------------------------------
    }

}

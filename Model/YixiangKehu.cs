



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
    /// <para>摘要：yixiangKehuModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：yixiangKehu
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>KhName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名字</td></tr>
    /// <tr valign="top"><td>3</td><td>KhPsd</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户密码</td></tr>
    /// <tr valign="top"><td>4</td><td>KhPhoneNumber</td><td>nvarchar</td><td>20</td><td></td><td></td><td></td><td>√</td><td></td><td>客户手机号 (作为登录帐号)</td></tr>
    /// <tr valign="top"><td>5</td><td>KhYuChanQi</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>客户预产期</td></tr>
    /// <tr valign="top"><td>6</td><td>KhYuChanHospital</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>客户预产医院</td></tr>
    /// <tr valign="top"><td>7</td><td>KhYuChanHospitalAddress</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>客户预产医院地址</td></tr>
    /// <tr valign="top"><td>8</td><td>KhCity</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户地区（省）</td></tr>
    /// <tr valign="top"><td>9</td><td>KhAddress</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>客户详细地址</td></tr>
    /// <tr valign="top"><td>10</td><td>KhAge</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户年龄</td></tr>
    /// <tr valign="top"><td>11</td><td>KhInfos</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>客户备注信息</td></tr>
    /// <tr valign="top"><td>12</td><td>KhWeiXinID</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户微信ID 绑定微信号</td></tr>
    /// <tr valign="top"><td>13</td><td>KhCreateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td>(getdate())</td><td>客户创建日期_createdate</td></tr>
    /// <tr valign="top"><td>14</td><td>OptName</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>15</td><td>KhLaiYuan</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户来源</td></tr>
    /// <tr valign="top"><td>16</td><td>KhState</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户状态</td></tr>
    /// <tr valign="top"><td>17</td><td>KhYeWu</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户业务负责人</td></tr>
    /// <tr valign="top"><td>18</td><td>KhWeiXin</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>客户微信号</td></tr>
    /// <tr valign="top"><td>19</td><td>KhBabyMonth</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户宝宝月龄</td></tr>
    /// <tr valign="top"><td>20</td><td>ProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户所属分公司</td></tr>
    /// <tr valign="top"><td>21</td><td>KeFuKhPhoneNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>客服人员填写的客户手机号</td></tr>
    /// <tr valign="top"><td>22</td><td>KhInCitySite</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户所在城市站</td></tr>
    /// <tr valign="top"><td>23</td><td>FuWuYueSaoID</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>为客户服务的月嫂ID</td></tr>
    /// <tr valign="top"><td>24</td><td>FuWuYueSaoName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>服务的月嫂名字</td></tr>
    /// <tr valign="top"><td>25</td><td>KhPsdXiuGaiDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>客户密码修改日期</td></tr>
    /// <tr valign="top"><td>26</td><td>KhClassName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户类型：会所客户，月嫂客户，读取字典</td></tr>
    /// <tr valign="top"><td>27</td><td>KhCallClassName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>客户呼叫类型，呼入/呼出</td></tr>
    /// <tr valign="top"><td>28</td><td>KhCallDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>客户呼入/呼出时间登记</td></tr>
    /// <tr valign="top"><td>29</td><td>XiaoFeiKaMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td></td><td>((0.00))</td><td>客户的消费卡余额</td></tr>
    /// <tr valign="top"><td>30</td><td>JDZhiFuToken</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>京东支付TOKEN值</td></tr>
    /// <tr valign="top"><td>31</td><td>xixiVIP</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>是否为喜喜会所用户 1是VIP，0不是VIP</td></tr>
    /// <tr valign="top"><td>32</td><td>huisuoID</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>会所ID 0表示非会所客户</td></tr>
    /// <tr valign="top"><td>33</td><td>KhJiFen</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>客户积分</td></tr>
    /// <tr valign="top"><td>34</td><td>xixiProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("yixiangKehu")]
    [Serializable]
    public partial class yixiangKehuXiXi 
    {
    
        public static string LogClass = "客户信息";
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
        /// 客户名字
        /// </summary>
        private string _KhName  = "";
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
        private string _KhPsd  = "";
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
        private string _KhPhoneNumber  = "";
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
        private DateTime? _KhYuChanQi ;
        /// <summary>
        /// 客户预产期
        /// </summary>
        [DisplayName("客户预产期")]
        
        public DateTime? KhYuChanQi
        {
            set { _KhYuChanQi = value; }
            get { return _KhYuChanQi; }
        }
        
        private DateTime _KhYuChanQiStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhYuChanQiStart
{
set { _KhYuChanQiStart = value; }
get{ return _KhYuChanQiStart; }
}
 private DateTime _KhYuChanQiEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhYuChanQiEnd
{
set { _KhYuChanQiEnd = value; }
get{ return _KhYuChanQiEnd; }
}
  
        
        /// <summary>
        /// 客户预产医院
        /// </summary>
        private string _KhYuChanHospital  = "";
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
        private string _KhYuChanHospitalAddress  = "";
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
        private string _KhCity  = "";
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
        private string _KhAddress  = "";
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
        private int? _KhAge ;
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
        private string _KhInfos  = "";
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
        private string _KhWeiXinID  = "";
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
        private DateTime? _KhCreateTime ;
        /// <summary>
        /// 客户创建日期_createdate
        /// </summary>
        [DisplayName("客户创建日期")]
        
        public DateTime? KhCreateTime
        {
            set { _KhCreateTime = value; }
            get { return _KhCreateTime; }
        }
        
        private DateTime _KhCreateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCreateTimeStart
{
set { _KhCreateTimeStart = value; }
get{ return _KhCreateTimeStart; }
}
 private DateTime _KhCreateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCreateTimeEnd
{
set { _KhCreateTimeEnd = value; }
get{ return _KhCreateTimeEnd; }
}
  
        
        /// <summary>
        /// 操作人
        /// </summary>
        private string _OptName  = "";
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
        /// 客户来源
        /// </summary>
        private string _KhLaiYuan  = "";
        /// <summary>
        /// 客户来源
        /// </summary>
        [DisplayName("客户来源")]
        
        public string KhLaiYuan
        {
            set { _KhLaiYuan = value; }
            get { return _KhLaiYuan; }
        }
        
         
        
        /// <summary>
        /// 客户状态
        /// </summary>
        private string _KhState  = "";
        /// <summary>
        /// 客户状态
        /// </summary>
        [DisplayName("客户状态")]
        
        public string KhState
        {
            set { _KhState = value; }
            get { return _KhState; }
        }
        
         
        
        /// <summary>
        /// 客户业务负责人
        /// </summary>
        private string _KhYeWu  = "";
        /// <summary>
        /// 客户业务负责人
        /// </summary>
        [DisplayName("客户业务负责人")]
        
        public string KhYeWu
        {
            set { _KhYeWu = value; }
            get { return _KhYeWu; }
        }
        
         
        
        /// <summary>
        /// 客户微信号
        /// </summary>
        private string _KhWeiXin  = "";
        /// <summary>
        /// 客户微信号
        /// </summary>
        [DisplayName("客户微信号")]
        
        public string KhWeiXin
        {
            set { _KhWeiXin = value; }
            get { return _KhWeiXin; }
        }
        
         
        
        /// <summary>
        /// 客户宝宝月龄
        /// </summary>
        private int? _KhBabyMonth ;
        /// <summary>
        /// 客户宝宝月龄
        /// </summary>
        [DisplayName("客户宝宝月龄")]
        
        public int? KhBabyMonth
        {
            set { _KhBabyMonth = value; }
            get { return _KhBabyMonth; }
        }
        
         
        
        /// <summary>
        /// 客户所属分公司
        /// </summary>
        private int? _ProjectId ;
        /// <summary>
        /// 客户所属分公司
        /// </summary>
        [DisplayName("客户所属分公司")]
        
        public int? ProjectId
        {
            set { _ProjectId = value; }
            get { return _ProjectId; }
        }
        
         
        
        /// <summary>
        /// 客服人员填写的客户手机号
        /// </summary>
        private string _KeFuKhPhoneNumber  = "";
        /// <summary>
        /// 客服人员填写的客户手机号
        /// </summary>
        [DisplayName("客服人员填写的客户手机号")]
         [Required]
        public string KeFuKhPhoneNumber
        {
            set { _KeFuKhPhoneNumber = value; }
            get { return _KeFuKhPhoneNumber; }
        }
        
         
        
        /// <summary>
        /// 客户所在城市站
        /// </summary>
        private string _KhInCitySite  = "";
        /// <summary>
        /// 客户所在城市站
        /// </summary>
        [DisplayName("客户所在城市站")]
        
        public string KhInCitySite
        {
            set { _KhInCitySite = value; }
            get { return _KhInCitySite; }
        }
        
         
        
        /// <summary>
        /// 为客户服务的月嫂ID
        /// </summary>
        private int? _FuWuYueSaoID ;
        /// <summary>
        /// 为客户服务的月嫂ID
        /// </summary>
        [DisplayName("为客户服务的月嫂ID")]
        
        public int? FuWuYueSaoID
        {
            set { _FuWuYueSaoID = value; }
            get { return _FuWuYueSaoID; }
        }
        
         
        
        /// <summary>
        /// 服务的月嫂名字
        /// </summary>
        private string _FuWuYueSaoName  = "";
        /// <summary>
        /// 服务的月嫂名字
        /// </summary>
        [DisplayName("服务的月嫂名字")]
        
        public string FuWuYueSaoName
        {
            set { _FuWuYueSaoName = value; }
            get { return _FuWuYueSaoName; }
        }
        
         
        
        /// <summary>
        /// 客户密码修改日期
        /// </summary>
        private DateTime? _KhPsdXiuGaiDateTime ;
        /// <summary>
        /// 客户密码修改日期
        /// </summary>
        [DisplayName("客户密码修改日期")]
        
        public DateTime? KhPsdXiuGaiDateTime
        {
            set { _KhPsdXiuGaiDateTime = value; }
            get { return _KhPsdXiuGaiDateTime; }
        }
        
        private DateTime _KhPsdXiuGaiDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhPsdXiuGaiDateTimeStart
{
set { _KhPsdXiuGaiDateTimeStart = value; }
get{ return _KhPsdXiuGaiDateTimeStart; }
}
 private DateTime _KhPsdXiuGaiDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhPsdXiuGaiDateTimeEnd
{
set { _KhPsdXiuGaiDateTimeEnd = value; }
get{ return _KhPsdXiuGaiDateTimeEnd; }
}
  
        
        /// <summary>
        /// 客户类型：会所客户，月嫂客户，读取字典
        /// </summary>
        private string _KhClassName  = "";
        /// <summary>
        /// 客户类型：会所客户，月嫂客户，读取字典
        /// </summary>
        [DisplayName("客户类型：会所客户，月嫂客户，读取字典")]
        
        public string KhClassName
        {
            set { _KhClassName = value; }
            get { return _KhClassName; }
        }
        
         
        
        /// <summary>
        /// 客户呼叫类型，呼入/呼出
        /// </summary>
        private string _KhCallClassName  = "";
        /// <summary>
        /// 客户呼叫类型，呼入/呼出
        /// </summary>
        [DisplayName("客户呼叫类型，呼入/呼出")]
        
        public string KhCallClassName
        {
            set { _KhCallClassName = value; }
            get { return _KhCallClassName; }
        }
        
         
        
        /// <summary>
        /// 客户呼入/呼出时间登记
        /// </summary>
        private DateTime? _KhCallDateTime ;
        /// <summary>
        /// 客户呼入/呼出时间登记
        /// </summary>
        [DisplayName("客户呼入/呼出时间登记")]
        
        public DateTime? KhCallDateTime
        {
            set { _KhCallDateTime = value; }
            get { return _KhCallDateTime; }
        }
        
        private DateTime _KhCallDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCallDateTimeStart
{
set { _KhCallDateTimeStart = value; }
get{ return _KhCallDateTimeStart; }
}
 private DateTime _KhCallDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCallDateTimeEnd
{
set { _KhCallDateTimeEnd = value; }
get{ return _KhCallDateTimeEnd; }
}
  
        
        /// <summary>
        /// 客户的消费卡余额
        /// </summary>
        private decimal _XiaoFeiKaMoney ;
        /// <summary>
        /// 客户的消费卡余额
        /// </summary>
        [DisplayName("客户的消费卡余额")]
         [Required]
        public decimal XiaoFeiKaMoney
        {
            set { _XiaoFeiKaMoney = value; }
            get { return _XiaoFeiKaMoney; }
        }
        
         
        
        /// <summary>
        /// 京东支付TOKEN值
        /// </summary>
        private string _JDZhiFuToken  = "";
        /// <summary>
        /// 京东支付TOKEN值
        /// </summary>
        [DisplayName("京东支付TOKEN值")]
        
        public string JDZhiFuToken
        {
            set { _JDZhiFuToken = value; }
            get { return _JDZhiFuToken; }
        }
        
         
        
        /// <summary>
        /// 是否为喜喜会所用户 1是VIP，0不是VIP
        /// </summary>
        private int? _xixiVIP ;
        /// <summary>
        /// 是否为喜喜会所用户 1是VIP，0不是VIP
        /// </summary>
        [DisplayName("是否为喜喜会所用户 1是VIP，0不是VIP")]
        
        public int? xixiVIP
        {
            set { _xixiVIP = value; }
            get { return _xixiVIP; }
        }
        
         
        
        /// <summary>
        /// 会所ID 0表示非会所客户
        /// </summary>
        private int? _huisuoID ;
        /// <summary>
        /// 会所ID 0表示非会所客户
        /// </summary>
        [DisplayName("会所ID 0表示非会所客户")]
        
        public int? huisuoID
        {
            set { _huisuoID = value; }
            get { return _huisuoID; }
        }
        
         
        
        /// <summary>
        /// 客户积分
        /// </summary>
        private int? _KhJiFen ;
        /// <summary>
        /// 客户积分
        /// </summary>
        [DisplayName("客户积分")]
        
        public int? KhJiFen
        {
            set { _KhJiFen = value; }
            get { return _KhJiFen; }
        }
        
         
        
        /// <summary>
        /// 
        /// </summary>
        private int? _xixiProjectId ;
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("xixiProjectId")]
        
        public int? xixiProjectId
        {
            set { _xixiProjectId = value; }
            get { return _xixiProjectId; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class yixiangKehuReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 客户名字
        /// </summary> 
        public string KhName { get;set; } 
	
          
        /// <summary>
        /// 客户密码
        /// </summary> 
        public string KhPsd { get;set; } 
	
          
        /// <summary>
        /// 客户手机号 (作为登录帐号)
        /// </summary> 
        public string KhPhoneNumber { get;set; } 
	
          
        /// <summary>
        /// 客户预产期
        /// </summary> 
        public DateTime? KhYuChanQi { get;set; } 
	
          private DateTime _KhYuChanQiStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhYuChanQiStart
{
set { _KhYuChanQiStart = value; }
get{ return _KhYuChanQiStart; }
}
 private DateTime _KhYuChanQiEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhYuChanQiEnd
{
set { _KhYuChanQiEnd = value; }
get{ return _KhYuChanQiEnd; }
}
 
        /// <summary>
        /// 客户预产医院
        /// </summary> 
        public string KhYuChanHospital { get;set; } 
	
          
        /// <summary>
        /// 客户预产医院地址
        /// </summary> 
        public string KhYuChanHospitalAddress { get;set; } 
	
          
        /// <summary>
        /// 客户地区（省）
        /// </summary> 
        public string KhCity { get;set; } 
	
          
        /// <summary>
        /// 客户详细地址
        /// </summary> 
        public string KhAddress { get;set; } 
	
          
        /// <summary>
        /// 客户年龄
        /// </summary> 
        public int? KhAge { get;set; } 
	
          
        /// <summary>
        /// 客户备注信息
        /// </summary> 
        public string KhInfos { get;set; } 
	
          
        /// <summary>
        /// 客户微信ID 绑定微信号
        /// </summary> 
        public string KhWeiXinID { get;set; } 
	
          
        /// <summary>
        /// 客户创建日期_createdate
        /// </summary> 
        public DateTime? KhCreateTime { get;set; } 
	
          private DateTime _KhCreateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCreateTimeStart
{
set { _KhCreateTimeStart = value; }
get{ return _KhCreateTimeStart; }
}
 private DateTime _KhCreateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCreateTimeEnd
{
set { _KhCreateTimeEnd = value; }
get{ return _KhCreateTimeEnd; }
}
 
        /// <summary>
        /// 操作人
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 客户来源
        /// </summary> 
        public string KhLaiYuan { get;set; } 
	
          
        /// <summary>
        /// 客户状态
        /// </summary> 
        public string KhState { get;set; } 
	
          
        /// <summary>
        /// 客户业务负责人
        /// </summary> 
        public string KhYeWu { get;set; } 
	
          
        /// <summary>
        /// 客户微信号
        /// </summary> 
        public string KhWeiXin { get;set; } 
	
          
        /// <summary>
        /// 客户宝宝月龄
        /// </summary> 
        public int? KhBabyMonth { get;set; } 
	
          
        /// <summary>
        /// 客服人员填写的客户手机号
        /// </summary> 
        public string KeFuKhPhoneNumber { get;set; } 
	
          
        /// <summary>
        /// 客户所在城市站
        /// </summary> 
        public string KhInCitySite { get;set; } 
	
          
        /// <summary>
        /// 为客户服务的月嫂ID
        /// </summary> 
        public int? FuWuYueSaoID { get;set; } 
	
          
        /// <summary>
        /// 服务的月嫂名字
        /// </summary> 
        public string FuWuYueSaoName { get;set; } 
	
          
        /// <summary>
        /// 客户密码修改日期
        /// </summary> 
        public DateTime? KhPsdXiuGaiDateTime { get;set; } 
	
          private DateTime _KhPsdXiuGaiDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhPsdXiuGaiDateTimeStart
{
set { _KhPsdXiuGaiDateTimeStart = value; }
get{ return _KhPsdXiuGaiDateTimeStart; }
}
 private DateTime _KhPsdXiuGaiDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhPsdXiuGaiDateTimeEnd
{
set { _KhPsdXiuGaiDateTimeEnd = value; }
get{ return _KhPsdXiuGaiDateTimeEnd; }
}
 
        /// <summary>
        /// 客户类型：会所客户，月嫂客户，读取字典
        /// </summary> 
        public string KhClassName { get;set; } 
	
          
        /// <summary>
        /// 客户呼叫类型，呼入/呼出
        /// </summary> 
        public string KhCallClassName { get;set; } 
	
          
        /// <summary>
        /// 客户呼入/呼出时间登记
        /// </summary> 
        public DateTime? KhCallDateTime { get;set; } 
	
          private DateTime _KhCallDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCallDateTimeStart
{
set { _KhCallDateTimeStart = value; }
get{ return _KhCallDateTimeStart; }
}
 private DateTime _KhCallDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime KhCallDateTimeEnd
{
set { _KhCallDateTimeEnd = value; }
get{ return _KhCallDateTimeEnd; }
}
 
        /// <summary>
        /// 客户的消费卡余额
        /// </summary> 
        public decimal? XiaoFeiKaMoney { get;set; } 
	
          
        /// <summary>
        /// 京东支付TOKEN值
        /// </summary> 
        public string JDZhiFuToken { get;set; } 
	
          
        /// <summary>
        /// 是否为喜喜会所用户 1是VIP，0不是VIP
        /// </summary> 
        public int? xixiVIP { get;set; } 
	
          
        /// <summary>
        /// 会所ID 0表示非会所客户
        /// </summary> 
        public int? huisuoID { get;set; } 
	
          
        /// <summary>
        /// 客户积分
        /// </summary> 
        public int? KhJiFen { get;set; } 
	
          
        /// <summary>
        /// 
        /// </summary> 
        public int? xixiProjectId { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

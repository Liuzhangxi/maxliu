



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
    /// <para>摘要：GuYuanUserModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：GuYuanUser
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>DepartmentName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>部门名</td></tr>
    /// <tr valign="top"><td>3</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>4</td><td>OptName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员名_optname</td></tr>
    /// <tr valign="top"><td>5</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员_optid</td></tr>
    /// <tr valign="top"><td>6</td><td>createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建时间_createdate</td></tr>
    /// <tr valign="top"><td>7</td><td>Name</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>姓名</td></tr>
    /// <tr valign="top"><td>8</td><td>PositionName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>岗位名</td></tr>
    /// <tr valign="top"><td>9</td><td>Sex</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>性别</td></tr>
    /// <tr valign="top"><td>10</td><td>OnboardDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>入职日期</td></tr>
    /// <tr valign="top"><td>11</td><td>FullMemberDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>转正日期</td></tr>
    /// <tr valign="top"><td>12</td><td>Nationality</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>民族</td></tr>
    /// <tr valign="top"><td>13</td><td>Polity</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>政治面貌</td></tr>
    /// <tr valign="top"><td>14</td><td>Birthday</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>生日</td></tr>
    /// <tr valign="top"><td>15</td><td>IDCard</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>身份证</td></tr>
    /// <tr valign="top"><td>16</td><td>Age</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>年龄</td></tr>
    /// <tr valign="top"><td>17</td><td>Phone</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>手机</td></tr>
    /// <tr valign="top"><td>18</td><td>Marry</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>婚姻状况</td></tr>
    /// <tr valign="top"><td>19</td><td>Education</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>学历</td></tr>
    /// <tr valign="top"><td>20</td><td>EmergencyName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>紧急联系人</td></tr>
    /// <tr valign="top"><td>21</td><td>EmergencyRelation</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>紧急联系人关系</td></tr>
    /// <tr valign="top"><td>22</td><td>EmergencyPhone</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>紧急联系人电话</td></tr>
    /// <tr valign="top"><td>23</td><td>YongGongType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>用工类型</td></tr>
    /// <tr valign="top"><td>24</td><td>ContractExpireDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>合同到期日</td></tr>
    /// <tr valign="top"><td>25</td><td>ContractMoney</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td>√</td><td></td><td>合同工资</td></tr>
    /// <tr valign="top"><td>26</td><td>Mark</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// <tr valign="top"><td>27</td><td>HuJi</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>户籍</td></tr>
    /// <tr valign="top"><td>28</td><td>CurrentLiving</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>现住地址</td></tr>
    /// <tr valign="top"><td>29</td><td>HuJiLiving</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>户籍地址</td></tr>
    /// <tr valign="top"><td>30</td><td>HuJiType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>户籍性质</td></tr>
    /// <tr valign="top"><td>31</td><td>SheBaoType</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>社保类型</td></tr>
    /// <tr valign="top"><td>32</td><td>BaseSheBaoMoney</td><td>decimal</td><td>9</td><td>18,0</td><td></td><td></td><td>√</td><td></td><td>社保基数</td></tr>
    /// <tr valign="top"><td>33</td><td>SheBaoStartDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>社保起缴日期</td></tr>
    /// <tr valign="top"><td>34</td><td>GongJiJingNumber</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>公积金帐号</td></tr>
    /// <tr valign="top"><td>35</td><td>HeTongQiXian</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>合同期限</td></tr>
    /// <tr valign="top"><td>36</td><td>WorkAge</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>工龄</td></tr>
    /// <tr valign="top"><td>37</td><td>BankCard</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>银行卡号</td></tr>
    /// <tr valign="top"><td>38</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店</td></tr>
    /// <tr valign="top"><td>39</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名</td></tr>
    /// <tr valign="top"><td>40</td><td>FuZhuangChiCun</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>服装尺寸</td></tr>
    /// <tr valign="top"><td>41</td><td>XieMa</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>鞋码</td></tr>
    /// <tr valign="top"><td>42</td><td>JinShengDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>晋升日期</td></tr>
    /// <tr valign="top"><td>43</td><td>LiZhiDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>离职日期</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("GuYuanUser")]
    [Serializable]
    public partial class GuYuanUser
    {

        public static string LogClass = "雇员";
        #region -  公共属性  ------------------------------------------------------------

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
        /// 部门名
        /// </summary>
        private string _DepartmentName = "";
        /// <summary>
        /// 部门名
        /// </summary>
        [DisplayName("部门名")]

        public string DepartmentName
        {
            set { _DepartmentName = value; }
            get { return _DepartmentName; }
        }



        /// <summary>
        /// 状态
        /// </summary>
        private string _State = "";
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
        /// 操作员名_optname
        /// </summary>
        private string _OptName = "";
        /// <summary>
        /// 操作员名_optname
        /// </summary>
        [DisplayName("操作员名")]

        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }



        /// <summary>
        /// 操作员_optid
        /// </summary>
        private int? _OptId;
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
        /// 创建时间_createdate
        /// </summary>
        private DateTime? _createdate;
        /// <summary>
        /// 创建时间_createdate
        /// </summary>
        [DisplayName("创建时间")]

        public DateTime? createdate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }

        private DateTime _createdateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime createdateStart
        {
            set { _createdateStart = value; }
            get { return _createdateStart; }
        }
        private DateTime _createdateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime createdateEnd
        {
            set { _createdateEnd = value; }
            get { return _createdateEnd; }
        }


        /// <summary>
        /// 姓名
        /// </summary>
        private string _Name = "";
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName("姓名")]

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }



        /// <summary>
        /// 岗位名
        /// </summary>
        private string _PositionName = "";
        /// <summary>
        /// 岗位名
        /// </summary>
        [DisplayName("岗位名")]

        public string PositionName
        {
            set { _PositionName = value; }
            get { return _PositionName; }
        }



        /// <summary>
        /// 性别
        /// </summary>
        private string _Sex = "";
        /// <summary>
        /// 性别
        /// </summary>
        [DisplayName("性别")]

        public string Sex
        {
            set { _Sex = value; }
            get { return _Sex; }
        }



        /// <summary>
        /// 入职日期
        /// </summary>
        private DateTime? _OnboardDate;
        /// <summary>
        /// 入职日期
        /// </summary>
        [DisplayName("入职日期")]

        public DateTime? OnboardDate
        {
            set { _OnboardDate = value; }
            get { return _OnboardDate; }
        }

        private DateTime _OnboardDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime OnboardDateStart
        {
            set { _OnboardDateStart = value; }
            get { return _OnboardDateStart; }
        }
        private DateTime _OnboardDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime OnboardDateEnd
        {
            set { _OnboardDateEnd = value; }
            get { return _OnboardDateEnd; }
        }


        /// <summary>
        /// 转正日期
        /// </summary>
        private DateTime? _FullMemberDate;
        /// <summary>
        /// 转正日期
        /// </summary>
        [DisplayName("转正日期")]

        public DateTime? FullMemberDate
        {
            set { _FullMemberDate = value; }
            get { return _FullMemberDate; }
        }

        private DateTime _FullMemberDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime FullMemberDateStart
        {
            set { _FullMemberDateStart = value; }
            get { return _FullMemberDateStart; }
        }
        private DateTime _FullMemberDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime FullMemberDateEnd
        {
            set { _FullMemberDateEnd = value; }
            get { return _FullMemberDateEnd; }
        }


        /// <summary>
        /// 民族
        /// </summary>
        private string _Nationality = "";
        /// <summary>
        /// 民族
        /// </summary>
        [DisplayName("民族")]

        public string Nationality
        {
            set { _Nationality = value; }
            get { return _Nationality; }
        }



        /// <summary>
        /// 政治面貌
        /// </summary>
        private string _Polity = "";
        /// <summary>
        /// 政治面貌
        /// </summary>
        [DisplayName("政治面貌")]

        public string Polity
        {
            set { _Polity = value; }
            get { return _Polity; }
        }



        /// <summary>
        /// 生日
        /// </summary>
        private DateTime? _Birthday;
        /// <summary>
        /// 生日
        /// </summary>
        [DisplayName("生日")]

        public DateTime? Birthday
        {
            set { _Birthday = value; }
            get { return _Birthday; }
        }

        private DateTime _BirthdayStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime BirthdayStart
        {
            set { _BirthdayStart = value; }
            get { return _BirthdayStart; }
        }
        private DateTime _BirthdayEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime BirthdayEnd
        {
            set { _BirthdayEnd = value; }
            get { return _BirthdayEnd; }
        }


        /// <summary>
        /// 身份证
        /// </summary>
        private string _IDCard = "";
        /// <summary>
        /// 身份证
        /// </summary>
        [DisplayName("身份证")]

        public string IDCard
        {
            set { _IDCard = value; }
            get { return _IDCard; }
        }



        /// <summary>
        /// 年龄
        /// </summary>
        private int? _Age;
        /// <summary>
        /// 年龄
        /// </summary>
        [DisplayName("年龄")]

        public int? Age
        {
            set { _Age = value; }
            get { return _Age; }
        }



        /// <summary>
        /// 手机
        /// </summary>
        private string _Phone = "";
        /// <summary>
        /// 手机
        /// </summary>
        [DisplayName("手机")]

        public string Phone
        {
            set { _Phone = value; }
            get { return _Phone; }
        }



        /// <summary>
        /// 婚姻状况
        /// </summary>
        private string _Marry = "";
        /// <summary>
        /// 婚姻状况
        /// </summary>
        [DisplayName("婚姻状况")]

        public string Marry
        {
            set { _Marry = value; }
            get { return _Marry; }
        }



        /// <summary>
        /// 学历
        /// </summary>
        private string _Education = "";
        /// <summary>
        /// 学历
        /// </summary>
        [DisplayName("学历")]

        public string Education
        {
            set { _Education = value; }
            get { return _Education; }
        }



        /// <summary>
        /// 紧急联系人
        /// </summary>
        private string _EmergencyName = "";
        /// <summary>
        /// 紧急联系人
        /// </summary>
        [DisplayName("紧急联系人")]

        public string EmergencyName
        {
            set { _EmergencyName = value; }
            get { return _EmergencyName; }
        }



        /// <summary>
        /// 紧急联系人关系
        /// </summary>
        private string _EmergencyRelation = "";
        /// <summary>
        /// 紧急联系人关系
        /// </summary>
        [DisplayName("紧急联系人关系")]

        public string EmergencyRelation
        {
            set { _EmergencyRelation = value; }
            get { return _EmergencyRelation; }
        }



        /// <summary>
        /// 紧急联系人电话
        /// </summary>
        private string _EmergencyPhone = "";
        /// <summary>
        /// 紧急联系人电话
        /// </summary>
        [DisplayName("紧急联系人电话")]

        public string EmergencyPhone
        {
            set { _EmergencyPhone = value; }
            get { return _EmergencyPhone; }
        }



        /// <summary>
        /// 用工类型
        /// </summary>
        private string _YongGongType = "";
        /// <summary>
        /// 用工类型
        /// </summary>
        [DisplayName("用工类型")]

        public string YongGongType
        {
            set { _YongGongType = value; }
            get { return _YongGongType; }
        }



        /// <summary>
        /// 合同到期日
        /// </summary>
        private DateTime? _ContractExpireDate;
        /// <summary>
        /// 合同到期日
        /// </summary>
        [DisplayName("合同到期日")]

        public DateTime? ContractExpireDate
        {
            set { _ContractExpireDate = value; }
            get { return _ContractExpireDate; }
        }

        private DateTime _ContractExpireDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime ContractExpireDateStart
        {
            set { _ContractExpireDateStart = value; }
            get { return _ContractExpireDateStart; }
        }
        private DateTime _ContractExpireDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime ContractExpireDateEnd
        {
            set { _ContractExpireDateEnd = value; }
            get { return _ContractExpireDateEnd; }
        }


        /// <summary>
        /// 合同工资
        /// </summary>
        private decimal? _ContractMoney;
        /// <summary>
        /// 合同工资
        /// </summary>
        [DisplayName("合同工资")]

        public decimal? ContractMoney
        {
            set { _ContractMoney = value; }
            get { return _ContractMoney; }
        }



        /// <summary>
        /// 备注
        /// </summary>
        private string _Mark = "";
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
        /// 户籍
        /// </summary>
        private string _HuJi = "";
        /// <summary>
        /// 户籍
        /// </summary>
        [DisplayName("户籍")]

        public string HuJi
        {
            set { _HuJi = value; }
            get { return _HuJi; }
        }



        /// <summary>
        /// 现住地址
        /// </summary>
        private string _CurrentLiving = "";
        /// <summary>
        /// 现住地址
        /// </summary>
        [DisplayName("现住地址")]

        public string CurrentLiving
        {
            set { _CurrentLiving = value; }
            get { return _CurrentLiving; }
        }



        /// <summary>
        /// 户籍地址
        /// </summary>
        private string _HuJiLiving = "";
        /// <summary>
        /// 户籍地址
        /// </summary>
        [DisplayName("户籍地址")]

        public string HuJiLiving
        {
            set { _HuJiLiving = value; }
            get { return _HuJiLiving; }
        }



        /// <summary>
        /// 户籍性质
        /// </summary>
        private string _HuJiType = "";
        /// <summary>
        /// 户籍性质
        /// </summary>
        [DisplayName("户籍性质")]

        public string HuJiType
        {
            set { _HuJiType = value; }
            get { return _HuJiType; }
        }



        /// <summary>
        /// 社保类型
        /// </summary>
        private string _SheBaoType = "";
        /// <summary>
        /// 社保类型
        /// </summary>
        [DisplayName("社保类型")]

        public string SheBaoType
        {
            set { _SheBaoType = value; }
            get { return _SheBaoType; }
        }



        /// <summary>
        /// 社保基数
        /// </summary>
        private decimal? _BaseSheBaoMoney;
        /// <summary>
        /// 社保基数
        /// </summary>
        [DisplayName("社保基数")]

        public decimal? BaseSheBaoMoney
        {
            set { _BaseSheBaoMoney = value; }
            get { return _BaseSheBaoMoney; }
        }



        /// <summary>
        /// 社保起缴日期
        /// </summary>
        private DateTime? _SheBaoStartDate;
        /// <summary>
        /// 社保起缴日期
        /// </summary>
        [DisplayName("社保起缴日期")]

        public DateTime? SheBaoStartDate
        {
            set { _SheBaoStartDate = value; }
            get { return _SheBaoStartDate; }
        }

        private DateTime _SheBaoStartDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime SheBaoStartDateStart
        {
            set { _SheBaoStartDateStart = value; }
            get { return _SheBaoStartDateStart; }
        }
        private DateTime _SheBaoStartDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime SheBaoStartDateEnd
        {
            set { _SheBaoStartDateEnd = value; }
            get { return _SheBaoStartDateEnd; }
        }


        /// <summary>
        /// 公积金帐号
        /// </summary>
        private string _GongJiJingNumber = "";
        /// <summary>
        /// 公积金帐号
        /// </summary>
        [DisplayName("公积金帐号")]

        public string GongJiJingNumber
        {
            set { _GongJiJingNumber = value; }
            get { return _GongJiJingNumber; }
        }



        /// <summary>
        /// 合同期限
        /// </summary>
        private string _HeTongQiXian = "";
        /// <summary>
        /// 合同期限
        /// </summary>
        [DisplayName("合同期限")]

        public string HeTongQiXian
        {
            set { _HeTongQiXian = value; }
            get { return _HeTongQiXian; }
        }



        /// <summary>
        /// 工龄
        /// </summary>
        private string _WorkAge = "";
        /// <summary>
        /// 工龄
        /// </summary>
        [DisplayName("工龄")]

        public string WorkAge
        {
            set { _WorkAge = value; }
            get { return _WorkAge; }
        }



        /// <summary>
        /// 银行卡号
        /// </summary>
        private string _BankCard = "";
        /// <summary>
        /// 银行卡号
        /// </summary>
        [DisplayName("银行卡号")]

        public string BankCard
        {
            set { _BankCard = value; }
            get { return _BankCard; }
        }



        /// <summary>
        /// 门店
        /// </summary>
        private int? _projectid;
        /// <summary>
        /// 门店
        /// </summary>
        [DisplayName("门店")]

        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }



        /// <summary>
        /// 门店名
        /// </summary>
        private string _ProjectName = "";
        /// <summary>
        /// 门店名
        /// </summary>
        [DisplayName("门店名")]

        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }



        /// <summary>
        /// 服装尺寸
        /// </summary>
        private string _FuZhuangChiCun = "";
        /// <summary>
        /// 服装尺寸
        /// </summary>
        [DisplayName("服装尺寸")]

        public string FuZhuangChiCun
        {
            set { _FuZhuangChiCun = value; }
            get { return _FuZhuangChiCun; }
        }



        /// <summary>
        /// 鞋码
        /// </summary>
        private string _XieMa = "";
        /// <summary>
        /// 鞋码
        /// </summary>
        [DisplayName("鞋码")]

        public string XieMa
        {
            set { _XieMa = value; }
            get { return _XieMa; }
        }



        /// <summary>
        /// 晋升日期
        /// </summary>
        private DateTime? _JinShengDate;
        /// <summary>
        /// 晋升日期
        /// </summary>
        [DisplayName("晋升日期")]

        public DateTime? JinShengDate
        {
            set { _JinShengDate = value; }
            get { return _JinShengDate; }
        }

        private DateTime _JinShengDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime JinShengDateStart
        {
            set { _JinShengDateStart = value; }
            get { return _JinShengDateStart; }
        }
        private DateTime _JinShengDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime JinShengDateEnd
        {
            set { _JinShengDateEnd = value; }
            get { return _JinShengDateEnd; }
        }


        /// <summary>
        /// 离职日期
        /// </summary>
        private DateTime? _LiZhiDate;
        /// <summary>
        /// 离职日期
        /// </summary>
        [DisplayName("离职日期")]

        public DateTime? LiZhiDate
        {
            set { _LiZhiDate = value; }
            get { return _LiZhiDate; }
        }

        private DateTime _LiZhiDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime LiZhiDateStart
        {
            set { _LiZhiDateStart = value; }
            get { return _LiZhiDateStart; }
        }
        private DateTime _LiZhiDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime LiZhiDateEnd
        {
            set { _LiZhiDateEnd = value; }
            get { return _LiZhiDateEnd; }
        }

        public Guid Guid { get; set; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class GuYuanUserReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 部门名
        /// </summary> 
        public string DepartmentName { get; set; }


        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get; set; }


        /// <summary>
        /// 操作员名_optname
        /// </summary> 
        public string OptName { get; set; }


        /// <summary>
        /// 操作员_optid
        /// </summary> 
        public int? OptId { get; set; }


        /// <summary>
        /// 创建时间_createdate
        /// </summary> 
        public DateTime? createdate { get; set; }

        private DateTime _createdateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime createdateStart
        {
            set { _createdateStart = value; }
            get { return _createdateStart; }
        }
        private DateTime _createdateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime createdateEnd
        {
            set { _createdateEnd = value; }
            get { return _createdateEnd; }
        }

        /// <summary>
        /// 姓名
        /// </summary> 
        public string Name { get; set; }


        /// <summary>
        /// 岗位名
        /// </summary> 
        public string PositionName { get; set; }


        /// <summary>
        /// 性别
        /// </summary> 
        public string Sex { get; set; }


        /// <summary>
        /// 入职日期
        /// </summary> 
        public DateTime? OnboardDate { get; set; }

        private DateTime _OnboardDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime OnboardDateStart
        {
            set { _OnboardDateStart = value; }
            get { return _OnboardDateStart; }
        }
        private DateTime _OnboardDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime OnboardDateEnd
        {
            set { _OnboardDateEnd = value; }
            get { return _OnboardDateEnd; }
        }

        /// <summary>
        /// 转正日期
        /// </summary> 
        public DateTime? FullMemberDate { get; set; }

        private DateTime _FullMemberDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime FullMemberDateStart
        {
            set { _FullMemberDateStart = value; }
            get { return _FullMemberDateStart; }
        }
        private DateTime _FullMemberDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime FullMemberDateEnd
        {
            set { _FullMemberDateEnd = value; }
            get { return _FullMemberDateEnd; }
        }

        /// <summary>
        /// 民族
        /// </summary> 
        public string Nationality { get; set; }


        /// <summary>
        /// 政治面貌
        /// </summary> 
        public string Polity { get; set; }


        /// <summary>
        /// 生日
        /// </summary> 
        public DateTime? Birthday { get; set; }

        private DateTime _BirthdayStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime BirthdayStart
        {
            set { _BirthdayStart = value; }
            get { return _BirthdayStart; }
        }
        private DateTime _BirthdayEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime BirthdayEnd
        {
            set { _BirthdayEnd = value; }
            get { return _BirthdayEnd; }
        }

        /// <summary>
        /// 身份证
        /// </summary> 
        public string IDCard { get; set; }


        /// <summary>
        /// 年龄
        /// </summary> 
        public int? Age { get; set; }


        /// <summary>
        /// 手机
        /// </summary> 
        public string Phone { get; set; }


        /// <summary>
        /// 婚姻状况
        /// </summary> 
        public string Marry { get; set; }


        /// <summary>
        /// 学历
        /// </summary> 
        public string Education { get; set; }


        /// <summary>
        /// 紧急联系人
        /// </summary> 
        public string EmergencyName { get; set; }


        /// <summary>
        /// 紧急联系人关系
        /// </summary> 
        public string EmergencyRelation { get; set; }


        /// <summary>
        /// 紧急联系人电话
        /// </summary> 
        public string EmergencyPhone { get; set; }


        /// <summary>
        /// 用工类型
        /// </summary> 
        public string YongGongType { get; set; }


        /// <summary>
        /// 合同到期日
        /// </summary> 
        public DateTime? ContractExpireDate { get; set; }

        private DateTime _ContractExpireDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime ContractExpireDateStart
        {
            set { _ContractExpireDateStart = value; }
            get { return _ContractExpireDateStart; }
        }
        private DateTime _ContractExpireDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime ContractExpireDateEnd
        {
            set { _ContractExpireDateEnd = value; }
            get { return _ContractExpireDateEnd; }
        }

        /// <summary>
        /// 合同工资
        /// </summary> 
        public decimal? ContractMoney { get; set; }


        /// <summary>
        /// 备注
        /// </summary> 
        public string Mark { get; set; }


        /// <summary>
        /// 户籍
        /// </summary> 
        public string HuJi { get; set; }


        /// <summary>
        /// 现住地址
        /// </summary> 
        public string CurrentLiving { get; set; }


        /// <summary>
        /// 户籍地址
        /// </summary> 
        public string HuJiLiving { get; set; }


        /// <summary>
        /// 户籍性质
        /// </summary> 
        public string HuJiType { get; set; }


        /// <summary>
        /// 社保类型
        /// </summary> 
        public string SheBaoType { get; set; }


        /// <summary>
        /// 社保基数
        /// </summary> 
        public decimal? BaseSheBaoMoney { get; set; }


        /// <summary>
        /// 社保起缴日期
        /// </summary> 
        public DateTime? SheBaoStartDate { get; set; }

        private DateTime _SheBaoStartDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime SheBaoStartDateStart
        {
            set { _SheBaoStartDateStart = value; }
            get { return _SheBaoStartDateStart; }
        }
        private DateTime _SheBaoStartDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime SheBaoStartDateEnd
        {
            set { _SheBaoStartDateEnd = value; }
            get { return _SheBaoStartDateEnd; }
        }

        /// <summary>
        /// 公积金帐号
        /// </summary> 
        public string GongJiJingNumber { get; set; }


        /// <summary>
        /// 合同期限
        /// </summary> 
        public string HeTongQiXian { get; set; }


        /// <summary>
        /// 工龄
        /// </summary> 
        public string WorkAge { get; set; }


        /// <summary>
        /// 银行卡号
        /// </summary> 
        public string BankCard { get; set; }


        /// <summary>
        /// 门店名
        /// </summary> 
        public string ProjectName { get; set; }


        /// <summary>
        /// 服装尺寸
        /// </summary> 
        public string FuZhuangChiCun { get; set; }


        /// <summary>
        /// 鞋码
        /// </summary> 
        public string XieMa { get; set; }


        /// <summary>
        /// 晋升日期
        /// </summary> 
        public DateTime? JinShengDate { get; set; }

        private DateTime _JinShengDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime JinShengDateStart
        {
            set { _JinShengDateStart = value; }
            get { return _JinShengDateStart; }
        }
        private DateTime _JinShengDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime JinShengDateEnd
        {
            set { _JinShengDateEnd = value; }
            get { return _JinShengDateEnd; }
        }

        /// <summary>
        /// 离职日期
        /// </summary> 
        public DateTime? LiZhiDate { get; set; }

        private DateTime _LiZhiDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime LiZhiDateStart
        {
            set { _LiZhiDateStart = value; }
            get { return _LiZhiDateStart; }
        }
        private DateTime _LiZhiDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime LiZhiDateEnd
        {
            set { _LiZhiDateEnd = value; }
            get { return _LiZhiDateEnd; }
        }

        [NotMapped]
        public int isHr { get; set; }

        #endregion ----------------------------------------------------------------------
    }

}

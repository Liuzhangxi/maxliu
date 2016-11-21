



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
    /// <para>摘要：MenDianFeeModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：MenDianFee
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>feiYongMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>金额</td></tr>
    /// <tr valign="top"><td>3</td><td>info</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// <tr valign="top"><td>4</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作员_optname</td></tr>
    /// <tr valign="top"><td>5</td><td>optId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作者_optid</td></tr>
    /// <tr valign="top"><td>6</td><td>createdate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>创建日期_createdate</td></tr>
    /// <tr valign="top"><td>7</td><td>checkName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审核者姓名</td></tr>
    /// <tr valign="top"><td>8</td><td>checkId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>审核者</td></tr>
    /// <tr valign="top"><td>9</td><td>checkDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>审核时间</td></tr>
    /// <tr valign="top"><td>10</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态</td></tr>
    /// <tr valign="top"><td>11</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>12</td><td>projectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>13</td><td>category</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>类别</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("MenDianFee")]
    [Serializable]
    public partial class MenDianFee
    {
        [DisplayName("交割信息")]
        public int? JiaoGeId { get; set; }



        public static string LogClass = "门店费用";
        [DisplayName("付款方式")]
        public string fkFangShi { get; set; }
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
        /// 金额
        /// </summary>
        private decimal? _feiYongMoney;
        /// <summary>
        /// 金额
        /// </summary>
        [DisplayName("金额")]

        public decimal? feiYongMoney
        {
            set { _feiYongMoney = value; }
            get { return _feiYongMoney; }
        }



        /// <summary>
        /// 备注
        /// </summary>
        private string _info = "";
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]

        public string info
        {
            set { _info = value; }
            get { return _info; }
        }



        /// <summary>
        /// 操作员_optname
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作员_optname
        /// </summary>
        [DisplayName("操作员")]

        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }



        /// <summary>
        /// 操作者_optid
        /// </summary>
        private int? _optId;
        /// <summary>
        /// 操作者_optid
        /// </summary>
        [DisplayName("操作者")]

        public int? optId
        {
            set { _optId = value; }
            get { return _optId; }
        }



        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        private DateTime? _createdate;
        /// <summary>
        /// 创建日期_createdate
        /// </summary>
        [DisplayName("创建日期")]

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
        /// 付款日期_payDate
        /// </summary>
        private DateTime? _payDate;
        /// <summary>
        /// 付款日期_payDate
        /// </summary>
        [DisplayName("付款时间")]

        public DateTime? payDate
        {
            set { _payDate = value; }
            get { return _payDate; }
        }

        private DateTime _payDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime payDateStart
        {
            set { _payDateStart = value; }
            get { return _payDateStart; }
        }
        private DateTime _payDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime payDateEnd
        {
            set { _payDateEnd = value; }
            get { return _payDateEnd; }
        }


        /// <summary>
        /// 审核者姓名
        /// </summary>
        private string _checkName = "";
        /// <summary>
        /// 审核者姓名
        /// </summary>
        [DisplayName("审核者姓名")]

        public string checkName
        {
            set { _checkName = value; }
            get { return _checkName; }
        }



        /// <summary>
        /// 审核者
        /// </summary>
        private int? _checkId;
        /// <summary>
        /// 审核者
        /// </summary>
        [DisplayName(@"审核者id")]

        public int? checkId
        {
            set { _checkId = value; }
            get { return _checkId; }
        }



        /// <summary>
        /// 审核时间
        /// </summary>
        private DateTime? _checkDate;
        /// <summary>
        /// 审核时间
        /// </summary>
        [DisplayName("审核时间")]

        public DateTime? checkDate
        {
            set { _checkDate = value; }
            get { return _checkDate; }
        }

        private DateTime _checkDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkDateStart
        {
            set { _checkDateStart = value; }
            get { return _checkDateStart; }
        }
        private DateTime _checkDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkDateEnd
        {
            set { _checkDateEnd = value; }
            get { return _checkDateEnd; }
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
        /// 门店_projectid
        /// </summary>
        private int? _projectid;
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
        private string _projectName = "";
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        [DisplayName("门店名")]

        public string projectName
        {
            set { _projectName = value; }
            get { return _projectName; }
        }



        /// <summary>
        /// 类别
        /// </summary>
        private string _category = "";
        /// <summary>
        /// 类别
        /// </summary>
        [DisplayName("类别")]

        public string category
        {
            set { _category = value; }
            get { return _category; }
        }




        #endregion ----------------------------------------------------------------------
    }

    public partial class MenDianFeeReq : BaseSearchReq
    {
        [DisplayName("交割信息")]
        public int? JiaoGeId { get; set; }
        [DisplayName("付款方式")]
        public string fkFangShi { get; set; }
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 金额
        /// </summary> 
        public decimal? feiYongMoney { get; set; }


        /// <summary>
        /// 备注
        /// </summary> 
        public string info { get; set; }


        /// <summary>
        /// 操作员_optname
        /// </summary> 
        public string optName { get; set; }


        /// <summary>
        /// 操作者_optid
        /// </summary> 
        public int? optId { get; set; }


        /// <summary>
        /// 创建日期_createdate
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
        /// 付款日期_payDate
        /// </summary> 
        public DateTime? payDate { get; set; }

        private DateTime _payDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime payDateStart
        {
            set { _payDateStart = value; }
            get { return _payDateStart; }
        }
        private DateTime _payDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime payDateEnd
        {
            set { _payDateEnd = value; }
            get { return _payDateEnd; }
        }


        /// <summary>
        /// 审核者姓名
        /// </summary> 
        public string checkName { get; set; }


        /// <summary>
        /// 审核者
        /// </summary> 
        public int? checkId { get; set; }


        /// <summary>
        /// 审核时间
        /// </summary> 
        public DateTime? checkDate { get; set; }

        private DateTime _checkDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkDateStart
        {
            set { _checkDateStart = value; }
            get { return _checkDateStart; }
        }
        private DateTime _checkDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkDateEnd
        {
            set { _checkDateEnd = value; }
            get { return _checkDateEnd; }
        }

        /// <summary>
        /// 状态
        /// </summary> 
        public string State { get; set; }


        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string projectName { get; set; }


        /// <summary>
        /// 类别
        /// </summary> 
        public string category { get; set; }




        #endregion ----------------------------------------------------------------------
    }

}

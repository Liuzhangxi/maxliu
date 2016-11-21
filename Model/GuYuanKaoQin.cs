



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
    /// <para>摘要：GuYuanKaoQinModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：GuYuanKaoQin
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>bigint</td><td>8</td><td></td><td>√</td><td>√</td><td></td><td></td><td>id</td></tr>
    /// <tr valign="top"><td>2</td><td>guyuanId</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>员工id</td></tr>
    /// <tr valign="top"><td>3</td><td>guyuanName</td><td>varchar</td><td>1</td><td></td><td></td><td></td><td>√</td><td></td><td>员工姓名</td></tr>
    /// <tr valign="top"><td>4</td><td>workDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>工作日</td></tr>
    /// <tr valign="top"><td>5</td><td>checkType</td><td>varchar</td><td>255</td><td></td><td></td><td></td><td>√</td><td></td><td>考勤类型</td></tr>
    /// <tr valign="top"><td>6</td><td>checkResult</td><td>varchar</td><td>255</td><td></td><td></td><td></td><td>√</td><td></td><td>考勤结果</td></tr>
    /// <tr valign="top"><td>7</td><td>checkTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>打卡时间</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("GuYuanKaoQin")]
    [Serializable]
    public partial class GuYuanKaoQin
    {

        public static string LogClass = "员工考勤表";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// id
        /// </summary>
        private long _id;
        /// <summary>
        /// id
        /// </summary>
        [Key]

        public long id
        {
            set { _id = value; }
            get { return _id; }
        }



        /// <summary>
        /// 员工id
        /// </summary>
        private int _guyuanId;
        /// <summary>
        /// 员工id
        /// </summary>
        [DisplayName("员工id")]
        [Required]
        public int guyuanId
        {
            set { _guyuanId = value; }
            get { return _guyuanId; }
        }



        /// <summary>
        /// 员工姓名
        /// </summary>
        private string _guyuanName = "";
        /// <summary>
        /// 员工姓名
        /// </summary>
        [DisplayName("员工姓名")]

        public string guyuanName
        {
            set { _guyuanName = value; }
            get { return _guyuanName; }
        }



        /// <summary>
        /// 工作日
        /// </summary>
        private DateTime? _workDate;
        /// <summary>
        /// 工作日
        /// </summary>
        [DisplayName("工作日")]

        public DateTime? workDate
        {
            set { _workDate = value; }
            get { return _workDate; }
        }

        private DateTime _workDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime workDateStart
        {
            set { _workDateStart = value; }
            get { return _workDateStart; }
        }
        private DateTime _workDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime workDateEnd
        {
            set { _workDateEnd = value; }
            get { return _workDateEnd; }
        }


        /// <summary>
        /// 考勤类型
        /// </summary>
        private string _checkType = "";
        /// <summary>
        /// 考勤类型
        /// </summary>
        [DisplayName("考勤类型")]

        public string checkType
        {
            set { _checkType = value; }
            get { return _checkType; }
        }



        /// <summary>
        /// 考勤结果
        /// </summary>
        private string _checkResult = "";
        /// <summary>
        /// 考勤结果
        /// </summary>
        [DisplayName("考勤结果")]

        public string checkResult
        {
            set { _checkResult = value; }
            get { return _checkResult; }
        }



        /// <summary>
        /// 打卡时间
        /// </summary>
        private DateTime? _checkTime;
        /// <summary>
        /// 打卡时间
        /// </summary>
        [DisplayName("打卡时间")]

        public DateTime? checkTime
        {
            set { _checkTime = value; }
            get { return _checkTime; }
        }

        private DateTime _checkTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkTimeStart
        {
            set { _checkTimeStart = value; }
            get { return _checkTimeStart; }
        }
        private DateTime _checkTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkTimeEnd
        {
            set { _checkTimeEnd = value; }
            get { return _checkTimeEnd; }
        }

        public string externalId { get; set; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class GuYuanKaoQinReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// id
        /// </summary> 
        public long id { get; set; }


        /// <summary>
        /// 员工id
        /// </summary> 
        public int? guyuanId { get; set; }


        /// <summary>
        /// 员工姓名
        /// </summary> 
        public string guyuanName { get; set; }


        /// <summary>
        /// 工作日
        /// </summary> 
        public DateTime? workDate { get; set; }

        private DateTime _workDateStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime workDateStart
        {
            set { _workDateStart = value; }
            get { return _workDateStart; }
        }
        private DateTime _workDateEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime workDateEnd
        {
            set { _workDateEnd = value; }
            get { return _workDateEnd; }
        }

        /// <summary>
        /// 考勤类型
        /// </summary> 
        public string checkType { get; set; }


        /// <summary>
        /// 考勤结果
        /// </summary> 
        public string checkResult { get; set; }


        /// <summary>
        /// 打卡时间
        /// </summary> 
        public DateTime? checkTime { get; set; }

        private DateTime _checkTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkTimeStart
        {
            set { _checkTimeStart = value; }
            get { return _checkTimeStart; }
        }
        private DateTime _checkTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime checkTimeEnd
        {
            set { _checkTimeEnd = value; }
            get { return _checkTimeEnd; }
        }

        public string externalId { get; set; }

        [NotMapped]
        /// <summary>
        /// 月份
        /// </summary>
        public string Month { get; set; }
        #endregion ----------------------------------------------------------------------
    }


    public partial class GuYuanMonthKaoQin : BaseSearchReq
    {
        /// <summary>
        /// id
        /// </summary> 
        public long id { get; set; }


        /// <summary>
        /// 员工id
        /// </summary> 
        public int? guyuanId { get; set; }


        /// <summary>
        /// 员工姓名
        /// </summary> 
        public string guyuanName { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// 迟到分钟
        /// </summary>
        public int ChiDaoFenzhong { get; set; }

        /// <summary>
        /// 迟到次数
        /// </summary>
        public int ChiDaoCiShu { get; set; }

        /// <summary>
        /// 迟到次数(30分钟以上)
        /// </summary>
        public int ChiDaoLongCiShu { get; set; }

        /// <summary>
        /// 早退分钟
        /// </summary>
        public int ZaoTuiFenzhong { get; set; }

        /// <summary>
        /// 早退次数
        /// </summary>
        public int ZaoTuiCiShu { get; set; }

        /// <summary>
        /// 早退次数(30分钟以上)
        /// </summary>
        public int ZaoTuiLongCiShu { get; set; }

        /// <summary>
        /// 旷工工时
        /// </summary>
        public int KuangGongGongShi { get; set; }

        /// <summary>
        /// 旷工次数
        /// </summary>
        public int KuangGongCiShu { get; set; }

        public string externalId { get; set; }
    }
}

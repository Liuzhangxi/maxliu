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
    /// <para>摘要：DingTalkKaoqinModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：DingTalkKaoqin
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>bigint</td><td>8</td><td></td><td>√</td><td>√</td><td></td><td></td><td>唯一标示ID（丁丁考勤）</td></tr>
    /// <tr valign="top"><td>2</td><td>groupId</td><td>bigint</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>考勤组ID</td></tr>
    /// <tr valign="top"><td>3</td><td>planId</td><td>bigint</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>排班ID</td></tr>
    /// <tr valign="top"><td>4</td><td>recordId</td><td>bigint</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>打卡记录ID</td></tr>
    /// <tr valign="top"><td>5</td><td>workDate</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>工作日</td></tr>
    /// <tr valign="top"><td>6</td><td>userId</td><td>bigint</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>用户ID</td></tr>
    /// <tr valign="top"><td>7</td><td>checkType</td><td>varchar</td><td>255</td><td></td><td></td><td></td><td>√</td><td></td><td>考勤类型（OnDuty：上班，OffDuty：下班）</td></tr>
    /// <tr valign="top"><td>8</td><td>sourceType</td><td>varchar</td><td>255</td><td></td><td></td><td></td><td>√</td><td></td><td>数据来源（ATM：考勤机,USER：用户打卡,BOSS：老板改签,APPROVE：审批系统,RECHECK：重新计算, SYSTEM：考勤系统）</td></tr>
    /// <tr valign="top"><td>9</td><td>timeResult</td><td>varchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>时间结果（Normal:正常;Early:早退; Late:迟到;SeriousLate:严重迟到；NotSigned:未打卡）</td></tr>
    /// <tr valign="top"><td>10</td><td>locationResult</td><td>varchar</td><td>255</td><td></td><td></td><td></td><td>√</td><td></td><td>位置结果（Normal:范围内；Outside:范围外）</td></tr>
    /// <tr valign="top"><td>11</td><td>approveResult</td><td>varchar</td><td>255</td><td></td><td></td><td></td><td>√</td><td></td><td>打卡审批结果（ Leave(1, “请假”),GoOut(3, “外出”),BusinessTrip(2, “出差”),FreeAttend(6, “免打卡”);）</td></tr>
    /// <tr valign="top"><td>12</td><td>approveId</td><td>bigint</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>关联的审批id</td></tr>
    /// <tr valign="top"><td>13</td><td>baseCheckTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>基准时间（计算迟到和早退）</td></tr>
    /// <tr valign="top"><td>14</td><td>userCheckTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>实际打卡时间</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("DingTalkKaoQin")]
    [Serializable]
    public partial class DingTalkKaoQin
    {

        public static string LogClass = "钉钉考勤表";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 唯一标示ID（丁丁考勤）
        /// </summary>
        private long _id;
        /// <summary>
        /// 唯一标示ID（丁丁考勤）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }



        /// <summary>
        /// 考勤组ID
        /// </summary>
        private long? _groupId;
        /// <summary>
        /// 考勤组ID
        /// </summary>
        [DisplayName("考勤组ID")]

        public long? groupId
        {
            set { _groupId = value; }
            get { return _groupId; }
        }



        /// <summary>
        /// 排班ID
        /// </summary>
        private long? _planId;
        /// <summary>
        /// 排班ID
        /// </summary>
        [DisplayName("排班ID")]

        public long? planId
        {
            set { _planId = value; }
            get { return _planId; }
        }



        /// <summary>
        /// 打卡记录ID
        /// </summary>
        private long? _recordId;
        /// <summary>
        /// 打卡记录ID
        /// </summary>
        [DisplayName("打卡记录ID")]

        public long? recordId
        {
            set { _recordId = value; }
            get { return _recordId; }
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
        /// 用户ID
        /// </summary>
        private string _userId;
        /// <summary>
        /// 用户ID
        /// </summary>
        [DisplayName("用户ID")]

        public string userId
        {
            set { _userId = value; }
            get { return _userId; }
        }



        /// <summary>
        /// 考勤类型（OnDuty：上班，OffDuty：下班）
        /// </summary>
        private string _checkType = "";
        /// <summary>
        /// 考勤类型（OnDuty：上班，OffDuty：下班）
        /// </summary>
        [DisplayName("考勤类型")]

        public string checkType
        {
            set { _checkType = value; }
            get { return _checkType; }
        }



        /// <summary>
        /// 数据来源（ATM：考勤机,USER：用户打卡,BOSS：老板改签,APPROVE：审批系统,RECHECK：重新计算, SYSTEM：考勤系统）
        /// </summary>
        private string _sourceType = "";
        /// <summary>
        /// 数据来源（ATM：考勤机,USER：用户打卡,BOSS：老板改签,APPROVE：审批系统,RECHECK：重新计算, SYSTEM：考勤系统）
        /// </summary>
        [DisplayName("数据来源")]

        public string sourceType
        {
            set { _sourceType = value; }
            get { return _sourceType; }
        }



        /// <summary>
        /// 时间结果（Normal:正常;Early:早退; Late:迟到;SeriousLate:严重迟到；NotSigned:未打卡）
        /// </summary>
        private string _timeResult = "";
        /// <summary>
        /// 时间结果（Normal:正常;Early:早退; Late:迟到;SeriousLate:严重迟到；NotSigned:未打卡）
        /// </summary>
        [DisplayName("时间结果")]

        public string timeResult
        {
            set { _timeResult = value; }
            get { return _timeResult; }
        }



        /// <summary>
        /// 位置结果（Normal:范围内；Outside:范围外）
        /// </summary>
        private string _locationResult = "";
        /// <summary>
        /// 位置结果（Normal:范围内；Outside:范围外）
        /// </summary>
        [DisplayName("位置结果")]

        public string locationResult
        {
            set { _locationResult = value; }
            get { return _locationResult; }
        }



        /// <summary>
        /// 打卡审批结果（ Leave(1, “请假”),GoOut(3, “外出”),BusinessTrip(2, “出差”),FreeAttend(6, “免打卡”);）
        /// </summary>
        private string _approveResult = "";
        /// <summary>
        /// 打卡审批结果（ Leave(1, “请假”),GoOut(3, “外出”),BusinessTrip(2, “出差”),FreeAttend(6, “免打卡”);）
        /// </summary>
        [DisplayName("打卡审批结果")]

        public string approveResult
        {
            set { _approveResult = value; }
            get { return _approveResult; }
        }



        /// <summary>
        /// 关联的审批id
        /// </summary>
        private long? _approveId;
        /// <summary>
        /// 关联的审批id
        /// </summary>
        [DisplayName("关联的审批id")]

        public long? approveId
        {
            set { _approveId = value; }
            get { return _approveId; }
        }



        /// <summary>
        /// 基准时间（计算迟到和早退）
        /// </summary>
        private DateTime? _baseCheckTime;
        /// <summary>
        /// 基准时间（计算迟到和早退）
        /// </summary>
        [DisplayName("基准时间")]

        public DateTime? baseCheckTime
        {
            set { _baseCheckTime = value; }
            get { return _baseCheckTime; }
        }

        private DateTime _baseCheckTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime baseCheckTimeStart
        {
            set { _baseCheckTimeStart = value; }
            get { return _baseCheckTimeStart; }
        }
        private DateTime _baseCheckTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime baseCheckTimeEnd
        {
            set { _baseCheckTimeEnd = value; }
            get { return _baseCheckTimeEnd; }
        }


        /// <summary>
        /// 实际打卡时间
        /// </summary>
        private DateTime? _userCheckTime;
        /// <summary>
        /// 实际打卡时间
        /// </summary>
        [DisplayName("实际打卡时间")]

        public DateTime? userCheckTime
        {
            set { _userCheckTime = value; }
            get { return _userCheckTime; }
        }

        private DateTime _userCheckTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime userCheckTimeStart
        {
            set { _userCheckTimeStart = value; }
            get { return _userCheckTimeStart; }
        }
        private DateTime _userCheckTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime userCheckTimeEnd
        {
            set { _userCheckTimeEnd = value; }
            get { return _userCheckTimeEnd; }
        }



        #endregion ----------------------------------------------------------------------
    }

    public partial class DingTalkKaoQinReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 唯一标示ID（丁丁考勤）
        /// </summary> 
        public long id { get; set; }


        /// <summary>
        /// 考勤组ID
        /// </summary> 
        public long? groupId { get; set; }


        /// <summary>
        /// 排班ID
        /// </summary> 
        public long? planId { get; set; }


        /// <summary>
        /// 打卡记录ID
        /// </summary> 
        public long? recordId { get; set; }


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
        /// 用户ID
        /// </summary> 
        public string userId { get; set; }


        /// <summary>
        /// 考勤类型（OnDuty：上班，OffDuty：下班）
        /// </summary> 
        public string checkType { get; set; }


        /// <summary>
        /// 数据来源（ATM：考勤机,USER：用户打卡,BOSS：老板改签,APPROVE：审批系统,RECHECK：重新计算, SYSTEM：考勤系统）
        /// </summary> 
        public string sourceType { get; set; }


        /// <summary>
        /// 时间结果（Normal:正常;Early:早退; Late:迟到;SeriousLate:严重迟到；NotSigned:未打卡）
        /// </summary> 
        public string timeResult { get; set; }


        /// <summary>
        /// 位置结果（Normal:范围内；Outside:范围外）
        /// </summary> 
        public string locationResult { get; set; }


        /// <summary>
        /// 打卡审批结果（ Leave(1, “请假”),GoOut(3, “外出”),BusinessTrip(2, “出差”),FreeAttend(6, “免打卡”);）
        /// </summary> 
        public string approveResult { get; set; }


        /// <summary>
        /// 关联的审批id
        /// </summary> 
        public long? approveId { get; set; }


        /// <summary>
        /// 基准时间（计算迟到和早退）
        /// </summary> 
        public DateTime? baseCheckTime { get; set; }

        private DateTime _baseCheckTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime baseCheckTimeStart
        {
            set { _baseCheckTimeStart = value; }
            get { return _baseCheckTimeStart; }
        }
        private DateTime _baseCheckTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime baseCheckTimeEnd
        {
            set { _baseCheckTimeEnd = value; }
            get { return _baseCheckTimeEnd; }
        }

        /// <summary>
        /// 实际打卡时间
        /// </summary> 
        public DateTime? userCheckTime { get; set; }

        private DateTime _userCheckTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime userCheckTimeStart
        {
            set { _userCheckTimeStart = value; }
            get { return _userCheckTimeStart; }
        }
        private DateTime _userCheckTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime userCheckTimeEnd
        {
            set { _userCheckTimeEnd = value; }
            get { return _userCheckTimeEnd; }
        }



        #endregion ----------------------------------------------------------------------
    }

}

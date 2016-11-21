



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
    /// <para>摘要：yuezihuiSuoInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：yuezihuiSuoInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>huiSuoName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>会所名</td></tr>
    /// <tr valign="top"><td>3</td><td>huiSuoStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td>((1))</td><td>会所状态</td></tr>
    /// <tr valign="top"><td>4</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作员</td></tr>
    /// <tr valign="top"><td>5</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td>(getdate())</td><td>操作时间_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("yuezihuiSuoInfo")]
    [Serializable]
    public partial class sao1saoyuezihuiSuoInfo
    {

        public static string LogClass = "会所信息";
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
        /// 会所名
        /// </summary>
        private string _huiSuoName = "";
        /// <summary>
        /// 会所名
        /// </summary>
        [DisplayName("会所名")]
        [Required]
        public string huiSuoName
        {
            set { _huiSuoName = value; }
            get { return _huiSuoName; }
        }

        [DisplayName("会所地址")]
        public string huiSuoAddress
        {
            get; set;
        }

        [DisplayName("所在城市")]
        public int? FuWuDianCity
        {
            get; set;
        }

        [DisplayName("所属项目公司")]
        public int? projectID
        {
            get; set;
        }

        [DisplayName("会所类型")]
        public string huiSuoType
        {
            get; set;
        }

        /// <summary>
        /// 会所状态
        /// </summary>
        private int _huiSuoStateID;
        /// <summary>
        /// 会所状态
        /// </summary>
        [DisplayName("会所状态")]
        [Required]
        public int huiSuoStateID
        {
            set { _huiSuoStateID = value; }
            get { return _huiSuoStateID; }
        }

        /// <summary>
        /// 操作员
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作员
        /// </summary>
        [DisplayName("操作员")]
        [Required]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }

        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        private DateTime _optDateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间_createdate
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


        [NotMapped]
        public string huiSuoStateName
        {

            get
            {
                if (huiSuoStateID == 1)
                    return "有效";
                else
                    return "无效";
            }
        }

        [NotMapped]
        public string cityName
        {
            get; set;
        }

        [NotMapped]
        public string Name
        {
            get; set;
        }

        public int? xixiHuisuoId { get; set; }

        #endregion ----------------------------------------------------------------------
    }
}





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
    /// <para>摘要：JMSGengZongModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：JMSGengZong
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JmsID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>加盟商ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟商名称</td></tr>
    /// <tr valign="top"><td>4</td><td>LxrID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>联系人ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>5</td><td>LxrName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>联系人名字</td></tr>
    /// <tr valign="top"><td>6</td><td>GenzongInfo</td><td>nvarchar</td><td>500</td><td></td><td></td><td></td><td></td><td></td><td>跟踪情况_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>7</td><td>GengzongDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>跟踪时间</td></tr>
    /// <tr valign="top"><td>8</td><td>GenzongStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>跟踪状态</td></tr>
    /// <tr valign="top"><td>9</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>10</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_listhidden_searchhidden_createdate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JMSGengZong")]
    [Serializable]
    public partial class JMSGengZong
    {

        public static string LogClass = "加盟商跟踪记录表";

        #region -  公共属性  ------------------------------------------------------------

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
        /// 加盟商ID_listhidden_searchhidden
        /// </summary>
        private int _JmsID;

        /// <summary>
        /// 加盟商ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟商ID")]
        [Required]
        public int JmsID
        {
            set { _JmsID = value; }
            get { return _JmsID; }
        }



        /// <summary>
        /// 加盟商名称
        /// </summary>
        private string _JmsName = "";

        /// <summary>
        /// 加盟商名称
        /// </summary>
        [DisplayName("加盟商名称")]
        [Required]
        public string JmsName
        {
            set { _JmsName = value; }
            get { return _JmsName; }
        }



        /// <summary>
        /// 联系人ID_listhidden_searchhidden
        /// </summary>
        private int _LxrID;

        /// <summary>
        /// 联系人ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("联系人ID")]
        [Required]
        public int LxrID
        {
            set { _LxrID = value; }
            get { return _LxrID; }
        }



        /// <summary>
        /// 联系人名字
        /// </summary>
        private string _LxrName = "";

        /// <summary>
        /// 联系人名字
        /// </summary>
        [DisplayName("联系人名字")]
        [Required]
        public string LxrName
        {
            set { _LxrName = value; }
            get { return _LxrName; }
        }



        /// <summary>
        /// 跟踪情况_listhidden_searchhidden
        /// </summary>
        private string _GenzongInfo = "";

        /// <summary>
        /// 跟踪情况_listhidden_searchhidden
        /// </summary>
        [DisplayName("跟踪情况")]
        [Required]
        public string GenzongInfo
        {
            set { _GenzongInfo = value; }
            get { return _GenzongInfo; }
        }



        /// <summary>
        /// 跟踪时间
        /// </summary>
        private DateTime _GengzongDateTime = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 跟踪时间
        /// </summary>
        [DisplayName("跟踪时间")]
        [Required]
        public DateTime GengzongDateTime
        {
            set { _GengzongDateTime = value; }
            get { return _GengzongDateTime; }
        }

        private DateTime _GengzongDateTimeStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime GengzongDateTimeStart
        {
            set { _GengzongDateTimeStart = value; }
            get { return _GengzongDateTimeStart; }
        }

        private DateTime _GengzongDateTimeEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime GengzongDateTimeEnd
        {
            set { _GengzongDateTimeEnd = value; }
            get { return _GengzongDateTimeEnd; }
        }


        /// <summary>
        /// 跟踪状态
        /// </summary>
        private int _GenzongStateID;

        /// <summary>
        /// 跟踪状态
        /// </summary>
        [DisplayName("跟踪状态")]
        [Required]
        public int GenzongStateID
        {
            set { _GenzongStateID = value; }
            get { return _GenzongStateID; }
        }

        [DisplayName("操作人id")]
        public int? optId { get; set; }
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
        /// 操作时间_listhidden_searchhidden_createdate
        /// </summary>
        private DateTime _optDateTime = SqlDateTime.MinValue.Value;

        /// <summary>
        /// 操作时间_listhidden_searchhidden_createdate
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

        /// <summary>
        /// 数据类型
        /// </summary>
        public string FromType { set; get; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class JMSGengZongReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// seed
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 加盟商ID_listhidden_searchhidden
        /// </summary> 
        public int? JmsID { get; set; }


        /// <summary>
        /// 加盟商名称
        /// </summary> 
        public string JmsName { get; set; }


        /// <summary>
        /// 联系人ID_listhidden_searchhidden
        /// </summary> 
        public int? LxrID { get; set; }


        /// <summary>
        /// 联系人名字
        /// </summary> 
        public string LxrName { get; set; }


        /// <summary>
        /// 跟踪情况_listhidden_searchhidden
        /// </summary> 
        public string GenzongInfo { get; set; }


        /// <summary>
        /// 跟踪时间
        /// </summary> 
        public DateTime GengzongDateTime { get; set; }

        private DateTime _GengzongDateTimeStart = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime GengzongDateTimeStart
        {
            set { _GengzongDateTimeStart = value; }
            get { return _GengzongDateTimeStart; }
        }

        private DateTime _GengzongDateTimeEnd = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime GengzongDateTimeEnd
        {
            set { _GengzongDateTimeEnd = value; }
            get { return _GengzongDateTimeEnd; }
        }

        /// <summary>
        /// 跟踪状态
        /// </summary> 
        public int? GenzongStateID { get; set; }


        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary> 
        public string optName { get; set; }


        /// <summary>
        /// 操作时间_listhidden_searchhidden_createdate
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





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
    /// <para>摘要：JMSJieDianClassModelModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：JMSJieDianClassModel
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JdClassName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>大类模型名称</td></tr>
    /// <tr valign="top"><td>3</td><td>JdClassPaiXu</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类排序_searchhidden</td></tr>
    /// <tr valign="top"><td>4</td><td>JdClassStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类模型状态</td></tr>
    /// <tr valign="top"><td>5</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>6</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JMSJieDianClassModel")]
    [Serializable]
    public partial class JMSJieDianClassModel
    {

        public static string LogClass = "加盟商筹建计划进度大类模型表";
        #region -  公共属性  ------------------------------------------------------------

        [DisplayName("是否为专有状态")]
        public string JdSpecialState { get; set; }
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
        /// 大类模型名称
        /// </summary>
        private string _JdClassName = "";
        /// <summary>
        /// 大类模型名称
        /// </summary>
        [DisplayName("大类名称")]
        [Required]
        public string JdClassName
        {
            set { _JdClassName = value; }
            get { return _JdClassName; }
        }



        /// <summary>
        /// 大类排序_searchhidden
        /// </summary>
        private int _JdClassPaiXu;
        /// <summary>
        /// 大类排序_searchhidden
        /// </summary>
        [DisplayName("大类排序")]
        [Required]
        public int JdClassPaiXu
        {
            set { _JdClassPaiXu = value; }
            get { return _JdClassPaiXu; }
        }



        /// <summary>
        /// 大类模型状态
        /// </summary>
        private int _JdClassStateID;
        /// <summary>
        /// 大类模型状态
        /// </summary>
        [DisplayName("大类状态")]
        [Required]
        public int JdClassStateID
        {
            set { _JdClassStateID = value; }
            get { return _JdClassStateID; }
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

    public partial class JMSJieDianClassModelReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// seed
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 大类模型名称
        /// </summary> 
        public string JdClassName { get; set; }


        /// <summary>
        /// 大类排序_searchhidden
        /// </summary> 
        public int? JdClassPaiXu { get; set; }


        /// <summary>
        /// 大类模型状态
        /// </summary> 
        public int? JdClassStateID { get; set; }


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

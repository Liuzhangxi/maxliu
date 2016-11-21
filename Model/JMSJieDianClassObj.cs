



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
    /// <para>摘要：JMSJieDianClassObjModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：JMSJieDianClassObj
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JmsID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>加盟商ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟商名称</td></tr>
    /// <tr valign="top"><td>4</td><td>JdClassModelID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类模型ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>5</td><td>JdClassModelName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>大类模型名称</td></tr>
    /// <tr valign="top"><td>6</td><td>JdClassPaiXu</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>排序</td></tr>
    /// <tr valign="top"><td>7</td><td>JdClassStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>是否有效</td></tr>
    /// <tr valign="top"><td>8</td><td>JdClassConfirmID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>是否确认</td></tr>
    /// <tr valign="top"><td>9</td><td>ProjectID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>项目公司ID</td></tr>
    /// <tr valign="top"><td>10</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>11</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JMSJieDianClassObj")]
    [Serializable]
    public partial class JMSJieDianClassObj
    {

        public static string LogClass = "加盟商筹建计划进度大类实体表";

        #region -  公共属性  ------------------------------------------------------------
        

        [DisplayName("特殊化操作人")]
        public string JdSpecialOptName { get; set; }
        [DisplayName("特殊化状态")]
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
        /// 大类模型ID_listhidden_searchhidden
        /// </summary>
        private int _JdClassModelID;

        /// <summary>
        /// 大类模型ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("大类模型ID")]
        [Required]
        public int JdClassModelID
        {
            set { _JdClassModelID = value; }
            get { return _JdClassModelID; }
        }



        /// <summary>
        /// 大类模型名称
        /// </summary>
        private string _JdClassModelName = "";

        /// <summary>
        /// 大类模型名称
        /// </summary>
        [DisplayName("大类模型名称")]
        [Required]
        public string JdClassModelName
        {
            set { _JdClassModelName = value; }
            get { return _JdClassModelName; }
        }



        /// <summary>
        /// 排序
        /// </summary>
        private int _JdClassPaiXu;

        /// <summary>
        /// 排序
        /// </summary>
        [DisplayName("排序")]
        [Required]
        public int JdClassPaiXu
        {
            set { _JdClassPaiXu = value; }
            get { return _JdClassPaiXu; }
        }



        /// <summary>
        /// 是否有效
        /// </summary>
        private int _JdClassStateID;

        /// <summary>
        /// 是否有效
        /// </summary>
        [DisplayName("是否有效")]
        [Required]
        public int JdClassStateID
        {
            set { _JdClassStateID = value; }
            get { return _JdClassStateID; }
        }



        /// <summary>
        /// 是否确认
        /// </summary>
        private int _JdClassConfirmID;

        /// <summary>
        /// 是否确认
        /// </summary>
        [DisplayName("是否确认")]
        [Required]
        public int JdClassConfirmID
        {
            set { _JdClassConfirmID = value; }
            get { return _JdClassConfirmID; }
        }



        /// <summary>
        /// 项目公司ID
        /// </summary>
        private int _ProjectID;

        /// <summary>
        /// 项目公司ID
        /// </summary>
        [DisplayName("项目公司ID")]
        [Required]
        public int ProjectID
        {
            set { _ProjectID = value; }
            get { return _ProjectID; }
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

    public partial class JMSJieDianClassObjReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("特殊化操作人")]
        public string JdSpecialOptName { get; set; }
        [DisplayName("特殊化状态")]
        public string JdSpecialState { get; set; }
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
        /// 大类模型ID_listhidden_searchhidden
        /// </summary> 
        public int? JdClassModelID { get; set; }


        /// <summary>
        /// 大类模型名称
        /// </summary> 
        public string JdClassModelName { get; set; }


        /// <summary>
        /// 排序
        /// </summary> 
        public int? JdClassPaiXu { get; set; }


        /// <summary>
        /// 是否有效
        /// </summary> 
        public int? JdClassStateID { get; set; }


        /// <summary>
        /// 是否确认
        /// </summary> 
        public int? JdClassConfirmID { get; set; }


        /// <summary>
        /// 项目公司ID
        /// </summary> 
        //public int? ProjectID { get; set; }


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

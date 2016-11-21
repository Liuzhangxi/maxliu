



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
    /// <para>摘要：JMSJieDianMXModelModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：JMSJieDianMXModel
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JdClassID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类模型ID</td></tr>
    /// <tr valign="top"><td>3</td><td>JdID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>节点ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>4</td><td>JdMXName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>节点明细名称</td></tr>
    /// <tr valign="top"><td>5</td><td>JdMXFuJianUrl</td><td>nvarchar</td><td>500</td><td></td><td></td><td></td><td></td><td></td><td>节点明细附件地址_listhidden_searchhidden_saveattach_</td></tr>
    /// <tr valign="top"><td>6</td><td>JdMXFuJianFileClass</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>节点明细文件类型</td></tr>
    /// <tr valign="top"><td>7</td><td>JdMXFuJianJiaMengClass</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>文件对应的加盟类型</td></tr>
    /// <tr valign="top"><td>8</td><td>JdMXStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>节点明细状态</td></tr>
    /// <tr valign="top"><td>9</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>10</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JMSJieDianMXModel")]
    [Serializable]
    public partial class JMSJieDianMXModel
    {

        public static string LogClass = "加盟商筹建计划节点明细模型表";
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
        /// 大类模型ID
        /// </summary>
        private int _JdClassID;
        /// <summary>
        /// 大类模型ID
        /// </summary>
        [DisplayName("大类模型ID")]
        [Required]
        public int JdClassID
        {
            set { _JdClassID = value; }
            get { return _JdClassID; }
        }



        /// <summary>
        /// 节点ID_listhidden_searchhidden
        /// </summary>
        private int _JdID;
        /// <summary>
        /// 节点ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("节点ID")]
        [Required]
        public int JdID
        {
            set { _JdID = value; }
            get { return _JdID; }
        }



        /// <summary>
        /// 节点明细名称
        /// </summary>
        private string _JdMXName = "";
        /// <summary>
        /// 节点明细名称
        /// </summary>
        [DisplayName("节点明细名称")]
        [Required]
        public string JdMXName
        {
            set { _JdMXName = value; }
            get { return _JdMXName; }
        }



        /// <summary>
        /// 节点明细附件地址_listhidden_searchhidden_saveattach_
        /// </summary>
        private string _JdMXFuJianUrl = "";
        /// <summary>
        /// 节点明细附件地址_listhidden_searchhidden_saveattach_
        /// </summary>
        [DisplayName("节点明细附件地址")]
       
        public string JdMXFuJianUrl
        {
            set { _JdMXFuJianUrl = value; }
            get { return _JdMXFuJianUrl; }
        }



        /// <summary>
        /// 节点明细文件类型
        /// </summary>
        private string _JdMXFuJianFileClass = "";
        /// <summary>
        /// 节点明细文件类型
        /// </summary>
        [DisplayName("节点明细文件类型")]
        [Required]
        public string JdMXFuJianFileClass
        {
            set { _JdMXFuJianFileClass = value; }
            get { return _JdMXFuJianFileClass; }
        }



        /// <summary>
        /// 文件对应的加盟类型
        /// </summary>
        private string _JdMXFuJianJiaMengClass = "";
        /// <summary>
        /// 文件对应的加盟类型
        /// </summary>
        [DisplayName("文件对应的加盟类型")]
        [Required]
        public string JdMXFuJianJiaMengClass
        {
            set { _JdMXFuJianJiaMengClass = value; }
            get { return _JdMXFuJianJiaMengClass; }
        }



        /// <summary>
        /// 节点明细状态
        /// </summary>
        private int _JdMXStateID;
        /// <summary>
        /// 节点明细状态
        /// </summary>
        [DisplayName("节点明细状态")]
        [Required]
        public int JdMXStateID
        {
            set { _JdMXStateID = value; }
            get { return _JdMXStateID; }
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

    public partial class JMSJieDianMXModelReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        
        public string JdClassIDStr { get; set; }
        /// <summary>
        /// seed
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 大类模型ID
        /// </summary> 
        public int? JdClassID { get; set; }


        /// <summary>
        /// 节点ID_listhidden_searchhidden
        /// </summary> 
        public int? JdID { get; set; }


        /// <summary>
        /// 节点明细名称
        /// </summary> 
        public string JdMXName { get; set; }


        /// <summary>
        /// 节点明细附件地址_listhidden_searchhidden_saveattach_
        /// </summary> 
        public string JdMXFuJianUrl { get; set; }


        /// <summary>
        /// 节点明细文件类型
        /// </summary> 
        public string JdMXFuJianFileClass { get; set; }


        /// <summary>
        /// 文件对应的加盟类型
        /// </summary> 
        public string JdMXFuJianJiaMengClass { get; set; }


        /// <summary>
        /// 节点明细状态
        /// </summary> 
        public int? JdMXStateID { get; set; }


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





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
    /// <para>摘要：JMSJieDianMXObjModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：JMSJieDianMXObj
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JmsID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>加盟商ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>3</td><td>JdClassModelID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>大类模型ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>4</td><td>JdClassModelName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>大类模型名称</td></tr>
    /// <tr valign="top"><td>5</td><td>JdModelID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>节点模型ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>6</td><td>JdModelName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>节点模型名称</td></tr>
    /// <tr valign="top"><td>7</td><td>JdMXModelID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>节点明细ID_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>8</td><td>JdMXModelName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>节点明细名称</td></tr>
    /// <tr valign="top"><td>9</td><td>JdMXFuJianFileClass</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>节点文件类型</td></tr>
    /// <tr valign="top"><td>10</td><td>JdMXFuJianJiaMengClass</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>文件对应的加盟类型</td></tr>
    /// <tr valign="top"><td>11</td><td>xxJdMXFuJianUrl</td><td>nvarchar</td><td>500</td><td></td><td></td><td></td><td></td><td></td><td>节点明细附件地址_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>12</td><td>JmsUpFileUrl</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td></td><td></td><td>加盟上传文件_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>13</td><td>JdMXStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>是否有效</td></tr>
    /// <tr valign="top"><td>14</td><td>JmsJdMXConfirmID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>加盟商是否确认</td></tr>
    /// <tr valign="top"><td>15</td><td>xxJdMXConfirmID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>喜喜是否确认</td></tr>
    /// <tr valign="top"><td>16</td><td>ProjectID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>项目公司ID</td></tr>
    /// <tr valign="top"><td>17</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>18</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_createdate_listhidden_searchhidden</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JMSJieDianMXObj")]
    [Serializable]
    public partial class JMSJieDianMXObj
    {

        public static string LogClass = "加盟商节点加盟进度明细列表";

        #region -  公共属性  ------------------------------------------------------------
       //public string xxUpFileUrl { get; set; }
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
        /// 节点模型ID_listhidden_searchhidden
        /// </summary>
        private int _JdModelID;

        /// <summary>
        /// 节点模型ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("节点模型ID")]
        [Required]
        public int JdModelID
        {
            set { _JdModelID = value; }
            get { return _JdModelID; }
        }



        /// <summary>
        /// 节点模型名称
        /// </summary>
        private string _JdModelName = "";

        /// <summary>
        /// 节点模型名称
        /// </summary>
        [DisplayName("节点模型名称")]
        [Required]
        public string JdModelName
        {
            set { _JdModelName = value; }
            get { return _JdModelName; }
        }



        /// <summary>
        /// 节点明细ID_listhidden_searchhidden
        /// </summary>
        private int _JdMXModelID;

        /// <summary>
        /// 节点明细ID_listhidden_searchhidden
        /// </summary>
        [DisplayName("节点明细ID")]
        [Required]
        public int JdMXModelID
        {
            set { _JdMXModelID = value; }
            get { return _JdMXModelID; }
        }



        /// <summary>
        /// 节点明细名称
        /// </summary>
        private string _JdMXModelName = "";

        /// <summary>
        /// 节点明细名称
        /// </summary>
        [DisplayName("节点明细名称")]
        [Required]
        public string JdMXModelName
        {
            set { _JdMXModelName = value; }
            get { return _JdMXModelName; }
        }



        /// <summary>
        /// 节点文件类型
        /// </summary>
        private string _JdMXFuJianFileClass = "";

        /// <summary>
        /// 节点文件类型
        /// </summary>
        [DisplayName("节点文件类型")]
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
        /// 节点明细附件地址_listhidden_searchhidden
        /// </summary>
        private string _xxJdMXFuJianUrl = "";

        /// <summary>
        /// 节点明细附件地址_listhidden_searchhidden
        /// </summary>
        [DisplayName("节点明细附件地址")] 
        public string xxJdMXFuJianUrl
        {
            set { _xxJdMXFuJianUrl = value; }
            get { return _xxJdMXFuJianUrl; }
        }



        /// <summary>
        /// 加盟上传文件_listhidden_searchhidden
        /// </summary>
        private string _JmsUpFileUrl = "";

        /// <summary>
        /// 加盟上传文件_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟上传文件")]
        public string JmsUpFileUrl
        {
            set { _JmsUpFileUrl = value; }
            get { return _JmsUpFileUrl; }
        }



        /// <summary>
        /// 是否有效
        /// </summary>
        private int _JdMXStateID;

        /// <summary>
        /// 是否有效
        /// </summary>
        [DisplayName("是否有效")]
        [Required]
        public int JdMXStateID
        {
            set { _JdMXStateID = value; }
            get { return _JdMXStateID; }
        }



        /// <summary>
        /// 加盟商是否确认
        /// </summary>
        private int _JmsJdMXConfirmID;

        /// <summary>
        /// 加盟商是否确认
        /// </summary>
        [DisplayName("加盟商是否确认")]
        [Required]
        public int JmsJdMXConfirmID
        {
            set { _JmsJdMXConfirmID = value; }
            get { return _JmsJdMXConfirmID; }
        }



        /// <summary>
        /// 喜喜是否确认
        /// </summary>
        private int _xxJdMXConfirmID;

        /// <summary>
        /// 喜喜是否确认
        /// </summary>
        [DisplayName("喜喜是否确认")]
        [Required]
        public int xxJdMXConfirmID
        {
            set { _xxJdMXConfirmID = value; }
            get { return _xxJdMXConfirmID; }
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

    public partial class JMSJieDianMXObjReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        
        /// <summary>
        /// seed
        /// </summary> 
        public int? id { get; set; }

        //public string xxUpFileUrl { get; set; }

        /// <summary>
        /// 加盟商ID_listhidden_searchhidden
        /// </summary> 
        public int? JmsID { get; set; }


        /// <summary>
        /// 大类模型ID_listhidden_searchhidden
        /// </summary> 
        public int? JdClassModelID { get; set; }


        /// <summary>
        /// 大类模型名称
        /// </summary> 
        public string JdClassModelName { get; set; }


        /// <summary>
        /// 节点模型ID_listhidden_searchhidden
        /// </summary> 
        public int? JdModelID { get; set; }


        /// <summary>
        /// 节点模型名称
        /// </summary> 
        public string JdModelName { get; set; }


        /// <summary>
        /// 节点明细ID_listhidden_searchhidden
        /// </summary> 
        public int? JdMXModelID { get; set; }


        /// <summary>
        /// 节点明细名称
        /// </summary> 
        public string JdMXModelName { get; set; }


        /// <summary>
        /// 节点文件类型
        /// </summary> 
        public string JdMXFuJianFileClass { get; set; }


        /// <summary>
        /// 文件对应的加盟类型
        /// </summary> 
        public string JdMXFuJianJiaMengClass { get; set; }


        /// <summary>
        /// 节点明细附件地址_listhidden_searchhidden
        /// </summary> 
        public string xxJdMXFuJianUrl { get; set; }


        /// <summary>
        /// 加盟上传文件_listhidden_searchhidden
        /// </summary> 
        public string JmsUpFileUrl { get; set; }


        /// <summary>
        /// 是否有效
        /// </summary> 
        public int? JdMXStateID { get; set; }


        /// <summary>
        /// 加盟商是否确认
        /// </summary> 
        public int? JmsJdMXConfirmID { get; set; }


        /// <summary>
        /// 喜喜是否确认
        /// </summary> 
        public int? xxJdMXConfirmID { get; set; }


        ///// <summary>
        ///// 项目公司ID
        ///// </summary> 
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

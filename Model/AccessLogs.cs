



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
    /// <para>摘要：AccessLogsModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：AccessLogs
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>Id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>KeyId</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>主键ID</td></tr>
    /// <tr valign="top"><td>3</td><td>Code</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>4</td><td>AccessClass</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>相关表单</td></tr>
    /// <tr valign="top"><td>5</td><td>AccessAction</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作行为</td></tr>
    /// <tr valign="top"><td>6</td><td>AccessInfo</td><td>nvarchar</td><td>500</td><td></td><td></td><td></td><td>√</td><td></td><td></td></tr>
    /// <tr valign="top"><td>7</td><td>AccessTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间</td></tr>
    /// <tr valign="top"><td>8</td><td>AccessPerson</td><td>nvarchar</td><td>-1</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("AccessLogs")]
    [Serializable]
    public partial class AccessLogs
    {

        public static string LogClass = "操作日志";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        private int _Id;
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }





        /// <summary>
        /// 主键ID
        /// </summary>
        private int _KeyId;
        /// <summary>
        /// 主键ID
        /// </summary>
        [DisplayName("主键ID")]
        public int KeyId
        {
            set { _KeyId = value; }
            get { return _KeyId; }
        }





        /// <summary>
        /// 
        /// </summary>
        private string _Code = "";
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Code")]
        public string Code
        {
            set { _Code = value; }
            get { return _Code; }
        }





        /// <summary>
        /// 相关表单
        /// </summary>
        private string _AccessClass = "";
        /// <summary>
        /// 相关表单
        /// </summary>
        [DisplayName("相关表单")]
        public string AccessClass
        {
            set { _AccessClass = value; }
            get { return _AccessClass; }
        }





        /// <summary>
        /// 操作行为
        /// </summary>
        private string _AccessAction = "";
        /// <summary>
        /// 操作行为
        /// </summary>
        [DisplayName("操作行为")]
        public string AccessAction
        {
            set { _AccessAction = value; }
            get { return _AccessAction; }
        }





        /// <summary>
        /// 
        /// </summary>
        private string _AccessInfo = "";
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AccessInfo")]
        public string AccessInfo
        {
            set { _AccessInfo = value; }
            get { return _AccessInfo; }
        }





        /// <summary>
        /// 操作时间
        /// </summary>
        private DateTime _AccessTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]
        public DateTime AccessTime
        {
            set { _AccessTime = value; }
            get { return _AccessTime; }
        }

        private DateTime _AccessTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime AccessTimeStart
        {
            set { _AccessTimeStart = value; }
            get { return _AccessTimeStart; }
        }
        private DateTime _AccessTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime AccessTimeEnd
        {
            set { _AccessTimeEnd = value; }
            get { return _AccessTimeEnd; }
        }




        /// <summary>
        /// 操作人
        /// </summary>
        private string _AccessPerson = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string AccessPerson
        {
            set { _AccessPerson = value; }
            get { return _AccessPerson; }
        }








        #endregion ----------------------------------------------------------------------
    }

    public partial class AccessLogsReq : BaseSearchReq
    {

         
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        private int _Id;
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id
        {
            set { _Id = value;}
            get { return _Id; }
        }





      
        /// <summary>
        /// 主键ID
        /// </summary>
        [DisplayName("主键ID")]
        public int? KeyId { get; set; }





        /// <summary>
        /// 
        /// </summary>
        private string _Code = "";
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Code")]
        public string Code
        {
            set { _Code = value; }
            get { return _Code; }
        }





        /// <summary>
        /// 相关表单
        /// </summary>
        private string _AccessClass = "";
        /// <summary>
        /// 相关表单
        /// </summary>
        [DisplayName("相关表单")]
        public string AccessClass
        {
            set { _AccessClass = value; }
            get { return _AccessClass; }
        }





        /// <summary>
        /// 操作行为
        /// </summary>
        private string _AccessAction = "";
        /// <summary>
        /// 操作行为
        /// </summary>
        [DisplayName("操作行为")]
        public string AccessAction
        {
            set { _AccessAction = value; }
            get { return _AccessAction; }
        }





        /// <summary>
        /// 
        /// </summary>
        private string _AccessInfo = "";
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AccessInfo")]
        public string AccessInfo
        {
            set { _AccessInfo = value; }
            get { return _AccessInfo; }
        }





        /// <summary>
        /// 操作时间
        /// </summary>
        private DateTime _AccessTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]
        public DateTime AccessTime
        {
            set { _AccessTime = value; }
            get { return _AccessTime; }
        }

        private DateTime _AccessTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime AccessTimeStart
        {
            set { _AccessTimeStart = value; }
            get { return _AccessTimeStart; }
        }
        private DateTime _AccessTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime AccessTimeEnd
        {
            set { _AccessTimeEnd = value; }
            get { return _AccessTimeEnd; }
        }




        /// <summary>
        /// 操作人
        /// </summary>
        private string _AccessPerson = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string AccessPerson
        {
            set { _AccessPerson = value; }
            get { return _AccessPerson; }
        }








        #endregion ----------------------------------------------------------------------
    }
}

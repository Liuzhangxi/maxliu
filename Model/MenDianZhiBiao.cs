



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
    /// <para>摘要：MenDianZhiBiaoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：MenDianZhiBiao
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>id</td></tr>
    /// <tr valign="top"><td>2</td><td>yueXiaoShou</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>月总金额目标</td></tr>
    /// <tr valign="top"><td>3</td><td>jianyeMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>间夜单价</td></tr>
    /// <tr valign="top"><td>4</td><td>DingdanCount</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>签单量</td></tr>
    /// <tr valign="top"><td>5</td><td>canguanCount</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>参观量</td></tr>
    /// <tr valign="top"><td>6</td><td>zhibiaoYear</td><td>varchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>指标年份</td></tr>
    /// <tr valign="top"><td>7</td><td>zhibiaoStateID</td><td>varchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>指标状态</td></tr>
    /// <tr valign="top"><td>8</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店</td></tr>
    /// <tr valign="top"><td>9</td><td>optName</td><td>varchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>10</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>操作时间</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("MenDianZhiBiao")]
    [Serializable]
    public partial class MenDianZhiBiao
    {

        public static string LogClass = "门店指标";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// id
        /// </summary>
        private int _id;
        /// <summary>
        /// id
        /// </summary>
        [Key]

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }



        /// <summary>
        /// 月总金额目标
        /// </summary>
        private decimal? _yueXiaoShou;
        /// <summary>
        /// 月总金额目标
        /// </summary>
        [DisplayName("月总金额目标")]

        public decimal? yueXiaoShou
        {
            set { _yueXiaoShou = value; }
            get { return _yueXiaoShou; }
        }



        /// <summary>
        /// 间夜单价
        /// </summary>
        private decimal? _jianyeMoney;
        /// <summary>
        /// 间夜单价
        /// </summary>
        [DisplayName("间夜单价")]

        public decimal? jianyeMoney
        {
            set { _jianyeMoney = value; }
            get { return _jianyeMoney; }
        }



        /// <summary>
        /// 签单量
        /// </summary>
        private decimal? _DingdanCount;
        /// <summary>
        /// 签单量
        /// </summary>
        [DisplayName("签单量")]

        public decimal? DingdanCount
        {
            set { _DingdanCount = value; }
            get { return _DingdanCount; }
        }



        /// <summary>
        /// 参观量
        /// </summary>
        private decimal? _canguanCount;
        /// <summary>
        /// 参观量
        /// </summary>
        [DisplayName("参观量")]

        public decimal? canguanCount
        {
            set { _canguanCount = value; }
            get { return _canguanCount; }
        }



        /// <summary>
        /// 指标年份
        /// </summary>
        private string _zhibiaoYear = "";
        /// <summary>
        /// 指标年份
        /// </summary>
        [DisplayName("指标年份")]

        public string zhibiaoYear
        {
            set { _zhibiaoYear = value; }
            get { return _zhibiaoYear; }
        }



        /// <summary>
        /// 指标状态
        /// </summary>
        private string _zhibiaoStateID = "";
        /// <summary>
        /// 指标状态
        /// </summary>
        [DisplayName("指标状态")]

        public string zhibiaoStateID
        {
            set { _zhibiaoStateID = value; }
            get { return _zhibiaoStateID; }
        }



        /// <summary>
        /// 门店
        /// </summary>
        private int? _projectid;
        /// <summary>
        /// 门店
        /// </summary>
        [DisplayName("门店")]

        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }



        /// <summary>
        /// 操作人
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]

        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }



        /// <summary>
        /// 操作时间
        /// </summary>
        private DateTime? _optDateTime;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]

        public DateTime? optDateTime
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
        public string projectName { get; set; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class MenDianZhiBiaoReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// id
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 月总金额目标
        /// </summary> 
        public decimal? yueXiaoShou { get; set; }


        /// <summary>
        /// 间夜单价
        /// </summary> 
        public decimal? jianyeMoney { get; set; }


        /// <summary>
        /// 签单量
        /// </summary> 
        public decimal? DingdanCount { get; set; }


        /// <summary>
        /// 参观量
        /// </summary> 
        public decimal? canguanCount { get; set; }


        /// <summary>
        /// 指标年份
        /// </summary> 
        public string zhibiaoYear { get; set; }


        /// <summary>
        /// 指标状态
        /// </summary> 
        public string zhibiaoStateID { get; set; }


        /// <summary>
        /// 操作人
        /// </summary> 
        public string optName { get; set; }


        /// <summary>
        /// 操作时间
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

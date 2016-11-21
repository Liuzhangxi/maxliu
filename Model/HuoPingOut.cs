



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
    /// <para>摘要：HuoPingOutModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：HuoPingOut
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>HuoPingId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品</td></tr>
    /// <tr valign="top"><td>3</td><td>HuoPingName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名</td></tr>
    /// <tr valign="top"><td>4</td><td>Stock</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>当月库存</td></tr>
    /// <tr valign="top"><td>5</td><td>projectid</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>门店_projectid</td></tr>
    /// <tr valign="top"><td>6</td><td>ProjectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>门店名_projectname</td></tr>
    /// <tr valign="top"><td>7</td><td>OptId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>8</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>9</td><td>MonthNeed</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>本月需领用数量</td></tr>
    /// <tr valign="top"><td>10</td><td>WeekOne</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>第一周领用数量</td></tr>
    /// <tr valign="top"><td>11</td><td>WeekTwo</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>第二周领用数量</td></tr>
    /// <tr valign="top"><td>12</td><td>WeekThree</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>第三周领用数量</td></tr>
    /// <tr valign="top"><td>13</td><td>WeekFour</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>第四周领用数量</td></tr>
    /// <tr valign="top"><td>14</td><td>WeekFive</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>第五周领用数量</td></tr>
    /// <tr valign="top"><td>15</td><td>State</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>审核状态</td></tr>
    /// <tr valign="top"><td>16</td><td>Mark</td><td>nvarchar</td><td>950</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// <tr valign="top"><td>17</td><td>ServerMonth</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>月份</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("HuoPingOut")]
    [Serializable]
    public partial class HuoPingOut
    {

        public static string LogClass = "货品出库信息";
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
        /// 申请ID
        /// </summary>
        private int? _HPShenqingId;
        /// <summary>
        /// 货品
        /// </summary>
        [DisplayName("申请ID")]

        public int? HPShenqingId
        {
            set { _HPShenqingId = value; }
            get { return _HPShenqingId; }
        }


        /// <summary>
        /// 货品
        /// </summary>
        private int? _HuoPingId;
        /// <summary>
        /// 货品
        /// </summary>
        [DisplayName("货品")]

        public int? HuoPingId
        {
            set { _HuoPingId = value; }
            get { return _HuoPingId; }
        }



        /// <summary>
        /// 货品名
        /// </summary>
        private string _HuoPingName = "";
        /// <summary>
        /// 货品名
        /// </summary>
        [DisplayName("货品名")]

        public string HuoPingName
        {
            set { _HuoPingName = value; }
            get { return _HuoPingName; }
        }



        /// <summary>
        /// 当月库存
        /// </summary>
        private decimal? _Stock;
        /// <summary>
        /// 当月库存
        /// </summary>
        [DisplayName("当月库存")]

        public decimal? Stock
        {
            set { _Stock = value; }
            get { return _Stock; }
        }

        /// <summary>
        /// 门店_projectid
        /// </summary>
        private int? _projectid;
        /// <summary>
        /// 门店_projectid
        /// </summary>
        [DisplayName("门店")]

        public int? projectid
        {
            set { _projectid = value; }
            get { return _projectid; }
        }



        /// <summary>
        /// 门店名_projectname
        /// </summary>
        private string _ProjectName = "";
        /// <summary>
        /// 门店名_projectname
        /// </summary>
        [DisplayName("门店名")]

        public string ProjectName
        {
            set { _ProjectName = value; }
            get { return _ProjectName; }
        }



        /// <summary>
        /// 操作人_optid
        /// </summary>
        private int? _OptId;
        /// <summary>
        /// 操作人_optid
        /// </summary>
        [DisplayName("操作人")]

        public int? OptId
        {
            set { _OptId = value; }
            get { return _OptId; }
        }



        /// <summary>
        /// 操作人名_optname
        /// </summary>
        private string _OptName = "";
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        [DisplayName("操作人名")]

        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        private DateTime? _OptDateTime = null;
        /// <summary>
        /// 操作时间
        /// </summary>

        public DateTime? OptDateTime
        {
            set { _OptDateTime = value; }
            get { return _OptDateTime; }
        }


        /// <summary>
        /// 本月需领用数量
        /// </summary>
        private decimal? _MonthNeed;
        /// <summary>
        /// 本月需领用数量
        /// </summary>
        [DisplayName("本月需领用数量")]

        public decimal? MonthNeed
        {
            set { _MonthNeed = value; }
            get { return _MonthNeed; }
        }

        /// <summary>
        /// 本月需领用数量（明细）
        /// </summary>
        private decimal? _MonthNeedDetail;
        /// <summary>
        /// 本月需领用数量（明细）
        /// </summary>
        [DisplayName("本月需领用数量（明细）")]

        public decimal? MonthNeedDetail
        {
            set { _MonthNeedDetail = value; }
            get { return _MonthNeedDetail; }
        }

        /// <summary>
        /// 第一周领用数量
        /// </summary>
        private decimal? _WeekOne;
        /// <summary>
        /// 第一周领用数量
        /// </summary>
        [DisplayName("第一周领用数量")]

        public decimal? WeekOne
        {
            set { _WeekOne = value; }
            get { return _WeekOne; }
        }



        /// <summary>
        /// 第二周领用数量
        /// </summary>
        private decimal? _WeekTwo;
        /// <summary>
        /// 第二周领用数量
        /// </summary>
        [DisplayName("第二周领用数量")]

        public decimal? WeekTwo
        {
            set { _WeekTwo = value; }
            get { return _WeekTwo; }
        }



        /// <summary>
        /// 第三周领用数量
        /// </summary>
        private decimal? _WeekThree;
        /// <summary>
        /// 第三周领用数量
        /// </summary>
        [DisplayName("第三周领用数量")]

        public decimal? WeekThree
        {
            set { _WeekThree = value; }
            get { return _WeekThree; }
        }



        /// <summary>
        /// 第四周领用数量
        /// </summary>
        private decimal? _WeekFour;
        /// <summary>
        /// 第四周领用数量
        /// </summary>
        [DisplayName("第四周领用数量")]

        public decimal? WeekFour
        {
            set { _WeekFour = value; }
            get { return _WeekFour; }
        }



        /// <summary>
        /// 第五周领用数量
        /// </summary>
        private decimal? _WeekFive;
        /// <summary>
        /// 第五周领用数量
        /// </summary>
        [DisplayName("第五周领用数量")]

        public decimal? WeekFive
        {
            set { _WeekFive = value; }
            get { return _WeekFive; }
        }



        /// <summary>
        /// 审核状态
        /// </summary>
        private string _State = "";
        /// <summary>
        /// 审核状态
        /// </summary>
        [DisplayName("审核状态")]

        public string State
        {
            set { _State = value; }
            get { return _State; }
        }



        /// <summary>
        /// 备注
        /// </summary>
        private string _Mark = "";
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]

        public string Mark
        {
            set { _Mark = value; }
            get { return _Mark; }
        }



        /// <summary>
        /// 月份
        /// </summary>
        private string _ServerMonth = "";
        /// <summary>
        /// 月份
        /// </summary>
        [DisplayName("月份")]

        public string ServerMonth
        {
            set { _ServerMonth = value; }
            get { return _ServerMonth; }
        }

        [NotMapped]
        public decimal? SingleCount { get; set; }

        #endregion ----------------------------------------------------------------------
    }

    public partial class HuoPingOutReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }

        /// <summary>
        /// 申请ID
        /// </summary>
        public int? HPShenqingId { get; set; }

        /// <summary>
        /// 货品
        /// </summary> 
        public int? HuoPingId { get; set; }


        /// <summary>
        /// 货品名
        /// </summary> 
        public string HuoPingName { get; set; }


        /// <summary>
        /// 当月库存
        /// </summary> 
        public decimal? Stock { get; set; }

        /// <summary>
        /// 门店名_projectname
        /// </summary> 
        public string ProjectName { get; set; }


        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? OptId { get; set; }


        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string OptName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? OptDateTime { get; set; }

        /// <summary>
        /// 本月需领用数量
        /// </summary> 
        public decimal? MonthNeed { get; set; }

        /// <summary>
        /// 本月需领用数量（明细）
        /// </summary> 
        public decimal? MonthNeedDetail { get; set; }

        /// <summary>
        /// 第一周领用数量
        /// </summary> 
        public decimal? WeekOne { get; set; }


        /// <summary>
        /// 第二周领用数量
        /// </summary> 
        public decimal? WeekTwo { get; set; }


        /// <summary>
        /// 第三周领用数量
        /// </summary> 
        public decimal? WeekThree { get; set; }


        /// <summary>
        /// 第四周领用数量
        /// </summary> 
        public decimal? WeekFour { get; set; }


        /// <summary>
        /// 第五周领用数量
        /// </summary> 
        public decimal? WeekFive { get; set; }


        /// <summary>
        /// 审核状态
        /// </summary> 
        public string State { get; set; }


        /// <summary>
        /// 备注
        /// </summary> 
        public string Mark { get; set; }


        /// <summary>
        /// 月份
        /// </summary> 
        public string ServerMonth { get; set; }




        #endregion ----------------------------------------------------------------------
    }

}

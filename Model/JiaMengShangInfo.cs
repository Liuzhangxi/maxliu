



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
    /// <para>摘要：JiaMengShangInfoModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：JiaMengShangInfo
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>seed</td></tr>
    /// <tr valign="top"><td>2</td><td>JmsName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟商名称</td></tr>
    /// <tr valign="top"><td>3</td><td>JmsPhone</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟商联系电话</td></tr>
    /// <tr valign="top"><td>4</td><td>JmsStateID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>加盟商状态</td></tr>
    /// <tr valign="top"><td>5</td><td>JmsQuDaoLaiYuan</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>渠道来源</td></tr>
    /// <tr valign="top"><td>6</td><td>JmsWeiXinHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>微信号_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>7</td><td>JmsMail</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>邮箱_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>8</td><td>JmsArea</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟所在地(城市)_address</td></tr>
    /// <tr valign="top"><td>9</td><td>JmsAddress</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>加盟商地址_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>10</td><td>JmsConShiHangYe</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>从事行业_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>11</td><td>JmsGuDongGouCheng</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>股东构成</td></tr>
    /// <tr valign="top"><td>12</td><td>JmsYiXiang</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟状态</td></tr>
    /// <tr valign="top"><td>13</td><td>JmsHasWuYe</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>是否有合适的物业</td></tr>
    /// <tr valign="top"><td>14</td><td>JmsWuYeClass</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>物业类型_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>15</td><td>JmsWuYeQuYu</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>物业位于城市的哪个区域_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>16</td><td>JmsZiJinYuSuan</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>资金预算_searchhidden</td></tr>
    /// <tr valign="top"><td>17</td><td>JmsHeZuoModel</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟合作模式_searchhidden</td></tr>
    /// <tr valign="top"><td>18</td><td>JmsXiaoFeiLi</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>加盟地消费力_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>19</td><td>JmsYZHSShuLiang</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>加盟地先有月子会所数量_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>20</td><td>JmsYZHSJunJia</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟地月子会所均价_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>21</td><td>JmsYongYouZiYuan</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td></td><td></td><td>加盟商拥有的资源_searchhidden</td></tr>
    /// <tr valign="top"><td>22</td><td>JmsVisitedXiXi</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>是否参观过喜喜_searchhidden</td></tr>
    /// <tr valign="top"><td>23</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td></td><td></td><td>操作人_listhidden_searchhidden</td></tr>
    /// <tr valign="top"><td>24</td><td>optDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td></td><td>操作时间_listhidden_searchhidden_createdate</td></tr>
    /// <tr valign="top"><td>25</td><td>ProjectID</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>所属项目公司Id</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
    [Table("JiaMengShangInfo")]
    [Serializable]
    public partial class JiaMengShangInfo 
    {
    
        public static string LogClass = "加盟商信息表";
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("固话")]
        public string JmsTelPhone { get; set; }

        [DisplayName("第一次跟踪情况")]
        [NotMapped]
        public string GenZongQingKuang { get; set; }
        [DisplayName("第一次跟踪时间")]
        [NotMapped]
        public DateTime GenZongShiJian { get; set; }

        [DisplayName("来源")]
        public string FromType { get; set; }

        [DisplayName("是否参观过其他品牌月子会所")]
        public string JmsHasVisitOther { get; set; }

        [DisplayName("加盟商是否上传新文件")]
        public string JmsHasNewState { get; set; }
        

        [DisplayName("加盟商所在省/直辖市")]
        public string JmsProvince { get; set; }
        [DisplayName("加盟商所在市/市级区")]
        public string JmsCity { get; set; }
        [DisplayName("加盟类型")]
        public string JmsClassName { get; set; }

        /// <summary>
        /// 标记加盟进度表  0没有 1以建 2已完成,3作废
        /// </summary>
        [DisplayName("加盟进度表标记")]
        public int JieDianTbStateID { get; set; }
        /// <summary>
        /// seed
        /// </summary>
        private int _id ;
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
        /// 加盟商名称
        /// </summary>
        private string _JmsName  = "";
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
        /// 加盟商联系电话
        /// </summary>
        private string _JmsPhone  = "";
        /// <summary>
        /// 加盟商联系电话
        /// </summary>
        [DisplayName("加盟商联系电话")]
         [Required]
        public string JmsPhone
        {
            set { _JmsPhone = value; }
            get { return _JmsPhone; }
        }
        
         
        
        /// <summary>
        /// 加盟商状态
        /// </summary>
        private int _JmsStateID ;
        /// <summary>
        /// 加盟商状态
        /// </summary>
        [DisplayName("加盟商意向")]
         [Required]
        public int JmsStateID
        {
            set { _JmsStateID = value; }
            get { return _JmsStateID; }
        }
        
         
        
        /// <summary>
        /// 渠道来源
        /// </summary>
        private string _JmsQuDaoLaiYuan  = "";
        /// <summary>
        /// 渠道来源
        /// </summary>
        [DisplayName("渠道来源")]
         [Required]
        public string JmsQuDaoLaiYuan
        {
            set { _JmsQuDaoLaiYuan = value; }
            get { return _JmsQuDaoLaiYuan; }
        }
        
         
        
        /// <summary>
        /// 微信号_listhidden_searchhidden
        /// </summary>
        private string _JmsWeiXinHao  = "";
        /// <summary>
        /// 微信号_listhidden_searchhidden
        /// </summary>
        [DisplayName("微信号")]
        
        public string JmsWeiXinHao
        {
            set { _JmsWeiXinHao = value; }
            get { return _JmsWeiXinHao; }
        }
        
         
        
        /// <summary>
        /// 邮箱_listhidden_searchhidden
        /// </summary>
        private string _JmsMail  = "";
        /// <summary>
        /// 邮箱_listhidden_searchhidden
        /// </summary>
        [DisplayName("邮箱")]
        
        public string JmsMail
        {
            set { _JmsMail = value; }
            get { return _JmsMail; }
        }
        
         
        
        /// <summary>
        /// 加盟所在地(城市)_address
        /// </summary>
        private string _JmsArea  = "";
        /// <summary>
        /// 加盟所在地(城市)_address
        /// </summary>
        [DisplayName("加盟所在地(区/县)")]
        
        public string JmsArea
        {
            set { _JmsArea = value; }
            get { return _JmsArea; }
        }
        
         
        
        /// <summary>
        /// 加盟商地址_listhidden_searchhidden
        /// </summary>
        private string _JmsAddress  = "";
        /// <summary>
        /// 加盟商地址_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟商地址")]
        
        public string JmsAddress
        {
            set { _JmsAddress = value; }
            get { return _JmsAddress; }
        }
        
         
        
        /// <summary>
        /// 从事行业_listhidden_searchhidden
        /// </summary>
        private string _JmsConShiHangYe  = "";
        /// <summary>
        /// 从事行业_listhidden_searchhidden
        /// </summary>
        [DisplayName("从事行业")]
        
        public string JmsConShiHangYe
        {
            set { _JmsConShiHangYe = value; }
            get { return _JmsConShiHangYe; }
        }
        
         
        
        /// <summary>
        /// 股东构成
        /// </summary>
        private string _JmsGuDongGouCheng  = "";
        /// <summary>
        /// 股东构成
        /// </summary>
        [DisplayName("股东构成")]
         [Required]
        public string JmsGuDongGouCheng
        {
            set { _JmsGuDongGouCheng = value; }
            get { return _JmsGuDongGouCheng; }
        }
        
         
        
        /// <summary>
        /// 加盟意向
        /// </summary>
        private string _JmsYiXiang  = "";
        /// <summary>
        /// 加盟状态
        /// </summary>
        [DisplayName("加盟状态")]
         [Required]
        public string JmsYiXiang
        {
            set { _JmsYiXiang = value; }
            get { return _JmsYiXiang; }
        }
        
         
        
        /// <summary>
        /// 是否有合适的物业
        /// </summary>
        private string _JmsHasWuYe  = "";
        /// <summary>
        /// 是否有合适的物业
        /// </summary>
        [DisplayName("是否有合适的物业")]
         [Required]
        public string JmsHasWuYe
        {
            set { _JmsHasWuYe = value; }
            get { return _JmsHasWuYe; }
        }
        
         
        
        /// <summary>
        /// 物业类型_listhidden_searchhidden
        /// </summary>
        private string _JmsWuYeClass  = "";
        /// <summary>
        /// 物业类型_listhidden_searchhidden
        /// </summary>
        [DisplayName("物业类型")]
        
        public string JmsWuYeClass
        {
            set { _JmsWuYeClass = value; }
            get { return _JmsWuYeClass; }
        }
        
         
        
        /// <summary>
        /// 物业位于城市的哪个区域_listhidden_searchhidden
        /// </summary>
        private string _JmsWuYeQuYu  = "";
        /// <summary>
        /// 物业位于城市的哪个区域_listhidden_searchhidden
        /// </summary>
        [DisplayName("物业位于城市的哪个区域")]
        
        public string JmsWuYeQuYu
        {
            set { _JmsWuYeQuYu = value; }
            get { return _JmsWuYeQuYu; }
        }
        
         
        
        /// <summary>
        /// 资金预算_searchhidden
        /// </summary>
        private string _JmsZiJinYuSuan  = "";
        /// <summary>
        /// 资金预算_searchhidden
        /// </summary>
        [DisplayName("资金预算")]
         [Required]
        public string JmsZiJinYuSuan
        {
            set { _JmsZiJinYuSuan = value; }
            get { return _JmsZiJinYuSuan; }
        }
        
         
        
        /// <summary>
        /// 加盟合作模式_searchhidden
        /// </summary>
        private string _JmsHeZuoModel  = "";
        /// <summary>
        /// 加盟合作模式_searchhidden
        /// </summary>
        [DisplayName("加盟合作模式")]
         [Required]
        public string JmsHeZuoModel
        {
            set { _JmsHeZuoModel = value; }
            get { return _JmsHeZuoModel; }
        }
        
         
        
        /// <summary>
        /// 加盟地消费力_listhidden_searchhidden
        /// </summary>
        private string _JmsXiaoFeiLi  = "";
        /// <summary>
        /// 加盟地消费力_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟地消费力")]
         [Required]
        public string JmsXiaoFeiLi
        {
            set { _JmsXiaoFeiLi = value; }
            get { return _JmsXiaoFeiLi; }
        }
        
         
        
        /// <summary>
        /// 加盟地先有月子会所数量_listhidden_searchhidden
        /// </summary>
        private string _JmsYZHSShuLiang  = "";
        /// <summary>
        /// 加盟地先有月子会所数量_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟地先有月子会所数量")]
         [Required]
        public string JmsYZHSShuLiang
        {
            set { _JmsYZHSShuLiang = value; }
            get { return _JmsYZHSShuLiang; }
        }
        
         
        
        /// <summary>
        /// 加盟地月子会所均价_listhidden_searchhidden
        /// </summary>
        private string _JmsYZHSJunJia  = "";
        /// <summary>
        /// 加盟地月子会所均价_listhidden_searchhidden
        /// </summary>
        [DisplayName("加盟地月子会所均价")]
         [Required]
        public string JmsYZHSJunJia
        {
            set { _JmsYZHSJunJia = value; }
            get { return _JmsYZHSJunJia; }
        }
        
         
        
        /// <summary>
        /// 加盟商拥有的资源_searchhidden
        /// </summary>
        private string _JmsYongYouZiYuan  = "";
        /// <summary>
        /// 加盟商拥有的资源_searchhidden
        /// </summary>
        [DisplayName("加盟商拥有的资源")]
         [Required]
        public string JmsYongYouZiYuan
        {
            set { _JmsYongYouZiYuan = value; }
            get { return _JmsYongYouZiYuan; }
        }
        
         
        
        /// <summary>
        /// 是否参观过喜喜_searchhidden
        /// </summary>
        private string _JmsVisitedXiXi  = "";
        /// <summary>
        /// 是否参观过喜喜_searchhidden
        /// </summary>
        [DisplayName("是否参观过喜喜")]
         [Required]
        public string JmsVisitedXiXi
        {
            set { _JmsVisitedXiXi = value; }
            get { return _JmsVisitedXiXi; }
        }
        
         
        
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary>
        private string _optName  = "";
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
        private DateTime _optDateTime  = SqlDateTime.MinValue.Value;
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
get{ return _optDateTimeStart; }
}
 private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime optDateTimeEnd
{
set { _optDateTimeEnd = value; }
get{ return _optDateTimeEnd; }
}


        /// <summary>
        /// 所属门店Id
        /// </summary>
        private int _ProjectID ;
        /// <summary>
        /// 所属门店
        /// </summary>
        [DisplayName("所属门店")]
         [Required]
        public int ProjectID
        {
            set { _ProjectID = value; }
            get { return _ProjectID; }
        }
        
        [DisplayName("销售")]
         public int? SaleId { get; set; }
        [DisplayName("销售名")]
        public string SaleName { get; set; }

        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class JiaMengShangInfoReq:BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------
        [DisplayName("固话")]
        public string JmsTelPhone { get; set; }

        [DisplayName("来源")]
        public string FromType { get; set; }
        [DisplayName("销售")]
        public int? SaleId { get; set; }
        [DisplayName("销售名")]
        public string SaleName { get; set; }
        public string JmsHasVisitOther { get; set; }
        public string JmsProvince { get; set; }
        public string JmsCity { get; set; }

        public string JmsClassName { get; set; }

        /// <summary>
        /// 标记加盟进度表  0没有 1以建 2完成 3作废
        /// </summary>
        public int? JieDianTbStateID { get; set; }
        /// <summary>
        /// seed
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 加盟商名称
        /// </summary> 
        public string JmsName { get;set; } 
	
          
        /// <summary>
        /// 加盟商联系电话
        /// </summary> 
        public string JmsPhone { get;set; } 
	
          
        /// <summary>
        /// 加盟商状态
        /// </summary> 
        public int? JmsStateID { get;set; } 
	
          
        /// <summary>
        /// 渠道来源
        /// </summary> 
        public string JmsQuDaoLaiYuan { get;set; } 
	
          
        /// <summary>
        /// 微信号_listhidden_searchhidden
        /// </summary> 
        public string JmsWeiXinHao { get;set; } 
	
          
        /// <summary>
        /// 邮箱_listhidden_searchhidden
        /// </summary> 
        public string JmsMail { get;set; } 
	
          
        /// <summary>
        /// 加盟所在地(城市)_address
        /// </summary> 
        public string JmsArea { get;set; } 
	
          
        /// <summary>
        /// 加盟商地址_listhidden_searchhidden
        /// </summary> 
        public string JmsAddress { get;set; } 
	
          
        /// <summary>
        /// 从事行业_listhidden_searchhidden
        /// </summary> 
        public string JmsConShiHangYe { get;set; } 
	
          
        /// <summary>
        /// 股东构成
        /// </summary> 
        public string JmsGuDongGouCheng { get;set; } 
	
          
        /// <summary>
        /// 加盟意向
        /// </summary> 
        public string JmsYiXiang { get;set; } 
	
          
        /// <summary>
        /// 是否有合适的物业
        /// </summary> 
        public string JmsHasWuYe { get;set; } 
	
          
        /// <summary>
        /// 物业类型_listhidden_searchhidden
        /// </summary> 
        public string JmsWuYeClass { get;set; } 
	
          
        /// <summary>
        /// 物业位于城市的哪个区域_listhidden_searchhidden
        /// </summary> 
        public string JmsWuYeQuYu { get;set; } 
	
          
        /// <summary>
        /// 资金预算_searchhidden
        /// </summary> 
        public string JmsZiJinYuSuan { get;set; } 
	
          
        /// <summary>
        /// 加盟合作模式_searchhidden
        /// </summary> 
        public string JmsHeZuoModel { get;set; } 
	
          
        /// <summary>
        /// 加盟地消费力_listhidden_searchhidden
        /// </summary> 
        public string JmsXiaoFeiLi { get;set; } 
	
          
        /// <summary>
        /// 加盟地先有月子会所数量_listhidden_searchhidden
        /// </summary> 
        public string JmsYZHSShuLiang { get;set; } 
	
          
        /// <summary>
        /// 加盟地月子会所均价_listhidden_searchhidden
        /// </summary> 
        public string JmsYZHSJunJia { get;set; } 
	
          
        /// <summary>
        /// 加盟商拥有的资源_searchhidden
        /// </summary> 
        public string JmsYongYouZiYuan { get;set; } 
	
          
        /// <summary>
        /// 是否参观过喜喜_searchhidden
        /// </summary> 
        public string JmsVisitedXiXi { get;set; } 
	
          
        /// <summary>
        /// 操作人_listhidden_searchhidden
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 操作时间_listhidden_searchhidden_createdate
        /// </summary> 
        public DateTime? optDateTime { get;set; } 
	
          private DateTime? _optDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime? optDateTimeStart
{
set { _optDateTimeStart = value; }
get{ return _optDateTimeStart; }
}
 private DateTime? _optDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime? optDateTimeEnd
{
set { _optDateTimeEnd = value; }
get{ return _optDateTimeEnd; }
}
 
        ///// <summary>
        ///// 所属项目公司Id
        ///// </summary> 
        //public int? ProjectID { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

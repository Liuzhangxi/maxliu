



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
    /// <para>摘要：DingDanModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：DingDan
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td>订单ID</td></tr>
    /// <tr valign="top"><td>2</td><td>CustomId</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td></td><td>客户ID</td></tr>
    /// <tr valign="top"><td>3</td><td>DDName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单名称</td></tr>
    /// <tr valign="top"><td>4</td><td>DDNumber</td><td>nvarchar</td><td>50</td><td></td><td>√</td><td></td><td></td><td></td><td>订单编号</td></tr>
    /// <tr valign="top"><td>5</td><td>DDMoeny</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td></td><td>((0))</td><td>订单金额</td></tr>
    /// <tr valign="top"><td>6</td><td>DDRealMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td></td><td>((0))</td><td>订单实际金额</td></tr>
    /// <tr valign="top"><td>7</td><td>DDDingJin</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td></td><td>((0))</td><td>订单定金</td></tr>
    /// <tr valign="top"><td>8</td><td>DDYuFu</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td></td><td>((0))</td><td>订单预付</td></tr>
    /// <tr valign="top"><td>9</td><td>DDYuKuan</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td></td><td>((0))</td><td>订单余款</td></tr>
    /// <tr valign="top"><td>10</td><td>ysID</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>月嫂 Id</td></tr>
    /// <tr valign="top"><td>11</td><td>DDStateID</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单状态id</td></tr>
    /// <tr valign="top"><td>12</td><td>DDInfos</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>订单备注</td></tr>
    /// <tr valign="top"><td>13</td><td>DDCompanyID</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>订单签约公司ID</td></tr>
    /// <tr valign="top"><td>14</td><td>DDLaiYuanID</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单来源ID</td></tr>
    /// <tr valign="top"><td>15</td><td>DDFuWuXiangMuID</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>订单服务项目ID</td></tr>
    /// <tr valign="top"><td>16</td><td>DDFuWuAddress</td><td>nvarchar</td><td>100</td><td></td><td></td><td></td><td>√</td><td></td><td>订单服务地址</td></tr>
    /// <tr valign="top"><td>17</td><td>DDFuWuYuYueBeginTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>订单预约开始日期</td></tr>
    /// <tr valign="top"><td>18</td><td>DDFuWuYuYueEndTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>订单预约结束日期</td></tr>
    /// <tr valign="top"><td>19</td><td>DDFuWuBeginTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>订单服务开始时间</td></tr>
    /// <tr valign="top"><td>20</td><td>DDFuWuEndTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>订单服务结束时间</td></tr>
    /// <tr valign="top"><td>21</td><td>DDKeFuComments</td><td>nvarchar</td><td>300</td><td></td><td></td><td></td><td>√</td><td></td><td>订单客户评价</td></tr>
    /// <tr valign="top"><td>22</td><td>OptName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人</td></tr>
    /// <tr valign="top"><td>23</td><td>DDCreateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td></td><td>(getdate())</td><td>订单日期创建</td></tr>
    /// <tr valign="top"><td>24</td><td>DDYeWuName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单业务人员名称</td></tr>
    /// <tr valign="top"><td>25</td><td>CustomName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>客户名称</td></tr>
    /// <tr valign="top"><td>26</td><td>ysName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>订单的月嫂名称</td></tr>
    /// <tr valign="top"><td>27</td><td>DDFuWuXiangMuName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>订单的服务项目名称</td></tr>
    /// <tr valign="top"><td>28</td><td>PayStatus</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td>((0))</td><td>订单支付状态 0未支付，每支付一笔加1</td></tr>
    /// <tr valign="top"><td>29</td><td>ProjectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>订单所属的分公司</td></tr>
    /// <tr valign="top"><td>30</td><td>DDLianXiRen</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单的联系人</td></tr>
    /// <tr valign="top"><td>31</td><td>DDLianXiRenPhone</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单联系人电话</td></tr>
    /// <tr valign="top"><td>32</td><td>parentDDID</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td>((0))</td><td>父订单ID</td></tr>
    /// <tr valign="top"><td>33</td><td>DDPingJiaState</td><td>int</td><td>4</td><td></td><td></td><td></td><td></td><td>((0))</td><td>订单评价状态 0未评价 1已评价</td></tr>
    /// <tr valign="top"><td>34</td><td>YongjinMoney</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>佣金的金额，默认值为订单金额*0.05</td></tr>
    /// <tr valign="top"><td>35</td><td>YunxingCheckedName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>运营中心审核人名字</td></tr>
    /// <tr valign="top"><td>36</td><td>YunxingCheckedDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>运营中心审核时间</td></tr>
    /// <tr valign="top"><td>37</td><td>ZongCaiCheckedName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>总裁审核人名字</td></tr>
    /// <tr valign="top"><td>38</td><td>ZongCaiCheckedDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>总裁审核时间</td></tr>
    /// <tr valign="top"><td>39</td><td>CaiWuZhiFuName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>财务支付人名字</td></tr>
    /// <tr valign="top"><td>40</td><td>CaiWuZhiFuDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>财务支付日期</td></tr>
    /// <tr valign="top"><td>41</td><td>CaiWuZhifFuPingZhen</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>财务支付凭证号</td></tr>
    /// <tr valign="top"><td>42</td><td>YongjinState</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>佣金支付状态 数据字典</td></tr>
    /// <tr valign="top"><td>43</td><td>DingdanStateDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td>(getdate())</td><td>订单状态日期</td></tr>
    /// <tr valign="top"><td>44</td><td>DDBaoXianHao</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单保险单号</td></tr>
    /// <tr valign="top"><td>45</td><td>DDFuWuDian</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>订单服务点</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("DingDan")]
    [Serializable]
    public partial class DingDan 
    {
    
        public static string LogClass = "订单信息";
        public int? endDaysChange { get; set; }

        [DisplayName("月嫂经纪人")]
        [NotMapped]
        public string ysJJRname { get; set; }

        [DisplayName("客户手机")]
        [NotMapped]
        public string KhPhoneNumber { get; set; }
        #region -  公共属性  ------------------------------------------------------------
        public int? xixiProjectID { get; set; }
        public int? xixiUserSystemID { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        private int _id ;
        /// <summary>
        /// 订单ID
        /// </summary>
        [Key]
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        
         
        
        /// <summary>
        /// 客户ID
        /// </summary>
        private int _CustomId ;
        /// <summary>
        /// 客户ID
        /// </summary>
        [DisplayName("客户ID")]
        public int CustomId
        {
            set { _CustomId = value; }
            get { return _CustomId; }
        }
        
         
        
        /// <summary>
        /// 订单名称
        /// </summary>
        private string _DDName  = "";
        /// <summary>
        /// 订单名称
        /// </summary>
        [DisplayName("订单名称")]
        public string DDName
        {
            set { _DDName = value; }
            get { return _DDName; }
        }
        
         
        
        /// <summary>
        /// 订单编号
        /// </summary>
        private string _DDNumber  = "";
        /// <summary>
        /// 订单编号
        /// </summary>
        [DisplayName("订单编号")]
        public string DDNumber
        {
            set { _DDNumber = value; }
            get { return _DDNumber; }
        }
        
         
        
        /// <summary>
        /// 订单金额
        /// </summary>
        private decimal _DDMoeny ;
        /// <summary>
        /// 订单金额
        /// </summary>
        [DisplayName("订单金额")]
        public decimal DDMoeny
        {
            set { _DDMoeny = value; }
            get { return _DDMoeny; }
        }
        
         
        
        /// <summary>
        /// 订单实际金额
        /// </summary>
        private decimal _DDRealMoney ;
        /// <summary>
        /// 订单实际金额
        /// </summary>
        [DisplayName("订单实际金额")]
        public decimal DDRealMoney
        {
            set { _DDRealMoney = value; }
            get { return _DDRealMoney; }
        }
        
         
        
        /// <summary>
        /// 订单定金
        /// </summary>
        private decimal _DDDingJin ;
        /// <summary>
        /// 订单定金
        /// </summary>
        [DisplayName("订单定金")]
        public decimal DDDingJin
        {
            set { _DDDingJin = value; }
            get { return _DDDingJin; }
        }
        
         
        
        /// <summary>
        /// 订单预付
        /// </summary>
        private decimal _DDYuFu ;
        /// <summary>
        /// 订单预付
        /// </summary>
        [DisplayName("订单预付")]
        public decimal DDYuFu
        {
            set { _DDYuFu = value; }
            get { return _DDYuFu; }
        }
        
         
        
        /// <summary>
        /// 订单余款
        /// </summary>
        private decimal _DDYuKuan ;
        /// <summary>
        /// 订单余款
        /// </summary>
        [DisplayName("订单余款")]
        public decimal DDYuKuan
        {
            set { _DDYuKuan = value; }
            get { return _DDYuKuan; }
        }
        
         
        
        /// <summary>
        /// 月嫂 Id
        /// </summary>
        private int? _ysID ;
        /// <summary>
        /// 月嫂 Id
        /// </summary>
        [DisplayName("月嫂 Id")]
        public int? ysID
        {
            set { _ysID = value; }
            get { return _ysID; }
        }
        
         
        
        /// <summary>
        /// 订单状态id
        /// </summary>
        private string _DDStateID  = "";
        /// <summary>
        /// 订单状态id
        /// </summary>
        [DisplayName("订单状态id")]
        public string DDStateID
        {
            set { _DDStateID = value; }
            get { return _DDStateID; }
        }
        
         
        
        /// <summary>
        /// 订单备注
        /// </summary>
        private string _DDInfos  = "";
        /// <summary>
        /// 订单备注
        /// </summary>
        [DisplayName("订单备注")]
        public string DDInfos
        {
            set { _DDInfos = value; }
            get { return _DDInfos; }
        }
        
         
        
        /// <summary>
        /// 订单签约公司ID
        /// </summary>
        private int? _DDCompanyID ;
        /// <summary>
        /// 订单签约公司ID
        /// </summary>
        [DisplayName("订单签约公司ID")]
        public int? DDCompanyID
        {
            set { _DDCompanyID = value; }
            get { return _DDCompanyID; }
        }
        
         
        
        /// <summary>
        /// 订单来源ID
        /// </summary>
        private string _DDLaiYuanID  = "";
        /// <summary>
        /// 订单来源ID
        /// </summary>
        [DisplayName("订单来源ID")]
        public string DDLaiYuanID
        {
            set { _DDLaiYuanID = value; }
            get { return _DDLaiYuanID; }
        }
        
         
        
        /// <summary>
        /// 订单服务项目ID
        /// </summary>
        private int? _DDFuWuXiangMuID ;
        /// <summary>
        /// 订单服务项目ID
        /// </summary>
        [DisplayName("订单服务项目ID")]
        public int? DDFuWuXiangMuID
        {
            set { _DDFuWuXiangMuID = value; }
            get { return _DDFuWuXiangMuID; }
        }
        
         
        
        /// <summary>
        /// 订单服务地址
        /// </summary>
        private string _DDFuWuAddress  = "";
        /// <summary>
        /// 订单服务地址
        /// </summary>
        [DisplayName("订单服务地址")]
        public string DDFuWuAddress
        {
            set { _DDFuWuAddress = value; }
            get { return _DDFuWuAddress; }
        }
        
         
        
        /// <summary>
        /// 订单预约开始日期
        /// </summary>
        private DateTime? _DDFuWuYuYueBeginTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 订单预约开始日期
        /// </summary>
        [DisplayName("订单预约开始日期")]
        public DateTime? DDFuWuYuYueBeginTime
        {
            set { _DDFuWuYuYueBeginTime = value; }
            get { return _DDFuWuYuYueBeginTime; }
        }
        
        private DateTime _DDFuWuYuYueBeginTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueBeginTimeStart
{
set { _DDFuWuYuYueBeginTimeStart = value; }
get{ return _DDFuWuYuYueBeginTimeStart; }
}
 private DateTime _DDFuWuYuYueBeginTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueBeginTimeEnd
{
set { _DDFuWuYuYueBeginTimeEnd = value; }
get{ return _DDFuWuYuYueBeginTimeEnd; }
}
  
        
        /// <summary>
        /// 订单预约结束日期
        /// </summary>
        private DateTime? _DDFuWuYuYueEndTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 订单预约结束日期
        /// </summary>
        [DisplayName("订单预约结束日期")]
        public DateTime? DDFuWuYuYueEndTime
        {
            set { _DDFuWuYuYueEndTime = value; }
            get { return _DDFuWuYuYueEndTime; }
        }
        
        private DateTime _DDFuWuYuYueEndTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueEndTimeStart
{
set { _DDFuWuYuYueEndTimeStart = value; }
get{ return _DDFuWuYuYueEndTimeStart; }
}
 private DateTime _DDFuWuYuYueEndTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueEndTimeEnd
{
set { _DDFuWuYuYueEndTimeEnd = value; }
get{ return _DDFuWuYuYueEndTimeEnd; }
}
  
        
        /// <summary>
        /// 订单服务开始时间
        /// </summary>
        private DateTime? _DDFuWuBeginTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 订单服务开始时间
        /// </summary>
        [DisplayName("订单服务开始时间")]
        public DateTime? DDFuWuBeginTime
        {
            set { _DDFuWuBeginTime = value; }
            get { return _DDFuWuBeginTime; }
        }
        
        private DateTime _DDFuWuBeginTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuBeginTimeStart
{
set { _DDFuWuBeginTimeStart = value; }
get{ return _DDFuWuBeginTimeStart; }
}
 private DateTime _DDFuWuBeginTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuBeginTimeEnd
{
set { _DDFuWuBeginTimeEnd = value; }
get{ return _DDFuWuBeginTimeEnd; }
}
  
        
        /// <summary>
        /// 订单服务结束时间
        /// </summary>
        private DateTime? _DDFuWuEndTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 订单服务结束时间
        /// </summary>
        [DisplayName("订单服务结束时间")]
        public DateTime? DDFuWuEndTime
        {
            set { _DDFuWuEndTime = value; }
            get { return _DDFuWuEndTime; }
        }
        
        private DateTime _DDFuWuEndTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuEndTimeStart
{
set { _DDFuWuEndTimeStart = value; }
get{ return _DDFuWuEndTimeStart; }
}
 private DateTime _DDFuWuEndTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuEndTimeEnd
{
set { _DDFuWuEndTimeEnd = value; }
get{ return _DDFuWuEndTimeEnd; }
}
  
        
        /// <summary>
        /// 订单客户评价
        /// </summary>
        private string _DDKeFuComments  = "";
        /// <summary>
        /// 订单客户评价
        /// </summary>
        [DisplayName("订单客户评价")]
        public string DDKeFuComments
        {
            set { _DDKeFuComments = value; }
            get { return _DDKeFuComments; }
        }
        
         
        
        /// <summary>
        /// 操作人
        /// </summary>
        private string _OptName  = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string OptName
        {
            set { _OptName = value; }
            get { return _OptName; }
        }
        
         
        
        /// <summary>
        /// 订单日期创建
        /// </summary>
        private DateTime _DDCreateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 订单日期创建
        /// </summary>
        [DisplayName("订单日期创建")]
        public DateTime DDCreateTime
        {
            set { _DDCreateTime = value; }
            get { return _DDCreateTime; }
        }
        
        private DateTime _DDCreateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDCreateTimeStart
{
set { _DDCreateTimeStart = value; }
get{ return _DDCreateTimeStart; }
}
 private DateTime _DDCreateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDCreateTimeEnd
{
set { _DDCreateTimeEnd = value; }
get{ return _DDCreateTimeEnd; }
}
  
        
        /// <summary>
        /// 订单业务人员名称
        /// </summary>
        private string _DDYeWuName  = "";
        /// <summary>
        /// 订单业务人员名称
        /// </summary>
        [DisplayName("订单业务人员名称")]
        public string DDYeWuName
        {
            set { _DDYeWuName = value; }
            get { return _DDYeWuName; }
        }
        
         
        
        /// <summary>
        /// 客户名称
        /// </summary>
        private string _CustomName  = "";
        /// <summary>
        /// 客户名称
        /// </summary>
        [DisplayName("客户名称")]
        public string CustomName
        {
            set { _CustomName = value; }
            get { return _CustomName; }
        }
        
         
        
        /// <summary>
        /// 订单的月嫂名称
        /// </summary>
        private string _ysName  = "";
        /// <summary>
        /// 订单的月嫂名称
        /// </summary>
        [DisplayName("订单的月嫂名称")]
        public string ysName
        {
            set { _ysName = value; }
            get { return _ysName; }
        }
        
         
        
        /// <summary>
        /// 订单的服务项目名称
        /// </summary>
        private string _DDFuWuXiangMuName  = "";
        /// <summary>
        /// 订单的服务项目名称
        /// </summary>
        [DisplayName("订单的服务项目名称")]
        public string DDFuWuXiangMuName
        {
            set { _DDFuWuXiangMuName = value; }
            get { return _DDFuWuXiangMuName; }
        }
        
         
        
        /// <summary>
        /// 订单支付状态 0未支付，每支付一笔加1
        /// </summary>
        private int _PayStatus ;
        /// <summary>
        /// 订单支付状态 0未支付，每支付一笔加1
        /// </summary>
        [DisplayName("订单支付状态 0未支付，每支付一笔加1")]
        public int PayStatus
        {
            set { _PayStatus = value; }
            get { return _PayStatus; }
        }
        
         
        
        /// <summary>
        /// 订单所属的分公司
        /// </summary>
        private int? _ProjectId ;
        /// <summary>
        /// 订单所属的分公司
        /// </summary>
        [DisplayName("订单所属的分公司")]
        public int? ProjectId
        {
            set { _ProjectId = value; }
            get { return _ProjectId; }
        }
        
         
        
        /// <summary>
        /// 订单的联系人
        /// </summary>
        private string _DDLianXiRen  = "";
        /// <summary>
        /// 订单的联系人
        /// </summary>
        [DisplayName("订单的联系人")]
        public string DDLianXiRen
        {
            set { _DDLianXiRen = value; }
            get { return _DDLianXiRen; }
        }
        
         
        
        /// <summary>
        /// 订单联系人电话
        /// </summary>
        private string _DDLianXiRenPhone  = "";
        /// <summary>
        /// 订单联系人电话
        /// </summary>
        [DisplayName("订单联系人电话")]
        public string DDLianXiRenPhone
        {
            set { _DDLianXiRenPhone = value; }
            get { return _DDLianXiRenPhone; }
        }
        
         
        
        /// <summary>
        /// 父订单ID
        /// </summary>
        private int? _parentDDID ;
        /// <summary>
        /// 父订单ID
        /// </summary>
        [DisplayName("父订单ID")]
        public int? parentDDID
        {
            set { _parentDDID = value; }
            get { return _parentDDID; }
        }
        
         
        
        /// <summary>
        /// 订单评价状态 0未评价 1已评价
        /// </summary>
        private int _DDPingJiaState ;
        /// <summary>
        /// 订单评价状态 0未评价 1已评价
        /// </summary>
        [DisplayName("订单评价状态 0未评价 1已评价")]
        public int DDPingJiaState
        {
            set { _DDPingJiaState = value; }
            get { return _DDPingJiaState; }
        }
        
         
        
        /// <summary>
        /// 佣金的金额，默认值为订单金额*0.05
        /// </summary>
        private decimal? _YongjinMoney ;
        /// <summary>
        /// 佣金的金额，默认值为订单金额*0.05
        /// </summary>
        [DisplayName("佣金的金额，默认值为订单金额*0.05")]
        public decimal? YongjinMoney
        {
            set { _YongjinMoney = value; }
            get { return _YongjinMoney; }
        }
        
         
        
        /// <summary>
        /// 运营中心审核人名字
        /// </summary>
        private string _YunxingCheckedName  = "";
        /// <summary>
        /// 运营中心审核人名字
        /// </summary>
        [DisplayName("运营中心审核人名字")]
        public string YunxingCheckedName
        {
            set { _YunxingCheckedName = value; }
            get { return _YunxingCheckedName; }
        }
        
         
        
        /// <summary>
        /// 运营中心审核时间
        /// </summary>
        private DateTime? _YunxingCheckedDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 运营中心审核时间
        /// </summary>
        [DisplayName("运营中心审核时间")]
        public DateTime? YunxingCheckedDateTime
        {
            set { _YunxingCheckedDateTime = value; }
            get { return _YunxingCheckedDateTime; }
        }
        
        private DateTime _YunxingCheckedDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime YunxingCheckedDateTimeStart
{
set { _YunxingCheckedDateTimeStart = value; }
get{ return _YunxingCheckedDateTimeStart; }
}
 private DateTime _YunxingCheckedDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime YunxingCheckedDateTimeEnd
{
set { _YunxingCheckedDateTimeEnd = value; }
get{ return _YunxingCheckedDateTimeEnd; }
}
  
        
        /// <summary>
        /// 总裁审核人名字
        /// </summary>
        private string _ZongCaiCheckedName  = "";
        /// <summary>
        /// 总裁审核人名字
        /// </summary>
        [DisplayName("总裁审核人名字")]
        public string ZongCaiCheckedName
        {
            set { _ZongCaiCheckedName = value; }
            get { return _ZongCaiCheckedName; }
        }
        
         
        
        /// <summary>
        /// 总裁审核时间
        /// </summary>
        private DateTime? _ZongCaiCheckedDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 总裁审核时间
        /// </summary>
        [DisplayName("总裁审核时间")]
        public DateTime? ZongCaiCheckedDateTime
        {
            set { _ZongCaiCheckedDateTime = value; }
            get { return _ZongCaiCheckedDateTime; }
        }
        
        private DateTime _ZongCaiCheckedDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ZongCaiCheckedDateTimeStart
{
set { _ZongCaiCheckedDateTimeStart = value; }
get{ return _ZongCaiCheckedDateTimeStart; }
}
 private DateTime _ZongCaiCheckedDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ZongCaiCheckedDateTimeEnd
{
set { _ZongCaiCheckedDateTimeEnd = value; }
get{ return _ZongCaiCheckedDateTimeEnd; }
}
  
        
        /// <summary>
        /// 财务支付人名字
        /// </summary>
        private string _CaiWuZhiFuName  = "";
        /// <summary>
        /// 财务支付人名字
        /// </summary>
        [DisplayName("财务支付人名字")]
        public string CaiWuZhiFuName
        {
            set { _CaiWuZhiFuName = value; }
            get { return _CaiWuZhiFuName; }
        }
        
         
        
        /// <summary>
        /// 财务支付日期
        /// </summary>
        private DateTime? _CaiWuZhiFuDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 财务支付日期
        /// </summary>
        [DisplayName("财务支付日期")]
        public DateTime? CaiWuZhiFuDateTime
        {
            set { _CaiWuZhiFuDateTime = value; }
            get { return _CaiWuZhiFuDateTime; }
        }
        
        private DateTime _CaiWuZhiFuDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CaiWuZhiFuDateTimeStart
{
set { _CaiWuZhiFuDateTimeStart = value; }
get{ return _CaiWuZhiFuDateTimeStart; }
}
 private DateTime _CaiWuZhiFuDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CaiWuZhiFuDateTimeEnd
{
set { _CaiWuZhiFuDateTimeEnd = value; }
get{ return _CaiWuZhiFuDateTimeEnd; }
}
  
        
        /// <summary>
        /// 财务支付凭证号
        /// </summary>
        private string _CaiWuZhifFuPingZhen  = "";
        /// <summary>
        /// 财务支付凭证号
        /// </summary>
        [DisplayName("财务支付凭证号")]
        public string CaiWuZhifFuPingZhen
        {
            set { _CaiWuZhifFuPingZhen = value; }
            get { return _CaiWuZhifFuPingZhen; }
        }
        
         
        
        /// <summary>
        /// 佣金支付状态 数据字典
        /// </summary>
        private string _YongjinState  = "";
        /// <summary>
        /// 佣金支付状态 数据字典
        /// </summary>
        [DisplayName("佣金支付状态 数据字典")]
        public string YongjinState
        {
            set { _YongjinState = value; }
            get { return _YongjinState; }
        }
        
         
        
        /// <summary>
        /// 订单状态日期
        /// </summary>
        private DateTime? _DingdanStateDateTime  = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 订单状态日期
        /// </summary>
        [DisplayName("订单状态日期")]
        public DateTime? DingdanStateDateTime
        {
            set { _DingdanStateDateTime = value; }
            get { return _DingdanStateDateTime; }
        }
        
        private DateTime _DingdanStateDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DingdanStateDateTimeStart
{
set { _DingdanStateDateTimeStart = value; }
get{ return _DingdanStateDateTimeStart; }
}
 private DateTime _DingdanStateDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DingdanStateDateTimeEnd
{
set { _DingdanStateDateTimeEnd = value; }
get{ return _DingdanStateDateTimeEnd; }
}
  
        
        /// <summary>
        /// 订单保险单号
        /// </summary>
        private string _DDBaoXianHao  = "";
        /// <summary>
        /// 订单保险单号
        /// </summary>
        [DisplayName("订单保险单号")]
        public string DDBaoXianHao
        {
            set { _DDBaoXianHao = value; }
            get { return _DDBaoXianHao; }
        }
        
         
        
        /// <summary>
        /// 订单服务点
        /// </summary>
        private string _DDFuWuDian  = "";
        /// <summary>
        /// 订单服务点
        /// </summary>
        [DisplayName("订单服务点")]
        public string DDFuWuDian
        {
            set { _DDFuWuDian = value; }
            get { return _DDFuWuDian; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class DingDanReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 订单ID
        /// </summary> 
        public int? id { get;set; } 
	
          
        /// <summary>
        /// 客户ID
        /// </summary> 
        public int? CustomId { get; set; } 
	
          
        /// <summary>
        /// 订单名称
        /// </summary> 
        public string DDName { get;set; } 
	
          
        /// <summary>
        /// 订单编号
        /// </summary> 
        public string DDNumber { get;set; } 
	
          
        /// <summary>
        /// 订单金额
        /// </summary> 
        public decimal? DDMoeny { get; set; } 
	
          
        /// <summary>
        /// 订单实际金额
        /// </summary> 
        public decimal? DDRealMoney { get; set; } 
	
          
        /// <summary>
        /// 订单定金
        /// </summary> 
        public decimal? DDDingJin { get; set; } 
	
          
        /// <summary>
        /// 订单预付
        /// </summary> 
        public decimal? DDYuFu { get; set; } 
	
          
        /// <summary>
        /// 订单余款
        /// </summary> 
        public decimal? DDYuKuan { get; set; } 
	
          
        /// <summary>
        /// 月嫂 Id
        /// </summary> 
        public int? ysID { get;set; } 
	
          
        /// <summary>
        /// 订单状态id
        /// </summary> 
        public string DDStateID { get;set; } 
	
          
        /// <summary>
        /// 订单备注
        /// </summary> 
        public string DDInfos { get;set; } 
	
          
        /// <summary>
        /// 订单签约公司ID
        /// </summary> 
        public int? DDCompanyID { get;set; } 
	
          
        /// <summary>
        /// 订单来源ID
        /// </summary> 
        public string DDLaiYuanID { get;set; } 
	
          
        /// <summary>
        /// 订单服务项目ID
        /// </summary> 
        public int? DDFuWuXiangMuID { get;set; } 
	
          
        /// <summary>
        /// 订单服务地址
        /// </summary> 
        public string DDFuWuAddress { get;set; } 
	
          
        /// <summary>
        /// 订单预约开始日期
        /// </summary> 
        public DateTime? DDFuWuYuYueBeginTime { get;set; } 
	
          private DateTime _DDFuWuYuYueBeginTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueBeginTimeStart
{
set { _DDFuWuYuYueBeginTimeStart = value; }
get{ return _DDFuWuYuYueBeginTimeStart; }
}
 private DateTime _DDFuWuYuYueBeginTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueBeginTimeEnd
{
set { _DDFuWuYuYueBeginTimeEnd = value; }
get{ return _DDFuWuYuYueBeginTimeEnd; }
}
 
        /// <summary>
        /// 订单预约结束日期
        /// </summary> 
        public DateTime? DDFuWuYuYueEndTime { get;set; } 
	
          private DateTime _DDFuWuYuYueEndTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueEndTimeStart
{
set { _DDFuWuYuYueEndTimeStart = value; }
get{ return _DDFuWuYuYueEndTimeStart; }
}
 private DateTime _DDFuWuYuYueEndTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuYuYueEndTimeEnd
{
set { _DDFuWuYuYueEndTimeEnd = value; }
get{ return _DDFuWuYuYueEndTimeEnd; }
}
 
        /// <summary>
        /// 订单服务开始时间
        /// </summary> 
        public DateTime? DDFuWuBeginTime { get;set; } 
	
          private DateTime _DDFuWuBeginTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuBeginTimeStart
{
set { _DDFuWuBeginTimeStart = value; }
get{ return _DDFuWuBeginTimeStart; }
}
 private DateTime _DDFuWuBeginTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuBeginTimeEnd
{
set { _DDFuWuBeginTimeEnd = value; }
get{ return _DDFuWuBeginTimeEnd; }
}
 
        /// <summary>
        /// 订单服务结束时间
        /// </summary> 
        public DateTime? DDFuWuEndTime { get;set; } 
	
          private DateTime _DDFuWuEndTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuEndTimeStart
{
set { _DDFuWuEndTimeStart = value; }
get{ return _DDFuWuEndTimeStart; }
}
 private DateTime _DDFuWuEndTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDFuWuEndTimeEnd
{
set { _DDFuWuEndTimeEnd = value; }
get{ return _DDFuWuEndTimeEnd; }
}
 
        /// <summary>
        /// 订单客户评价
        /// </summary> 
        public string DDKeFuComments { get;set; } 
	
          
        /// <summary>
        /// 操作人
        /// </summary> 
        public string OptName { get;set; } 
	
          
        /// <summary>
        /// 订单日期创建
        /// </summary> 
        public DateTime DDCreateTime { get;set; } 
	
          private DateTime _DDCreateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDCreateTimeStart
{
set { _DDCreateTimeStart = value; }
get{ return _DDCreateTimeStart; }
}
 private DateTime _DDCreateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DDCreateTimeEnd
{
set { _DDCreateTimeEnd = value; }
get{ return _DDCreateTimeEnd; }
}
 
        /// <summary>
        /// 订单业务人员名称
        /// </summary> 
        public string DDYeWuName { get;set; } 
	
          
        /// <summary>
        /// 客户名称
        /// </summary> 
        public string CustomName { get;set; } 
	
          
        /// <summary>
        /// 订单的月嫂名称
        /// </summary> 
        public string ysName { get;set; } 
	
          
        /// <summary>
        /// 订单的服务项目名称
        /// </summary> 
        public string DDFuWuXiangMuName { get;set; } 
	
          
        /// <summary>
        /// 订单支付状态 0未支付，每支付一笔加1
        /// </summary> 
        public int? PayStatus { get; set; }


        ///// <summary>
        ///// 订单所属的分公司
        ///// </summary> 
        //public int? ProjectId { get; set; } 
	
          
        /// <summary>
        /// 订单的联系人
        /// </summary> 
        public string DDLianXiRen { get;set; } 
	
          
        /// <summary>
        /// 订单联系人电话
        /// </summary> 
        public string DDLianXiRenPhone { get;set; } 
	
          
        /// <summary>
        /// 父订单ID
        /// </summary> 
        public int parentDDID { get;set; } 
	
          
        /// <summary>
        /// 订单评价状态 0未评价 1已评价
        /// </summary> 
        public int DDPingJiaState { get;set; } 
	
          
        /// <summary>
        /// 佣金的金额，默认值为订单金额*0.05
        /// </summary> 
        public decimal? YongjinMoney { get;set; } 
	
          
        /// <summary>
        /// 运营中心审核人名字
        /// </summary> 
        public string YunxingCheckedName { get;set; } 
	
          
        /// <summary>
        /// 运营中心审核时间
        /// </summary> 
        public DateTime? YunxingCheckedDateTime { get;set; } 
	
          private DateTime _YunxingCheckedDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime YunxingCheckedDateTimeStart
{
set { _YunxingCheckedDateTimeStart = value; }
get{ return _YunxingCheckedDateTimeStart; }
}
 private DateTime _YunxingCheckedDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime YunxingCheckedDateTimeEnd
{
set { _YunxingCheckedDateTimeEnd = value; }
get{ return _YunxingCheckedDateTimeEnd; }
}
 
        /// <summary>
        /// 总裁审核人名字
        /// </summary> 
        public string ZongCaiCheckedName { get;set; } 
	
          
        /// <summary>
        /// 总裁审核时间
        /// </summary> 
        public DateTime? ZongCaiCheckedDateTime { get;set; } 
	
          private DateTime _ZongCaiCheckedDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ZongCaiCheckedDateTimeStart
{
set { _ZongCaiCheckedDateTimeStart = value; }
get{ return _ZongCaiCheckedDateTimeStart; }
}
 private DateTime _ZongCaiCheckedDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime ZongCaiCheckedDateTimeEnd
{
set { _ZongCaiCheckedDateTimeEnd = value; }
get{ return _ZongCaiCheckedDateTimeEnd; }
}
 
        /// <summary>
        /// 财务支付人名字
        /// </summary> 
        public string CaiWuZhiFuName { get;set; } 
	
          
        /// <summary>
        /// 财务支付日期
        /// </summary> 
        public DateTime? CaiWuZhiFuDateTime { get;set; } 
	
          private DateTime _CaiWuZhiFuDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CaiWuZhiFuDateTimeStart
{
set { _CaiWuZhiFuDateTimeStart = value; }
get{ return _CaiWuZhiFuDateTimeStart; }
}
 private DateTime _CaiWuZhiFuDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime CaiWuZhiFuDateTimeEnd
{
set { _CaiWuZhiFuDateTimeEnd = value; }
get{ return _CaiWuZhiFuDateTimeEnd; }
}
 
        /// <summary>
        /// 财务支付凭证号
        /// </summary> 
        public string CaiWuZhifFuPingZhen { get;set; } 
	
          
        /// <summary>
        /// 佣金支付状态 数据字典
        /// </summary> 
        public string YongjinState { get;set; } 
	
          
        /// <summary>
        /// 订单状态日期
        /// </summary> 
        public DateTime? DingdanStateDateTime { get;set; } 
	
          private DateTime _DingdanStateDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DingdanStateDateTimeStart
{
set { _DingdanStateDateTimeStart = value; }
get{ return _DingdanStateDateTimeStart; }
}
 private DateTime _DingdanStateDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime DingdanStateDateTimeEnd
{
set { _DingdanStateDateTimeEnd = value; }
get{ return _DingdanStateDateTimeEnd; }
}
 
        /// <summary>
        /// 订单保险单号
        /// </summary> 
        public string DDBaoXianHao { get;set; } 
	
          
        /// <summary>
        /// 订单服务点
        /// </summary> 
        public string DDFuWuDian { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

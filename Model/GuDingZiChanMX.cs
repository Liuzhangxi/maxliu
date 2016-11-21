



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
    /// <para>摘要：guDingZiChanMXModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
    /// <remarks>
    /// 对应数据库表：guDingZiChanMX
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>GuDingId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>对应资产</td></tr>
    /// <tr valign="top"><td>3</td><td>zichanNum</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>编号</td></tr>
    /// <tr valign="top"><td>4</td><td>zichanName</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>名称</td></tr>
    /// <tr valign="top"><td>5</td><td>zichanPinPai</td><td>nvarchar</td><td>150</td><td></td><td></td><td></td><td>√</td><td></td><td>品牌</td></tr>
    /// <tr valign="top"><td>6</td><td>zichanChangJia</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>厂商</td></tr>
    /// <tr valign="top"><td>7</td><td>changjiaNum</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>厂商型号	</td></tr>
    /// <tr valign="top"><td>8</td><td>zichanShulia</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>数量</td></tr>
    /// <tr valign="top"><td>9</td><td>zichanSingle</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>单价</td></tr>
    /// <tr valign="top"><td>10</td><td>zichanJi</td><td>decimal</td><td>9</td><td>18,2</td><td></td><td></td><td>√</td><td></td><td>金额</td></tr>
    /// <tr valign="top"><td>11</td><td>zichanDiDian</td><td>nvarchar</td><td>250</td><td></td><td></td><td></td><td>√</td><td></td><td>存放地点	</td></tr>
    /// <tr valign="top"><td>12</td><td>zichanUserName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>使用人名</td></tr>
    /// <tr valign="top"><td>13</td><td>zichanUserId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>使用人</td></tr>
    /// <tr valign="top"><td>14</td><td>zichanCaiGouName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>采购人名</td></tr>
    /// <tr valign="top"><td>15</td><td>zichanCaiGouId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>采购人</td></tr>
    /// <tr valign="top"><td>16</td><td>zichanGouRuDate</td><td>date</td><td>3</td><td></td><td></td><td></td><td>√</td><td></td><td>购入时间</td></tr>
    /// <tr valign="top"><td>17</td><td>zichanBeiZhu</td><td>nvarchar</td><td>850</td><td></td><td></td><td></td><td>√</td><td></td><td>备注</td></tr>
    /// <tr valign="top"><td>18</td><td>zichanBuChong</td><td>nvarchar</td><td>550</td><td></td><td></td><td></td><td>√</td><td></td><td>补充</td></tr>
    /// <tr valign="top"><td>19</td><td>optName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人名_optname</td></tr>
    /// <tr valign="top"><td>20</td><td>optId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>操作人_optid</td></tr>
    /// <tr valign="top"><td>21</td><td>createDateTime</td><td>datetime</td><td>8</td><td></td><td></td><td></td><td>√</td><td></td><td>操作时间_createdate</td></tr>
    /// <tr valign="top"><td>22</td><td>state</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>状态_validstate</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################

    public class guDingZiChanMXBig
    {

        public guDingZiChanMX guDingZiChanMX { get; set; }

        public  guDingZiChan guDingZiChan { get; set; }

    }

    [Table("guDingZiChanMX")]
    [Serializable]
    public partial class guDingZiChanMX 
    {
    
        public static string LogClass = "固定资产明细";
        #region -  公共属性  ------------------------------------------------------------
        ///// </summary>
        //[DisplayName("资产名")]

        //public string mainZiChanName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private int _id ;
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
        /// 对应资产
        /// </summary>
        private int? _GuDingId ;
        /// <summary>
        /// 对应资产
        /// </summary>
        [DisplayName("对应固定资产id")]
        
        public int? GuDingId
        {
            set { _GuDingId = value; }
            get { return _GuDingId; }
        }
        
         
        
        /// <summary>
        /// 编号
        /// </summary>
        private string _zichanNum  = "";
        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("编号")]
        
        public string zichanNum
        {
            set { _zichanNum = value; }
            get { return _zichanNum; }
        }
        
         
        
        /// <summary>
        /// 名称
        /// </summary>
        private string _zichanName  = "";
        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("名称")]
        
        public string zichanName
        {
            set { _zichanName = value; }
            get { return _zichanName; }
        }
        
         
        
        /// <summary>
        /// 品牌
        /// </summary>
        private string _zichanPinPai  = "";
        /// <summary>
        /// 品牌
        /// </summary>
        [DisplayName("品牌")]
        
        public string zichanPinPai
        {
            set { _zichanPinPai = value; }
            get { return _zichanPinPai; }
        }
        
         
        
        /// <summary>
        /// 厂商
        /// </summary>
        private string _zichanChangJia  = "";
        /// <summary>
        /// 厂商
        /// </summary>
        [DisplayName("厂商")]
        
        public string zichanChangJia
        {
            set { _zichanChangJia = value; }
            get { return _zichanChangJia; }
        }
        
         
        
        /// <summary>
        /// 厂商型号	
        /// </summary>
        private string _changjiaNum  = "";
        /// <summary>
        /// 厂商型号	
        /// </summary>
        [DisplayName("厂商型号	")]
        
        public string changjiaNum
        {
            set { _changjiaNum = value; }
            get { return _changjiaNum; }
        }
        
         
        
        /// <summary>
        /// 数量
        /// </summary>
        private decimal? _zichanShulia ;
        /// <summary>
        /// 数量
        /// </summary>
        [DisplayName("数量")]
        
        public decimal? zichanShulia
        {
            set { _zichanShulia = value; }
            get { return _zichanShulia; }
        }
        
         
        
        /// <summary>
        /// 单价
        /// </summary>
        private decimal? _zichanSingle ;
        /// <summary>
        /// 单价
        /// </summary>
        [DisplayName("单价")]
        
        public decimal? zichanSingle
        {
            set { _zichanSingle = value; }
            get { return _zichanSingle; }
        }
        
         
        
        /// <summary>
        /// 金额
        /// </summary>
        private decimal? _zichanJi ;
        /// <summary>
        /// 金额
        /// </summary>
        [DisplayName("金额")]
        
        public decimal? zichanJi
        {
            set { _zichanJi = value; }
            get { return _zichanJi; }
        }
        
         
        
        /// <summary>
        /// 存放地点	
        /// </summary>
        private string _zichanDiDian  = "";
        /// <summary>
        /// 存放地点	
        /// </summary>
        [DisplayName("存放地点	")]
        
        public string zichanDiDian
        {
            set { _zichanDiDian = value; }
            get { return _zichanDiDian; }
        }
        
         
        
        /// <summary>
        /// 使用人名
        /// </summary>
        private string _zichanUserName  = "";
        /// <summary>
        /// 使用人名
        /// </summary>
        [DisplayName("使用人名")]
        
        public string zichanUserName
        {
            set { _zichanUserName = value; }
            get { return _zichanUserName; }
        }
        
         
        
        /// <summary>
        /// 使用人
        /// </summary>
        private int? _zichanUserId ;
        /// <summary>
        /// 使用人
        /// </summary>
        [DisplayName("使用人id")]
        
        public int? zichanUserId
        {
            set { _zichanUserId = value; }
            get { return _zichanUserId; }
        }
        
         
        
        /// <summary>
        /// 采购人名
        /// </summary>
        private string _zichanCaiGouName  = "";
        /// <summary>
        /// 采购人名
        /// </summary>
        [DisplayName("采购人名")]
        
        public string zichanCaiGouName
        {
            set { _zichanCaiGouName = value; }
            get { return _zichanCaiGouName; }
        }
        
         
        
        /// <summary>
        /// 采购人
        /// </summary>
        private int? _zichanCaiGouId ;
        /// <summary>
        /// 采购人
        /// </summary>
        [DisplayName("采购人id")]
        
        public int? zichanCaiGouId
        {
            set { _zichanCaiGouId = value; }
            get { return _zichanCaiGouId; }
        }
        
         
        
        /// <summary>
        /// 购入时间
        /// </summary>
        private DateTime? _zichanGouRuDate ;
        /// <summary>
        /// 购入时间
        /// </summary>
        [DisplayName("购入时间")]
        
        public DateTime? zichanGouRuDate
        {
            set { _zichanGouRuDate = value; }
            get { return _zichanGouRuDate; }
        }
        
        private DateTime _zichanGouRuDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime zichanGouRuDateStart
{
set { _zichanGouRuDateStart = value; }
get{ return _zichanGouRuDateStart; }
}
 private DateTime _zichanGouRuDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime zichanGouRuDateEnd
{
set { _zichanGouRuDateEnd = value; }
get{ return _zichanGouRuDateEnd; }
}
  
        
        /// <summary>
        /// 备注
        /// </summary>
        private string _zichanBeiZhu  = "";
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        
        public string zichanBeiZhu
        {
            set { _zichanBeiZhu = value; }
            get { return _zichanBeiZhu; }
        }
        
         
        
        /// <summary>
        /// 补充
        /// </summary>
        private string _zichanBuChong  = "";
        /// <summary>
        /// 补充
        /// </summary>
        [DisplayName("补充")]
        
        public string zichanBuChong
        {
            set { _zichanBuChong = value; }
            get { return _zichanBuChong; }
        }
        
         
        
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        private string _optName  = "";
        /// <summary>
        /// 操作人名_optname
        /// </summary>
        [DisplayName("操作人名")]
        
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }
        
         
        
        /// <summary>
        /// 操作人_optid
        /// </summary>
        private int? _optId ;
        /// <summary>
        /// 操作人_optid
        /// </summary>
        [DisplayName("操作人")]
        
        public int? optId
        {
            set { _optId = value; }
            get { return _optId; }
        }
        
         
        
        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        private DateTime? _createDateTime ;
        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        [DisplayName("操作时间")]
        
        public DateTime? createDateTime
        {
            set { _createDateTime = value; }
            get { return _createDateTime; }
        }
        
        private DateTime _createDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateTimeStart
{
set { _createDateTimeStart = value; }
get{ return _createDateTimeStart; }
}
 private DateTime _createDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateTimeEnd
{
set { _createDateTimeEnd = value; }
get{ return _createDateTimeEnd; }
}
  
        
        /// <summary>
        /// 状态_validstate
        /// </summary>
        private string _state  = "";
        /// <summary>
        /// 状态_validstate
        /// </summary>
        [DisplayName("状态")]
        
        public string state
        {
            set { _state = value; }
            get { return _state; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class guDingZiChanMXReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 对应资产
        /// </summary> 
        public int? GuDingId { get;set; } 
	
          
        /// <summary>
        /// 编号
        /// </summary> 
        public string zichanNum { get;set; } 
	
          
        /// <summary>
        /// 名称
        /// </summary> 
        public string zichanName { get;set; } 
	
          
        /// <summary>
        /// 品牌
        /// </summary> 
        public string zichanPinPai { get;set; } 
	
          
        /// <summary>
        /// 厂商
        /// </summary> 
        public string zichanChangJia { get;set; } 
	
          
        /// <summary>
        /// 厂商型号	
        /// </summary> 
        public string changjiaNum { get;set; } 
	
          
        /// <summary>
        /// 数量
        /// </summary> 
        public decimal? zichanShulia { get;set; } 
	
          
        /// <summary>
        /// 单价
        /// </summary> 
        public decimal? zichanSingle { get;set; } 
	
          
        /// <summary>
        /// 金额
        /// </summary> 
        public decimal? zichanJi { get;set; } 
	
          
        /// <summary>
        /// 存放地点	
        /// </summary> 
        public string zichanDiDian { get;set; } 
	
          
        /// <summary>
        /// 使用人名
        /// </summary> 
        public string zichanUserName { get;set; } 
	
          
        /// <summary>
        /// 使用人
        /// </summary> 
        public int? zichanUserId { get;set; } 
	
          
        /// <summary>
        /// 采购人名
        /// </summary> 
        public string zichanCaiGouName { get;set; } 
	
          
        /// <summary>
        /// 采购人
        /// </summary> 
        public int? zichanCaiGouId { get;set; } 
	
          
        /// <summary>
        /// 购入时间
        /// </summary> 
        public DateTime? zichanGouRuDate { get;set; } 
	
          private DateTime _zichanGouRuDateStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime zichanGouRuDateStart
{
set { _zichanGouRuDateStart = value; }
get{ return _zichanGouRuDateStart; }
}
 private DateTime _zichanGouRuDateEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime zichanGouRuDateEnd
{
set { _zichanGouRuDateEnd = value; }
get{ return _zichanGouRuDateEnd; }
}
 
        /// <summary>
        /// 备注
        /// </summary> 
        public string zichanBeiZhu { get;set; } 
	
          
        /// <summary>
        /// 补充
        /// </summary> 
        public string zichanBuChong { get;set; } 
	
          
        /// <summary>
        /// 操作人名_optname
        /// </summary> 
        public string optName { get;set; } 
	
          
        /// <summary>
        /// 操作人_optid
        /// </summary> 
        public int? optId { get;set; } 
	
          
        /// <summary>
        /// 操作时间_createdate
        /// </summary> 
        public DateTime? createDateTime { get;set; } 
	
          private DateTime _createDateTimeStart = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateTimeStart
{
set { _createDateTimeStart = value; }
get{ return _createDateTimeStart; }
}
 private DateTime _createDateTimeEnd = SqlDateTime.MinValue.Value;
[NotMapped]
public DateTime createDateTimeEnd
{
set { _createDateTimeEnd = value; }
get{ return _createDateTimeEnd; }
}
 
        /// <summary>
        /// 状态_validstate
        /// </summary> 
        public string state { get;set; } 
	
          
        
       
        #endregion ----------------------------------------------------------------------
    } 
    
}

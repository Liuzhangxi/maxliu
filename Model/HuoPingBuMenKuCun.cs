



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
    /// <para>摘要：HuoPingBuMenKuCunModel 类，业务模型。</para>
    /// <para>说明：</para>
    /// <para>Programmer： Sean</para>
    /// <para>Email： </para>
	/// <remarks>
    /// 对应数据库表：HuoPingBuMenKuCun
    /// <table class="dtTABLE" cellspacing="0">
    /// <tr valign="top"><th>序号</th><th>列名</th><th>数据类型</th><th>长度</th><th>小数位</th><th>标识</th><th>主键</th><th>允许空</th><th>默认值</th><th>字段说明</th></tr>
    /// <tr valign="top"><td>1</td><td>id</td><td>int</td><td>4</td><td></td><td>√</td><td>√</td><td></td><td></td><td></td></tr>
    /// <tr valign="top"><td>2</td><td>projectId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>部门ID</td></tr>
    /// <tr valign="top"><td>3</td><td>projectName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>部门名称</td></tr>
    /// <tr valign="top"><td>4</td><td>HPId</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品ID</td></tr>
    /// <tr valign="top"><td>5</td><td>HPName</td><td>nvarchar</td><td>50</td><td></td><td></td><td></td><td>√</td><td></td><td>货品名称</td></tr>
    /// <tr valign="top"><td>6</td><td>CurStock</td><td>int</td><td>4</td><td></td><td></td><td></td><td>√</td><td></td><td>货品库存数</td></tr>
    /// </table>
    /// </remarks>
    /// </summary>
    ///################################################################################################
     [Table("HuoPingBuMenKuCun")]
    [Serializable]
    public partial class HuoPingBuMenKuCun 
    {
    
        public static string LogClass = "货品部门库存";
        #region -  公共属性  ------------------------------------------------------------

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
        /// 部门ID
        /// </summary>
        private int? _projectId ;
        /// <summary>
        /// 部门ID
        /// </summary>
        [DisplayName("部门ID")]
        
        public int? projectId
        {
            set { _projectId = value; }
            get { return _projectId; }
        }
        
         
        
        /// <summary>
        /// 部门名称
        /// </summary>
        private string _projectName  = "";
        /// <summary>
        /// 部门名称
        /// </summary>
        [DisplayName("部门名称")]
        
        public string projectName
        {
            set { _projectName = value; }
            get { return _projectName; }
        }
        
         
        
        /// <summary>
        /// 货品ID
        /// </summary>
        private int? _HPId ;
        /// <summary>
        /// 货品ID
        /// </summary>
        [DisplayName("货品ID")]
        
        public int? HPId
        {
            set { _HPId = value; }
            get { return _HPId; }
        }
        
         
        
        /// <summary>
        /// 货品名称
        /// </summary>
        private string _HPName  = "";
        /// <summary>
        /// 货品名称
        /// </summary>
        [DisplayName("货品名称")]
        
        public string HPName
        {
            set { _HPName = value; }
            get { return _HPName; }
        }
        
         
        
        /// <summary>
        /// 货品库存数
        /// </summary>
        private int? _CurStock ;
        /// <summary>
        /// 货品库存数
        /// </summary>
        [DisplayName("货品库存数")]
        
        public int? CurStock
        {
            set { _CurStock = value; }
            get { return _CurStock; }
        }
        
         
        
        
        #endregion ----------------------------------------------------------------------
    } 
    
    public partial class HuoPingBuMenKuCunReq:BaseSearchReq
    { 
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get;set; } 
	
          
        /// <summary>
        /// 部门名称
        /// </summary> 
        public string projectName { get;set; } 
	
          
        /// <summary>
        /// 货品ID
        /// </summary> 
        public int? HPId { get;set; } 
	
          
        /// <summary>
        /// 货品名称
        /// </summary> 
        public string HPName { get;set; } 
	
          
        /// <summary>
        /// 货品库存数
        /// </summary> 
        public int? CurStock { get;set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        private int? _projectId;
        /// <summary>
        /// 部门ID
        /// </summary>
        [DisplayName("部门ID")]

        public int? projectId
        {
            set { _projectId = value; }
            get { return _projectId; }
        }


        #endregion ----------------------------------------------------------------------
    } 
    
}

using System.ComponentModel;
using System.Data.SqlTypes;
using OUDAL.ModelBase;

namespace OUDAL.Model.Sales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTable")]
    public partial class SalesTable
    {
        public static string LogClass = "SalesTable";
        [DisplayName("喜喜门店")]
        public int? xixiProjectId { get; set; }
        
        [DisplayName("系统中用户名")]
        public string SystemUserName { get; set; }
        [DisplayName("系统中用户")]
        public int? SystemUserId { get; set; }

        [DisplayName("所属部门ID")]
        public int? salesDeptID { set; get; }

        [DisplayName("是否为部门经理")]
        public int? isDeptManger { set; get; }


        [DisplayName("状态")]
        public int salesStateID { set; get; }


        [Key]
        public int id { set; get; }

        /// <summary>
        /// 销售员名字
        /// </summary>
        [DisplayName("销售员名字")]
        [Required]
        public string salesName { set; get; } = "";


        /// <summary>
        /// 销售员电话
        /// </summary>
        [DisplayName("销售员电话")]
        [Required]
        public string salesPhone { set; get; } = "";


        /// <summary>
        /// 销售员密码
        /// </summary>
        [DisplayName("销售员密码")]
        [Required]
        public string salesPsd { set; get; } = "";


        /// <summary>
        /// 销售员所在门店
        /// </summary>
        [DisplayName("销售员所在门店")]
        [Required]
        public string salesDepart { set; get; } = "";


        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string optName { set; get; } = "";


        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]
        public DateTime optDateTime { set; get; } = SqlDateTime.MinValue.Value;

        [DisplayName("职员类型")]
        public string salesType { get; set; }


        [NotMapped]
        public DateTime optDateTimeStart { set; get; } = SqlDateTime.MinValue.Value;

        [NotMapped]
        public DateTime optDateTimeEnd { set; get; } = SqlDateTime.MinValue.Value;


        [DisplayName("是否为部门经理")]
        [NotMapped]
        public string isDeptMangerDesc
        {
            get
            {
                switch (isDeptManger)
                {
                    case 2:
                        return "否";
                    default: return "是";
                }
            }
        }

        [DisplayName("状态")]
        [NotMapped]
        public string salesStateIDDesc
        {
            get
            {
                switch (salesStateID)
                {
                    case 2:
                        return "无效";
                    default: return "有效";
                }
            }
        }
    }
}

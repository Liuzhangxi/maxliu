using System.ComponentModel;

namespace OUDAL.Model.Sales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salesDept")]
    public partial class salesDept
    {
        public int id { get; set; }

        [DisplayName("喜喜门店")]
        public int? xixiProjectID { get; set; }

        [Required]
        [DisplayName("部门名称")]
        [StringLength(50)]
        public string DeptName { get; set; }

        [DisplayName("项目id")]
        public int projectID { get; set; }

        [DisplayName("城市id")]
        public int cityID { get; set; }

        [DisplayName("部门状态")]
        public int deptStateID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("操作人")]
        public string optName { get; set; }

        [DisplayName("操作时间")]
        public DateTime optDateTime { get; set; }
    }
}

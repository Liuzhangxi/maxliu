namespace OUDAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yixiangKehuView")]
    public partial class yixiangKehuView
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [StringLength(50)]
        public string KhName { get; set; }

        [StringLength(50)]
        public string KhPsd { get; set; }

        [StringLength(20)]
        public string KhPhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KhYuChanQi { get; set; }

        [StringLength(300)]
        public string KhYuChanHospital { get; set; }

        [StringLength(300)]
        public string KhYuChanHospitalAddress { get; set; }

        [StringLength(100)]
        public string KhCity { get; set; }

        [StringLength(300)]
        public string KhAddress { get; set; }

        public int? KhAge { get; set; }

        [StringLength(300)]
        public string KhInfos { get; set; }

        [StringLength(100)]
        public string KhWeiXinID { get; set; }

        public DateTime? KhCreateTime { get; set; }

        [StringLength(100)]
        public string OptName { get; set; }

        [StringLength(100)]
        public string KhLaiYuan { get; set; }

        [StringLength(100)]
        public string KhState { get; set; }

        [StringLength(100)]
        public string KhYeWu { get; set; }

        [StringLength(100)]
        public string KhWeiXin { get; set; }

        public int? KhBabyMonth { get; set; }

        public int? ProjectId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string KeFuKhPhoneNumber { get; set; }

        [StringLength(50)]
        public string KhInCitySite { get; set; }

        public int? FuWuYueSaoID { get; set; }

        [StringLength(50)]
        public string FuWuYueSaoName { get; set; }

        public DateTime? KhPsdXiuGaiDateTime { get; set; }

        [StringLength(50)]
        public string KhClassName { get; set; }

        [StringLength(50)]
        public string KhCallClassName { get; set; }

        public DateTime? KhCallDateTime { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal XiaoFeiKaMoney { get; set; }

        [StringLength(300)]
        public string JDZhiFuToken { get; set; }

        public int? xixiVIP { get; set; }

        public int? huisuoID { get; set; }

        public int? KhJiFen { get; set; }
    }
}

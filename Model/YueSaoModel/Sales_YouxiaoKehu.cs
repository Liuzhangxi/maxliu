namespace OUDAL.Model.YueSaoModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales_YouxiaoKehu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kHID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SalesName { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime optDateTime { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesID { get; set; }
    }
}

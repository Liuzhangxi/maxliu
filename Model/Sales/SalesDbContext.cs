//namespace OUDAL.Model.Sales
//{
//    using System;
//    using System.Data.Entity;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Linq;

//    public partial class SalesDbContext : DbContext
//    {
//        public SalesDbContext()
//            : base("name=YZHSERP")
//        {
//        }

//        public virtual DbSet<salesDept> salesDept { get; set; }
//        public virtual DbSet<SalesKeHuFangWen> SalesKeHuFangWen { get; set; }
//        public virtual DbSet<SalesKeHuGenZhong> SalesKeHuGenZhong { get; set; }
//        public virtual DbSet<SalesTable> SalesTable { get; set; }
//        public virtual DbSet<yixiangKehu> yixiangKehu { get; set; }


//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//        }
//    }
//}

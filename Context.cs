
using OUDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using OUDAL.Model.Sales;
using OUDAL.Model.YueSaoModel;
using OUDAL.ModelBase;
using OUDAL.Model;

namespace OUDAL
{//this is notebook v1.0
    //desktop 1.1
    public class Context : DbContext
    {
        public Context()
            : base(DBConst.YZHSErpConnectString)
        {
            ///防止用本类更新数据库
            Database.SetInitializer<Context>(null);

#if DEBUG
            Database.Log = log => System.Diagnostics.Debug.WriteLine(log);
#endif
        } 
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentUser> DepartmentUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<RoleFunction> RoleFunctions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<DictionaryItem> DictionaryItems { get; set; }
        public DbSet<AccessLogs> AccessLogs { get; set; }
        public DbSet<SysCode> SysCode { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<JiaMengShangInfo> JiaMengShangInfo { get; set; }
        public DbSet<JMSLXR> JMSLXR { get; set; }

        public DbSet<JMSGengZong> JMSGengZong { get; set; }

        public DbSet<JMSJieDianModel> JMSJieDianModel { get; set; }
        public DbSet<JMSJieDianClassModel> JMSJieDianClassModel { get; set; }
        public DbSet<JMSJieDianMXModel> JMSJieDianMXModel { get; set; }

        public DbSet<JMSJieDianObj> JMSJieDianObj { get; set; }
        public DbSet<JMSJieDianClassObj> JMSJieDianClassObj { get; set; }
        public DbSet<JMSJieDianMXObj> JMSJieDianMXObj { get; set; }

        public DbSet<KeHu> KeHu { get; set; }

        public DbSet<KhHeTong> KhHeTong { get; set; }

        public DbSet<DDShouKuan> DDShouKuan { get; set; }
        public DbSet<JieDianGengZong> JieDianGengZong { get; set; }
        public DbSet<JmsDirectory> JmsDirectory { get; set; }
        public DbSet<JmsFile> JmsFile { get; set; }
        public DbSet<FloorInfo> FloorInfo { get; set; }
        public DbSet<RoomCheckIn> RoomCheckIn { get; set; }
        public DbSet<RoomInfo> RoomInfo { get; set; }

        public DbSet<GuYuanDepartment> GuYuanDepartment { get; set; }
        public DbSet<GuYuanGroup> GuYuanGroup { get; set; }
        public DbSet<GuYuanUser> GuYuanUser { get; set; }
        public DbSet<Caipu> Caipu { get; set; }
        public DbSet<DietSpecial> DietSpecial { get; set; }
        public DbSet<KeRenPeiCan> KeRenPeiCan { get; set; }
        public DbSet<DietDayNote> DietDayNote { get; set; }

        public DbSet<JMSShouKuan> JMSShouKuan { get; set; }
        public DbSet<JMSShouKuanRule> JMSShouKuanRule { get; set; }
        public DbSet<SmsLog> SmsLog { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<TrainingRecord> TrainingRecord { get; set; }
        public DbSet<PingXiangInfo> PingXiangInfo { get; set; }
        public DbSet<CustomerPingXiang> CustomerPingXiang { get; set; }
        public DbSet<CaipuModel> CaipuModel { get; set; }
        public DbSet<CaipuModelType> CaipuModelType { get; set; }
        public DbSet<PaiBan> PaiBan { get; set; }
        public DbSet<PaiBanType> PaiBanType { get; set; }
        public DbSet<DayType> DayType { get; set; }
        public DbSet<HuLiRegist> HuLiRegist { get; set; }
        public DbSet<ChildCareDetail> ChildCareDetail { get; set; }
        public DbSet<ChildCareMain> ChildCareMain { get; set; }
        public DbSet<HuoPing> HuoPing { get; set; }
        public DbSet<HuoPingOut> HuoPingOut { get; set; }
        public DbSet<HuoPingShenQing> HuoPingShenQing { get; set; }

        public DbSet<SalesTable> SalesTable { get; set; }
        //public virtual DbSet<salesDept> salesDept { get; set; }
        public DbSet<guDingZiChan> guDingZiChan { get; set; }
        public DbSet<guDingZiChanMX> guDingZiChanMX { get; set; }
        public virtual DbSet<SalesKeHuFangWen> SalesKeHuFangWen { get; set; }
        public virtual DbSet<SalesKeHuGenZhong> SalesKeHuGenZhong { get; set; }

        public virtual DbSet<yixiangKehuView> yixiangKehu { get; set; }

        public virtual DbSet<youxiaokehu> youxiaokehu { get; set; }

        public virtual DbSet<Sales_YouxiaoKehu> Sales_YouxiaoKehu { get; set; }

        public virtual DbSet<YiHaoPing> YiHaoPing { get; set; }

        public virtual DbSet<HuoPingCaiGou> HuoPingCaiGou { get; set; }

        public virtual DbSet<HuoPingPanKu> HuoPingPanKu { get; set; }

        public virtual DbSet<HuoPingRuku> HuoPingRuku { get; set; }
        public virtual DbSet<yixiangKehuXiXi> yixiangKehuXiXi { get; set; }
        public virtual DbSet<HuoPingCaiGouDan> HuoPingCaiGouDan { get; set; }

        public virtual DbSet<HuoPingBuMenKuCun> HuoPingBuMenKuCun { get; set; }
        public virtual DbSet<KeMu> KeMu { get; set; } 
        public virtual DbSet<HeTongService> HeTongService { get; set; }

        public virtual DbSet<HuoPingRukuDan> HuoPingRukuDan { get; set; }

        public virtual DbSet<KeHuJieDianClassModel> KeHuJieDianClassModel { get; set; }
        public virtual DbSet<KeHuJieDianClassObj> KeHuJieDianClassObj { get; set; }
        public virtual DbSet<KeHuJieDianModel> KeHuJieDianModel { get; set; }
        public virtual DbSet<KeHuJieDianObj> KeHuJieDianObj { get; set; }
        public virtual DbSet<HeTongServiceModel> HeTongServiceModel { get; set; } 
        public virtual DbSet<DingTalkUser> DingTalkUser { get; set; }
        public DbSet<MenDianFee> MenDianFee { get; set; }
        public virtual DbSet<DingTalkKaoQin> DingTalkKaoQin { get; set; }
        public virtual DbSet<GuYuanKaoQin> GuYuanKaoQin { get; set; }

        public DbSet<ServiceReport> ServiceReport { get; set; }
        public DbSet<CaiJinInfo> CaiJinInfo { get; set; }
        public DbSet<CanOtherInfo> CanOtherInfo { get; set; }
         
        public DbSet<JiaoGeFee> JiaoGeFee { get; set; }
 
        public DbSet<MenDianZhiBiao> MenDianZhiBiao { get; set; }
 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentUser>().HasKey(p => new { p.UserId, p.DepartmentId });
            modelBuilder.Entity<RoleUser>().HasKey(p => new { p.UserId, p.RoleId });
            modelBuilder.Entity<RoleFunction>().HasKey(p => new { p.RoleId, p.FunctionId }); 

            base.OnModelCreating(modelBuilder);
        } 

    }
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>//DropCreateDatabaseAlways<Context>// 
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
            Seeding.Seed(context);
        }
    }

    public class Initializer : IDatabaseInitializer<Context>
    {


        public void InitializeDatabase(Context context)
        {
            if (System.Diagnostics.Debugger.IsAttached && context.Database.Exists())
            //&& !context.Database.CompatibleWithModel(false))
            {
                context.Database.Delete();
            }

            if (!context.Database.Exists())
            {
                context.Database.Create();
                Seeding.Seed(context);

                var contextObject = context as System.Object;
                var contextType = contextObject.GetType();
                var properties = contextType.GetProperties();
                System.Type t = null;
                string tableName = null;
                string fieldName = null;
                foreach (var pi in properties)
                {
                    if (pi.PropertyType.IsGenericType && pi.PropertyType.Name.Contains("DbSet"))
                    {
                        t = pi.PropertyType.GetGenericArguments()[0];

                        var mytableName = t.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                        if (mytableName.Length > 0)
                        {
                            DisplayNameAttribute mytable = mytableName[0] as DisplayNameAttribute;
                            // tableName = mytable.Name;
                        }
                        else
                        {
                            tableName = pi.Name;

                            // EXECUTE   sp_addextendedproperty   N'MS_Description',   '销售套餐1',   N'user',   N'dbo',   N'table',   N'SalePackages' 

                        }

                        FieldInfo tableNameField = t.GetField("LogClass");
                        string descTable = tableName;

                        if (tableNameField != null)
                        {
                            descTable = tableNameField.GetValue(t) + "";
                        }
                        ///0 tablename
                        string dropTableDesc = "  EXEC   sp_dropextendedproperty   'MS_Description','user',dbo,'table','{0}' ";
                        ///0 tabledesc,1 tablename
                        string addTableDesc = " EXECUTE   sp_addextendedproperty   N'MS_Description',   '{0}',   N'user',   N'dbo',   N'table',   N'{1}'";
                        try
                        {
                            context.Database.ExecuteSqlCommand(string.Format(dropTableDesc, tableName));
                        }
                        catch { }
                        try
                        {
                            context.Database.ExecuteSqlCommand(string.Format(addTableDesc, descTable, tableName));
                        }
                        catch { }
                        // string descTableName = pi.get
                        // t.GetProperty("LogClass");
                        foreach (var piEntity in t.GetProperties())
                        {
                            if (piEntity.GetCustomAttributes(typeof(DisplayNameAttribute), true).Length > 0)
                            {
                                fieldName = piEntity.Name;
                                //EXEC sp_dropextendedproperty 'MS_Description','user',dbo,'table','Clients','column',N'SalesId';
                                //EXEC sp_addextendedproperty N'MS_Description','自动编号1',N'user',N'dbo',N'table',N'Clients',N'column',N'SalesId'

                                //说明文字先后顺序，先description -> displayname
                                string desc = ((DisplayNameAttribute)piEntity.GetCustomAttributes(typeof(DisplayNameAttribute), true)[0]).DisplayName;

                                if (piEntity.GetCustomAttributes(typeof(DescriptionAttribute), true).Length > 0)
                                {
                                    desc = ((DescriptionAttribute)piEntity.GetCustomAttributes(typeof(DescriptionAttribute), true)[0]).Description;
                                }




                                //0 tablename,1 columnname,2 desc
                                string dropdesc = string.Format("EXEC sp_dropextendedproperty 'MS_Description','user',dbo,'table','{0}','column',N'{1}'", tableName, fieldName);
                                string createdesc = string.Format("EXEC sp_addextendedproperty N'MS_Description','{2}',N'user',N'dbo',N'table',N'{0}',N'column',N'{1}'", tableName, fieldName, desc);
                                try
                                {
                                    context.Database.ExecuteSqlCommand(dropdesc);
                                }
                                catch { }
                                try
                                {
                                    context.Database.ExecuteSqlCommand(createdesc);
                                }
                                catch { }
                            }
                        }
                    }
                }
            }
        }
    }

    public class ContextDropDBInitializer : DropCreateDatabaseAlways<Context>// 
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
            Seeding.Seed(context);
        }




    }
    public class Seeding
    {
        public static void Seed(Context context)
        {
            try
            {
                InitFunctions(context);


                //List<SalePackage> salePackages = new List<SalePackage>
                //                                   {
                //                                       new SalePackage {Name = "套餐A", ProjectId = 3, Remark = "Remark公司",OrderMoney = 10000},
                //                                       new SalePackage {Name = "套餐B", ProjectId = 3, Remark = "Remark部门",OrderMoney = 20000},
                //                                       new SalePackage {Name = "套餐C", ProjectId = 3, Remark = "Remark项目",OrderMoney = 30000},
                //                                       new SalePackage {Name = "套餐甲", ProjectId = 4, Remark = "Remark项目",OrderMoney = 10000}
                //                                   };
                //salePackages.ForEach(o => context.SalePackages.Add(o));
                //context.SaveChanges();

                List<Department> departments = new List<Department>
                                                   {
                                                       new Department {Name = "集团", PId = 0, DepartmentType = "公司"},
                                                       new Department {Name = "营销部", PId = 1, DepartmentType = "部门"},
                                                       new Department {Name = "北京项目", PId = 1, DepartmentType = "项目"},
                                                       new Department {Name = "上海项目", PId = 1, DepartmentType = "项目"}
                                                   };
                departments.ForEach(o => context.Departments.Add(o));
                context.SaveChanges();



                List<SystemUser> users = new List<SystemUser>
                                             {
                                                 new SystemUser
                                                     {LoginName = "Admin", Password = "11", State = 0, Name = "管理员"},
                                                 new SystemUser {LoginName="lihui",Name="李慧",Password="11"},
                                                 new SystemUser {LoginName="zyw",Name="张毅维",Password="11"}
                                             };
                users.ForEach(o =>
                              {
                                  SystemUser user = new SystemUser();
                                  user.Save(context, o);
                              });
                context.SaveChanges();
                context.RoleUsers.Add(new RoleUser { RoleId = 1, UserId = 1 });
                context.RoleUsers.Add(new RoleUser { RoleId = 2, UserId = 2 });
                context.RoleUsers.Add(new RoleUser { RoleId = 3, UserId = 3 });
                context.DepartmentUsers.Add(new DepartmentUser
                {
                    UserId = 1,
                    DepartmentId = 2
                });
                context.DepartmentUsers.Add(new DepartmentUser
                {
                    UserId = 1,
                    DepartmentId = 3
                });
                context.DepartmentUsers.Add(new DepartmentUser
                {
                    UserId = 2,
                    DepartmentId = 3
                });
                context.DepartmentUsers.Add(new DepartmentUser
                {
                    UserId = 3,
                    DepartmentId = 3
                });
                context.SaveChanges();

                List<OUDAL.Dictionary> dictionaries = new List<Dictionary>
                {
                    new Dictionary {Catalog = "加盟商", Name = "加盟商状态"},
                    new Dictionary {Catalog = "加盟商", Name = "渠道来源"},
                    new Dictionary {Catalog = "加盟商", Name = "股东构成"},
                    new Dictionary {Catalog = "加盟商", Name = "加盟意向"},
                    new Dictionary {Catalog = "加盟商", Name = "物业类型"},
                    new Dictionary {Catalog = "加盟商", Name = "城市区域"},
                    new Dictionary {Catalog = "加盟商", Name = "资金预算"},
                    new Dictionary {Catalog = "加盟商", Name = "合作模式"},
                    new Dictionary {Catalog = "加盟商", Name = "加盟地消费力"},
                    new Dictionary {Catalog = "加盟商", Name = "加盟地先有月子会所数量"},
                    new Dictionary {Catalog = "加盟商", Name = "加盟地月子会所均价"},
                    new Dictionary {Catalog = "加盟商", Name = "加盟商拥有的资源"},
                    new Dictionary {Catalog = "加盟商", Name = "是否参观过喜喜"},

                };
                dictionaries.ForEach(o => context.Dictionaries.Add(o));
                context.SaveChanges();
                
                foreach (var dictionary in dictionaries)
                {
                    var index = 0;
                    if (dictionary.Name == "加盟商状态")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "重点关注" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "持续跟踪" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "无效客户" });
                    }
                    if (dictionary.Name == "渠道来源")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "商务通" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "百度" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "点评" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "朋友介绍" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "全球加盟网" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "其他" }); 
                    }
                    if (dictionary.Name == "股东构成")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "公司投资" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "个人投资" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "合伙投资" });
                       
                    }
                    if (dictionary.Name == "加盟意向")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "初步了解" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "项目确定寻找物业中" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "已筹建确定加盟品牌类型" });
                  
                    }
                    if(dictionary.Name== "物业类型")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "酒店及酒店式公寓" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "商铺商务楼" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "独栋物业" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "其他" });
                    }
                    if (dictionary.Name == "城市区域")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "中心地带" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "中间地带" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "边缘地带" }); 
                    }
                    if (dictionary.Name == "资金预算")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "100-300万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "300-500万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "500-1000万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "1000万以上" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "根据需要再决定" });
                    }
                    if (dictionary.Name == "合作模式")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "技术支持自创品牌" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "品牌加盟自建团队管理" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "品牌委托加盟委托管理" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "合作经营" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 5, Name = "希望被收购" });
                    }
                    if (dictionary.Name == "加盟地消费力")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "很低" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "低" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "一般" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "高" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 5, Name = "很高" });
                    }
                    if (dictionary.Name == "加盟地先有月子会所数量")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "无" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "1-5" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "6-10" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "11-20" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 5, Name = "21-30" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 6, Name = "30以上" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 7, Name = "不清楚" });
                    }
                    if (dictionary.Name == "加盟地月子会所均价")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "2万以下" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "2-3万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "3-4万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "4-5万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 5, Name = "5-8万" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 6, Name = "8万以上" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 7, Name = "目前无会所" });
                    }
                    if (dictionary.Name == "加盟商拥有的资源")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "物业" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "医疗" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "供应商" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "政府" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 5, Name = "其他" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 6, Name = "无任何资源" });
                    }
                    if (dictionary.Name == "是否参观过喜喜")
                    {
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 1, Name = "无" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 2, Name = "来上海参观过" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 3, Name = "外地门店参观过" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 4, Name = "上海和外地都参观过" });
                        context.DictionaryItems.Add(new DictionaryItem { DictId = dictionary.Id, IndexNum = 5, Name = "已付当地考察" });
                    }
                }
                context.SaveChanges();
                Client c1 = new Client
                {
                    AllName = "张三",
                    AllPhone = "13912341234 80012345",
                    CreateTime = DateTime.Now
                    ,
                    Intent = ClientIntentEnum.一般,
                    ProjectId = 3,
                    SalesId = 3,
                    State = ClientStateEnum.来电,
                    StateDate = DateTime.Today
                };

                Client c2 = new Client
                {
                    AllName = "李四",
                    AllPhone = "13911111111 80012345",
                    CreateTime = DateTime.Now.Subtract(new TimeSpan(360, 0, 0, 0))
                    ,
                    Intent = ClientIntentEnum.一般,
                    ProjectId = 3,
                    SalesId = 3,
                    State = ClientStateEnum.成交,
                    StateDate = DateTime.Today.Subtract(new TimeSpan(360,0,0,0))
                };
                context.Clients.Add(c1);
                context.Clients.Add(c2);
                context.SaveChanges();
                //ClientContact cc1 = new ClientContact
                //{
                //    ClientId = c1.Id,
                //    ContactType = ContactTypeEnum.子女,
                //    Name = "张三",
                //    Mobile = "13912341234",
                //    Phone = "80012345",
                //    Gender = "男"
                //};
                //context.ClientContacts.Add(cc1);
                //ClientContactRecord cr1 = new ClientContactRecord
                //{
                //    ClientId = c1.Id,
                //    ActualTime = DateTime.Now,
                //    FirstType = 1,
                //    Person = 1,
                //    Type = "来电"
                //};
                //context.ClientContactRecords.Add(cr1);
                //context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                var i = dbEx;
                throw (dbEx);
            }

        }

        public static void InitFunctions(Context context)
        {
            List<Function> funlist = new List<Function>
            {
                new Function {Name = "系统管理", ParentName = "-", Sort = 100},
                new Function {Name = "部门管理", ParentName = "系统管理", Sort = 0},
                new Function {Name = "用户管理", ParentName = "系统管理", Sort = 0},
                new Function {Name = "角色管理", ParentName = "系统管理", Sort = 0},
                new Function {Name = "数据字典", ParentName = "系统管理", Sort = 0},
                new Function {Name = "参数配置", ParentName = "系统管理", Sort = 0},
                new Function {Name = "项目管理", ParentName = "-", Sort = 1},
                new Function {Name = "项目信息查看", ParentName = "项目管理", Sort = 1},
                new Function {Name = "项目信息编辑", ParentName = "项目管理", Sort = 2},
                new Function {Name = "数据字典", ParentName = "项目管理", Sort = 3},
                new Function {Name = "加盟商管理", ParentName = "-", Sort = 3},
                new Function {Name = "加盟商信息表", ParentName = "加盟商管理", Sort = 0},
                new Function {Name = "联系人列表", ParentName = "加盟商管理", Sort = 0},
                new Function {Name = "跟踪记录表", ParentName = "加盟商管理", Sort = 0},

                //new Function {Name = "销售员", ParentName = "加盟商管理", Sort = 0},
                //new Function {Name = "客户查询", ParentName = "加盟商管理", Sort = 0},
                //new Function {Name = "客户编辑", ParentName = "加盟商管理", Sort = 0},
                //new Function {Name = "客户删除", ParentName = "加盟商管理", Sort = 0},
                //new Function {Name = "客户邀约查询", ParentName = "加盟商管理", Sort = 0},
                //new Function {Name = "客户分配", ParentName = "加盟商管理", Sort = 0}, 
                
                new Function {Name = "销售管理", ParentName = "-", Sort = 2000},
                new Function {Name = "销售套餐查看", ParentName = "销售管理", Sort = 0},
                new Function {Name = "销售套餐编辑", ParentName = "销售管理", Sort = 0},
                new Function {Name = "订单查询", ParentName = "销售管理", Sort = 0},
                new Function {Name = "订单编辑", ParentName = "销售管理", Sort = 0},
                new Function {Name = "订单删除", ParentName = "销售管理", Sort = 0},
                new Function {Name = "订金查询", ParentName = "销售管理", Sort = 0},
                new Function {Name = "订金收款", ParentName = "销售管理", Sort = 0},
                new Function {Name = "项目报表", ParentName = "-", Sort = 2000},
            };
            funlist.ForEach(o => context.Functions.Add(o));

            context.SaveChanges();
            List<Role> roles = new List<Role>
            {
                new Role {Name = "系统管理员"},
                new Role {Name = "项目经理"},
                new Role {Name = "项目助理"},
                new Role {Name = "销售员"}
            };
            roles.ForEach(o =>
            {
                context.Roles.Add(o);
                context.SaveChanges();
                funlist.ForEach(
                    p =>
                    {
                        if (o.Id == 1 || o.Id == 2 || o.Id == 3)
                        {
                            context.RoleFunctions.Add(new RoleFunction
                            {
                                RoleId = o.Id,
                                FunctionId = p.Id
                            });
                        }
                    });
            });
            context.SaveChanges();
        }
    } 
}
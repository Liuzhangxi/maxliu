 
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

namespace OUDAL
{//this is notebook v1.0
    //desktop 1.1
    public class YueSaoErpContext : DbContext
    {
        public YueSaoErpContext()
            : base(DBConst.YueSaoErpConnectString)
        {
            Database.SetInitializer<YueSaoErpContext>(null);
        }
        public DbSet<DingDan> DingDan { get; set; }
         
        public DbSet<sao1saoyuezihuiSuoInfo> yuezihuiSuoInfo { get; set; }

        //public DbSet<yssalesDept> salesDept { get; set; }
        public DbSet<Seskehu> Seskehu { get; set; }
        //public DbSet<SystemUser> SystemUsers { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<DepartmentUser> DepartmentUsers { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<RoleUser> RoleUsers { get; set; }
        //public DbSet<Function> Functions { get; set; }
        //public DbSet<RoleFunction> RoleFunctions { get; set; }
        //public DbSet<Company> Companies { get; set; }
        //public DbSet<Dictionary> Dictionaries { get; set; }
        //public DbSet<DictionaryItem> DictionaryItems { get; set; }
        //public DbSet<AccessLogs> AccessLogs { get; set; }
        //public DbSet<SysCode> SysCode { get; set; }
        //public DbSet<Attachment> Attachments { get; set; }
        //public DbSet<Client> Clients { get; set; }  

    } 
}
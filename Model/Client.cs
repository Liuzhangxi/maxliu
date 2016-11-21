using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OUDAL
{
    public enum ClientIntentEnum { 无意向, 弱, 一般, 较强, 强, 已成交 }
    public enum ClientStateEnum { 来电, 来访, 成交 }
    public enum ClientViewScopeEnum { 无, 查看本组, 查看项目, 查看所有 }
    public class Client
    {
        public static string LogClass = "客户";

        [DisplayName("年龄")]
        [NotMapped]
        public int? Age
        {
            get
            {
                if (BirthDay != null)
                    return DateTime.Now.Year - BirthDay.Value.Year;
                return null;
            }
        }
        [Key]
        public int Id { get; set; }
        [Description("项目_updatehidden")]
        [DisplayName("项目")]
        public int ProjectId { get; set; }

        [DisplayName("客户经理")]
        public int SalesId { get; set; }


        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("介绍人")]
        public string Agent { get; set; }


        [DisplayName("出生日期")]
        public DateTime? BirthDay { get; set; }
        [DisplayName("问卷填写日期")]
        public DateTime CreateTime { get; set; }
        [DisplayName("客户意向")]
        public ClientIntentEnum Intent { get; set; }
        [DisplayName("客户状态")]
        public ClientStateEnum State { get; set; }

        [DisplayName("当期状态开始日期")]
        public DateTime StateDate { get; set; }

        //保存电话及联系人时候，重新更新这个字段，将所有电话包含进来
        //保存电话及联系人时候，重新更新这个字段，将所有电话包含进来
        [DisplayName("手机")]
        public string AllPhone { get; set; }
        [DisplayName("客户名")]
        public string AllName { get; set; }
        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("区域")]
        public string Area { get; set; }
        [DisplayName("职业")]
        public string Career { get; set; }

        [DisplayName("性别")]
        public string Gender { get; set; }
        [DisplayName("预约时间段(启)")]
        public DateTime? AppointmentDatePre { get; set; }
        [DisplayName("预约时间段(止)")]
        public DateTime? AppointmentDateAfter { get; set; }

        [DisplayName("预约时间")]
        public DateTime? AppointmentDate { get; set; }

        [DisplayName("来访确认")]
        public string ContactType { get; set; }
        [DisplayName("预约时间段")]
        public string AppointmentTimeSpan { get; set; }
        /// <summary>
        /// 这里将相关联系人信息更新到 allphone ,allname字段
        /// </summary>
        /// <param name="db"></param>
        public void UpdateClient(Context db)
        { 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
 
    }

    public class ClientSelect
    {
        public static string LogClass = "客户";
        [DisplayName("预约次数")]
        public int Appointtimes { get; set; }
        [DisplayName("来访次数")]
        public int Cometimes { get; set; }
        [Key]
        public int Id { get; set; }
        [Description("项目_updatehidden")]
        [DisplayName("项目")]
        public int ProjectId { get; set; }

        [DisplayName("客户经理")]
        public int SalesId { get; set; }


        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("介绍人")]
        public string Agent { get; set; }

        [DisplayName("问卷填写日期")]
        public DateTime CreateTime { get; set; }
        [DisplayName("客户意向")]
        public ClientIntentEnum Intent { get; set; }
        [DisplayName("客户状态")]
        public ClientStateEnum State { get; set; }

        [DisplayName("当期状态开始日期")]
        public DateTime StateDate { get; set; }

        //保存电话及联系人时候，重新更新这个字段，将所有电话包含进来
        //保存电话及联系人时候，重新更新这个字段，将所有电话包含进来
        [DisplayName("手机")]
        public string AllPhone { get; set; }
        [DisplayName("客户名")]
        public string AllName { get; set; }
        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("区域")]
        public string Area { get; set; }
        [DisplayName("职业")]
        public string Career { get; set; }

        [DisplayName("性别")]
        public string Gender { get; set; }
        [DisplayName("预约时间段(启)")]
        public DateTime? AppointmentDatePre { get; set; }
        [DisplayName("预约时间段(止)")]
        public DateTime? AppointmentDateAfter { get; set; }

        [DisplayName("预约时间")]
        public DateTime? AppointmentDate { get; set; }

        [DisplayName("来访确认")]
        public string ContactType { get; set; }
        [DisplayName("预约时间段")]
        public string AppointmentTimeSpan { get; set; }
 
       
    }
    //ToDo:这里需要重新定义
    public class ClientListModel
    {
        public static string sql =
               @"select  c.*,u.name as sales from Clients c join systemusers u  on c.salesid=u.id where 1=1";
        public static string stategroupsql = @"select  COUNT(*) as Num ,c.[State] from Clients c join systemusers u  on c.salesid=u.id where 1=1 {0} group by c.[State]";

        /// <summary>
        /// 0 condition
        /// </summary>
        public static string salegroupsql = @"select COUNT(*) as Num ,c.[State],u.id as Saleid ,u.Name as SalerName from Clients c join systemusers u 
 on c.salesid=u.id where 1=1  {0} 
 group by c.[State],u.Id,u.Name order by u.Id
";


        public int Id { get; set; }

        public string AllName { get; set; }
        public string AllPhone { get; set; }
        public ClientIntentEnum Intent { get; set; }
        public ClientStateEnum State { get; set; }
        public string Sales { get; set; }
        public int Num { get; set; }
        public int Saleid { get; set; }
        public string SalerName { get; set; }
    }

    public class ClientReportModel
    {
        public string Name { get; set; }
        //public string 
    }





}
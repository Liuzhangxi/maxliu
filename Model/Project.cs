using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OUDAL
{
   
    public class Project
    {
        public static string LogClass = "项目";
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentId { get; set; }

        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("详细信息")]
        public string Remark { get; set; }
        [DisplayName("开售日期")]
        public DateTime? SaleBeginDate { get; set; }
        [DisplayName("预计入住日期")]
        public DateTime? CheckinBeginDate { get; set; }



    }

}

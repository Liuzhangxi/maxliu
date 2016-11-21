using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OUDAL
{
    public class Department
    {
        [NotMapped]
        public List<JiaoGeFee> JiaoGeInfo { get; set; }

        public decimal JiaoGeJin
        {
            get
            {
                if (JiaoGeInfo == null || JiaoGeInfo.Count == 0) return 0;
                decimal temp=0;
                JiaoGeInfo.ForEach(j =>
                {
                    j.DdShouKuans.ForEach(s =>
                    {
                        temp += s.SKMoney;
                    });
                    temp += j.BeiYongMoney ?? 0;
                });
                return temp;
            }
        }
        public int Id { get; set; }
        [Required]
        public int PId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("名称")]
        public string Name { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName("类别")]
        [MaxLength(50)]
        public string DepartmentType { get; set; }

        [DisplayName("区域")]
        [MaxLength(150)]
        public string Area { get; set; }

        [DisplayName("电话")]
        [MaxLength(50)]
        public string Tel { get; set; }
         
        [MaxLength(50)]
        public string State { get; set; }

        [DisplayName("物业类型")]
        public string WuYeClass { get; set; }
        
        public Department()
        {
            DepartmentType = "";
        }

        public static string LogClass = "Departments";

        [DisplayName("站点公司")]
        [NotMapped]
        public string Name1
        {
            get { return Name; }
            set {; }
        }

        [DisplayName("所属分公司")]
        [NotMapped]
        public string Name2
        {
            get { return Name; }
            set {; }
        }


    }
    
}

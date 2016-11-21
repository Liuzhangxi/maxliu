using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL
{
    public enum ContactTypeEnum { 子女,亲属,老人}
    /// <summary>
    /// 客户联系人 
    /// </summary>
    public class ClientContact
    {
        public static string LogClass = "客户联系人";
        [Key] 
        public int Id { get; set; }
        public int ClientId { get; set; }
        [DisplayName("默认联系人")]
        public bool IsDefault { get; set; }
        [DisplayName("类型")]
        public ContactTypeEnum ContactType { get; set; }
        [Required]
        [DisplayName("姓名")]
        public string Name { get; set; }
        [DisplayName("性别")]
        public string Gender { get; set; }
        [Required]
        [DisplayName("手机")]
        public string Mobile { get; set; }
        [DisplayName("电话")]
        public string Phone { get; set; }
        [DisplayName("联系地址")]
        public string Address { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("生日")]
        public string Birthday { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OUDAL
{
    [Table("DingTalkUser")]
    public class DingTalkUser
    {
        public static string LogClass = "钉钉员工表";

        public int id { get; set; }

        /// <summary>
        /// 员工唯一标识ID（不可修改）
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 成员名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// [详情]钉钉ID
        /// </summary>
        public string dingId { get; set; }

        /// <summary>
        /// [详情]	手机号（ISV不可见）
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// [详情]分机号（ISV不可见）
        /// </summary>
        public string tel { get; set; }

        /// <summary>
        /// [详情]	办公地点（ISV不可见）
        /// </summary>
        public string workPlace { get; set; }

        /// <summary>
        /// [详情]	备注（ISV不可见）
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// [详情]是否是企业的管理员, true表示是, false表示不是
        /// </summary>
        public bool isAdmin { get; set; }

        /// <summary>
        /// [详情]	是否为企业的老板, true表示是, false表示不是
        /// </summary>
        public bool isBoss { get; set; }

        /// <summary>
        /// [详情]是否是部门的主管, true表示是, false表示不是
        /// </summary>
        public bool isLeader { get; set; }

        /// <summary>
        /// [详情]表示该用户是否激活了钉钉
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        /// [详情]成员所属部门id列表
        /// </summary>
        public List<long> department { get; set; }

        /// <summary>
        /// [详情]职位信息
        /// </summary> 
        public string position { get; set; }

        /// <summary>
        /// [详情]员工的邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// [详情]员工的企业邮箱
        /// </summary>
        public string orgEmail { get; set; }

        /// <summary>
        /// [详情]	员工工号
        /// </summary>
        public string jobnumber { get; set; }

        public Guid Guid { get; set; }
    }
}

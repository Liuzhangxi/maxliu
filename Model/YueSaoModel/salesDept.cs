using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OUDAL.ModelBase;

namespace OUDAL
{
    public partial class SearchDingDanReq : BaseSearchReq
    {
        public string depname { get; set; }
        public string fwDateStart { get; set; }
        public string fwDateEnd { get; set; } 
    }

   [Table("salesDept")]
    [Serializable]
    public partial class yssalesDept
    {

        public static string LogClass = "salesDept";
        #region -  公共属性  ------------------------------------------------------------
        [NotMapped]
        public string cityName { get; set; }

        [NotMapped]
        public string Name { get; set; }

        [DisplayName("状态")]
        [NotMapped]
        public string deptStateIDDesc
        {
            get
            {
                switch (deptStateID)
                {
                    case 2:
                        return "无效";
                    default: return "有效";
                }
            }
        }

        /// <summary>
        /// seed
        /// </summary>
        private int _id;
        /// <summary>
        /// seed
        /// </summary>
        [Key]
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }





        /// <summary>
        /// 部门名称
        /// </summary>
        private string _DeptName = "";
        /// <summary>
        /// 部门名称
        /// </summary>
        [DisplayName("部门名称")]
        [Required]
        public string DeptName
        {
            set { _DeptName = value; }
            get { return _DeptName; }
        }





        /// <summary>
        /// 分公司ID
        /// </summary>
        private int _projectID;
        /// <summary>
        /// 分公司ID
        /// </summary>
        [DisplayName("分公司ID")]
        public int projectID
        {
            set { _projectID = value; }
            get { return _projectID; }
        }





        /// <summary>
        /// 城市站点ID
        /// </summary>
        private int _cityID;
        /// <summary>
        /// 城市站点ID
        /// </summary>
        [DisplayName("城市站点ID")]
        public int cityID
        {
            set { _cityID = value; }
            get { return _cityID; }
        }





        /// <summary>
        /// 部门状态，1有效 2无效
        /// </summary>
        private int _deptStateID;
        /// <summary>
        /// 部门状态，1有效 2无效
        /// </summary>
        [DisplayName("部门状态")]
        public int deptStateID
        {
            set { _deptStateID = value; }
            get { return _deptStateID; }
        }





        /// <summary>
        /// 操作人
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("操作人")]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }





        /// <summary>
        /// 操作时间
        /// </summary>
        private DateTime _optDateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间
        /// </summary>
        [DisplayName("操作时间")]
        public DateTime optDateTime
        {
            set { _optDateTime = value; }
            get { return _optDateTime; }
        }

        private DateTime _optDateTimeStart = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeStart
        {
            set { _optDateTimeStart = value; }
            get { return _optDateTimeStart; }
        }
        private DateTime _optDateTimeEnd = SqlDateTime.MinValue.Value;
        [NotMapped]
        public DateTime optDateTimeEnd
        {
            set { _optDateTimeEnd = value; }
            get { return _optDateTimeEnd; }
        }







        #endregion ----------------------------------------------------------------------
    }
}

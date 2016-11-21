using System.ComponentModel;
using System.Data.SqlTypes;
using OUDAL.ModelBase;

namespace OUDAL.Model.Sales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yuezihuiSuoInfo")]
    [Serializable]
    public partial class yuezihuiSuoInfo
    {

        public static string LogClass = "会所信息";
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        [Key]

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }



        /// <summary>
        /// 会所名
        /// </summary>
        private string _huiSuoName = "";
        /// <summary>
        /// 会所名
        /// </summary>
        [DisplayName("会所名")]
        [Required]
        public string huiSuoName
        {
            set { _huiSuoName = value; }
            get { return _huiSuoName; }
        }

        [DisplayName("会所地址")]
        public string huiSuoAddress
        {
            get; set;
        }

        [DisplayName("所在城市")]
        public int? FuWuDianCity
        {
            get; set;
        }

        [DisplayName("所属项目公司")]
        public int? projectID
        {
            get; set;
        }

        [DisplayName("会所类型")]
        public string huiSuoType
        {
            get; set;
        }

        /// <summary>
        /// 会所状态
        /// </summary>
        private int _huiSuoStateID;
        /// <summary>
        /// 会所状态
        /// </summary>
        [DisplayName("会所状态")]
        [Required]
        public int huiSuoStateID
        {
            set { _huiSuoStateID = value; }
            get { return _huiSuoStateID; }
        }



        /// <summary>
        /// 操作员
        /// </summary>
        private string _optName = "";
        /// <summary>
        /// 操作员
        /// </summary>
        [DisplayName("操作员")]
        [Required]
        public string optName
        {
            set { _optName = value; }
            get { return _optName; }
        }



        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        private DateTime _optDateTime = SqlDateTime.MinValue.Value;
        /// <summary>
        /// 操作时间_createdate
        /// </summary>
        [DisplayName("操作时间")]
        [Required]
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


        [NotMapped]
        public string huiSuoStateName
        {

            get
            {
                if (huiSuoStateID == 1)
                    return "有效";
                else
                    return "无效";
            }
        }

        [NotMapped]
        public string cityName
        {
            get; set;
        }

        [NotMapped]
        public string Name
        {
            get; set;
        }

        #endregion ----------------------------------------------------------------------
    }

    public partial class yuezihuiSuoInfoReq : BaseSearchReq
    {
        #region -  公共属性  ------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        /// 会所名
        /// </summary> 
        public string huiSuoName { get; set; }


        public string huiSuoAddress
        {
            get; set;
        }

        public int? FuWuDianCity
        {
            get; set;
        }

        public string huiSuoType
        {
            get; set;
        }


        /// <summary>
        /// 会所状态
        /// </summary> 
        public int? huiSuoStateID { get; set; }


        /// <summary>
        /// 操作员
        /// </summary> 
        public string optName { get; set; }


        /// <summary>
        /// 操作时间_createdate
        /// </summary> 
        public DateTime? optDateTime { get; set; }

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

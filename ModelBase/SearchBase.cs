using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.ModelBase
{
    public class BaseSearchReq
    { 
        public string projectids { get; set; }
        /// <summary>
        /// 项目id
        /// </summary>
        public int? projectid { get; set; }

        /// <summary>
        /// 排序字段名称
        /// </summary>
        public string sidx { get; set; }

        /// <summary>
        /// 排序规则 asc or desc
        /// </summary>
        public string sord { get; set; }

        /// <summary>
        /// pageindex 页数
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// pagesize 行数
        /// </summary>
        public int rows { get; set; }
    }

    public class SearchListResult<T>
    {
        public object Sum { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
          public int records { get; set; }

        /// <summary>
        /// 信息列表
        /// </summary>
        public List<T> rows { get; set; } 
 
    }
}

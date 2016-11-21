using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUDAL.ModelBase
{
   public class BootTreeViewModel
    {
       public BootTreeViewModel()
       {
            state = new BootTreeViewState();
           
       }
        /// <summary>
        /// 加盟类型,权限相关
        /// </summary>
        public string JmsUploadClassState { get; set; }
      public string   text { get; set; }
        public string href { get; set; }
        public string tags { get; set; }

        public int fileid { get; set; }
        public int directoryId { get; set; }
        public string  Name { get; set; }

        /// <summary>
        /// 文件夹路径
        /// </summary>
        public string DirectoryPath { get; set; }
        public BootTreeViewState state { get; set; }
        public bool canclick { get; set; }

        /// <summary>
        /// true,false
        /// </summary>
        public bool isDirectory { get; set; }
        public List<BootTreeViewModel> nodes { get; set; }
    }

    public class BootTreeViewState
    {
        public bool @checked
        {
            get;set;
        }
        public bool enableChecked
        {
            get; set;
        }
        public bool disabled
        {
            get; set;
        }
    }
    
}

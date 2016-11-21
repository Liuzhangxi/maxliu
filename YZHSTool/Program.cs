using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SesTools;

namespace YZHSTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string configFileName = "log.log4net";
            System.IO.FileInfo f = new System.IO.FileInfo(configFileName);
            LogHelper.LogHelper.SetConfig(f, "");
            LogHelper.LogHelper.Info("App Start");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}

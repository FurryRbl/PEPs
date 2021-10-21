using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PEPs
{
    internal class InsFuni
    {
        public static  String InstallFlash()
        {
            Process exec = new Process();
            exec.StartInfo.FileName = "AdobeFlashPlayerActiveXforWindows10.bat";
            exec.Start();
            System.Threading.Thread.Sleep(30000); //进程延迟
            Process[] app = Process.GetProcessesByName("AdobeFlashPlayerActiveXforWindows10");
            if (app.Length > 0)
            {
                System.Threading.Thread.Sleep(100000); //进程延迟
                Process[] apps = Process.GetProcessesByName("AdobeFlashPlayerActiveXforWindows10");
                if (app.Length > 0)
                {
                    MessageBox.Show("安装Flash异常");
                }
            };
            return null;
        }
    }
}

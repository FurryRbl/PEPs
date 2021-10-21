using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static PEPs.InsFuni;

namespace PEPs
{
    public partial class PEPs : Form
    {
        public PEPs()
        {
            InitializeComponent();
        }

        private void 启动_Click(object sender, System.EventArgs e)
        {
            if(File.Exists(@"C:\Windows\System32\Macromed\Flash\Flash.ocx"))
            {
                Start();
            }
            else
            {
                InstallFlash();
                Start();
            }
        }

        public static String Start()
        {
            if (File.Exists(@"start/start.exe"))
            {
                Process exec = new Process();
                exec.StartInfo.FileName = "start.bat";
                exec.Start();
            }
            else
            {
                MessageBox.Show("找不到start目录下的start.exe文件");
            }
            return null;
        }
    }
}

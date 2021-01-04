using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class processForm : Form
    {
        public processForm()
        {
            InitializeComponent();
            showAppMemory();
        }

        public void showAppMemory()
        {
            this.appCount.Text = "";
            Process[] processes = Process.GetProcesses();
            int appCount = 0;
            this.appMemory.Text = "";
            foreach (Process process in processes)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    appCount += 1;
                    appMemory.Text = appMemory.Text + "Process " + process.ProcessName.ToString() + " is using: " + (process.PagedMemorySize64 / 1048576).ToString() +" MB\n";
                }
            }
            this.appCount.Text = "There are currently " + appCount.ToString() + " foreground application(s) running";
        }
    }
}

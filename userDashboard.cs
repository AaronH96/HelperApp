using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class userDashboard : Form
    {
        //Set clock format
        private const string Format = "HH:mm";
        //Setup performance counter for CPU and RAM
        private PerformanceCounter perfCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

        //Welcome message and setup clock
        public userDashboard()
        {
            InitializeComponent();
            label2.Text = "Welcome " + welcomeScreen.userName + "!";
            DateTime currentDate = DateTime.Now; 
            var culture = new CultureInfo("en-AU");
            label3.Text = "Current Time: " + currentDate.ToString(Format);
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        //Start timer for time display and performance measurement
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            var culture = new CultureInfo("en-AU");
            label3.Text = "Current Time: " + currentDate.ToString(Format);
            cpuCounter.Text = "CPU performance: " + cpuPerformance();
            ramPerf.Text = "RAM performance: " + ramPerformance();
        }
            
        //Show storage function
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MemoryForm memStat = new MemoryForm();
            memStat.Show();
        }

        //Show running process function
        private void button2_Click(object sender, EventArgs e)
        {
            processForm procForm = new processForm();
            procForm.Show();
        }

        //Setup confirmation message when user want to close application
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }

        //Show fast Folder access function
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            folderForm folder = new folderForm();
            folder.Show();
        }

        //Show fast Webpage access function
        private void button4_Click(object sender, EventArgs e)
        {
            linkForm link = new linkForm();
            link.Show();
            

        }

        //Launch Snipping Tool function
        private void button5_Click(object sender, EventArgs e)
        {
            Process snippingToolProcess = new Process();
            snippingToolProcess.EnableRaisingEvents = true;
            if (!Environment.Is64BitProcess)
            {
                snippingToolProcess.StartInfo.FileName = "C:\\Windows\\sysnative\\SnippingTool.exe";
                snippingToolProcess.Start();
            }
            else
            {
                snippingToolProcess.StartInfo.FileName = "C:\\Windows\\system32\\SnippingTool.exe";
                snippingToolProcess.Start();
            }
        }

        //Show fast Application function
        private void button6_Click(object sender, EventArgs e)
        {
            appForm app = new appForm();
            app.Show();
        }

        //Setup performance measurement and help tips
        private void userDashboard_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1,"Show storage status");
            toolTip1.SetToolTip(this.button2, "Show currently running applications");
            toolTip1.SetToolTip(this.button3, "Fast folder access");
            toolTip1.SetToolTip(this.button4, "Fast webpage access");
            toolTip1.SetToolTip(this.button5, "Launch Snipper Tool");
            toolTip1.SetToolTip(this.button6, "Fast launch application");
            cpuCounter.Text = "CPU performance: " + cpuPerformance();
            ramPerf.Text = "RAM performance: " + ramPerformance();
        }
        
        //return CPU performance in percentage
        public string cpuPerformance()
        {
            return perfCounter.NextValue() + "%";
        }
        //return RAM performance in percentage
        public string ramPerformance()
        {
            return ramCounter.NextValue() + "%";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string helpFile = Directory.GetCurrentDirectory() + "\\Readme.txt";
            Process.Start(@helpFile);
        }
    }
}

using CsvHelper;
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
    public partial class appForm : Form
    {
        public appForm()
        {
            InitializeComponent();
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            appList.Text = "";
            string folderPath = Directory.GetCurrentDirectory() + "\\AppList.csv";
            List<fastApp> fastAppList = new List<fastApp>();
            using (var reader = new StreamReader(folderPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HeaderValidated = null;
                csv.Configuration.MissingFieldFound = null;
                var records = csv.GetRecords<fastApp>();
                foreach (fastApp app in records)
                {
                    appList.Text = appList.Text + app.appName.ToString() + "\n";
                    fastAppList.Add(app);
                }
            }
            foreach (fastApp app in fastAppList)
            {
                this.appList.Links.Add(appList.Text.IndexOf(app.appName), app.appName.Length, app.appLink);
            }
        }

        private void appList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = "";
            // Determine which link was clicked and set the appropriate url.
            this.appList.Links[appList.Links.IndexOf(e.Link)].Visited = true;
            path = e.Link.LinkData.ToString();
            Process.Start(@path);
        }
    }
}

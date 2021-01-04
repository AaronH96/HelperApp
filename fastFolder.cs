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
    public partial class folderForm : Form
    {
        public folderForm()
        {
            InitializeComponent();
        }

        private void folderForm_Load(object sender, EventArgs e)
        {
            fastFolder.Text = "";
            string folderPath = Directory.GetCurrentDirectory() + "\\FileList.csv";
            List<fastFolder> fastFolderList = new List<fastFolder>();
            using (var reader = new StreamReader(folderPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HeaderValidated = null;
                csv.Configuration.MissingFieldFound = null;
                var records = csv.GetRecords<fastFolder>();
                foreach (fastFolder folder in records)
                {
                    fastFolder.Text = fastFolder.Text + folder.folderName.ToString() + "\n";
                    fastFolderList.Add(folder);
                }
            }
            foreach (fastFolder folder in fastFolderList)
            {
                this.fastFolder.Links.Add(fastFolder.Text.IndexOf(folder.folderName),folder.folderName.Length,folder.folderDir);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = "";
            // Determine which link was clicked and set the appropriate url.
            this.fastFolder.Links[fastFolder.Links.IndexOf(e.Link)].Visited = true;
            path = e.Link.LinkData.ToString();
            Process.Start(@path);
        }

    }
}

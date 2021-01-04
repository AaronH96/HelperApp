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
    public partial class linkForm : Form
    {
        public linkForm()
        {
            InitializeComponent();
        }

        private void linkForm_Load(object sender, EventArgs e)
        {
            linkList.Text = "";
            string folderPath = Directory.GetCurrentDirectory() + "\\LinkList.csv";
            List<fastLink> fastLinkList = new List<fastLink>();
            using (var reader = new StreamReader(folderPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HeaderValidated = null;
                csv.Configuration.MissingFieldFound = null;
                var records = csv.GetRecords<fastLink>();
                foreach (fastLink link in records)
                {
                    linkList.Text = linkList.Text + link.linkName.ToString() + "\n";
                    fastLinkList.Add(link);
                }
            }
            foreach (fastLink link in fastLinkList)
            {
                this.linkList.Links.Add(linkList.Text.IndexOf(link.linkName), link.linkName.Length, link.linkURL);
            }
        }

        private void fastLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = "";
            // Determine which link was clicked and set the appropriate url.
            this.linkList.Links[linkList.Links.IndexOf(e.Link)].Visited = true;
            path = e.Link.LinkData.ToString();
            Process.Start(@path);
        }
    }
}

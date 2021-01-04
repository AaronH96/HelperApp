using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MemoryForm : Form
    {
        public MemoryForm()
        {
            InitializeComponent();
            showMemory();
        }

        public void showMemory()
        {
            memoryStat.Margin = new Padding(4, 4, 4, 4);
            memoryStat.Text = "";
            DriveInfo[] allDrive = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrive)
            {
                memoryStat.Text = memoryStat.Text + "Available space in Drive " + drive.Name.Substring(0, 1) + ": "
                    + (drive.AvailableFreeSpace / 1073741824).ToString() + "GB / " + (drive.TotalSize / 1073741824).ToString() + "GB\n";
            }
            
        }

    }
}

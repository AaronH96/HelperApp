using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class welcomeScreen : Form
    {
        public static string userName="";

        //Prompt user to input a username
        public welcomeScreen()
        {
            InitializeComponent();
            this.ActiveControl = richTextBox1;
            richTextBox1.Focus();
            button2.Visible = true;
            this.AcceptButton = button2;
        }

        //Launch User Dashboard with input username
        private void label1_Click(object sender, EventArgs e)
        {
            userName = richTextBox1.Text;
            userDashboard frm2 = new userDashboard();
            frm2.Show();
            this.Visible = false;            
        }
               
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationServicePlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_toolStripButton1_Click(object sender, EventArgs e)
        {
            registerForm registrationForm = new registerForm();
            registrationForm.MdiParent = this;
            registrationForm.Show();
        }

        private void search_toolStripButton2_Click(object sender, EventArgs e)
        {
            searchForm searchForm = new searchForm();
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void browser_toolStripButton3_Click(object sender, EventArgs e)
        {
            browserForm browserForm = new browserForm();
            browserForm.MdiParent = this;
            browserForm.Show();
        }

        private void calculator_toolStripButton4_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Users\\Louise\\source\\repos\\Calculator\\Calculator\\bin\\Debug\\Calculator.exe";
            this.process1.Start();
        }

        private void about_toolStripButton5_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void exit_toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                register_toolStripButton1_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {
                search_toolStripButton2_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                browser_toolStripButton3_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                calculator_toolStripButton4_Click(sender, e);
            }

            if (e.KeyCode == Keys.F5)
            {
                about_toolStripButton5_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                exit_toolStripButton6_Click(sender, e);
            }
        }
    }
}

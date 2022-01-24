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
    public partial class browserForm : Form
    {
        public browserForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            string webpage = searchBar.Text.Trim();

            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(webpage);
            }

            
        }
    }
}

using System;
using System.Text;
using System.Windows.Forms;

namespace RegistrationServicePlatform
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.searchIdTextBox.Text == "")
            {
                MessageBox.Show("ID value not set");
                return;
            }

            string folderName;
            folderName = "X:\\C#\\RegistrationServicePlatformRegistreredData\\";
            string element;
            string readText;

            // Show ID:
            element = folderName + this.searchIdTextBox.Text + "_id.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.idTextBox.Text = readText;
            }

            // Find first name:
            element = folderName + this.searchIdTextBox.Text + "_firstname.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.firstNameTextBox.Text = readText;
            }

            // Find last name:
            element = folderName + this.searchIdTextBox.Text + "_lastname.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.lastNameTextBox.Text = readText;
            }

            // Find phone:
            element = folderName + this.searchIdTextBox.Text + "_phone.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.phoneTextBox.Text = readText;
            }


            // Find email:
            element = folderName + this.searchIdTextBox.Text + "_email.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.emailTextBox.Text = readText;
            }


            // Find address:
            element = folderName + this.searchIdTextBox.Text + "_address.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.addressTextBox.Text = readText;
            }

            // Find additional info:
            element = folderName + this.searchIdTextBox.Text + "_additional.txt";

            if (System.IO.File.Exists(element) == true)
            {
                readText = System.IO.File.ReadAllText(element, Encoding.UTF8);
                this.additionalInfoTextBox.Text = readText;
            }

        
        }

     
    }
}

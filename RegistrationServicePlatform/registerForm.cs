using System;
using System.Text;
using System.Windows.Forms;

namespace RegistrationServicePlatform
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void newDataButton_Click(object sender, EventArgs e)
        {
            this.newDataButton.Enabled = false;
            this.saveChangesButton.Enabled = true;

            this.infoBox.Enabled = true;

            // Clear all textboxes
            this.idTextBox.ResetText();
            this.firstNameTextBox.ResetText();
            this.lastNameTextBox.ResetText();
            this.phoneTextBox.ResetText();
            this.emailTextBox.ResetText();
            this.addressTextBox.ResetText();
            this.additionalInfoTextBox.ResetText();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            // Disallow saving without ID value
            if (this.idTextBox.Text == "")
            {
                MessageBox.Show("ID value not set");
                return;
            }


            this.saveChangesButton.Enabled = false;
            this.newDataButton.Enabled = true;

            this.infoBox.Enabled = false;

            string folderName;
            folderName = "X:\\C#\\RegistrationServicePlatformRegistreredData\\";

            string element;



            // Save ID:
            element = folderName + this.idTextBox.Text + "_id.txt";
            System.IO.File.WriteAllText(element, this.idTextBox.Text, Encoding.UTF8);

            // Save first name:
            element = folderName + this.idTextBox.Text + "_firstname.txt";
            System.IO.File.WriteAllText(element, this.firstNameTextBox.Text, Encoding.UTF8);

            // Save surname:
            element = folderName + this.idTextBox.Text + "_lastname.txt";
            System.IO.File.WriteAllText(element, this.lastNameTextBox.Text, Encoding.UTF8);

            // Save phone:
            element = folderName + this.idTextBox.Text + "_phone.txt";
            System.IO.File.WriteAllText(element, this.phoneTextBox.Text, Encoding.UTF8);

            // Save email
            element = folderName + this.idTextBox.Text + "_email.txt";
            System.IO.File.WriteAllText(element, this.emailTextBox.Text, Encoding.UTF8);

            // Save address
            element = folderName + this.idTextBox.Text + "_address.txt";
            System.IO.File.WriteAllText(element, this.addressTextBox.Text, Encoding.UTF8);

            // Save additional information
            element = folderName + this.idTextBox.Text + "_additional.txt";
            System.IO.File.WriteAllText(element, this.additionalInfoTextBox.Text, Encoding.UTF8);

            MessageBox.Show("Saved");
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            this.infoBox.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.Classes;


namespace FreelancerPlatform.Pages
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        // getting the connection class here
        Connection.Connection connection = new Connection.Connection();

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Profile profile = new Profile();
                // getting the function to insert the data here
                profile.ProfessionalSummary = txtProfessionalSummary.Text;
                profile.Fullname = txtName.Text;
                profile.Skill = cmbSkills.SelectedItem.ToString(); // getting the value from the combo box here
                profile.EducationBackground = cmbEducationBackground.SelectedItem.ToString();
                profile.PhoneNumber = txtPhoneNumber.Text;
                profile.Email = txtEmail.Text;
                profile.Languages = cmbLanguages.SelectedItem.ToString();
                // getting values from the combo box here
                if (rbtnAvailable.Checked)
                {
                    profile.Availability = "Available";
                }
                else if (rbtnNotAvailable.Checked)
                {
                    profile.Availability = "Not Available";
                }
                else
                {
                    MessageBox.Show("make sure you have selected the status first");
                }
                profile.PaymentTerms = txtPaymentTerms.Text;
                profile.Experience = txtExperience.Text;
                profile.Location = txtLocation.Text;
                profile.PreviousProjects = txtPreviousProjects.Text;

                // calling the save details function here
                profile.CreateProfileDetails();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

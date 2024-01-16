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


namespace FreelancerPlatform.ClientPages
{
    public partial class ClientProfile : Form
    {
        public ClientProfile()
        {
            InitializeComponent();
        }

        private void BtnCreateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                // ==============getting the form controls here=================== //
                client.FirstName = txtFirstName.Text;
                client.LastName = txtLastname.Text;
                client.PhoneNumber = txtPhoneNumber.Text;
                client.Email = txtEmail.Text;
                client.ProjectTitle = txtProjectTitle.Text;
                client.ProjectDescription = txtProjectDescription.Text;
                client.ProjectType = txtProjectType.Text;
                client.Budget = txtBudget.Text;
                // =========== getting the date from the picker here ================ //
                DateTime selectDate = dateProjectStartDate.Value;
                client.StartDate = selectDate.ToShortDateString();
                // ===================getting the end date here =========================//
                DateTime endproject = dateProjectEnddate.Value;
                client.ProjectDeadline = endproject.ToShortDateString();
                // ==================== calling the function to save the date here =============//
                client.CreateClientProfile();
                ClearFields(); // function to clear the fields here

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= function to clear the fields here =============//
        public void ClearFields()
        {
            try
            {
                txtBudget.Text = "";
                txtFirstName.Text = "";
                txtLastname.Text = "";
                txtPhoneNumber.Text = "";
                txtProjectDescription.Text = "";
                txtProjectTitle.Text = "";
                txtProjectType.Text = "";
                txtEmail.Text = "";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

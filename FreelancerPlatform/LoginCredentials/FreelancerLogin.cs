using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.LoginCredentials;
using FreelancerPlatform.Connection;
using FreelancerPlatform.Classes;



namespace FreelancerPlatform.LoginCredentials
{
    public partial class FreelancerLogin : Form
    {
        public FreelancerLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection conn = new Connection.Connection();
                conn.DatabaseConnection(); // getting the database connection here
                conn.CreateFreelancerRegisterTable();

                FreelancerRegister freelancerRegister = new FreelancerRegister();
                freelancerRegister.Show();
                this.Hide();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Freelancer freelancer = new Freelancer();
            freelancer.Username = txtUsername.Text;
            freelancer.Password = txtPassword.Text;

            // Validate username and password
            if (string.IsNullOrWhiteSpace(freelancer.Username) || string.IsNullOrWhiteSpace(freelancer.Password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Authenticate the user
            if (freelancer.AuthenticateUser(freelancer.Username, freelancer.Password))
            {
                MessageBox.Show("Login successful!");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}

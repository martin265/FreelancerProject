using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.ClientPages;
using FreelancerPlatform.Classes;


namespace FreelancerPlatform.ClientPages
{
    public partial class ClientLogin : Form
    {
        public ClientLogin()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                ClientRegister clientRegister = new ClientRegister();
                clientRegister.Show();
                this.Hide();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Username = txtUsername.Text;
            client.Password = txtPassword.Text;

            // Validate username and password
            if (string.IsNullOrWhiteSpace(client.Username) || string.IsNullOrWhiteSpace(client.Password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Authenticate the user
            if (client.AuthenticateUser(client.Username, client.Password))
            {
                MessageBox.Show("Login successful!");
                ClientDashboard clientDashboard = new ClientDashboard();
                clientDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}

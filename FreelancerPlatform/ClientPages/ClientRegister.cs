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
using FreelancerPlatform.ClientPages;
using FreelancerPlatform.Connection;


namespace FreelancerPlatform.ClientPages
{
    public partial class ClientRegister : Form
    {
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("fill in the blanks first");
                }
                else
                {
                    Connection.Connection connection = new Connection.Connection();
                    connection.DatabaseConnection();
                    connection.CreateClientRegisterTable(); // creating the table here
                    Client client = new Client();
                    client.Username = txtUsername.Text;
                    client.Password = txtPassword.Text;

                    // =============== calling the register function here
                    client.RegisterClient();
                    this.Hide();
                    ClientLogin clientLogin = new ClientLogin();
                    clientLogin.Show();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

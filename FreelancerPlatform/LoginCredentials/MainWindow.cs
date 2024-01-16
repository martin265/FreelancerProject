using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.Connection;
using FreelancerPlatform.ClientPages;
using MySql.Data.MySqlClient;


namespace FreelancerPlatform.LoginCredentials
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            // calling all the tables when the button is clickedsss
        }


        // ================ the button to call freelancer =======//
        private void BtnFreelancer_Click(object sender, EventArgs e)
        {
            try
            {
                FreelancerLogin freelancerLogin = new FreelancerLogin();
                freelancerLogin.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ========== the button to call the client window ==========//
        private void BtnClient_Click(object sender, EventArgs e)
        {
            try
            {
                ClientLogin clientLogin = new ClientLogin();
                clientLogin.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSetupDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection conn = new Connection.Connection();
                conn.DatabaseConnection();
                conn.CreateProjectDetailsTable();
                conn.CreateBidingTable();
                conn.CreateProfileTable();
                conn.CreateClientProfileTable();
                conn.CreateFreelancerRegisterTable();
                conn.CreateClientRegisterTable();

                MessageBox.Show("database initialised successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

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
using MySql.Data.MySqlClient;


namespace FreelancerPlatform.ClientPages
{
    public partial class ProfileDetails : Form
    {
        public ProfileDetails()
        {
            InitializeComponent();
            displayClientDetails();
        }

        private void ClientProfileDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayClientDetails()
        {
            try
            {
                // Replace these values with your actual MySQL server details
                string connectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(connectionString);
                // opening the database connection here
                connection.Open();
                string getAllFreelancers = @"SELECT * FROM client_profile";
                MySqlCommand selectRecords = new MySqlCommand(getAllFreelancers, connection);
                // ============= running the query here ============//
                using (MySqlDataReader reader = selectRecords.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // creating the datatable here for the records.
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // passing the records to the data grid here
                        ClientProfileDetails.DataSource = dataTable;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientProfileDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

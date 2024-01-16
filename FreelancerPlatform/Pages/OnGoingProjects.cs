using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FreelancerPlatform.Classes;


namespace FreelancerPlatform.Pages
{
    public partial class OnGoingProjects : Form
    {
        public OnGoingProjects()
        {
            InitializeComponent();
            displayAllProjects();
        }

        private void AllProjectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnGoingProjects_Load(object sender, EventArgs e)
        {

        }

        // ================ function to display the records here ====================== //
        public void displayAllProjects()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the database connection here
                connection.Open();
                string getAllFreelancers = @"SELECT * FROM biding_projects";
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
                        AllProjectsDataGridView.DataSource = dataTable;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

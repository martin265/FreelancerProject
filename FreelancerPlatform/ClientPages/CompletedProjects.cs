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

namespace FreelancerPlatform.ClientPages
{
    public partial class CompletedProjects : Form
    {
        public CompletedProjects()
        {
            InitializeComponent();
            showAllCompletedProjects();
        }

        private void CompletedProjectsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showAllCompletedProjects()
        {
            try
            {
                string connectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(connectionString);

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
                        CompletedProjectsDataGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

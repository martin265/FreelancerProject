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
    public partial class ViewFreelancer : Form
    {
        public ViewFreelancer()
        {
            InitializeComponent();
            showAllFreelancers();
        }

        private void ViewFreelancerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ============= function to get all the registered freelancers =============//
        public void showAllFreelancers()
        {
            try
            {
                string connectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(connectionString);

                // opening the database connection here
                connection.Open();
                string getAllFreelancers = @"SELECT * FROM profile";
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
                        ViewFreelancerDataGridView.DataSource = dataTable;
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

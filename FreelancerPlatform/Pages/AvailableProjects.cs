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
using FreelancerPlatform.Connection;
using FreelancerPlatform.Classes;


namespace FreelancerPlatform.Pages
{
    public partial class AvailableProjects : Form
    {
        public AvailableProjects()
        {
            InitializeComponent();
            displayComboBox();
            fetchRecords();
        }

        private void CmbBrowseProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(connectionString);

                // opening the database connection here
                connection.Open();
                string getAllFreelancers = @"SELECT * FROM available_projects WHERE project_title = '"+cmbBrowseProjects.Text+"';";
                MySqlCommand selectRecords = new MySqlCommand(getAllFreelancers, connection);
                using (MySqlDataReader reader = selectRecords.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // filling the text fields upon combo box value selection //
                        txtProjectTitle.Text = reader["project_title"].ToString();
                        txtProjectDescription.Text = reader["project_description"].ToString();
                        txtProjectType.Text = reader["project_type"].ToString();
                        txtBudget.Text = reader["budget"].ToString();
                        dateStartDate.Text = reader["start_date"].ToString();
                        ProjectDeadline.Text = reader["project_deadline"].ToString();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================ show records in combo box ====================== //
        public void displayComboBox()
        {
            try
            {
                string connectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(connectionString);

                // opening the database connection here
                connection.Open();
                string getAllFreelancers = @"SELECT project_title FROM available_projects";
                MySqlCommand selectRecords = new MySqlCommand(getAllFreelancers, connection);
                using (MySqlDataReader reader = selectRecords.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // ========= looping through the records here ==============//
                        while (reader.Read())
                        {
                            string record = reader.GetString("project_title");
                            cmbBrowseProjects.Items.Add(record);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBidProject_Click(object sender, EventArgs e)
        {
            try
            {
                Freelancer freelancer = new Freelancer(); // the object for the client class here
                freelancer.ProjectTitle = txtProjectTitle.Text;
                freelancer.ProjectDescription = txtProjectDescription.Text;
                freelancer.ProjectType = txtProjectType.Text;
                freelancer.Budget = txtBudget.Text;
                freelancer.BidingPrice = txtBiddingPrice.Text;
                // =========== getting the date from the picker here ================ //
                DateTime selectDate = dateStartDate.Value;
                freelancer.StartDate = selectDate.ToShortDateString();
                // ===================getting the end date here =========================//
                DateTime endproject = ProjectDeadline.Value;
                freelancer.ProjectDeadline = endproject.ToShortDateString();
                // ==================== calling the function to save the date here =============//
                freelancer.saveBidingDetails(); // calling the function to post the projects here
                fetchRecords();
                clearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ============= function to clear the text fields here =============//
        public void clearFields()
        {
            try
            {
                txtBudget.Text = "";
                txtProjectDescription.Text = "";
                txtProjectTitle.Text = "";
                txtProjectType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================== function to fetch records in the database ====================//
        public void fetchRecords()
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
                        BidingDataGridView.DataSource = dataTable;
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

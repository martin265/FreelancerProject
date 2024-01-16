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
using FreelancerPlatform.Classes;
using MySql.Data.MySqlClient;



namespace FreelancerPlatform.ClientPages
{
    public partial class PostProjects : Form
    {
        public PostProjects()
        {
            InitializeComponent();
            displayDetails();


        }
        int ID; // the counter for the table records here

        private void PostProjects_Load(object sender, EventArgs e)
        {

        }

        private void BtnSaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(); // the object for the client class here
                client.ProjectTitle = txtProjectTitle.Text;
                client.ProjectDescription = txtProjectDescription.Text;
                client.ProjectType = txtProjectType.Text;
                client.Budget = txtBudget.Text;
                // =========== getting the date from the picker here ================ //
                DateTime selectDate = Startdate.Value;
                client.StartDate = selectDate.ToShortDateString();
                // ===================getting the end date here =========================//
                DateTime endproject = ProjectDeadline.Value;
                client.ProjectDeadline = endproject.ToShortDateString();
                // ==================== calling the function to save the date here =============//
                client.PostProjects(); // calling the function to post the projects here
                displayDetails();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void AvailableProjectsDatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtProjectTitle.Text = AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProjectDescription.Text = AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtProjectType.Text = AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBudget.Text = AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Startdate.Text = AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                ProjectDeadline.Text = AvailableProjectsDatagridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================ the function to show the details in the table here ===========//
        public void displayDetails()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the database connection here
                connection.Open();
                string getAllFreelancers = @"SELECT * FROM available_projects";
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
                        AvailableProjectsDatagridView.DataSource = dataTable;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearFields()
        {
            try
            {
                txtBudget.Text = "";
                txtProjectDescription.Text = "";
                txtProjectTitle.Text = "";
                txtProjectType.Text = "";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(); // the object for the client class here
                client.ProjectID = ID;
                client.ProjectTitle = txtProjectTitle.Text;
                client.ProjectDescription = txtProjectDescription.Text;
                client.ProjectType = txtProjectType.Text;
                client.Budget = txtBudget.Text;
                // =========== getting the date from the picker here ================ //
                DateTime selectDate = Startdate.Value;
                client.StartDate = selectDate.ToShortDateString();
                // ===================getting the end date here =========================//
                DateTime endproject = ProjectDeadline.Value;
                client.ProjectDeadline = endproject.ToShortDateString();
                // ==================== calling the function to save the date here =============//
                client.updateProjectDetails(); // calling the function to update the projects here
                displayDetails();
                clearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Client client = new Client(); // the object for the client class here
            client.ProjectID = ID;
            client.ProjectTitle = txtProjectTitle.Text;
            client.ProjectDescription = txtProjectDescription.Text;
            client.ProjectType = txtProjectType.Text;
            client.Budget = txtBudget.Text;
            // =========== getting the date from the picker here ================ //
            DateTime selectDate = Startdate.Value;
            client.StartDate = selectDate.ToShortDateString();
            // ===================getting the end date here =========================//
            DateTime endproject = ProjectDeadline.Value;
            client.ProjectDeadline = endproject.ToShortDateString();
            // ==================== calling the function to save the date here =============//
            client.deleteProjectRecord(); // calling the function to update the projects here
            displayDetails();
            clearFields();
        }
    }
}

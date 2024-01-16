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
using FreelancerPlatform.Connection;
using MySql.Data.MySqlClient;


namespace FreelancerPlatform
{
    public partial class ClientDashboard : Form
    {
        public ClientDashboard()
        {
            InitializeComponent();
            // getting the connection with the databse here
            Connection.Connection connection = new Connection.Connection();
            connection.DatabaseConnection();
            //connection.CreateClientProfileTable();

            // =============calling the function here ================//
            showAllFreelancers();
        }

        private void BtnCreateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCenterPanel.Controls.Clear(); // removing the default controls for the panel here
                // =========== creating the object for the profile form here ========//
                ClientPages.ClientProfile profile = new ClientProfile();
                profile.TopLevel = false;

                // ===============adding controls to the main form here =======//
                ClientCenterPanel.Controls.Add(profile);
                // ============showing the controls to the main page here
                profile.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                ClientCenterPanel.Controls.Clear(); // removing the default controls for the panel here
                // =========== creating the object for the profile form here ========//
                ClientPages.ClientProfile profile = new ClientProfile();
                profile.TopLevel = false;

                // ===============adding controls to the main form here =======//
                ClientCenterPanel.Controls.Add(profile);
                // ============showing the controls to the main page here
                profile.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnViewProfileDetails_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCenterPanel.Controls.Clear(); // removing the default controls for the panel here
                // =========== creating the object for the profile form here ========//
                ProfileDetails profileDetails = new ProfileDetails();
                profileDetails.TopLevel = false;

                ClientCenterPanel.Controls.Add(profileDetails);

                profileDetails.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnViewFreelancer_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCenterPanel.Controls.Clear(); //  removing the default controls here
                ViewFreelancer viewFreelancer = new ViewFreelancer(); // the form for the free lancers here
                viewFreelancer.TopLevel = false;

                // passing the controls to the main panel here
                ClientCenterPanel.Controls.Add(viewFreelancer);
                viewFreelancer.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    if(reader.HasRows)
                    {
                        // creating the datatable here for the records.
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void BtnCompletedProjects_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCenterPanel.Controls.Clear(); // removing the default controls for the panel
                // ============== creating the object for the form to be called =========== //
                CompletedProjects completedProjects = new CompletedProjects();

                completedProjects.TopLevel = false;

                ClientCenterPanel.Controls.Add(completedProjects);
                completedProjects.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPostProject_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCenterPanel.Controls.Clear(); // removing the default controls here
                PostProjects postProjects = new PostProjects();
                // ===============passing the top level to false==========//
                postProjects.TopLevel = false;

                ClientCenterPanel.Controls.Add(postProjects);
                postProjects.Show(); 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

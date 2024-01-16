using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.ClientPages;
using MySql.Data.MySqlClient;
using FreelancerPlatform.Connection;



namespace FreelancerPlatform.Classes
{
    class Freelancer
    {
        // ==============getters and setters here ==========//
        private int freelancer_id;
        private string project_title;
        private string project_description;
        private string project_type;
        private string budget;
        private string start_date;
        private string project_deadline;
        private string biding_price;
        private string username;
        private string password;

        // ==============================// =====================================//
        public int FreelancerID { get { return freelancer_id; } set { freelancer_id = value; } }
        public string ProjectTitle { get { return project_title; } set { project_title = value; } }
        public string ProjectDescription { get { return project_description; } set { project_description = value; } }
        public string ProjectType { get { return project_type; } set { project_type = value; } }
        public string Budget { get { return budget; } set { budget = value; } }
        public string StartDate { get { return start_date; } set { start_date = value; } }
        public string ProjectDeadline { get { return project_deadline; } set { project_deadline = value; } }
        public string BidingPrice { get { return biding_price; }set{ biding_price = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        // ===================== // functions to save the biding details here ===============//
        public void saveBidingDetails()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string insertQuery = @"INSERT INTO biding_projects(project_title, project_description, project_type, budget, biding_price, start_date, project_deadline) VALUES('" + project_title + "', '" + project_description + "', '" + project_type + "', '" + budget + "', '"+biding_price+"', '" + start_date + "', '" + project_deadline + "')";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Biding details successfully".ToUpper());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RegisterFreelancer()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string insertQuery = @"INSERT INTO freelancer_register(username, password) VALUES ('"+username+"', '"+password+"');";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Freelancer registered successfully".ToUpper());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool AuthenticateUser(string username, string password)
        {
            string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM freelancer_register WHERE username = @username AND password = @password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if any rows are returned
                        return reader.HasRows;
                    }
                }
            }
        }


    }
}

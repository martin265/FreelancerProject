using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FreelancerPlatform.Classes
{
    class Client
    {
        private int project_id;
        private string first_name;
        private string last_name;
        private string phone_number;
        private string email;
        private string project_title;
        private string project_description;
        private string project_type;
        private string budget;
        private string start_date;
        private string project_deadline;
        private string username;
        private string password;

        // ================== getters and setters here ================//
        public int ProjectID { get { return project_id; } set { project_id = value; } }
        public string FirstName { get { return first_name; } set { first_name = value; } }
        public string LastName { get { return last_name; } set { last_name = value; } }
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string ProjectTitle { get { return project_title; } set { project_title = value; } }
        public string ProjectDescription { get { return project_description; } set { project_description = value; } }
        public string ProjectType { get { return project_type; } set { project_type = value; } }
        public string Budget { get { return budget; } set { budget = value; } }
        public string StartDate { get { return start_date; } set { start_date = value; } }
        public string ProjectDeadline { get { return project_deadline ; } set { project_deadline = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        // ====================== functions will be here =========================== //
        public void PostProjects()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string insertQuery = @"INSERT INTO available_projects(project_title, project_description, project_type, budget, start_date, project_deadline) VALUES('"+project_title+"', '"+project_description+"', '"+project_type+"', '"+budget+"', '"+start_date+"', '"+project_deadline+"')";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("project details successfully".ToUpper());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===============function to post new projects for the freelancers =================== //
        public void CreateClientProfile()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string insertQuery = @"
                    INSERT INTO client_profile(first_name, last_name, phone_number, email, project_title, project_description, project_type, budget, start_date, project_deadline)
                    VALUES('" + first_name + "', '" + last_name + "', '" + phone_number + "', '" + email + "', '" + project_title + "', '" + project_description + "', '" + project_type + "', '" + budget + "', '" + start_date + "', '" + project_deadline + "')";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("client profile created successfully".ToUpper());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==================function to update project details here =================== //
        public void updateProjectDetails()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string updateQuery = @"UPDATE available_projects SET project_title = '"+project_title+"', project_description = '"+project_description+"', project_type = '"+project_type+"', budget = '"+budget+"', start_date = '"+start_date+"', project_deadline = '"+project_deadline+"' WHERE project_id = '"+project_id+"';";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("project details updated successfully".ToUpper());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =============== function to delete the project details here ==============//
        public void deleteProjectRecord()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string updateQuery = @"DELETE FROM available_projects WHERE project_id = '"+project_id+"';";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("project details deleted successfully".ToUpper());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RegisterClient()
        {
            try
            {
                // getting the connection here for the mysql
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);

                // opening the connection here
                connection.Open();

                // the query to save the records
                string insertQuery = @"INSERT INTO client_register(username, password) VALUES ('" + username + "', '" + password + "');";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Client registered successfully".ToUpper());

            }
            catch (Exception ex)
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
                string query = "SELECT * FROM client_register WHERE username = @username AND password = @password";
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

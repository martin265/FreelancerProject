using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FreelancerPlatform.Connection
{
    class Connection
    {
        // =============the connection with the database will be here
        public void DatabaseConnection()
        {
            string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            try
            {
                // --------opening the connection with the database here
                connection.Open();
                //MessageBox.Show("connection with the database initialised successfully");
                DropingDatabase();
                CreateNewdatabase(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DropingDatabase()
        {
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"DROP DATABASE IF EXISTS freelancerdb"; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Database dropped successfully successfully".ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateNewdatabase()
        {
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"CREATE DATABASE freelancerdb"; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Database dropped successfully successfully".ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============the code for creating the tables will be here
        public void CreateProfileTable()
        {
            
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"
                    CREATE TABLE IF NOT EXISTS Profile(
                        profile_id INT AUTO_INCREMENT PRIMARY KEY,
                        professional_summary VARCHAR(100) NOT NULL,
                        full_name VARCHAR(50) NOT NULL,
                        skills VARCHAR(50) NOT NULL,
                        education_background VARCHAR(50) NOT NULL,
                        phone_number VARCHAR(50) NOT NULL,
                        email VARCHAR(50) UNIQUE NOT NULL,
                        languages VARCHAR(50) NOT NULL,
                        availability VARCHAR(50) NOT NULL,
                        payment_terms VARCHAR(50) NOT NULL,
                        experience VARCHAR(50) NOT NULL,
                        location VARCHAR(50) NOT NULL,
                        previous_projects VARCHAR(50) NOT NULL
                    );
                "; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("tabled created successfully".ToUpper());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // ================creating the table for the client profile here =========== //
        public void CreateClientProfileTable()
        {
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"
                    CREATE TABLE IF NOT EXISTS client_profile(
                        client_profile_id INT AUTO_INCREMENT PRIMARY KEY,
                        first_name VARCHAR(50) NOT NULL,
                        last_name VARCHAR(50) NOT NULL,
                        phone_number VARCHAR(50) NOT NULL,
                        email VARCHAR(50) UNIQUE,
                        project_title VARCHAR(50) NOT NULL,
                        project_description VARCHAR(50) NOT NULL,
                        project_type VARCHAR(50) NOT NULL,
                        budget VARCHAR(50) NOT NULL,
                        start_date VARCHAR(50) NOT NULL,
                        project_deadline VARCHAR(50) NOT NULL
                        
                    );
                "; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("client created successfully".ToUpper());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        // ================function to create the projects table ============//
        public void CreateProjectDetailsTable()
        {
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"
                    CREATE TABLE IF NOT EXISTS available_projects(
                        project_id INT AUTO_INCREMENT PRIMARY KEY,
                        project_title VARCHAR(50) NOT NULL,
                        project_description VARCHAR(50) NOT NULL,
                        project_type VARCHAR(50) NOT NULL,
                        budget VARCHAR(50) NOT NULL,
                        start_date VARCHAR(50) NOT NULL,
                        project_deadline VARCHAR(50) NOT NULL
                        
                    );
                "; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Projects table created successfully".ToUpper());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =================creating a table for the biding details here ===============//
        public void CreateBidingTable()
        {
            try
            {

                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"
                    CREATE TABLE IF NOT EXISTS biding_projects(
                        project_id INT AUTO_INCREMENT PRIMARY KEY,
                        project_title VARCHAR(50) NOT NULL,
                        project_description VARCHAR(50) NOT NULL,
                        project_type VARCHAR(50) NOT NULL,
                        budget VARCHAR(50) NOT NULL,
                        biding_price VARCHAR(50) NOT NULL,
                        start_date VARCHAR(50) NOT NULL,
                        project_deadline VARCHAR(50) NOT NULL
                    );
                "; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Biding table created successfully".ToUpper());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CreateFreelancerRegisterTable()
        {
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"
                    CREATE TABLE IF NOT EXISTS freelancer_register(
                        username VARCHAR(50) NOT NULL,
                        password VARCHAR(50) NOT NULL
                    );
                "; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("Register table created successfully".ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========== the table for the client register here
        public void CreateClientRegisterTable()
        {
            try
            {
                string ConnectionString = "server=localhost;database=freelancedb;uid=root;password='';";
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                // opening the connection with the databse here
                connection.Open();
                string createProfileTable = @"
                    CREATE TABLE IF NOT EXISTS client_register(
                        username VARCHAR(50) NOT NULL,
                        password VARCHAR(50) NOT NULL
                    );
                "; // the end of the query here
                // executing the query here for creating the profile table 
                MySqlCommand createTableCommand = new MySqlCommand(createProfileTable, connection);
                createTableCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("client table created successfully".ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

    }
}

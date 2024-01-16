using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.Connection;
using FreelancerPlatform.Pages;
using MySql.Data.MySqlClient;


namespace FreelancerPlatform.Classes
{
    class Profile
    {
        // the getters and setters for the private attributes
        private string professional_summary;
        private string full_name;
        private string skills;
        private string education_background;
        private string phone_number;
        private string email;
        private string languages;
        private string availability;
        private string payment_terms;
        private string experience;
        private string location;
        private string previous_projects;

        // the getters will be here
        public string ProfessionalSummary { get { return professional_summary; } set { professional_summary = value; } }
        public string Fullname { get { return full_name; } set { full_name = value; } }
        public string Skill { get { return skills; }set { skills = value; } }
        public string EducationBackground { get { return education_background; } set { education_background = value; } }
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Languages { get { return languages; } set { languages = value; } }
        public string Availability { get { return availability; } set { availability = value; } }
        public string PaymentTerms { get { return payment_terms; } set { payment_terms = value; } }
        public string Experience { get { return experience; } set { experience = value; } }
        public string Location { get { return location; } set { location = value; } }
        public string PreviousProjects { get { return previous_projects; } set { previous_projects = value; } }

        // ========function to insert records into the databse here
        public void CreateProfileDetails()
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
                    INSERT INTO profile(professional_summary, full_name, skills, education_background, phone_number, email,
                    languages, availability, payment_terms, experience, location, previous_projects)
                    VALUES('"+professional_summary+"', '"+full_name+"', '"+skills+"', '"+education_background+"', '"+phone_number+"', '"+email+"', '"+languages+"', '"+availability+"', '"+payment_terms+"', '"+experience+"', '"+location+"', '"+previous_projects+"')";
                // running the database query here
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection); // running here
                insertCommand.ExecuteNonQuery(); // running the query here
                MessageBox.Show("profile created successfully".ToUpper());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

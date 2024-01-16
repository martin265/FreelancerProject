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
using FreelancerPlatform.Pages;


namespace FreelancerPlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connection.Connection connection = new Connection.Connection(); // calling the connection class here
            connection.DatabaseConnection();

            //connection.CreateProfileTable();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                CenterPanel.Controls.Clear(); // removing the default controls here
                // creating a new object for the profile form here
                ProfilePage profilePage = new ProfilePage();
                // removing the top level capability
                profilePage.TopLevel = false;
                // adding controls to the main window here
                CenterPanel.Controls.Add(profilePage);
                // showing the page on the panel here
                profilePage.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                CenterPanel.Controls.Clear(); // removing the default controls here
                // creating a new object for the profile form here
                AvailableProjects availableProjects = new AvailableProjects();
                // removing the top level capability
                availableProjects.TopLevel = false;
                // adding controls to the main window here
                CenterPanel.Controls.Add(availableProjects);
                // showing the page on the panel here
                availableProjects.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnManageProjects_Click(object sender, EventArgs e)
        {
            try
            {
                CenterPanel.Controls.Clear(); // removing the default controls here
                // creating a new object for the profile form here
                OnGoingProjects onGoingProjects = new OnGoingProjects();
                // removing the top level capability
                onGoingProjects.TopLevel = false;
                // adding controls to the main window here
                CenterPanel.Controls.Add(onGoingProjects);
                // showing the page on the panel here
                onGoingProjects.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CenterPanel.Controls.Clear(); // removing the default controls here
                // creating a new object for the profile form here
                OnGoingProjects onGoingProjects = new OnGoingProjects();
                // removing the top level capability
                onGoingProjects.TopLevel = false;
                // adding controls to the main window here
                CenterPanel.Controls.Add(onGoingProjects);
                // showing the page on the panel here
                onGoingProjects.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnCloseSystem_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

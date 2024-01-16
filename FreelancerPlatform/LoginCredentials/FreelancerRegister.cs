using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreelancerPlatform.Classes;


namespace FreelancerPlatform.LoginCredentials
{
    public partial class FreelancerRegister : Form
    {
        public FreelancerRegister()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Freelancer freelancer = new Freelancer();
                freelancer.Username = txtUsername.Text;
                freelancer.Password = txtPassword.Text;

                // =============== calling the register function here
                freelancer.RegisterFreelancer();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

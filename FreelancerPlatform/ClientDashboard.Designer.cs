namespace FreelancerPlatform
{
    partial class ClientDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.btnViewFreelancer = new System.Windows.Forms.Button();
            this.btnViewProfileDetails = new System.Windows.Forms.Button();
            this.btnCompletedProjects = new System.Windows.Forms.Button();
            this.ClientCenterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPostProject = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfile.Location = new System.Drawing.Point(12, 348);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(198, 69);
            this.btnCreateProfile.TabIndex = 0;
            this.btnCreateProfile.Text = "Create Profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.BtnCreateProfile_Click);
            // 
            // btnViewFreelancer
            // 
            this.btnViewFreelancer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFreelancer.Location = new System.Drawing.Point(12, 417);
            this.btnViewFreelancer.Name = "btnViewFreelancer";
            this.btnViewFreelancer.Size = new System.Drawing.Size(198, 69);
            this.btnViewFreelancer.TabIndex = 1;
            this.btnViewFreelancer.Text = "View Freelancers";
            this.btnViewFreelancer.UseVisualStyleBackColor = true;
            this.btnViewFreelancer.Click += new System.EventHandler(this.BtnViewFreelancer_Click);
            // 
            // btnViewProfileDetails
            // 
            this.btnViewProfileDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfileDetails.Location = new System.Drawing.Point(12, 486);
            this.btnViewProfileDetails.Name = "btnViewProfileDetails";
            this.btnViewProfileDetails.Size = new System.Drawing.Size(198, 69);
            this.btnViewProfileDetails.TabIndex = 2;
            this.btnViewProfileDetails.Text = "View Profile Details";
            this.btnViewProfileDetails.UseVisualStyleBackColor = true;
            this.btnViewProfileDetails.Click += new System.EventHandler(this.BtnViewProfileDetails_Click);
            // 
            // btnCompletedProjects
            // 
            this.btnCompletedProjects.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletedProjects.Location = new System.Drawing.Point(12, 555);
            this.btnCompletedProjects.Name = "btnCompletedProjects";
            this.btnCompletedProjects.Size = new System.Drawing.Size(198, 69);
            this.btnCompletedProjects.TabIndex = 3;
            this.btnCompletedProjects.Text = "Completed Projects";
            this.btnCompletedProjects.UseVisualStyleBackColor = true;
            this.btnCompletedProjects.Click += new System.EventHandler(this.BtnCompletedProjects_Click);
            // 
            // ClientCenterPanel
            // 
            this.ClientCenterPanel.AutoScroll = true;
            this.ClientCenterPanel.Location = new System.Drawing.Point(216, 12);
            this.ClientCenterPanel.Name = "ClientCenterPanel";
            this.ClientCenterPanel.Size = new System.Drawing.Size(1089, 676);
            this.ClientCenterPanel.TabIndex = 4;
            // 
            // btnPostProject
            // 
            this.btnPostProject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostProject.Location = new System.Drawing.Point(12, 279);
            this.btnPostProject.Name = "btnPostProject";
            this.btnPostProject.Size = new System.Drawing.Size(198, 69);
            this.btnPostProject.TabIndex = 5;
            this.btnPostProject.Text = "Post Project";
            this.btnPostProject.UseVisualStyleBackColor = true;
            this.btnPostProject.Click += new System.EventHandler(this.BtnPostProject_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FreelancerPlatform.Properties.Resources.influencer;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPostProject);
            this.Controls.Add(this.ClientCenterPanel);
            this.Controls.Add(this.btnCompletedProjects);
            this.Controls.Add(this.btnViewProfileDetails);
            this.Controls.Add(this.btnViewFreelancer);
            this.Controls.Add(this.btnCreateProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDashboard";
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Button btnViewFreelancer;
        private System.Windows.Forms.Button btnViewProfileDetails;
        private System.Windows.Forms.Button btnCompletedProjects;
        private System.Windows.Forms.FlowLayoutPanel ClientCenterPanel;
        private System.Windows.Forms.Button btnPostProject;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
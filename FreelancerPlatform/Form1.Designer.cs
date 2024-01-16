namespace FreelancerPlatform
{
    partial class Form1
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.btnCloseSystem = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Location = new System.Drawing.Point(12, 251);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(166, 77);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Available Projects";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnManageProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProjects.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageProjects.Location = new System.Drawing.Point(12, 405);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(166, 77);
            this.btnManageProjects.TabIndex = 1;
            this.btnManageProjects.Text = "Manage Projects";
            this.btnManageProjects.UseVisualStyleBackColor = false;
            this.btnManageProjects.Click += new System.EventHandler(this.BtnManageProjects_Click);
            // 
            // btnCloseSystem
            // 
            this.btnCloseSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.btnCloseSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSystem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseSystem.Location = new System.Drawing.Point(12, 482);
            this.btnCloseSystem.Name = "btnCloseSystem";
            this.btnCloseSystem.Size = new System.Drawing.Size(166, 77);
            this.btnCloseSystem.TabIndex = 1;
            this.btnCloseSystem.Text = "Close Systen";
            this.btnCloseSystem.UseVisualStyleBackColor = false;
            this.btnCloseSystem.Click += new System.EventHandler(this.BtnCloseSystem_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.AutoScroll = true;
            this.CenterPanel.Location = new System.Drawing.Point(184, 12);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1116, 676);
            this.CenterPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FreelancerPlatform.Properties.Resources.influencer;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.btnCloseSystem);
            this.Controls.Add(this.btnManageProjects);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnManageProjects;
        private System.Windows.Forms.Button btnCloseSystem;
        private System.Windows.Forms.FlowLayoutPanel CenterPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


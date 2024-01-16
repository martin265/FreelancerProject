namespace FreelancerPlatform.LoginCredentials
{
    partial class MainWindow
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
            this.btnFreelancer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetupDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFreelancer
            // 
            this.btnFreelancer.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreelancer.Location = new System.Drawing.Point(134, 237);
            this.btnFreelancer.Name = "btnFreelancer";
            this.btnFreelancer.Size = new System.Drawing.Size(362, 230);
            this.btnFreelancer.TabIndex = 0;
            this.btnFreelancer.Text = "Freelancer";
            this.btnFreelancer.UseVisualStyleBackColor = true;
            this.btnFreelancer.Click += new System.EventHandler(this.BtnFreelancer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(645, 237);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(362, 230);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Freelancer Platform";
            // 
            // btnSetupDatabase
            // 
            this.btnSetupDatabase.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupDatabase.Location = new System.Drawing.Point(379, 97);
            this.btnSetupDatabase.Name = "btnSetupDatabase";
            this.btnSetupDatabase.Size = new System.Drawing.Size(380, 91);
            this.btnSetupDatabase.TabIndex = 3;
            this.btnSetupDatabase.Text = "Setup Database";
            this.btnSetupDatabase.UseVisualStyleBackColor = true;
            this.btnSetupDatabase.Click += new System.EventHandler(this.BtnSetupDatabase_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 479);
            this.Controls.Add(this.btnSetupDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnFreelancer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFreelancer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetupDatabase;
    }
}
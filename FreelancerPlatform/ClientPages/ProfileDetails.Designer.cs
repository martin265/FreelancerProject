namespace FreelancerPlatform.ClientPages
{
    partial class ProfileDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClientProfileDetails = new System.Windows.Forms.DataGridView();
            this.btnRefreshDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientProfileDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Details";
            // 
            // ClientProfileDetails
            // 
            this.ClientProfileDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientProfileDetails.Location = new System.Drawing.Point(12, 90);
            this.ClientProfileDetails.Name = "ClientProfileDetails";
            this.ClientProfileDetails.Size = new System.Drawing.Size(1065, 491);
            this.ClientProfileDetails.TabIndex = 1;
            this.ClientProfileDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientProfileDetails_CellClick);
            this.ClientProfileDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientProfileDetails_CellContentClick);
            // 
            // btnRefreshDetails
            // 
            this.btnRefreshDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDetails.Location = new System.Drawing.Point(835, 606);
            this.btnRefreshDetails.Name = "btnRefreshDetails";
            this.btnRefreshDetails.Size = new System.Drawing.Size(242, 58);
            this.btnRefreshDetails.TabIndex = 2;
            this.btnRefreshDetails.Text = "Refresh Details";
            this.btnRefreshDetails.UseVisualStyleBackColor = true;
            // 
            // ProfileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 676);
            this.Controls.Add(this.btnRefreshDetails);
            this.Controls.Add(this.ClientProfileDetails);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileDetails";
            ((System.ComponentModel.ISupportInitialize)(this.ClientProfileDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientProfileDetails;
        private System.Windows.Forms.Button btnRefreshDetails;
    }
}
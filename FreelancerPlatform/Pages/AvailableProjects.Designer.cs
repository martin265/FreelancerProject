namespace FreelancerPlatform.Pages
{
    partial class AvailableProjects
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
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrowseProjects = new System.Windows.Forms.ComboBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectType = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.ProjectDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBiddingPrice = new System.Windows.Forms.TextBox();
            this.btnBidProject = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.BidingDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BidingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(12, 136);
            this.txtProjectTitle.Multiline = true;
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(528, 59);
            this.txtProjectTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse And Bid on Projects";
            // 
            // cmbBrowseProjects
            // 
            this.cmbBrowseProjects.FormattingEnabled = true;
            this.cmbBrowseProjects.Location = new System.Drawing.Point(302, 82);
            this.cmbBrowseProjects.Name = "cmbBrowseProjects";
            this.cmbBrowseProjects.Size = new System.Drawing.Size(453, 21);
            this.cmbBrowseProjects.TabIndex = 2;
            this.cmbBrowseProjects.SelectedIndexChanged += new System.EventHandler(this.CmbBrowseProjects_SelectedIndexChanged);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(576, 136);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(528, 59);
            this.txtProjectDescription.TabIndex = 0;
            // 
            // txtProjectType
            // 
            this.txtProjectType.Location = new System.Drawing.Point(12, 234);
            this.txtProjectType.Multiline = true;
            this.txtProjectType.Name = "txtProjectType";
            this.txtProjectType.Size = new System.Drawing.Size(528, 59);
            this.txtProjectType.TabIndex = 3;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(576, 234);
            this.txtBudget.Multiline = true;
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(528, 59);
            this.txtBudget.TabIndex = 4;
            // 
            // dateStartDate
            // 
            this.dateStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStartDate.Location = new System.Drawing.Point(12, 330);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(528, 38);
            this.dateStartDate.TabIndex = 5;
            // 
            // ProjectDeadline
            // 
            this.ProjectDeadline.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDeadline.Location = new System.Drawing.Point(576, 325);
            this.ProjectDeadline.Name = "ProjectDeadline";
            this.ProjectDeadline.Size = new System.Drawing.Size(528, 43);
            this.ProjectDeadline.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Browse Projects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Project Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Budget";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Project Deadline";
            // 
            // txtBiddingPrice
            // 
            this.txtBiddingPrice.Location = new System.Drawing.Point(15, 404);
            this.txtBiddingPrice.Multiline = true;
            this.txtBiddingPrice.Name = "txtBiddingPrice";
            this.txtBiddingPrice.Size = new System.Drawing.Size(528, 59);
            this.txtBiddingPrice.TabIndex = 14;
            // 
            // btnBidProject
            // 
            this.btnBidProject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBidProject.Location = new System.Drawing.Point(576, 404);
            this.btnBidProject.Name = "btnBidProject";
            this.btnBidProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBidProject.Size = new System.Drawing.Size(197, 59);
            this.btnBidProject.TabIndex = 15;
            this.btnBidProject.Text = "Bid Project";
            this.btnBidProject.UseVisualStyleBackColor = true;
            this.btnBidProject.Click += new System.EventHandler(this.BtnBidProject_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(907, 404);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(197, 59);
            this.btnClearFields.TabIndex = 15;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            // 
            // BidingDataGridView
            // 
            this.BidingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BidingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BidingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BidingDataGridView.Location = new System.Drawing.Point(15, 478);
            this.BidingDataGridView.Name = "BidingDataGridView";
            this.BidingDataGridView.Size = new System.Drawing.Size(1089, 225);
            this.BidingDataGridView.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(907, 709);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(197, 67);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bidding Price";
            // 
            // AvailableProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 788);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.BidingDataGridView);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnBidProject);
            this.Controls.Add(this.txtBiddingPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectDeadline);
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtProjectType);
            this.Controls.Add(this.cmbBrowseProjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtProjectTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvailableProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvailableProjects";
            ((System.ComponentModel.ISupportInitialize)(this.BidingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrowseProjects;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectType;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.DateTimePicker ProjectDeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBiddingPrice;
        private System.Windows.Forms.Button btnBidProject;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.DataGridView BidingDataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label9;
    }
}
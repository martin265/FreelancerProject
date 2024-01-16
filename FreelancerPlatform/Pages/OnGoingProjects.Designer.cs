namespace FreelancerPlatform.Pages
{
    partial class OnGoingProjects
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AllProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRfreshProjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllProjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "manage Projects";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(547, 50);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AllProjectsDataGridView
            // 
            this.AllProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProjectsDataGridView.Location = new System.Drawing.Point(12, 150);
            this.AllProjectsDataGridView.Name = "AllProjectsDataGridView";
            this.AllProjectsDataGridView.Size = new System.Drawing.Size(1065, 438);
            this.AllProjectsDataGridView.TabIndex = 2;
            this.AllProjectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllProjectsDataGridView_CellContentClick);
            // 
            // btnRfreshProjects
            // 
            this.btnRfreshProjects.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRfreshProjects.Location = new System.Drawing.Point(839, 603);
            this.btnRfreshProjects.Name = "btnRfreshProjects";
            this.btnRfreshProjects.Size = new System.Drawing.Size(238, 61);
            this.btnRfreshProjects.TabIndex = 3;
            this.btnRfreshProjects.Text = "Refresh Projects";
            this.btnRfreshProjects.UseVisualStyleBackColor = true;
            // 
            // OnGoingProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 676);
            this.Controls.Add(this.btnRfreshProjects);
            this.Controls.Add(this.AllProjectsDataGridView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OnGoingProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnGoingProjects";
            this.Load += new System.EventHandler(this.OnGoingProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllProjectsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView AllProjectsDataGridView;
        private System.Windows.Forms.Button btnRfreshProjects;
    }
}
namespace WindowsFormsApp1
{
    partial class AdminPanel
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
            this.return_btn = new System.Windows.Forms.Button();
            this.employee_add = new System.Windows.Forms.Button();
            this.project_add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Open_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(664, 41);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(124, 23);
            this.return_btn.TabIndex = 0;
            this.return_btn.Text = "Return to Login Form";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // employee_add
            // 
            this.employee_add.Location = new System.Drawing.Point(664, 387);
            this.employee_add.Name = "employee_add";
            this.employee_add.Size = new System.Drawing.Size(115, 51);
            this.employee_add.TabIndex = 1;
            this.employee_add.Text = "Add Employee";
            this.employee_add.UseVisualStyleBackColor = true;
            this.employee_add.Click += new System.EventHandler(this.employee_add_Click);
            // 
            // project_add
            // 
            this.project_add.Location = new System.Drawing.Point(543, 387);
            this.project_add.Name = "project_add";
            this.project_add.Size = new System.Drawing.Size(103, 51);
            this.project_add.TabIndex = 2;
            this.project_add.Text = "Add Project";
            this.project_add.UseVisualStyleBackColor = true;
            this.project_add.Click += new System.EventHandler(this.project_add_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 369);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Project Name";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Path";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Added By";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Recent Changes";
            this.columnHeader4.Width = 98;
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(419, 387);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(109, 51);
            this.Open_btn.TabIndex = 4;
            this.Open_btn.Text = "Open Project";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(308, 387);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(105, 51);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete Project";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(664, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(124, 23);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.project_add);
            this.Controls.Add(this.employee_add);
            this.Controls.Add(this.return_btn);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button employee_add;
        private System.Windows.Forms.Button project_add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}
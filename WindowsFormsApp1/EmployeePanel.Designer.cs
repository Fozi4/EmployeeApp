namespace WindowsFormsApp1
{
    partial class EmployeePanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.exit_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.opn_btn = new System.Windows.Forms.Button();
            this.status_btn = new System.Windows.Forms.Button();
            this.myTasks_checkBox = new System.Windows.Forms.CheckBox();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opn_tsk_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(647, 376);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(677, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(111, 27);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(677, 46);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(111, 23);
            this.return_btn.TabIndex = 2;
            this.return_btn.Text = "Return To Login ";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // opn_btn
            // 
            this.opn_btn.Location = new System.Drawing.Point(361, 394);
            this.opn_btn.Name = "opn_btn";
            this.opn_btn.Size = new System.Drawing.Size(99, 44);
            this.opn_btn.TabIndex = 3;
            this.opn_btn.Text = "Open Project";
            this.opn_btn.UseVisualStyleBackColor = true;
            this.opn_btn.Click += new System.EventHandler(this.opn_btn_Click);
            // 
            // status_btn
            // 
            this.status_btn.Location = new System.Drawing.Point(569, 394);
            this.status_btn.Name = "status_btn";
            this.status_btn.Size = new System.Drawing.Size(90, 44);
            this.status_btn.TabIndex = 4;
            this.status_btn.Text = "Project Status";
            this.status_btn.UseVisualStyleBackColor = true;
            this.status_btn.Click += new System.EventHandler(this.status_btn_Click);
            // 
            // myTasks_checkBox
            // 
            this.myTasks_checkBox.AutoSize = true;
            this.myTasks_checkBox.Location = new System.Drawing.Point(669, 92);
            this.myTasks_checkBox.Name = "myTasks_checkBox";
            this.myTasks_checkBox.Size = new System.Drawing.Size(119, 17);
            this.myTasks_checkBox.TabIndex = 5;
            this.myTasks_checkBox.Text = "Show only my tasks";
            this.myTasks_checkBox.UseVisualStyleBackColor = true;
            this.myTasks_checkBox.CheckedChanged += new System.EventHandler(this.myTasks_checkBox_CheckedChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Project Name";
            this.columnHeader13.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Added By";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Recent Changes";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Assigned To";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            // 
            // opn_tsk_btn
            // 
            this.opn_tsk_btn.Location = new System.Drawing.Point(466, 395);
            this.opn_tsk_btn.Name = "opn_tsk_btn";
            this.opn_tsk_btn.Size = new System.Drawing.Size(97, 43);
            this.opn_tsk_btn.TabIndex = 6;
            this.opn_tsk_btn.Text = "Open Task";
            this.opn_tsk_btn.UseVisualStyleBackColor = true;
            this.opn_tsk_btn.Click += new System.EventHandler(this.opn_tsk_btn_Click);
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opn_tsk_btn);
            this.Controls.Add(this.myTasks_checkBox);
            this.Controls.Add(this.status_btn);
            this.Controls.Add(this.opn_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.listView1);
            this.Name = "EmployeePanel";
            this.Text = "EmployeePanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button opn_btn;
        private System.Windows.Forms.Button status_btn;
        private System.Windows.Forms.CheckBox myTasks_checkBox;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button opn_tsk_btn;
    }
}
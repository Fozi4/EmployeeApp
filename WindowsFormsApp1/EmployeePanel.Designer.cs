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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exit_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.opn_btn = new System.Windows.Forms.Button();
            this.mark_btn = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(647, 376);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Project Name";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Added by";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Task";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(677, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(111, 27);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(677, 46);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(111, 23);
            this.return_btn.TabIndex = 2;
            this.return_btn.Text = "Return To Login ";
            this.return_btn.UseVisualStyleBackColor = true;
            // 
            // opn_btn
            // 
            this.opn_btn.Location = new System.Drawing.Point(464, 394);
            this.opn_btn.Name = "opn_btn";
            this.opn_btn.Size = new System.Drawing.Size(99, 44);
            this.opn_btn.TabIndex = 3;
            this.opn_btn.Text = "Open Project";
            this.opn_btn.UseVisualStyleBackColor = true;
            // 
            // mark_btn
            // 
            this.mark_btn.Location = new System.Drawing.Point(569, 394);
            this.mark_btn.Name = "mark_btn";
            this.mark_btn.Size = new System.Drawing.Size(90, 44);
            this.mark_btn.TabIndex = 4;
            this.mark_btn.Text = "Mark as Done";
            this.mark_btn.UseVisualStyleBackColor = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 72;
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mark_btn);
            this.Controls.Add(this.opn_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.listView1);
            this.Name = "EmployeePanel";
            this.Text = "EmployeePanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button opn_btn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button mark_btn;
    }
}
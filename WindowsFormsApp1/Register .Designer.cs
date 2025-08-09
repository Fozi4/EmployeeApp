namespace WindowsFormsApp1
{
    partial class Register
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
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.code_txtBox = new System.Windows.Forms.TextBox();
            this.login_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adm_code_lbl = new System.Windows.Forms.Label();
            this.comboBoxRegisterAs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(116, 84);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(154, 20);
            this.password_txtBox.TabIndex = 0;
            // 
            // code_txtBox
            // 
            this.code_txtBox.Location = new System.Drawing.Point(347, 215);
            this.code_txtBox.Name = "code_txtBox";
            this.code_txtBox.Size = new System.Drawing.Size(100, 20);
            this.code_txtBox.TabIndex = 1;
            this.code_txtBox.Visible = false;
            // 
            // login_txtBox
            // 
            this.login_txtBox.Location = new System.Drawing.Point(116, 52);
            this.login_txtBox.Name = "login_txtBox";
            this.login_txtBox.Size = new System.Drawing.Size(154, 20);
            this.login_txtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // adm_code_lbl
            // 
            this.adm_code_lbl.AutoSize = true;
            this.adm_code_lbl.Location = new System.Drawing.Point(231, 218);
            this.adm_code_lbl.Name = "adm_code_lbl";
            this.adm_code_lbl.Size = new System.Drawing.Size(110, 13);
            this.adm_code_lbl.TabIndex = 5;
            this.adm_code_lbl.Text = "Admin Code Required";
            this.adm_code_lbl.Visible = false;
            // 
            // comboBoxRegisterAs
            // 
            this.comboBoxRegisterAs.FormattingEnabled = true;
            this.comboBoxRegisterAs.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.comboBoxRegisterAs.Location = new System.Drawing.Point(116, 110);
            this.comboBoxRegisterAs.Name = "comboBoxRegisterAs";
            this.comboBoxRegisterAs.Size = new System.Drawing.Size(154, 21);
            this.comboBoxRegisterAs.TabIndex = 6;
            this.comboBoxRegisterAs.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegisterAs_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Register As";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(194, 138);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.Location = new System.Drawing.Point(372, 12);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(75, 23);
            this.ext_btn.TabIndex = 9;
            this.ext_btn.Text = "Exit";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 247);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRegisterAs);
            this.Controls.Add(this.adm_code_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_txtBox);
            this.Controls.Add(this.code_txtBox);
            this.Controls.Add(this.password_txtBox);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.TextBox code_txtBox;
        private System.Windows.Forms.TextBox login_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adm_code_lbl;
        private System.Windows.Forms.ComboBox comboBoxRegisterAs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button ext_btn;
    }
}
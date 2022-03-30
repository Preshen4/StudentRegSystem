
namespace StudentSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbStudentNumber = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.cmbYearOfReg = new System.Windows.Forms.ComboBox();
            this.chkbModules = new System.Windows.Forms.CheckedListBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkRepeatModules = new System.Windows.Forms.CheckBox();
            this.cmbGroupRepeat = new System.Windows.Forms.ComboBox();
            this.chkbModulesRepeat = new System.Windows.Forms.CheckedListBox();
            this.cmbYearRepeat = new System.Windows.Forms.ComboBox();
            this.btnRepeatModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "STUDENT NUMBER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(238, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "FIRST NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(238, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "LAST NAME:";
            // 
            // txtbStudentNumber
            // 
            this.txtbStudentNumber.Location = new System.Drawing.Point(24, 116);
            this.txtbStudentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbStudentNumber.Name = "txtbStudentNumber";
            this.txtbStudentNumber.Size = new System.Drawing.Size(162, 23);
            this.txtbStudentNumber.TabIndex = 6;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(238, 116);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(162, 23);
            this.txtbPassword.TabIndex = 7;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(24, 179);
            this.txtbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(162, 23);
            this.txtbFirstName.TabIndex = 8;
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(238, 179);
            this.txtbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(162, 23);
            this.txtbLastName.TabIndex = 9;
            // 
            // cmbYearOfReg
            // 
            this.cmbYearOfReg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbYearOfReg.FormattingEnabled = true;
            this.cmbYearOfReg.Items.AddRange(new object[] {
            "HIGHER CERTIFICATE",
            "BCA 1",
            "BCA 2",
            "BCA 3",
            "POST GRADUATION"});
            this.cmbYearOfReg.Location = new System.Drawing.Point(24, 267);
            this.cmbYearOfReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYearOfReg.Name = "cmbYearOfReg";
            this.cmbYearOfReg.Size = new System.Drawing.Size(162, 28);
            this.cmbYearOfReg.TabIndex = 10;
            this.cmbYearOfReg.Text = "YEAR OF REGISTER";
            this.cmbYearOfReg.SelectedIndexChanged += new System.EventHandler(this.cmbYearOfReg_SelectedIndexChanged);
            // 
            // chkbModules
            // 
            this.chkbModules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbModules.FormattingEnabled = true;
            this.chkbModules.Items.AddRange(new object[] {
            ""});
            this.chkbModules.Location = new System.Drawing.Point(24, 319);
            this.chkbModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModules.Name = "chkbModules";
            this.chkbModules.Size = new System.Drawing.Size(189, 172);
            this.chkbModules.TabIndex = 11;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "GROUP 1",
            "GROUP 2",
            "GROUP 3"});
            this.cmbGroup.Location = new System.Drawing.Point(24, 512);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(162, 28);
            this.cmbGroup.TabIndex = 12;
            this.cmbGroup.Text = "GROUP";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(24, 573);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 31);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkRepeatModules
            // 
            this.chkRepeatModules.AutoSize = true;
            this.chkRepeatModules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRepeatModules.Location = new System.Drawing.Point(24, 227);
            this.chkRepeatModules.Name = "chkRepeatModules";
            this.chkRepeatModules.Size = new System.Drawing.Size(158, 25);
            this.chkRepeatModules.TabIndex = 14;
            this.chkRepeatModules.Text = "REPEAT MODULES";
            this.chkRepeatModules.UseVisualStyleBackColor = true;
            this.chkRepeatModules.CheckedChanged += new System.EventHandler(this.chkRepeatModules_CheckedChanged);
            // 
            // cmbGroupRepeat
            // 
            this.cmbGroupRepeat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGroupRepeat.FormattingEnabled = true;
            this.cmbGroupRepeat.Items.AddRange(new object[] {
            "GROUP 1",
            "GROUP 2",
            "GROUP 3"});
            this.cmbGroupRepeat.Location = new System.Drawing.Point(238, 512);
            this.cmbGroupRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGroupRepeat.Name = "cmbGroupRepeat";
            this.cmbGroupRepeat.Size = new System.Drawing.Size(162, 28);
            this.cmbGroupRepeat.TabIndex = 17;
            this.cmbGroupRepeat.Text = "GROUP";
            this.cmbGroupRepeat.Visible = false;
            // 
            // chkbModulesRepeat
            // 
            this.chkbModulesRepeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbModulesRepeat.FormattingEnabled = true;
            this.chkbModulesRepeat.Items.AddRange(new object[] {
            ""});
            this.chkbModulesRepeat.Location = new System.Drawing.Point(238, 319);
            this.chkbModulesRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModulesRepeat.Name = "chkbModulesRepeat";
            this.chkbModulesRepeat.Size = new System.Drawing.Size(189, 172);
            this.chkbModulesRepeat.TabIndex = 16;
            this.chkbModulesRepeat.Visible = false;
            // 
            // cmbYearRepeat
            // 
            this.cmbYearRepeat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbYearRepeat.FormattingEnabled = true;
            this.cmbYearRepeat.Items.AddRange(new object[] {
            "HIGHER CERTIFICATE",
            "BCA 1",
            "BCA 2",
            "BCA 3",
            "POST GRADUATION"});
            this.cmbYearRepeat.Location = new System.Drawing.Point(238, 267);
            this.cmbYearRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYearRepeat.Name = "cmbYearRepeat";
            this.cmbYearRepeat.Size = new System.Drawing.Size(162, 28);
            this.cmbYearRepeat.TabIndex = 15;
            this.cmbYearRepeat.Text = "YEAR OF REGISTER";
            this.cmbYearRepeat.Visible = false;
            this.cmbYearRepeat.SelectedIndexChanged += new System.EventHandler(this.cmbYearRepeat_SelectedIndexChanged);
            // 
            // btnRepeatModules
            // 
            this.btnRepeatModules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRepeatModules.Location = new System.Drawing.Point(238, 573);
            this.btnRepeatModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRepeatModules.Name = "btnRepeatModules";
            this.btnRepeatModules.Size = new System.Drawing.Size(162, 31);
            this.btnRepeatModules.TabIndex = 18;
            this.btnRepeatModules.Text = "REGISTER REPEAT MODULES";
            this.btnRepeatModules.UseVisualStyleBackColor = true;
            this.btnRepeatModules.Click += new System.EventHandler(this.btnRepeatModules_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 643);
            this.Controls.Add(this.btnRepeatModules);
            this.Controls.Add(this.cmbGroupRepeat);
            this.Controls.Add(this.chkbModulesRepeat);
            this.Controls.Add(this.cmbYearRepeat);
            this.Controls.Add(this.chkRepeatModules);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.chkbModules);
            this.Controls.Add(this.cmbYearOfReg);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.txtbFirstName);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbStudentNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbStudentNumber;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.ComboBox cmbYearOfReg;
        private System.Windows.Forms.CheckedListBox chkbModules;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkRepeatModules;
        private System.Windows.Forms.ComboBox cmbGroupRepeat;
        private System.Windows.Forms.CheckedListBox chkbModulesRepeat;
        private System.Windows.Forms.ComboBox cmbYearRepeat;
        private System.Windows.Forms.Button btnRepeatModules;
    }
}
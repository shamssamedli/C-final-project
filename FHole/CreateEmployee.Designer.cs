namespace FHole
{
    partial class AddCustomer
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
            this.EmployeeCreateName = new System.Windows.Forms.TextBox();
            this.EmployeeCreateSurname = new System.Windows.Forms.TextBox();
            this.EmployeeCreateUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeCreateRoles = new System.Windows.Forms.ComboBox();
            this.EmployeeCreatePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeCreateName
            // 
            this.EmployeeCreateName.Location = new System.Drawing.Point(21, 72);
            this.EmployeeCreateName.Multiline = true;
            this.EmployeeCreateName.Name = "EmployeeCreateName";
            this.EmployeeCreateName.Size = new System.Drawing.Size(200, 38);
            this.EmployeeCreateName.TabIndex = 0;
            this.EmployeeCreateName.TextChanged += new System.EventHandler(this.EmployeeCreateName_TextChanged);
            // 
            // EmployeeCreateSurname
            // 
            this.EmployeeCreateSurname.Location = new System.Drawing.Point(22, 151);
            this.EmployeeCreateSurname.Multiline = true;
            this.EmployeeCreateSurname.Name = "EmployeeCreateSurname";
            this.EmployeeCreateSurname.Size = new System.Drawing.Size(199, 40);
            this.EmployeeCreateSurname.TabIndex = 1;
            // 
            // EmployeeCreateUsername
            // 
            this.EmployeeCreateUsername.Location = new System.Drawing.Point(22, 233);
            this.EmployeeCreateUsername.Multiline = true;
            this.EmployeeCreateUsername.Name = "EmployeeCreateUsername";
            this.EmployeeCreateUsername.Size = new System.Drawing.Size(200, 38);
            this.EmployeeCreateUsername.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 179);
            this.button1.TabIndex = 3;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EmployeeCreateRoles
            // 
            this.EmployeeCreateRoles.FormattingEnabled = true;
            this.EmployeeCreateRoles.Location = new System.Drawing.Point(19, 380);
            this.EmployeeCreateRoles.Name = "EmployeeCreateRoles";
            this.EmployeeCreateRoles.Size = new System.Drawing.Size(200, 21);
            this.EmployeeCreateRoles.TabIndex = 4;
            this.EmployeeCreateRoles.SelectedIndexChanged += new System.EventHandler(this.EmployeeCreateRoles_SelectedIndexChanged);
            // 
            // EmployeeCreatePassword
            // 
            this.EmployeeCreatePassword.Location = new System.Drawing.Point(21, 307);
            this.EmployeeCreatePassword.Multiline = true;
            this.EmployeeCreatePassword.Name = "EmployeeCreatePassword";
            this.EmployeeCreatePassword.PasswordChar = '*';
            this.EmployeeCreatePassword.Size = new System.Drawing.Size(199, 41);
            this.EmployeeCreatePassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Roles";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeCreatePassword);
            this.Controls.Add(this.EmployeeCreateRoles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmployeeCreateUsername);
            this.Controls.Add(this.EmployeeCreateSurname);
            this.Controls.Add(this.EmployeeCreateName);
            this.Name = "AddCustomer";
            this.Text = "CreateEmployee";
            this.Load += new System.EventHandler(this.CreateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeCreateName;
        private System.Windows.Forms.TextBox EmployeeCreateSurname;
        private System.Windows.Forms.TextBox EmployeeCreateUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox EmployeeCreateRoles;
        private System.Windows.Forms.TextBox EmployeeCreatePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
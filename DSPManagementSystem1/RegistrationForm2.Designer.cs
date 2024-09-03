namespace DSPManagementSystem1
{
    partial class RegistrationForm2
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
            this.button2 = new System.Windows.Forms.Button();
            this.signup_btnCreate = new System.Windows.Forms.Button();
            this.signup_showpass = new System.Windows.Forms.CheckBox();
            this.signup_accType = new System.Windows.Forms.ComboBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.signup_conPassword = new System.Windows.Forms.TextBox();
            this.signup_showconpass = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_pnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.signup_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.signup_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(577, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // signup_btnCreate
            // 
            this.signup_btnCreate.BackColor = System.Drawing.Color.Gold;
            this.signup_btnCreate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btnCreate.Location = new System.Drawing.Point(426, 424);
            this.signup_btnCreate.Name = "signup_btnCreate";
            this.signup_btnCreate.Size = new System.Drawing.Size(121, 41);
            this.signup_btnCreate.TabIndex = 19;
            this.signup_btnCreate.Text = "CREATE";
            this.signup_btnCreate.UseVisualStyleBackColor = false;
            this.signup_btnCreate.Click += new System.EventHandler(this.signup_btnCreate_Click);
            // 
            // signup_showpass
            // 
            this.signup_showpass.AutoSize = true;
            this.signup_showpass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showpass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signup_showpass.Location = new System.Drawing.Point(555, 283);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(138, 20);
            this.signup_showpass.TabIndex = 17;
            this.signup_showpass.Text = "Show Password";
            this.signup_showpass.UseVisualStyleBackColor = false;
            this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged_1);
            // 
            // signup_accType
            // 
            this.signup_accType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signup_accType.FormattingEnabled = true;
            this.signup_accType.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.signup_accType.Location = new System.Drawing.Point(22, 201);
            this.signup_accType.Name = "signup_accType";
            this.signup_accType.Size = new System.Drawing.Size(121, 24);
            this.signup_accType.TabIndex = 16;
            this.signup_accType.SelectedIndexChanged += new System.EventHandler(this.signup_accType_SelectedIndexChanged);
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(450, 255);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(243, 22);
            this.signup_password.TabIndex = 14;
            // 
            // signup_userName
            // 
            this.signup_userName.Location = new System.Drawing.Point(22, 130);
            this.signup_userName.Multiline = true;
            this.signup_userName.Name = "signup_userName";
            this.signup_userName.Size = new System.Drawing.Size(243, 22);
            this.signup_userName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(490, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 78);
            this.label2.TabIndex = 13;
            this.label2.Text = "DSPM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(447, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Get Started";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(447, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Retype Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // signup_conPassword
            // 
            this.signup_conPassword.Location = new System.Drawing.Point(450, 344);
            this.signup_conPassword.Multiline = true;
            this.signup_conPassword.Name = "signup_conPassword";
            this.signup_conPassword.PasswordChar = '*';
            this.signup_conPassword.Size = new System.Drawing.Size(243, 22);
            this.signup_conPassword.TabIndex = 14;
            this.signup_conPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // signup_showconpass
            // 
            this.signup_showconpass.AutoSize = true;
            this.signup_showconpass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showconpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showconpass.ForeColor = System.Drawing.Color.White;
            this.signup_showconpass.Location = new System.Drawing.Point(555, 381);
            this.signup_showconpass.Name = "signup_showconpass";
            this.signup_showconpass.Size = new System.Drawing.Size(138, 20);
            this.signup_showconpass.TabIndex = 17;
            this.signup_showconpass.Text = "Show Password";
            this.signup_showconpass.UseVisualStyleBackColor = false;
            this.signup_showconpass.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email";
            // 
            // signup_email
            // 
            this.signup_email.Location = new System.Drawing.Point(22, 276);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(243, 22);
            this.signup_email.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number";
            // 
            // signup_pnum
            // 
            this.signup_pnum.Location = new System.Drawing.Point(22, 344);
            this.signup_pnum.Multiline = true;
            this.signup_pnum.Name = "signup_pnum";
            this.signup_pnum.Size = new System.Drawing.Size(243, 22);
            this.signup_pnum.TabIndex = 14;
            this.signup_pnum.TextChanged += new System.EventHandler(this.signup_pnum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(447, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // signup_address
            // 
            this.signup_address.Location = new System.Drawing.Point(450, 127);
            this.signup_address.Multiline = true;
            this.signup_address.Name = "signup_address";
            this.signup_address.Size = new System.Drawing.Size(243, 74);
            this.signup_address.TabIndex = 14;
            this.signup_address.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Gender";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // signup_gender
            // 
            this.signup_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signup_gender.FormattingEnabled = true;
            this.signup_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.signup_gender.Location = new System.Drawing.Point(22, 413);
            this.signup_gender.Name = "signup_gender";
            this.signup_gender.Size = new System.Drawing.Size(121, 24);
            this.signup_gender.TabIndex = 16;
            this.signup_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // RegistrationForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.signup_btnCreate);
            this.Controls.Add(this.signup_showconpass);
            this.Controls.Add(this.signup_showpass);
            this.Controls.Add(this.signup_gender);
            this.Controls.Add(this.signup_accType);
            this.Controls.Add(this.signup_conPassword);
            this.Controls.Add(this.signup_address);
            this.Controls.Add(this.signup_pnum);
            this.Controls.Add(this.signup_email);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.signup_userName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm2";
            this.Text = "RegistrationForm2";
            this.Load += new System.EventHandler(this.RegistrationForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button signup_btnCreate;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.ComboBox signup_accType;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signup_conPassword;
        private System.Windows.Forms.CheckBox signup_showconpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox signup_pnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox signup_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox signup_gender;
    }
}
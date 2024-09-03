namespace DSPManagementSystem1
{
    partial class frmSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_btnCreate = new System.Windows.Forms.Button();
            this.signup_showconpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signup_showpass = new System.Windows.Forms.CheckBox();
            this.signup_userName = new System.Windows.Forms.TextBox();
            this.signup_conPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signup_btnCreate);
            this.panel1.Controls.Add(this.signup_showconpass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.signup_showpass);
            this.panel1.Controls.Add(this.signup_userName);
            this.panel1.Controls.Add(this.signup_conPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signup_password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(357, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 415);
            this.panel1.TabIndex = 0;
            // 
            // signup_btnCreate
            // 
            this.signup_btnCreate.AutoSize = true;
            this.signup_btnCreate.BackColor = System.Drawing.Color.Crimson;
            this.signup_btnCreate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btnCreate.Location = new System.Drawing.Point(71, 362);
            this.signup_btnCreate.Name = "signup_btnCreate";
            this.signup_btnCreate.Size = new System.Drawing.Size(159, 29);
            this.signup_btnCreate.TabIndex = 26;
            this.signup_btnCreate.Text = "Delete Account";
            this.signup_btnCreate.UseVisualStyleBackColor = false;
            this.signup_btnCreate.Click += new System.EventHandler(this.signup_btnCreate_Click);
            // 
            // signup_showconpass
            // 
            this.signup_showconpass.AutoSize = true;
            this.signup_showconpass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showconpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showconpass.ForeColor = System.Drawing.Color.White;
            this.signup_showconpass.Location = new System.Drawing.Point(133, 316);
            this.signup_showconpass.Name = "signup_showconpass";
            this.signup_showconpass.Size = new System.Drawing.Size(138, 20);
            this.signup_showconpass.TabIndex = 24;
            this.signup_showconpass.Text = "Show Password";
            this.signup_showconpass.UseVisualStyleBackColor = false;
            this.signup_showconpass.CheckedChanged += new System.EventHandler(this.signup_showconpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Delete Account";
            // 
            // signup_showpass
            // 
            this.signup_showpass.AutoSize = true;
            this.signup_showpass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showpass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signup_showpass.Location = new System.Drawing.Point(133, 218);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(138, 20);
            this.signup_showpass.TabIndex = 25;
            this.signup_showpass.Text = "Show Password";
            this.signup_showpass.UseVisualStyleBackColor = false;
            this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged);
            // 
            // signup_userName
            // 
            this.signup_userName.Location = new System.Drawing.Point(28, 103);
            this.signup_userName.Multiline = true;
            this.signup_userName.Name = "signup_userName";
            this.signup_userName.Size = new System.Drawing.Size(243, 22);
            this.signup_userName.TabIndex = 23;
            // 
            // signup_conPassword
            // 
            this.signup_conPassword.Location = new System.Drawing.Point(28, 279);
            this.signup_conPassword.Multiline = true;
            this.signup_conPassword.Name = "signup_conPassword";
            this.signup_conPassword.PasswordChar = '*';
            this.signup_conPassword.Size = new System.Drawing.Size(243, 22);
            this.signup_conPassword.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username";
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(28, 190);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(243, 22);
            this.signup_password.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Retype Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 78);
            this.label2.TabIndex = 14;
            this.label2.Text = "DSPM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSPManagementSystem1.Properties.Resources.engineer;
            this.pictureBox1.Location = new System.Drawing.Point(47, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox signup_showconpass;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.TextBox signup_userName;
        private System.Windows.Forms.TextBox signup_conPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signup_btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
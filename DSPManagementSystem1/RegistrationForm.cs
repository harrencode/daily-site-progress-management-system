using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSPManagementSystem1
{
    public partial class RegistrationForm : Form
    {
        private const string admin = "Administrator";
        private const string user = "User";
        


        public RegistrationForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            login_username.Select();
            this.AcceptButton = null;
        }

        private void button2_Click(object sender, EventArgs e)


        {
            login_username.Text = "";
            login_password.Text= "";
            /*mainDashboard reForm = new mainDashboard();
            reForm.Show();
            this.Hide();*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            

            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);
            


            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill al blank fields", "Error Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM log WHERE username= @username AND password = @password";
                        using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@password", login_password.Text);
                            

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                /* MessageBox.Show("Logged in Succesfully", "Information Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string selectUsername = "SELECT username FROM log WHERE username = @username AND password = @password";
                                
                                using (MySqlCommand cmd2 = new MySqlCommand(selectUsername, connect))
                                {
                                    cmd2.Parameters.AddWithValue("@username", login_username.Text);
                                    cmd2.Parameters.AddWithValue("@password", login_password.Text);
                                    
                                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                                    {
                                        if(reader.Read())
                                        {
                                             string usernamePass = reader["username"].ToString();
                                            
                                        }
                                        
                                        
                                       
                                    }
                                }
                                */


                                string selectAccountType = "SELECT accounttype FROM log WHERE username = @username AND password = @password";
                                using (MySqlCommand cmd1 = new MySqlCommand(selectAccountType, connect))
                                {
                                    cmd1.Parameters.AddWithValue("@username", login_username.Text);
                                    cmd1.Parameters.AddWithValue("@password", login_password.Text);


                                    using (MySqlDataReader reader = cmd.ExecuteReader())
                                        
                                    {
                                        if (reader.Read())
                                        {
                                            string accountType = reader["accounttype"].ToString();
                                            string usernamePass= reader["username"].ToString();
                                            
                                            switch(accountType)
                                            {
                                                case admin:
                                                    MessageBox.Show("You are logged in as an administrator", "Information Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    this.Hide();
                                                    
                                                    mainDashboard mForm = new mainDashboard(accountType,usernamePass);
                                                    mForm.Show();
                                                    

                                                    break;

                                                case user:
                                                    MessageBox.Show("You are logged in as a user", "Information Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    this.Hide();

                                                    mainDashboard mForm2 = new mainDashboard(accountType,usernamePass);
                                                    mForm2.Show();

                                                    /*frmSettings settingsFrm = new frmSettings(usernamePass);
                                                    settingsFrm.Hide();
                                                    RegistrationForm2 regForm = new RegistrationForm2();
                                                    regForm.Hide();*/
                                                    
                                                    break;

                                                




                                                    




                                            }



                                        }
                                        else
                                        {

                                        }



                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void RegistrationForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void login_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               
                login_btn.PerformClick();
            }
        }
    }
}
    

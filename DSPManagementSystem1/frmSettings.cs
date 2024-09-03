using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSPManagementSystem1
{
    public partial class frmSettings : Form
    {

        private string usernamePass;
        public frmSettings(string usernamePass)
        {
            InitializeComponent();
            this.usernamePass = usernamePass;
        }

        private void signup_btnCreate_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);


            if (signup_userName.Text == "" || signup_password.Text == "" || signup_conPassword.Text == "")
            {
                MessageBox.Show("Please fill al blank fields", "Error Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_password.Text != signup_conPassword.Text)
            {
                MessageBox.Show("Password Mismatch", "Error Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            cmd.Parameters.AddWithValue("@username", usernamePass);
                            cmd.Parameters.AddWithValue("@password", signup_password.Text);
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string deletedata = "DELETE FROM log WHERE username IN ('" + signup_userName.Text + "')";
                                MySqlCommand cmd2 = new MySqlCommand(deletedata, connect);
                                cmd2.Parameters.AddWithValue("@username", signup_userName.Text);
                                cmd2.Parameters.AddWithValue("@password", signup_password.Text);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Account Deleted Succesfully", "Information Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                signup_userName.Text = "";
                                signup_password.Text = "";
                                signup_conPassword.Text = "";

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




                    /*connect.Open();

                     string deletedata2 = "DELETE FROM log WHERE username IN ('" + signup_userName.Text + "')";


                     using (MySqlCommand cmd = new MySqlCommand(deletedata2, connect))
                     {



                         cmd.ExecuteNonQuery();


                         MessageBox.Show("Account Deleted Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                         connect.Close();*/
                }
            }
            }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (signup_showpass.Checked)
                {
                    signup_password.PasswordChar = '\0';
                }
                else
                {
                    signup_password.PasswordChar = '*';
                }
            }
        }

        private void signup_showconpass_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (signup_showconpass.Checked)
                {
                    signup_conPassword.PasswordChar = '\0';
                }
                else
                {
                    signup_conPassword.PasswordChar = '*';
                }
            }
        }
    }
    }

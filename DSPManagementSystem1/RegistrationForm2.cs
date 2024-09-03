using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace DSPManagementSystem1
{
    public partial class RegistrationForm2 : Form
    {
        /*SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\OneDrive\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30");*/

        public RegistrationForm2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void RegistrationForm2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup_userName.Text = "";
            signup_accType.Text = "";
            signup_email.Text = "";
            signup_pnum.Text = "";
            signup_gender.Text = "";
            signup_address.Text = "";
            signup_password.Text = "";
            signup_conPassword.Text = "";


        }

        private void signup_btnCreate_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);

            if (signup_email.Text == "" || signup_userName.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM log WHERE username = '" + signup_userName.Text.Trim() + "'";
                        using (MySqlCommand checkUser = new MySqlCommand(checkUsername, connect))
                        {
                            MySqlDataAdapter adapter = new MySqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_userName.Text + "is already exists", "Error Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO log (email,username,password,accounttype,gender,phonenumber,address) " + "VALUES(@email,@username,@password,@accounttype,@gender,@phonenumber,@address)";


                                using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_userName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@accounttype", signup_accType.Text); ;
                                    cmd.Parameters.AddWithValue("@gender", signup_gender.Text); ;
                                    cmd.Parameters.AddWithValue("@phonenumber", signup_pnum.Text.Trim());
                                    cmd.Parameters.AddWithValue("@address", signup_address.Text.Trim());



                                    cmd.ExecuteNonQuery();
                                    if (signup_password.Text == signup_conPassword.Text)
                                    {
                                        MessageBox.Show("Registered Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        signup_userName.Text = "";
                                        signup_accType.Text = "";
                                        signup_email.Text = "";
                                        signup_pnum.Text = "";
                                        signup_gender.Text = "";
                                        signup_address.Text = "";
                                        signup_password.Text = "";
                                        signup_conPassword.Text = "";
                                    }

                                    else
                                    {
                                        MessageBox.Show("Password mismatch", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }

                                    
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }


            }
        }


        

        private void signup_showpass_CheckedChanged_1(object sender, EventArgs e)
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

        private void signup_accType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signup_pnum_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

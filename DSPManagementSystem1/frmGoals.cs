using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace DSPManagementSystem1
{
    public partial class frmGoals : Form
    {

        public frmGoals()
        {
            InitializeComponent();

        }

        private void signup_btnCreate_Click(object sender, EventArgs e)

        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);

            connect.Open();
            String gid = textBox1.Text;
            String desc = textBox2.Text;
            string insertData = "INSERT INTO goals (goalid,description) " + "VALUES(@goalid,@description)";


            using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
            {
                cmd.Parameters.AddWithValue("@goalid", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@description", textBox3.Text.Trim());


                cmd.ExecuteNonQuery();

                MessageBox.Show("Goal Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableDataLoad();
                connect.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);

            connect.Open();


            string selectData = "SELECT COUNT(*) FROM goals WHERE goalid = @goalid";

            using (MySqlCommand cmdSelect = new MySqlCommand(selectData, connect))
            {
                cmdSelect.Parameters.AddWithValue("@goalid", textBox1.Text.Trim());
                int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Goal does not exist.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return;
                }
            }


            string deletedata = "DELETE FROM goals WHERE goalid IN ('" + textBox1.Text + "')";


            using (MySqlCommand cmd = new MySqlCommand(deletedata, connect))
            {



                cmd.ExecuteNonQuery();


                MessageBox.Show("Goal Deleted Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableDataLoad();
                connect.Close();
            }
        }

        private void frmGoals_Load(object sender, EventArgs e)
        {
            TableDataLoad();
        }
        void TableDataLoad()
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";


            using (MySqlConnection connect = new MySqlConnection(cs))
            {
                try
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM dspmsystem1.goals;", connect);
                    DataTable AllDataTable = new DataTable();
                    using (MySqlDataAdapter adaptor = new MySqlDataAdapter(cmd))

                    {
                        adaptor.Fill(AllDataTable);

                    }
                    dataGridView1.DataSource = AllDataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message));
                }
                


            }

    }
            
            
        





        }
            

    }

    
    


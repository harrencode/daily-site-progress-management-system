using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPManagementSystem1
{
    public partial class frmProblems : Form
    {

        public frmProblems()
        {
            InitializeComponent();
        }

        private void signup_btnCreate_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);
            connect.Open();
            String qid = textBox2.Text;
            String problem = textBox3.Text;
            string insertData = "INSERT INTO problems (qid,problem) " + "VALUES(@qid,@problem)";


            using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
            {
                cmd.Parameters.AddWithValue("@qid", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@problem", textBox3.Text.Trim());


                cmd.ExecuteNonQuery();

                MessageBox.Show("Problem Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableDataLoad();
                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);

            connect.Open();
            String qid = textBox1.Text;
            String answer = textBox4.Text;

            string selectData = "SELECT COUNT(*) FROM problems WHERE qid = @qid";

            using (MySqlCommand cmdSelect = new MySqlCommand(selectData, connect))
            {
                cmdSelect.Parameters.AddWithValue("@qid", textBox1.Text.Trim());
                int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Error: qid does not exist.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return;
                }
            }


            string updateData = "UPDATE problems SET answer = @answer WHERE qid = @qid";

            using (MySqlCommand cmd22 = new MySqlCommand(updateData, connect))
            {
                cmd22.Parameters.AddWithValue("@qid", textBox1.Text.Trim());
                cmd22.Parameters.AddWithValue("@answer", textBox4.Text.Trim());


                cmd22.ExecuteNonQuery();

                MessageBox.Show("Answer Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableDataLoad();
                connect.Close();
            }
        }

        private void frmProblems_Load(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM dspmsystem1.problems;", connect);
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

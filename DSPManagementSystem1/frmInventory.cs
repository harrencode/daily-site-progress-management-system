using MySql.Data.MySqlClient;
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

    public partial class frmInventory : Form
    {

        public frmInventory()
        {
            InitializeComponent();
        }

        private void signup_btnCreate_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);
            connect.Open();

            string checkIfExistsQuery = "SELECT COUNT(*) FROM inventory WHERE itemid = @itemid";
            using (var cmdCheck = new MySqlCommand(checkIfExistsQuery, connect))
            {
                cmdCheck.Parameters.AddWithValue("@itemid", textBox1.Text.Trim());
                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Item already exists. Cannot Add", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            String Itemiid = textBox1.Text;
            String name = textBox2.Text;
            String quan = textBox3.Text;
            String desc = textBox5.Text;
            string insertData = "INSERT INTO inventory (itemid,name,quantity,description,date) " + "VALUES(@itemid,@name,@quantity,@description,@date)";
            DateTime date = DateTime.Today;

            using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
            {

                cmd.Parameters.AddWithValue("@Itemid", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@name", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@quantity", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@description", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableDataLoad();
                connect.Close();



            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM dspmsystem1.inventory;", connect);
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                
            }
            else
            {
                MessageBox.Show("Name and Description must be empty.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string cs = @"server=localhost;userid=root;password=admin;database=dspmsystem1";
            var connect = new MySqlConnection(cs);

            connect.Open();
            string updateData = "UPDATE inventory SET quantity = @quantity, date = @date WHERE itemid = @itemid";

            using (var cmd = new MySqlCommand(updateData, connect))
            {
                cmd.Parameters.AddWithValue("@itemid", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@quantity", textBox3.Text.Trim());

                cmd.Parameters.AddWithValue("@date", DateTime.Today);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Inventory Modified Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TableDataLoad();
            connect.Close();
        }


        


    }
    }


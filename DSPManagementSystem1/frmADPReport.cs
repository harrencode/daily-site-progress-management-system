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
    public partial class frmADPReport : Form
    {

        public frmADPReport()
        {
            InitializeComponent();
        }

        private void frmADPReport_Load(object sender, EventArgs e)
        {
            TableDataLoad1();
            TableDataLoad2();
        }
        void TableDataLoad1()
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
        void TableDataLoad2()
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
                    dataGridView2.DataSource = AllDataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message));
                }



            }
        }
    }
}

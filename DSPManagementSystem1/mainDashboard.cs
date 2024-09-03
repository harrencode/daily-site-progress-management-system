using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting.Contexts;

namespace DSPManagementSystem1
{
    public partial class mainDashboard : Form
    {
       
        private string accountType;
        private string usernamePass;
        
        private const string admin = "Administrator";
        private const string user = "User";


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        public mainDashboard(string accountType,string usernamePass)
        {

            InitializeComponent();
            this.accountType = accountType;
            this.usernamePass = usernamePass;
          
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Parent = pictureBox2;
            lblTitle.BackColor = Color.Transparent;
        }



        private void mainDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrationForm rform = new RegistrationForm();
            
            rform.Show();
            
        }
        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
           

        }

        private void btnADPR_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnADPR.Height;
            pnlNav.Top = btnADPR.Top;
            pnlNav.Left = btnADPR.Left;
            btnADPR.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Automated Daily Progress Report";
            this.PnlFormLoader.Controls.Clear();
            frmADPReport frmADPReport_Vrb = new frmADPReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmADPReport_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmADPReport_Vrb);
            frmADPReport_Vrb.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRegistration.Height;
            pnlNav.Top = btnRegistration.Top;
            pnlNav.Left = btnRegistration.Left;
            btnRegistration.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Registration";
            this.PnlFormLoader.Controls.Clear();
            RegistrationForm2 RegistrationForm2_Vrb = new RegistrationForm2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            RegistrationForm2_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(RegistrationForm2_Vrb);
            
            switch (accountType)
            {
                case admin:
                    RegistrationForm2_Vrb.Show();

                    break;
                case user:
                    RegistrationForm2_Vrb.Hide();
                    MessageBox.Show("You need to be an administrator to access this", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    noAccess nacc = new noAccess()  { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    nacc.FormBorderStyle = FormBorderStyle.None;
                    this.PnlFormLoader.Controls.Add(nacc);
                    nacc.Show();
                    break;
            }
                
            

        }





            private void btnGoals_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnGoals.Height;
                pnlNav.Top = btnGoals.Top;
                pnlNav.Left = btnGoals.Left;
                btnGoals.BackColor = Color.FromArgb(46, 51, 73);

                lblTitle.Text = "Goals";
                this.PnlFormLoader.Controls.Clear();
                frmGoals frmGoals_Vrb = new frmGoals() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmGoals_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmGoals_Vrb);
                frmGoals_Vrb.Show();

            }

            private void btnInvetory_Click_1(object sender, EventArgs e)
            {
                pnlNav.Height = btnInvetory.Height;
                pnlNav.Top = btnInvetory.Top;
                pnlNav.Left = btnInvetory.Left;
                btnInvetory.BackColor = Color.FromArgb(46, 51, 73);

                lblTitle.Text = "Inventory";
                this.PnlFormLoader.Controls.Clear();
                frmInventory frmInventory_Vrb = new frmInventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmInventory_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmInventory_Vrb);



                frmInventory_Vrb.Show();

            }

            private void btnProblems_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnProblems.Height;
                pnlNav.Top = btnProblems.Top;
                pnlNav.Left = btnProblems.Left;
                btnProblems.BackColor = Color.FromArgb(46, 51, 73);

                lblTitle.Text = "Problems";
                this.PnlFormLoader.Controls.Clear();
                frmProblems frmProblems_Vrb = new frmProblems() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmProblems_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmProblems_Vrb);
                frmProblems_Vrb.Show();

            }

            private void btnSettings_Click(object sender, EventArgs e)
            {


            pnlNav.Height = btnSettings.Height;
                pnlNav.Top = btnSettings.Top;
                pnlNav.Left = btnSettings.Left;
                btnSettings.BackColor = Color.FromArgb(46, 51, 73);

                lblTitle.Text = "Settings";
                this.PnlFormLoader.Controls.Clear();
                frmSettings frmSettings_Vrb = new frmSettings(usernamePass) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSettings_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmSettings_Vrb);

            switch (accountType)
            {
                case admin:
                    frmSettings_Vrb.Show();
                    break;
                case user:
                    frmSettings_Vrb.Hide();
                    MessageBox.Show("You need to be an administrator to access this", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    noAccess nacc = new noAccess() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    nacc.FormBorderStyle = FormBorderStyle.None;
                    this.PnlFormLoader.Controls.Add(nacc);
                    nacc.Show();
                   


                    break;
            }



            

               
            }

            private void btnDashboard_Leave(object sender, EventArgs e)
            {
                btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void btnRegistration_Leave(object sender, EventArgs e)
            {
                btnRegistration.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void btnADPR_Leave(object sender, EventArgs e)
            {
                btnADPR.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void btnGoals_Leave(object sender, EventArgs e)
            {
                btnGoals.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void btnInvetory_Leave(object sender, EventArgs e)
            {
                btnInvetory.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void btnProblems_Leave(object sender, EventArgs e)
            {
                btnProblems.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void btnSettings_Leave(object sender, EventArgs e)
            {
                btnSettings.BackColor = Color.FromArgb(24, 30, 54);

            }

            private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
            {

            }

            private void lblTitle_Click(object sender, EventArgs e)
            {

            }

        }
    }

    



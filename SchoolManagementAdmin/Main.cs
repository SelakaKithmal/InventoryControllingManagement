using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SATHOSA_ICS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //public frmMain main;

        //string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        //For animated panels direction
        string optionsDirection = "down";
        string toastDirection = "down";
        string rightDirection = "right";

        //For animated panels timeout
        int optionsTimeOut = 0;
        int toastTimeOut = 0;
        int RightTimeOut = 0;

        //For animated panels position
        int optionsX;
        int optionsY;
        int rightX;
        int rightY;

        //method to set fullscreen
        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }

        //method to set the position of the main panel that holds the controls to center of the form.
        public void setMainPanelPosition()
        {
            int mX = (Width - pnlMain.Width) / 2;
            int mY = (Height - pnlMain.Height) / 2;
            pnlMain.Location = new Point(mX, mY);
        }

        //method to set the initial location of the options panel.
        private void setOptionsPanelPosition()
        {
            int x = Width;
            optionsX = 0;
            optionsY = Height + pnlOptions.Height;
            pnlOptions.Size = new Size(x, pnlOptions.Height);
            pnlOptions.Location = new Point(optionsX, optionsY);
            pbHide.Location = new Point(Width - 41, pbHide.Location.Y);
            int mX = (pnlOptions.Width - pnlOptionsMain.Width) / 2;
            int mY = pnlOptionsMain.Location.Y;
            pnlOptionsMain.Location = new Point(mX, mY);
            cmbAcademicYear.Location = new Point(Width - 125, cmbAcademicYear.Location.Y);
            lblAcademicYear.Location = new Point(Width - 226, lblAcademicYear.Location.Y);
        }

        private void setRightOptionsPanelPosition()
        {
            int y = Height;
            rightY = 0;
            rightX = Width + pnlRightOptions.Width;
            pnlRightOptions.Size = new Size(pnlRightOptions.Width, y);
            pnlRightOptions.Location = new Point(rightX, rightY);
            int rX = pnlRightMain.Location.X;
            int rY = (pnlRightOptions.Height - pnlRightMain.Height) / 2;
            pnlRightMain.Location = new Point(rX, rY);
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {            
            setFullScreen();
            setOptionsPanelPosition();
            setRightOptionsPanelPosition();
            setMainPanelPosition();
            Options.Start();
            RightOptions.Start();
            FirstColumn.Start();
            //ShowTime.Start();
            //FirstColumn.Start();
            //SecondColumn.Start();
            //ThirdColumn.Start();
            //string conString = new connect().getConnection();
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //con.Close();
            //string conString = ConfigurationManager.ConnectionStrings["SchoolManagement"].ConnectionString;
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //con.Close();
        }

        private void MasterEntry(object sender, EventArgs e)
        {
            Sales_Invoice NewSales = new Sales_Invoice();

            NewSales.Show();
          
        }

        private void Students(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.Show();
           
            
            
                       
        }

        private void Employees(object sender, EventArgs e)
        {
            Supplier newSupplier = new Supplier();
            newSupplier.Show();
            
        }

        private void Accounts(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "UNDER DEVOLOPMENT", "HOLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Attendance(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "UNDER DEVOLOPMENT", "HOLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Reports(object sender, EventArgs e)
        {
           //MetroFramework.MetroMessageBox.Show(this, "UNDER DEVOLOPMENT", "HOLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            REPORTS newReport = new REPORTS();
            newReport.Show();
          
        }

        private void Transport(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "UNDER DEVOLOPMENT", "HOLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Search(object sender, EventArgs e)
        {

            Products newProduct = new Products();
            newProduct.Show();
        }

        private void Backup(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "UNDER DEVOLOPMENT", "HOLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Restore(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "UNDER DEVOLOPMENT", "HOLD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= Height - 15 && e.X < (Width - pnlRightOptions.Width))
            {
                optionsDirection = "up";
                rightDirection = "right";
                optionsTimeOut = 0;
            }
            if (e.X >= Width - 15)
            {
                rightDirection = "left";
                RightTimeOut = 0;
                optionsDirection = "down";
            }
            if (e.X < (Width - pnlRightOptions.Width))
            {
                rightDirection = "Left";
            }
        }

        private void Options_Tick(object sender, EventArgs e)
        {
            if (optionsTimeOut < 1000)
            {
                optionsTimeOut++;
            }
            if (optionsTimeOut == 1000)
            {
                if (optionsDirection == "up")
                {
                    optionsDirection = "down";
                }
            }
            if (optionsDirection == "up")
            {
                if (optionsY > Height - pnlOptions.Height + 3)
                {
                    optionsY -= 3;
                    pnlOptions.Location = new Point(optionsX, optionsY);
                }
            }
            else
            {
                if (optionsY < Height)
                {
                    optionsY += 3;
                }
                pnlOptions.Location = new Point(optionsX, optionsY);
            }
        }

        private void RightOptions_Tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1000)
            {
                RightTimeOut++;
            }
            if (RightTimeOut == 1000)
            {
                if (rightDirection == "left")
                {
                    rightDirection = "right";
                }
            }
            if (rightDirection == "left")
            {
                if (rightX > Width - pnlRightOptions.Width)
                {
                    rightX -= 2;
                    pnlRightOptions.Location = new Point(rightX, rightY);
                }
            }
            else
            {
                if (rightX < Width)
                {
                    rightX += 2;
                }
                pnlRightOptions.Location = new Point(rightX, rightY);
            }
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            optionsDirection = "down";
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            rightDirection = "right";
        }

        private void FirstColumn_Tick(object sender, EventArgs e)
        {
            if (pnlStudents.BackColor == Color.Crimson)
            {
                pnlStudents.BackColor = Color.Red;
                pnlEmployees.BackColor = Color.Blue;
                pnlMasterEntry.BackColor = Color.DarkOrange;
                pnlAttendance.BackColor = Color.Purple;
                //pnlAccounts.BackColor = Color.Crimson;
            }
            else if( pnlStudents.BackColor==Color.Red)
            {
                pnlStudents.BackColor = Color.Blue;
                pnlEmployees.BackColor = Color.DarkOrange;
                pnlMasterEntry.BackColor = Color.Purple;
                pnlAttendance.BackColor = Color.Crimson;
                //pnlAccounts.BackColor = Color.Red;
            }
            else if (pnlStudents.BackColor == Color.Blue)
            {
                pnlStudents.BackColor = Color.DarkOrange;
                pnlEmployees.BackColor = Color.Purple;
                pnlMasterEntry.BackColor = Color.Crimson;
                pnlAttendance.BackColor = Color.Red;
                //pnlAccounts.BackColor = Color.Blue;
            }
            else if (pnlStudents.BackColor == Color.DarkOrange)
            {
                pnlStudents.BackColor = Color.Purple;
                pnlEmployees.BackColor = Color.Crimson;
                pnlMasterEntry.BackColor = Color.Red;
                pnlAttendance.BackColor = Color.Blue;
                //pnlAccounts.BackColor = Color.DarkOrange;
            }
            else
            {
                pnlStudents.BackColor = Color.Crimson;
                pnlEmployees.BackColor = Color.Red;
                pnlMasterEntry.BackColor = Color.Blue;
                pnlAttendance.BackColor = Color.DarkOrange;
                //pnlAccounts.BackColor = Color.Purple;
            }
        }

        private void lblMainTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlMasterEntry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }
    }
}

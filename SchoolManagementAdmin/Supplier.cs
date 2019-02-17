using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SATHOSA_ICS
{
    public partial class Supplier : MetroForm
    {
        SqlConnection Supplier_Connection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
        public Supplier()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroComboBox2.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = ""; ;
            metroTextBox7.Text = "";
            metroComboBox1.Text = "";
            metroTextBox8.Text = "";
            metroTextBox4.Text = "";
             metroTextBox9.Text= "";
            metroTextBox10.Text= "";
             metroTextBox3.Text= "";
             metroTextBox11.Text= "";
             metroTextBox41.Text= "";
             metroComboBox5.Text= "";
             metroTextBox12.Text= "";
             metroTextBox13.Text= "";
             metroComboBox14.Text= "";
             metroComboBox4.Text = "";

        }

       /* public void Clear2()
        {

            metroComboBox14.Text = "";
            metroTextBox28.Text = "";
            metroTextBox43.Text = "";
            metroTextBox30.Text = "";
            metroTextBox32.Text = "";
            metroTextBox35.Text = "";
            metroTextBox36.Text = "";
            metroComboBox11.SelectedItem = "";
            metroTextBox34.Text = "";
            metroTextBox33.Text = "";
            metroTextBox31.Text = "";
            metroTextBox29.Text = "";
            metroTextBox40.Text = "";
            metroTextBox42.Text = "";
            metroTextBox44.Text = "";
            metroTextBox39.Text = "";
            metroTextBox38.Text = "";
            metroTextBox37.Text = "";
            metroTextBox45.Text = "";



        }*/

        public void insertValues()
        {
            try
            {

                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroComboBox2.Text == "" || metroTextBox5.Text == "" || metroTextBox6.Text == "" || metroTextBox7.Text == "" || metroComboBox1.Text == "" || metroTextBox8.Text == "" || metroTextBox4.Text == "" || metroTextBox9.Text == "" || metroTextBox10.Text == "" || metroComboBox3.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "REQUIRED FIELDS CANNOT BE EMPTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand insert = new SqlCommand();
                    insert.Connection = Supplier_Connection;
                    insert.CommandText = "Execute AddSupplier @Supplier_ID ,@Supplier_Name ,@NIC ,@Gender ,@DOB ,@Contact_Number ,@Email ,@Payment_Methods,@Supplier_Address_Line1 ,@Supplier_Address_Line2,@Supplier_City ,@Zip_Code ,@Product_ID ,@Company_Name ,@WH_Address ,@Delivery_Method ,@VAT_No ,@Company_Contact,@Credit_Limit,@Interest_Rates";
                    insert.Parameters.AddWithValue("@Supplier_ID", metroTextBox1.Text);
                    insert.Parameters.AddWithValue("@Supplier_Name", metroTextBox2.Text);
                    insert.Parameters.AddWithValue("@NIC ", metroTextBox3.Text);
                    insert.Parameters.AddWithValue("@Gender", metroComboBox2.Text);
                    insert.Parameters.AddWithValue("@DOB", metroTextBox5.Text);
                    insert.Parameters.AddWithValue("@Contact_Number", metroTextBox6.Text);
                    insert.Parameters.AddWithValue("@Email", metroTextBox7.Text);
                    insert.Parameters.AddWithValue("@Payment_Method", metroComboBox1.Text);
                    insert.Parameters.AddWithValue("@Customer_Address_Line1", metroTextBox8.Text);
                    insert.Parameters.AddWithValue("@Customer_Address_Line2", metroTextBox4.Text);
                    insert.Parameters.AddWithValue("@Customer_City", metroTextBox9.Text);
                    insert.Parameters.AddWithValue("@Zip_Code", metroTextBox10.Text);
                    insert.Parameters.AddWithValue("@Product_ID", metroTextBox3.Text);
                    insert.Parameters.AddWithValue("@Company_Name", metroTextBox11.Text);
                    insert.Parameters.AddWithValue("@WH_Address", metroTextBox41.Text);
                    insert.Parameters.AddWithValue("@Delivery_Method", metroComboBox5.Text);
                    insert.Parameters.AddWithValue("@VAT_No", metroTextBox12.Text);
                    insert.Parameters.AddWithValue("@Company_Contact", metroTextBox13.Text);
                    insert.Parameters.AddWithValue("@Credit_Limit", metroComboBox14.Text);
                    insert.Parameters.AddWithValue("@Interest_Rates", metroComboBox4.Text);



                    Supplier_Connection.Open();
                    insert.ExecuteNonQuery();
                    Supplier_Connection.Close();
                    MetroFramework.MetroMessageBox.Show(this, "SUPPLIER DETAILS SAVING SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                MessageBox.Show("VIOLATION OF SQL SEVER RULES.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Supplier_Connection.Close();
            }
        }
        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

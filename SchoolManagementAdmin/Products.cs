using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Data.Sql;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace SATHOSA_ICS
{
    public partial class Products : MetroForm
    {
        SqlConnection Product_Connection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
        public Products()
        {
            InitializeComponent();
        }
        public void insertValues()
        {
            try
            {

                if (metroTextBox1.Text == "" || metroTextBox3.Text == "" || metroTextBox11.Text == "" || metroTextBox5.Text == "" || metroTextBox7.Text == "" || metroTextBox8.Text == "" || metroTextBox9.Text == "" || metroTextBox4.Text == "" || metroTextBox6.Text == "" || metroTextBox10.Text == "" )
                {
                    MetroFramework.MetroMessageBox.Show(this, "REQUIRED FIELDS CANNOT BE EMPTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand insert = new SqlCommand();
                    insert.Connection = Product_Connection;
                    insert.CommandText = "Execute AddProducts @Product_ID,@Product_Name,@Product_Description,@Product_Buying_Price,@Net_Weight,@Product_Selling_Price,@Product_Reorder_Level,@Unit_Of_Measure,@Quantity_On_Hand,@VAT_Applicability";
                    insert.Parameters.AddWithValue("@Product_ID", metroTextBox1.Text);
                    insert.Parameters.AddWithValue("@Product_Name", metroTextBox3.Text);
                    insert.Parameters.AddWithValue("@Product_Description ", metroTextBox11.Text);
                    insert.Parameters.AddWithValue("@Product_Buying_Price", metroTextBox4.Text);
                    insert.Parameters.AddWithValue("@Net_Weight", metroTextBox5.Text);
                    insert.Parameters.AddWithValue("@Product_Selling_Price", metroTextBox6.Text);
                    insert.Parameters.AddWithValue("@Product_Reorder_Level", metroTextBox7.Text);
                    insert.Parameters.AddWithValue("@Unit_Of_Measure", metroTextBox8.Text);
                    insert.Parameters.AddWithValue("@Quantity_On_Hand", metroTextBox9.Text);
                    insert.Parameters.AddWithValue("@VAT_Applicability", metroTextBox10.Text);
                    


                    Product_Connection.Open();
                    insert.ExecuteNonQuery();
                    Product_Connection.Close();
                    MetroFramework.MetroMessageBox.Show(this, "PRODUCT DETAILS SAVING SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                MessageBox.Show("VIOLATION OF SQL SEVER RULES.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Product_Connection.Close();
            }
        }

        public void FillMetroComboProdcut()
        {

            SqlConnection ComboConnection = Product_Connection;
            SqlCommand command = new SqlCommand("SELECT Product_ID FROM Product");
            command.Connection = ComboConnection;
            SqlDataReader rdr;
            try
            {
                ComboConnection.Open();
                rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    String ICode = rdr.GetString(0);
                    metroComboBox1.Items.Add(ICode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void FillMetroComboProdcut2()
        {

            SqlConnection ComboConnection2 = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand command2 = new SqlCommand("SELECT Product_ID FROM Product");
            command2.Connection = ComboConnection2;
            SqlDataReader rdr;
            try
            {
                ComboConnection2.Open();
                rdr = command2.ExecuteReader();

                while (rdr.Read())
                {
                    String ICode = rdr.GetString(0);
                    metroComboBox2.Items.Add(ICode);
                }
            }
            catch (Exception ex)
            {
                ComboConnection2.Close();
                MessageBox.Show("" + ex);
            }
        }
        public void Clear3()
        {
            metroTextBox28.Text ="";
            metroTextBox20.Text = "";
            metroTextBox27.Text = "";
            metroTextBox26.Text ="";
            metroTextBox25.Text ="";
            metroTextBox24.Text = "";
            metroTextBox23.Text = "";
            metroTextBox22.Text = "";
            metroTextBox21.Text = "";


        }

        public void Clear2()
        {
            metroComboBox1.Text = "";
            metroTextBox19.Text ="";
            metroTextBox2.Text = "";
            metroTextBox18.Text = "";

            metroTextBox17.Text = "";
            metroTextBox16.Text = "";
            metroTextBox15.Text = "";
            metroTextBox14.Text = "";
            metroTextBox13.Text = "";
            metroTextBox12.Text = "";
        
        
        }
        public void Clear()
        {
        
                    metroTextBox1.Text="";
                    metroTextBox3.Text="";
                     metroTextBox11.Text="";
                    metroTextBox4.Text="";
                     metroTextBox5.Text="";
                     metroTextBox6.Text="";
                     metroTextBox7.Text="";
                     metroTextBox8.Text="";
                     metroTextBox9.Text="";
                     metroTextBox10.Text="";
        
        
        
        }

        public void RetrieveValuesForView(String ID)
        {
            SqlConnection RetProductInfo = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand Select = new SqlCommand("Select Product_Name,Product_Description,Product_Buying_Price,Net_Weight,Product_Selling_Price,Product_Reorder_Level,Unit_Of_Measure,Quantity_On_Hand,VAT_Applicability FROM Product Where Product_ID=@ID;", RetProductInfo);

            //MessageBox.Show(""+ID);
            Select.Parameters.AddWithValue("@ID", ID);
            try
            {
                SqlDataReader DataReader;
                RetProductInfo.Open();
                DataReader = Select.ExecuteReader();


                while (DataReader.Read())
                {
                    metroTextBox19.Text = DataReader["Product_Name"].ToString();
                    metroTextBox2.Text = DataReader["Product_Description"].ToString();
                    metroTextBox18.Text = DataReader["Product_Buying_Price"].ToString();


                    metroTextBox17.Text = DataReader["Net_Weight"].ToString();
                    metroTextBox16.Text = DataReader["Product_Selling_Price"].ToString();
                    metroTextBox15.Text = DataReader["Product_Reorder_Level"].ToString();
                    metroTextBox14.Text = DataReader["Unit_Of_Measure"].ToString();
                    metroTextBox13.Text = DataReader["Quantity_On_Hand"].ToString();
                    metroTextBox12.Text = DataReader["VAT_Applicability"].ToString();
                   

                }

                DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                RetProductInfo.Close();
            }

        }

        public void RetrieveValuesForView2(String ID)
        {
            SqlConnection RetProductInfo = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand Select = new SqlCommand("Select Product_Name,Product_Description,Product_Buying_Price,Net_Weight,Product_Selling_Price,Product_Reorder_Level,Unit_Of_Measure,Quantity_On_Hand,VAT_Applicability FROM Product Where Product_ID=@ID;", RetProductInfo);

            //MessageBox.Show(""+ID);
            Select.Parameters.AddWithValue("@ID", ID);
            try
            {
                SqlDataReader DataReader;
                RetProductInfo.Open();
                DataReader = Select.ExecuteReader();


                while (DataReader.Read())
                {
                    metroTextBox28.Text = DataReader["Product_Name"].ToString();
                    metroTextBox20.Text = DataReader["Product_Description"].ToString();
                    metroTextBox27.Text = DataReader["Product_Buying_Price"].ToString();
                    metroTextBox26.Text = DataReader["Net_Weight"].ToString();
                    metroTextBox25.Text = DataReader["Product_Selling_Price"].ToString();
                    metroTextBox24.Text = DataReader["Product_Reorder_Level"].ToString();
                    metroTextBox23.Text = DataReader["Unit_Of_Measure"].ToString();
                    metroTextBox22.Text = DataReader["Quantity_On_Hand"].ToString();
                    metroTextBox21.Text = DataReader["VAT_Applicability"].ToString();


                }

                DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                RetProductInfo.Close();
            }

        }

        public void UpdateValues()
        {
            try
            {

                if (metroTextBox19.Text == "" || metroTextBox2.Text == "" || metroTextBox17.Text == "" || metroTextBox15.Text == "" || metroTextBox14.Text == "" || metroTextBox13.Text == "" || metroTextBox18.Text == "" || metroTextBox16.Text == "" )
                {
                    MetroFramework.MetroMessageBox.Show(this, "REQUIRED FIELDS CANNOT BE EMPTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection Update_Product = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
                    SqlCommand update = new SqlCommand();
                    update.CommandType = CommandType.Text;
                    update.Connection = Update_Product;
                    update.CommandText = "Execute UpdateProducts @Product_ID,@Product_Name,@Product_Description,@Product_Buying_Price,@Net_Weight,@Product_Selling_Price,@Product_Reorder_Level,@Unit_Of_Measure,@Quantity_On_Hand,@VAT_Applicability";

                    update.Parameters.AddWithValue("@Product_ID", metroComboBox1.Text);
                    update.Parameters.AddWithValue("@Product_Name", metroTextBox19.Text);
                    update.Parameters.AddWithValue("@Product_Description ", metroTextBox2.Text);
                    update.Parameters.AddWithValue("@Product_Buying_Price", metroTextBox18.Text);
                    update.Parameters.AddWithValue("@Net_Weight", metroTextBox17.Text);
                    update.Parameters.AddWithValue("@Product_Selling_Price", metroTextBox16.Text);
                    update.Parameters.AddWithValue("@Product_Reorder_Level", metroTextBox15.Text);
                    update.Parameters.AddWithValue("@Unit_Of_Measure", metroTextBox14.Text);
                    update.Parameters.AddWithValue("@Quantity_On_Hand", metroTextBox13.Text);
                    update.Parameters.AddWithValue("@VAT_Applicability", metroTextBox12.Text);

                    Update_Product.Open();
                    update.ExecuteNonQuery();
                    Update_Product.Close();
                    MetroFramework.MetroMessageBox.Show(this, "PRODUCT DETAILS UPDATING SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FillData();
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                Product_Connection.Close();
            }

        }
        private void Products_Load(object sender, EventArgs e)
        {
            FillMetroComboProdcut();
            FillMetroComboProdcut2();

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            insertValues();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID;
            ID = Convert.ToString(metroComboBox1.Text);
            RetrieveValuesForView(ID);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Clear2();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID2;
            ID2=Convert.ToString(metroComboBox2.Text);
            RetrieveValuesForView2(ID2);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Clear3();
        }
    }
}

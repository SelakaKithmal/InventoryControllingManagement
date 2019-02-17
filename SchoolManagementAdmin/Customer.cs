using MetroFramework.Forms;
using MetroFramework;
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
    public partial class Customer : MetroForm
    {
        SqlConnection Customer_Connection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
        public Customer()
        {
            InitializeComponent();
        }
 public void insertValues()
        {
            try
            {

               if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroComboBox2.Text =="" || metroTextBox5.Text == "" || metroTextBox6.Text == "" || metroTextBox7.Text == "" || metroTextBox1.Text == "" || metroTextBox8.Text == "" || metroTextBox4.Text == "" || metroTextBox9.Text == "" || metroTextBox10.Text==""||metroComboBox1.Text=="")
                {
                    MetroFramework.MetroMessageBox.Show(this, "REQUIRED FIELDS CANNOT BE EMPTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand insert = new SqlCommand();
                    insert.Connection = Customer_Connection;
                    insert.CommandText = "Execute AddCustomer @Customer_ID,@Customer_Name,@Customer_NIC,@Gender,@DOB,@Contact_Number,@Email,@Payment_Method,@Customer_Address_Line1,@Customer_Address_Line2,@Customer_City,@Zip_Code,@Company_Name,@WH_Address,@Delivary_Method,@VAT,@Company_Contact,@Credit_Limit_Allowed,@Interest_Rates";
                    insert.Parameters.AddWithValue("@Customer_ID", metroTextBox1.Text);
                    insert.Parameters.AddWithValue("@Customer_Name", metroTextBox2.Text);
                    insert.Parameters.AddWithValue("@Customer_NIC", metroTextBox3.Text);
                    insert.Parameters.AddWithValue("@Gender", metroComboBox2.Text);
                    insert.Parameters.AddWithValue("@DOB", metroTextBox5.Text);
                    insert.Parameters.AddWithValue("@Contact_Number", metroTextBox6.Text);
                    insert.Parameters.AddWithValue("@Email", metroTextBox7.Text);
                    insert.Parameters.AddWithValue("@Payment_Method", metroComboBox1.Text);
                    insert.Parameters.AddWithValue("@Customer_Address_Line1", metroTextBox8.Text);
                    insert.Parameters.AddWithValue("@Customer_Address_Line2", metroTextBox4.Text);
                    insert.Parameters.AddWithValue("@Customer_City", metroTextBox9.Text);
                    insert.Parameters.AddWithValue("@Zip_Code", metroTextBox10.Text);
                    insert.Parameters.AddWithValue("@Company_Name", metroTextBox11.Text);
                    insert.Parameters.AddWithValue("@WH_Address", metroTextBox41.Text);
                    insert.Parameters.AddWithValue("@Delivary_Method", metroComboBox3.Text);
                    insert.Parameters.AddWithValue("@VAT", metroTextBox12.Text);
                    insert.Parameters.AddWithValue("@Company_Contact", metroTextBox13.Text);
                    insert.Parameters.AddWithValue("@Credit_Limit_Allowed", metroTextBox14.Text);
                    insert.Parameters.AddWithValue("@Interest_Rates", metroComboBox4.Text);
                   



                    Customer_Connection.Open();
                    insert.ExecuteNonQuery();
                    Customer_Connection.Close();
                    MetroFramework.MetroMessageBox.Show(this, "CUSTOMER DETAILS SAVING SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                  
               }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                MessageBox.Show("VIOLATION OF SQL SEVER RULES.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Customer_Connection.Close();
            }
        }
   public void RetrieveValues(String ID)
        {
            SqlConnection RetCustInfo = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand Select = new SqlCommand("Select Customer_Name,NIC,Gender,DOB,Contact_Number,Email,Payment_Method,Customer_Address_Line1,Customer_Address_Line2,Customer_City,Zip_Code,Company_Name,WH_Address,Delivary_Method,VAT_Registration_No,Company_Contact,Credit_Limit_Allowed,Interest_Rates FROM Customer Where Customer_ID=@ID;", RetCustInfo);
           
            //MessageBox.Show(""+ID);
            Select.Parameters.AddWithValue("@ID", ID);
            try
            {
                SqlDataReader DataReader;
                RetCustInfo.Open();
                DataReader = Select.ExecuteReader();


                while (DataReader.Read())
                {
                    metroTextBox28.Text = DataReader["Customer_Name"].ToString();
                    metroTextBox43.Text = DataReader["NIC"].ToString();
                    metroTextBox30.Text = DataReader["Gender"].ToString();
                    metroTextBox32.Text = Convert.ToString(DataReader["DOB"]).Remove(8);
                  
                    metroTextBox35.Text = DataReader["Contact_Number"].ToString();
                    metroTextBox36.Text = DataReader["Email"].ToString();
                    metroComboBox11.Text = DataReader["Payment_Method"].ToString();
                    metroTextBox34.Text = DataReader["Customer_Address_Line1"].ToString();
                    metroTextBox33.Text = DataReader["Customer_Address_Line2"].ToString();
                    metroTextBox31.Text = DataReader["Customer_City"].ToString();
                    metroTextBox29.Text = DataReader["Zip_Code"].ToString();
                    metroTextBox40.Text = DataReader["Company_Name"].ToString();
                    metroTextBox42.Text = DataReader["WH_Address"].ToString();
                    metroTextBox44.Text = DataReader["Delivary_Method"].ToString();
                    metroTextBox39.Text = DataReader["VAT_Registration_No"].ToString();
                    metroTextBox38.Text = DataReader["Company_Contact"].ToString();
                    metroTextBox37.Text = DataReader["Credit_Limit_Allowed"].ToString();
                    metroTextBox45.Text = DataReader["Interest_Rates"].ToString();

                }

                DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            finally
            {
                RetCustInfo.Close();
            }
          
        }
   public void RetrieveValuesForView(String ID)
   {
       SqlConnection RetCustInfo = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
       SqlCommand Select = new SqlCommand("Select Customer_Name,NIC,Gender,DOB,Contact_Number,Email,Payment_Method,Customer_Address_Line1,Customer_Address_Line2,Customer_City,Zip_Code,Company_Name,WH_Address,Delivary_Method,VAT_Registration_No,Company_Contact,Credit_Limit_Allowed,Interest_Rates FROM Customer Where Customer_ID=@ID;", RetCustInfo);

       //MessageBox.Show(""+ID);
       Select.Parameters.AddWithValue("@ID", ID);
       try
       {
           SqlDataReader DataReader;
           RetCustInfo.Open();
           DataReader = Select.ExecuteReader();


           while (DataReader.Read())
           {
               metroTextBox23.Text = DataReader["Customer_Name"].ToString();
               metroTextBox46.Text = DataReader["NIC"].ToString();
               metroTextBox22.Text = DataReader["Gender"].ToString();
               metroTextBox21.Text = Convert.ToString(DataReader["DOB"]).Remove(8);

               metroTextBox20.Text = DataReader["Contact_Number"].ToString();
               metroTextBox19.Text = DataReader["Email"].ToString();
               metroComboBox6.Text = DataReader["Payment_Method"].ToString();
               metroTextBox18.Text = DataReader["Customer_Address_Line1"].ToString();
               metroTextBox17.Text = DataReader["Customer_Address_Line2"].ToString();
               metroTextBox16.Text = DataReader["Customer_City"].ToString();
               metroTextBox15.Text = DataReader["Zip_Code"].ToString();
               metroTextBox27.Text = DataReader["Company_Name"].ToString();
               metroTextBox47.Text = DataReader["WH_Address"].ToString();
               metroComboBox9.Text = DataReader["Delivary_Method"].ToString();
               metroTextBox26.Text = DataReader["VAT_Registration_No"].ToString();
               metroTextBox25.Text = DataReader["Company_Contact"].ToString();
               metroTextBox24.Text = DataReader["Credit_Limit_Allowed"].ToString();
               metroComboBox8.Text = DataReader["Interest_Rates"].ToString();

           }

           DataReader.Close();
       }
       catch (Exception ex)
       {
           MessageBox.Show("" + ex);
       }
       finally
       {
           RetCustInfo.Close();
       }

   }

 public void UpdateValues()
        {
            try
            {

                if (metroTextBox28.Text == "" || metroTextBox43.Text == "" || metroTextBox30.Text == "" || metroTextBox32.Text == "" || metroTextBox35.Text == "" || metroTextBox36.Text == "" || metroTextBox11.Text == "" || metroTextBox34.Text == "" || metroTextBox33.Text == "" || metroTextBox31.Text == "" || metroTextBox40.Text == "" || metroTextBox42.Text == "" || metroTextBox44.Text == "" || metroTextBox39.Text == "" || metroTextBox38.Text == "" || metroTextBox37.Text == "" || metroTextBox45.Text == "" || metroTextBox29.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "REQUIRED FIELDS CANNOT BE EMPTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand update_Customer = new SqlCommand();
                    update_Customer.CommandType = CommandType.Text;
                    update_Customer.Connection = Customer_Connection;
                    update_Customer.CommandText = "Execute UpdateSupplier @Supplier_ID,@Supplier_Name,@Supplier_Address,@Supplier_phone";

                    update_Customer.Parameters.AddWithValue("@Customer_ID", metroComboBox14.Text);
                    update_Customer.Parameters.AddWithValue("@Customer_Name", metroTextBox28.Text);
                    update_Customer.Parameters.AddWithValue("@Customer_NIC", metroTextBox43.Text);
                    update_Customer.Parameters.AddWithValue("@Gender", metroTextBox30.Text);
                    update_Customer.Parameters.AddWithValue("@DOB", metroTextBox32.Text);
                    update_Customer.Parameters.AddWithValue("@Contact_Number", metroTextBox35.Text);
                    update_Customer.Parameters.AddWithValue("@Email", metroTextBox36.Text);
                    update_Customer.Parameters.AddWithValue("@Payment_Method", metroComboBox11.Text);
                    update_Customer.Parameters.AddWithValue("@Customer_Address_Line1", metroTextBox34.Text);
                    update_Customer.Parameters.AddWithValue("@Customer_Address_Line2", metroTextBox33.Text);
                    update_Customer.Parameters.AddWithValue("@Customer_City", metroTextBox31.Text);
                    update_Customer.Parameters.AddWithValue("@Zip_Code", metroTextBox29.Text);
                    update_Customer.Parameters.AddWithValue("@Company_Name", metroTextBox40.Text);
                    update_Customer.Parameters.AddWithValue("@WH_Address", metroTextBox42.Text);
                    update_Customer.Parameters.AddWithValue("@Delivary_Method", metroTextBox44.Text);
                    update_Customer.Parameters.AddWithValue("@VAT", metroTextBox39.Text);
                    update_Customer.Parameters.AddWithValue("@Company_Contact", metroTextBox38.Text);
                    update_Customer.Parameters.AddWithValue("@Credit_Limit_Allowed", metroTextBox37.Text);
                    update_Customer.Parameters.AddWithValue("@Interest_Rates", metroTextBox45.Text);
                   
                    Customer_Connection.Open();
                    update_Customer.ExecuteNonQuery();
                    Customer_Connection.Close();
                    MetroFramework.MetroMessageBox.Show(this, "CUSTOMER DETAILS UPDATING SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FillData();
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                Customer_Connection.Close();
            }

        }
        public void FillMetroComboCustomer()
        {

            SqlConnection ComboConnection = Customer_Connection;
            SqlCommand command = new SqlCommand("SELECT Customer_ID FROM Customer");
            command.Connection = ComboConnection;
            SqlDataReader rdr;
            try
            {
                ComboConnection.Open();
                rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    String ICode = rdr.GetString(0);
                    metroComboBox14.Items.Add(ICode);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("" + ex);
            }
        }

        public void FillMetroComboCustomer2()
        {

            SqlConnection ComboConnection2 = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT Customer_ID FROM Customer");
            command.Connection = ComboConnection2;
            SqlDataReader rdr;
            try
            {
                ComboConnection2.Open();
                rdr = command.ExecuteReader();
               // ComboConnection2.Close();

                while (rdr.Read())
                {
                    String ICode = rdr.GetString(0);
                    metroComboBox7.Items.Add(ICode);
                }
            }
            catch (Exception ex)
            {
                ComboConnection2.Close();
                MessageBox.Show("" + ex);
            }
            finally
            {
                ComboConnection2.Close();
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            FillMetroComboCustomer();
            FillMetroComboCustomer2();
        }
        public void Clear()
        {
             metroTextBox1.Text="";
            metroTextBox2.Text="";
            metroTextBox3.Text="";
             metroComboBox2.Text="";
             metroTextBox5.Text="";
             metroTextBox6.Text="";;
             metroTextBox7.Text="";
            metroComboBox1.Text="";
             metroTextBox8.Text="";
             metroTextBox4.Text="";
            metroTextBox9.Text="";
            metroTextBox10.Text="";
            metroTextBox11.Text="";
            metroTextBox41.Text="";
            metroComboBox3.Text="";
             metroTextBox12.Text="";
             metroTextBox13.Text="";
            metroTextBox14.Text="";
            metroComboBox4.Text = "";
        
        }

        public void Clear2()
        {

           metroComboBox14.Text="";
            metroTextBox28.Text="";
            metroTextBox43.Text="";
            metroTextBox30.Text="";
             metroTextBox32.Text="";
            metroTextBox35.Text="";
            metroTextBox36.Text="";
            metroComboBox11.SelectedItem = "";
             metroTextBox34.Text="";
            metroTextBox33.Text="";
            metroTextBox31.Text="";
            metroTextBox29.Text="";
             metroTextBox40.Text="";
             metroTextBox42.Text="";
            metroTextBox44.Text="";
             metroTextBox39.Text="";
             metroTextBox38.Text="";
             metroTextBox37.Text="";
           metroTextBox45.Text="";
                   
        
        
        }
        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            insertValues();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroTextBox16_Click(object sender, EventArgs e)
        {

        }

        private void RightOptions_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void Options_Tick(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //RetrieveValues();
        }
      
        private void metroComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID;
            ID = metroComboBox14.Text;
            //MessageBox.Show("" + ID);
            RetrieveValues(ID);
         
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Clear2();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID;
            ID = metroComboBox7.Text;
            //MessageBox.Show("" + ID);
            RetrieveValuesForView(ID);
        }
    }
}

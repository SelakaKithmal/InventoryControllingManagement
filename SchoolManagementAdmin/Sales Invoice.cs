using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SATHOSA_ICS
{
    public partial class Sales_Invoice : MetroForm
    {
        SqlConnection Invoice_Connection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");

        public Sales_Invoice()
        {
            InitializeComponent();
        }

        public void FillMetroComboCustomer()
        {

            SqlConnection ComboConnection = Invoice_Connection;
            SqlCommand command = new SqlCommand("SELECT Customer_ID FROM Customer");
            command.Connection = ComboConnection;
            SqlDataReader rdr4;
            try
            {
                ComboConnection.Open();
                rdr4 = command.ExecuteReader();

                while (rdr4.Read())
                {
                    String ICode = rdr4.GetString(0);
                    metroComboBox1.Items.Add(ICode);
                }
                rdr4.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void FillMetroComboProducts()
        {

            SqlConnection ComboConnection2 = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT Product_ID FROM Product");
            command.Connection = ComboConnection2;
            SqlDataReader rdr3;
            try
            {
                ComboConnection2.Open();
                rdr3 = command.ExecuteReader();

                while (rdr3.Read())
                {
                    String ICode = rdr3.GetString(0);
                    metroComboBox2.Items.Add(ICode);
                }
                ComboConnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                
            }
           
        }
        public void RetrieveProductPrice(String ID)
        {
            SqlConnection RetrieveProductPrice = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand Select = new SqlCommand("Select Product_Selling_Price FROM Product Where Product_ID=@ID;", RetrieveProductPrice);

            //MessageBox.Show(""+ID);
            Select.Parameters.AddWithValue("@ID", ID);
            try
            {
                SqlDataReader DataReader2;
                RetrieveProductPrice.Open();
                DataReader2 = Select.ExecuteReader();


                while (DataReader2.Read())
                {
                    metroTextBox7.Text = DataReader2["Product_Selling_Price"].ToString();
              

                }

                DataReader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                RetrieveProductPrice.Close();
            }

        }


        public void RetrieveUnitofMeasureofProduct(String ID)
        {
            SqlConnection RetrieveUnitofMeasureofProduct = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand Select = new SqlCommand("Select Unit_Of_Measure FROM Product Where Product_ID=@ID;", RetrieveUnitofMeasureofProduct);

            //MessageBox.Show(""+ID);
            Select.Parameters.AddWithValue("@ID", ID);
            try
            {
                SqlDataReader DataReader1;
                RetrieveUnitofMeasureofProduct.Open();
                DataReader1 = Select.ExecuteReader();


                while (DataReader1.Read())
                {
                    metroTextBox6.Text = DataReader1["Unit_Of_Measure"].ToString();


                }

                DataReader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                RetrieveUnitofMeasureofProduct.Close();
            }

        }


        public void insertValues()
        {
            try
            {

                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroComboBox1.Text == "" || metroComboBox2.Text == "" || metroTextBox7.Text == "" || metroTextBox6.Text == "" || metroTextBox3.Text == "" || metroTextBox8.Text == "")
                {
                    MessageBox.Show("REQUIRED FIELDS CANNOT BE EMPTY");
                }
                else
                {
                    String Time = Convert.ToString(metroLabel9.Text);
                        int Qty = Convert.ToInt16(metroTextBox3.Text);
                    SqlCommand insert = new SqlCommand();
                    SqlConnection AddInvoiceConnection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
                    insert.Connection = AddInvoiceConnection;
                    insert.CommandText = "Execute AddInvoice @Invoice_ID,@Invoice_Date,@Customer_ID,@Product_ID,@Time,@Product_Price,@Unit_Of_Measure,@Quantity,@Sub_Total";
                    insert.Parameters.AddWithValue("@Invoice_ID", metroTextBox1.Text);
                    insert.Parameters.AddWithValue("@Invoice_Date", metroTextBox2.Text);
                    insert.Parameters.AddWithValue("@Customer_ID", metroComboBox1.Text);
                    insert.Parameters.AddWithValue("@Product_ID", metroComboBox2.Text);
                    insert.Parameters.AddWithValue("@Time", Time );
                    insert.Parameters.AddWithValue("@Product_Price", metroTextBox7.Text);
                    insert.Parameters.AddWithValue("@Unit_Of_Measure", metroTextBox6.Text);
                    insert.Parameters.AddWithValue("@Quantity", metroTextBox3.Text);
                    insert.Parameters.AddWithValue("@Sub_Total", metroTextBox8.Text);

                    AddInvoiceConnection.Open();
                    insert.ExecuteNonQuery();
                    AddInvoiceConnection.Close();
                    MessageBox.Show("RECORD HAD BEEN ADDED SUCCESSFULLY");
                    FillData();

                    /////////////////////////////////////////////////
                    // Getting Item Stock Count SCount Final Variable
                    SqlCommand getStockCount = new SqlCommand();
                    getStockCount.CommandType = CommandType.Text;
                    getStockCount.Connection = Invoice_Connection;
                    getStockCount.Parameters.AddWithValue("@Product_ID", metroComboBox2.Text);
                    getStockCount.CommandText = "select Quantity_On_Hand from Product where Product_ID =@Product_ID";
                    AddInvoiceConnection.Open();
                    int SCount;
                    SCount = Convert.ToInt16(getStockCount.ExecuteScalar());
                    AddInvoiceConnection.Close();
                    /////// Subtracting from Count
                    int ActualCount = 0;
                    ActualCount = SCount - Qty;
                    //////////////////////////////////////////// UpdateItems
                    SqlCommand update_item = new SqlCommand();
                    update_item.CommandType = CommandType.Text;
                    update_item.Connection = AddInvoiceConnection;
                    // update_item.CommandText = "Execute UpdateItem @Customer_ID,@Customer_Name,@Customer_Address,@Customer_phone";
                    update_item.CommandText = "Execute ReUpdateProduct @Product_ID,@Quantity_On_Hand";
                    update_item.Parameters.AddWithValue("@Product_ID", metroComboBox2.Text);
                    update_item.Parameters.AddWithValue("@Quantity_On_Hand", ActualCount);


                    AddInvoiceConnection.Open();
                    update_item.ExecuteNonQuery();
                    AddInvoiceConnection.Close();
                    // MessageBox.Show("RECORD HAD BEEN UPDATED SUCCESSFULLY");

                    Clear1();

                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                MessageBox.Show("VIOLATION OF SQL SEVER RULES.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //AddInvoiceConnection.Close();
            }
        }


        void Clear1()
        {
           // metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroComboBox1.Text = "";
            metroComboBox2.Text = "";
            metroTextBox7.Text = "";
            metroTextBox6.Text = "";
            metroTextBox3.Text = "";
            metroRadioButton1.Checked = false;
            metroTextBox8.Text = "";
        
        
        }

        void Clear2()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroComboBox1.Text = "";
            metroComboBox2.Text = "";
            metroTextBox7.Text = "";
            metroTextBox6.Text = "";
            metroTextBox3.Text = "";
            metroRadioButton1.Checked = false;
            metroTextBox8.Text = "";


        }
        void FillData()
        {
            // 1
            // Open connection
            SqlConnection FillDatagridConnection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            FillDatagridConnection.Open();
            // 2
            // Create new DataAdapter
            SqlCommand select2 = new SqlCommand("SELECT * FROM Sales_Invoice", FillDatagridConnection);
            SqlDataAdapter data_adapter2 = new SqlDataAdapter();
            data_adapter2.SelectCommand = select2;
            DataTable dataset2 = new DataTable();
            data_adapter2.Fill(dataset2);
            BindingSource bindingsource2 = new BindingSource();
            bindingsource2.DataSource = dataset2;
            metroGrid1.DataSource = bindingsource2;
            data_adapter2.Update(dataset2);
            FillDatagridConnection.Close();

        }


        void CalculateFinalBill(String ID)
        {
            try
            {
                // 1
                // Open connection
                SqlConnection FinalBillConnection2 = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");

                // 2
                // Create new DataAdapter

                SqlCommand select2 = new SqlCommand();
                select2.Parameters.AddWithValue("@ID", metroTextBox1.Text);
                select2.CommandType = CommandType.Text;
                select2.Connection = FinalBillConnection2;
                select2.CommandText = "select SUM(Sub_Total)FROM Sales_Invoice where Invoice_ID=@ID";
                String FullTotal;

                FinalBillConnection2.Open();
                FullTotal = Convert.ToString(select2.ExecuteScalar());
                FinalBillConnection2.Close();
                Double dTotal = Convert.ToDouble(FullTotal);
                MetroFramework.MetroMessageBox.Show(this, "FINAL BILL TOTAL IS "+dTotal, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear2();
            }

            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            
            }

        }

        public void Sales_Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sATHOSADataSet1.Sales_Invoice' table. You can move, or remove it, as needed.
            this.sales_InvoiceTableAdapter.Fill(this.sATHOSADataSet1.Sales_Invoice);
            timer1.Start();
           
            metroTextBox2.Text = DateTime.Now.ToShortDateString();
            FillMetroComboCustomer();
            FillMetroComboProducts();
            
        }

        String getLastID()
        {


            SqlConnection Invoice_Connection = new SqlConnection("Data Source=SELAKA\\SELA;Initial Catalog=SATHOSA;Integrated Security=True");
            SqlCommand getMaxID = new SqlCommand();
            getMaxID.CommandType = CommandType.Text;
            getMaxID.Connection = Invoice_Connection;
            getMaxID.CommandText = "select MAX(Invoice_ID) from Sales_Invoice";
            Invoice_Connection.Open();
            String LastID;
            LastID = Convert.ToString(getMaxID.ExecuteScalar());
            if (LastID == "")
            {
                LastID = "I000";
                return LastID;
            }
            else
            {
                Invoice_Connection.Close();
                return LastID;

            }




        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID;
            ID = metroComboBox2.Text;
            //MessageBox.Show("" + ID);
            RetrieveProductPrice(ID);

            String ID2 = ""; ;
            ID2 = metroComboBox2.Text;
            //MessageBox.Show("" + ID);
            RetrieveUnitofMeasureofProduct(ID2);
        }

        
        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
           
            
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
        private void metroTextBox5_Click(object sender, EventArgs e)
        {
          
      
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void metroTextBox8_Click(object sender, EventArgs e)
        {
      

        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int Quantity = Convert.ToInt16(metroTextBox3.Text);
                int Price = Convert.ToInt16(metroTextBox7.Text);
                int Sub = 0;
                Sub = Quantity * Price;
                //MessageBox.Show("" + Sub);
                metroTextBox8.Text = Convert.ToString(Sub);
            }
            catch (Exception ex)
            {

            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked)
            {
                String NewLastID;
                NewLastID = getLastID();
                String id = NewLastID.Substring(1, 3);
                int NewID = Convert.ToInt16(id);
                NewID = NewID + 1;
                String NID = "I00" + NewID;
                metroTextBox1.Text = NID;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            insertValues();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel9.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            CalculateFinalBill(metroTextBox1.Text);
        }

        
    }
}

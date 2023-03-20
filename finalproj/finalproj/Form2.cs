using finalproj.StoreClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        StoreClass1 std = new StoreClass1();
        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get the values from Input Fields
            std.productName = txt1.Text;
            std.productProducer = txt2.Text;
            std.doe = txt3.Text;
            std.stock = txt4.Text;
            std.price = txt5.Text;

            // Insert a record to the table using the previous method
            bool success = std.Insert(std);

            if (success == true)
            {
                MessageBox.Show(" New product inserted to store");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed");
                
            }

            DataTable dt = std.Select();
            DGV.DataSource = dt;
        }
        public void Clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = String.Empty;
            txt5.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = std.Select();
            DGV.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Transfer the Form values to StoreClass1
            std.productName = (txt1.Text);
            std.productProducer = txt2.Text;
            std.doe = txt3.Text;
            std.stock = txt4.Text;
            std.price= txt5.Text;
            // Update the row in the table in DB
            bool success = std.Update(std);
            if (success == true)
            {
                MessageBox.Show(" product information has been updated");

                // Load DGV from DB
                DataTable dt = std.Select();
                DGV.DataSource = dt;

                // Call the Clear() method
                Clear();
            }
            else
            {
                MessageBox.Show("product information has not been updated");
            }
              }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Get the data from From
          //  std.productID = Convert.ToInt32(txt1.Text);
            std.productName=(txt1.Text);
            std.productProducer = (txt2.Text);
            std.doe = (txt3.Text);
            std.stock = (txt4.Text);
            std.price = (txt5.Text);
         

            bool success = std.Delete(std);
            if (success)
            {
                // Successfully deleted
                MessageBox.Show("product  has been deleted");
                // Refresh the DGV
                DataTable dt = std.Select();
                DGV.DataSource = dt;

                // Call the Clear() method
                Clear();

            }
            else
            {
                // Failed to delete
                MessageBox.Show("product has not been deleted");
            }

        }


        // Connection String
       // string connstrng = ConfigurationManager.ConnectionStrings["finalproj.Properties.Settings.StoreConnectionString"].ConnectionString;

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        string connstrng = ConfigurationManager.ConnectionStrings["finalproj.Properties.Settings.StoreConnectionString"].ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Searchbox value
            string keyword = textBox1.Text;

            // Connect to DB
            SqlConnection conn = new SqlConnection(connstrng);
            // Data Adapter
            SqlDataAdapter me = new SqlDataAdapter("SELECT * FROM product WHERE productName LIKE '%" + keyword + "%' OR  productProducer LIKE '%" + keyword + "%' OR  doe LIKE '%" + keyword + "%' OR  stock LIKE '%" + keyword + "%' OR  price LIKE '%" + keyword + "%'", conn);

            // Create the data table
            DataTable dt = new DataTable();

            // Fill te dt with sda
            me.Fill(dt);

            // DGV Datasource
            DGV.DataSource = dt;
        }
    }
    }


    
    


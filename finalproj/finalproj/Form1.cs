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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conmarket = ConfigurationManager.ConnectionStrings["finalproj.Properties.Settings.StoreConnectionString"].ConnectionString;

        private DataTable Select()
        {
            //DB connection
            SqlConnection con = new SqlConnection(conmarket);

            //Create an Object for DataTable
            DataTable dataTable = new DataTable();

            try
            {
                // write sql query (your tables name)
                string sqlCode = "SELECT * FROM admin";

                // write sql query (your tables name)
                SqlCommand cmd = new SqlCommand(sqlCode, con);

                // create sqldataadapter using cmd
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // open connection
                con.Open();
                dataAdapter.Fill(dataTable);

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }

        private bool isExistInTable(DataTable table, String username, String password)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row[0].Equals(username))
                    if (row[1].Equals(password))
                        return true;
            }

            return false;
        }
        private void  button1_Click(object sender, EventArgs e)
        {
            DataTable table = Select();

            string username = name.Text;
            string password = boo.Text;

            bool isExist = isExistInTable(table, username, password);

            if (isExist)
            {
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
                form = null;
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Acess Denied!!!");

            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

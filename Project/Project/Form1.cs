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

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String conS = "Data Source=(localdb)\visual;Initial Catalog=pharma;Integrated Security=True";

        private DataTable Select()
        {
            SqlConnection c = new SqlConnection(conS);
            DataTable dTable = new DataTable();

            try
            {
                string sqlCode = "SELECT * FROM A";
                SqlCommand cmd = new SqlCommand(sqlCode, c);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                c.Open();
                dataAdapter.Fill(dTable);

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return dTable;
        }

        private bool isExistInTable(DataTable table, String username, String password)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row[1].Equals(username))
                    if (row[2].Equals(password))
                        return true;
            }

            return false;
        }


        private void login_Click(object sender, EventArgs e)
        {
            DataTable table = Select();
            string username = txtUser.Text;
            string password = txtPass.Text;

            bool isExist = isExistInTable(table, username, password);

            if (isExist)
            {
                MessageBox.Show("Loging In.....");
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
    }
}

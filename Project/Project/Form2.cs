using Project.MedClasses;
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

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MedClass1 Md = new MedClass1();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Md.medName = txtName.Text;
            Md.medMaker = txtMaker.Text;
            Md.purpose = txtPur.Text;
            Md.price = txtPrice.Text;
            Md.doe = DOEE.Text;
            bool success = Md.Insert(Md);

            if (success == true)
            {
                MessageBox.Show("A new Patient inserted to DB");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed");
            }

            DataTable dt = Md.Select();
            DtGVmed.DataSource = dt;
        }
        public void Clear()
        {
            txtName.Text = "";
            txtMaker.Clear();
            txtPur.Text = String.Empty;
            txtPrice.Clear();
            DOEE.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = Md.Select();
            DtGVmed.DataSource = dt;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Md.medID = (int)DtGVmed.CurrentRow.Cells[0].Value;
            bool success = Md.Delete(Md);
            if (success)
            {
                MessageBox.Show("Record has been deleted");
                DataTable dt = Md.Select();
                DtGVmed.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Record has not been deleted");
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Md.medName=txtName.Text;
            Md.medMaker=txtMaker.Text;
            Md.purpose=txtPur.Text;
            Md.price=txtPrice.Text;
            Md.doe=DOEE.Text;
            bool success = Md.Update(Md);

            if (success == true)
            {
                MessageBox.Show("Record has been updated");
                DataTable dt = Md.Select();
                DtGVmed.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }
        string C = ConfigurationManager.ConnectionStrings["Project.Properties.Settings.pharmaConnectionString"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(C);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM med WHERE medName LIKE '%" + keyword + "%' OR medMaker LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            DtGVmed.DataSource = dt;
        }

        private void Clearr_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DtGVmed_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rIndex = e.RowIndex;
            txtName.Text = DtGVmed.Rows[rIndex].Cells[1].Value.ToString();
            txtMaker.Text = DtGVmed.Rows[rIndex].Cells[2].Value.ToString();
            txtPur.Text = DtGVmed.Rows[rIndex].Cells[3].Value.ToString();
            txtPrice.Text = DtGVmed.Rows[rIndex].Cells[4].Value.ToString();
            DOEE.Text = DtGVmed.Rows[rIndex].Cells[5].Value.ToString();
        }
    }
}


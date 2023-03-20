using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Project.MedClasses
{
    class MedClass1
    {
        public int medID { get; set; }
        public string medName { get; set; }
        public string medMaker { get; set; }
        public string purpose { get; set; }
        public string price { get; set; }
        public string doe { get; set; }
        static string myconnection1 = ConfigurationManager.ConnectionStrings["Project.Properties.Settings.pharmaConnectionString"].ConnectionString;
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnection1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM med";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(MedClass1 Md)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection1);

            try
            {
                string sql = "INSERT INTO med (medName, medMaker, purpose, price, doe) VALUES (@medName, @medMaker, @purpose, @price, @doe) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@medName", Md.medName);
                cmd.Parameters.AddWithValue("@medMaker", Md.medMaker);
                cmd.Parameters.AddWithValue("@purpose", Md.purpose);
                cmd.Parameters.AddWithValue("@price", Md.price);
                cmd.Parameters.AddWithValue("@doe", Md.doe);




                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        public bool Update(MedClass1 Md)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection1);
            try
            {
                string sql = "UPDATE med SET medName=@medName, medMaker=@medMaker, purpose=@purpose,price=@price,doe=@doe";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@medName", Md.medName);
                cmd.Parameters.AddWithValue("@medMaker", Md.medMaker);
                cmd.Parameters.AddWithValue("@purpose", Md.purpose);
                cmd.Parameters.AddWithValue("@price", Md.price);
                cmd.Parameters.AddWithValue("@doe", Md.doe);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Delete(MedClass1 Md)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection1);
            try
            {
                string sql = "DELETE FROM med WHERE medID = @medID ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@medID", Md.medID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}

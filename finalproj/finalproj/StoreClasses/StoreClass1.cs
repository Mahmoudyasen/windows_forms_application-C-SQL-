using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace finalproj.StoreClasses
{
    class StoreClass1
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productProducer { get; set; }
        public string doe { get; set; }
        public string stock { get; set; }
        public string price { get; set; }
        static string conmarket = ConfigurationManager.ConnectionStrings["finalproj.Properties.Settings.StoreConnectionString"].ConnectionString;
        public DataTable Select()
        {
            // Step 1: Database Connection
            SqlConnection linking = new SqlConnection(conmarket);

            //Create an Object for DataTable
            DataTable dt = new DataTable();
            try
            {
                // Step 2: Write Sql Query
                string sql = "SELECT * FROM product";
                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, linking);
                // Create SqlDataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // Open connection
                linking.Open();
                // Fill our dt with our adapter.
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                linking.Close();
            }
            return dt;
        }
        public bool Insert(StoreClass1 std)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;

            // Step 1: Database Connection
            SqlConnection linking = new SqlConnection(conmarket);

            try
            {
                // Step 2: Write Sql Query to insert data
                string sql = "INSERT INTO product (productName, productProducer, doe ,stock ,price ) VALUES (@productName, @productProducer, @doe, @stock, @price) ";

                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, linking);

                // Create Parameters to add data
                cmd.Parameters.AddWithValue("@productName", std.productName);
                cmd.Parameters.AddWithValue("@productProducer", std.productProducer);
                cmd.Parameters.AddWithValue("@doe", std.doe);
                cmd.Parameters.AddWithValue("@stock", std.stock);
                cmd.Parameters.AddWithValue("@price", std.price);


                // Open connection
                linking.Open();

                // Run the Query
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value "rows" will be greater then zero else it will be zero
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
                linking.Close();
            }

            return isSuccess;
        }
        public bool Update(StoreClass1 std)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database Connection
            SqlConnection linking = new SqlConnection(conmarket);
            try
            {
                // Step 2: Write Sql Query to update data in DB
                string sql = "UPDATE product SET productName=@productName, productProducer=@productProducer, doe=@doe, stock=@stock, price=@price WHERE productID = @productID";

                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, linking);

                // Create Parameters to update data
                cmd.Parameters.Add("@productName", std.productName);
                cmd.Parameters.Add("@productProducer", std.productProducer);
                cmd.Parameters.Add("@doe", std.doe);
                cmd.Parameters.Add("@stock", std.stock);
                cmd.Parameters.Add("@price", std.price);


                // Open connection
                linking.Open();

                // Run the Query
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value "rows" will be greater then zero else it will be zero
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
                linking.Close();
            }

            return isSuccess;
        }

        public bool Delete(StoreClass1 std)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database Connection
            SqlConnection linking = new SqlConnection(conmarket);
            try
            {
                // Step 2: Write Sql Query to Delete data in DB
                string sql = "DELETE FROM product WHERE productID = @productID ";

                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, linking);

                // Create Parameter to delete data
                cmd.Parameters.Add("@productID", std.productID);


                // Open connection
                linking.Open();

                // Run the Query
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value "rows" will be greater then zero else it will be zero
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
                linking.Close();
            }

            return isSuccess;
        }




    }
}

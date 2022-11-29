using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class FunctionsDAL
    {
        private string _connString = "Data Source=LAPTOP-IP1RMDOK;Initial Catalog=FoodStore_Managerment;Integrated Security=True";
        public DataTable getData(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand(query, conn);
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlComm);
                    sqlData.Fill(data); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return data;
        }
        public DataTable func(string query, WarehouseIngredientDTO dataDTO)
        {
            DataTable dataDAL = new DataTable();
            using (SqlConnection _conn = new SqlConnection(_connString))
            {
                try
                {
                    _conn.Open();
                    SqlCommand sqlComm = new SqlCommand(query, _conn);
                    if (sqlComm.ExecuteNonQuery() > 1)
                    {
                        return dataDAL;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { _conn.Close(); }

            }
            return dataDAL;
        }
        public bool _func(string query, WarehouseIngredientDTO dataDTO)
        {
            DataTable dataDAL = new DataTable();
            using (SqlConnection _conn = new SqlConnection(_connString))
            {
                try
                {
                    _conn.Open();
                    SqlCommand sqlComm = new SqlCommand(query, _conn);
                    if (sqlComm.ExecuteNonQuery() > 1)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { _conn.Close(); }

            }
            return false;
        }
    }
}

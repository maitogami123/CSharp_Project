using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Function
    {
        private string connString = @"Data Source=.\explorer;Initial Catalog=FoodStore_Managerment;Integrated Security=True";
        public DataTable GetData(string query) //show ra hết
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(query, conn);


                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public bool InsertData(string query) //đẩy dữ liệu vào sql
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand(query, conn);
                    if (sqlComm.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error Connection");
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool DeleteData(string query)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand(query, conn);
                    if (sqlComm.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }

                catch
                {
                    MessageBox.Show("Error Connection");
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool UpdateData(string query)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand(query, conn);
                    if (sqlComm.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error Connection");
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }
    }
}

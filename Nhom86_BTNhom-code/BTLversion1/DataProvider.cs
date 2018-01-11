using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLversion1
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True"; 
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider(); return instance;
            }

            private set
            {
                Instance = value;
            }
        }

        public DataTable SelectTable(string TenBang)
        {
            string query = string.Format("SELECT * from [{0}]", TenBang);
            return ExecuteReader(query);
        }

        public DataTable ExecuteReader(string query)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(connectionSTR);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = -1;
            SqlConnection connection = new SqlConnection(connectionSTR);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query)
        {
            object data = null;
            SqlConnection connection = new SqlConnection(connectionSTR);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return data;
        }
    }
}

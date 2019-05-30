using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDataTable
{
    class SqlQueries
    {
        public static string manager = ConfigurationManager.ConnectionStrings["newConnection"].ConnectionString;

        public static DataTable SQLSorguCalistir(string sql)
        {
            SqlConnection connection = null;
            DataTable data = new DataTable();
            try
            {
                connection = new SqlConnection(manager);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                data.Load(command.ExecuteReader());
            }
            catch (Exception e)
            {
                throw new Exception("Sorgu çalıştırılamadı : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public static DataTable SQLSorguCalistirUsing(string sql)
        {
            SqlConnection connection = null;
            DataTable data = new DataTable();
            using (connection = new SqlConnection(manager))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                data.Load(command.ExecuteReader());
            }
            return data;
        }

        public static int NonSorguCalistir(string sql)
        {
            SqlConnection connection = null;
            int result = -1;
            try
            {
                connection = new SqlConnection(manager);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}

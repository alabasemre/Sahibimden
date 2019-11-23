using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenDAL
{
    public class Helper:IDisposable
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        SqlCommand cmd = null;

        public int ExecuteNonQuery(string cmdText, SqlParameter[] p)
        {
            int sonuc = 0;
            
            cmd = new SqlCommand(cmdText,connection);

            if (p!=null)
            {
                cmd.Parameters.AddRange(p);
            }

            OpenConnection();
            sonuc = cmd.ExecuteNonQuery();
            //CloseConnection();

            return sonuc;
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            //SqlCommand cmd = new SqlCommand(cmdtext, cn);
            cmd = new SqlCommand(cmdtext, connection);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }

            OpenConnection();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        private void OpenConnection()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            if (connection != null && cmd != null)
            {
                connection.Dispose();
                cmd.Dispose();
            }
        }
    }
}

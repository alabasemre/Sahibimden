using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenDAL
{
    public class Helper : IDisposable
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        SqlCommand cmd = null;
        SqlTransaction TSQL; 

        public int ExecuteNonQuery(string cmdText, SqlParameter[] p,bool tStart=false)
        {
            int sonuc = 0;

            cmd = new SqlCommand(cmdText, connection);

            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }

            OpenConnection();
            if (tStart)
            {
                BeginTransaction();
            }

            cmd.Transaction = TSQL;

            sonuc = cmd.ExecuteNonQuery();

            return sonuc;
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
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

        public void Dispose()
        {
            if (connection != null && cmd != null)
            {             
                connection.Dispose();
                cmd.Dispose();                
            }
            if (TSQL!=null)
            {
                TSQL.Dispose();
            }
        }

        public void BeginTransaction()
        {
            if (TSQL == null && connection.State==ConnectionState.Open)
            {
                TSQL = connection.BeginTransaction();
            }
        }

        public void Commit()
        {
            TSQL.Commit();
        }

        public void Rollback()
        {
            TSQL.Rollback();
        }
    }
}

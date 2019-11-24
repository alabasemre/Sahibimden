using SahibimdenDAL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace SahibimdenBLL
{
    public class ResimBL:IDisposable
    {
        Helper help = new Helper();
        public bool ResimEkle(byte[] img)
        {            
            SqlParameter[] p = { new SqlParameter("@resim",img)};

            return 0 < help.ExecuteNonQuery("INSERT INTO tbl_resim (ilan_id,resim) VALUES((SELECT MAX(ilan_id) FROM tbl_ilan),@resim)", p);
        }

        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
    }
}

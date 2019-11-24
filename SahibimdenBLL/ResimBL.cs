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
using System.IO;

namespace SahibimdenBLL
{
    public class ResimBL : IDisposable
    {
        Helper help = new Helper();
        public bool ResimEkle(byte[] img)
        {
            SqlParameter[] p = { new SqlParameter("@resim", img) };

            return 0 < help.ExecuteNonQuery("INSERT INTO tbl_resim (ilan_id,resim) VALUES((SELECT MAX(ilan_id) FROM tbl_ilan),@resim)", p);
        }

        public List<Resim> ResimListele()
        {
            List<Resim> resimler = new List<Resim>();

            SqlDataReader dr = help.ExecuteReader("SELECT resim FROM tbl_resim", null);

            while (dr.Read())
            {
                byte[] resim = (byte[])dr["resim"];

                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);
                ms.Write(resim, 0, resim.Length);

                resimler.Add
                (
                    new Resim
                    {
                        Img = Image.FromStream(ms, true)
                    }
                );
            }
            dr.Close();
            return resimler;
        }

        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
    }
}

using SahibimdenDAL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenBLL
{
    public class KategoriBL:IDisposable
    {       
        Helper help = new Helper();
        public List<Kategori> KategoriListele(int id)
        {
            List<Kategori> kategoriList = new List<Kategori>();

            SqlParameter[] p = { new SqlParameter("@ust_kat", id) };

            SqlDataReader dr = help.ExecuteReader("SELECT kategori_id,ad,ust_kategori FROM tbl_kategori WHERE ust_kategori=@ust_kat", p);           

            while (dr.Read())
            {
                kategoriList.Add
                (
                    new Kategori
                    {
                        KategoriId = (int)dr["kategori_id"],
                        Ad = dr["ad"].ToString(),
                        UstKategori = (int)dr["ust_kategori"]
                    }
                );
            }
          
            dr.Close();

            return kategoriList;
        }      
        public void Dispose()
        {
            help.Dispose();
        }
        public void Commit()
        {
            help.Commit();
        }
        public void Rollback()
        {
            help.Rollback();
        }
    }
}

using SahibimdenDAL;
using SahibimdenMODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenBLL
{
    public class ArabaBL : IDisposable
    {
        Helper help = new Helper();        

        public List<Araba> AracListele(int id)
        {
            List<Araba> marka = new List<Araba>();

            SqlParameter[] p = { new SqlParameter("@id",id)};

            SqlDataReader dr= help.ExecuteReader("SELECT araba_id,ad,ust_kategori FROM tbl_araba WHERE ust_kategori=@id",p);

            while (dr.Read())
            {
                marka.Add
                (
                    new Araba
                    {
                        Ad = dr["Ad"].ToString(),
                        ArabaId = (int)dr["araba_id"],
                        UstKategori = (int)dr["ust_kategori"]
                    }
                );
            }
            dr.Close();

            marka.Insert(0, new Araba { Ad = "Seçiniz..." });
            return marka;
        }  

        public void Dispose()
        {
            ((IDisposable)help).Dispose();
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

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
        //Helper help = new Helper(); 
        Helper help = Helper.getInstance();
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

        public List<Araba> SeriListele(int ustKat=0)
        {
            List<Araba> marka = new List<Araba>();

            SqlParameter[] p = { new SqlParameter("@ustKat", ustKat) };

            SqlDataReader dr = help.ExecuteReader("SELECT araba_id,ad,ust_kategori FROM tbl_araba WHERE ust_kategori IN(SELECT araba_id FROM tbl_araba WHERE ust_kategori=@ustKat)", p);

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
            marka.Insert(0, new Araba { Ad = "Seçiniz..." });
            dr.Close();          
            return marka;
        }

        public List<Araba> ModelListele(int ustKat = 0)
        {
            List<Araba> marka = new List<Araba>();

            SqlParameter[] p = { new SqlParameter("@ustKat", ustKat) };

            SqlDataReader dr = help.ExecuteReader("SELECT araba_id,ad,ust_kategori FROM tbl_araba " +
                "WHERE ust_kategori IN (SELECT araba_id FROM tbl_araba WHERE ust_kategori " +
                "IN(SELECT araba_id FROM tbl_araba WHERE ust_kategori=@ustKat))", p);

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
            marka.Insert(0, new Araba { Ad = "Seçiniz..." });
            dr.Close();
            return marka;
        }

        public List<Araba> MarkaAra(string ad)
        {
            List<Araba> marka = new List<Araba>();

            SqlParameter[] p = { new SqlParameter("@ad", ad) };

            SqlDataReader dr = help.ExecuteReader("SELECT araba_id,ad,ust_kategori FROM tbl_araba WHERE ad=@ad", p);

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
            return marka;
        }

        public bool ArabaEkle(Araba araba)
        {
            SqlParameter[] p = { new SqlParameter("@ad", araba.Ad), new SqlParameter("ustKat", araba.UstKategori) };
            return 0 < help.ExecuteNonQuery("INSERT INTO tbl_araba (ad,ust_kategori) VALUES(@ad,@ustKat)",p);
        }
        public bool Guncelle(Araba araba)
        {
            SqlParameter[] p = { new SqlParameter("@id",araba.ArabaId),new SqlParameter("@ad", araba.Ad), new SqlParameter("@ustKat", araba.UstKategori) };
            return 0 < help.ExecuteNonQuery("UPDATE tbl_araba SET ad=@ad,ust_kategori=@ustKat WHERE araba_id=@id", p);
        }

        public bool Sil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@id", id) };
            return 0 < help.ExecuteNonQuery("DELETE FROM tbl_araba WHERE araba_id=@id OR ust_kategori=@id OR " +
                "ust_kategori IN (SELECT araba_id FROM tbl_araba WHERE ust_kategori=@id)", p);
        }

        public bool KayitVarmi(Araba araba)
        {
            int adet = 0;
            SqlParameter[] p = { new SqlParameter("@ad", araba.Ad), new SqlParameter("ustKat",araba.UstKategori) };

            SqlDataReader dr = help.ExecuteReader("SELECT COUNT(*) as Adet FROM tbl_araba WHERE ad=@ad AND ust_kategori=@ustKat",p);

            if (dr.Read())
            {
               adet = (int)dr["Adet"];     
            }
            dr.Close();
            return adet==1;
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

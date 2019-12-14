using SahibimdenDAL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenBLL
{
    public class OzellikBL : IDisposable
    {
        //Helper help = new Helper();  
        //Helper help = Helper.getInstance();
        Helper help = Helper.getInstance;

        public bool ArabaOzellikEkle(Ozellik ozellik)
        {
            int sonuc = 0;

            SqlParameter[] p = { new SqlParameter("@kategori", ozellik.kategori_id), new SqlParameter("@deger", ozellik.deger) };

            sonuc = help.ExecuteNonQuery("INSERT INTO tbl_deger(ilan_id,kategori_id,deger)VALUES((SELECT MAX(ilan_id) FROM tbl_ilan),@kategori,@deger)", p,true);

            return sonuc == 1;
        }

        public List<Ozellik> OzellikGetir(string ad)
        {
            List<Ozellik> ozellikler = new List<Ozellik>();

            SqlParameter[] p = { new SqlParameter("@ad", ad) };
            SqlDataReader dr = help.ExecuteReader                
                (
                "SELECT ISNULL((SELECT ad FROM tbl_kategori WHERE kategori_id=d.deger AND ust_kategori=k.kategori_id),d.deger) as deger " +
                "FROM tbl_kategori as k " +
                "INNER JOIN tbl_deger as d " +
                "ON k.kategori_id=d.kategori_id " +
                "WHERE k.ad=@ad"
                , p);

            while (dr.Read())
            {
                Ozellik ozellik = new Ozellik();
                ozellik.deger = dr["deger"].ToString();
                ozellikler.Add(ozellik);              
            }
            dr.Close();
            return ozellikler;
        }

        public DataTable AracDetayGetir(int id)
        {
            SqlParameter[] p = {new SqlParameter("@id",id) };

            return help.GetDataTable("SELECT k.ad,ISNULL((SELECT ad FROM tbl_kategori as ka WHERE ka.ust_kategori=k.kategori_id AND ka.kategori_id=d.deger ),d.deger) as deger FROM tbl_deger as d INNER JOIN tbl_kategori as k ON d.kategori_id  = k.kategori_id WHERE ilan_id =@id",p);
        }
        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
        public void DisposeCmd()
        {
            help.DisposeCmd();
        }   
    }
}

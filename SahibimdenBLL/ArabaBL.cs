using SahibimdenDAL;
using SahibimdenMODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenBLL
{
    public class ArabaBL
    {
        string[,] ozellik;

        public bool IlanEkle(Ilan ilan)
        {
            Helper help = new Helper();

            SqlParameter[] p = { new SqlParameter("@aciklama", ilan.Aciklama), new SqlParameter("@ad", ilan.ArabaId) };

            return 0 < help.ExecuteNonQuery("INSERT INTO tbl_ilan (aciklama,araba_id) VALUES(@aciklama,(SELECT araba_id FROM tbl_araba WHERE ad=@ad))", p);
        }

        public bool ArabaOzellikEkle(ArabaOzellik araba)
        {
            Helper help = new Helper();
            int sonuc = 0;
            DiziOlustur(araba);

            for (int i = 0; i < ozellik.GetLength(0); i++)
            {
                SqlParameter[] p = { new SqlParameter("@kategori", ozellik[i, 0]), new SqlParameter("@deger", ozellik[i, 1]) };

                sonuc += help.ExecuteNonQuery("INSERT INTO tbl_deger (ilan_id,kategori_id,deger) " +
                     "VALUES ((SELECT MAX(ilan_id) FROM tbl_ilan),(SELECT kategori_id FROM tbl_kategori" +
                     " WHERE ad=@kategori),ISNULL((SELECT kategori_id FROM tbl_kategori WHERE ad=@deger AND ust_kategori<>0),@deger))", p);
            }

            return sonuc == ozellik.GetLength(0);
        }

        private void DiziOlustur(ArabaOzellik araba)
        {
            ozellik = new string[,]
            {
                { "Yıl", araba.Yil },
                { "Yakıt Tipi",araba.YakitTipi },
                { "Vites Tipi",araba.VitesTipi },
                { "Kilometre", araba.KM },
                { "Kasa Tipi", araba.KasaTipi },
                { "Motor Gücü", araba.MotorGucu },
                { "Motor Hacmi", araba.MotorHacmi },
                { "Renk", araba.Renk },
                { "Fiyat", araba.Fiyat },
                { "Durum", araba.Durum }
             };
        }
    }
}

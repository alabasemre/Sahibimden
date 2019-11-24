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
    public class OzellikBL:IDisposable
    {
        Helper help = new Helper();
        public bool ArabaOzellikEkle(Ozellik ozellik)
        {          
            int sonuc = 0;          

            SqlParameter[] p = { new SqlParameter("@kategori", ozellik.kategori_id), new SqlParameter("@deger", ozellik.deger) };

                //sonuc += help.ExecuteNonQuery("INSERT INTO tbl_deger (ilan_id,kategori_id,deger) " +
                //    "VALUES ((SELECT MAX(ilan_id) FROM tbl_ilan),(SELECT kategori_id FROM tbl_kategori" +
                //     " WHERE ad=@kategori),ISNULL((SELECT kategori_id FROM tbl_kategori WHERE ad=@deger AND ust_kategori<>0),@deger))", p);

            sonuc=help.ExecuteNonQuery("INSERT INTO tbl_deger(ilan_id,kategori_id,deger)VALUES((SELECT MAX(ilan_id) FROM tbl_ilan),@kategori,@deger)", p); 

            return sonuc == 1;
        }
        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
    }
}

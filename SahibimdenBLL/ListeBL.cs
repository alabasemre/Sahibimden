using SahibimdenDAL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenBLL
{
    public class ListeBL:IDisposable
    {
        Helper help = new Helper();
              

        public List<ListeModel> Listele()
        {
            List<ListeModel> liste = new List<ListeModel>();

            SqlDataReader dr = help.ExecuteReader
                (
                "SELECT ilan_id," +
                "(SELECT resim FROM tbl_resim WHERE ilan_id=tbl_ilan.ilan_id) as resim," +
                "(SELECT a.ad FROM tbl_araba as a WHERE a.araba_id=(SELECT ust_kategori FROM tbl_araba as a WHERE a.araba_id=(SELECT ust_kategori FROM tbl_araba as a WHERE a.araba_id=tbl_ilan.araba_id))) as Marka, " +
                "(SELECT a.ad FROM tbl_araba as a WHERE a.araba_id=(SELECT ust_kategori FROM tbl_araba as a WHERE a.araba_id=tbl_ilan.araba_id)) as Seri," +
                "(SELECT a.ad FROM tbl_araba as a WHERE a.araba_id=tbl_ilan.araba_id) as Model," +
                "aciklama,ilan_tarihi " +
                "FROM tbl_ilan"
                , null
                );

            while (dr.Read())
            {
                byte[] resim = (byte[])dr["resim"];

                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);
                ms.Write(resim, 0, resim.Length);
                liste.Add(new ListeModel
                {
                    IlanId = (int)dr["ilan_id"],
                    IlanTarihi = (DateTime)dr["ilan_tarihi"],
                    Aciklama = dr["aciklama"].ToString(),
                    Marka = dr["Marka"].ToString(),
                    Model = dr["Model"].ToString(),
                    Seri = dr["Seri"].ToString(),
                    Img = Image.FromStream(ms, true)
                });
            }
            dr.Close();
            return liste;
        }
        public void Dispose()
        {
            ((IDisposable)help).Dispose();
        }
    }
   
}

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
    public class IlanBL : IDisposable
    {
        //Helper help = new Helper();
        //Helper help = Helper.getInstance();
        Helper help = Helper.getInstance;

        public bool IlanEkle(Ilan ilan)
        {
            SqlParameter[] p = { new SqlParameter("@aciklama", ilan.Aciklama), new SqlParameter("@id", ilan.ArabaId) };

            return 0 < help.ExecuteNonQuery("INSERT INTO tbl_ilan (aciklama,araba_id) VALUES(@aciklama,@id)", p, true);
        }

        public Ilan IlanBilgisi(int id)
        {
            SqlParameter[] p = { new SqlParameter("@ilanid", id) };
            Ilan ilan = null;
            SqlDataReader dr = help.ExecuteReader("SELECT aciklama,ilan_tarihi FROM tbl_ilan WHERE ilan_id=@ilanid", p);
            if (dr.Read())
            {
                ilan = new Ilan();
                ilan.Aciklama = dr["aciklama"].ToString();
                ilan.IlanTarihi = (DateTime)dr["ilan_tarihi"];
            }
            dr.Close();
            return ilan;
        }

        public bool IlanGuncelle(Ilan iln)
        {
            SqlParameter[] p = { new SqlParameter("@ilanid", iln.IlanId), new SqlParameter("@aciklama", iln.Aciklama), new SqlParameter("@arabaid", iln.ArabaId) };
            return help.ExecuteNonQuery("UPDATE tbl_ilan set aciklama=@aciklama,araba_id=@arabaid WHERE ilan_id=@ilanid",p,true) > 0;
        }

        public bool IlanSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@ilanid", id) };

            return help.ExecuteNonQuery("DELETE FROM tbl_ilan WHERE ilan_id=@ilanid", p) > 0;
        }

        public void Dispose()
        {
            help.Dispose();
        }
        public void DisposeCmd()
        {
            help.DisposeCmd();
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

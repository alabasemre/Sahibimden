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
        Helper help = Helper.getInstance();
        public bool IlanEkle(Ilan ilan)
        {
            SqlParameter[] p = { new SqlParameter("@aciklama", ilan.Aciklama), new SqlParameter("@id", ilan.ArabaId) };

            return 0 < help.ExecuteNonQuery("INSERT INTO tbl_ilan (aciklama,araba_id) VALUES(@aciklama,@id)", p,true);
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

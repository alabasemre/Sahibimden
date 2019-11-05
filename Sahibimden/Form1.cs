using SahibimdenBLL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibimden
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //string[] ad =
        //{
        //    "Yıl",
        //    "Yakıt Tipi",
        //    "Vites Tipi",
        //    "Kilometre",
        //    "Kasa Tipi",
        //    "Motor Gücü",
        //    "Motor Hacmi",
        //    "Renk",
        //    "Fiyat",
        //    "Durum"
        //};
            
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ArabaOzellik araba = new ArabaOzellik();
            
            araba.Yil = txtYil.Text;
            araba.YakitTipi = cbYakit.Text;
            araba.VitesTipi = cbVites.Text;
            araba.KM = txtKM.Text;
            araba.KasaTipi = cbKasaTipi.Text;
            araba.MotorGucu = txtMotorGucu.Text;
            araba.MotorHacmi = txtMotorHacmi.Text;
            araba.Renk = cbRenk.Text;
            araba.Fiyat = txtFiyat.Text;
            araba.Durum = cbDurum.Text;
    
            Ilan ilan = new Ilan();
            ArabaBL arabaBL = new ArabaBL();

            ilan.Aciklama = txtAciklama.Text;
            ilan.ArabaId = cbModel.Text;

            if (arabaBL.IlanEkle(ilan) && arabaBL.ArabaOzellikEkle(araba))
            {
                MessageBox.Show("Ekleme Başarılı");
            }           
                 
        }    
    }
}

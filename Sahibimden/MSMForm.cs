using SahibimdenBLL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibimden
{
    public partial class MSMForm : Form
    {
        ArabaBL arabaBL = null;
        int markaId;
        public MSMForm()
        {
            InitializeComponent();
        }

        private void MSMForm_Load(object sender, EventArgs e)
        {
            GetMarka();
        }

        void GetMarka()
        {
            arabaBL = new ArabaBL();
            List<Araba> markaList = arabaBL.AracListele(0);
            markaList.RemoveAt(0);
            dgvMarkaList.DataSource = markaList;
            dgvMarkaList.Columns[2].Visible = false;
            arabaBL.Dispose();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Araba araba = null;
            try
            {
                if (MarkaKontrol())
                {
                    MessageBox.Show("Marka Adını Giriniz...");
                    return;
                }
                arabaBL = new ArabaBL();

                araba = new Araba();
                araba.Ad = txtMarka.Text.Trim();
                araba.UstKategori = 0;

                if (arabaBL.KayitVarmi(araba))
                {
                    MessageBox.Show("Aynı Ada Sahip Marka Var", "Aynı Adlı Marka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arabaBL.Dispose();
                    return;
                }

                if (btnMarkaEkle.Text == "Marka Ekle")
                {
                    MessageBox.Show(arabaBL.ArabaEkle(araba) ? "Ekleme Başarılı" : "Ekleme Yapılamadı");
                }
                else
                {
                    araba.ArabaId = markaId;
                    MessageBox.Show(arabaBL.Guncelle(araba) ? "Güncelleme Başarılı" : "Güncelleme Yapılamadı");
                }
                GetMarka();
                MarkaTemizle();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                MainFormYenile();
                arabaBL.Dispose();
            }
        }

        bool MarkaKontrol()
        {
            return txtMarka.Text.Trim() == "";
        }
        void MarkaTemizle()
        {
            txtMarka.Text = "";
            btnMarkaEkle.Text = "Marka Ekle";
            dgvMarkaList.ClearSelection();
            btnMarkaSil.Visible = false;
        }

        private void btnMarkaVazgec_Click(object sender, EventArgs e)
        {
            MarkaTemizle();
        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            if (markaId == 0)
            {
                MessageBox.Show("Silinecek Markayı Seçin...");
                return;
            }

            try
            {
                if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    arabaBL = new ArabaBL();
                    if (arabaBL.Sil(markaId))
                    {
                        MessageBox.Show("Silme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetMarka();
                        MarkaTemizle();
                        MainFormYenile();
                    }
                    else
                    {
                        MessageBox.Show("Silme Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi..", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                arabaBL.Dispose();
            }
        }

        void MainFormYenile()
        {
            MainForm mn = (MainForm)Application.OpenForms["MainForm"];
            mn.ListeYenile();
            mn.GetMarka();
        }

        private void dgvMarkaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            markaId = (int)dgvMarkaList.CurrentRow.Cells[0].Value;
            txtMarka.Text = dgvMarkaList.CurrentRow.Cells[1].Value.ToString();
            btnMarkaEkle.Text = "Güncelle";
            btnMarkaSil.Visible = true;
        }
    }
}

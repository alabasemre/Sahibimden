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
    public partial class OzellikForm : Form
    {
        int ustKategoriId;
        int altKategoriId;

        public OzellikForm()
        {
            InitializeComponent();
            dgvUstKategori.AutoGenerateColumns = false;
            dgvSecenek.AutoGenerateColumns = false;
        }

        private void OzellikForm_Load(object sender, EventArgs e)
        {
            UstKategoriListele();
        }

        private void UstKategoriListele()
        {
            using (SahibimdenContext ctx = new SahibimdenContext())
            {
                dgvUstKategori.DataSource = ctx.tbl_kategori.Where(ent => ent.ust_kategori == 0).ToList();

                cmbUstKategori.DisplayMember = "ad";
                cmbUstKategori.ValueMember = "kategori_id";
                cmbUstKategori.DataSource = ctx.tbl_kategori.Where(ent => ent.ust_kategori == 0).ToList();
            }
        }

        private void dgvUstKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUstKategori.Text = dgvUstKategori.CurrentRow.Cells["clmKategori"].Value.ToString();
            ustKategoriId = (int)dgvUstKategori.CurrentRow.Cells["clmKategoriId"].Value;
            btnEkle.Text = "Güncelle";
            btnSil.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (EksikVarMiUst())
            {
                MessageBox.Show("Lütfen Bilgiler Eksiksiz Girin...");
                return;
            }
            try
            {

                using (SahibimdenContext ctx = new SahibimdenContext())
                {
                    string kategoriAdi = txtUstKategori.Text.Trim();
                    tbl_kategori kategori;

                    if (ctx.tbl_kategori.Where(ent => ent.ad == kategoriAdi).Count() == 0)
                    {
                        if (ustKategoriId == 0)
                        {
                            kategori = new tbl_kategori { ad = kategoriAdi, ust_kategori = 0 };
                            ctx.tbl_kategori.Add(kategori);
                        }
                        else
                        {
                            kategori = ctx.tbl_kategori.Find(ustKategoriId);
                            kategori.ad = kategoriAdi;
                        }
                        ctx.SaveChanges();
                        UstKategoriListele();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Kategori Zaten Var");
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }


        private bool EksikVarMiUst()
        {
            return txtUstKategori.Text.Trim() == "";
        }

        private bool EksikVarMiAlt()
        {
            return txtSecenek.Text.Trim() == "";
        }

        private void Temizle()
        {
            ustKategoriId = 0;
            btnEkle.Text = String.Empty;
            btnSil.Visible = false;
            txtUstKategori.Text = String.Empty;
            dgvUstKategori.ClearSelection();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SahibimdenContext ctx = new SahibimdenContext())
            {
                if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctx.tbl_kategori.Remove(ctx.tbl_kategori.Find(ustKategoriId));

                    List<tbl_kategori> kat = ctx.tbl_kategori.Where(ent => ent.ust_kategori == ustKategoriId).ToList();

                    foreach (tbl_kategori kategori in kat)
                    {
                        ctx.tbl_kategori.Remove(kategori);
                    }

                    ctx.SaveChanges();
                    Temizle();
                    UstKategoriListele();                    
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void cmbUstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecenekListele();
        }

        private void dgvSecenek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSecenek.Text = dgvSecenek.CurrentRow.Cells["clmSecenek"].Value.ToString();
            altKategoriId = (int)dgvSecenek.CurrentRow.Cells["clmAltKategoriId"].Value;
            btnSecenekEkle.Text = "Guncelle";
            btnSecenekSil.Visible = true;
        }

        private void btnSecenekEkle_Click(object sender, EventArgs e)
        {
            if (EksikVarMiAlt() || cmbUstKategori.SelectedIndex <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Girin...");
                return;
            }
            try
            {

                using (SahibimdenContext ctx = new SahibimdenContext())
                {
                    string kategoriAdi = txtSecenek.Text.Trim();
                    tbl_kategori kategori;
                    int ustKat = (int)cmbUstKategori.SelectedValue;
                    if (ctx.tbl_kategori.Where(ent => ent.ad == kategoriAdi).Count() == 0)
                    {
                        if (altKategoriId == 0)
                        {
                            kategori = new tbl_kategori { ad = kategoriAdi, ust_kategori = ustKat };
                            ctx.tbl_kategori.Add(kategori);
                        }
                        else
                        {
                            kategori = ctx.tbl_kategori.Find(altKategoriId);
                            kategori.ad = kategoriAdi;
                        }
                        ctx.SaveChanges();
                        SecenekListele();
                        SecenekTemizle();
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Secenek Zaten Var");
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }

        void SecenekListele()
        {
            int ustKategoriId = (int)cmbUstKategori.SelectedValue;
            using (SahibimdenContext ctx = new SahibimdenContext())
            {
                dgvSecenek.DataSource = ctx.tbl_kategori.Where(ent => ent.ust_kategori == ustKategoriId).ToList();
            }
        }

        void SecenekTemizle()
        {
            txtSecenek.Text = String.Empty;
            btnSecenekEkle.Text = "Ekle";
            btnSecenekSil.Visible = false;
            altKategoriId = 0;
        }

        private void btnSecenekVazgec_Click(object sender, EventArgs e)
        {
            SecenekTemizle();
        }

        private void btnSecenekSil_Click(object sender, EventArgs e)
        {
            using (SahibimdenContext ctx = new SahibimdenContext())
            {
                if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctx.tbl_kategori.Remove(ctx.tbl_kategori.Find(altKategoriId));

                    ctx.SaveChanges();
                    SecenekTemizle();
                    SecenekListele();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

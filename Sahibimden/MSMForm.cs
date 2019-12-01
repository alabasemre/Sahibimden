using SahibimdenBLL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int seriId;
        int modelId;
        public MSMForm()
        {
            InitializeComponent();
        }

        private void MSMForm_Load(object sender, EventArgs e)
        {
            GetMarka();
            GetSeri();
            GetModel();
        }

        void GetMarka()
        {
            try
            {
                arabaBL = new ArabaBL();

                List<Araba> markaList = arabaBL.AracListele(0);
                markaList.RemoveAt(0);

                dgvMarkaList.DataSource = markaList;
                dgvMarkaList.Columns[2].Visible = false;

                cmbMarka.DisplayMember = "Ad";
                cmbMarka.ValueMember = "ArabaId";
                cmbMarka.DataSource = arabaBL.AracListele(0);

                GetSeri();               
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

        void GetSeri()
        {
            try
            {
                arabaBL = new ArabaBL();

                List<Araba> seriList = arabaBL.SeriListele();
                seriList.RemoveAt(0);

                dgvSeriList.DataSource = seriList;
                dgvSeriList.Columns[2].Visible = false;

                cmbSeri.DisplayMember = "Ad";
                cmbSeri.ValueMember = "ArabaId";
                cmbSeri.DataSource = arabaBL.SeriListele();

                GetModel();
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

        void GetModel()
        {
            try
            {
                arabaBL = new ArabaBL();

                List<Araba> modelList = arabaBL.ModelListele();
                modelList.RemoveAt(0);

                dgvModelListe.DataSource = modelList;
                dgvModelListe.Columns[2].Visible = false;
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

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Araba araba = null;
            try
            {
                if (txtMarka.Text.Trim() == "")
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

        void MarkaTemizle()
        {
            markaId = 0;
            txtMarka.Text = "";
            btnMarkaEkle.Text = "Marka Ekle";
            dgvMarkaList.ClearSelection();
            btnMarkaSil.Visible = false;
            GetMarka();
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
            try
            {
                MainForm mn = (MainForm)Application.OpenForms["MainForm"];
                mn.GetMarka();
            }
            catch (Exception)
            {

            }
        }

        private void dgvMarkaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                markaId = (int)dgvMarkaList.CurrentRow.Cells[0].Value;
                txtMarka.Text = dgvMarkaList.CurrentRow.Cells[1].Value.ToString();
                btnMarkaEkle.Text = "Güncelle";
                btnMarkaSil.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvSeriList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSeri.Text = dgvSeriList.CurrentRow.Cells[1].Value.ToString();
                cmbMarka.SelectedValue = (int)dgvSeriList.CurrentRow.Cells["UstKategori"].Value;
                btnSeriEkle.Text = "Güncelle";
                btnSeriSil.Visible = true;
                seriId = (int)dgvSeriList.CurrentRow.Cells[0].Value;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnSeriVazgec_Click(object sender, EventArgs e)
        {
            SeriTemizle();
        }
        private void SeriTemizle()
        {
            try
            {
                btnSeriSil.Visible = false;
                cmbMarka.SelectedIndex = 0;
                btnSeriEkle.Text = "Seri Ekle";
                txtSeri.Text = "";
                dgvSeriList.ClearSelection();
                seriId = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSeriEkle_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex == 0 || txtSeri.Text.Trim() == "")
            {
                MessageBox.Show("Marka Seçin ve Seri Adını Girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Araba araba = null;
            try
            {
                arabaBL = new ArabaBL();
                araba = new Araba();
                araba.Ad = txtSeri.Text.Trim();
                araba.UstKategori = (int)cmbMarka.SelectedValue;

                if (arabaBL.KayitVarmi(araba))
                {
                    MessageBox.Show("Aynı Ada Sahip Seri Var", "Aynı Adlı Seri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arabaBL.Dispose();
                    return;
                }

                if (seriId == 0)
                {
                    MessageBox.Show(arabaBL.ArabaEkle(araba) ? "Seri Ekleme Başarılı" : "Ekleme Yapılamadı");
                }
                else
                {
                    araba.ArabaId = seriId;
                    MessageBox.Show(arabaBL.Guncelle(araba) ? "Seri Güncelleme Başarılı" : "Güncelleme Yapılamadı");
                }
                SeriTemizle();
                GetSeri();
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

        private void btnSeriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    arabaBL = new ArabaBL();
                    if (arabaBL.Sil(seriId))
                    {
                        MessageBox.Show("Silme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetSeri();
                        SeriTemizle();
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

        private void dgvModelListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {             
                modelId = (int)dgvModelListe.CurrentRow.Cells["ArabaId"].Value;
                txtModel.Text = dgvModelListe.CurrentRow.Cells["Ad"].Value.ToString();
                cmbSeri.SelectedValue = (int)dgvModelListe.CurrentRow.Cells["UstKategori"].Value;
                btnModelSil.Visible = true;
                btnModelEkle.Text = "Güncelle";
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

        void ModelTemizle()
        {
            txtModel.Text = "";
            btnModelSil.Visible = false;
            btnModelEkle.Text = "Model Ekle";
            cmbSeri.SelectedIndex = 0;
            dgvModelListe.ClearSelection();
            modelId = 0;
        }

        private void btnModelTemizle_Click(object sender, EventArgs e)
        {
            ModelTemizle();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            if (cmbSeri.SelectedIndex == 0 || txtModel.Text.Trim() == "")
            {
                MessageBox.Show("Seri Seçin ve Model Adını Girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Araba araba = null;
            try
            {
                arabaBL = new ArabaBL();
                araba = new Araba();
                araba.Ad = txtModel.Text.Trim();
                araba.UstKategori = (int)cmbSeri.SelectedValue;

                if (arabaBL.KayitVarmi(araba))
                {
                    MessageBox.Show("Aynı Ada Sahip Seri Var", "Aynı Adlı Seri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arabaBL.Dispose();
                    return;
                }

                if (modelId == 0)
                {
                    MessageBox.Show(arabaBL.ArabaEkle(araba) ? "Seri Ekleme Başarılı" : "Ekleme Yapılamadı");
                }
                else
                {
                    araba.ArabaId = modelId;
                    MessageBox.Show(arabaBL.Guncelle(araba) ? "Seri Güncelleme Başarılı" : "Güncelleme Yapılamadı");
                }
                ModelTemizle();
                GetModel();
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

        private void btnModelSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    arabaBL = new ArabaBL();
                    if (arabaBL.Sil(modelId))
                    {
                        MessageBox.Show("Silme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetModel();
                        ModelTemizle();
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

        private void btnMarkaAra_Click(object sender, EventArgs e)
        {
            if (txtMarkaAra.Text.Trim() == "")
            {
                MessageBox.Show("Aranacak Markayı Girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                arabaBL = new ArabaBL();
                if (arabaBL.MarkaAra(txtMarkaAra.Text.Trim()).Count == 0)
                {
                    MessageBox.Show("Marka Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                markaId = 0;
                txtMarka.Text = "";
                btnMarkaEkle.Text = "Marka Ekle";
                btnMarkaSil.Visible = false;

                dgvMarkaList.DataSource = arabaBL.MarkaAra(txtMarkaAra.Text.Trim());
                dgvMarkaList.ClearSelection();

                txtMarkaAra.Text = "";
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

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSeri.Text.Trim()!="")
                {
                    return;
                }
                List<Araba> seriList;
                arabaBL = new ArabaBL();
                if (cmbMarka.SelectedIndex == 0)
                {
                    seriList = arabaBL.SeriListele();
                    seriList.RemoveAt(0);

                    dgvSeriList.DataSource = seriList;
                    dgvSeriList.Columns[2].Visible = false;

                    return;
                }

                seriList = arabaBL.AracListele((int)cmbMarka.SelectedValue);
                seriList.RemoveAt(0);
                if (seriList.Count == 0)
                {
                    MessageBox.Show("Bu Markaya Ait Seri Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvSeriList.DataSource = seriList;
                dgvSeriList.Columns[2].Visible = false;
                SeriAraTemizle();
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

        void SeriAraTemizle()
        {
            btnSeriSil.Visible = false;
            btnSeriEkle.Text = "Seri Ekle";
            txtSeri.Text = "";
            dgvSeriList.ClearSelection();
            seriId = 0;
        }
      
    }
}

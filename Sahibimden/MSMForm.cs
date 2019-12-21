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
        int seriId;
        int modelId;
        DataTable markaDT;
        public MSMForm()
        {
            InitializeComponent();
            dgvMarkaList.AutoGenerateColumns = false;
        }

        private void MSMForm_Load(object sender, EventArgs e)
        {
            GetMarka();
            GetSeri();
            GetMarkaCMB();
        }

        void GetMarka()
        {
            try
            {
                arabaBL = new ArabaBL();

                List<Araba> markaList = arabaBL.AracListele(0);
                markaList.RemoveAt(0);

                markaDT= arabaBL.MarkaListele();
                dgvMarkaList.DataSource = markaDT;             

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

        void GetMarkaCMB()
        {
            try
            {
                arabaBL = new ArabaBL();

                cmbModMarka.DisplayMember = "Ad";
                cmbModMarka.ValueMember = "ArabaId";
                cmbModMarka.DataSource = arabaBL.AracListele(0);
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
                dgvSeriList.Columns[0].Visible = false;
                dgvSeriList.Columns[2].Visible = false;               

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

        void GetSeriCMB()
        {
            try
            {
                arabaBL = new ArabaBL();

                cmbSeri.DisplayMember = "Ad";
                cmbSeri.ValueMember = "ArabaId";
                cmbSeri.DataSource = arabaBL.AracListele((int)cmbModMarka.SelectedValue);
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

                List<Araba> modelList = arabaBL.AracListele((int)cmbSeri.SelectedValue);
                modelList.RemoveAt(0);

                dgvModelList.DataSource = modelList;
                dgvModelList.Columns[0].Visible = false;
                dgvModelList.Columns[2].Visible = false;
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

        private void dgvModelList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                modelId = (int)dgvModelList.CurrentRow.Cells["ArabaId"].Value;
                txtModel.Text = dgvModelList.CurrentRow.Cells["Ad"].Value.ToString();
                cmbSeri.SelectedValue = (int)dgvModelList.CurrentRow.Cells["UstKategori"].Value;
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
            cmbSeri.SelectedIndex =0;
            cmbModMarka.SelectedIndex = 0;
            dgvModelList.ClearSelection();
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
                    MessageBox.Show("Aynı Ada Sahip Model Var", "Aynı Adlı Seri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arabaBL.Dispose();
                    return;
                }

                if (modelId == 0)
                {
                    MessageBox.Show(arabaBL.ArabaEkle(araba) ? "Model Ekleme Başarılı" : "Ekleme Yapılamadı");
                }
                else
                {
                    araba.ArabaId = modelId;
                    MessageBox.Show(arabaBL.Guncelle(araba) ? "Model Güncelleme Başarılı" : "Güncelleme Yapılamadı");
                }
                ModelTemizle();
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

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSeri.Text.Trim() != "")
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

        private void cmbModMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbModMarka.SelectedIndex == 0)
                {
                    cmbSeri.Enabled = false;
                    cmbSeri.SelectedIndex = 0;
                    return;
                }
                cmbSeri.Enabled = true;
                Debug.WriteLine((int)cmbModMarka.SelectedValue);
                GetSeriCMB();
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        private void cmbSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSeri.SelectedIndex == 0)
                {
                    dgvModelList.DataSource = null;
                    return;
                }
                GetModel();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in markaDT.Rows)
            {
                arabaBL = new ArabaBL();
                if (item.RowState == DataRowState.Deleted)
                {
                    arabaBL.Sil((int)item["araba_id",DataRowVersion.Original]);
                }
                else
                {
                    Araba araba = new Araba();
                    araba.Ad = item["ad"].ToString();
                    araba.UstKategori = 0;
                    switch (item.RowState)
                    {                                  
                        case DataRowState.Added:
                            arabaBL.ArabaEkle(araba);
                            break;                       
                        case DataRowState.Modified:
                            araba.ArabaId = (int)item["araba_id"];
                            arabaBL.Guncelle(araba);
                            break;
                        default:
                            break;
                    }
                }
            }
            GetMarka();
            GetMarkaCMB();
            txtMarkaAra.Text = "";
        }

        private void txtMarkaAra_TextChanged(object sender, EventArgs e)
        {
            //dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, textBox1.Text);
            markaDT.DefaultView.RowFilter= string.Format("[{0}] LIKE '%{1}%'", "Ad", txtMarkaAra.Text);
        }

        private void MSMForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFormYenile();
        }
    }
    
}

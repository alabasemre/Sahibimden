﻿using Sahibimden.languages.tr;
using SahibimdenBLL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibimden
{
    public partial class MainForm : Form
    {
        List<Kategori> kategoriler = null;
        KategoriBL kategori = null;
        ArabaBL araba = null;
        IlanBL ilanBL = null;
        OzellikBL ozellikBL = null;
        ResimBL resimBL = null;
        ListeBL listeBL = null;

        string resimYolu = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetMarka();
                FormOlustur();
                CBoxOlustur();
                ListeYenile();
            }
            catch (Exception)
            {
                // TODO
            }
        }
        public void GetMarka()
        {
            araba = new ArabaBL();

            cmbMarka.DisplayMember = "Ad";
            cmbMarka.ValueMember = "ArabaId";
            cmbMarka.DataSource = araba.AracListele(0);

            araba.Dispose();
        }
        private void GetSeri()
        {
            araba = new ArabaBL();

            cmbSeri.Enabled = true;
            cmbSeri.DisplayMember = "Ad";
            cmbSeri.ValueMember = "ArabaId";
            cmbSeri.DataSource = araba.AracListele((int)cmbMarka.SelectedValue);

            araba.Dispose();
        }
        private void GetModel()
        {
            araba = new ArabaBL();

            cmbModel.Enabled = true;
            cmbModel.DisplayMember = "Ad";
            cmbModel.ValueMember = "ArabaId";
            cmbModel.DataSource = araba.AracListele((int)cmbSeri.SelectedValue);

            araba.Dispose();
        }

        private void FormOlustur()
        {
            kategori = new KategoriBL();
            kategoriler = kategori.KategoriListele(0);

            for (int i = 0; i < kategoriler.Count; i++)
            {
                Label label = new Label();
                label.Text = kategoriler[i].Ad;
                label.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

                if (kategori.KategoriListele(kategoriler[i].KategoriId).Count == 0)
                {
                    TboxOlustur(i);
                }
                else
                {
                    CmbOlustur(i);
                }
                label.Location = new Point(10, i * 25 + 10);
                pnlLabel.Controls.Add(label);
            }           
            kategori.Dispose();
        }

        private void TboxOlustur(int i)
        {
            TextBox txtBox = new TextBox();
            txtBox.Location = new Point(10, i * 25 + 10);
            txtBox.KeyPress += TxtBox_KeyPress;
            pnlBoxs.Controls.Add(txtBox);
        }

        private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8))
            {
                MessageBox.Show("Verileri Rakamsal Girin...", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void CmbOlustur(int i)
        {
            ComboBox cmb = new ComboBox();

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb.DisplayMember = "Ad";
            cmb.ValueMember = "KategoriId";
            cmb.DataSource = kategori.KategoriListele(kategoriler[i].KategoriId);
            cmb.Location = new Point(10, i * 25 + 10);

            pnlBoxs.Controls.Add(cmb);

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != 0)
            {
                GetSeri();
            }
            else
            {
                cmbSeri.Enabled = false;
                cmbModel.Enabled = false;
            }
        }

        private void cmbSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != 0 && cmbSeri.SelectedIndex != 0)
            {
                GetModel();
            }
            else
            {
                cmbModel.Enabled = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (IlanKontrol() && OzellikKontrol() && resimYolu != string.Empty)
                {
                    if (MessageBox.Show(TurkishLang.CONFIRM_MESSAGE, "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (IlanOlustur())
                        {
                            SetOzellik();
                            ResimEkle();
                        }
                        else
                        {
                            return;
                        }
                      
                        ilanBL.Commit();
                        MessageBox.Show("Ekleme Başarılı");
                        ListeYenile();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme İptal Edildi");
                    }
                }
                else
                {
                    MessageBox.Show("Araba Seçimi Yapın ve Boş Alanları Doldurun Resim Eklemeyi Unutmayın....");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı Hatası İşlem Geri Alındı");
                if (ilanBL != null)
                {
                    MessageBox.Show("Test");
                    ilanBL.Rollback();
                }              
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Verileri Rakamsal Girin....");
            }
            finally
            {
                if (ilanBL != null)
                {
                    ilanBL.Dispose();
                }              
            }
        }

        private void SetOzellik()
        {
            ozellikBL = new OzellikBL();
            try
            {
                for (int i = 0; i < kategoriler.Count; i++)
                {
                    Ozellik ozellik = new Ozellik();
                    ozellik.kategori_id = kategoriler[i].KategoriId;
                    if (pnlBoxs.Controls[i] is TextBox)
                    {
                        ozellik.deger = pnlBoxs.Controls[i].Text.Trim();
                    }
                    else
                    {
                        ComboBox cmb = (ComboBox)pnlBoxs.Controls[i];
                        ozellik.deger = cmb.SelectedValue.ToString();
                    }
                    ozellikBL.ArabaOzellikEkle(ozellik);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ozellikBL.DisposeCmd();
            }

        }
        private bool IlanOlustur()
        {
            try
            {
                ilanBL = new IlanBL();
                Ilan iln = new Ilan();

                iln.Aciklama = richBoxAciklama.Text;
                iln.ArabaId = (int)cmbModel.SelectedValue;

                return ilanBL.IlanEkle(iln);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ilanBL.DisposeCmd();
            }
        }

        private bool IlanKontrol()
        {
            bool kontrol = true;
            if (cmbModel.SelectedIndex == 0 || cmbSeri.SelectedIndex == 0 || cmbMarka.SelectedIndex == 0)
            {
                kontrol = false;
            }
            else if (cmbSeri.Enabled == false || cmbModel.Enabled == false)
            {
                kontrol = false;
            }

            return kontrol;
        }

        private bool OzellikKontrol()
        {
            bool kontrol = true;

            try
            {
                for (int i = 0; i < pnlBoxs.Controls.Count; i++)
                {
                    if (pnlBoxs.Controls[i] is TextBox)
                    {
                        int.Parse(pnlBoxs.Controls[i].Text.Trim());
                        if (pnlBoxs.Controls[i].Text.Trim() == "")
                        {
                            kontrol = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return kontrol;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            dialogResim.Title = "Resim Seçimi";
            dialogResim.Filter = "Jpeg Dosyası (*.jpg)|*.jpg";
            if (dialogResim.ShowDialog() == DialogResult.OK)
            {
                picBoxAraba.Image = Image.FromFile(dialogResim.FileName);
                resimYolu = dialogResim.FileName.ToString();
            }
        }

        private void ResimEkle()
        {
            try
            {
                FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] resim = br.ReadBytes((int)fs.Length);
                br.Close();
                br.Dispose();
                fs.Close();
                fs.Dispose();

                resimBL = new ResimBL();
                resimBL.ResimEkle(resim);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                resimBL.DisposeCmd();
            }
        }

        void CBoxOlustur()
        {
            for (int i = 0; i < kategoriler.Count; i++)
            {
                CheckBox cbox = new CheckBox();
                cbox.Text = kategoriler[i].Ad;
                cbox.Location = new Point(20, i * 20 + 20);
                cbox.CheckedChanged += Cbox_CheckedChanged;
                gbxChecks.Controls.Add(cbox);
            }
        }

        private void Cbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbox = (CheckBox)sender;
                if (cbox.Checked)
                {
                    ozellikBL = new OzellikBL();

                    dgvilan.Columns.Add(cbox.Text, cbox.Text);

                    List<Ozellik> liste = ozellikBL.OzellikGetir(cbox.Text);

                    for (int i = 0; i < liste.Count; i++)
                    {
                        dgvilan.Rows[i].Cells[cbox.Text].Value = liste[i].deger;
                    }
                }
                else
                {
                    dgvilan.Columns.Remove(cbox.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ozellikBL.Dispose();
            }
        }

        public void ListeYenile()
        {
            try
            {
                listeBL = new ListeBL();

                dgvilan.DataSource = listeBL.Listele();

                dgvilan.Columns["IlanId"].Visible = false;

                DataGridViewColumn col = dgvilan.Columns[1];
                //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;         
                ((DataGridViewImageColumn)dgvilan.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                listeBL.Dispose();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            cmbMarka.SelectedIndex = 0;
            picBoxAraba.Image = null;

            for (int i = 0; i < pnlBoxs.Controls.Count; i++)
            {
                if (pnlBoxs.Controls[i] is TextBox)
                {
                    pnlBoxs.Controls[i].Text = "";
                }
            }
        }

        private void menuMSMislem_Click(object sender, EventArgs e)
        {
            MSMForm msmForm = new MSMForm();
            msmForm.ShowDialog();
        }

        private void dgvilan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AracDetay frmAracDetay = new AracDetay((int)dgvilan.CurrentRow.Cells[0].Value);
            frmAracDetay.ShowDialog();
        }
    }
}

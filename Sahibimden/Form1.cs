using SahibimdenBLL;
using SahibimdenMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibimden
{
    public partial class MenuForm : Form
    {
        List<Kategori> kategoriler = null;
        KategoriBL kategori = null;
        ArabaBL araba = null;
        IlanBL ilanBL = null;
        OzellikBL ozellikBL = null;
        string resimYolu=string.Empty;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetMarka();
            FormOlustur();
        }

        private void GetMarka()
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
            pnlBoxs.Controls.Add(txtBox);
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
                    if (MessageBox.Show("Ekleme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo)==DialogResult.Yes) 
                    {
                        IlanOlustur();
                        SetOzellik();
                        ResimEkle();
                        MessageBox.Show("Ekleme Başarılı");
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
            catch (Exception)
            {
                MessageBox.Show("Verileri Rakamsal Girin....");
            }
            finally
            {
                if (ilanBL != null)
                {
                    ilanBL.Dispose();
                }
                if (ozellikBL != null)
                {
                    ozellikBL.Dispose();
                }
            }
        }

        private void SetOzellik()
        {
            ozellikBL = new OzellikBL();

            for (int i = 0; i < kategoriler.Count; i++)
            {
                Ozellik ozellik = new Ozellik();
                ozellik.kategori_id = kategoriler[i].KategoriId;
                if (pnlBoxs.Controls[i] is TextBox)
                {
                    ozellik.deger = int.Parse(pnlBoxs.Controls[i].Text);
                }
                else
                {
                    ComboBox cmb = (ComboBox)pnlBoxs.Controls[i];
                    ozellik.deger = (int)cmb.SelectedValue;
                }
                ozellikBL.ArabaOzellikEkle(ozellik);
            }
        }

        private void IlanOlustur()
        {
            ilanBL = new IlanBL();
            Ilan iln = new Ilan();

            iln.Aciklama = richBoxAciklama.Text;
            iln.ArabaId = (int)cmbModel.SelectedValue;

            ilanBL.IlanEkle(iln);
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
            dialogResim.Filter= "Jpeg Dosyası (*.jpg)|*.jpg";
            if (dialogResim.ShowDialog()==DialogResult.OK)
            {
                picBoxAraba.Image = Image.FromFile(dialogResim.FileName);
                resimYolu = dialogResim.FileName.ToString();
            }
        }

        private void ResimEkle()
        {
            FileStream fs = new FileStream(resimYolu,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            br.Dispose();
            fs.Close();
            fs.Dispose();

            ResimBL resimBL = new ResimBL();
            resimBL.ResimEkle(resim);
            resimBL.Dispose();
        }
   
    }
}

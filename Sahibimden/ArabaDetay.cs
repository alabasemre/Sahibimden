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
    public partial class AracDetay : Form
    {
        int ilanId;
        IlanBL ilanBL = null;
        ArabaBL arabaBL = null;
        MainForm frm = null;
        int markaid;
        int seriid;
        int modelid;
        public AracDetay()
        {
            InitializeComponent();
        }

        public AracDetay(int id, string[] msm)
        {
            InitializeComponent();
            this.ilanId = id;

            lblMarkatxt.Text = msm[0];
            lblSeritxt.Text = msm[1];
            lblModeltxt.Text = msm[2];

            try
            {
                IlanGetir();
                OzellikGetir();
                ResimGetir();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ResimGetir()
        {
            ResimBL resimBL = null;
            try
            {
                resimBL = new ResimBL();
                picAraba.Image = resimBL.ArabaResmi(ilanId);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                resimBL.Dispose();
            }
        }

        private void OzellikGetir()
        {
            OzellikBL ozellikBL = null;
            try
            {
                ozellikBL = new OzellikBL();
                dgvAracDetay.DataSource = ozellikBL.AracDetayGetir(this.ilanId);
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

        private void IlanGetir()
        {
            try
            {
                ilanBL = new IlanBL();
                Ilan ilan = ilanBL.IlanBilgisi(ilanId);
                lblTarihtxt.Text = ilan.IlanTarihi.ToString();
                rcTxtAciklama.Text = ilan.Aciklama;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ilanBL.Dispose();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İlan Silinsin Mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ilanBL = new IlanBL();
                    if (ilanBL.IlanSil(ilanId))
                    {
                        frm = (MainForm)Application.OpenForms["MainForm"];
                        frm.ListeYenile();
                        MessageBox.Show("İlan Silindi", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    ilanBL.Dispose();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                frm = (MainForm)Application.OpenForms["MainForm"];
                frm.picBoxAraba.Image = picAraba.Image;
                for (int i = 0; i < frm.pnlBoxs.Controls.Count; i++)
                {
                    if (frm.pnlBoxs.Controls[i] is TextBox)
                    {
                        frm.pnlBoxs.Controls[i].Text = dgvAracDetay.Rows[i].Cells["clmDeger"].Value.ToString();
                    }
                    else
                    {
                        ComboBox cmb = (ComboBox)frm.pnlBoxs.Controls[i];
                        cmb.SelectedItem = dgvAracDetay.Rows[i].Cells["clmDeger"].Value.ToString();
                    }
                }
                frm.tabMenu.SelectedTab = frm.tabMenu.TabPages[0];

                MainFormModel();
                MainFormSeri();
                MainFormMarka();

                frm.cmbMarka.SelectedValue = markaid;
                frm.cmbSeri.SelectedValue = seriid;
                frm.cmbModel.SelectedValue = modelid;
                frm.ilanid = this.ilanId;
                frm.btnKaydet.Visible = false;
                frm.btnGuncelle.Visible = true;

                frm.richBoxAciklama.Text = rcTxtAciklama.Text;
            }
            catch (Exception)
            {
               //TODO
            }

            this.Close();
        }
        private void MainFormMarka()
        {
            try
            {
                arabaBL = new ArabaBL();
                markaid = arabaBL.MarkaSeriId(seriid);                
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

        private void MainFormSeri()
        {
            try
            {
                arabaBL = new ArabaBL();
                seriid = arabaBL.MarkaSeriId(modelid);           
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

        private void MainFormModel()
        {
            try
            {
                arabaBL = new ArabaBL();
                modelid = arabaBL.ModelId(ilanId);
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
    }
}

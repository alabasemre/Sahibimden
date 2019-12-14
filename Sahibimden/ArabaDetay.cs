using SahibimdenBLL;
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
    public partial class AracDetay : Form
    {
        int ilanId;
        public AracDetay()
        {
            InitializeComponent();
        }

        public AracDetay(int id)
        {
            InitializeComponent();
            this.ilanId = id;

            OzellikBL ozellikBL = new OzellikBL();
            dgvAracDetay.DataSource = ozellikBL.AracDetayGetir(this.ilanId);           
            ozellikBL.Dispose();       
        }
    }
}

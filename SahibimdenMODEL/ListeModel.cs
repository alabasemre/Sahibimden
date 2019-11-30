using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibimdenMODEL
{
    public class ListeModel
    {
        public int IlanId { get; set; }
        public Image Img { get; set; }        
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Seri { get; set; }
        public string Aciklama { get; set; }
        public DateTime IlanTarihi { get; set; }           
    }
}

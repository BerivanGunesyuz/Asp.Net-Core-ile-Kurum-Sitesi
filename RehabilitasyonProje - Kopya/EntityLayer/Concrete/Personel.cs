using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string Aciklama { get; set; }
        public string ResimUrl { get; set; }
        public string Baslik { get; set; }
    }
}

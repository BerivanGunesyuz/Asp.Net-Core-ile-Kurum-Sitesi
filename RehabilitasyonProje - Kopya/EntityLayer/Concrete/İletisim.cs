using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class İletisim
    {
        [Key]
        public int MesajId { get; set; }
            public string Ad { get; set; }
            public string Email { get; set; }
            public string Konu { get; set; }
            public DateTime GonderimTarihi { get; set; }
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Sinif { get; set; }
    }
}

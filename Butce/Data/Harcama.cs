﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce
{
    class Harcama
    {
        public int HarcamaId { get; set; }
        public DateTime Tarih { get; set; }
        public string Kategori { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
    }
}

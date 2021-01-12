using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class Stok
    {
        public int StokId { get; set; }
        public int UrunKodu { get; set; }
        public int Barkod { get; set; }
        public string Cesit { get; set; }
        public int StokMiktari { get; set; }
        public string UrunAdi { get; set; }
        public double BirimGirdiFiyat { get; set; } 
        public int Miktar { get; set; }
        

    }
}

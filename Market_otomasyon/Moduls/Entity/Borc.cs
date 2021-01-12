using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Market_otomasyon.Moduls.Entity
{
    public class Borc
    {
        public int BorcId { get; set; }
        public int MusteriID { get; set; }
       // public string MusteriAd { get; set; }
       // public string MusteriSoyad { get; set; }
        public double Tutar { get; set; }
        public int SatinAlmaTarihi { get; set; }
        public double MusteriOdeme { get; set; }
        //public double ToplamBorc{ get; set; }

    }
}

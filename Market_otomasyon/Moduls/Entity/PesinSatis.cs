using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class PesinSatis
    {
        public int Id { get; set; }
        public int FaturaID { get; set; }
        public int MusteriID { get; set; }
        public double Tutar { get; set; }
    }
}

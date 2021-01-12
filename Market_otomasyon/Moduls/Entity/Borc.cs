using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class Borc
    {
        public int Id { get; set; }
        public int IrsaliyeNo { get; set; }
        public int TedarikciNo { get; set; }
        public int Odeme { get; set; }
        public int Tarih { get; set; }
    }
}

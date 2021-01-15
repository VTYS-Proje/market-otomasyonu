using Market_otomasyon.Context;
using Market_otomasyon.Moduls.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_otomasyon
{
    public partial class Musteri_Sil : Form
    {
        public Musteri_Sil()
        {
            InitializeComponent();
        }
        MarketDbContext db = new MarketDbContext();
        private void btnsil_Click(object sender, EventArgs e)
        {
            Moduls.Entity.Musteri musteriler = db.Musteris.First(u => u.TelefonNo == tel.Text);
            MessageBox.Show(musteriler.MusteriAd + " " + musteriler.MusteriSoyad + " isimli müşteri silinmiştir.");
            db.Musteris.Remove(musteriler);
            db.SaveChanges();

        }
    }
}

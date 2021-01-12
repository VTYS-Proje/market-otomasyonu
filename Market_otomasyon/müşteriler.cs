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
    public partial class müşteriler : Form
    {
        public müşteriler()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            var context = new MarketDbContext();
            context.Musteris.Add(new Musteri
            {
                MusteriAd = txtmüstad.Text,
                MusteriSoyad = txtmüstsoyad.Text,
                TelefonNo = txtmüsttelefon.Text
            });
            var cevap = context.SaveChanges();
            if (cevap > 0)
            {
                MessageBox.Show("Müşteri sisteme başarıyla kaydedilmiştir.");
            }
            else
            {
                MessageBox.Show("Müşteri sisteme kaydedilememiştir.");
            }
        }
    }
}

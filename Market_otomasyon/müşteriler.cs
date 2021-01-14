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
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();
            //this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_menu ANA = new Ana_menu();
            ANA.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarketDbContext db = new MarketDbContext();
            var müsteri = db.Musteris.ToList();
            dataGridView1.DataSource = müsteri;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MarketDbContext aa = new MarketDbContext();
            var borc = aa.Borcs.ToList();
            dataGridView1.DataSource = borc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci = new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }
    }
}

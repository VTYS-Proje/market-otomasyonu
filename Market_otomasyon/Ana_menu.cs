using Market_otomasyon.Context;
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
    public partial class Ana_menu : Form
    {
        DataTable tablo = new DataTable();
        double tutar = 0;
        public Ana_menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            peşin_ödeme_ekran pesin = new peşin_ödeme_ekran();
            pesin.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            veresiye_ödeme veresiye = new veresiye_ödeme();
            veresiye.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            müşteriler müşteri = new müşteriler();
            müşteri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci= new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var barkodNo = textBox1.Text;
            using (var bb = new MarketDbContext() )
            {
                var urun = bb.Stoks.FirstOrDefault(a => a.Barkod.ToString() == barkodNo);
                if (urun != null )
                {
                    tablo.Rows.Add(urun.UrunAdi);
                    dataGridView1.DataSource = tablo;
                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı");
                }
                tutar += urun.BirimGirdiFiyat;
                textBox2.Text = tutar.ToString();
            }
        }

        private void Ana_menu_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Ürün Adı", typeof(string));
            // tablo.Columns.Add("Miktar", typeof(int));
            tablo.Columns.Add("Fiyat", typeof(double));
        }
    }

}

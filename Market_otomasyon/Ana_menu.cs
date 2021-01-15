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

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            groupBox8.Show();

            
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
                    tablo.Rows.Add(urun.UrunKodu, urun.UrunAdi, urun.Cesit, urun.BirimGirdiFiyat);
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
            groupBox8.Hide();
            tablo.Columns.Add("Ürün Kodu", typeof(int));
            tablo.Columns.Add("Ürün Adı", typeof(string));
            tablo.Columns.Add("Çeşidi", typeof(string));
            tablo.Columns.Add("Fiyatı", typeof(double));

           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int para;
            para = int.Parse(textBox5.Text) -  int.Parse(textBox2.Text);
            textBox4.Text = para.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

}

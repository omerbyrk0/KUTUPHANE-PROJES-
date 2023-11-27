using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Projesi
{
    public partial class Frm_ÜyeSayfası : Form
    {
        public Frm_ÜyeSayfası()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_ÜyeSayfası_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneVeriTabanıDataSet2.Tbl_Kitaplar' table. You can move, or remove it, as needed.
            this.tbl_KitaplarTableAdapter.Fill(this.kütüphaneVeriTabanıDataSet2.Tbl_Kitaplar);

            int sıra = rnd.Next(1,11);

            switch(sıra)
            {
                case 1:label1.Text = "Kitaplar uygarlığa yol gösteren ışıklardır.";
                    break;

                case 2:label1.Text = "Gençlerini kitapla beslemeyen milletlerin sonu acıdır.";
                    break;
                case 3: label1.Text = "Kitap ruha ilaçdır.";
                    break;
                case 4: label1.Text = "İyi bir kitap bir hazinedir.";
                    break;
                case 5:label1.Text = "Kitaplıklar aklın tedavi yerleridir.";
                    break;
                case 6:label1.Text = "İnsanların aynası kitaplardır.";
                    break;
                case 7: label1.Text = "Allah’ım bana kitap dolu bir evle çiçek dolu bir bahçe ver.";
                    break;
                case 8:label1.Text = "Kitaplar da dostlar gibi az fakat iyi seçilmiş olmalıdır.";
                    break;
                case 9: label1.Text = "Kitap aşığı insanların canım sıkılıyor dediklerine rastlamadım.";
                    break;
                case 10: label1.Text = "Ümitle açılıp kazançla kapanan bir kitap iyi bir kitaptır.";
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string secilen = textBox1.Text;

            SqlCommand komut = new SqlCommand("select * from Tbl_Kitaplar where Kitapismi = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aradığınız Kitap Bulunmuştur "+"\n" + textBox1.Text.ToUpper(), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Aradığınız Kitap Malesef Bulunamamıştır...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Girişler fr = new Frm_Girişler();
            fr.Show();
            this.Hide();
        }
    }
}

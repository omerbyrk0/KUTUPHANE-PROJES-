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
    public partial class Frm_Kitap : Form
    {
        public Frm_Kitap()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneVeriTabanıDataSet.Tbl_Kitaplar' table. You can move, or remove it, as needed.
            this.tbl_KitaplarTableAdapter.Fill(this.kütüphaneVeriTabanıDataSet.Tbl_Kitaplar);

        }

        SqlConnection baglantı = new SqlConnection("Data Source=OMER\\SQLEXPRESS;Initial Catalog=KütüphaneVeriTabanı;Integrated Security=True");

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_KitaplarTableAdapter.Fill(this.kütüphaneVeriTabanıDataSet.Tbl_Kitaplar);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kitaplar (Kitapİsmi,KitapYazar,KitapSayfa,KitapTür)values(@p1,@p2,@p3,@p4)",bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_kitapadı.Text);
            komut.Parameters.AddWithValue("@p2", txt_kitapyazar.Text);
            komut.Parameters.AddWithValue("@p3", txt_kitapsayfa.Text);
            komut.Parameters.AddWithValue("@p4", txt_tür.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kitap Eklendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_kitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_kitapadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_kitapsayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_tür.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("delete from Tbl_Kitaplar where Kitapİd=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_kitapid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kitap Silindi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

      

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
      
            SqlCommand komut = new SqlCommand("update Tbl_Kitaplar set Kitapİsmi=@p1,KitapYazar=@p2,KitapSayfa=@p3,KitapTür=@p4 where Kitapİd=@p5", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_kitapadı.Text);
            komut.Parameters.AddWithValue("@p2", txt_kitapyazar.Text);
            komut.Parameters.AddWithValue("@p3", txt_kitapsayfa.Text);
            komut.Parameters.AddWithValue("@p4", txt_tür.Text);
            komut.Parameters.AddWithValue("@p5", txt_kitapid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }

        void temizle()
        {
            txt_kitapid.Text = " ";
            txt_kitapadı.Text = " ";
            txt_kitapyazar.Text = " ";
            txt_kitapsayfa.Text = " ";
            txt_tür.Text = " ";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AdminSayfası fr = new Frm_AdminSayfası();
            fr.Show();
            this.Hide();
        }
    }
}

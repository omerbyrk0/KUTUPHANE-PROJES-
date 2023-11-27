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
    public partial class Frm_Üyeler : Form
    {
        public Frm_Üyeler()
        {
            InitializeComponent();
        }


        sqlbaglantısı bgl = new sqlbaglantısı();


        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_ÜyeTableAdapter.Fill(this.kütüphaneVeriTabanıDataSet1.Tbl_Üye);
        }

        private void Frm_Üyeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneVeriTabanıDataSet1.Tbl_Üye' table. You can move, or remove it, as needed.
            this.tbl_ÜyeTableAdapter.Fill(this.kütüphaneVeriTabanıDataSet1.Tbl_Üye);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_üyeid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_üyead.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_üyesoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_üyetc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_üyesifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Üye (Üyeadı,ÜyeSoyadı,ÜyeTc,ÜyeSıfre)values(@p1,@p2,@p3,@p4)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_üyead.Text);
            komut.Parameters.AddWithValue("@p2",txt_üyesoyad.Text);
            komut.Parameters.AddWithValue("@p3", txt_üyetc.Text);
            komut.Parameters.AddWithValue("@p4", txt_üyesifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Eklendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Üye where Üyeİd=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_üyeid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Silindi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }
        

        void temizle()
        {
            txt_üyeid.Text = " ";
            txt_üyead.Text = " ";
            txt_üyesoyad.Text = " ";
            txt_üyetc.Text = " ";
            txt_üyesifre.Text = " ";
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Üye set Üyeadı=@p1,ÜyeSoyadı=@p2,ÜyeTc=@p3,ÜyeSıfre=@p4 where Üyeid = @p5", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_üyead.Text);
            komut.Parameters.AddWithValue("@p2", txt_üyesoyad.Text);
            komut.Parameters.AddWithValue("@p3", txt_üyetc.Text);
            komut.Parameters.AddWithValue("@p4", txt_üyesifre.Text);
            komut.Parameters.AddWithValue("@p5", txt_üyeid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AdminSayfası fr = new Frm_AdminSayfası();
            fr.Show();
            this.Hide();
        }
    }


}

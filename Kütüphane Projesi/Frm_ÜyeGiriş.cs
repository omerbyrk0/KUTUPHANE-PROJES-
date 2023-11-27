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
    public partial class Frm_ÜyeGiriş : Form
    {
        public Frm_ÜyeGiriş()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Üye where ÜyeTc=@p1 and ÜyeSıfre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Frm_ÜyeSayfası frm = new Frm_ÜyeSayfası();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglantı().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Üyekayıt fr = new Frm_Üyekayıt();
            fr.Show();
        }
    }
}

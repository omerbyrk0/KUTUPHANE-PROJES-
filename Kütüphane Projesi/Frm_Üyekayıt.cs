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
    public partial class Frm_Üyekayıt : Form
    {
        public Frm_Üyekayıt()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Üye(ÜyeAdı,ÜyeSoyadı,ÜyeTc,ÜyeSıfre)values (@p1,@p2,@p3,@p4)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1",txt_uyead.Text);
            komut.Parameters.AddWithValue("@p2", txt_uyesoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", txt_uyesıfre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Eklendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

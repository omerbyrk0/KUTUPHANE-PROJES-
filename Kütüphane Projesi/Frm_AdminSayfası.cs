using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Projesi
{
    public partial class Frm_AdminSayfası : Form
    {
        public Frm_AdminSayfası()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Frm_Kitap fr = new Frm_Kitap();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Üyeler fr = new Frm_Üyeler();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Girişler fr = new Frm_Girişler();
            fr.Show();
            this.Hide();
        }
    }
}

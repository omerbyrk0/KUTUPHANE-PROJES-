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
    public partial class Frm_Girişler : Form
    {
        public Frm_Girişler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AdminGiriş fr = new Frm_AdminGiriş();
            fr.Show();
            this.Hide();
        }

        private void Frm_Girişler_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Frm_ÜyeGiriş fr = new Frm_ÜyeGiriş();
            fr.Show();
            this.Hide();
        }
    }
}

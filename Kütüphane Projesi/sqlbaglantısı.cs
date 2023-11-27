using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kütüphane_Projesi
{
    internal class sqlbaglantısı
    {
        public SqlConnection baglantı()
        {
            SqlConnection baglan = new SqlConnection("Data Source=OMER\\SQLEXPRESS;Initial Catalog=KütüphaneVeriTabanı;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}

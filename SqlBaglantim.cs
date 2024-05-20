using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace HastaneOtomasyonu
{
    internal class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source = SALIH; Initial Catalog = HastaneOtomasyonu; Integrated Security = True ");
            baglanti.Open();
            return baglanti;
        }
    }
}

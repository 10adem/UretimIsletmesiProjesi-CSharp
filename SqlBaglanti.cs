using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UretimIsletmesi
{
    class SqlBaglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = localhost; Initial Catalog = UretimIsletmesi; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}

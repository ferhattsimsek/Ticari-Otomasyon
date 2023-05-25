using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-JKCGOLGI\MSSQLSERVERR;Initial Catalog=DBOticariotomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}

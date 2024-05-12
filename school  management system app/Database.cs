using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrenciTablosuDenemesi
{
    class Database
    {
       public SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ogrenci; UserID=burak; Password=1");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7F14DMR;Initial Catalog=DbYazOkulu; integrated security=true;");
    }
}

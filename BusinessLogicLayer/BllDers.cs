using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer1;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BllDers
    {
        public static List<EntityDersler> BLLListele()
        {
            return DalDers.DersListesi();
        }

        public static int TalepEkleBll(EntityBasvuruForm p)
        {
            if(p.OgrenciId!=null && p.BasvuruDersId!=null)
            {
                return DalDers.TalepEkle(p);
            }
            return -1;
        }
    }
}

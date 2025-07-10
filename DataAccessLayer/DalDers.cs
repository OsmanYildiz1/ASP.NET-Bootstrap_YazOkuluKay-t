using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer1;

namespace DataAccessLayer
{
    public class DalDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Dersler", Baglanti.connection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            SqlDataReader reader2 = sqlCommand.ExecuteReader();
            while (reader2.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.Id = Convert.ToInt32(reader2[0].ToString());
                ent.DersAd = reader2[1].ToString();
                ent.Min = Convert.ToInt32(reader2[2].ToString());
                ent.Max = Convert.ToInt32(reader2[3].ToString());

                degerler.Add(ent);
            }
            reader2.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert Into Tbl_BasvuruForm (OgrId,DersId) values(@p1,@p2)",Baglanti.connection);
            sqlCommand.Parameters.AddWithValue("@p1", parametre.OgrenciId);
            sqlCommand.Parameters.AddWithValue("@p2", parametre.BasvuruDersId);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            return sqlCommand.ExecuteNonQuery();    
        }
    }
}

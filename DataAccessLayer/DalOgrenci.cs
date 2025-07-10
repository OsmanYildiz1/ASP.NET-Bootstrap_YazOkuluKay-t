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
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Tbl_Ogrenci(OgrAd,OgrSoyad,OgrNumara,OgrFotoğraf,OgrSifre) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.connection);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",parametre.Ad);
            cmd.Parameters.AddWithValue("@p2",parametre.Soyad);
            cmd.Parameters.AddWithValue("@p3",parametre.Numara);
            cmd.Parameters.AddWithValue("@p4",parametre.Fotograf);
            cmd.Parameters.AddWithValue("@p5",parametre.Sifre);
            return cmd.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Ogrenci",Baglanti.connection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(reader[0].ToString());
                ent.Ad = reader[1].ToString();
                ent.Soyad = reader[2].ToString();
                ent.Numara = reader[3].ToString();
                ent.Fotograf = reader[4].ToString();
                ent.Sifre = reader[5].ToString();
                ent.Bakiye = Convert.ToDouble(reader[6].ToString());
                degerler.Add(ent);
            }
            reader.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From Tbl_Ogrenci Where OgrId=@p1",Baglanti.connection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.Parameters.AddWithValue("@p1", parametre);
            return sqlCommand.ExecuteNonQuery() > 0; // işlem sağlanıyorsa zaten true dönecek
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Ogrenci Where OgrId=@p1", Baglanti.connection);
            sqlCommand.Parameters.AddWithValue("@p1", id);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = reader[1].ToString();
                ent.Soyad = reader[2].ToString();
                ent.Numara = reader[3].ToString();
                ent.Fotograf = reader[4].ToString();
                ent.Sifre = reader[5].ToString();
                ent.Bakiye = Convert.ToDouble(reader[6].ToString());
                degerler.Add(ent);
            }
            reader.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand sqlcommand = new SqlCommand("Update Tbl_Ogrenci Set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFotoğraf=@p4,OgrSifre=@p5 Where OgrId=@p6", Baglanti.connection);
            if (sqlcommand.Connection.State != ConnectionState.Open)
            {
                sqlcommand.Connection.Open();
            }
            sqlcommand.Parameters.AddWithValue("@p1", deger.Ad);
            sqlcommand.Parameters.AddWithValue("@p2", deger.Soyad);
            sqlcommand.Parameters.AddWithValue("@p3", deger.Numara);
            sqlcommand.Parameters.AddWithValue("@p4", deger.Fotograf);
            sqlcommand.Parameters.AddWithValue("@p5", deger.Sifre);
            sqlcommand.Parameters.AddWithValue("@p6", deger.Id);
            return sqlcommand.ExecuteNonQuery() > 0; 
        }

    }
}

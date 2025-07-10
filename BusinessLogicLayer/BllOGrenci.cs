using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer1;

namespace BusinessLogicLayer
{
    public class BllOGrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null & p.Numara != null && p.Sifre != null && p.Fotograf != null)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BLLListele()
        {
            return DalOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBll(int p)
        {
            if (p != null)
            {
                return DalOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DalOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null & p.Numara != null && p.Sifre != null && p.Fotograf != null && p.Id >0)
            {
                return DalOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
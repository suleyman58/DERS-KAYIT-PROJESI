using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBll(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.FOTOGRAF != null && p.BAKIYE != null )
            {
                return DALOgrenci.Ogrenci_Ekle(p);

            }
            return -1;

        }

        public static List<EntityOgrenci> BllListeleme()
        {
            return DALOgrenci.OgrenciListesi();

        }

        public static bool OgrencisilBll(int p)
        {
            if (p >= 0)
            {
                return DALOgrenci.öğrencisil(p);

            }
            return false;

        }

        public static List<EntityOgrenci> Bllbilgi(int p)
        {
            return DALOgrenci.Ogrenci_bilgi(p);

        }

        public static bool Ogrencigüncellebll(EntityOgrenci p)
        {
            if (p.AD!= null && p.SOYAD != null && p.NUMARA != null && p.FOTOGRAF != null && p.BAKIYE != null)
            {
                return DALOgrenci.ogrenci_güncelleme(p);

            }
            return false;

        }
    }
}

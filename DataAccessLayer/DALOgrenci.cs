using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int Ogrenci_Ekle(EntityOgrenci parametre)
        {
            SqlCommand konut_ekle = new SqlCommand("insert into tblogrenci values(@ograd,@ogrsoyad,@ogrno,@ogrfoto,@ogrbakiye)", baglanti.bgl);
            if (konut_ekle.Connection.State != ConnectionState.Open)
            {
                konut_ekle.Connection.Open();

            }

            konut_ekle.Parameters.AddWithValue("@ograd", parametre.AD);
            konut_ekle.Parameters.AddWithValue("@ogrsoyad", parametre.SOYAD);
            konut_ekle.Parameters.AddWithValue("@ogrno", parametre.NUMARA);
            konut_ekle.Parameters.AddWithValue("@ogrfoto", parametre.FOTOGRAF);
            konut_ekle.Parameters.AddWithValue("@ogrbakiye", parametre.BAKIYE);
            return konut_ekle.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand sorgu_komut = new SqlCommand("select * from tblogrenci", baglanti.bgl);
            if (sorgu_komut.Connection.State != ConnectionState.Open)
            {
                sorgu_komut.Connection.Open();

            }
            SqlDataReader dr = sorgu_komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci enty = new EntityOgrenci();
                enty.ID = Convert.ToInt32(dr["ogrID"].ToString());
                enty.AD = dr["ograd"].ToString();
                enty.SOYAD = dr["ogrsoyad"].ToString();
                enty.NUMARA = dr["ogrnumara"].ToString();
                enty.FOTOGRAF = dr["ogrfoto"].ToString();
                enty.BAKIYE = dr["ogrbakiye"].ToString();
                degerler.Add(enty);

            }
            dr.Close();

            return degerler;
        }

        public static bool öğrencisil(int parametre)
        {
            SqlCommand sil_komutu = new SqlCommand("delete from tblogrenci where ogrID = @p1", baglanti.bgl);
            if (sil_komutu.Connection.State != ConnectionState.Open)
            {
                sil_komutu.Connection.Open();

            }
            sil_komutu.Parameters.AddWithValue("@p1", parametre);
            return sil_komutu.ExecuteNonQuery() > 0;


        }

        public static List<EntityOgrenci> Ogrenci_bilgi(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand Ogrenci_bilgi_komut = new SqlCommand("select * from tblogrenci where ogrID=@p1", baglanti.bgl);
            Ogrenci_bilgi_komut.Parameters.AddWithValue("@p1", id);

            if (Ogrenci_bilgi_komut.Connection.State != ConnectionState.Open)
            {
                Ogrenci_bilgi_komut.Connection.Open();

            }
            SqlDataReader dr = Ogrenci_bilgi_komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci enty = new EntityOgrenci();
                enty.AD = dr["ograd"].ToString();
                enty.SOYAD = dr["ogrsoyad"].ToString();
                enty.NUMARA = dr["ogrnumara"].ToString();
                enty.FOTOGRAF = dr["ogrfoto"].ToString();
                enty.BAKIYE = dr["ogrbakiye"].ToString();
                degerler.Add(enty);

            }
            dr.Close();

            return degerler;
        }

        public static bool ogrenci_güncelleme(EntityOgrenci deger)
        {
            SqlCommand güncelle_komutu = new SqlCommand("update tblogrenci set ograd=@p1,ogrsoyad=@p2,ogrnumara=@p3,ogrfoto=@p4,ogrbakiye=@p5 where ogrID=@p6)", baglanti.bgl);
            if (güncelle_komutu.Connection.State != ConnectionState.Open)
            {
                güncelle_komutu.Connection.Open();
            }
            güncelle_komutu.Parameters.AddWithValue("@p6", deger.ID);
            güncelle_komutu.Parameters.AddWithValue("@p1", deger.AD);
            güncelle_komutu.Parameters.AddWithValue("@p2", deger.SOYAD);
            güncelle_komutu.Parameters.AddWithValue("@p3", deger.NUMARA);
            güncelle_komutu.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            güncelle_komutu.Parameters.AddWithValue("@p5", deger.BAKIYE);
            return güncelle_komutu.ExecuteNonQuery() > 0;
        }
    }
}

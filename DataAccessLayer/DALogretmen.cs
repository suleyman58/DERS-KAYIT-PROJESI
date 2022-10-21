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
    public class DALogretmen
    {
        public static List<EntityOgretmen> OgretmenListesi()
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand sorgu_komut = new SqlCommand("select * from tblogretmen", baglanti.bgl);
            if (sorgu_komut.Connection.State != ConnectionState.Open)
            {
                sorgu_komut.Connection.Open();

            }
            SqlDataReader dr = sorgu_komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen enty = new EntityOgretmen();
                enty.OGRTID = Convert.ToInt32(dr["ogrtID"].ToString());
                enty.OGRTADSOYAD = dr["ogrtadsoyad"].ToString();
                enty.OGRTBRANS = dr["ogrtbrans"].ToString();
               
                degerler.Add(enty);

            }
            dr.Close();

            return degerler;
        }
    }
}

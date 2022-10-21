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
    public class DALDersler
    {
        public static List<EntityDers> dersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand göster_komut = new SqlCommand("select * from tbldersler", baglanti.bgl);
            if (göster_komut.Connection.State != ConnectionState.Open)
            {
                göster_komut.Connection.Open();

            }
            SqlDataReader dr = göster_komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers enty = new EntityDers();
                enty.DERSID = Convert.ToInt32(dr["dersID"].ToString());
                enty.DERSAD = dr["dersad"].ToString();
                enty.DERSMINKONT = Convert.ToInt32(dr["dersminkontenjan"].ToString());
                enty.DERSMAXKONT = Convert.ToInt32(dr["dersmaxkontenjan"].ToString());
                degerler.Add(enty);
            }
            dr.Close();
            return degerler;
        }

        public static int talepekle(EntityBasvuru parametre)
        {
            SqlCommand talep_komut = new SqlCommand("insert into tblbasvuruformu values(@ogrid,@dersid)", baglanti.bgl);
            talep_komut.Parameters.AddWithValue("@ogrid", parametre.BASOGRID);
            talep_komut.Parameters.AddWithValue("@dersid", parametre.BASDERSID);

            if (talep_komut.Connection.State != ConnectionState.Open)
            {
                talep_komut.Connection.Open();

            }
            return talep_komut.ExecuteNonQuery();

        }

    }
}

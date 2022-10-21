using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;



namespace YAZOKULU
{
    public partial class SİTEkayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle_komutu = new SqlCommand("insert into tblogrencikayitlari values(@p1,@p2)", baglanti.bgl);
            if (ekle_komutu.Connection.State != ConnectionState.Open)
            {
                ekle_komutu.Connection.Open();

            }
            string sifre = Sha256cs.ComputeSha256Hash(txtyntcsifre2.Text);

            ekle_komutu.Parameters.AddWithValue("@p1", txtyntcno2.Text);
            ekle_komutu.Parameters.AddWithValue("@p2", sifre);
            ekle_komutu.ExecuteNonQuery();

            Response.Write("KAYIT YAPILDI");


        }
    }
}
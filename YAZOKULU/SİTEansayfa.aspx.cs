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
    public partial class SİTEansayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SİTEkayit.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand giris_komutu = new SqlCommand("select * from tblogrencikayitlari where ogrno=@p1 and ogrsifre=@p2", baglanti.bgl);
            if (giris_komutu.Connection.State != ConnectionState.Open)
            {
                giris_komutu.Connection.Open();

            }

            string sifre_çözücü = Sha256cs.ComputeSha256Hash(txtyntcsifre.Text);
            giris_komutu.Parameters.AddWithValue("@p1", txtyntcno.Text);
            giris_komutu.Parameters.AddWithValue("@p2", sifre_çözücü);
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(giris_komutu);
            da.Fill(tb);
            if (tb.Rows.Count>0)
            {
                Response.Redirect("anasayfa.aspx");
            }
            else
            {
                Response.Write("<Script>alert('YÖNETİCİ NUMARASI VEYA ŞİFRESİ HATALI. ');</Script>");

            }
        }
    }
}
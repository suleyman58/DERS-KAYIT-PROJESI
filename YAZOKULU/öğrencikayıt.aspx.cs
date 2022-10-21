using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;



namespace YAZOKULU
{
    public partial class öğrencikayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            EntityOgrenci ekleme = new EntityOgrenci();
            ekleme.AD = txtograd.Text;
            ekleme.SOYAD = txtogrsoyad.Text;
            ekleme.NUMARA = txtogrno.Text;
            ekleme.FOTOGRAF = txtogrfoto.Text;
            ekleme.BAKIYE = txtogrbakiye.Text;

            BLLOgrenci.OgrenciEkleBll(ekleme);

            

            Response.Write("Kayıt Yapıldı");

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


namespace YAZOKULU
{
    public partial class öğrencigüncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            int x = Convert.ToInt32(Request.QueryString["ID"].ToString());
            txtogrID.Text = x.ToString();
            txtogrID.Enabled = false;
            if (Page.IsPostBack== false)
            {
                EntityOgrenci ent = new EntityOgrenci();
                List<EntityOgrenci> OgrList = BLLOgrenci.Bllbilgi(x);
                txtograd.Text = OgrList[0].AD.ToString();
                txtogrsoyad.Text = OgrList[0].SOYAD.ToString();
                txtogrno.Text = OgrList[0].NUMARA.ToString();
                txtogrfoto.Text = OgrList[0].FOTOGRAF.ToString();
                txtogrbakiye.Text = OgrList[0].BAKIYE.ToString();
            }

        }

        protected void btn_gncl_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = txtograd.Text;
            ent.SOYAD = txtogrsoyad.Text;
            ent.NUMARA = txtogrno.Text;
            ent.FOTOGRAF = txtogrfoto.Text;
            ent.BAKIYE = txtogrbakiye.Text;
            BLLOgrenci.Ogrencigüncellebll(ent);
            Response.Redirect("Öğrenciler.aspx");


        }
    }
}
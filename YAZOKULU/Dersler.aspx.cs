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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> entders = BLLDers.BlldersListeleme();
            dropders.DataSource = BLLDers.BlldersListeleme();
            dropders.DataTextField = "DERSAD";
            dropders.DataValueField = "DERSID";
            dropders.DataBind();

        }

        protected void derskayit_Click(object sender, EventArgs e)
        {
            EntityBasvuru ent = new EntityBasvuru();
           
            if (txtkayitogrid == null)
            {
                Response.Redirect("yanlış giriş yaptınız");

            }
            else
            {
                ent.BASOGRID = int.Parse(txtkayitogrid.Text);
            }
            ent.BASDERSID = int.Parse(dropders.SelectedValue.ToString());
            BLLDers.talepeklebll(ent);

        }
    }
}
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
    public partial class Kontenjan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> DersList = BLLDers.BlldersListeleme();
            Repeater1.DataSource = DersList;
            Repeater1.DataBind();
        }
    }
}
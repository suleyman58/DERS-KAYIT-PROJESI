﻿using System;
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
    public partial class öğretmentablo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<EntityOgretmen> OgrList = BLLogretmen.BLLListeleme();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();

        }
    }
}
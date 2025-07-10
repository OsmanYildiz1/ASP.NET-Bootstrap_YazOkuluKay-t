﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> OgrList = BllOGrenci.BLLListele();
        Repeater1.DataSource = OgrList;
        Repeater1.DataBind();
    }
}
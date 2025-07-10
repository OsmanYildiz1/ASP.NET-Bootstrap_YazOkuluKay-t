using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgrId"]);
        TxtId.Text = x.ToString();
        TxtId.Enabled = false;
        if (!Page.IsPostBack)
        {
            List<EntityOgrenci> OgrList = BllOGrenci.BLLDetay(x);
            TxtAd.Text = OgrList[0].Ad.ToString();
            TxtSoyad.Text = OgrList[0].Soyad.ToString();
            TxtNumara.Text = OgrList[0].Numara.ToString();
            TxtFoto.Text = OgrList[0].Fotograf.ToString();
            TxtSifre.Text = OgrList[0].Sifre.ToString();
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = TxtSoyad.Text;
        ent.Numara = TxtNumara.Text;
        ent.Sifre = TxtSifre.Text;
        ent.Fotograf = TxtFoto.Text;
        ent.Id = Convert.ToInt32(TxtId.Text);
        BllOGrenci.OgrenciGuncelleBll(ent);
        Response.Redirect("OgrenciListesi.aspx");
    }
}
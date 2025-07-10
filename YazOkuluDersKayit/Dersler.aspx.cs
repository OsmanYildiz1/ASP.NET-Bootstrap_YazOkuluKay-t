using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using BusinessLogicLayer;
using DataAccessLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<EntityDersler> entDers = new List<EntityDersler>();
            DropDownList1.DataSource = BllDers.BLLListele();
            DropDownList1.DataTextField = "DersAd";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // TextBox1.Text = DropDownList1.SelectedValue.ToString();
        EntityBasvuruForm entityBasvuruForm = new EntityBasvuruForm();
        entityBasvuruForm.OgrenciId = int.Parse(TextBox1.Text);
        entityBasvuruForm.BasvuruDersId = int.Parse(DropDownList1.SelectedValue.ToString());
        BllDers.TalepEkleBll(entityBasvuruForm);
    }
}
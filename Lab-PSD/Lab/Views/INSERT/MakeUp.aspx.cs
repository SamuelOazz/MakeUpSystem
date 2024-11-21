using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views.Insert
{
    public partial class MakeUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            ListType.DataSource = TypeController.GetAllMakeUpTypes();
            ListType.DataTextField = "Name";
            ListType.DataValueField = "Id";
            ListType.DataBind();
            ListBrand.DataSource = BrandController.GetAllMakeUpBrand();
            ListBrand.DataTextField = "Name";
            ListBrand.DataValueField = "Id";
            ListBrand.DataBind();
        }

        protected void AddMakeUpBtn_Click(object sender, EventArgs e)
        {
            var name = Name.Text;
            var price = Price.Text;
            var weight = Weight.Text;
            var typeID = int.Parse(ListType.SelectedValue);
            var brandID = int.Parse(ListBrand.SelectedValue);

            var err = MakeUpController.AddMakeup(name,price,weight,typeID,brandID);
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}
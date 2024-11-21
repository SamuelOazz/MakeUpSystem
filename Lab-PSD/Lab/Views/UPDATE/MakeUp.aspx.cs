using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views.Update
{
    public partial class MakeUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }

            if (IsPostBack)
            {
                return;
            }


            var Id = int.Parse(Request.Params.Get("Id") ?? "-1");
            if (Id == -1)
            {
                Response.Redirect("~/Views/ManageMakeUp.aspx");
            }

            var makeup = MakeUpController.GetMakeUpByID(Id);
            Name.Text = makeup.Name;
            Price.Text = makeup.Price.ToString();
            Weight.Text = makeup.Weight.ToString()  ;

            ListType.DataSource = TypeController.GetAllMakeUpTypes();
            ListType.DataTextField = "Name";
            ListType.DataValueField = "Id";
            ListType.DataBind();
            ListType.SelectedValue = makeup.TypeID.ToString();
            ListType.DataBind();
            ListBrand.DataSource = BrandController.GetAllMakeUpBrand();
            ListBrand.DataTextField = "Name";
            ListBrand.DataValueField = "Id";
            ListBrand.DataBind();
            ListBrand.SelectedValue = makeup.BrandID.ToString();
            ListBrand.DataBind();
        }

        protected void UpdateMakeUpBtn_Click(object sender, EventArgs e)
        {
            var name = Name.Text;
            var prices = int.Parse(Price.Text);
            var weights = int.Parse(Weight.Text);
            var typeid = int.Parse(ListType.SelectedValue);
            var brandid = int.Parse(ListBrand.SelectedValue);

            var Id = int.Parse(Request.Params.Get("Id") ?? "-1");
            var error = MakeUpController.UpdateMakeup(Id, name, prices, weights, typeid, brandid);

            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}
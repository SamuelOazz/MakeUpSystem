using Lab.Controller;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views.Update
{
    public partial class Brand : System.Web.UI.Page
    {
        protected List<MakeUpBrand> brand = new List<MakeUpBrand>();
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
            if( Id == -1)
            {
                Response.Redirect("~/Views/ManageMakeUp.aspx");
            }

            var brandId = BrandController.GetMakeUpBrand(Id);
            if(brandId == null)
            {
                Response.Redirect("~/Views/ManageMakeUp.aspx");
                return;
            }

            Name.Text = brandId.Name;
            Rating.Text = brandId.Rating.ToString();
       
        }

        protected void UpdateBrandBtn_Click(object sender, EventArgs e)
        {
            var namebrand = Name.Text;
            var newrating = Rating.Text;
            var ratingINT = int.Parse(newrating ?? "-1");
            var id = int.Parse(Request.Params.Get("Id") ?? "-1");
            var err = MakeUpController.UpdateBrand(id, namebrand, ratingINT);

            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}
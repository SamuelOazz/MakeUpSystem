using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views.Insert
{
    public partial class Brand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            var namebrand = Name.Text;
            var newrating = Rating.Text;
            var ratingINT = int.Parse(newrating ?? "-1");

            var err = MakeUpController.AddBrand(namebrand, ratingINT);

            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}
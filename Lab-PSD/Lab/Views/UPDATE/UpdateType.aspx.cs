using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views.Update
{
    public partial class UpdateType : System.Web.UI.Page
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
            var type = TypeController.GetType(Id);

            name.Text = type.name;
        }

        protected void UpdateTypebtn_Click(object sender, EventArgs e)
        {
            var Name = name.Text;
            var Id = int.Parse(Request.Params.Get("Id") ?? "-1");

            var err = MakeUpController.UpdateType(Id,Name);
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}
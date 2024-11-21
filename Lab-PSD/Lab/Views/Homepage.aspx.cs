using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }

            if (Session["role"].ToString() == "admin")
            {
                ListUserStore.DataSource = UserController.GetAllOfUser();
                ListUserStore.DataBind();
            }

        }
    }
}
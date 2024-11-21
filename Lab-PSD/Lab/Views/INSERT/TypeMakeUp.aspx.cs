using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views.Insert
{
    public partial class TypeMakeUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }
        }

        protected void AddTypeBtn_Click(object sender, EventArgs e)
        {
            var name = Name.Text;
            var err = MakeUpController.AddType(name);
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}
using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("~/Views/Homepage.aspx");
            }
        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            var username = Username.Text;
            var email = Email.Text;
            var password = Password.Text;
            var conpass = ConPass.Text;
            var gender = Gender.Text;
            var dob = DoB.Text;

            var err = UserController.RegisterUser(username,email,password,conpass,dob,gender);

            if(err != "")
            {
                Error.Text = err;
                return;
            }
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}
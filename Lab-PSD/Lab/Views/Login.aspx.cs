using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("~/Views/Homepage.aspx");
            }
        }

        private void AddCookie(string key, string value)
        {
            var cookie = new HttpCookie(key, value)
            {
                Expires = DateTime.Now.AddDays(7)
            };
            Response.Cookies.Add(cookie);
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            var username = Username.Text;
            var password = Password.Text;   

            var err = UserController.LoginUser(username, password);
            if(err != "")
            {
                Error.Text = err;
                return;
            }
            if (remember.Checked)
            {
                AddCookie("Username", username);
                AddCookie("Password", password);
            }

            Response.Redirect("~/Views/Homepage.aspx");
        }
    }
}
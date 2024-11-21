using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Masters
{
    public partial class Nav : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            var isAuth = HttpContext.Current.Request.Url.AbsolutePath == "/Views/Login.aspx" || HttpContext.Current.Request.Url.AbsolutePath == "/Views/Register.aspx";

            var sessionEmpty = Session["User"] == null || Session["Id"] == null;

            var cookieUsername = Request.Cookies["Username"]?.Value;
            var cookiePassword = Request.Cookies["Password"]?.Value;
            var cookieEmpty = cookieUsername == null || cookiePassword == null;

            if(sessionEmpty && cookieEmpty)
            {
                if (!isAuth)
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }

            var error = sessionEmpty
                ? UserController.LoginUser(cookieUsername, cookiePassword)
                : UserController.SessionLog(Session["Id"].ToString());
            if (error != "")
            {
                return;
            }

            All.Visible = true;

            switch (Session["role"].ToString())
            {
                case "admin":
                    Admin.Visible = true;
                    break;
                case "user":
                    User.Visible = true;
                    break;
            }

            if (isAuth)
            {
                Response.Redirect("~/Views/Homepage.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] != null)
            {
                var usernameCookie = new HttpCookie("Username")
                {
                    Expires = DateTime.Now.AddDays(-7)
                };
                Response.Cookies.Add(usernameCookie);
            }
            if (Request.Cookies["Password"] != null)
            {
                var passwordCookie = new HttpCookie("Password")
                {
                    Expires = DateTime.Now.AddDays(-7)
                };
                Response.Cookies.Add(passwordCookie);
            }

            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}
using Lab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        private void UpdateProfile(int id, string username, string email, string dob, string gender)
        {
            userid.Text = id.ToString();
            UserName.Text = username;
            Email.Text = email;
            DOB.Text = dob;
            Gender.Text = gender;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            if (IsPostBack)
            {
                return;
            }
            var User = UserController.GetUser(int.Parse(Session["Id"].ToString()));
            UpdateProfile(User.Id, User.username, User.email, User.dob.ToString("yyyy-MM-dd"), User.gender);
        }


        private void AddCookie(string key, string value)
        {
            var cookie = new HttpCookie(key, value);
            Response.Cookies.Add(cookie);
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(userid.Text);
            var username = UserName.Text;
            var email = Email.Text;
            var dob = DOB.Text;
            var gender = Gender.Text;
            var Oldpass = OldPass.Text;
            var Newpass = NewPass.Text;

            var passerr = UserController.Updatepass(ID, Oldpass, Newpass);
            var err = UserController.UpdateUser(ID,username, email, dob, gender);
            Err.Text = err;
            Err.Text = "Profile Updated";
            AddCookie("UserName", username);
            UpdateProfile(ID, username, email, dob, gender);
        }
    }
}
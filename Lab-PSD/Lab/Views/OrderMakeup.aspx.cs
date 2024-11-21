using Lab.Controller;
using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class OrderMakeup : System.Web.UI.Page
    {
        protected List<MakeUp> MakeUps = new List<MakeUp>();
        protected List<Cart> Carts   = new List<Cart>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
           {
                Response.Redirect("~/Views/Login.aspx");
             }

            if (Session["role"].ToString() != "user")
            {
                Response.Redirect("~/Views/Homepage.aspx");
             }

           MakeUps = MakeUpController.GetAllMakeUps();
           MakeUps.Sort((z,y) => y.MakeUpBrand.Rating - z.MakeUpBrand.Rating);
           Carts = CartController.GetAllCart();
           Carts.Reverse();

            var action = Request.Params.Get("action");
            switch (action)
            {
                case "add":
                    Addcart();
                    break;
                case "clear":
                    clearCart();
                    break;
                case "checkout":
                    checkoutitem();
                    break;
            }


        }
        private void checkoutitem()
        {
            var userId = int.Parse(Session["Id"].ToString());
            var error = OrderController.CheckOut(userId, Carts);
            if (error == "")
            {
                clearCart();
            }

        }

        private void clearCart()
        {
            var userId = int.Parse(Session["Id"].ToString());
            var error = OrderController.clearcart(userId);
            if (error == "")
            {
                Response.Redirect("~/Views/OrderMakeUp.aspx", true);
            }
        }

        private void Addcart()
        {
            var id = int.Parse(Request.Params.Get("id") ?? "-1");
            var quantity = int.Parse(Request.Params.Get("q") ?? "0");
            var error = OrderController.AddCart(int.Parse(Session["Id"].ToString()), id, quantity);
            if (error == "")
            {
                Response.Redirect("~/Views/OrderMakeUp.aspx");
            }

        }
    }
}
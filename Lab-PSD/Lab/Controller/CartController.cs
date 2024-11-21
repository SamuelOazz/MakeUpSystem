using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class CartController
    {
        public static List<Cart> GetAllCart()
        {
            return CartHandler.GetAllCart();
        }
    }
}
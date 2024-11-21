using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Handler
{
    public static class CartHandler
    {
        public static List<Cart> GetAllCart()
        {
            return CartRepo.GetAllCart();
        }
    }
}
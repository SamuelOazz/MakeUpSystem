using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class CartFactory
    {
        private static int NEWID()
        {
            var maxId = CartRepo.GetAllCart();
            return maxId.Count == 0 ? 1 : maxId.Max(x => x.Id) + 1;
        }

        public static Cart CreateCart(int UserId, int MakeUpId, int Quantity)
        {
            Cart cart = new Cart();
            cart.Id = NEWID();
            cart.UserId = UserId;
            cart.MakeUpId = MakeUpId;
            cart.Quantity = Quantity;
            return cart;
        }

    }
}
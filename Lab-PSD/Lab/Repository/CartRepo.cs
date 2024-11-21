using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class CartRepo
    {
        public static List<Cart> GetAllCart()
        {
            return (from x in Database.Instance.Carts
                    select x).ToList();

        }

        public static Cart GetCart(int id)
        {
            return (from x in Database.Instance.Carts where x.Id == id select x).FirstOrDefault();

        }

        public static List<Cart> GetCartByUserID(int UserID)
        {
            return Database.Instance.Carts.Where(x => x.UserId == UserID).ToList();
        }

        public static void DeleteAllCart(int UserId)
        {
            var cart = GetCartByUserID(UserId);
            foreach(var item in cart)
            {
                Database.Instance.Carts.Remove(item);
            }
            Database.Instance.SaveChanges();
        }

        public static void Addcart(Cart cart)
        {
            Database.Instance.Carts.Add(cart);
            Database.Instance.SaveChanges();
        }

    }
}
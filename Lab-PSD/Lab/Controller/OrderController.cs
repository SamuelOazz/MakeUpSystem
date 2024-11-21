using Lab.Handler;
using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class OrderController
    {
        private static string ValidateQuantity(int quantity)
        {
            return quantity <= 0 ? "Quantity must be greater than 0!" : "";
        }

        private static string ValidateMakeup(int makeupId)
        {
            return MakeUpRepo.GetMakeUpById(makeupId) == null ? "Makeup not found!" : "";
        }

        public static string CheckOut(int Userid, List<Cart> cart)
        {
            var err = OrderHandler.CheckOut(Userid,cart);
            return err;
        }

        public static string clearcart(int Userid)
        {
            var err = OrderHandler.clearcart(Userid);
            return err;
        }

        public static string AddCart(int Userid, int MakeUpId, int Quantity)
        {
            var quantityerr = ValidateQuantity(Quantity);
            var makeuperr = ValidateMakeup(MakeUpId);
            var err = OrderHandler.Addcart(Userid, MakeUpId, Quantity);
            return err;
        }

        public static (TransactionHeader,List<TransactionDetail>,string) GetTransactionID(int id)
        {
            return OrderHandler.GetTransaction(id);
        }

        public static string ManageTransaction(int id , string status)
        {
            return OrderHandler.ManageTransaction(id,status);
        }
    }
}
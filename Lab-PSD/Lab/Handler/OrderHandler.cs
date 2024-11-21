using Lab.Factory;
using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Lab.Handler
{
    public static class OrderHandler
    {

        public static string clearcart(int userid)
        {
            CartRepo.DeleteAllCart(userid);
            return "";
        }

        public static string CheckOut(int userid, List<Cart> cart)
        {
                var (header, details) = TransactionFactory.CreateTransaction(userid, cart, "Unhandled");
                TransactionHeaderRepo.AddTH(header);
                TransactionDetailRepo.AddTD(details);
            
            return "";
        }

        public static (TransactionHeader, List<TransactionDetail>, string) GetTransaction(int id)
        {
            var head = TransactionHeaderRepo.GetTransactionHeader(id);
            if(head == null)
            {
                return (null, null, "Transaction Header Not found");
            }
            var detail = TransactionDetailRepo.GetTransactionDetail(id);
            return detail == null ? (null, null, "Transaction detail not found!") : ((TransactionHeader, List<TransactionDetail>, string))(head, detail, "");


        }

        public static string ManageTransaction(int id, string status)
        {
            TransactionHeaderRepo.UpdateTransactionHeader(id,status);
            return "";
        }

        public static string Addcart(int userid, int makeupid, int quantity)
        {
            var carts = CartFactory.CreateCart(userid, makeupid, quantity);
            CartRepo.Addcart(carts);
            return "";
        }

    }
}
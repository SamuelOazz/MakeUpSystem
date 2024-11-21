using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class TransactionFactory
    {
        private static int NewHeaderId()
        {
            var maxId = TransactionHeaderRepo.GetAllTransactionHeader();
            return maxId.Count == 0 ? 1 : maxId.Max(x => x.Id) + 1;
        }

        private static int NEWDETAILID()
        {
            var MaxID = TransactionDetailRepo.GetAllTransactionDetails();
            return MaxID.Count == 0 ? 1 : MaxID.Max(x => x.Id) + 1;
        }

        public static (TransactionHeader, List<TransactionDetail>) CreateTransaction(int userId, List<Cart> cart,string status)
        {
            TransactionHeader th = new TransactionHeader();
            th.Id = NewHeaderId();
            th.UserId = userId;
            th.Status = status;
            th.TransactionDate = DateTime.Now;

            var td = new List<TransactionDetail>();
            var i = 0;
            foreach(var item in cart)
            {
                td.Add(new TransactionDetail
                {
                    Id = NEWDETAILID() + i,
                    TransactionId = th.Id,
                    MakeupId = item.MakeUpId,
                    Quantity = item.Quantity
                });
                i++;
            }


            return (th, td);
        }
    }
}
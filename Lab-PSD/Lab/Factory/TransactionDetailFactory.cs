using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(
            int TransactionId, int MakeupId, int Quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionId = TransactionId;
            td.MakeupId = MakeupId;
            td.Quantity = Quantity;
            return td;
        }
    }
}
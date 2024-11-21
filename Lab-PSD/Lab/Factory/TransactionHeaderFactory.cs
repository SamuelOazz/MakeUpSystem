using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class TransactionHeaderFactory
    {
        private static int NewID()
        {
            var MaxId = TransactionHeaderRepo.GetAllTransactionHeader();
            return MaxId.Count == 0 ? 1 : MaxId.Max(x => x.Id) + 1;
        }

        public static TransactionHeader CreateTransactionHeader(int UserId
            , string Status)
        {
            TransactionHeader th = new TransactionHeader();
            th.Id = NewID();
            th.UserId = UserId;
            th.Status = Status;
            th.TransactionDate = DateTime.Now;
            return th;
        }
    }
}
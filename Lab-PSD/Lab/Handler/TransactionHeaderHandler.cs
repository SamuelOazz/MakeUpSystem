using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Handler
{
    public static class TransactionHeaderHandler
    {
        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return TransactionHeaderRepo.GetAllTransactionHeader();
        }

        public static List<TransactionHeader> GetUserTransactionHeader(int Userid)
        {
            return TransactionHeaderRepo.GetUserTransactionHeader(Userid);
        }
    }
}
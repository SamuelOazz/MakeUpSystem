using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class TransactionHeaderController
    {
        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return TransactionHeaderHandler.GetAllTransactionHeader();
        }

        public static List<TransactionHeader> GetUserTransactionHeader(int Userid)
        {
            return TransactionHeaderHandler.GetUserTransactionHeader(Userid);
        }

    }
}
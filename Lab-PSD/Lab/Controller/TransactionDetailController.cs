using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class TransactionDetailController
    {
        public static List<TransactionDetail> GetAllTransactionDetails()
        {
            return TransactionDetailHandler.GetAllTransactionDetails();
        }
    }
}
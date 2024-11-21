using Lab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class TransactionHeaderRepo
    {
        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return (from x in Database.Instance.TransactionHeaders
                    select x).ToList();
        }

        public static TransactionHeader GetTransactionHeader(int id)
        {
            return Database.Instance.TransactionHeaders.FirstOrDefault(x => x.Id == id);
        }

        public static List<TransactionHeader> GetUserTransactionHeader(int UserId)
        {
            return (from x in Database.Instance.TransactionHeaders where x.UserId == UserId select x).ToList(); 
        }

        public static void UpdateTransactionHeader (int id, string Status)
        {
            var header = Database.Instance.TransactionHeaders.FirstOrDefault((t) => t.Id.Equals(id));
            header.Status = Status;
            Database.Instance.SaveChanges();
            
        }

        public static void AddTH ( TransactionHeader th)
        {
            Database.Instance.TransactionHeaders.Add(th);
            Database.Instance.SaveChanges();
        }

    }
}
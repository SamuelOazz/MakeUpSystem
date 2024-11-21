using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class TransactionDetailRepo
    {

        public static List<TransactionDetail> GetAllTransactionDetails()
        {
            return (from x in Database.Instance.TransactionDetails
                    select x).ToList();
        }

        public static List<TransactionDetail> GetTransactionDetail(int id)
        {
            return Database.Instance.TransactionDetails.Where((x) => x.Id == id).ToList();  

        }

        public static void AddTD ( List<TransactionDetail> td)
        {
            foreach (var detail in td)
            {
                Database.Instance.TransactionDetails.Add(detail);
            }
            Database.Instance.SaveChanges();
        }


    }
}
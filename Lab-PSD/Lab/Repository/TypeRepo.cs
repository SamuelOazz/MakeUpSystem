using Lab.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class TypeRepo
    {
        public static List<MakeUpType> GetAllOfMakeUPTypes()
        {
            return (from x in Database.Instance
                    .MakeUpTypes select x).ToList();
        }

        public static MakeUpType GetTypeId (int id)
        {
            return (from x in Database.Instance.MakeUpTypes
                    where x.Id == id
                    select x).FirstOrDefault();
        }

        public static string DeleteTypeByID (int id)
        {
            var type =  (from x in Database.Instance.MakeUpTypes where x.Id == id select x).FirstOrDefault();
            Database.Instance.MakeUpTypes.Remove(type);
            Database.Instance.SaveChanges();
            return"";
        }

        public static void AddType(MakeUpType type)
        {
            Database.Instance.MakeUpTypes.Add(type);
            Database.Instance.SaveChanges();
        }

        public static string UpdateType(int id, string name)
        {
            var Uptype = (from x in Database.Instance.MakeUpTypes where x.Id == id select x).FirstOrDefault();
            Uptype.name = name;
            Database.Instance.SaveChanges();
            return "";
        }

    }
}
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class MakeUpRepo
    {
        public static List<MakeUp> GetAllMakeUps()
        {
            return (from m in Database.Instance.MakeUps
                    select m).ToList();
        }

        public static MakeUp GetMakeUpById(int id)
        {
            return Database.Instance.MakeUps.FirstOrDefault(m => m.Id == id);
        }

        public static void AddMakeUp(MakeUp makeUp)
        {
            Database.Instance.MakeUps.Add(makeUp);
            Database.Instance.SaveChanges();
        }

        public static string DeleteMakeUp(int id)
        {
            var MakeUp = (from x in Database.Instance.MakeUps where x.Id == id select x).FirstOrDefault();
            Database.Instance.MakeUps.Remove(MakeUp); Database.Instance.SaveChanges();

            return"";
        }

        public static string UpdateMakeUp (int id, string name , int price, int weight, int typeID, int BrandID)
        {
            var MakeUp = (from x in Database.Instance.MakeUps where x.Id == id select x).FirstOrDefault();
            MakeUp.Name = name;
            MakeUp.Price = price;
            MakeUp.Weight = weight;
            MakeUp.TypeID = typeID;
            MakeUp.BrandID = BrandID;
            Database.Instance.SaveChanges();

            return"";
        }


    }
}
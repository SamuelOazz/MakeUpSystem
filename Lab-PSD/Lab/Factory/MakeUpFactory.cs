using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class MakeUpFactory
    {
        private static int NewId()
        {
            var maxId = MakeUpRepo.GetAllMakeUps();
            return maxId.Count == 0 ? 1 : maxId.Max(x => x.Id) + 1;
        }

        public static MakeUp CreateMakeUp(string Name,int price,int Weight, int TypeID,int BrandID)
        {
            MakeUp makeup = new MakeUp();
            makeup.Id = NewId();
            makeup.Name = Name;
            makeup.Price = price;
            makeup.Weight = Weight;
            makeup.TypeID = TypeID;
            makeup.BrandID = BrandID;
           return makeup;
        }

    }
}
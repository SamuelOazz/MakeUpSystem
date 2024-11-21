using Lab.Factory;
using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Handler
{
    public static class MakeupHandler
    {
        public static List<MakeUp> GetAllMakeUps()
        {
            return MakeUpRepo.GetAllMakeUps();
        }

        public static MakeUp GetMakeUpByID(int id)
        {
            return MakeUpRepo.GetMakeUpById(id);
        }

        public static string AddMakeUpBrand(string name, int rating)
        {
            var newbrand = BrandFactory.CreateBrand(name, rating);
            BrandRepo.AddMakeUpBrand(newbrand);
            return "";
        }

        public static string AddType(string name)
        {
            var newtype = TypeFactory.CreateType(name);
            TypeRepo.AddType(newtype);
            return "";
        }

        public static string AddMakeUp(string name, int price, int weight, int typeId, int brandId)
        {
            var newmakeup = MakeUpFactory.CreateMakeUp(name, price, weight, typeId, brandId);
            MakeUpRepo.AddMakeUp(newmakeup);
            return "";
        }

        public static string UpdateMakeup(int id, string name, int price, int weight, int typeId, int brandId)
        {
            return MakeUpRepo.UpdateMakeUp(id, name, price, weight, typeId, brandId);
        }

         public static string UpdateType(int id, string name)
        {
            return TypeRepo.UpdateType(id, name);
        }

        public static string UpdateBrand(int id, string name, int rating)
        {
            return BrandRepo.UpdateMakeUpBrand(id, name, rating);
        }

        public static string DeleteMakeUp(int id)
        {
            return MakeUpRepo.DeleteMakeUp(id);
        }

        public static string DeleteTypeByID(int id)
        {
            return TypeRepo.DeleteTypeByID(id);
        }

        public static string DeleteMakeUpBrand(int id)
        {
            return BrandRepo.DeleteMakeUpBrand(id);
        }


    }
}
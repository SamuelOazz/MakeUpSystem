using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class MakeUpController
    {
        public static List<MakeUp> GetAllMakeUps()
        {
            return MakeupHandler.GetAllMakeUps();
        }

        public static MakeUp GetMakeUpByID(int id)
        {
            return MakeupHandler.GetMakeUpByID(id);
        }

        public static string DeleteMakeUp(int id)
        {
            return MakeupHandler.DeleteMakeUp(id);
        }

        private static string ValidateName(string name)
        {
            return name.Length < 1 || name.Length > 99 ? "Name must be between 1-99 characters." : "";
        }

        private static string ValidateMakeupPrice(int price)
        {
            return price < 0 ? "Price must be greater than 0." : "";
        }

        private static string ValidateRating(int rating)
        {
            return rating < 0 || rating > 100 ? "Rating must be between 0-100." : "";
        }

        public static string AddBrand(string name,int rating)
        {
            var err = ValidateName(name);
            err = ValidateRating(rating);
            return MakeupHandler.AddMakeUpBrand(name,rating);
                
        }

        public static string AddType(string name)
        {
            var err = ValidateName(name);
            return MakeupHandler.AddType(name);
        }

        public static string AddMakeup(string name, string price, string weight, int typeId, int brandId)
        {
            var err = ValidateMakeup(name,price,weight,typeId,brandId);
            var priceINT = int.Parse(price);
            var weightINT = int.Parse(weight);
            err = MakeupHandler.AddMakeUp(name,priceINT,weightINT,typeId,brandId);
            return err;
        }

        private static string ValidateFill(IEnumerable<string> items)
        {
            return items.Any(x => x == "") ? "Please fill in all fields." : "";
        }


        private static string ValidateMakeupWeight(int weight)
        {
            return weight < 1 || weight > 1500 ? "Weight must be between 1-1500." : "";
        }

        private static string ValidateMakeup(string name, string price, string weight, int typeId, int brandId)
        {
            var err = ValidateFill(new List<string> {name,price,weight});
            if (typeId == -1 || brandId == -1)
            {
                return "Please fill in all fields.";
            }
            var newprice = int.Parse(price ?? "-1");
            err = ValidateMakeupPrice(newprice);

            var newweight = int.Parse(weight ?? "-1");
            err = ValidateMakeupWeight(newweight);

            return "";
        }

        public static string UpdateBrand(int id, string name, int rating)
        {
            var err = ValidateName(name);
            err = ValidateRating(rating);
            return MakeupHandler.UpdateBrand(id, name, rating);
        }

        public static string UpdateMakeup(int id, string name, int price, int weight, int typeId, int brandId)
        {
            return MakeupHandler.UpdateMakeup(id,name,price,weight,typeId,brandId);
        }

        public static string UpdateType(int id, string name)
        {
            return MakeupHandler.UpdateType(id,name);
        }

        public static string DeleteTypeByID(int id)
        {
            return MakeupHandler.DeleteTypeByID(id);
        }

        public static string DeleteMakeUpBrand(int id)
        {
            return MakeupHandler.DeleteMakeUpBrand(id);
        }


     }

}
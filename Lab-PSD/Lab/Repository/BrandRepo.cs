using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class BrandRepo
    {
        public static List<MakeUpBrand> GetAllMakeUpBrand()
        {
            return (from x in Database.Instance.MakeUpBrands
                    select x).ToList();
        }

        public static MakeUpBrand GetMakeUpBrand(int id)
        {
            return (from x in Database.Instance.MakeUpBrands where x.Id == id select x).FirstOrDefault();
        }

        public static void AddMakeUpBrand(MakeUpBrand brand)
        {
            Database.Instance.MakeUpBrands.Add(brand);
            Database.Instance.SaveChanges();
        }

        public static string DeleteMakeUpBrand(int id)
        {
            var br = (from x in Database.Instance.MakeUpBrands where x.Id == id select x).FirstOrDefault();
            Database.Instance.MakeUpBrands.Remove(br);
            Database.Instance.SaveChanges();
            return "";
        }

        public static string UpdateMakeUpBrand(int id, string name, int rating)
        {
            var br = (from x in Database.Instance.MakeUpBrands where x.Id == id select x).FirstOrDefault();
            br.Name = name;
            br.Rating = rating;
            Database.Instance.SaveChanges();
            return "";
        }

    }
}
using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class BrandFactory
    {
        private static int NewId()
        {
            var maxId = BrandRepo.GetAllMakeUpBrand();
            return maxId.Count == 0 ? 1 : maxId.Max(x => x.Id) + 1;
        }

        public static MakeUpBrand CreateBrand(string name, int rating)
        {
            MakeUpBrand brand = new MakeUpBrand();
            brand.Id = NewId();
            brand.Name = name;
            brand.Rating = rating;
            return brand;
        }
    }
}
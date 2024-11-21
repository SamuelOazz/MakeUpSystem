using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Handler
{
    public static class BrandHandler
    {
        public static List<MakeUpBrand> GetAllMakeUpBrand()
        {
            return BrandRepo.GetAllMakeUpBrand();
        }

        public static MakeUpBrand GetMakeUpBrand(int id)
        {
            return BrandRepo.GetMakeUpBrand(id);
        }
    }
}
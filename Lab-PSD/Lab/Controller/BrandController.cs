using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class BrandController
    {
        public static List<MakeUpBrand> GetAllMakeUpBrand()
        {
            return BrandHandler.GetAllMakeUpBrand();    
        }

        public static MakeUpBrand GetMakeUpBrand(int id)
        {
            return BrandHandler.GetMakeUpBrand(id);
        }
    }
}
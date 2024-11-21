using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public class TypeController
    {
        public static List<MakeUpType> GetAllMakeUpTypes()
        {
            return TypeHandler.GetAllMakeUpTypes();
        }

        public static MakeUpType GetType(int id)
        {
            return TypeHandler.GetType(id);
        }
    }
}
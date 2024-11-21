using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Handler
{
    public static class TypeHandler
    {
        public static List<MakeUpType> GetAllMakeUpTypes()
        {
            return TypeRepo.GetAllOfMakeUPTypes();
        }

        public static MakeUpType GetType(int id)
        {
            return TypeRepo.GetTypeId(id);
        }
    }
}
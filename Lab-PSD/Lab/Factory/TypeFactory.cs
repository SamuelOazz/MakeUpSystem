using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class TypeFactory
    {
        private static int NEWID()
        {
            var MaxID = TypeRepo.GetAllOfMakeUPTypes();
            return MaxID.Count == 0 ? 1 : MaxID.Max(u => u.Id) + 1;
        }

        public static MakeUpType CreateType(string name)
        {
            MakeUpType type = new MakeUpType();
            type.Id = NEWID();
            type.name = name;
            return type;
        }
    }
}
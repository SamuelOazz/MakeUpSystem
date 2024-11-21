using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public static class Database
    {
        private static Entities1 _Database;
        public static Entities1 Instance
        {
            get
            {
                if (_Database == null)
                {
                    _Database = new Entities1();
                }
                return _Database;
            }
        }
    }
}
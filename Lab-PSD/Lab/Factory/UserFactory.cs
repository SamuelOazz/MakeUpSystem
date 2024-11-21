using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public static class UserFactory
    {

        private static int NewID()
        {
            var MaxID = UserRepo.GetAllOfUser();
            return MaxID.Count == 0 ? 1 : MaxID.Max(u => u.Id) + 1;
        }

        public static User CreateUser(String username,string email,string password
            ,string gender,string dob)
        {
            User user = new User();
            user.Id = NewID();
            user.username = username;
            user.email = email;
            user.password = password;
            user.gender = gender;
            user.role = "user";
            user.dob = DateTime.Parse(dob).Date;
            return user;
        }
    }
}
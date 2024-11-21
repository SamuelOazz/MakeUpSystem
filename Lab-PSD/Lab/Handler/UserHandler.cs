using Lab.Factory;
using Lab.Models;
using Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Handler
{
    public static class UserHandler
    {

        public static List<User> GetAllOfUser()
        {
            return UserRepo.GetAllOfUser();
        }

        public static User GetUser(int id)
        {
            return UserRepo.GetUser(id);
        }

        public static string RegisterUser(string username, string email, string password, string dob,
            string gender)
        {
            var User = UserFactory.CreateUser(username, email, password, gender, dob);
            UserRepo.AddUser(User);
            return "";
        }

        private static void SaveSession(User user)
        {
            HttpContext.Current.Session["User"] = user.username;
            HttpContext.Current.Session["Role"] = user.role;
            HttpContext.Current.Session["Id"] = user.Id;
        }

        public static string SessionLogin(string id)
        {
            var idInt = int.Parse(id ?? "-1");
            var User = UserRepo.GetUser(idInt);
            if (User == null)
            {
                return "User not Found";
            }
            SaveSession(User);
            return"";
        }

        public static string UserLogin(string username, string password)
        {
            var User = UserRepo.GetUsernamepass(username,password);
            if(User == null)
            {
                return "Invalid username or password!";
            }
            SaveSession(User);
            return "";
        }

        public static string UpdateUser(int Id, string username, string email, string gender, string dob)
        {
            var (ErrorForUpdate, User) = UserRepo.UpdateUser(Id, username, email, gender, dob);
            SaveSession(User);
            return ErrorForUpdate;
        }

        public static string Updatapass(int Id, string OldPassword, string NewPassword)
        {
            var User = UserRepo.GetUser(Id);
            if(User == null)
            {
                return "User not found";
            }
            if(OldPassword != User.password)
            {
                return "Incorrect password";
            }
            UserRepo.UpdatePass(Id, NewPassword);
            return "";
        }

    }
}
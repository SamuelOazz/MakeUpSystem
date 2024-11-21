using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Repository
{
    public abstract class UserRepo
    {
        public static List<User> GetAllOfUser()
        {
            return (from x in Database.Instance.Users
                    select x ).ToList();    
        }
        public static void AddUser(User user)
        {
            Database.Instance.Users.Add(user);
            Database.Instance.SaveChanges();
        }
        public static User GetUser(int id)
        {
            return (from u in Database.Instance.Users
                    where u.Id == id
                    select u).FirstOrDefault();
        }

        public static User GetUsernamepass(string username, string password)
        {
            return (from u in Database.Instance.Users
                    where u.username == username && u.password == password
                    select u).FirstOrDefault();
        }

        public static (string,User) UpdateUser(int Id,string username,string email,string gender,string dob)
        {
            var user = (from x in Database.Instance.Users
                        where x.Id == Id
                        select x).FirstOrDefault(); 
            if (user == null)
            {
                return ("user not Found",null);
            }
            user.username = username;
            user.email = email;
            user.gender = gender;
            user.dob = DateTime.Now;
            Database.Instance.SaveChanges();

            return ("", user);
        }

        public static void UpdatePass(int Id, string password)
        {
            var user = (from x in Database.Instance.Users
                        where x.Id == Id
                        select x).FirstOrDefault();
            if (user != null) {
                user.password = password;
            }
            Database.Instance.SaveChanges();
        }

    }
}
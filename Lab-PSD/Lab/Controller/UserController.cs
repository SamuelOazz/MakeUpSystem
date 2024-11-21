using Lab.Handler;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Controller
{
    public static class UserController
    {

        public static User GetUser(int id)
        {
            return UserHandler.GetUser(id);
        }


        public static List<User> GetAllOfUser()
        {
            return UserHandler.GetAllOfUser();
        }


        private static string Validate(string username, string email, string dob, string gender)
        {
            if(username == "" || email == "" || gender == "" || dob == "")
            {
                return "All fields must be filled!";
            }

            if(username.Length < 5)
            {
                return "Username must be at least 5 characters long!";
            }
            if(username.Length > 15)
            {
                return "Username must be at most 15 characters long!";
            }
            if (!email.EndsWith(".com"))
            {
                return "Email must be a valid format!";
            }
            return "";
        }

        private static string ValidateConfirmPass(string password, string ConfirmPassword)
        {
            if(password == "" || ConfirmPassword == "")
            {
                return "All fields must be fill";
            }
            if(password != ConfirmPassword)
            {
                return "password don't match";
            }
            return "";
        }

        private static String ValidatePass(string password)
        {
            if(password == null)
            {
                return "Password don't be empty";
            }
            if(password == "")
            {
                return "Password don't be empty";
            }
            return "";
        }

        private static string ValidateUsername(string username)
        {
            if(username == null)
            {
                return "Username don't be empty";
            }
            if(username == "")
            {
                return "Password don't be empty";
            }
            if(username.Length < 5)
            {
                return "Username must be at least 5 characters long!";
            }
            if(username.Length > 15)
            {
                return "Username must be at most 15 characters long!";
            }
            return "";
        }

        public static string RegisterUser(string username, string email, string password, string confPassword,
         string dob, string gender)
        {
            var ErrorInfo = Validate(username, email, dob, gender);
            if(ErrorInfo != "") {
                return ErrorInfo;
            }
            var passerror = ValidateConfirmPass(password,confPassword);
            if(passerror != "")
            {
                return passerror;
            }
            var err = UserHandler.RegisterUser(username, email, password, dob, gender);
            return err;
        }

        public static string SessionLog(string Id)
        {
            var err = UserHandler.SessionLogin(Id);
            return err;
        }

        public static string LoginUser(string username, string password)
        {
            var UsernameErr = ValidateUsername(username);
            var PassowrdErr = ValidatePass(password);
            var err = UserHandler.UserLogin(username, password);
            return err;

        }

        public static string UpdateUser(int Id,  string username, string email,string dob, string gender)
        {
            var Infoerr = Validate(username, email, dob, gender);
            var err = UserHandler.UpdateUser(Id,username,email,dob, gender);    
            return err;
        }

        public static string Updatepass(int Id, string OldPassword, string NewPassword)
        {
            var Oldpasserror = ValidatePass(OldPassword);
            var Newpasserror = ValidatePass(NewPassword);
            var err = UserHandler.Updatapass(Id, OldPassword, NewPassword);
            return err;
        }
    }
}
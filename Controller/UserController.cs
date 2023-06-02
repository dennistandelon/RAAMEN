using project_RAAMEN.Handler;
using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Controller
{
    public class UserController
    {
        public static string registerUser(string name, string email, string gender, string password, string confirm)
        {
            if (name.Length < 5 || name.Length > 15)
            {
                return "Name must between 5 - 15 Characters!";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email must end with .com!";
            }

            if(gender == "Select gender")
            {
                return "Gender must be selected!";
            }

            if(password.Equals("") || password == null || password.Equals(" "))
            {
                return "Password cannot be empty";
            }

            if (!confirm.Equals(password))
            {
                return "Password and Confirm password must be same!";
            }

            int role = 1;

            return UserHandler.createUser(name, email, gender, password, role);
        }

        public static string loginValidation(string name, string pass)
        {
            if(name == "" || pass == "")
            {
                return "Please input username and password!";
            }

            User validatedUser = UserHandler.validateUser(name, pass);

            if(validatedUser == null)
            {
                return "Wrong username or password!";
            }

            return "Success";
        }

        public static User getUser(string name, string pass)
        {
            return UserHandler.validateUser(name, pass);
        }

        public static List<User> getUsersByRole(string role)
        {
            return UserHandler.getUserByRole(role);
        }

        public static string updateUser(string userID,string name, string email, string gender, string pass)
        {
            if (name.Length < 5 || name.Length > 15)
            {
                return "Name must between 5 - 15 Characters!";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email must end with .com!";
            }

            if (gender == "Select gender")
            {
                return "Gender must be selected!";
            }

            return UserHandler.updateUser(userID,name,email,gender,pass);
        }

        public static User getUserById(string id)
        {
            return UserHandler.getUserById(id);
        }

    }
}
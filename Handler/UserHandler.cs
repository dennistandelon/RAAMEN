using project_RAAMEN.Model;
using project_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Handler
{
    public class UserHandler
    {
        public static string createUser(string name, string email, string gender, string pass, int role)
        {
            return UserRepository.createUser(name,email,gender,pass, role);
        }

        public static User validateUser(string name, string pass)
        {
            return UserRepository.validateUser(name, pass);
        }

        public static List<User> getUserByRole(string role)
        {
            return UserRepository.getUserByRole(role);
        }

        public static string updateUser(string userID, string name, string email, string gender, string pass)
        {
            return UserRepository.updateUser(userID, name, email, gender, pass);
        }

        public static User getUserById(string id)
        {
            int ids = int.Parse(id);
            return UserRepository.getUserById(ids);
        }

    }

}
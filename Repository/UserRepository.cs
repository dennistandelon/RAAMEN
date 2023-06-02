using project_RAAMEN.Factory;
using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Repository
{
    public class UserRepository
    {
        public static string createUser(string name, string email, string gender, string password, int role)
        {
            RaamenDBEntities db = Connect.getConnection();

            User newUser = UserFactory.createUser(name, email, gender, password, role);

            db.Users.Add(newUser);
            db.SaveChanges();

            return "Registration Success!";
        }

        public static User validateUser(string name, string pass)
        {
            RaamenDBEntities db = Connect.getConnection();

            User userData = (from u in db.Users where u.Username == name select u).Where(x => x.Password == pass).FirstOrDefault();

            return userData;
        }

        public static List<User> getUserByRole(string role)
        {
            RaamenDBEntities db = Connect.getConnection();

            int roles = int.Parse(role);
            List<User> userByRole = (from x in db.Users where x.Roleid == roles select x).ToList();

            return userByRole;
        }

        public static string updateUser(string userID, string name, string email, string gender, string pass)
        {
            RaamenDBEntities db = Connect.getConnection();

            int uid = int.Parse(userID);
            User user = (from x in db.Users where x.Id == uid select x).FirstOrDefault();

            if (user != null)
            {
                if(user.Password != pass)
                {
                    return "Wrong Password!";
                }
            }

            user.Username = name;
            user.Email = email;
            user.Gender = gender;

            db.SaveChanges();

            return "Success";
        }

        public static User getUserById(int id)
        {
            RaamenDBEntities db = Connect.getConnection();
            return ((from x in db.Users where x.Id == id select x).FirstOrDefault());

        }
    }
}
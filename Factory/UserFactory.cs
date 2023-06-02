using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Factory
{
    public class UserFactory
    {
        public static User createUser(string userName, string email, string gender, string password, int role)
        {
            return new User() { 
                Username = userName, 
                Email = email, 
                Gender = gender, 
                Password = password, 
                Roleid = role 
            };
        }
    }
}
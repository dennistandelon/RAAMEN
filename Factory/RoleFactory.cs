using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Factory
{
    public class RoleFactory
    {
        public static Role CreateRole(string name)
        {
            return new Role() { name = name };
        }
    }
}
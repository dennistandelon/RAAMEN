using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN
{
    public class Connect
    {
        private static RaamenDBEntities db;
        private Connect()
        {
            db = new RaamenDBEntities();
        }

        public static RaamenDBEntities getConnection()
        {
            if(db == null)
            {
                new Connect();
            }

            return db;
        }

    }
}
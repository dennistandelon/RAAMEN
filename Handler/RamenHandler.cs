using project_RAAMEN.Model.DTO;
using project_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Handler
{
    public class RamenHandler
    {
        public static ViewRamen getViewRamen(string id)
        {
            int ids = int.Parse(id);
            return RamenRepository.getViewRamen(ids);
        }

        public static List<ViewRamen> getViewRamenList()
        {
            return RamenRepository.getViewRamenList();
        }

        public static string createRamen(string name, int meat, string broth, string price)
        {
            return RamenRepository.createRamen(name, meat, broth, price);
        }

        public static string updateRamen(int id, string name, int meat, string broth, string price)
        {
            return RamenRepository.updateRamen(id, name, meat, broth, price);
        }

        public static string deleteRamen(string id)
        {
            int ids = int.Parse(id);

            return RamenRepository.deleteRamen(ids);
        }
    }
}
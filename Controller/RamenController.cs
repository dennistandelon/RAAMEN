using project_RAAMEN.Handler;
using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Controller
{
    public class RamenController
    {
        public static ViewRamen GetViewRamen(string id)
        {
            return RamenHandler.getViewRamen(id);
        }

        public static List<ViewRamen> getViewRamenList()
        {
            return RamenHandler.getViewRamenList();
        }

        public static string createRamen(string name, string meat, string broth, string price)
        {

            if (!name.Contains("Ramen"))
            {
                return "Name must contains 'Ramen'!";
            }

            if (meat == "Select meat")
            {
                return "Meat must be selected!";
            }

            if (broth.Equals("") || broth == null)
            {
                return "Broth cannot be empty!";
            }

            try
            {
                int prices = int.Parse(price);
                if (prices < 3000)
                {
                    return "Price must be at least 3000!";
                }
            }
            catch (Exception ex)
            {
                return "Price Error: " + ex.Message;
            }

            int meatid = int.Parse(meat);

            return RamenHandler.createRamen(name, meatid, broth, price);
        }

        public static string updateRamen(int id, string name, string meat, string broth, string price)
        {
            if (!name.Contains("Ramen"))
            {
                return "Name must contains 'Ramen'!";
            }

            if (meat == "Select meat")
            {
                return "Meat must be selected!";
            }

            if (broth.Equals("") || broth == null)
            {
                return "Broth cannot be empty!";
            }

            try
            {
                int prices = int.Parse(price);
                if (prices < 3000)
                {
                    return "Price must be at least 3000!";
                }
            }
            catch (Exception ex)
            {
                return "Price Error: " + ex.Message;
            }

            int meatid = int.Parse(meat);

            return RamenHandler.updateRamen(id, name, meatid, broth, price);
        }

        public static string deleteRamen(string id)
        {
            return RamenHandler.deleteRamen(id);
        }
    }
}
using project_RAAMEN.Factory;
using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Repository
{
    public class RamenRepository
    {
        public static ViewRamen getViewRamen(int id)
        {
            RaamenDBEntities db = Connect.getConnection();
            Ramen ramen = (from x in db.Ramen1 where x.id == id select x).FirstOrDefault();

            ViewRamen data = new ViewRamen();
            if (ramen != null)
            {
                Meat meat = (from x in db.Meats where x.id == ramen.Meatid select x).FirstOrDefault();

                data.id = ramen.id;
                data.name = ramen.Name;
                data.meat = meat.name;
                data.broth = ramen.Borth;
                data.price = int.Parse(ramen.Price);
            }

            return data;
        }

        public static List<ViewRamen> getViewRamenList()
        {
            RaamenDBEntities db = Connect.getConnection();

            var dummy_ramen = (
                    from x in db.Ramen1
                    join y in db.Meats on x.Meatid equals y.id
                    select new 
                    { 
                        id = x.id,
                        name = x.Name, 
                        meat = y.name, 
                        broth = x.Borth, 
                        price = x.Price 
                    }
                ).ToList();

            List<ViewRamen> views = new List<ViewRamen>();

            foreach(var ramen in dummy_ramen)
            {
                views.Add(new ViewRamen()
                {
                    id = ramen.id,
                    name = ramen.name,
                    meat = ramen.meat,
                    broth = ramen.broth,
                    price = int.Parse(ramen.price)
                });
            }

            return views;
        }

        public static string createRamen(string name, int meat, string broth, string price)
        {
            Ramen newRamen = RamenFactory.createRamen(name, meat, broth, price);

            RaamenDBEntities db = Connect.getConnection();

            db.Ramen1.Add(newRamen);
            db.SaveChanges();

            return "Success";
        }

        public static string updateRamen(int id, string name, int meat, string broth, string price)
        {
            RaamenDBEntities db = Connect.getConnection();

            Ramen ramen = (from x in db.Ramen1 where x.id == id select x).FirstOrDefault();

            ramen.Name = name;
            ramen.Meatid = meat;
            ramen.Borth = broth;
            ramen.Price = price;

            db.SaveChanges();

            return "Success";
        }

        public static string deleteRamen(int id)
        {
            RaamenDBEntities db = Connect.getConnection();

            Ramen ramen = (from x in db.Ramen1 where x.id == id select x).FirstOrDefault();

            db.Ramen1.Remove(ramen);
            db.SaveChanges();

            return "Success";
        }
    }
}
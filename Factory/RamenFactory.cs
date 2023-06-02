using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Factory
{
    public class RamenFactory
    {
        public static Ramen createRamen(string name, int meat, string broth, string price)
        {
            return new Ramen() { 
                Name = name,
                Meatid = meat,
                Borth = broth,
                Price = price
            };
        }
    }
}
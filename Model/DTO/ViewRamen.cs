using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Model.DTO
{
    public class ViewRamen
    {
        public int id { get; set; }
        public string name { get; set; }
        public string meat { get; set; }
        public string broth { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    }
}
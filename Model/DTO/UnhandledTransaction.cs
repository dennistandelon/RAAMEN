using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Model.DTO
{
    public class UnhandledTransaction
    {
        public int id { get; set; }
        public int userId { get; set; }
        public List<ViewRamen> details { get; set; }
    }

}
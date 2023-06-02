using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Model.DTO
{
    public class ViewHeader
    {
        public int id { get; set; }
        public string staff { get; set; }
        public string customer { get; set; }
        public DateTime date { get; set; }
    }
}
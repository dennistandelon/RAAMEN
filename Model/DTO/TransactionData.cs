using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Model.DTO
{
    public class TransactionData
    {
        public int id { get; set;}
        public string customer { get; set; }
        public string staff { get; set; }
        public DateTime date { get; set; }

        public List<TrDetail> details { get; set; }
    }

    public class TrDetail
    {
        public string ramen { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int total { get; set; }
    }
}
using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Factory
{
    public class TransactionFactory
    {
        public static Header createHeader(int cid, int sid, DateTime date)
        {
            return new Header()
            {
                Customerid = cid,
                Staffid = sid,
                Date = date
            };
        }

        public static Detail createDetail(int hid, int rid, int quantity)
        {
            return new Detail()
            {
                Headerid = hid,
                Ramenid = rid,
                Quantity = quantity
            };
        }
    }
}
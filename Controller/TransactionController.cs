using project_RAAMEN.Handler;
using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Controller
{
    public class TransactionController
    {
        public static string insertTransaction(int staff, UnhandledTransaction trx)
        {
            DateTime now = DateTime.Now;

            return TransactionHandler.insertTransaction(staff, now, trx);
        }

        public static List<ViewHeader> getAllHeaderList()
        {
            return TransactionHandler.getAllHeaderList();
        }

        public static List<ViewHeader> getUserHeaderList(string id)
        {
            int ids = int.Parse(id);
            return TransactionHandler.getHeaderListByUser(ids);
        }

        public static ViewHeader getHeaderData(string id)
        {
            int ids = int.Parse(id);
            return TransactionHandler.getHeaderData(ids);
        }

        public static List<ViewDetail> getDetailData(string id)
        {
            int ids = int.Parse(id);
            return TransactionHandler.getDetailData(ids);
        }

        public static List<TransactionData> getAllTransaction()
        {
            return TransactionHandler.getAllTransaction();
        }
    }
}
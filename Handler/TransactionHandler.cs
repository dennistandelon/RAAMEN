using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using project_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Handler
{
    public class TransactionHandler
    {
        public static string insertTransaction(int staff, DateTime date, UnhandledTransaction trx)
        {
            return TransactionRepository.insertTransaction(staff, date, trx);
        }

        public static List<ViewHeader> getAllHeaderList()
        {
            return TransactionRepository.getAllHeaderList();
        }

        public static List<ViewHeader> getHeaderListByUser(int user)
        {
            return TransactionRepository.getHeaderListByUser(user);
        }

        public static ViewHeader getHeaderData(int id)
        {
            return TransactionRepository.getHeaderData(id);
        }

        public static List<ViewDetail> getDetailData(int id)
        {
            return TransactionRepository.getDetailData(id);
        }

        public static List<TransactionData> getAllTransaction()
        {
            return TransactionRepository.getAllTransaction();
        }
    }
}
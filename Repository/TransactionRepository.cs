using project_RAAMEN.Factory;
using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_RAAMEN.Repository
{
    public class TransactionRepository
    {
        public static string insertTransaction(int staff, DateTime date, UnhandledTransaction trx)
        {
            RaamenDBEntities db = Connect.getConnection();

            Header head = TransactionFactory.createHeader(trx.userId, staff, date);
            db.Headers.Add(head);
            db.SaveChanges();

            int headerId = head.id;

            foreach(ViewRamen detail in trx.details)
            {
                Detail dt = TransactionFactory.createDetail(headerId, detail.id, detail.quantity);
                db.Details.Add(dt);
                db.SaveChanges();
            }

            return "Success";
        }

        public static List<ViewHeader> getAllHeaderList()
        {
            RaamenDBEntities db = Connect.getConnection();

            List<Header> headerList = (from head in db.Headers select head).ToList();

            List<ViewHeader> data = new List<ViewHeader>();
            foreach(Header head in headerList)
            {
                string staffName = UserRepository.getUserById(head.Staffid).Username;
                string customerName = UserRepository.getUserById(head.Customerid).Username;
                data.Add(new ViewHeader()
                {
                    id = head.id,
                    date = head.Date,
                    customer = customerName,
                    staff = staffName
                });
            }


            return data;
        }

        public static List<ViewHeader> getHeaderListByUser(int user)
        {
            RaamenDBEntities db = Connect.getConnection();

            List<Header> headerList = (from head in db.Headers
                                       where head.Customerid == user
                                       select head).ToList();

            List<ViewHeader> data = new List<ViewHeader>();
            string customerName = UserRepository.getUserById(user).Username;
            foreach (Header head in headerList)
            {
                string staffName = UserRepository.getUserById(head.Staffid).Username;
                data.Add(new ViewHeader()
                {
                    id = head.id,
                    date = head.Date,
                    customer = customerName,
                    staff = staffName
                });
            }

            return data;
        }

        public static ViewHeader getHeaderData(int id)
        {
            RaamenDBEntities db = Connect.getConnection();

            Header head =  (from x in db.Headers where x.id == id select x).FirstOrDefault();

            string staffName = UserRepository.getUserById(head.Staffid).Username;
            return new ViewHeader()
            {
                id = head.id,
                date = head.Date,
                staff = staffName
            };
        }

        public static List<ViewDetail> getDetailData(int id)
        {
            RaamenDBEntities db = Connect.getConnection();

            List<ViewDetail> details = new List<ViewDetail>();

            List<Detail> dummy_data = (from x in db.Details where x.Headerid == id select x).ToList();

            foreach(Detail dummy in dummy_data)
            {
                string ramenName = RamenRepository.getViewRamen(dummy.Ramenid).name;
                details.Add(new ViewDetail()
                {
                    headerid = id,
                    ramen = ramenName,
                    quantity = dummy.Quantity
                });
            }

            return details;
        }

        public static List<TransactionData> getAllTransaction()
        {
            RaamenDBEntities db = Connect.getConnection();
            List<Header> headers = (
                from x in db.Headers
                select x).ToList();
            List<Detail> details = (from x in db.Details select x).ToList();

            List<TransactionData> allData = new List<TransactionData>();

            foreach(Header head in headers)
            {
                TransactionData td = new TransactionData();

                td.id = head.id;
                td.staff = UserRepository.getUserById(head.Staffid).Username;
                td.customer = UserRepository.getUserById(head.Customerid).Username;
                td.date = head.Date;

                List<TrDetail> trDetails = new List<TrDetail>();

                foreach(Detail dt in details)
                {
                    if(dt.Headerid == head.id)
                    {
                        TrDetail dtd = new TrDetail();
                        dtd.ramen = RamenRepository.getViewRamen(dt.Ramenid).name;
                        dtd.quantity = dt.Quantity;
                        dtd.price = RamenRepository.getViewRamen(dt.Ramenid).price;
                        dtd.total = dt.Quantity * RamenRepository.getViewRamen(dt.Ramenid).price;
                        trDetails.Add(dtd);
                    }
                }
                td.details = trDetails;

                allData.Add(td);
            }

            return allData;
        }
    }
}
using project_RAAMEN.Controller;
using project_RAAMEN.Model.DTO;
using project_RAAMEN.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport report = new CrystalReport();
            CrystalReportViewer.ReportSource = report;

            DataSet data = getData(TransactionController.getAllTransaction());
            report.SetDataSource(data);
        }

        private DataSet getData(List<TransactionData> dbData)
        {
            DataSet data = new DataSet();

            var header = data.TrHeader;
            var detail = data.TrDetail;

            foreach(TransactionData th in dbData)
            {
                var headerRow = header.NewRow();
                headerRow["id"] = th.id;
                headerRow["Customer"] = th.customer;
                headerRow["Staff"] = th.staff;
                headerRow["Date"] = th.date;
                header.Rows.Add(headerRow);

                foreach (TrDetail td in th.details)
                {
                    var detailRow = detail.NewRow();
                    detailRow["Headerid"] = th.id;
                    detailRow["Ramen"] = td.ramen;
                    detailRow["Quantity"] = td.quantity;
                    detailRow["Price"] = td.price;
                    detailRow["Total"] = td.total;
                    detail.Rows.Add(detailRow);
                }
            }

            return data;
        }
    }
}
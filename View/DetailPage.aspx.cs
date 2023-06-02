using project_RAAMEN.Controller;
using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class DetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var logged = Session["Role"];
            if(logged == null || logged.ToString() == "2")
            {
                Response.Redirect("Home.aspx");
            }

            string id = Request["id"];

            ViewHeader head = TransactionController.getHeaderData(id);

            TrIdLabel.Text = "Transaction ID: "+ head.id.ToString();
            StaffLbl.Text = "Handled By: "+ head.staff;
            DateLbl.Text = "Transaction Date: "+ head.date.ToString();

            DetailGV.DataSource = TransactionController.getDetailData(id);
            DetailGV.DataBind();
        }
    }
}
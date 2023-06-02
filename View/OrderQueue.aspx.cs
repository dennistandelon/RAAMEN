using project_RAAMEN.Controller;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var logged = Session["Role"];
            if(logged == null || logged.ToString() == "1")
            {
                Response.Redirect("Home.aspx");
            }

            List<UnhandledTransaction> queue = (List<UnhandledTransaction>)Application["Unhandle"];

            QueueGV.DataSource = queue;
            QueueGV.DataBind();
            
        }

        protected void QueueGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = QueueGV.SelectedRow;
            string id = row.Cells[0].Text.ToString();

            int index = int.Parse(id);

            List<UnhandledTransaction> queue = (List<UnhandledTransaction>)Application["Unhandle"];

            DetailLbl.Text = "Detail for Unhandled " + index; 
            UnhandledTransaction data = queue[index-1];

            CartGV.DataSource = data.details;
            CartGV.DataBind();

        }

        protected void QueueGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = QueueGV.Rows[e.RowIndex];
            string id = row.Cells[0].Text;

            List<UnhandledTransaction> queue = (List<UnhandledTransaction>)Application["Unhandle"];

            int index = int.Parse(id);
            UnhandledTransaction trx = queue[index - 1];

            queue.RemoveAt(index - 1);

            Application["Unhandle"] = queue;


            int currUser = int.Parse(Session["User"].ToString());
            TransactionController.insertTransaction(currUser,trx);

            QueueGV.DataSource = queue;
            QueueGV.DataBind();

            CartGV.DataSource = null;
            CartGV.DataBind();
        }
    }
}
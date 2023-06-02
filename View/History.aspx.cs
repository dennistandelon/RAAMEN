using project_RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class History : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var logged = Session["Role"];
            if(logged == null || logged.ToString() == "2")
            {
                Response.Redirect("Home.aspx");
            }

            if(logged.ToString() == "1")
            {
                HeaderGV.DataSource = TransactionController.getUserHeaderList(Session["User"].ToString());
            }
            else
            { 
                HeaderGV.DataSource = TransactionController.getAllHeaderList();
            }
            HeaderGV.DataBind();
        }

        protected void HeaderGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = HeaderGV.SelectedRow;
            string id = row.Cells[0].Text;

            Response.Redirect("DetailPage.aspx?id=" + id);
        }
    }
}
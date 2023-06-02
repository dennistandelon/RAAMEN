using project_RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var logged = Session["Role"];
            if (logged == null || logged.ToString() == "1")
            {
                Response.Redirect("Home.aspx");
            }

            RaamenView.DataSource = RamenController.getViewRamenList();
            RaamenView.DataBind();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertRamen.aspx");
        }

        protected void RaamenView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = RaamenView.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();

            Response.Redirect("UpdateRamen.aspx?id=" + id);
        }

        protected void RaamenView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = RaamenView.Rows[e.RowIndex];
            string id = row.Cells[0].Text.ToString();

            RamenController.deleteRamen(id);

            RaamenView.DataSource = RamenController.getViewRamenList();
            RaamenView.DataBind();
        }
    }
}
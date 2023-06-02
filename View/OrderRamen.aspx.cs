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
    public partial class OrderRamen : System.Web.UI.Page
    {
        UnhandledTransaction trx;

        protected void Page_Load(object sender, EventArgs e)
        {
            var logged = Session["Role"];
            if (logged == null)
            {
                Response.Redirect("Home.aspx");
            }

            string role = logged.ToString();
            if(role == null || role != "1")
            {
                Response.Redirect("Home.aspx");
            }

            RaamenView.DataSource = RamenController.getViewRamenList();
            RaamenView.DataBind();
        }

        protected void RaamenView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = RaamenView.SelectedRow;
            string id = row.Cells[0].Text.ToString();

            string cartSession = Session["User"].ToString() + "Cart";
            if(Session[cartSession] != null)
            {
                trx = (UnhandledTransaction)Session[cartSession];
            }

            if(trx == null)
            {
                trx = new UnhandledTransaction();
            }

            ViewRamen addRamen = RamenController.GetViewRamen(id);
            addRamen.quantity = 1;

            if(trx.details == null)
            {
                trx.details = new List<ViewRamen>();
            }

            ViewRamen dummy = trx.details.Where(x => x.id == addRamen.id).FirstOrDefault();
            
            if(dummy == null)
            {
                trx.details.Add(addRamen) ;
            }
            else
            {
                dummy.quantity = dummy.quantity + 1;
            }
            

            Session[cartSession] = trx;

            CartGV.DataSource = trx.details;
            CartGV.DataBind();
        }

        protected void ClearCart_Click(object sender, EventArgs e)
        {
            string cartSession = Session["User"].ToString() + "Cart";
            Session.Remove(cartSession);

            CartGV.DataSource = null;
            CartGV.DataBind();
        }

        protected void BuyBtn_Click(object sender, EventArgs e)
        {
            string cartSession = Session["User"].ToString() + "Cart";
            trx = (UnhandledTransaction)Session[cartSession];
            if(trx != null)
            {
                trx.userId = int.Parse(Session["User"].ToString());

                List<UnhandledTransaction> allUnhandle;
                if(Application["Unhandle"] != null)
                {
                    allUnhandle = (List<UnhandledTransaction>)Application["Unhandle"];
                }
                else
                {
                   allUnhandle =  new List<UnhandledTransaction>();
                }
               

                allUnhandle.Add(trx);

                int len = allUnhandle.Count();
                for(int i=0; i<len; i++)
                {
                    allUnhandle[i].id = i+1;
                }

                Application["Unhandle"] = allUnhandle;

                Session.Remove(cartSession);
            }
        }
    }
}
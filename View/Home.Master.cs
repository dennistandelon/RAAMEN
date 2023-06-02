using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserData"];
            if (Session["User"] == null)
            {
                Response.Redirect("Home.aspx");
            }


           String role = (String)Session["Role"];

           if(navbar.Items.Count < 1)
            {
                if (role == "1")
                {
                    navbar.Items.Clear();
                    navbar.Items.Add(new MenuItem("Order Ramen", "", "", "OrderRamen.aspx"));
                    navbar.Items.Add(new MenuItem("History", "", "", "History.aspx"));
                    navbar.Items.Add(new MenuItem("Profile", "", "", "Profile.aspx"));
                    navbar.Items.Add(new MenuItem("Log Out", "", "", "Logout.aspx"));
                }
                else if (role == "2")
                {
                    navbar.Items.Add(new MenuItem("Home", "", "", "Home.aspx"));
                    navbar.Items.Add(new MenuItem("Manage Ramen", "", "", "ManageRamen.aspx"));
                    navbar.Items.Add(new MenuItem("Order Queue", "", "", "OrderQueue.aspx"));
                    navbar.Items.Add(new MenuItem("Profile", "", "", "Profile.aspx"));
                    navbar.Items.Add(new MenuItem("Log Out", "", "", "Logout.aspx"));
                }
                else if (role == "3")
                {
                    navbar.Items.Add(new MenuItem("Manage Ramen", "", "", "ManageRamen.aspx"));
                    navbar.Items.Add(new MenuItem("Order Queue", "", "", "OrderQueue.aspx"));
                    navbar.Items.Add(new MenuItem("Profile", "", "", "Profile.aspx"));
                    navbar.Items.Add(new MenuItem("History", "", "", "History.aspx"));
                    navbar.Items.Add(new MenuItem("Report", "", "", "Report.aspx"));
                    navbar.Items.Add(new MenuItem("Log Out", "", "", "Logout.aspx"));
                }
            }



        }
    }
}
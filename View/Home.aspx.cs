using project_RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                HttpCookie httpCookie = Request.Cookies["UserData"];
                if (httpCookie == null)
                {
                    Response.Redirect("Login.aspx");
                }
                Session["User"] = httpCookie["User"];
                Session["Role"] = httpCookie["Role"];
            }

            var role = Session["Role"].ToString();
            if(role == "1")
            {
                // Member
                roleLbl.Text = "You are a Member";
            } else if(role == "2"){
                // Staff
                roleLbl.Text = "Member List<br/>";
                GV1.DataSource = UserController.getUsersByRole("1");
                GV1.DataBind();
            } else if(role == "3"){
                // Admin
                roleLbl.Text = "Member List<br/>";
                GV1.DataSource = UserController.getUsersByRole("1");
                GV1.DataBind();

                roleLbl2.Text = "Staff List<br/>";
                GV2.DataSource = UserController.getUsersByRole("2");
                GV2.DataBind();
            }
            
        }
    }
}
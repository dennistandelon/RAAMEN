using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["User"] != null)
            {
                Session.Remove("User");
            }

            if(Session["Role"] != null)
            {
                Session.Remove("Role");
            }

            HttpCookie cookie = Request.Cookies["UserData"];
            if(cookie != null)
            {
                cookie.Expires.AddDays(-10);
            }


            Response.Redirect("Login.aspx");
        }
    }
}
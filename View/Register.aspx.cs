using project_RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie = Request.Cookies["UserData"];
            if (httpCookie != null)
            {
                Response.Redirect("Home.aspx");
            }

            login.NavigateUrl = "Login.aspx";
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Text = UserController.registerUser(
                usernameTxb.Text, emailTxb.Text, genderDropDown.SelectedValue,
                pwTxb.Text, cpwTxb.Text);

        }
    }
}
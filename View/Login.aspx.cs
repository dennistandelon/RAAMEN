using project_RAAMEN.Controller;
using project_RAAMEN.Factory;
using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie = Request.Cookies["UserData"];
            if(httpCookie != null)
            {
                Response.Redirect("Home.aspx");
            }

            regist.NavigateUrl = "Register.aspx";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            errorLbl.Text = UserController.loginValidation(usernameTxb.Text, passwordTxb.Text);

            if(errorLbl.Text == "Success")
            {
                if (cookieBox.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserData");
                    cookie.Expires.AddDays(1);
                    cookie["User"] = UserController.getUser(usernameTxb.Text, passwordTxb.Text).Id.ToString(); ;

                    cookie["Role"] = UserController.getUser(usernameTxb.Text, passwordTxb.Text).Roleid.ToString();

                    Response.Cookies.Add(cookie);
                }


                User loggedUser = UserController.getUser(usernameTxb.Text, passwordTxb.Text);
                Session["User"] = loggedUser.Id.ToString();
                Session["Role"] = loggedUser.Roleid.ToString();
                Response.Redirect("Home.aspx");
            }

        }
    }
}
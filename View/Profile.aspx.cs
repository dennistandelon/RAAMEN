using project_RAAMEN.Controller;
using project_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var Logged = Session["User"];
            if (Logged == null)
            {
                Response.Redirect("Login.aspx");
            }

            User user = UserController.getUserById(Session["User"].ToString());
            oldNameLbl.Text = "Username: " + user.Username;
            oldEmailLbl.Text = "Email: " + user.Email;
            genderLbl.Text = "Gender: " + user.Gender;

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {

            var userID = Session["User"].ToString();
            errorLbl.Text = UserController.updateUser(userID,usernameTxb.Text, emailTxb.Text, genderDropDown.SelectedValue, pwTxb.Text);
        }
    }
}
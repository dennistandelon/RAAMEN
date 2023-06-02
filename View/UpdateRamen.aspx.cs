using project_RAAMEN.Controller;
using project_RAAMEN.Model;
using project_RAAMEN.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_RAAMEN.View
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var logged = Session["Role"];
            if (logged == null || logged.ToString() == "1")
            {
                Response.Redirect("Home.aspx");
            }

            if (MeatDropDown.Items.Count <= 1)
            {
                RaamenDBEntities db = Connect.getConnection();
                List<Meat> meatList = (from x in db.Meats select x).ToList();

                foreach (Meat meat in meatList)
                {
                    MeatDropDown.Items.Add(new ListItem(meat.name, meat.id.ToString()));
                }

            }

            ViewRamen data = RamenController.GetViewRamen(Request["id"]);

            NameLbl.Text = "Name: " + data.name;
            MeatLbl.Text = "Meat: " + data.meat;
            BrothLbl.Text = "Broth: " + data.broth;
            PriceLbl.Text = "Price: " + data.price;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            string name = nameTxb.Text;
            string meat = MeatDropDown.SelectedValue;
            string broth = brothTxb.Text;
            string price = priceTxb.Text;

            errorLbl.Text = RamenController.updateRamen(id,name,meat,broth,price);
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }
    }
}
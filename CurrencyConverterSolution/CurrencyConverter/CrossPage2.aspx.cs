using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class CrossPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null) {
                lblInfo.Text = "You came from a page titled " + PreviousPage.Title;
                //Response.Redirect("default.aspx");
            }
        }
    }
}
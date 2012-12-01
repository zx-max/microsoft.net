using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class SimpleCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void cmdIncrement_Click(Object sender, EventArgs e)
        {
            int counter;
            if (ViewState["Counter"] == null) {
                counter = 1;
            } else {
                counter = (int)ViewState["Counter"] + 1;
            }
            ViewState["Counter"] = counter;
            lblCount.Text = "Counter: " + counter.ToString();
        }
    }
}
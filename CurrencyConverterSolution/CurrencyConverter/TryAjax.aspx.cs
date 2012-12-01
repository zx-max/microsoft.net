using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class TryAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdRefreshTime_Click(Object sender, EventArgs e)
        {
            lblTime1.Text = DateTime.Now.ToLongTimeString();
            lblTime2.Text = DateTime.Now.ToLongTimeString();
            lblTime3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
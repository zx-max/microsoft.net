using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Convert_ServerClick(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Convert_ServerClick_2");
            Result.InnerText = buildMessage();
        }

        private string buildMessage()
        {
            Decimal euros = Decimal. Parse(US.Value) * 0.85M;
            return  US.Value + "US Dollar = " + euros + " euros.";
        }
    }
}
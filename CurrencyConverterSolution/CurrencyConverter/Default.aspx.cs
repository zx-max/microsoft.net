using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace CurrencyConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod(EnableSession = false)]
        public static string HelloWorld()
        {
            System.Diagnostics.Trace.WriteLine("hola");
            Console.WriteLine("console");
            return "Hello: " + DateTime.Now.Millisecond;
        }
    }
}
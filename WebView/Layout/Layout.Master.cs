using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho.WebView.Layout
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AssociacaoID"] = 1;
            if (Session["AssociacaoID"] == null)
                Response.Redirect("~/Login.aspx");

        }
    }
}
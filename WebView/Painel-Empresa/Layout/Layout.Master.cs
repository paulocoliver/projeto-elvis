using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.Types;
using Trabalho.BLL;

namespace Trabalho.WebView.Painel_Empresa.Layout
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AssociacaoID"] = 1;
            Session["idEmpresa"] = 7;

            if(Session["idEmpresa"] == null)
            {
                Response.Redirect("/Site/Default.aspx");
            }
        }
    }
}
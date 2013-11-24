using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho.WebView.Assoc.Layout
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        public bool autenticado;

        protected void Page_Load(object sender, EventArgs e)
        {
           autenticado = (Session["idEmpresa"] == null ? false : true );
        }
    }
}
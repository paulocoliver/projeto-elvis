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

        public int assocCookie;

        protected void Page_Load(object sender, EventArgs e)
        {
           //Session["AssociacaoID"] = 1;
           autenticado = (Session["idEmpresa"] == null ? false : true );
        }

        public int AssociacaoIdCookie
        {
            get
            {
                assocCookie = int.Parse(Request.Cookies["assocCookie"].Value);
                if (assocCookie == null || assocCookie == 0)
                {
                    assocCookie = 1;
                }
                return assocCookie;
            }
        }
    }
}
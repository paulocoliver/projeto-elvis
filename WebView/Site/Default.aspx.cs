using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Site
{
    public partial class Default : System.Web.UI.Page
    {
        public string texto;

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            if (id > 0)
            {
                HttpCookie cookie = new HttpCookie("assocCookie");
                cookie.Value = id.ToString();
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Site/Default.aspx");
            }

            PaginaInicialBLL bll = new PaginaInicialBLL();
            PaginaInicialType pagina = bll.select(Master.AssociacaoIdCookie);

           texto = pagina.Texto;
        }
    }
}
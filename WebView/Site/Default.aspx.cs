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
            PaginaInicialBLL bll = new PaginaInicialBLL();
            PaginaInicialType pagina = bll.select(1);

            texto = pagina.Texto;
        }
    }
}
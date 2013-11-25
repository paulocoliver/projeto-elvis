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
    public partial class Eventos : System.Web.UI.Page
    {
        public EventosType eventos;

        protected void Page_Load(object sender, EventArgs e)
        {
            EventoBLL bll = new EventoBLL();
            eventos = bll.select(1);
        }
    }
}
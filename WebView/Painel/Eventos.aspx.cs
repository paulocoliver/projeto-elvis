using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho.WebView.Painel
{
    public partial class Eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.EventoBLL evtBLL = new BLL.EventoBLL();
            GridView1.DataSource = evtBLL.select(Master.getAssociacaoSession().IdAssociacao);
            GridView1.DataBind();
        }
    }
}
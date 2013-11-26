using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Painel
{
    public partial class Empresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpresaBLL BLL = new EmpresaBLL();
            GridView1.DataSource = BLL.selectByAssociacao(Master.getAssociacaoSession());
            GridView1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.Types;
using Trabalho.BLL;

namespace Trabalho.WebView.Painel_Empresa
{
    public partial class Pagamento : System.Web.UI.Page
    {
        private EmpresaType _empresa;

        protected void Page_Load(object sender, EventArgs e)
        {
            _empresa = Master.getEmpresa();
            lbExpira.Text = _empresa.dateCompare().ToString()+" dias.";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Painel_Empresa
{
    public partial class Efetuar_Pagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idEmpresa;
            if (Session["idEmpresa"] == null)
            {
                idEmpresa = 7;
            }
            else {
                idEmpresa = Convert.ToInt32(Session["idEmpresa"]);
            }
            
            EmpresaBLL BLL = new EmpresaBLL();
            EmpresaType empresa = BLL.selectRecord(idEmpresa);

            PagamentoBLL pgBLL = new PagamentoBLL();
            pgBLL.efetuarBaixa(empresa,100.00);
            empresa.addDays(30); 
        }
    }
}
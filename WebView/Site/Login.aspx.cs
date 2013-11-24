using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            BLL.EmpresaBLL empresaBLL = new BLL.EmpresaBLL();
            EmpresaType empresa = empresaBLL.login(txtUsuario.Text,txtSenha.Text);

            if (empresa.IdEmpresa > 0)
            {
                Session["idEmpresa"] = empresa.IdEmpresa;
                Response.Redirect("/Painel-Empresa/Default.aspx");
            }
            else
            {               
                Response.Write("<script>Javascript:alert('Acesso negado');</script>");
            }
        }
    }
}
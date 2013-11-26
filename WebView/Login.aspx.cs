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
            Types.AssociacaoType assoc = new Types.AssociacaoType();
            assoc.Usuario = txtUsuario.Text;
            assoc.Senha = txtSenha.Text;

            BLL.AssociacaoBLL assocBLL = new BLL.AssociacaoBLL();
            assoc = assocBLL.login(assoc);

            if (assoc.IdAssociacao > 0)
            {
                Session["AssociacaoID"] = assoc.IdAssociacao;
                Response.Redirect("~/Default.aspx");
            }
            else
            {               
                Response.Write("<script>Javascript:alert('Acesso negado');</script>");
            }
        }
    }
}
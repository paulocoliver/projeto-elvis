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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            Types.AssociacaoType assoc = new Types.AssociacaoType();
            assoc.Nome = txtNome.Text;
            assoc.Url = txtUrl.Text;
            assoc.Usuario = txtUsuario.Text;
            assoc.Senha = txtSenha.Text;

            BLL.AssociacaoBLL assocBLL = new BLL.AssociacaoBLL();
            int id = assocBLL.insert(assoc);

            if (id > 0)
            {
                Session["AssociacaoID"] = id;
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Write("<script>Javascript:alert('Ocorreu um erro ao tentar cadastrar a associação');</script>");
            }
            
        }
    }
}
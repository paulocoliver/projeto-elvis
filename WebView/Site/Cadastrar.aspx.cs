using Newtonsoft.Json;
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
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    EmpresaType empresa = save();
                    if (Convert.ToInt32(empresa.IdEmpresa) > 0)
                    {
                        Session["idEmpresa"] = empresa.IdEmpresa;
                        Response.Redirect("/Painel-Empresa/Default.aspx");
                    }
                    else
                    {
                        throw new Exception("Não foi possivel cadastrar este usuário");
                    }
                }
                catch (Exception error) {
                    Response.Write("<script type='text/javascript'>alert('" + error.Message + "')</script>");
                }
              
            }else{
                selectPaises();
            }
        }

        public void selectPaises()
        {
            PaisBLL bll = new PaisBLL();
            PaisesType paises = new PaisesType();
            paises.Add(new PaisType());
            paises.AddRange(bll.select());
            selectPais.DataValueField = "idPais";
            selectPais.DataTextField = "Descricao";
            selectPais.DataSource = paises;
            
            selectPais.DataBind();
        }

        public EmpresaType save()
        {
            EmpresaType empresa = new EmpresaType();
            empresa.IdAssociacao = Master.AssociacaoIdCookie;
            empresa.IdCidade = Convert.ToInt32(txtCidade.Text);
            empresa.RazaoSocial = txtRazaoSocial.Text;
            empresa.Senha = txtSenha.Text;
            empresa.Nome = txtNome.Text;
            empresa.CNPJ = txtCNPJ.Text;
            empresa.IE = txtIE.Text;
            empresa.CEP = txtCEP.Text;
            empresa.Endereco = txtEndereco.Text;
            empresa.Complemento = txtComplemento.Text;
            empresa.Email = txtEmail.Text;
            empresa.Site = txtSite.Text;
           

            EmpresaBLL bll = new EmpresaBLL();
            empresa.IdEmpresa = bll.insert(empresa);

            return empresa;
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Assoc
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        private string _id_associacao;

        protected void Page_Load(object sender, EventArgs e)
        {
            _id_associacao = "1";
            if (IsPostBack)
            {
                if (save() )
                {
                    Response.Redirect("/Assoc/Default.aspx");
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

        public bool save() {

            EmpresaType empresa = new EmpresaType();
            empresa.IdAssociacao = _id_associacao;
            empresa.IdCidade = txtCidade.Text;
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
            bll.insert(empresa);

            return true;
        }
    }
}
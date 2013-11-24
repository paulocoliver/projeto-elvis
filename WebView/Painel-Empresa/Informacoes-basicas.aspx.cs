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
    public partial class Informacoes_basicas : System.Web.UI.Page
    {
        private EmpresaType _empresa;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpresaBLL bll = new EmpresaBLL();
            int idEmpresa = Session["idEmpresa"]  != null ? Convert.ToInt32(Session["idEmpresa"]) : 7;

            _empresa = bll.selectRecord(idEmpresa);

            if (IsPostBack)
            {
                try
                {
                    if (save())
                    {
                        Response.Write("<script type='text/javascript'>alert('Dados atualizados com sucesso.')</script>");
                    }
                    else {
                        throw new Exception("Não foi possivel atualizar o cadastro");
                    }
                }
                catch (Exception error)
                {
                    Response.Write("<script type='text/javascript'>alert('" + error.Message + "')</script>");
                }
            }

            addValues();
        }

        public bool save()
        {
            _empresa.IdCidade = Convert.ToInt32(txtCidade.Text);
            _empresa.RazaoSocial = txtRazaoSocial.Text;
            _empresa.Nome = txtNome.Text;
            _empresa.CNPJ = txtCNPJ.Text;
            _empresa.IE = txtIE.Text;
            _empresa.CEP = txtCEP.Text;
            _empresa.Endereco = txtEndereco.Text;
            _empresa.Complemento = txtComplemento.Text;
            _empresa.Email = txtEmail.Text;
            _empresa.Site = txtSite.Text;

            EmpresaBLL bll = new EmpresaBLL();

            return bll.update(_empresa);
        }

        public void addValues() {

            cidadeType cidade = getCidade(_empresa.IdCidade);
            EstadoType estado = getEstado(Convert.ToInt32(cidade.idEstado));

            loadPaises(estado.idPais);
            txtEstado.Text = estado.idEstado;
            txtCidade.Text = cidade.idCidade;

            txtCEP.Text  = _empresa.CEP;
            txtCNPJ.Text = _empresa.CNPJ;
            txtComplemento.Text = _empresa.Complemento;
            txtEmail.Text = _empresa.Email;
            txtEndereco.Text = _empresa.Endereco;    
            txtIE.Text = _empresa.IE;
            txtNome.Text = _empresa.Nome;
            txtRazaoSocial.Text = _empresa.RazaoSocial;
            txtSite.Text = _empresa.Site;
        }

        public void loadPaises(string idPais)
        {
            PaisBLL bll = new PaisBLL();
            PaisesType paises = new PaisesType();
            paises.Add(new PaisType());
            paises.AddRange(bll.select());
            selectPais.DataValueField = "idPais";
            selectPais.DataTextField = "Descricao";
            selectPais.DataSource = paises;
            selectPais.SelectedValue = idPais;

            selectPais.DataBind();
        }

        public cidadeType getCidade(int id_cidade)
        {
            CidadeBLL bll = new CidadeBLL();
            return bll.selectRecord(id_cidade);
        }

        public EstadoType getEstado(int id_estado) {
            EstadoBLL bll = new EstadoBLL();
            return bll.selectRecord(id_estado);
        }
    }
}
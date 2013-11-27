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
    public partial class Financeiro_add : System.Web.UI.Page
    {
        private string url_list;
        public FinanceiroType financ;
        public FinanceiroBLL financBLL;
        public string _TitlePage;

        protected void Page_Load(object sender, EventArgs e)
        {
            url_list = "~/Painel/Financeiro.aspx";

            int id = Convert.ToInt32(Request.QueryString["id"]);
            financBLL = new FinanceiroBLL();

            if (id > 0)
            {
                _TitlePage = "Editar";
                financ = financBLL.selectRecord(id);
                if (financ.IdFinanceiro > 0 && Master.SessionAssociacaoId == financ.IdAssociacao)
                {
                    if (!IsPostBack)
                    {
                        double newValor = financ.Valor;
                        if (financ.Valor < 0)
                        {
                            newValor = financ.Valor * -1;
                        }

                        txtTitulo.Text = financ.Titulo;
                        txtValor.Text = newValor.ToString();
                        txtData.Text = financ.DataFormatSql;
                        RdoTipo.SelectedValue = financ.Tipo;
                    }
                }
                else
                {
                    Session["FlashMsg"] = "Id invalido";
                    Session["FlashMsgType"] = "danger";
                    Response.Redirect(url_list);
                }
            }
            else
            {
                _TitlePage = "Adicionar";
                financ = new FinanceiroType();
            }

            _TitlePage += " Receita ou Despesa";

            this.Title = _TitlePage;

            this.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                financ.IdAssociacao = Master.SessionAssociacaoId;
                financ.Titulo = txtTitulo.Text;
                financ.Valor = Double.Parse(txtValor.Text);
                financ.Data = txtData.Text;
                financ.Tipo = RdoTipo.SelectedValue;
                
                if ((financ.Tipo == "despesa" && financ.Valor > 0) || financ.Tipo == "receita" && financ.Valor < 0)
                {
                    financ.Valor = financ.Valor * -1;
                }

                string msg;
                if (financ.IdFinanceiro > 0)
                {
                    financBLL.update(financ);
                    msg = "Alterado com sucesso";
                }
                else
                {
                    financ.IdFinanceiro = financBLL.insert(financ);
                    msg = "Adicionado com sucesso";
                }

                if (financ.IdFinanceiro > 0)
                {
                    Session["FlashMsg"] = msg;
                    Session["FlashMsgType"] = "success";
                }
                else
                {
                    throw new Exception("Ocorreu um erro");
                }
            }
            catch (Exception ex)
            {
                Session["FlashMsg"] = ex.Message;
                //Session["FlashMsg"] = "Ocorreu um erro";
                Session["FlashMsgType"] = "danger";
            }
            finally
            {
            }

            Response.Redirect(this.url_list);
        }
    }
}
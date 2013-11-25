using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Empresa
{
    public partial class Questionario_add : System.Web.UI.Page
    {
        private string url_list;
        public QuestionarioType questionario;
        public QuestionarioBLL questionarioBLL;
        public QuestionarioOpcoesType OpcoesQuestionario;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.url_list = "~/Painel/Questionario.aspx";

            this.questionarioBLL = new QuestionarioBLL();
            this.OpcoesQuestionario = new QuestionarioOpcoesType();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            if (id != null && id > 0)
            {
                this.questionario = this.questionarioBLL.selectRecord(id);

                if (questionario.idQuestionario != null && questionario.idQuestionario > 0)
                {
                    if (!IsPostBack)
                    {
                        txtPergunta.Text = questionario.Descricao;
                        cmb_tipo.SelectedValue = questionario.Tipo;
                    }

                    string[] exploded = questionario.Tipo.Split('_');
                    if (exploded[1] == "S")
                    {
                        QuestionarioOpcaoBLL bllOpcoes = new QuestionarioOpcaoBLL();
                        this.OpcoesQuestionario = bllOpcoes.select(questionario);
                    }
                }
                else
                {
                    Session["FlashMsg"] = "Id invalido";
                    Session["FlashMsgType"] = "danger";
                    Response.Redirect(this.url_list);
                }

            }
            else
            {
                this.questionario = new QuestionarioType();
            }

            this.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            this.questionario.Descricao = txtPergunta.Text;
            this.questionario.Tipo = cmb_tipo.SelectedValue;
            this.questionario.IdAssociacao = Int32.Parse(Session["AssociacaoID"].ToString());

            
            try
            {
                string msg;
                if (this.questionario.idQuestionario != null && this.questionario.idQuestionario > 0)
                {
                    questionarioBLL.update(this.questionario);
                    msg = "Alterado com sucesso";
                }
                else
                {
                    this.questionario.idQuestionario = questionarioBLL.insert(this.questionario);
                    msg = "Adicionado com sucesso";
                }

                if (this.questionario.idQuestionario != null && this.questionario.idQuestionario > 0)
                {
                    string formOptions = Request.Form["options[]"];
                    if (formOptions != null)
                    {
                        string[] opcoes = formOptions.Split(',');
                        if (opcoes.Length > 0)
                        {
                            QuestionarioOpcaoBLL optBLL = new QuestionarioOpcaoBLL();
                            optBLL.delete(this.questionario);

                            foreach (string opt in opcoes)
                            {
                                QuestionarioOpcaoType optType = new QuestionarioOpcaoType();
                                optType.IdQuestionario = this.questionario.idQuestionario;
                                optType.Descricao = opt;
                                optBLL.insert(optType);
                            }
                        }
                    }

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
                //Session["FlashMsg"] = ex.Message;
                Session["FlashMsg"] = "Ocorreu um erro";
                Session["FlashMsgType"] = "danger";
            }
            finally
            {
            }

            Response.Redirect(this.url_list);
        }
    }
}
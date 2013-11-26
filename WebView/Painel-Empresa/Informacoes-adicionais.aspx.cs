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
    public partial class Questionario : System.Web.UI.Page
    {
        public QuestionariosType questionarios;
        private EmpresaType _empresa;

        protected void Page_Load(object sender, EventArgs e)
        {
            _empresa = Master.getEmpresa();

            QuestionarioBLL bll = new QuestionarioBLL();
            questionarios = bll.select(_empresa.IdAssociacao, _empresa.IdEmpresa);

            if (IsPostBack)
            {
                save(); 
            }
        }

        private void save() {

            QuestionarioRespostaBLL bll = new QuestionarioRespostaBLL();

            foreach (QuestionarioType questionario in questionarios) {

                QuestionarioRespostasType questionarioRespostas = new QuestionarioRespostasType();
                if (Request.Form[questionario.idQuestionario.ToString()] != null)
                {
                    string[] respostas = Request.Form[ questionario.idQuestionario.ToString() ].Split(',');
                
                    foreach (string resposta in respostas) {
                        QuestionarioRespostaType questionarioResposta = new QuestionarioRespostaType();
                        questionarioResposta.idQuestionario = questionario.idQuestionario;
                        questionarioResposta.idEmpresa = _empresa.IdEmpresa;
                        questionarioResposta.Valor = resposta;
                        questionarioRespostas.Add(questionarioResposta);
                    }
                }
                questionario.Respostas = questionarioRespostas;
                bll.save(questionario, _empresa.IdEmpresa);
            }
        }

        public void createSelect(QuestionarioType questionario)
        {
            Response.Write("<label for='" + questionario.idQuestionario + "'>" + questionario.Descricao + "</label>");
            Response.Write("<select class='form-control' name='" + questionario.idQuestionario + "' id='" + questionario.idQuestionario + "' >");
            if (questionario.TipoIsMultiple)
            {
                Trabalho.Types.QuestionarioOpcoesType ops = getOptions(questionario);
                foreach (Trabalho.Types.QuestionarioOpcaoType op in ops)
                {
                    Response.Write("<option value='" + op.Descricao + "' "+(questionario.Respostas.hasValue(op.Descricao) ? "selected='selected'" : "") +" >" + op.Descricao + "</options>");
                }
            }
            Response.Write("</select>");
        }

        public void createInput(QuestionarioType questionario)
        {

            Response.Write("<label for='" + questionario.idQuestionario + "'>" + questionario.Descricao + "</label>");
            if (questionario.TipoIsMultiple)
            {
                Trabalho.Types.QuestionarioOpcoesType ops = getOptions(questionario);
                Response.Write("<div class='form-inline'>");
                foreach (Trabalho.Types.QuestionarioOpcaoType op in ops)
                {
   
                    Response.Write("<label for='" + op.idOpcaoQuestionario + "'>" + op.Descricao + "</label>");
                    Response.Write("<input "+
                                    (questionario.Respostas.hasValue(op.Descricao) ? "checked='checked' " : "") +
                                    "type='" + questionario.TipoFormat + "' "+ 
                                    "name='" + questionario.idQuestionario + "' " +
                                    "id='" + op.idOpcaoQuestionario + "' " + 
                                    "value='" + op.Descricao + "' " + 
                                   "/>");     
                }
                Response.Write("</div>");
            }
            else
            {
                string resposta = "";
                if (questionario.Respostas.ToArray().Length > 0) {
                    resposta = questionario.Respostas[0].Valor;   
                }
                Response.Write("<input class='form-control " + questionario.TipoFormat.ToLower() + "' value='" + resposta + "' type='" + questionario.TipoFormat + "' name='" + questionario.idQuestionario + "' id='" + questionario.idQuestionario + "' >");
            }
            
        }

        public QuestionarioOpcoesType getOptions(QuestionarioType questionario)
        {
            QuestionarioOpcaoBLL bll = new QuestionarioOpcaoBLL();
            QuestionarioOpcoesType opcoes = bll.select(questionario);

            return opcoes;
        }
    }
}
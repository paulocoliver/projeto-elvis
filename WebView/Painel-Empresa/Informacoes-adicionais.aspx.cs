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

        protected void Page_Load(object sender, EventArgs e)
        {
            QuestionarioBLL bll = new QuestionarioBLL();
            questionarios = bll.select();
        }

        public void createSelect(QuestionarioType questionario)
        {
            Response.Write("<label for='" + questionario.Descricao + "'>" + questionario.Descricao + "</label>");
            Response.Write("<select class='form-control' name='" + questionario.Descricao + "' id='" + questionario.Descricao + "' >");
            if (questionario.TipoIsMultiple)
            {
                Trabalho.Types.QuestionarioOpcoesType ops = getOptions(questionario);
                foreach (Trabalho.Types.QuestionarioOpcaoType op in ops)
                {
                    Response.Write("<option value='" + op.Descricao + "'>" + op.Descricao + "</options>");
                }
            }
            Response.Write("</select>");
        }

        public void createInput(QuestionarioType questionario)
        {
           
            Response.Write("<label for='" + questionario.Descricao + "'>" + questionario.Descricao + "</label>");
            if (questionario.TipoIsMultiple)
            {
                Trabalho.Types.QuestionarioOpcoesType ops = getOptions(questionario);
                Response.Write("<div class='form-inline'>");
                foreach (Trabalho.Types.QuestionarioOpcaoType op in ops)
                {
                    Response.Write("<label for='" + op.Descricao + "'>" + op.Descricao + "</label>");
                    Response.Write("<input type='" + questionario.TipoFormat + "' name='" + questionario.Descricao + "' id='" + op.Descricao + "' value='" + op.Descricao + "'/>");     
                }
                Response.Write("</div>");
            }
            else
            {
                Response.Write("<input class='form-control " + questionario.TipoFormat.ToLower() + "' type='" + questionario.TipoFormat + "' name='" + questionario.Descricao + "' id='" + questionario.Descricao + "' >");
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
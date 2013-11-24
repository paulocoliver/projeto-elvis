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
    public partial class Questionario_del : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                QuestionarioBLL questionarioBLL = new QuestionarioBLL();
                QuestionarioType questionario = questionarioBLL.selectRecord(id);
                if (questionario.idQuestionario != null && questionario.idQuestionario > 0 && questionario.IdAssociacao == Int32.Parse(Session["AssociacaoID"].ToString()))
                {
                    QuestionarioOpcaoBLL opcaoBLL = new QuestionarioOpcaoBLL();
                    opcaoBLL.delete(questionario);
                    questionarioBLL.delete(questionario);
                    Session["FlashMsg"] = "Apagado com sucesso";
                    Session["FlashMsgType"] = "success";
                }
                else
                {
                    throw new Exception("Id invalido");
                }
            }
            catch (Exception ex)
            {
                Session["FlashMsg"] = "Ocorreu um erro ao apagar";
                Session["FlashMsgType"] = "danger";
            }
            
            Response.Redirect("~/Empresa/Questionario.aspx");
        }
    }
}
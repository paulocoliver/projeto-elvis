using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho.WebView.Painel
{
    public partial class Empresas_view : System.Web.UI.Page
    {
        private Types.EmpresaType _DadosEmpresa;
        private Types.QuestionariosType _RespostasQuestionario;

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            try
            {
                if ( id > 0)
                {
                    BLL.EmpresaBLL BLL = new BLL.EmpresaBLL();
                    DadosEmpresa = BLL.selectRecord(id);
                    if (DadosEmpresa.IdAssociacao != Master.SessionAssociacaoId)
                        throw new Exception("IdAssociacao invalido");

                    BLL.QuestionarioBLL QuestBLL = new BLL.QuestionarioBLL();
                    RespostasQuestionario = QuestBLL.select(DadosEmpresa.IdAssociacao, DadosEmpresa.IdEmpresa);
                }
                else
                {
                    throw new Exception("No id");
                }
            }
            catch (Exception)
            {
                Session["FlashMsg"] = "Ocorreu um erro";
                Session["FlashMsgType"] = "danger";
                Response.Redirect("~/Painel/Empresas.aspx");
            }

            this.DataBind();
        }

        public Types.EmpresaType DadosEmpresa
        {
            get { return _DadosEmpresa; }
            set { _DadosEmpresa = value; }
        }

        public Types.QuestionariosType RespostasQuestionario
        {
            get { return _RespostasQuestionario; }
            set { _RespostasQuestionario = value; }
        }
    }
}
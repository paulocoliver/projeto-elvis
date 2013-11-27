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
    public partial class Financeiro_del : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                FinanceiroBLL financBLL = new FinanceiroBLL();
                FinanceiroType financ = financBLL.selectRecord(id);
                if (financ.IdFinanceiro != null && financ.IdFinanceiro > 0 && financ.IdAssociacao == Int32.Parse(Session["AssociacaoID"].ToString()))
                {
                    financBLL.delete(financ);
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

            Response.Redirect("~/Painel/Financeiro.aspx");
        }
    }
}
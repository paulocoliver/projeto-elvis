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
    public partial class Empresas_Efetuar_Baixa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idEmpresa = Convert.ToInt32(Request.QueryString["id"].ToString());
            int idAssociacao;

            if (Session["AssociacaoID"] == null)
            {
                idAssociacao = 7;
                //Response.Redirect("~/Login.aspx");
            }
            else {
                idAssociacao = Convert.ToInt32(Session["AssociacaoID"]);
            }

            try
            {
                if (idEmpresa > 0)
                {
                    EmpresaBLL BLL = new EmpresaBLL();
                    EmpresaType empresa = BLL.selectRecord(idEmpresa);

                    if(empresa.IdAssociacao != idAssociacao){
                        throw new Exception("Acesso Negado!");
                    }

                    PagamentoBLL pgBLL = new PagamentoBLL();
                    pgBLL.efetuarBaixa(empresa, 100.00);
                    empresa.addDays(30);

                    Session["FlashMsg"] = "Baixa efetuada com sucesso.";
                    Session["FlashMsgType"] = "success";
                }
                else
                {
                    throw new Exception("ID Empresa não encontrado");
                }
            }
            catch (Exception error)
            {
                Session["FlashMsg"] = error.Message;
                Session["FlashMsgType"] = "dang";
            }
            finally {
                Response.Redirect("~/Painel/Empresas.aspx");
            }
        }
    }
}
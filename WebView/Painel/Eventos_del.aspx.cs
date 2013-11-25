using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.Types;
using Trabalho.BLL;

namespace Trabalho.WebView.Painel
{
    public partial class Eventos_del : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                if( id > 0 ){
               
                    EventoBLL bll = new EventoBLL();
                    EventoType evento = bll.selectRecord(id);

                    if (evento.idEvento > 0 && evento.idAssociacao == Int32.Parse(Session["AssociacaoID"].ToString()))
                    {
                        bll.delete(evento);
                        Session["FlashMsg"] = "Apagado com sucesso";
                        Session["FlashMsgType"] = "success";
                    }
                    else
                    {
                        throw new Exception("Id invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                Session["FlashMsg"] = ex.Message;
                Session["FlashMsgType"] = "danger";
            }

            Response.Redirect("~/Painel/Eventos.aspx");
        }
    }
}
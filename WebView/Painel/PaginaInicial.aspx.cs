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
    public partial class PaginaInicial : System.Web.UI.Page
    {
        public string texto;

        protected void Page_Load(object sender, EventArgs e)
        {
            int idAssociacao = Int32.Parse(Session["AssociacaoID"].ToString());

            PaginaInicialBLL bll = new PaginaInicialBLL();
            PaginaInicialType pagina = bll.select(idAssociacao);

            if(IsPostBack){
                pagina.Texto = Request.Form["texto"].ToString();
                bll.save(pagina);

                Session["FlashMsg"] = "Conteúdo atualizado com sucesso.";
                Session["FlashMsgType"] = "success";
            }
            texto = pagina.Texto;
        }
    }
}
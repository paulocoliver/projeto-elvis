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
    public partial class Eventos_add : System.Web.UI.Page
    {
        private int _idAssociacao;
        private int _idEvento;
        private EventoType _evento;

        public string _Descricao = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            _idAssociacao = (Session["idAssociacao"] == null ? 1 : Convert.ToInt32(Session["idAssociacao"].ToString()));
            _idEvento = Convert.ToInt32(Request.QueryString["id"]);

             loadEvento();

        }

        public void loadEvento() {
            EventoBLL bll = new EventoBLL();

            if (_idEvento > 0 && !IsPostBack)
            {
                _evento = bll.selectRecord(_idEvento);

                txtTitulo.Text = _evento.Titulo;
                txtLocal.Text = _evento.Local;           
                txtDataInicio.Text = _evento.dataIniToInput;
                txtDataFim.Text = _evento.dataEndToInput;
                _Descricao = _evento.Descricao;
            }
            else {
                _evento = new EventoType();
                if(_idEvento > 0){
                    _evento.idEvento = _idEvento;               
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try{

                EventoBLL bll = new EventoBLL();
                string descricao = Request.Form["descricao"].ToString();

                _evento.idAssociacao = Master.getAssociacaoSession().IdAssociacao;
                _evento.Local = txtLocal.Text;
                _evento.Titulo = txtTitulo.Text;
                _evento.dataIni = txtDataInicio.Text;
                _evento.dataEnd = txtDataFim.Text;
                _evento.Descricao = descricao;
      
                if (_evento.idEvento > 0)
                {
                    bll.update(_evento);

                    Session["FlashMsg"] = "Evento atualizado com sucesso.";
                    Session["FlashMsgType"] = "success";
                }
                else {
                    bll.inserir(_evento);

                    Session["FlashMsg"] = "Evento cadastro com sucesso.";
                    Session["FlashMsgType"] = "success";
                }

           }catch (Exception ex)
           {
                Session["FlashMsg"] = ex.Message;
                Session["FlashMsgType"] = "danger";
           }
           finally
           {
               Response.Redirect("~/Painel/Eventos.aspx");
           }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho.WebView.Painel
{
    public partial class Financeiro : System.Web.UI.Page
    {
        private Types.FinanceirosType _DadosFinanceiros;
        public double saldoAnterior;

        protected void Page_Load(object sender, EventArgs e)
        {
            string mes = "11";
            string ano = "2013";

            if (IsPostBack)
            {
                mes = cmb_mes.Text;
                ano = cmb_ano.Text;
            }
            else
            {
                cmb_mes.Text = mes.ToString();
                cmb_ano.Text = ano.ToString();
            }


            Types.AssociacaoType assoc = Master.getAssociacaoSession();
            BLL.FinanceiroBLL BLL = new BLL.FinanceiroBLL();
            _DadosFinanceiros = BLL.selectByAssociacao(assoc, ano, mes);

            saldoAnterior = BLL.selectSaldoAnterior(assoc, ano, mes);

            this.DataBind();
        }

        public Types.FinanceirosType DadosFinanceiros
        {
            get { return _DadosFinanceiros; }
            set { _DadosFinanceiros = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho.WebView.Layout
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        private Types.AssociacaoType Assoc;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["AssociacaoID"] = 1;
            VerificaSession();

        }

        public void VerificaSession() {
            if (Session["AssociacaoID"] == null)
                Response.Redirect("~/Login.aspx");
        }

        public int SessionAssociacaoId
        {
            get {
                VerificaSession();
                return Int32.Parse(Session["AssociacaoID"].ToString()); 
            }
            set { Session["AssociacaoID"] = value; }
        }

        public Types.AssociacaoType getAssociacaoSession()
        {
            if (Assoc == null) {
                VerificaSession();
                BLL.AssociacaoBLL AssocBLL = new BLL.AssociacaoBLL();
                Assoc = AssocBLL.selectRecord(SessionAssociacaoId);
            }
            return Assoc;
        }
    }
}
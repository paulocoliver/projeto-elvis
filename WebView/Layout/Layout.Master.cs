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
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AssociacaoID"] = 1;
            if (Session["AssociacaoID"] == null)
                Response.Redirect("~/Login.aspx");

        }

        public int SessionAssociacaoId
        {
            get { return Int32.Parse(Session["AssociacaoID"].ToString()); }
            set { Session["AssociacaoID"] = value; }
        }

        public Types.AssociacaoType getAssociacaoSession()
        {
            if (SessionAssociacaoId == 0)
                Response.Redirect("~/Login.aspx");

            BLL.AssociacaoBLL AssocBLL = new BLL.AssociacaoBLL();
            return AssocBLL.selectRecord(SessionAssociacaoId);
        }
    }
}
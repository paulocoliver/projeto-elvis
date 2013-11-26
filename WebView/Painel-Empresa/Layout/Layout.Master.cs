using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.Types;
using Trabalho.BLL;

namespace Trabalho.WebView.Painel_Empresa.Layout
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idEmpresa"] = 7;
            if(Session["idEmpresa"] == null)
            {
                Response.Redirect("/Site/Default.aspx");
            }
        }

        public int SessionEmpresa
        {
            get {
                if (Session["idEmpresa"] == null) {
                    Session["idEmpresa"] = 7;
                }
                return Int32.Parse(Session["idEmpresa"].ToString()); 
            }
            set { Session["idEmpresa"] = value; }
        }

        public EmpresaType getEmpresa()
        {
            if (SessionEmpresa == 0)
                Response.Redirect("/Site/Login.aspx");

            EmpresaBLL BLL = new EmpresaBLL();
            return BLL.selectRecord(SessionEmpresa);
        }
    }
}
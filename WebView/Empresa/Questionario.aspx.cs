using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Empresa
{
    public partial class Questionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuestionarioBLL questBLL = new QuestionarioBLL();
            GridView1.DataSource = questBLL.select();
            GridView1.DataBind();
        }
    }
}
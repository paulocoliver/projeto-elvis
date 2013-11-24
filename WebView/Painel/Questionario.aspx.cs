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
            GridView1.DataSource = questBLL.select(1, null);
            GridView1.DataBind();
        }

        public List<String> GetTipos()
        {
            List<String> list = new List<String>();

            list.Add("Text");
            list.Add("Textarea");
            list.Add("Select");
            list.Add("Checkbox");
            list.Add("Radio");
            list.Add("File");
            list.Add("Color");
            list.Add("Date");
            list.Add("Time");

            return list;
        }
        
    }
}
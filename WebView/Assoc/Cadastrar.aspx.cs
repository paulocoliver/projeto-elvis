using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho.BLL;
using Trabalho.Types;

namespace Trabalho.WebView.Assoc
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        private int _id_associacao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }else{
                selectPaises();
            }
        }

        public void selectPaises()
        {
            PaisBLL bll = new PaisBLL();
            PaisesType paises = new PaisesType();
            paises.Add(new PaisType());
            paises.AddRange(bll.select());
            selectPais.DataValueField = "idPais";
            selectPais.DataTextField = "Descricao";
            selectPais.DataSource = paises;
            
            selectPais.DataBind();
        }

        public void save() {

            EmpresaType empresa = new EmpresaType();
            //empresa.IdAssociacao = _id_associacao;
            
        }

        

    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho.BLL;
using Trabalho.Types;

namespace WebView.Assoc.Ajax
{
    /// <summary>
    /// Summary description for Buscar_Cidades
    /// </summary>
    public class Buscar_Cidades : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            int idEstado = Convert.ToInt32(context.Request.QueryString["id"]);
            AjaxResponse response = new AjaxResponse();
            response.Success = true;
            response.Cidades = cidadeBLL.select(idEstado);

            context.Response.ContentType = "application/json";
            context.Response.Write(JsonConvert.SerializeObject(response));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public class AjaxResponse
        {

            private cidadesType _cidades;
            private bool _success;
            private string _msg;

            public cidadesType Cidades
            {
                get { return _cidades; }
                set { _cidades = value; }
            }

            public bool Success
            {
                get { return _success; }
                set { _success = value; }
            }

            public string Msg
            {
                get { return _msg; }
                set { _msg = value; }
            }
        }
    }
}
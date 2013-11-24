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
    /// Summary description for Buscar_Estados
    /// </summary>
    public class Buscar_Estados : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            int idPais = Convert.ToInt32(context.Request.QueryString["id"]);
            AjaxResponse response = new AjaxResponse();
            response.Success = true;
            response.Estados = estadoBLL.select(idPais);

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
    }

    public class AjaxResponse{

        private EstadosType _estados;
        private bool _success;
        private string _msg;

        public EstadosType Estados
        {
            get { return _estados; }
            set { _estados = value; }
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
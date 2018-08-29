using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace SudokuWeb.ViewBusiness
{
 
    public class ActivarAdministrador : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType.Equals("GET") && context.Request.QueryString.Keys.Count > 0)
            {
                Engine.EngineUtil Funcion = new Engine.EngineUtil();
                string mail = Funcion.DecodeBase64(context.Request.QueryString["mail"]);
                string password = context.Request.QueryString["password"];
                string administrador = context.Request.QueryString["administrador"];
                Engine.EngineUtil.ActivarCuentaAdministrador(mail, password, administrador);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
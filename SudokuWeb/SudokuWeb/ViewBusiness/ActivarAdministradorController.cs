using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SudokuWeb.ViewBusiness
{
    public class ActivarAdministradorController : ApiController
    {
        [HttpGet]
        public string GetActivarAdministrador(string mail, string password, string administrador)
        {
            Engine.EngineUtil Funcion = new Engine.EngineUtil();
            mail = Funcion.DecodeBase64(mail);
            string resultado = Engine.EngineUtil.ActivarCuentaAdministrador(mail, password, administrador);
            Engine.MailNotificacion FuncionMail = new Engine.MailNotificacion();
            return resultado;
        }
    }
}
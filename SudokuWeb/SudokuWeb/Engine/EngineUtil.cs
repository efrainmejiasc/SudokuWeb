using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace SudokuWeb.Engine
{
    public class EngineUtil
    {
        private static Models.EngineModel ModeloDb = new Models.EngineModel();
        private static Engine.MailNotificacion FuncionMail = new Engine.MailNotificacion();


        public string ConvertirBase64(string cadena)
        {
            var comprobanteXmlPlainTextBytes = Encoding.UTF8.GetBytes(cadena);
            var cadenaBase64 = Convert.ToBase64String(comprobanteXmlPlainTextBytes);
            return cadenaBase64;
        }

        public string DecodeBase64(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public bool EmailEsValido(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            bool resultado = false;
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public bool InternetConnection()
        {
            bool r = false;
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                r = true;
            }
            catch { }
            return r;
        }

        // ************************************************************************************************************************************************

        [System.Web.Services.WebMethod]
        public static string  CrearPerfilCliente(string MAIL, string NOMBRE, string USUARIO, string PASSWORD,string PASSWORD2,bool ROBOT)
        {
            EngineUtil Funcion = new EngineUtil();
            string resultado = string.Empty;

            if (NOMBRE == string.Empty)
            {
                resultado = "El Campo Nombre No Puede Estar Vacio";
                return resultado;
            }
            else if (MAIL == string.Empty)
            {
                resultado = "El Campo Correo Electronico No Puede Estar Vacio";
                return resultado;
            }
            else if (USUARIO == string.Empty)
            {
              resultado = "El Campo Nombre de Usuario No Puede Estar Vacio";
              return resultado;
            }
            else if (USUARIO.Contains(" "))
            {
                resultado = "El Campo Nombre de Usuario No Puede Contener Espacios en Blanco";
                return resultado;
            }
            else if (PASSWORD == string.Empty)
            {
                resultado = "El Campo Contraseña No Puede Estar Vacio";
                return resultado;
            }
            else if (PASSWORD.Contains(" "))
            {
                resultado = "El Campo Contraseña No Puede Contener Espacios en Blanco";
                return resultado;
            }
            else if (PASSWORD2 == string.Empty)
            {
                resultado = "El Campo Confirmar Contraseña No Puede Estar Vacio";
                return resultado;
            }
            else if (PASSWORD.Contains(" "))
            {
                resultado = "El Campo Confirmar Contraseña No Puede Contener Espacios en Blanco";
                return resultado;
            }
            else if (PASSWORD != PASSWORD2)
            {
                resultado = "Las Contrasñas deben ser Iguales";
                return resultado;
            }
            else if (!Funcion.EmailEsValido(MAIL))
            {
                resultado = "Debe Ingresar una Direccion de Correo Valida";
                return resultado;
            }
            else if (ROBOT == false)
            {
                resultado = "Seleccione la Casilla No Soy un Robot";
                return resultado;
            }

            string existeMail = ModeloDb.SeleccionMail(MAIL);
            string existeUsuario = ModeloDb.SeleccionUsuario(USUARIO);
            if (existeMail != string.Empty && existeUsuario != string.Empty)
            {
                 resultado = "La Direccion de Correo Electronico y el Usuario ya se Encuentran Registrados"; 
            }
            else if (existeMail != string.Empty && existeUsuario == string.Empty)
            {
                 resultado = "La Direccion de Correo Electronico ya se Encuentra Registrada";
            }
            else if (existeMail == string.Empty && existeUsuario != string.Empty)
            {
                resultado = "El Nombre de Usuario ya se Encuentra Registrado";
            }
            else if (existeMail == string.Empty && existeUsuario == string.Empty)
            {
                int r = ModeloDb.InsertarCliente(MAIL, NOMBRE, USUARIO, PASSWORD);
                if (r == -1)
                {
                    bool k = FuncionMail.EnviarMail(Models.EngineData.asuntoActivacion, Models.EngineData.cuerpoActivacion + ConstruirUrlEstadoCliiente(MAIL,USUARIO,"ACTIVO") , MAIL);
                    resultado = Models.EngineData.CuentaRegistradaExitosamente;//200
                }
                else
                {
                    resultado = "La Cuenta No Pudo ser Registrada Exitosamente, Intentelo mas Tarde";
                }
            }

            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static string ConstruirUrlEstadoCliiente (string MAIL , string USUARIO , string ESTADO)
        {
            string urlEstadoCliente = string.Empty;
            EngineUtil Funcion = new EngineUtil();
            string MAIL64 = Funcion.ConvertirBase64(MAIL);
            urlEstadoCliente = Models.EngineData.urlEstado + Models.EngineData.interrogacion + Models.EngineData.usuario + USUARIO +
                               Models.EngineData.y + Models.EngineData.estado + ESTADO + Models.EngineData.y + Models.EngineData.mail + MAIL64;

            return urlEstadoCliente;
        }

        [System.Web.Services.WebMethod]
        public static string Login (string USUARIO, string PASSWORD,bool ROBOT)
        {
            string resultado = string.Empty;
            if (USUARIO == string.Empty)
            {
                resultado = "El Campo Usuario No Puede Estar Vacio";
                return resultado;
            }
            else if (PASSWORD == string.Empty)
            {
                resultado = "El Campo Contraseña No Puede Estar Vacio";
                return resultado;
            }
            else if (ROBOT == false)
            {
                resultado = "Seleccione la Casilla No Soy un Robot";
                return resultado;
            }

            string existeUsuarioPassword = ModeloDb.LogeoCliente(USUARIO,PASSWORD,"ACTIVO");
            if (existeUsuarioPassword == string.Empty)
            {
                resultado = "El Usuario con el Password Ingresado no Existe o se Encuentra Inactivo"; 
            }
            else
            {
                resultado = Models.EngineData.loginExitoso;// 500
            }

            return resultado;
        }


    }
}
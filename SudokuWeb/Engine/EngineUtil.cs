using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using SudokuWeb.Models;
using System.Data;

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

        public bool CompareString(string a, string b)
        {
            bool resultado = false;
            if (a == b)
            {
                resultado = true;
            }
            return resultado;
        }

        public string GetIpAddress(System.Web.HttpRequest request)
        {
            // Recuperamos la IP de la máquina del cliente
            // Primero comprobamos si se accede desde un proxy
            string ipAddress1 = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            // Acceso desde una máquina particular
            string ipAddress2 = request.ServerVariables["REMOTE_ADDR"];
            string ipAddress = string.IsNullOrEmpty(ipAddress1) ? ipAddress2 : ipAddress1;
            // Devolvemos la ip
            return ipAddress;
        }

        public bool SessionValida()
        {
            bool resultado = true;
            if (HttpContext.Current.Session["Usuario"] == null)
            {
                resultado = false;
            }
            return resultado;
        }

        public  DataTable AddColumnFechas(DataTable dt)
        {
            dt.Columns.Add("FechaCompra");
            dt.Columns.Add("FechaExpiracion");
            DateTime fecha = DateTime.UtcNow.Date;
            foreach (DataRow row in dt.Rows)
            {
                row["FechaCompra"] = fecha.ToString ("dd/MM/yyyy");
                row["FechaExpiracion"] = fecha.AddDays(30).ToString("dd/MM/yyyy");
            }
            return dt;
        }

        // ************************************************************************************************************************************************
        //METODOS SUDOKU AUTENTIFICACION & PERFIL CLIENTE

        [System.Web.Services.WebMethod]
        public static string CrearPerfilCliente(string MAIL, string NOMBRE, string USUARIO, string PASSWORD, string PASSWORD2, bool ROBOT)
        {
            EngineUtil Funcion = new EngineUtil();
            string resultado = string.Empty;

            if (NOMBRE == string.Empty)
            {
                resultado = Models.EngineData.campoNombreNoVacio;
                return resultado;
            }
            else if (MAIL == string.Empty)
            {
                resultado = Models.EngineData.campoCorreoElectronicoNoVacio;
                return resultado;
            }
            else if (USUARIO == string.Empty)
            {
                resultado = Models.EngineData.campoNombreUsuarioNoVacio;
                return resultado;
            }
            else if (USUARIO.Contains(" "))
            {
                resultado = Models.EngineData.nombreUsuarioConEspacios;
                return resultado;
            }
            else if (PASSWORD == string.Empty)
            {
                resultado = Models.EngineData.campoContraseñaNoVacio;
                return resultado;
            }
            else if (PASSWORD.Contains(" "))
            {
                resultado = Models.EngineData.campoContraseñaConEspacios;
                return resultado;
            }
            else if (PASSWORD2 == string.Empty)
            {
                resultado = Models.EngineData.campoConfirmarContraseñaNoVacio;
                return resultado;
            }
            else if (PASSWORD.Contains(" "))
            {
                resultado = Models.EngineData.campoConfirmarContraseñaConEspacios;
                return resultado;
            }
            else if (PASSWORD != PASSWORD2)
            {
                resultado = Models.EngineData.contraseñasNoIguales;
                return resultado;
            }
            else if (!Funcion.EmailEsValido(MAIL))
            {
                resultado = Models.EngineData.emailNoValido;
                return resultado;
            }
            else if (ROBOT == false)
            {
                resultado = Models.EngineData.seleccionCasillaNoSoyRobot;
                return resultado;
            }

            int existeMail = ModeloDb.SeleccionMail(MAIL);
            int existeUsuario = ModeloDb.SeleccionUsuario(USUARIO);
            if (existeMail > 0 && existeUsuario > 0)
            {
                resultado = Models.EngineData.mailUsuarioRegistrado;
            }
            else if (existeMail > 0 && existeUsuario == 0)
            {
                resultado = Models.EngineData.mailRegistrado;
            }
            else if (existeMail == 0 && existeUsuario != 0)
            {
                resultado = Models.EngineData.usuarioExiste;
            }
            else if (existeMail == 0 && existeUsuario == 0)
            {
                int r = ModeloDb.InsertarCliente(MAIL, NOMBRE, USUARIO, PASSWORD);
                if (r == -1)
                {
                    bool k = FuncionMail.EnviarMail(Models.EngineData.asuntoActivacion, Models.EngineData.cuerpoActivacion + " <br/> <br/> " + ConstruirUrlEstadoCliente(MAIL, USUARIO, "INACTIVO"), MAIL);
                    resultado = Models.EngineData.CuentaRegistradaExitosamente;//200
                }
                else
                {
                    resultado = Models.EngineData.cuentaNoRegistrada;
                }
            }

            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static bool SeleccionHorasActivar(string MAIL, string ESTADO)
        {
            bool resultado = false;
            int r = ModeloDb.SeleccionHorasActivar(MAIL, ESTADO);
            if (r >= 0 && r <= 72)
            {
                resultado = true;
            }

            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string ActivarCliente(string MAIL, string ESTADO)
        {
            string resultado = string.Empty;
            int r = ModeloDb.ActivarInactivarDesactivarCliente(MAIL, ESTADO);
            if (r == -1)
            {
                resultado = Models.EngineData.activacionExitosa + HttpContext.Current.Session["Usuario"].ToString();
                HttpContext.Current.Session["Estado"] = "ACTIVO";
            }
            else
            {
                resultado = Models.EngineData.cuentaNoActivada;
            }
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string ConstruirUrlEstadoCliente(string MAIL, string USUARIO, string ESTADO)
        {
            string urlEstadoCliente = string.Empty;
            EngineUtil Funcion = new EngineUtil();
            string MAIL64 = Funcion.ConvertirBase64(MAIL);
            urlEstadoCliente = Models.EngineData.urlEstado + Models.EngineData.interrogacion + Models.EngineData.usuario + USUARIO +
                               Models.EngineData.y + Models.EngineData.estado + ESTADO + Models.EngineData.y + Models.EngineData.mail + MAIL64;

            return urlEstadoCliente;
        }


        [System.Web.Services.WebMethod]
        public static bool RestablecerData(string MAIL, string CAMPO)
        {
            bool resultado = false;
            Engine.MailNotificacion FuncionMail = new Engine.MailNotificacion();
            FuncionMail.EnviarMail(Models.EngineData.asuntoRestablecer, Models.EngineData.cuerpoRestablecer + ConstruirUrlRestablecerData(MAIL, CAMPO), MAIL);

            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string ConstruirUrlRestablecerData(string MAIL, string CAMPO)
        {
            string urlRestablecerData = string.Empty;
            EngineUtil Funcion = new EngineUtil();
            string MAIL64 = Funcion.ConvertirBase64(MAIL);
            urlRestablecerData = Models.EngineData.urlRestablecer + Models.EngineData.interrogacion + Models.EngineData.mail + MAIL64 + Models.EngineData.y + Models.EngineData.campo + CAMPO;

            return urlRestablecerData;
        }

        [System.Web.Services.WebMethod]
        public static string ConstruirUrlCreateAdmin(string MAIL, string ADMINISTRADOR, string PASSWORD)
        {
            string urlActivarAdministrador = string.Empty;
            EngineUtil Funcion = new EngineUtil();
            string MAIL64 = Funcion.ConvertirBase64(MAIL);
            string PASSWORD64 = Funcion.ConvertirBase64(PASSWORD);
            urlActivarAdministrador = Models.EngineData.urlActivarAdministrador + Models.EngineData.interrogacion + Models.EngineData.mail + MAIL64 + Models.EngineData.y + Models.EngineData.password + PASSWORD64 + Models.EngineData.y + Models.EngineData.administrador + ADMINISTRADOR;

            return urlActivarAdministrador;
        }

        [System.Web.Services.WebMethod]
        public static string Login(string USUARIO, string PASSWORD, bool ROBOT)
        {
            string resultado = string.Empty;
            if (USUARIO == string.Empty)
            {
                resultado = Models.EngineData.campoNombreUsuarioNoVacio;
                return resultado;
            }
            else if (PASSWORD == string.Empty)
            {
                resultado = Models.EngineData.campoContraseñaNoVacio;
                return resultado;
            }
            else if (ROBOT == false)
            {
                resultado = Models.EngineData.seleccionCasillaNoSoyRobot;
                return resultado;
            }

            string existeUsuarioPassword = ModeloDb.LogeoCliente(USUARIO, PASSWORD, "ACTIVO");
            if (existeUsuarioPassword == string.Empty)
            {
                resultado = Models.EngineData.UsuarioPassworInactivoNoExiste;
            }
            else
            {
                EngineUtil Funcion = new EngineUtil();
                HttpContext.Current.Session["Identificador"] = Funcion.ConvertirBase64(USUARIO + PASSWORD);
                HttpContext.Current.Session["Usuario"] = USUARIO;
                resultado = Models.EngineData.loginExitoso;
            }

            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static string NuevoEmailCliente(string MAIL, string USUARIO, string ESTADO)
        {
            Models.EngineModel Funcion = new Models.EngineModel();
            string resultado = string.Empty;
            int n = Funcion.ActualizarHoraRegistroCliente(MAIL);
            if (n == -1)
            {
                bool k = FuncionMail.EnviarMail(Models.EngineData.asuntoActivacion, Models.EngineData.cuerpoActivacion + ConstruirUrlEstadoCliente(MAIL, USUARIO, "ACTIVO"), MAIL);
                if (k)
                {
                    resultado = Models.EngineData.transaccionFallida;
                }
                else
                {
                    resultado = Models.EngineData.transaccionFallida;
                }
            }
            else
            {
                resultado = Models.EngineData.transaccionFallida;
            }
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string ActualizarUsuarioCliente(string MAIL, string USUARIO, string CONTRASEÑA)
        {
            string resultado = string.Empty;
            int n = ModeloDb.ActualizarUsuarioCliente(MAIL, USUARIO, CONTRASEÑA);
            if (n == -1)
            {
                resultado = Models.EngineData.usuarioClienteActualizado;
            }
            else
            {
                resultado = Models.EngineData.transaccionFallida;
            }
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string ActualizarPasswordCliente(string MAIL, string CONTRASEÑA)
        {
            string resultado = string.Empty;
            int n = ModeloDb.ActualizarPasswordCliente(MAIL, CONTRASEÑA);
            if (n == -1)
            {
                resultado = Models.EngineData.passwordClienteActualizado;
            }
            else
            {
                resultado = Models.EngineData.transaccionFallida;
            }
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static bool ImpedirConexionesSimultaneas(string USUARIO, string IDENTIFICADOR, bool existeCookie)
        {
            bool resultado = false;
            string ip = HttpContext.Current.Session["Ip"].ToString();
            ConexionUsuario CnxUsuario = ModeloDb.SeleccionConexionUsuario(USUARIO, IDENTIFICADOR);
            if (CnxUsuario.Id == 0)
            {
                ModeloDb.InsertarConexionUsuario(USUARIO, IDENTIFICADOR, HttpContext.Current.Session["Ip"].ToString()); // 1era CONEXION
                resultado = true;
            }
            else if (CnxUsuario.Id > 0)
            {
                if (CnxUsuario.Ip == ip) // CONECTADO MISMA IP
                {
                    ModeloDb.InsertarConexionUsuario(USUARIO, IDENTIFICADOR, ip);
                    resultado = true;
                }
                else if (CnxUsuario.Ip != ip && CnxUsuario.TiempoTrascurrido <= 20) // IP DIFERENTE TIEMPO < 20
                {
                    resultado = false;
                }
                else if (CnxUsuario.Ip != ip && CnxUsuario.TiempoTrascurrido >= 20 && existeCookie) // IP DIFERENTE EXISTE COOKIE TIEMPO < "=
                {
                    ModeloDb.InsertarConexionUsuario(USUARIO, IDENTIFICADOR, ip);
                    resultado = true;
                }
                else if (CnxUsuario.Ip != ip && CnxUsuario.TiempoTrascurrido < 20 && !existeCookie)// IP DIFERENTE NO EXISTE COOKIE TIEMPO < 20
                {
                    resultado = false;
                }

            }

            return resultado;
        }

        //********************************************************************************************************************************************************************************************
        // METODO AUTENTIFICACION PERFIL ADMINISTRADOR

        [System.Web.Services.WebMethod]
        public static string AutentificacionAdministrador(string administrador, string password)
        {
            string resultado = string.Empty;
            if (administrador == string.Empty)
            {
                return resultado = "Ingrese nombre de admistrador";
            }
            else if (password == string.Empty)
            {
                return resultado = "Ingrese contraseña de administrador";
            }

            int n = ModeloDb.SeleccionIdAdministrador(administrador, password);
            if (n > 0)
            {
                resultado = "Autentificacion Exitosa";
            }
            else if (n == 0)
            {
                resultado = "Autetificacion Fallida";
            }

            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static string CreateAdministrador(string mail, string administrador, string password1, string password2)
        {
            string resultado = string.Empty;
            EngineUtil Funcion = new EngineUtil();
            if (administrador == string.Empty)
            {
                return resultado = "Ingrese nombre de admistrador";
            }
            else if (mail == string.Empty)
            {
                return resultado = "El campo correo electronico no puede ser vacio";
            }
            else if (password1 == string.Empty || password2 == string.Empty)
            {
                return resultado = "Las contraseñas no pueden ser vacias";
            }
            else if (!Funcion.CompareString(password1, password2))
            {
                return resultado = "Las contraseñas deben ser iguales";
            }
            else if (!Funcion.EmailEsValido(mail))
            {
                return resultado = "El correo electronico debe ser valido";
            }

            int n = ModeloDb.SeleccionMailAdministrador(mail);
            if (n > 0)
            {
                return resultado = "la cuenta de correo electronico ya se encuentra registrada";
            }

            n = ModeloDb.InsertarAdministrador(mail, administrador, password1);
            if (n == -1)
            {
                resultado = Models.EngineData.administradorCreadoExito;
                bool result = FuncionMail.EnviarMail(administrador + " - "+ Models.EngineData.asuntoCreateAdmin, "<br/> Nombre de Administrador: " + administrador + "<br/>" +
                                       "E-Mail: " + mail + " " + Models.EngineData.cuerpoCreateAdmin + "<br/><br/>" + EngineUtil.ConstruirUrlCreateAdmin(mail, administrador, password1), Models.EngineData.myEmail);
            }
            else
            {
                resultado = Models.EngineData.administradorCreadoFallido;
            }
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string  ActivarCuentaAdministrador(string MAIL, string PASSWORD, string ADMINISTRADOR)
        {
            string resultado = "Activacion Fallida";
            int n = ModeloDb.ActualizarEstadoAdministrador(MAIL, PASSWORD, "ACTIVO");
            if (n == -1)
            {
                FuncionMail.EnviarMail(ADMINISTRADOR + " Sudoku Para Todos", "Felicitaciones! , su cuenta de Administrador ahora esta activada <br/><br/> visite: " + Models.EngineData.urlSite, MAIL);
                resultado = Models.EngineData.actualizacionExitosa;
            }
            else
            {
                FuncionMail.EnviarMail("Administrador Sudoku Para Todos No Activado", "Su usuario no pudo ser activado correctamente", MAIL);
            }
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static string ActualizarNombreAdministrador(string MAIL, string ADMINISTRADOR, string PASSWORD)
        {
            string resultado = string.Empty;
            EngineUtil Funcion = new EngineUtil();

            if (ADMINISTRADOR == string.Empty)
            {
                return resultado = "Ingrese nombre de admistrador";
            }
            else if (PASSWORD == string.Empty)
            {
                return resultado = "Ingrese contraseña de admistrador";
            }
            else if (MAIL == string.Empty)
            {
                return resultado = "Ingrese correo electronico";
            }
            else if (!Funcion.EmailEsValido(MAIL))
            {
                return resultado = "El correo electronico debe ser valido";
            }

            int n = ModeloDb.SeleccionMailAdministrador(MAIL);
            if (n == 0)
            {
                return resultado = "la cuenta de correo electronico no se encuentra registrada";
            }

            n = ModeloDb.ActualizarNombreAdministrador(MAIL, ADMINISTRADOR, PASSWORD, "ACTIVO");
            if (n == -1)
            {
                resultado = Models.EngineData.nombreAdminUpdateExito;
            }
            else
            {
                resultado = Models.EngineData.nombreAdminUpdateFallido;
            }

            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static string ActualizarPasswordAdministrador(string MAIL, string PASSWORD1, string PASSWORD2)
        {
            string resultado = string.Empty;
            EngineUtil Funcion = new EngineUtil();

            if (PASSWORD1 == string.Empty)
            {
                return resultado = "Ingrese contraseña de admistrador";
            }
            else if (PASSWORD2 == string.Empty)
            {
                return resultado = "Ingrese confirmar contraseña de admistrador";
            }
            else if (!Funcion.CompareString(PASSWORD1, PASSWORD2))
            {
                return resultado = "Las contraseñas deben ser iguales";
            }
            else if (MAIL == string.Empty)
            {
                return resultado = "Ingrese correo electronico";
            }
            else if (!Funcion.EmailEsValido(MAIL))
            {
                return resultado = "El correo electronico debe ser valido";
            }

            int n = ModeloDb.SeleccionMailAdministrador(MAIL);
            if (n == 0)
            {
                return resultado = "la cuenta de correo electronico no se encuentra registrada";
            }

            n = ModeloDb.ActualizarPasswordAdministrador(MAIL, PASSWORD1, "ACTIVO");
            if (n == -1)
            {
                resultado = Models.EngineData.passwordAdminUpdateExito;
            }
            else
            {
                resultado = Models.EngineData.passwordAdminUpdateFallido;
            }

            return resultado;
        }

        //METODOS _ NEGOCIO
        [System.Web.Services.WebMethod]
        public static GridView MostrarProductosVenta(GridView gvd)
        {
            DataTable dt = new DataTable();
            dt = ModeloDb.SeleccionProductosVenta();
            Engine.EngineUtil Funcion = new Engine.EngineUtil();
            dt = Funcion.AddColumnFechas(dt);
            HttpContext.Current.Session["DtProductoVenta"] = dt;
            gvd.DataSource = dt;
            gvd.DataBind();
            return gvd;
        }

        [System.Web.Services.WebMethod]
        public static GridView MostrarProductos (GridView gvd)
        {
            DataTable dt = new DataTable();
            dt = ModeloDb.SeleccionProductosAll();
            HttpContext.Current.Session["DtProducto"] = dt;
            gvd.DataSource = dt;
            gvd.DataBind();
            return gvd;
        }

        [System.Web.Services.WebMethod]
        public static string InsertatProducto( string producto, string descripcion, string moneda, string precio)
        {
            string resultado = string.Empty;
            if (producto == string.Empty || descripcion == string.Empty || moneda == string.Empty)
            {
                return resultado = "No puede existir valores vacios";
            }
            double price = 0;
            try
            {
                price = Convert.ToDouble(precio);
            }
            catch
            {
                return resultado = "El valor precio debe ser numerico";
            }
            int n = ModeloDb.InsertarProducto(producto, descripcion, moneda, price);
            if (n == -1)
            {
                resultado = Models.EngineData.agregarProductoExito;
            }
            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static string  ActualizarProducto (int id, string producto,string descripcion,string moneda , string precio)
        {
            string resultado = string.Empty;
            if ( producto == string.Empty || descripcion == string.Empty || moneda == string.Empty)
            {
                return resultado = "No puede existir valores vacios";
            }
            double price = 0;
            try
            {
                price = Convert.ToDouble(precio);
            }
            catch
            {
                return resultado = "El valor precio debe ser numerico";
            }
            int n = ModeloDb.ActualizarProducto(id, producto, descripcion, moneda, price);
            if (n == -1)
            {
                resultado = Models.EngineData.actualizacionProductoExito;
            }
            else
            {
                resultado = Models.EngineData.transaccionFallida2;
            }
            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static string EliminarProducto(int id)
        {
            string resultado = string.Empty;
            int n = ModeloDb.EliminarProducto(id);
            if (n == -1)
            {
                resultado = Models.EngineData.eliminacionProductoExito;
            }
            else
            {
                resultado = Models.EngineData.transaccionFallida2;
            }
            return resultado;
        }


    }
}
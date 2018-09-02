using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SudokuWeb.Models
{
    public class EngineData
    {
        private static EngineData valor;
        public static EngineData Instance()
        {
            if ((valor == null))
            {
                valor = new EngineData();
            }
            return valor;
        }

        public const string interrogacion = "?";
        public const string y = "&";
        public const string espacio = "%20";
        public const string mail = "mail=";
        public const string usuario = "usuario=";
        public const string estado = "estado=";
        public const string campo = "campo=";
        public const string administrador = "administrador=";
        public const string password = "password=";
        public const string dateFormatUtc = "yyyy-MM-ddTHH:mm:ss+hh:mm";

        public const string asuntoCreateAdmin = "Administrador de  Sudoku Para Todos esperando Activacion";
        public const string cuerpoCreateAdmin = "Siga el link o corte y pegue en su navegador para activar el nuevo administrador <br/><br/><br/>";
        public const string administradorCreadoExito = "Administrador creado satisfactoriamente,en poco tiempo activaremos su cuenta,notificaremos enviando un E-Mail";
        public const string administradorCreadoFallido = "El Administrador no pudo ser creado satisfactoriamente";
        public const string nombreAdminUpdateExito = "El Nombre de administrador fue actualizado satisfactoriamente";
        public const string nombreAdminUpdateFallido= "El Nombre de administrador fue actualizado satisfactoriamente";
        public const string passwordAdminUpdateExito = "La contraseña de administrador fue actualizada satisfactoriamente";
        public const string passwordAdminUpdateFallido = "La contraseña de administrador fue actualizada satisfactoriamente";
        public const string actualizacionProductoExito = "Actualizacion de producto exitosa";
        public const string agregarProductoExito = "El producto se agrego de forma exitosa";
        public const string myEmail= "sudokuparatodos@gmail.com";
        public const string asuntoAddUpdateproducto = "Agregar Actualizar Productos en Sudoku Para Todos ";
        public const string cuerpoAddUpdateproducto = "Agregar Actualizar Productos en Sudoku Para Todos ";
        public const string actualizacionExitosa = "Activacion Exitosa";

        public const string urlSite = "http://localhost:51828/ViewBusiness/Entry.aspx";
        //public const  string urlSite = "http://joselelu-001-site1.etempurl.com/ViewBusiness/Entry.aspx";

        public const string urlEstado = "http://localhost:51828/View/ActivarCuentaSudoku.aspx";
        //public const  string urlEstado = "http://joselelu-001-site1.etempurl.com/View/ActivarCuentaSudoku.aspx";

        public const string urlRestablecer = "http://localhost:51828/View/NuevoUserPassword.aspx";
        //public const  string urlRestablecer = "http://joselelu-001-site1.etempurl.com/View/NuevoUserPassword.aspx";

        public const string urlActivarAdministrador = "http://localhost:51828/ViewBusiness/api/ActivarAdministrador";
        //public const string urlActivarAdministrador = "http://joselelu-001-site1.etempurl.com/ViewBusiness/api/ActivarAdministrador";

        public static string CuentaRegistradaExitosamente = "Cuenta Registrada Exitosamente, Recibira un correo Electronico para Activar su Cuenta";
        public static string asuntoActivacion =  "Activacion de Cuenta Sudoku Para Todos";
        public static string cuerpoActivacion = "Bienvenido a Sudoku Para Todos , para activar su cuenta puede seguir el siguiente link o cortar y pegar en su navegador web <br/><br/><br/> ";  
        public static string loginExitoso = "Auntentificacion Exitosa";
        public static string activacionExitosa = "Cuenta Activada Exitosamente, ";
        public static string emailNoValido = "Ingrese una cuenta de correo electronico valida";
        public static string emailNoExiste = "El correo electronico ingresado no esta registrado";
        public static string restablecerData = "Revise su bandeja de correo electronico hemos enviado un link para restablecer sus datos";
        public static string asuntoRestablecer = "Restablecer Datos en Sudoku Para Todos";
        public static string cuerpoRestablecer = "Respuesta peticion restablecer datos en Sudoku Para Todos , para restablecer sus datos puede seguir el siguiente link o cortar y pegar en su navegador web <br/><br/><br/>";
        public static string tiempoActivarCuenta = "El Tiempo para Activar su Cuenta a Expirado, Volveremos a Enviar un Link a su cuenta de Correo";
        public static string emailDiferente = "La direccion de correo electronico debe ser la misma donde se envio el link";
        public static string nombreUsuarioConEspacios = "El campo nombre de usuario no puede contener espacios en blanco";
        public static string usuarioClienteActualizado = "Usuario actualizado satisfactoriamente";
        public static string contraseñasNoIguales = "Las contraseñas deben ser iguales";
        public static string passwordClienteActualizado = "Contraseña actualizada satisfactoriamente";
        public static string transaccionFallida = "Transaccion Fallida";
        public static string usuarioExiste = "El Nombre de usuario ya se encuentra registrado";
        public static string multipleConexionUsuario = "Se detecto multiples conexiones de su nombre de usuario, debe cerrar todas las conexiones y esperar un minimo de 20 minutos para volver a conectarse";
        public static string campoNombreNoVacio = "El Campo Nombre No Puede Estar Vacio";
        public static string campoCorreoElectronicoNoVacio = "El Campo Correo Electronico No Puede Estar Vacio";
        public static string campoNombreUsuarioNoVacio = "El Campo Nombre de Usuario No Puede Estar Vacio";
        public static string campoContraseñaNoVacio = "El Campo Contraseña No Puede Estar Vacio";
        public static string campoContraseñaConEspacios = "El Campo Contraseña No Puede Contener Espacios en Blanco";
        public static string campoConfirmarContraseñaNoVacio = "El Campo Confirmar Contraseña No Puede Estar Vacio";
        public static string campoConfirmarContraseñaConEspacios = "El Campo Confirmar Contraseña No Puede Contener Espacios en Blanco";
        public static string seleccionCasillaNoSoyRobot = "Seleccione la Casilla No Soy un Robot";
        public static string mailUsuarioRegistrado = "La Direccion de Correo Electronico y el Usuario ya se Encuentran Registrados";
        public static string mailRegistrado = "La Direccion de Correo Electronico ya se Encuentra Registrada";
        public static string cuentaNoRegistrada = "La Cuenta No Pudo ser Registrada Exitosamente, Intentelo mas Tarde";
        public static string cuentaNoActivada = "La Cuenta No Pudo ser Activada, Intentelo mas Tarde";
        public static string UsuarioPassworInactivoNoExiste = "El Usuario con el Password Ingresado no Existe o se Encuentra Inactivo"; 


    }
}
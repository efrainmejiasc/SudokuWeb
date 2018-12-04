using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SudokuWeb.Models
{
    public class EngineModel
    {
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["CnxSudoku"].ToString();
        private Engine.EngineUtil FuncionUtil = new Engine.EngineUtil();

//NEGOCIO _ CLIENTE 
        public int SeleccionMail (string MAIL)
        {
            object obj = new object();
            int resultado = 0;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionMail", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
                resultado = Convert.ToInt32(obj);
            }
            return resultado;
        }

        public int SeleccionUsuario(string USUARIO)
        {
            object obj = new object();
            int resultado = 0;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionUsuario", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
               resultado = Convert.ToInt32(obj);
            }
            return resultado;
        }


        public string  SeleccionUsuario(int id)
        {
            object obj = new object();
            string  resultado = string.Empty;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionUsuarioConId", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ID",id);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
                resultado = obj.ToString();
            }
            return resultado;
        }

        public int InsertarCliente(string MAIL,string NOMBRE, string USUARIO, string PASSWORD)
        {
            int  resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_InsertarCliente", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                command.Parameters.AddWithValue("@PASSWORD",FuncionUtil.ConvertirBase64(PASSWORD));
                command.Parameters.AddWithValue("@FECHA", DateTime.Now);
                command.Parameters.AddWithValue("@FECHAUTC", DateTime.UtcNow.ToString(Models.EngineData.dateFormatUtc));
                command.Parameters.AddWithValue("@ESTADO", "INACTIVO");
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarUsuarioCliente(string MAIL, string USUARIO, string PASSWORD)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarUsuarioCliente", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarPasswordCliente(string MAIL, string PASSWORD)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarPasswordCliente", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarHoraRegistroCliente(string MAIL)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarHoraRegistroCliente", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@FECHA", DateTime.Now);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActivarInactivarDesactivarCliente(string MAIL , string ESTADO)
        {
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            int resultado = new int();
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActivarInactivarDesactivarCliente", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@ESTADO", ESTADO);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int SeleccionHorasActivar(string MAIL,string ESTADO)
        {
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            object obj = new object();
            int  resultado = - 1;
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionHorasActivar", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@ESTADO", ESTADO);
                command.Parameters.AddWithValue("@FECHA", DateTime.Now);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }

            if (obj != null)
            {
                resultado = Convert.ToInt32(obj);
            }

            return resultado;
        }

        public int LogeoCliente(string USUARIO , string PASSWORD,string ESTADO)
        {
            object obj = new object();
            int id = 0;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_LogeoCliente", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                command.Parameters.AddWithValue("@ESTADO", ESTADO);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
                id = Convert.ToInt32(obj);
            }
            return id;
        }

        public int InsertarConexionUsuario(string USUARIO, string IDENTIFICADOR, string IP)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_InsertarConexionUsuario", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                command.Parameters.AddWithValue("@IDENTIFICADOR", IDENTIFICADOR);
                command.Parameters.AddWithValue("@FECHACONEXION", DateTime.Now);
                command.Parameters.AddWithValue("@FECHACONEXIONUTC", DateTime.UtcNow.ToString(Models.EngineData.dateFormatUtc));
                command.Parameters.AddWithValue("@IP", IP);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public ConexionUsuario SeleccionConexionUsuario(string USUARIO, string IDENTIFICADOR)
        {
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            ConexionUsuario CnxUsuario = new ConexionUsuario();
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionConexionUsuario", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                command.Parameters.AddWithValue("@IDENTIFICADOR", IDENTIFICADOR);
                command.Parameters.AddWithValue("@FECHACONEXION", DateTime.Now);
                SqlDataReader lector = lector = command.ExecuteReader();
                while ((lector.Read()))
                {
                    try
                    {
                        CnxUsuario = new ConexionUsuario
                        {
                            Id = Convert.ToInt64(lector[0]),
                            Usuario = lector[1].ToString(),
                            Identificador = lector[2].ToString(),
                            FechaConexion = Convert.ToDateTime(lector[3]),
                            FechaConexionUtc = lector[4].ToString(),
                            Ip = lector[5].ToString(),
                            TiempoTrascurrido = Convert.ToInt64(lector[6])
                        };
                    }
                    catch { } 
                }
                lector.Close();
                command.Connection.Close();
                Conexion.Close();
            }
            return  CnxUsuario;
        }

// NEGOCIO - ADMINISTRADOR 
        public int SeleccionIdAdministrador(string ADMINISTRADOR , string PASSWORD)
        {
            object obj = new object();
            int resultado = 0;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionIdAdministrador", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ADMINISTRADOR", ADMINISTRADOR);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
                resultado = Convert.ToInt32(obj);
            }
            return resultado;
        }

        public int SeleccionMailAdministrador(string MAIL)
        {
            object obj = new object();
            int resultado = 0;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionMailAdministrador", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
                resultado = Convert.ToInt32(obj);
            }
            return resultado;
        }

        public int InsertarAdministrador (string MAIL, string ADMINISTRADOR, string PASSWORD)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_InsertarAdministrador", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@ADMINISTRADOR", ADMINISTRADOR);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                command.Parameters.AddWithValue("@FECHA", DateTime.Now);
                command.Parameters.AddWithValue("@FECHAUTC", DateTime.UtcNow.ToString(Models.EngineData.dateFormatUtc));
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarEstadoAdministrador(string MAIL, string PASSWORD, string ESTADO)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarEstadoAdministrador", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@PASSWORD",PASSWORD);
                command.Parameters.AddWithValue("@ESTADO", ESTADO);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarNombreAdministrador(string MAIL,string ADMINISTRADOR, string PASSWORD, string ESTADO)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarEstadoAdministrador", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@ADMINISTRADOR", ADMINISTRADOR);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                command.Parameters.AddWithValue("@ESTADO", ESTADO);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarPasswordAdministrador(string MAIL, string PASSWORD, string ESTADO)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarPasswordAdministrador", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@PASSWORD", FuncionUtil.ConvertirBase64(PASSWORD));
                command.Parameters.AddWithValue("@ESTADO", ESTADO);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }
        // NEGOCIO - VENTAS
        public DataTable SeleccionProductosVenta()
        {
            DataTable dataTabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);

            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionProductosVenta", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdaptador = new SqlDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }

        public  DataTable SeleccionProductosAll ()
        {
            DataTable dataTabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);

            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionProductosAll", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdaptador = new SqlDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }
        public int InsertarProducto(string PRODUCTO, string DESCRIPCION, string MONEDA, double PRECIO)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_InsertarProducto", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@PRODUCTO", PRODUCTO);
                command.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
                command.Parameters.AddWithValue("@MONEDA", MONEDA);
                command.Parameters.AddWithValue("@PRECIO", PRECIO);
                command.Parameters.AddWithValue("@FECHA", DateTime.Now);
                command.Parameters.AddWithValue("@FECHAMODIFICACION", DateTime.Now);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int ActualizarProducto(int ID, string PRODUCTO, string DESCRIPCION, string MONEDA, double PRECIO)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_ActualizarProducto", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@PRODUCTO", PRODUCTO);
                command.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
                command.Parameters.AddWithValue("@MONEDA", MONEDA);
                command.Parameters.AddWithValue("@PRECIO", PRECIO);
                command.Parameters.AddWithValue("@FECHAMODIFICACION", DateTime.Now);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

        public int EliminarProducto(int ID)
        {
            int resultado = new int();
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_EliminarProducto", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ID", ID);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

    }
}
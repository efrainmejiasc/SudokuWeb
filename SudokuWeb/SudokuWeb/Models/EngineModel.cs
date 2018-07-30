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


        public string  SeleccionMail (string MAIL)
        {
            object obj = new object();
            string resultado = string.Empty;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionMail", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MAIL", MAIL);
                obj = command.ExecuteScalar();
                Conexion.Close();
            }
            if (obj != null)
            {
                resultado = obj.ToString();
            }
            return resultado;
        }

        public string SeleccionUsuario(string USUARIO)
        {
            object obj = new object();
            string resultado = string.Empty;
            SqlConnection Conexion = new SqlConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_SeleccionUsuario", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
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
                command.Parameters.AddWithValue("@MAIL", MAIL);
                command.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                command.Parameters.AddWithValue("@USUARIO", USUARIO);
                command.Parameters.AddWithValue("@PASSWORD",FuncionUtil.ConvertirBase64(PASSWORD));
                command.Parameters.AddWithValue("@FECHA", DateTime.Now);
                command.Parameters.AddWithValue("@ESTADO", "INACTIVO");
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }

            return resultado;
        }

    }
}
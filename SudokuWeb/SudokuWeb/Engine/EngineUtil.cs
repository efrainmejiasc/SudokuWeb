﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        [System.Web.Services.WebMethod]
        public static string  CrearPerfilCliente(string MAIL, string NOMBRE, string USUARIO, string PASSWORD)
        {
            string resultado = string.Empty;
            string existeMail = ModeloDb.SeleccionMail(MAIL);
            string existeUsuario = ModeloDb.SeleccionUsuario(USUARIO);
            if (existeMail != string.Empty && existeUsuario != string.Empty)
            {
                 resultado = "La Direccion de Correo Electronico y el Usuario ya se Encuentran Registrados"; //001
            }
            else if (existeMail != string.Empty && existeUsuario == string.Empty)
            {
                 resultado = "La Direccion de Correo Electronico ya se Encuentra Registrada";//002
            }
            else if (existeMail == string.Empty && existeUsuario != string.Empty)
            {
                resultado = "El Nombre de Usuario ya se Encuentra Registrado";//003
            }
            else if (existeMail == string.Empty && existeUsuario == string.Empty)
            {
                int r = ModeloDb.InsertarCliente(MAIL, NOMBRE, USUARIO, PASSWORD);
                if (r == -1)
                {
                    EngineUtil Funcion = new EngineUtil();
                    bool k = FuncionMail.EnviarMail(Models.EngineData.asuntoActivacion, Models.EngineData.cuerpoActivacion + ConstruirUrlEstadoCliiente(MAIL,USUARIO,"ACTIVO") , MAIL);
                    resultado = "Cuenta Registrada Exitosamente, Recibira un correo Electronico para Activar el Estado de Su Cuenta";//200
                }
                else
                {
                    resultado = "La Cuenta No Pudo ser Registrada Exitosamente, Intentelo mas Tarde";//004
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

      

    }
}
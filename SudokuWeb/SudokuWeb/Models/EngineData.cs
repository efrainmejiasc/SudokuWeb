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

        public static string interrogacion = "?";
        public static string y = "&";
        public static string espacio = "%20";
        public static string mail = "mail=";
        public static string usuario = "usuario=";
        public static string estado = "estado=";
        public static string urlEstado = "http://localhost:51828/View/ActivarCuentaSudoku.aspx";

        public static string asuntoActivacion =  "Activacion de Cuenta Sudoku Para Todos";
        public static string cuerpoActivacion = "Bienvenido a Sudoku Para Todos , para activar su cuenta puede seguir el siguiente link </br></br>";  


    }
}
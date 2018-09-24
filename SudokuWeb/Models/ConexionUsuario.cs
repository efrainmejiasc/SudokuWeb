using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SudokuWeb.Models
{
    public class ConexionUsuario
    {
        public long Id = 0;

        public string Usuario { get; set; }

        public string Identificador { get; set; }

        public DateTime FechaConexion { get; set; }

        public string FechaConexionUtc { get; set; }

        public string Ip { get; set; }

        public long  TiempoTrascurrido { get; set; }
    }
}
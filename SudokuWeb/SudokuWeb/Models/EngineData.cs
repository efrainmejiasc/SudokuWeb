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

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SudokuWeb.Engine
{
    public class Globalizacion
    {
        public void UICultureClobalizacion(System.Web.UI.Page page, string lenguaje)
        {
            String selectedLanguage = lenguaje;
            page.UICulture = selectedLanguage;
            page.Culture = selectedLanguage;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture(selectedLanguage);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(selectedLanguage);
        }
    }
}
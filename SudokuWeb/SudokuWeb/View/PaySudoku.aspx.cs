using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class PaySudoku : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        protected override void InitializeCulture()
        {
            if (Request.Cookies["Cult"] != null)
            {
                Engine.Globalizacion globalizacion = new Engine.Globalizacion();
                globalizacion.UICultureClobalizacion(this, Request.Cookies["Cult"].Value);
            }
            base.InitializeCulture();
        }
    }
}
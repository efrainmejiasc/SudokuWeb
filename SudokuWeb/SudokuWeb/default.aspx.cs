using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnLogin"):
                    Response.Redirect("View/Login.aspx");
                    break;
                case ("btnRegistro"):
                    Response.Redirect("View/RegistrarCuenta.aspx");
                    break;
            }
        }

    }
}
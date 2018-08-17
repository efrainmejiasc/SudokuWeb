using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class Contrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnContrato_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            switch (btn.ID)
            {
                case ("btnAceptar"):
                    if (chkRobot.Checked)
                    {
                        Response.Redirect("View/Login.aspx");
                    } 
                    break;
                case ("btnCancelar"):
                    Response.Redirect("View/Contrato.aspx");
                    break;
            }
        }
    }
}
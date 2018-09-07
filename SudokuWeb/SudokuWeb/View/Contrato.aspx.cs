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
            if (!IsPostBack)
            {
                chkRobot.Checked = false;
            }
        }

        protected void BtnContrato_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnAceptar"):
                    if (chkRobot.Checked)
                    {
                        Response.Redirect("RegistrarCuenta.aspx");
                    }
                    else
                    {
                        string scripting = "PareceRobot();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot();", scripting, true);
                    }
                    break;
                case ("btnCancelar"):
                    Response.Redirect("~/default.aspx");
                    break;
            }
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
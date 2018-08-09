using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class Login : System.Web.UI.Page
    {
        Models.EngineModel g = new Models.EngineModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarTexto();
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelar"):
                    Response.Redirect("~/default.aspx");
                    break;
                case ("btnAceptar"):
                    string usuario = txtUsuario.Text;
                    string password = txtPassword.Text;
                    bool noRobot = chkRobot.Checked;
                    lblMensaje.Text = Engine.EngineUtil.Login(usuario, password, noRobot);
                    string script = "MostrarVentana('msj');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    break;
            }
        }

        protected void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            string script = "OcultarVentana('msj');";
            if (lblMensaje.Text == Models.EngineData.loginExitoso)
            {
                LimpiarTexto();
            }
            else
            {
                lblMensaje.Text = string.Empty;
            }
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
        }

        private void LimpiarTexto()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lblMensaje.Text = string.Empty;
            chkRobot.Checked = false;
        }

    }
}
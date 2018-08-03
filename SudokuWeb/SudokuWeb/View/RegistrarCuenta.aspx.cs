using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { LimpiarTexto(); }
        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelar"):
                    Response.Redirect("~/default.aspx");
                    break;
                case ("btnAceptar"):
                    string nombre = txtNombreCompleto.Text;
                    string mail = txtMail.Text;
                    string usuario = txtUsuario.Text;
                    string password = txtPassword.Text;
                    string password2 = txtPassword2.Text;
                    bool noRobot = chkRobot.Checked;
                    lblMensaje.Text  = Engine.EngineUtil.CrearPerfilCliente(mail, nombre, usuario, password, password2,noRobot);
                    string script = "MostrarVentana('msj');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    break;
            }
        }

        protected void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            string script = "OcultarVentana('msj');";
            if (lblMensaje.Text == Models.EngineData.CuentaRegistradaExitosamente)
            {
                LimpiarTexto();
            } else
            {
                lblMensaje.Text = string.Empty;
            }
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
        }

        private void LimpiarTexto()
        {
            txtNombreCompleto.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPassword2.Text = string.Empty;
            lblMensaje.Text = string.Empty;
            chkRobot.Checked = false;
        }
    }
}
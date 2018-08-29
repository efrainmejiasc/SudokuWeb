using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SudokuWeb.View
{
    public partial class NuevoUserPassword : System.Web.UI.Page
    {
        Engine.EngineUtil Funcion = new Engine.EngineUtil();
        Models.EngineModel ModeloDb = new Models.EngineModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Keys.Count > 0)
            {
                Engine.EngineUtil Funcion = new Engine.EngineUtil();
                Session["Mail"] = Funcion.DecodeBase64(Request.QueryString["mail"]);
                Session["CampoRestablecer"] = Request.QueryString["campo"];
                if (Session["CampoRestablecer"].ToString () == "Username")
                {
                    Pnl1.Visible = true;
                    Pnl2.Visible = false;

                }
                else if (Session["CampoRestablecer"].ToString() == "Password")
                {
                    Pnl2.Visible = true;
                    Pnl1.Visible = false;
                }
            }
            if (!IsPostBack)
            {
                chkRobotUser.Checked = false;
                chkRobotPass.Checked = false;
            }
        }

        protected void BtnUsername_Click(object sender, EventArgs e)
        {
            string mail = MailUser();
            string script = "MostrarVentana('msj');";
            if (chkRobotUser.Checked)
            {
                if (txtPasswordUser.Text == string.Empty)
                {
                    lblMensaje.Text = Models.EngineData.campoContraseñaNoVacio;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                if (txtUsuario.Text == string.Empty)
                {
                    lblMensaje.Text = Models.EngineData.campoNombreUsuarioNoVacio;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                if (txtUsuario.Text.Contains(" "))
                {
                    lblMensaje.Text = Models.EngineData.nombreUsuarioConEspacios;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                int existeUsuario = ModeloDb.SeleccionUsuario(txtUsuario.Text);
                if (existeUsuario > 0)
                {
                    lblMensaje.Text = Models.EngineData.usuarioExiste;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }

                lblMensaje.Text = Engine.EngineUtil.ActualizarUsuarioCliente(mail, txtUsuario.Text, txtPasswordUser.Text);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
            }
            else
            {
                string scripting = "PareceRobot();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot();", scripting, true);
            }      
        }

        protected void BtnPassword_Click(object sender, EventArgs e)
        {
            string mail = MailUser();
            string script = "MostrarVentana('msj');";
            if (chkRobotPass.Checked)
            {
                if (txtPassword.Text == string.Empty || txtPassword2.Text  == string.Empty)
                {
                    lblMensaje.Text = Models.EngineData.campoContraseñaNoVacio;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                if (txtPassword.Text.Contains(" ") || txtPassword2.Text.Contains(" "))
                {
                    lblMensaje.Text = Models.EngineData.campoContraseñaConEspacios;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                if (!Funcion.CompareString(txtPassword.Text, txtPassword2.Text))
                {
                    lblMensaje.Text = Models.EngineData.contraseñasNoIguales;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                if (mail != string.Empty)
                {
                    lblMensaje.Text = Engine.EngineUtil.ActualizarPasswordCliente(mail, txtPassword.Text);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                }
            }
            else
            {
                string scripting = "PareceRobot();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot();", scripting, true);
            }
        }

        private string MailUser()
        {
            string mail = string.Empty;
            try
            {
             mail = Session["Mail"].ToString();
            }
            catch
            { }
            return mail;
        }

        protected void btnAceptarMensaje_Click(object sender, EventArgs e)
        {
            if (lblMensaje.Text == Models.EngineData.usuarioClienteActualizado | lblMensaje.Text == Models.EngineData.passwordClienteActualizado)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string script = "OcultarVentana('msj');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
            }
        }
    }
}
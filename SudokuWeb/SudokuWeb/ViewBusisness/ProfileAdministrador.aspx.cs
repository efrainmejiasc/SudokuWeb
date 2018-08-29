using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.ViewBusiness
{
    public partial class ProfileAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                chkRobot1.Checked = false;
                chkRobot2.Checked = false;
                chkRobot3.Checked = false;
                if (Request.QueryString.Keys.Count > 0)
                {
                    string nav = Request.QueryString["div"];
                    if (nav == "OlvidoUsuario")
                    {
                        string script1 = "NavegacionDiv('#OlvidoUsuario');";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "NavegacionDiv('#OlvidoUsuario')", script1, true);
                    }
                    else if (nav == "OlvidoPassword")
                    {
                        string script2 = "NavegacionDiv(#OlvidoPassword');";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "NavegacionDiv('#OlvidoPassword')", script2, true);
                    } 
                }
            }
        }


        protected void BtnCreateAdmin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelar"):
                    Response.Redirect("Entry.aspx");
                    break;
                case ("btnAceptar"):
                    if (chkRobot1.Checked)
                    {
                        string resultado = string.Empty;
                        string mail = txtMail.Text;
                        string administrador = txtAdministrador.Text;
                        string password1 = txtPassword.Text;
                        string password2 = txtPassword2.Text;
                        resultado = Engine.EngineUtil.CreateAdministrador(mail, administrador, password1, password2);
                        lblMensaje.Text = resultado;
                        string script = "MostrarVentana('msj');";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    }
                    else
                    {
                        string script = "PareceRobot();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot()", script, true);
                    }

                    break;
            }
        }

        protected void BtnRestablecerAdmin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelarUser"):
                    Response.Redirect("Entry.aspx");
                    break;
                case ("btnAceptarUser"):
                    if (chkRobot2.Checked)
                    {
                        string resultado = string.Empty;
                        string administrador = txtNombreAdmin.Text;
                        string mail = txtMailAdmin.Text;
                        string password = txtPasswordAdmin.Text;
                        resultado = Engine.EngineUtil.ActualizarNombreAdministrador(mail,administrador,password);
                        lblMensaje.Text = resultado;
                        string script = "MostrarVentana('msj');";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    }
                    else
                    {
                        string script = "PareceRobot();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot()", script, true);
                    }

                    break;
            }
        }

        protected void BtnRestablecerPassword_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            { 
                case ("btnCancelarPass"):
                    Response.Redirect("Entry.aspx");
                    break;
                case ("btnAceptarPass"):
                    if (chkRobot3.Checked)
                    {
                        string resultado = string.Empty;
                        string mail = txtEmail.Text;
                        string password1 = txtPassword3.Text;
                        string password2 = txtPassword4.Text;
                        resultado = Engine.EngineUtil.ActualizarPasswordAdministrador(mail, password1, password2);
                        lblMensaje.Text = resultado;
                        string script = "MostrarVentana('msj');";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    }
                    else
                    {
                        string script = "PareceRobot();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot()", script, true);
                    }

                    break;
            }
        }

        protected void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            string script = "OcultarVentana('msj');";
            if (lblMensaje.Text == Models.EngineData.administradorCreadoExito || lblMensaje.Text == Models.EngineData.nombreAdminUpdateExito || lblMensaje.Text == Models.EngineData.nombreAdminUpdateExito)
            {
                Response.Redirect("Entry.aspx");
            }
            else
            {
                lblMensaje.Text = string.Empty;
            }
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
        }
    }
}
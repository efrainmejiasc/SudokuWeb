using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SudokuWeb.Engine;

namespace SudokuWeb.ViewBusiness
{
    public partial class Entry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                chkRobotUser.Checked = false;
            }
        }

        protected void BtnAutentificacionAdmin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelar"):
                    string script = "window.close();";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "closewindows", script, true);
                    break;
                case ("btnAceptar"):
                   if (chkRobotUser.Checked)
                    {
                        string administrador = txtAdmin.Text;
                        string password = txtContraseña.Text;
                        string resultado = Engine.EngineUtil.AutentificacionAdministrador(administrador, password);
                        if (resultado == "Autentificacion Exitosa")
                        {
                            Response.Redirect("Manager.aspx");
                        }
                        else
                        {
                            lblMensaje.Text = resultado;
                            string script2 = "MostrarVentana('msj');";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script2, true);
                        }
                    }
                    else
                    {
                        string script3 = "PareceRobot();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot()", script3, true);
                    }
                    break;
            }
        }

        protected void LnkNavAdministracion_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            switch (btn.ID)
            {
                case ("lnkNuevoAdmin"):
                    string script1 = "OpenProfileAdministrador1();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "OpenProfileAdministrador1()", script1, true);
                    break;
                case ("lnkNombreAdmin"):
                    string script2 = "OpenProfileAdministrador2();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "OpenProfileAdministrador2()", script2, true);
                    break;
                case ("lnkCotrasenaAdmin"):
                    string script3 = "OpenProfileAdministrador3();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "OpenProfileAdministrador3()", script3, true);
                    break;
            }
        }


        protected void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            string script = "OcultarVentana('msj');";
            lblMensaje.Text = string.Empty;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
        }
    }
}
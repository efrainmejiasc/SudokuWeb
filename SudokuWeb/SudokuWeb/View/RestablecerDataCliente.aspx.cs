using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class RestablecerDataCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
                chkRobot.Checked = false;
           }
        }

        protected void BtnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        protected void BtnRestablecerData_Click(object sender, EventArgs e)
        {
            if (chkRobot.Checked == true)
            {
                string script = "MostrarVentana('msj');";
                string mail = txtMail.Text;
                if (mail == string.Empty)
                {
                    lblMensaje.Text = Models.EngineData.campoCorreoElectronicoNoVacio;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    return;
                }
                if (mail != string.Empty)
                {
                    Engine.EngineUtil Funcion = new Engine.EngineUtil();
                    bool r = Funcion.EmailEsValido(mail);
                    if (!r)
                    {
                        lblMensaje.Text = Models.EngineData.emailNoValido;
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                        return;
                    }
                }
                Models.EngineModel FuncionDb = new Models.EngineModel();
                Button btn = sender as Button;
                int n = 0;
                switch (btn.ID)
                {

                    case ("btnUsuario"):
                        n = FuncionDb.SeleccionMail(mail);
                        if (n == 0)
                        {
                            lblMensaje.Text = Models.EngineData.emailNoExiste;
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                        }
                        else
                        {
                            lblMensaje.Text = Models.EngineData.restablecerData;
                            Engine.EngineUtil.RestablecerData(mail, "Username");
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                        }

                        break;
                    case ("btnContraseña"):
                        n = FuncionDb.SeleccionMail(mail);
                        if (n == 0)
                        {
                            lblMensaje.Text = Models.EngineData.emailNoExiste;
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                        }
                        else
                        {
                            lblMensaje.Text = Models.EngineData.restablecerData;
                            Engine.EngineUtil.RestablecerData(mail, "Password");
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                        }
                        break;
                }

            }
            else
            {
                string scripting = "PareceRobot();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot();", scripting, true);
            }

        }

        protected void btnAceptarMensaje_Click(object sender, EventArgs e)
        {
            string script = "OcultarVentana('msj');";
            if (lblMensaje.Text == Models.EngineData.restablecerData || lblMensaje.Text == Models.EngineData.emailNoExiste)
            {
                Response.Redirect("~/default.aspx");
            }
            else
            {
                lblMensaje.Text = string.Empty;
                txtMail.Text = string.Empty;
            }
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class ActSudoku : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Keys.Count > 0)
            {
                Engine.EngineUtil Funcion = new Engine.EngineUtil();
                Session["Mail"] = Funcion.DecodeBase64(Request.QueryString["mail"]);
                Session["Usuario"] = Request.QueryString["usuario"];
                Session["Estado"] = Request.QueryString["estado"];
            }
        }

        protected void BtnActivarCuenta_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelar"):
                    Response.Redirect("~/default.aspx");
                    break;
                case ("btnAceptar"):
                    string script = "MostrarVentana('msj');";
                    if (Session["Estado"].ToString() == "INACTIVO" || Session["Estado"].ToString() == "DESACTIVADO")
                    {
                        bool k = Engine.EngineUtil.SeleccionHorasActivar(Session["Mail"].ToString(), Session["Estado"].ToString());
                        if (!k)
                        {
                            string r = Engine.EngineUtil.NuevoEmailCliente(Session["Mail"].ToString(), Session["Usuario"].ToString(),Session["Estado"].ToString());

                            lblMensaje.Text = "El Tiempo para Activar su Cuenta a Expirado, Volveremos a Enviar un Link a su cuenta de Correo";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                            return;
                        }
                    }
                    else
                    {
                        lblMensaje.Text = Engine.EngineUtil.ActivarInactivarDesactivarCliente(Session["Mail"].ToString(), Session["Estado"].ToString());
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class InitGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
                bool r = ObtenerCookie();
                r = AccesoUsuario(r);
                if (r)
                {
                    EscribirCookie();
                }
                else
                {
                    lblMensaje.Text = Models.EngineData.multipleConexionUsuario;
                    string script = "MostrarVentana('msj');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                }
            }
        }

        private bool ObtenerCookie()
        {
            bool existeCookie = false;
            Session["Cookie"] = false;
            if (Request.Cookies["Cookies"] != null)
            {
                Session["Cookie"] = Request.Cookies["Cookie"].Value;
                Session["Cookie"] = true;
                existeCookie = true;
            }
            return existeCookie;
        }

        private bool AccesoUsuario(bool existeCookie)
        {
            bool resultado = false;
            resultado = Engine.EngineUtil.ImpedirConexionesSimultaneas(Session["USUARIO"].ToString(), Session["Identificador"].ToString(), (bool)Session["Cookie"]);
            return resultado;
        }

        private void EscribirCookie()
        {
            HttpCookie cook = new HttpCookie("Cookie");
            cook.Value = Session["Identificador"].ToString();
            cook.Expires = DateTime.Now.AddMinutes(21);
            Response.Cookies.Add(cook);
        }

        protected void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            if (lblMensaje.Text == Models.EngineData.multipleConexionUsuario)
            {
                string script = "CerrarVentana();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "CerrarVentana()", script, true);
            }
            else
            {
                string script = "OcultarVentana('msj');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
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
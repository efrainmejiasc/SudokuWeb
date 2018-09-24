using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.RequestType.Equals("POST")|| Request.RequestType.Equals("GET"))
            {
                Engine.EngineUtil Funcion = new Engine.EngineUtil();
                string k = Funcion.GetIpAddress(Request);
            }
            if (Session["UserName"] != null)
            {
                lblUserName.Text = Session["UserName"].ToString();
                btnCerrarSesion.Visible = true;
            }
            else
            {
                lblUserName.Text = string.Empty;
                lblUserName.Visible = false;
                btnCerrarSesion.Visible = false;
            }
          

        }

        protected void BtnInit_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            switch (btn.ID)
            {
                case ("btnLogin"):
                    Response.Redirect("View/Login.aspx");
                    break;
                case ("btnRegistro"):
                    Response.Redirect("View/Contrato.aspx");
                    break;
                case ("btnOlvido"):
                    Response.Redirect("View/RestablecerDataCliente.aspx");
                    break;
                case ("btncerrarSesion"):
                    lblUserName.Text = string.Empty;
                    lblUserName.Visible = false;
                    btnCerrarSesion.Visible = false;
                    break;
            }
        }
        protected override void InitializeCulture()
        {
            if (Request.Form["ddlMultilenguaje"] != null)
            {
                Engine.Globalizacion globalizacion = new Engine.Globalizacion();
                HttpCookie cookie = new HttpCookie("Cult");
                cookie.Value = Request.Form["ddlMultilenguaje"];
                Response.Cookies.Add(cookie);
                globalizacion.UICultureClobalizacion(this, Request.Form["ddlMultilenguaje"]);
            }
            base.InitializeCulture();
        }

    }
}
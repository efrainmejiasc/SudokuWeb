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
                        string password = txtPassword.Text;
                        string password2 = txtPassword2.Text;
                        if (resultado == "")
                        {

                        }
                        else
                        {
                            lblMensaje.Text = resultado;
                            string script = "MostrarVentana('msj');";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                        }
                    }
                    else
                    {
                        string script = "PareceRobot();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "PareceRobot()", script, true);
                    }

                    break;
            }
        }


    }
}
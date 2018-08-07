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
                    Response.Redirect("View/RegistrarCuenta.aspx");
                    break;
                case ("btncerrarSesion"):
                    lblUserName.Text = string.Empty;
                    lblUserName.Visible = false;
                    btnCerrarSesion.Visible = false;
                    break;
            }
        }

     
    }
}
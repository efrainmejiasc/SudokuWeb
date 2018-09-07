using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.View
{
    public partial class BuyingSudoku : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["DtProductoVenta"] == null)
            {
                GridView1 = Engine.EngineUtil.MostrarProductosVenta(GridView1);
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                string id = row.Cells[0].Text;
                string producto = row.Cells[1].Text;
                string descripcion = row.Cells[2].Text; ;
                string moneda = row.Cells[3].Text; 
                string precio = row.Cells[4].Text;
                string fechaCompra = row.Cells[5].Text;
                string fechaExpiracion = row.Cells[6].Text;
                lblMensaje.Text = "Producto : " + producto + "<br/>" + "Descripcion : " + descripcion + "<br/>" + "Precio : " + moneda + precio + "<br/>" + "Periodo : " + fechaCompra + " - " + fechaExpiracion;
                string script = "MostrarVentana('msj');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            GridView1.SelectedIndex = -1;
            string script = "OcultarVentana('msj');";
            lblMensaje.Text = string.Empty;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
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
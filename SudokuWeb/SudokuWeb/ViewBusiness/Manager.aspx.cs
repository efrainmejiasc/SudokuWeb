using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.ViewBusiness
{
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtMoneda.Text = "$";
            if (!IsPostBack && Session ["DtProducto"] != null)
            {
                GridView1 = Engine.EngineUtil.MostrarProductos(GridView1);
            }
        }


        protected void BtnAgregarProductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnCancelar"):
                    Response.Redirect("Entry.aspx");
                    break;
                case ("btnAceptar"):
                    string producto = txtProducto.Text.ToUpper();
                    string descripcion = txtDescripcion.Text.ToUpper();
                    string moneda = txtMoneda.Text;
                    string precio = txtPrecio.Text;
                    string resultado = Engine.EngineUtil.InsertatProducto(producto, descripcion, moneda, precio);
                    lblMensaje.Text = resultado;
                    GridView1 = Engine.EngineUtil.MostrarProductos(GridView1);
                    Engine.MailNotificacion EnviarMail = new Engine.MailNotificacion();
                    bool r = EnviarMail.EnviarMail(Models.EngineData.asuntoAddUpdateproducto, Models.EngineData.cuerpoAddUpdateproducto, Models.EngineData.myEmail);
                    string script = "MostrarVentana('msj');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
                    break;
            }
        }

        protected void BtnProductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.ID)
            {
                case ("btnSalir"):
                    Response.Redirect("Entry.aspx");
                    break;
                case ("btnMostrarProducto"):
                    GridView1 = Engine.EngineUtil.MostrarProductos(GridView1);
                    break;
            }
        }
        protected void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            string script = "OcultarVentana('msj');";
            lblMensaje.Text = string.Empty;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "OcultarVentana('msj')", script, true);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //ROW EVENTOS
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value);
            GridView1 = Engine.EngineUtil.MostrarProductos(GridView1);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            GridViewRow row = GridView1.Rows[e.RowIndex];
            string producto = ((TextBox)(row.Cells[2].Controls[0])).Text.ToUpper();
            string descripcion = ((TextBox)(row.Cells[3].Controls[0])).Text.ToUpper();
            string moneda = ((TextBox)(row.Cells[4].Controls[0])).Text.ToUpper();
            string precio = ((TextBox)(row.Cells[5].Controls[0])).Text;
            string resultado = Engine.EngineUtil.ActualizarProducto( id, producto, descripcion, moneda, precio);
            GridView1.EditIndex = -1;
            GridView1 = Engine.EngineUtil.MostrarProductos(GridView1);
            lblMensaje.Text  = resultado;
            Engine.MailNotificacion EnviarMail = new Engine.MailNotificacion();
            bool r = EnviarMail.EnviarMail(Models.EngineData.asuntoAddUpdateproducto, Models.EngineData.cuerpoAddUpdateproducto, Models.EngineData.myEmail);
            string script = "MostrarVentana('msj');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "MostrarVentana('msj')", script, true);
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1 = Engine.EngineUtil.MostrarProductos(GridView1);
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }

        
    }
}
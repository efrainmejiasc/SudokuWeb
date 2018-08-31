<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="SudokuWeb.ViewBusiness.Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <script src="../js/main.js"></script>
    
      <script language="javaScript" type="text/javaScript">
          function MostrarVentana()
          {
              var ventana = document.getElementById('msj');
              ventana.style.display = 'block';
          }

          function OcultarVentana()
          {
              var ventana = document.getElementById('msj');
              ventana.style.display = 'none';
          }
  
      </script> 
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <div>
                   <asp:Label ID="Label2" runat="server" Text="Agregar Producto"></asp:Label>
                   <asp:Label ID="Label3" runat="server" Text="Producto"></asp:Label>
                   <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
                   <asp:Label ID="Label4" runat="server" Text="Descripcion"></asp:Label>
                   <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                   <asp:Label ID="Label5" runat="server" Text="Moneda"></asp:Label>
                   <asp:TextBox ID="txtMoneda" runat="server"></asp:TextBox>
                   <asp:Label ID="Label6" runat="server" Text="Precio"></asp:Label>
                   <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

                   <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                   <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
             </div>

          
          <div>
            <asp:Label ID="Label1" runat="server" Text="Actualizacion de Productos y Precios"></asp:Label>
           <asp:GridView ID="GridView1" runat="server"  
            DataKeyNames="ID" 
            AutoGenerateEditButton="True" 
            AutoGenerateColumns="False" 
            OnRowEditing="GridView1_RowEditing" 
            OnRowUpdating="GridView1_RowUpdating"
            OnRowDataBound="GridView1_RowDataBound" 
            OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="3" CellSpacing="3"
            CssClass=" table-striped table-hover table-condensed small-top-margin" >

            <HeaderStyle BackColor="DimGray" Font-Bold="True" ForeColor="White"  Wrap="False" BorderColor="DimGray" BorderStyle="Solid" BorderWidth="3px" Font-Size="15pt"  HorizontalAlign="Center" />
            <EditRowStyle BackColor="DimGray" ForeColor="White" Wrap="False" Font-Size="15pt" Font-Bold="True" HorizontalAlign="Center"/>
            <AlternatingRowStyle BackColor="White" ForeColor="DimGray" Wrap="False" Font-Size="12pt" HorizontalAlign="Center" />
            <RowStyle BackColor="White"   Wrap="False"  ForeColor="DimGray" Font-Size="12pt" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="Dimgray" Wrap="False" ForeColor="White" Font-Size="15pt"  HorizontalAlign="Center"/>
            <Columns>  
               <asp:BoundField DataField="ID" HeaderText="ID"  ReadOnly="true" />
               <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="false"/>
               <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="false"/>
               <asp:BoundField DataField="Moneda" HeaderText="Moneda" ReadOnly="false"/>
               <asp:BoundField DataField="Precio" HeaderText="Precio" ReadOnly="false" />
               <asp:BoundField DataField="Fecha" HeaderText="Fecha Creacion" ReadOnly="true" />
               <asp:BoundField DataField="FechaModificacion" HeaderText="Fecha Actualizacion" ReadOnly="true" />
            </Columns>
            </asp:GridView>

              <asp:Button ID="btnMostrarProducto" runat="server" Text="Mostrar Productos" OnClick="BtnProductos_Click" />
              <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="BtnProductos_Click" />
         </div>

            <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" /> 
            </div>

        </div>
    </form>
</body>
</html>

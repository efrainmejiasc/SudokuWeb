<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyingSudoku.aspx.cs" Inherits="SudokuWeb.View.BuyingSudoku" %>

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
           <asp:Label ID="Label1" runat="server" Text="Planes y Servicios Sudoku Para Todos"></asp:Label>
           <div>
           <asp:GridView ID="GridView1" runat="server"  
            DataKeyNames="ID" 
            AutoGenerateColumns="False" 
            onrowcommand="GridView1_RowCommand"
            CssClass=" table-striped table-hover table-condensed small-top-margin" >

            <HeaderStyle BackColor="DimGray" Font-Bold="True" ForeColor="White"  Wrap="False" BorderColor="DimGray" BorderStyle="Solid" BorderWidth="3px" Font-Size="15pt"  HorizontalAlign="Center" />
            <EditRowStyle BackColor="DimGray" ForeColor="White" Wrap="False" Font-Size="15pt" Font-Bold="True" HorizontalAlign="Center"/>
            <AlternatingRowStyle BackColor="White" ForeColor="DimGray" Wrap="False" Font-Size="12pt" HorizontalAlign="Center" />
            <RowStyle BackColor="White"   Wrap="False"  ForeColor="DimGray" Font-Size="12pt" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="Blue" Wrap="False" ForeColor="White" Font-Size="15pt"  HorizontalAlign="Center"/>
            <Columns>  
               <asp:BoundField DataField="ID" HeaderText="ID"  ReadOnly="true" />
               <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="false"/>
               <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="false"/>
               <asp:BoundField DataField="Moneda" HeaderText="Moneda" ReadOnly="false"/>
               <asp:BoundField DataField="Precio" HeaderText="Precio" ReadOnly="false" />
               <asp:BoundField DataField="FechaCompra" HeaderText="Fecha de Compra" ReadOnly="true" />
               <asp:BoundField DataField="FechaExpiracion" HeaderText="Fecha de Expiracion" ReadOnly="true" />
               <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Comprar Ahora" />
            </Columns>
            </asp:GridView>   
           </div>

         <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" /> 
        </div>
    
     </div>
    </form>
</body>
</html>

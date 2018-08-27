<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InitGame.aspx.cs" Inherits="SudokuWeb.View.InitGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
     <script src="../js/main.js"></script>
     <script type="text/javaScript">
          function MostrarVentana(idDiv)
          {
              var ventana = document.getElementById(idDiv);
              ventana.style.display = 'block';
          }

          function OcultarVentana(idDiv)
          {
              var ventana = document.getElementById(idDiv);
              ventana.style.display = 'none';
          }

          function MiAlerta(msj)
          {
              alert(msj);
          }
      </script> 
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" />
        </div>
        </div>
    </form>
    
</body>
</html>

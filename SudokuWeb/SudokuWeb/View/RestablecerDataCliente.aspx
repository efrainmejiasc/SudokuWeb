<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestablecerDataCliente.aspx.cs" Inherits="SudokuWeb.View.RestablecerDataCliente" %>

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
              <asp:Image ID="Image" class="logo" runat="server" ImageUrl="/public/images/logo.png" Height="143px" Width="180px" />
              <asp:Button ID="BtnInicio" runat="server" Text="Inicio" OnClick="BtnInicio_Click"  />

              <asp:Label ID="Label1" runat="server" Text="Ingrese su Correo Electronico"></asp:Label>
              <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
              <asp:CheckBox ID="chkRobot" runat="server" Text="No Soy un Robot" />

              <asp:Label ID="Label2" runat="server" Text="Olvido su usuario"></asp:Label>
              <asp:Button ID="btnUsuario" runat="server" Text="Restablecer Usuario" OnClick="BtnRestablecerData_Click"  />

              <asp:Label ID="Label3" runat="server" Text="Olvido su Contraseña"></asp:Label>
             <asp:Button ID="btnContraseña" runat="server" Text="Restablecer Contraseña" OnClick="BtnRestablecerData_Click"   />
        </div>

        <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="btnAceptarMensaje_Click" />
        </div>

    </form>
</body>
</html>

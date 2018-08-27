<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoUserPassword.aspx.cs" Inherits="SudokuWeb.View.NuevoUserPassword" %>

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
             <div>
                  <asp:Image ID="Image2" class="logo" runat="server" ImageUrl="/public/images/logo.png" Height="151px" Width="145px" />
                   <asp:Label ID="Label8" runat="server" Text="SUDOKU PARA TODOS"></asp:Label>
             </div>

             <div>
                 <asp:Panel ID="Pnl1" runat="server">
                      <asp:Label ID="Label1" runat="server" Text="Restablecer Nombre de Usuario"></asp:Label>
                      <asp:Label ID="Label2" runat="server" Text="Nuevo Nombre de Usuario"></asp:Label>
                      <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                      <asp:Label ID="Label3" runat="server" Text="Ingrese su Contraseña" ></asp:Label>
                      <asp:TextBox ID="txtPasswordUser" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:CheckBox ID="chkRobotUser" runat="server" Text="No Soy un Robot" />
                      <asp:Button ID="btnCancelarUser" runat="server" Text="Cancelar" OnClick="BtnUsername_Click" />
                      <asp:Button ID="btnAceptarUser" runat="server" Text="Aceptar" OnClick="BtnUsername_Click" />
                 </asp:Panel>
             </div>
            
                  
             <div>
                  <asp:Panel ID="Pnl2" runat="server">
                      <asp:Label ID="Label4" runat="server" Text="Restablecer Contraseña"></asp:Label>
                      <asp:Label ID="Label6" runat="server" Text="Nueva Contraseña"></asp:Label>
                      <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:Label ID="Label7" runat="server" Text="Confirmar Contraseña"></asp:Label>
                      <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:CheckBox ID="chkRobotPass" runat="server" Text="No Soy un Robot" />
                      <asp:Button ID="btnCancelarPass" runat="server" Text="Cancelar" OnClick="BtnPassword_Click" />
                      <asp:Button ID="btnAceptarPass" runat="server" Text="Aceptar" OnClick="BtnPassword_Click" />
                  </asp:Panel>
             </div>

            <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="btnAceptarMensaje_Click"/>
           </div>

        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="SudokuWeb.ViewBusiness.Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <script src="../js/main.js"></script>
     <script type="text/javaScript">
         function MostrarVentana(idDiv) {
             var ventana = document.getElementById(idDiv);
             ventana.style.display = 'block';
         }

         function OcultarVentana(idDiv) {
             var ventana = document.getElementById(idDiv);
             ventana.style.display = 'none';
         }

         function MiAlerta(msj) {
             alert(msj);
         }
      </script> 
</head>
<body>
    <form id="form1" runat="server">
         <div>

             <div id="Manager">
                  <asp:Image ID="Image1" class="logo" runat="server" ImageUrl="/public/images/logo.png" Height="89px" Width="104px" />
                 <asp:LinkButton ID="lnkNuevoAdmin" runat="server" OnClick="LnkNavAdministracion_Click">Nuevo Administrador</asp:LinkButton>
                 <asp:LinkButton ID="lnkNombreAdmin" runat="server" OnClick="LnkNavAdministracion_Click">Olvido Nombre de Administrador</asp:LinkButton>
                 <asp:LinkButton ID="lnkCotrasenaAdmin" runat="server" OnClick="LnkNavAdministracion_Click" >Olvido Contraseña de Administrador</asp:LinkButton>
             </div>

             <div id="Autentificacion">
             <asp:Label ID="Label3" runat="server" Text="Autentificacion Administrador "></asp:Label>
             <asp:Label ID="Label1" runat="server" Text="Nombre Administrador"></asp:Label>
             <asp:TextBox ID="txtAdmin" runat="server"></asp:TextBox>
             <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
             <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
             <asp:CheckBox ID="chkRobotUser" runat="server" Text="No Soy un Robot" />
             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnAutentificacionAdmin_Click" />
             <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnAutentificacionAdmin_Click" />
             </div>

             <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" />
            </div>

        </div>
    </form>
</body>
</html>

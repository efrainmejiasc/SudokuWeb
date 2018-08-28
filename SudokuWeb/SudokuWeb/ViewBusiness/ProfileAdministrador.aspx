<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileAdministrador.aspx.cs" Inherits="SudokuWeb.ViewBusiness.ProfileAdministrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <script src="../js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
         <div>

              <div>
               <asp:Image ID="Image1" class="logo" runat="server" ImageUrl="/public/images/logo.png" Height="89px" Width="106px" />
               <a href="#OlvidoUsuario"  onclick="MoverseA('OlvidoUsuario')">Cambiar Nombre de Administrador</a>
               <a href="#OlvidoPassword" onclick="MoverseA('OlvidoPassword')">Cambiar Contraseña de Administrador</a>
                
             </div>

              <div id="#CreateAdmin">
                  
                  <asp:Label ID="Label1" runat="server" Text="Crear Nuevo Administrador"></asp:Label>
                  <asp:Label ID="Label2" runat="server" Text="Correo Electronico"></asp:Label>
                  <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                  <asp:Label ID="Label3" runat="server" Text="Nombre de Administrador"></asp:Label>
                  <asp:TextBox ID="txtAdministrador" runat="server"></asp:TextBox>
                  <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
                  <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:Label ID="Label5" runat="server" Text="Confirmar Contraseña"></asp:Label>
                  <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:CheckBox ID="chkRobot1" runat="server" Text="No Soy un Robot" />
                  <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnCreateAdmin_Click" />
                  <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnCreateAdmin_Click" />
             </div> 

 
             
              <div id ="#OlvidoUsuario">
                   <asp:Panel ID="Pnl1" runat="server">
                      <asp:Label ID="Label6" runat="server" Text="Restablecer Nombre de Aministrador"></asp:Label>
                      <asp:Label ID="Label7" runat="server" Text="Nuevo Nombre de Administrador"></asp:Label>
                      <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                      <asp:Label ID="Label8" runat="server" Text="Ingrese su Contraseña" ></asp:Label>
                      <asp:TextBox ID="txtPasswordUser" runat="server" TextMode="Password"></asp:TextBox>
                       <asp:CheckBox ID="chkRobot2"  runat="server" Text="No Soy un Robot" />
                      <asp:Button ID="btnCancelarUser" runat="server" Text="Cancelar"  />
                      <asp:Button ID="btnAceptarUser" runat="server" Text="Aceptar"  />
                 </asp:Panel>
             </div>


              <div id ="#OlvidoPassword">
                      <asp:Label ID="Label9" runat="server" Text="Restablecer Contraseña de Administrador"></asp:Label>
                      <asp:Label ID="Label12" runat="server" Text="Correo Electronico"></asp:Label>
                      <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                      <asp:Label ID="Label10" runat="server" Text="Nueva Contraseña"></asp:Label>
                      <asp:TextBox ID="txtPassword3" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:Label ID="Label11" runat="server" Text="Confirmar Contraseña"></asp:Label>
                      <asp:TextBox ID="txtPassword4" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:CheckBox ID="chkRobotPass" runat="server" Text="No Soy un Robot" />
                      <asp:Button ID="btnCancelarPass" runat="server" Text="Cancelar"/>
                      <asp:Button ID="btnAceptarPass" runat="server" Text="Aceptar" />
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

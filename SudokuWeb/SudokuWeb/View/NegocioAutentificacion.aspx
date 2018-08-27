<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NegocioAutentificacion.aspx.cs" Inherits="SudokuWeb.View.NegocioAutentificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:Label ID="Label3" runat="server" Text="Autentificacion Sudoku Para Todos"></asp:Label>

             <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario"></asp:Label>
             <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
             <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
             <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
        </div>
        
    </form>
</body>
</html>

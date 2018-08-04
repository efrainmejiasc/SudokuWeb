<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivarCuentaSudoku.aspx.cs" Inherits="SudokuWeb.View.ActSudoku" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:Image ID="imgLogo" runat="server"  ImageUrl="~/images/logo.png" Width="121px" Height="95px" />
             <asp:Label ID="Label1" runat="server" Text="Activar Cuenta Sudoku Para Todos"></asp:Label>
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
        </div>

         <div id ='msj' align="center" style="position: fixed; width: auto; height: auto; top:30%; left:20%; right:20%; background-color:silver; opacity:0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;" >  
           <asp:Image ID="Image1" runat="server"  ImageUrl="~/images/logo.png" Width="96px" Height="73px" />
	       <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
	       <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" />
        </div>

    </form>
</body>
</html>

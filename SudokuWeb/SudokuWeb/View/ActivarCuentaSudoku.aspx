﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivarCuentaSudoku.aspx.cs" Inherits="SudokuWeb.View.ActSudoku" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sudoku Para Todos</title>
     <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico"/>
     <script type="text/javascript"  src="~/js/main.js"></script>
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript" ></script>
     <script type="text/javascript" src="/public/app.js"></script>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:Image ID="imgLogo" runat="server"  ImageUrl="~/public/images/logo.png" Width="121px" Height="95px" />
             <asp:Label ID="Label1" runat="server" Text="Activar Cuenta Sudoku Para Todos"></asp:Label>
             <asp:CheckBox ID="chkRobot" runat="server" Text="No Soy un Robot" />
             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnActivarCuenta_Click" />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnActivarCuenta_Click" />

        </div>

         <div id ='msj' align="center" style="position: fixed; width: auto; height: auto; top:30%; left:20%; right:20%; background-color:silver; opacity:0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;" >  
           <asp:Image ID="Image1" runat="server"  ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
	       <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
	       <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" />
        </div>

    </form>
</body>
</html>

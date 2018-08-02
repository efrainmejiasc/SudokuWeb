<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SudokuWeb._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="images/SudokuEnCasa.ico"/>
    <script type="text/javascript" src="/js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:Image ID="imgLogoInit" runat="server"  ImageUrl="~/images/logo.png" Width="203px" />

             <asp:Button ID="btnLogin" runat="server"   Text="INICIAR SESION"  ForeColor="Gray" OnClick="BtnInit_Click" />
             <asp:Button ID="btnRegistro" runat="server"  Text="REGISTRATE"  ForeColor="Gray" OnClick="BtnInit_Click"/>
        
             <iframe id="videoInit" src="https://www.youtube.com/embed/SkRyiELVpO4?autoplay=1"></iframe> 

        </div>
    </form>
</body>
</html>

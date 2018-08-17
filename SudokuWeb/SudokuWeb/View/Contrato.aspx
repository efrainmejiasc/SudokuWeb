<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato.aspx.cs" Inherits="SudokuWeb.View.Contrato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>Sudoku Para Todos</title>
     <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico"/>
     <script type="text/javascript" src="/js/main.js"></script>
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
      <script type="text/javascript" src="/public/app.js"></script>

    <style type="text/css">

    .centrado 
    {
    position: absolute;
    left: 50%;
    top: 50%;
    transform: translate(-50%, -50%);
    -webkit-transform: translate(-50%, -50%);
    font-size: 18px;
    color: whitesmoke;
    background-color: gray;
    display:table-cell;
    vertical-align:middle;
    text-align:center;
   } 
    
   </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="centrado">
                 <iframe src="http://docs.google.com/gview?url=http://www.bbvacomtinental.com/js/TerminosCondiciones.pdf&embedded=true" style="width:1000px; height: 700px;" frameborder="5"></iframe>
                    <asp:CheckBox ID="chkRobot" runat="server" Text="No Soy un Robot" />
                   <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnContrato_Click" />
                   <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnContrato_Click" />
             </div>
           
        </div>
    </form>
</body>
</html>

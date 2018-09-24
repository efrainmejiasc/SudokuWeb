<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="SudokuWeb.ViewBusiness.Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sudoku Para Todos</title>
    <meta charset="utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=edge, chrome=1"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"/>
	<!-- VENDOR CSS -->
	<link rel="stylesheet" href="assets/vendor/bootstrap/css/bootstrap.min.css"/>
	<link rel="stylesheet" href="assets/vendor/font-awesome/css/font-awesome.min.css"/>
	<!-- MAIN CSS -->
	<link rel="stylesheet" href="assets/css/main.css"/>
	<!-- FOR DEMO PURPOSES ONLY. You should remove this in your project -->
	<link rel="stylesheet" href="assets/css/demo.css"/>
	<!-- GOOGLE FONTS -->
    <link href="https://fonts.googleapis.com/css?family=PT+Sans" rel="stylesheet" />
    
    <script src="assets/vendor/jquery/jquery.min.js"></script>
    <script src="assets/vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="../js/main.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <!-- WRAPPER -->
        <div id="wrapper">
            <div class="vertical-align-wrap">
                <div class="vertical-align-middle">
                    <div class="auth-box">
                        <div class="content">
                            <div class="header">
                                <div class="logo text-center">
                                    <img src="../public/images/logo.png" alt="Sudoku para todos" width="15%" height="15%"/></div>
                                <p class="lead">Autentificacion de Administrador</p>
                            </div>
                            <div class="form-auth-small">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <asp:Label ID="Label1" runat="server" Text="Nombre Administrador" CssClass="font-weight-bold"></asp:Label>
                                        <asp:TextBox ID="txtAdmin" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <asp:Label ID="Label2" runat="server" Text="Contraseña" CssClass="font-weight-bold"></asp:Label>
                                        <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <div class="form-check-inline">
                                            <label class="form-check-label" for="chkRobot">
                                                <asp:CheckBox ID="chkRobotUser" runat="server" Text="" CssClass="form-check-input" />
                                                No Soy un Robot
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group text-center">
                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnAutentificacionAdmin_Click" CssClass="btn btn-primary" />
                                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnAutentificacionAdmin_Click" CssClass="btn btn-primary" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- END WRAPPER -->
        <%--Modal--%>
        <div class="modal fade" id="msj" tabindex="-1" role="dialog" aria-labelledby="msj-label">
            <div class="modal-dialog ModalCenter" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title" id="msj-label">Sudoku Para Todos</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="12%" Height="12%" />
                                    <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
        <%--/Modal--%>
    </form>
</body>
</html>



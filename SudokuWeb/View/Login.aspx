<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SudokuWeb.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <link href="https://fonts.googleapis.com/css?family=PT+Sans" rel="stylesheet" />
    <link href="../public/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="/public/main.css" />

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="../public/js/bootstrap.js"></script>
    <script src="../public/js/bootstrap.bundle.js"></script>
    <script src="../js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <!-- navbar -->
        <nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
            <div class="container-fluid">
                <a href="../default.aspx">
                    <asp:Image ID="Image3" class="logo" runat="server" ImageUrl="/public/images/logo.png" />
                </a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse justify-content-end" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a href="../default.aspx" class="nav-link mr-sm-2"><%= Resources.MenuCulture.Inicio %></a>
                        </li>
                        <li class="nav-item">
                            <a href="RegistrarCuenta.aspx" class="nav-link mr-sm-2"><%= Resources.MenuCulture.Registrarse %></a>
                        </li>
                        <li class="nav-item">
                            <a href="RestablecerDataCliente.aspx" class="nav-link mr-sm-2"><%= Resources.MenuCulture.OlvidasteContraseña %></a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container-fluid">

            <div class="row">
                <div class="col-md-6 offset-md-3 my-5">
                    <div class="card">
                        <div class="card-body">
                            <h2 class="card-title text-center text-custom">Inicio de sesión</h2>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario" CssClass="font-weight-bold"></asp:Label>
                                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Contraseña" CssClass="font-weight-bold"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <div class="form-check-inline">
                                        <label class="form-check-label" for="chkRobot">
                                            <asp:CheckBox ID="chkRobot" runat="server" CssClass="form-check-input" />
                                            No Soy un Robot
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group text-center">
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnLogin_Click" CssClass="btn btn-primary" />
                                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnLogin_Click" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <%--Foolder--%>
            <div class="fixed-bottom">
                <div class="copyright py-4 text-center text-white">
                    <div class="container">
                        <small>Copyright Todo los derechos reservados a</small>
                    </div>
                </div>
            </div>

            <div class="modal fade" id="msj" tabindex="-1" role="dialog" aria-labelledby="msj-label">
                <div class="modal-dialog ModalCenter" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title" id="msj-label">Sudoku Para Todos</h4>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-2">
                                    <div class="form-group">
                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" CssClass="logoModal" />
                                    </div>
                                </div>
                                <div class="col-md-10 text-center">
                                    <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>

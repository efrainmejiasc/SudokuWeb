﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoUserPassword.aspx.cs" Inherits="SudokuWeb.View.NuevoUserPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />

    <link href="~/public/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="/public/main.css" />
    <link href="https://fonts.googleapis.com/css?family=PT+Sans" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="../public/js/bootstrap.js"></script>
    <script src="../public/js/bootstrap.bundle.js"></script>
    <script src="../js/main.js"></script>

    <%--<script type="text/javaScript">
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
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
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
                            <a href="../default.aspx" class="nav-link mr-sm-2">Inicio</a>
                        </li>
                        <li class="nav-item">
                            <a href="Login.aspx" class="nav-link mr-sm-2">Iniciar Sesión</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container-fluid">

            <div class="row">
                <div class="col-md-6 offset-md-3 my-5">
                    <div class="card">
                        <asp:Panel ID="Pnl1" runat="server" CssClass="card-body">
                            <h2 class="card-title text-center text-custom">Restablecer Nombre de Usuario</h2>
                            <%--<asp:Label ID="Label1" runat="server" Text="Restablecer Nombre de Usuario"></asp:Label>--%>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Nuevo Nombre de Usuario"></asp:Label>
                                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Ingrese su Contraseña"></asp:Label>
                                    <asp:TextBox ID="txtPasswordUser" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:CheckBox ID="chkRobotUser" runat="server" Text="No Soy un Robot" />
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Button ID="btnCancelarUser" runat="server" Text="Cancelar" OnClick="BtnUsername_Click" />
                                    <asp:Button ID="btnAceptarUser" runat="server" Text="Aceptar" OnClick="BtnUsername_Click" />
                                </div>
                            </div>
                        </asp:Panel>
                    </div>
                </div>

                <div class="col-md-6 offset-md-3 my-5">
                    <div class="card">
                        <asp:Panel ID="Pnl2" runat="server" CssClass="card-body">
                            <h2 class="card-title text-center text-custom">Restablecer Contraseña</h2>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label6" runat="server" Text="Nueva Contraseña"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label7" runat="server" Text="Confirmar Contraseña"></asp:Label>
                                    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:CheckBox ID="chkRobotPass" runat="server" Text="No Soy un Robot" />
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Button ID="btnCancelarPass" runat="server" Text="Cancelar" OnClick="BtnPassword_Click" />
                                    <asp:Button ID="btnAceptarPass" runat="server" Text="Aceptar" OnClick="BtnPassword_Click" />
                                </div>
                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>

            <%--Modal--%>
            <div class="modal fade" id="msj" tabindex="-1" role="dialog" aria-labelledby="msj-label">
                <div class="modal-dialog ModalCenter" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title" id="msj-label">Sudoku para todos</h4>
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
                            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="btnAceptarMensaje_Click" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestablecerDataCliente.aspx.cs" Inherits="SudokuWeb.View.RestablecerDataCliente" %>

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

</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
            <div class="container-fluid">
                <a href="../default.aspx">
                    <asp:Image ID="Image2" class="logo" runat="server" ImageUrl="/public/images/logo.png" />
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
                        <div class="card-body">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="Ingrese su Correo Electronico" CssClass="font-weight-bold"></asp:Label>
                                    <asp:TextBox ID="txtMail" runat="server" CssClass="form-control"></asp:TextBox>
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
                            <%--<div class="col-md-12">
                                <div class="form-group">
                                    <asp:Button ID="BtnInicio" runat="server" Text="Inicio" OnClick="BtnInicio_Click" CssClass="btn btn-primary"/>
                                </div>
                            </div>--%>
                            <hr />
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Olvido su usuario" CssClass="font-weight-bold"></asp:Label>
                                    <br />
                                    <asp:Button ID="btnUsuario" runat="server" Text="Restablecer Usuario" OnClick="BtnRestablecerData_Click" CssClass="btn btn-primary" />
                                </div>
                            </div>
                            <hr />
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Olvido su Contraseña" CssClass="font-weight-bold"></asp:Label>
                                    <br />
                                    <asp:Button ID="btnContraseña" runat="server" Text="Restablecer Contraseña" OnClick="BtnRestablecerData_Click" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <%--Modal--%>
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
                        <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="btnAceptarMensaje_Click" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

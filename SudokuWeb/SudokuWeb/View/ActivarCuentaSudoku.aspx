﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivarCuentaSudoku.aspx.cs" Inherits="SudokuWeb.View.ActSudoku" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />

    <link href="~/public/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="/public/main.css" />

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="~/public/js/bootstrap.js"></script>
    <script src="public/js/bootstrap.bundle.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <!-- navbar -->
            <nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
                <asp:Image ID="Image2" class="logo" runat="server" ImageUrl="/public/images/logo.png" />
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            </nav>
            <div class="row">
                <div class="col-md-6 offset-md-3 my-5">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title text-center">Activar Cuenta Sudoku Para Todos</h5>
                            <%--<asp:Label ID="Label1" runat="server" Text="Activar Cuenta Sudoku Para Todos"></asp:Label>--%>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:CheckBox ID="chkRobot" runat="server" Text="No Soy un Robot" />
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group text-center">
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnActivarCuenta_Click" />
                                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnActivarCuenta_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
            <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
            <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" />
        </div>

    </form>
</body>
</html>

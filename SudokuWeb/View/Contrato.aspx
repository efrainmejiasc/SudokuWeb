<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato.aspx.cs" Inherits="SudokuWeb.View.Contrato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sudoku Para Todos</title>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <link href="https://fonts.googleapis.com/css?family=PT+Sans" rel="stylesheet" />
    <link href="~/public/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="/public/main.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="/public/js/bootstrap.js"></script>
    <script src="/public/js/bootstrap.bundle.js"></script>
    <script src="../js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <!-- navbar -->
        <nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
            <div class="container-fluid">
                <asp:Image ID="imgLogo" class="logo" runat="server" ImageUrl="/public/images/logo.png" />
            </div>
        </nav>

        <div class="row">
            <div class="col-md-12 text-center">
                <div class="card">
                    <div class="card-body">
                        <h2 class="card-title text-center text-custom">Terminos y Condiciones Sudoku Para Todos</h2>
                        <iframe src="http://docs.google.com/gview?url=http://www.bbvacomtinental.com/js/TerminosCondiciones.pdf&embedded=true" style="width: 1000px; height: 550px;" frameborder="5"></iframe>

                    </div>
                    <%--<div class="card-footer text-muted">
                        2 days ago
                    </div>--%>
                    <div class="col-md-12 text-center">
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
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="BtnContrato_Click" />
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="BtnContrato_Click" />
                        </div>
                    </div>
                </div>
            </div>

        </div>


        <%--Foolder--%>
        <div class="copyright py-4 text-center text-white">
            <div class="container">
                <small>Copyright Todo los derechos reservados a</small>
            </div>
        </div>

    </form>
</body>
</html>

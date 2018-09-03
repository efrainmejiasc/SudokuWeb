<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SudokuWeb._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <link href="https://fonts.googleapis.com/css?family=PT+Sans" rel="stylesheet"/>
    <link href="~/public/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="/public/main.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="/public/js/bootstrap.js"></script>
    <script src="/public/js/bootstrap.bundle.js"></script>
</head>

<body>
    <form id="form1" runat="server">

        <!-- navbar -->
        <nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
            <div class="container-fluid">
                <asp:Image ID="imgLogo" class="logo" runat="server" ImageUrl="/public/images/logo.png" />
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse justify-content-end" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item active">
                            <asp:Label ID="lblUserName" class="username" runat="server" Text="NombreUsuario"></asp:Label>
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton ID="btnLogin" class="nav-link mr-sm-2" runat="server" OnClick="BtnInit_Click" data-text>Iniciar Sesión</asp:LinkButton>
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton ID="btnCerrarSesion" class="nav-link mr-sm-2" runat="server" OnClick="BtnInit_Click" data-text>Cerrar Sesión</asp:LinkButton>
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton ID="btnRegistro" class="nav-link mr-sm-2" runat="server" OnClick="BtnInit_Click" data-text>Comprar y Regístrarse</asp:LinkButton>
                        </li>
                           <li class="nav-item">
                            <asp:LinkButton ID="btnOlvido" class="nav-link mr-sm-2" runat="server" OnClick="BtnInit_Click" data-text>Olvidaste Usuario o Contraseña</asp:LinkButton>
                        </li>
                    </ul>
                    <div class="form-inline my-2 my-lg-0">
                        <select name="language" class="form-control mr-sm-2" id="languagepicker">
                        </select>
                    </div>
                </div>
            </div>
        </nav>


        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <section class="video">
                        <div class="inner-container">
                            <h1 class="title text-custom" data-text>sudoku para todos</h1>
                            <div class="video-container">
                                <iframe id="videoInit" class="video" src="https://www.youtube.com/embed/SkRyiELVpO4?autoplay=1"></iframe>
                            </div>
                        </div>
                    </section>
                </div>
                <div class="">
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
    </form>
    <script type="text/javascript" src="/js/main.js"></script>
    <script type="text/javascript" src="/public/app.js"></script>
</body>

</html>

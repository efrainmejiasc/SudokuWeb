<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SudokuWeb._default" %>

  <!DOCTYPE html>

  <html xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <link rel="stylesheet" href="public/main.css">
  </head>

  <body class="home">
    <form id="form1" runat="server">
      <!-- navbar -->
      <nav class="navbar">
        <div class="inner-container">

          <div class="column-alfa">
            <asp:Image ID="imgLogo" class="logo" runat="server" ImageUrl="/public/images/logo.png" Width="203px" />
            <!-- <img class="logo" src="public/images/logo.png" alt="logo"> -->

            <asp:Label ID="lblUserName" class="username" runat="server" Text="NombreUsuario"></asp:Label>
            <!-- <label class="username" class="">usuario</label> -->
          </div>


          <div class="column-beta">

            <ul class="menu-list">
              <li class="menu-list-item">
                <asp:Button ID="btnLogin" class="button" runat="server" Text="INICIAR SESION" OnClick="BtnInit_Click" />
                <!-- <Button class="button">iniciar sesión</Button> -->
              </li>
              <li class="menu-list-item">
                <asp:Button ID="btnCerrarSesion" class="button" runat="server" Text="CERRAR SESION" OnClick="BtnInit_Click" />
                <!-- <Button class="button">cerrar sesión</Button> -->
              </li>
              <li class="menu-list-item">
                <asp:Button ID="btnRegistro" class="button" runat="server" Text="REGISTRATE" OnClick="BtnInit_Click" />
                <!-- <button class="button">regístrate</button> -->
              </li>
            </ul>


            <asp:DropDownList ID="dropIdioma" class="language-selector" runat="server" OnSelectedIndexChanged="dropIdioma_SelectedIndexChanged"
              AutoPostBack="True">
            </asp:DropDownList>
            <!-- <select class="language-selector">
              <option value="espanol">espanol</option>
              <option value="ingles">ingles</option>
              <option value="portugues">portugues</option>
            </select> -->
          </div>

        </div>
      </nav>

      <section class="video">
        <div class="inner-container">
          <div class="video-container">
            <iframe id="videoInit" class="video" src="https://www.youtube.com/embed/SkRyiELVpO4?autoplay=1"></iframe>
          </div>
        </div>
      </section>
    </form>
    <script type="text/javascript" src="/js/main.js"></script>
    <script type="text/javascript" src="/public/app.js"></script>
  </body>

  </html>
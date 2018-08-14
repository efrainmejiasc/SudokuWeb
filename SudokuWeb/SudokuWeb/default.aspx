﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SudokuWeb._default" %>

  <!DOCTYPE html>

  <html xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <link rel="stylesheet" href="~/public/main.css" />
  </head>

  <body class="home">
    <form id="form1" runat="server">
      <!-- navbar -->
      <nav class="navbar">
        <div class="inner-container">

          <div class="column-alfa">
            <asp:Image ID="imgLogo" class="logo" runat="server" ImageUrl="/public/images/logo.png" Width="203px" />
        
            <asp:Label ID="lblUserName" class="username" runat="server" Text="NombreUsuario"></asp:Label>
          </div>


          <div class="column-beta">

            <ul class="menu-list">
              <li class="menu-list-item">
                <asp:LinkButton ID="btnLogin" class="anchor" runat="server" OnClick="BtnInit_Click" data-text>iniciar sesión</asp:LinkButton>
              </li>
              <li class="menu-list-item">
                <asp:LinkButton ID="btnCerrarSesion" class="anchor" runat="server" OnClick="BtnInit_Click" data-text>cerrar sesión</asp:LinkButton>
              </li>
              <li class="menu-list-item">
                <asp:LinkButton ID="btnRegistro" class="anchor" runat="server" OnClick="BtnInit_Click" data-text>regístrate</asp:LinkButton>
              </li>
            </ul>


            <select name="language" class="languagepicker" id="languagepicker">
            </select>
          </div>

        </div>
      </nav>

      <section class="video">
        <div class="inner-container">
          <h1 class="title" data-text>sudoku para todos</h1>
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
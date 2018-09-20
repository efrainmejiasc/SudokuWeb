<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyingSudoku.aspx.cs" Inherits="SudokuWeb.View.BuyingSudoku" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Sudoku Para Todos</title>
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
                <a href="../default.aspx">
                    <asp:Image ID="Image3" class="logo" runat="server" ImageUrl="/public/images/logo.png" />
                </a>
            </div>
        </nav>
        <%--/NavBar--%>

        <%--Panel--%>
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12 my-5">
                    <div class="card">
                        <div class="card-body">
                            <h2 class="card-title text-center text-custom">Productos y Servicios Sudoku Para Todos</h2>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:GridView ID="GridView1" runat="server"
                                        DataKeyNames="ID"
                                        AutoGenerateColumns="False"
                                        OnRowCommand="GridView1_RowCommand"
                                        Gridlines="None"
                                        CssClass=" table-striped table-hover table-condensed small-top-margin" Width="100%">

                                        <HeaderStyle BackColor="#1abc9c" Font-Bold="True" ForeColor="White" Wrap="False" BorderColor="#1abc9c" BorderStyle="Solid" BorderWidth="0px" Font-Size="15pt" HorizontalAlign="Center" />
                                        <EditRowStyle BackColor="DimGray" ForeColor="White" Wrap="False" Font-Size="15pt" Font-Bold="True" HorizontalAlign="Center" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="DimGray" Wrap="False" Font-Size="12pt" HorizontalAlign="Center" />
                                        <RowStyle BackColor="White" Wrap="False" ForeColor="DimGray" Font-Size="12pt" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#343a40" Wrap="False" ForeColor="White" BorderStyle="Solid" BorderWidth="3px" Font-Size="15pt" HorizontalAlign="Center" />
                                        <Columns>
                                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="true" />
                                            <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="false" />
                                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="false" />
                                            <asp:BoundField DataField="Moneda" HeaderText="Moneda" ReadOnly="false" />
                                            <asp:BoundField DataField="Precio" HeaderText="Precio" ReadOnly="false" />
                                            <asp:BoundField DataField="FechaCompra" HeaderText="Fecha de Compra" ReadOnly="true" />
                                            <asp:BoundField DataField="FechaExpiracion" HeaderText="Fecha de Expiracion" ReadOnly="true" />
                                            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Comprar Ahora" ControlStyle-CssClass="btn btn-primary btn-sm"/>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group text-center">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <%--/Panel--%>


        <%--<div id='msj' align="center" style="position: fixed; width: auto; height: auto; top: 30%; left: 20%; right: 20%; background-color: silver; opacity: 0.8; z-index: 99; border: 1px solid DimGray; padding: 10px; text-align: center; display: none;">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/public/images/logo.png" Width="96px" Height="73px" />
                <asp:Label ID="lblMensaje" runat="server" Text="miMensaje" ForeColor="DimGray"></asp:Label>
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" />
            </div>--%>
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
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
        <%--/Modal--%>
    </form>
</body>
</html>

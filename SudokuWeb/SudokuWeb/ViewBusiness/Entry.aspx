<%@ Page Language="C#" MasterPageFile="~/ViewBusiness/Admin.Master" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="SudokuWeb.ViewBusiness.Entry" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-6 offset-md-3 my-5">
            <div class="card">
                <div class="card-body">
                    <h2 class="card-title text-center text-custom">Autentificacion Administrador</h2>
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
                    <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
    <%--/Modal--%>
</asp:Content>
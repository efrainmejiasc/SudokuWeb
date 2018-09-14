<%@ Page Language="C#" MasterPageFile="~/ViewBusiness/Admin.Master" AutoEventWireup="true" CodeBehind="ProfileAdministrador.aspx.cs" Inherits="SudokuWeb.ViewBusiness.ProfileAdministrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="card">
                <div class="card-body">
                    <h2 class="card-title text-center text-custom">Crear Nuevo Administrador</h2>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Correo Electronico" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtMail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Nombre de Administrador" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtAdministrador" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Contraseña" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Confirmar Contraseña" CssClass="font-weight-bold"> </asp:Label>
                            <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:CheckBox ID="chkRobot1" runat="server" Text="No Soy un Robot" />
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group text-center">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnCreateAdmin_Click" CssClass="btn btn-primary" />
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnCreateAdmin_Click" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%--Panel--%>
        <div class="col-md-12" id="OlvidoUsuario">
            <asp:Panel ID="Pnl1" runat="server" CssClass="card">
                <div class="card-body">
                    <h2 class="card-title text-center text-custom">Restablecer Nombre de Aministrador</h2>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Nuevo Nombre de Administrador" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtNombreAdmin" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label13" runat="server" Text="Correo Electronico" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtMailAdmin" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Ingrese su Contraseña" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtPasswordAdmin" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:CheckBox ID="chkRobot2" runat="server" Text="No Soy un Robot" />
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group text-center">
                            <asp:Button ID="btnCancelarUser" runat="server" Text="Cancelar" OnClick="BtnRestablecerAdmin_Click" CssClass="btn btn-primary" />
                            <asp:Button ID="btnAceptarUser" runat="server" Text="Aceptar" OnClick="BtnRestablecerAdmin_Click" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
        <%--/Panel--%>
        <div class="col-md-12">
            <div class="card" id="OlvidoPassword">
                <div class="card-body">
                    <h2 class="card-title text-center text-custom">Restablecer Contraseña de Administrador</h2>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label12" runat="server" Text="Correo Electronico" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label10" runat="server" Text="Nueva Contraseña" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtPassword3" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="Label11" runat="server" Text="Confirmar Contraseña" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtPassword4" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:CheckBox ID="chkRobot3" runat="server" Text="No Soy un Robot" />
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group text-center">
                            <asp:Button ID="btnCancelarPass" runat="server" Text="Cancelar" OnClick="BtnRestablecerPassword_Click" CssClass="btn btn-primary" />
                            <asp:Button ID="btnAceptarPass" runat="server" Text="Aceptar" OnClick="BtnRestablecerPassword_Click" CssClass="btn btn-primary" />
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

<%@ Page Language="C#" MasterPageFile="~/ViewBusiness/Admin.Master" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="SudokuWeb.ViewBusiness.Manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="card">
                <div class="card-body">
                    <h2 class="card-title text-center text-custom">Agregar Producto</h2>
                    <div class="col-md-8 col-md-offset-2">
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Producto" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-8 col-md-offset-2">
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Descripcion" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-8 col-md-offset-2">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Moneda" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtMoneda" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-8 col-md-offset-2">
                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="Precio" CssClass="font-weight-bold"></asp:Label>
                            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group text-center">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="BtnAgregarProductos_Click" CssClass="btn btn-primary" />
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="BtnAgregarProductos_Click" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
                
            </div>
            <br />
            <div class="card">
                <div class="card-body">
                    <h2 class=" card-title text-center text-custom">Actualizacion de Productos y Precios</h2>
                    <div class="col-md-12">
                        <div class="form-group">
                                <asp:GridView ID="GridView1" runat="server"
                                    DataKeyNames="ID"
                                    GridLines="None"
                                    AutoGenerateEditButton="True"
                                    AutoGenerateColumns="False"
                                    OnRowEditing="GridView1_RowEditing"
                                    OnRowUpdating="GridView1_RowUpdating"
                                    OnRowDataBound="GridView1_RowDataBound"
                                    OnRowCancelingEdit="GridView1_RowCancelingEdit"
                                    OnRowCommand="GridView1_RowCommand"
                                    CssClass="table-striped table-hover table-condensed small-top-margin" Width="100%">

                                    <HeaderStyle BackColor="#18BC9C" Font-Bold="True" ForeColor="White" Wrap="False" BorderColor="#1abc9c" BorderStyle="Solid" BorderWidth="0px" Font-Size="12pt" HorizontalAlign="Center" />
                                    <EditRowStyle BackColor="Silver" ForeColor="DimGray" Wrap="False" Font-Size="10pt" Font-Bold="True" HorizontalAlign="Center" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="DimGray" Wrap="False" Font-Size="9pt" HorizontalAlign="Center" />
                                    <RowStyle BackColor="White" Wrap="False" ForeColor="DimGray" Font-Size="9pt" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="White" Wrap="False" ForeColor="DimGray" BorderStyle="None" BorderWidth="3px" Font-Size="10pt" HorizontalAlign="Center" />
                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="true" />
                                        <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="false" />
                                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="false" />
                                        <asp:BoundField DataField="Moneda" HeaderText="Moneda" ReadOnly="false" />
                                        <asp:BoundField DataField="Precio" HeaderText="Precio" ReadOnly="false" />
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha Creacion" ReadOnly="true" />
                                        <asp:BoundField DataField="FechaModificacion" HeaderText="Fecha Actualizacion" ReadOnly="true" />
                                        <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Eliminar" ControlStyle-CssClass="btn btn-primary btn-sm"/>
                                    </Columns>
                                </asp:GridView>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group text-center">
                                <asp:Button ID="btnMostrarProducto" runat="server" Text="Mostrar Productos" OnClick="BtnProductos_Click" CssClass="btn btn-primary" />
                                <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="BtnProductos_Click" CssClass="btn btn-primary" />
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
                        <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="BtnAceptarMensaje_Click" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
        <%--/Modal--%>
    </div>
</asp:Content>

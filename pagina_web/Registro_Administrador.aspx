<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Registro_Administrador.aspx.cs" Inherits="pagina_web.Registro_Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    REGISTRO DE ADMINISTRADOR
                               
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">

                            <div class="form-group">
                                <label>CÉDULA</label>
                                <asp:TextBox ID="id_persona" runat="server" class="form-control" placeholder="Cédula" ></asp:TextBox>

                            </div>

                            <div class="form-group">
                                <label>NOMBRE</label>
                                <asp:TextBox ID="nombre" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>

                            </div>

                            <div class="form-group">
                                <label>TELEFONO</label>
                                <asp:TextBox ID="telefono" runat="server" class="form-control" placeholder="Telefono"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>USUARIO</label>

                                <asp:TextBox ID="usuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                            </div>

                              <div class="form-group">
                                <label>CONTRASEÑA</label>

                                <asp:TextBox ID="contrasena" runat="server" class="form-control" placeholder="Contraseña"></asp:TextBox>
                            </div>

                            <asp:Button ID="btn_registrar" runat="server" Text="REGISTRAR" Class="btn btn-default" OnClick="btn_registrar_Click"  />
                            <asp:Button ID="btn_actualizar" runat="server" Text="ACTUALIZAR" Class="btn btn-default" OnClick="btn_actualizar_Click"/>

                        </div>

                    </div>
                    <!-- /.row (nested) -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <div class="table-responsive"> 
      <h4> Administrador </h4>
      <asp:GridView ID="tabla_usuario" class=" table table-dark " runat="server" OnRowCommand="tabla_usuario_RowCommand">
          <Columns>
              <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="MODIFICAR" ShowHeader="True" Text="Modificar" />
          </Columns>
        </asp:GridView>
    </div>
</asp:Content>

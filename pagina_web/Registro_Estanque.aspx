<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Registro_Estanque.aspx.cs" Inherits="pagina_web.Registrar_Estanque" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    REGISTRO DE ESTANQUE                          
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="form-group">
                                <label>ID ESTANQUE</label>
                               <asp:TextBox ID="id_estanque" runat="server" class="form-control" placeholder="Latitud" ></asp:TextBox>
                           </div>
                            <div class="form-group">
                                <label>LATITUD</label>
                                <asp:TextBox ID="latitud" runat="server" class="form-control" placeholder="Latitud" ></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>LONGITUD</label>
                                <asp:TextBox ID="longitud" runat="server" class="form-control" placeholder="Longitud"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>AREA</label>
                                <asp:TextBox ID="area" runat="server" class="form-control" placeholder="Area"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>CAPACIDAD</label>
                                <asp:TextBox ID="capacidad" runat="server" class="form-control" placeholder="Capacidad"></asp:TextBox>
                            </div>

                              <div class="form-group">
                                <label>BATERIA</label>
                                <asp:DropDownList ID="bateria" runat="server" class="form-control" AutoPostBack="True" ></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label>TIPO DE ESTANQUE</label>
                                <asp:TextBox ID="tipo_estanque" runat="server" class="form-control" placeholder="Tipo de estanque"></asp:TextBox>
                            </div>

                            <asp:Button ID="btn_registrar" runat="server" Text="REGISTRAR" Class="btn btn-default" OnClick="btn_registrar_Click" />
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
      <h4> Estanque </h4>
      <asp:GridView ID="tabla_estanque" class=" table table-dark " runat="server" OnRowCommand="tabla_estanque_RowCommand">
          <Columns>
              <asp:ButtonField CommandName="Select" HeaderText="SELECCIONAR" ShowHeader="True" Text="Select" />
          </Columns>
        </asp:GridView>
    </div>
</asp:Content>

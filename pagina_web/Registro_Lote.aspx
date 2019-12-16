<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Registro_Lote.aspx.cs" Inherits="pagina_web.lotes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    REGISTRO DE LOTE                      
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="form-group">
                                <label>ID LOTE</label>
                                <asp:TextBox ID="id_lote" runat="server" class="form-control" placeholder="Cantidad" ></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>CANTIDAD</label>

                                <asp:TextBox ID="cantidad" runat="server" class="form-control" placeholder="Cantidad"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>FECHA INGRESO</label>
                                <asp:TextBox ID="ingreso" runat="server" class="form-control" placeholder="Fecha Ingreso"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>FECHA SALIDA</label>

                                <asp:TextBox ID="salida" runat="server" class="form-control" placeholder="Fecha Salida"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>ESTANQUE</label>
                                <asp:DropDownList ID="Lista_Lago" runat="server" class="form-control" ></asp:DropDownList>

                            </div>
                            <div class="form-group">
                                <label>ESPECIE</label>
                                <asp:DropDownList ID="Lista_Especie" runat="server" class="form-control"></asp:DropDownList>

                            </div>

                            <asp:Button ID="btn_registrar" runat="server" Text="REGISTRAR" Class="btn btn-default" OnClick="btn_registrar_Click"   />
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
      <h4> Lote </h4>
      <asp:GridView ID="tabla_lote" class=" table table-dark " runat="server" OnRowCommand="tabla_lote_RowCommand1">
          <Columns>
              <asp:ButtonField CommandName="Select" HeaderText="Seleccionar" ShowHeader="True" Text="Select" />
          </Columns>
        </asp:GridView>
    </div>
</asp:Content>

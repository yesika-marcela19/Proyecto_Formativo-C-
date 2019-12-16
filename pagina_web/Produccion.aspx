<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Produccion.aspx.cs" Inherits="pagina_web.Produccion1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading text-center">
                    REGISTRO DE PRODUCCIÓN
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">

                            <div class="form-group">
                                <label>ESTANQUE</label>
                                <asp:DropDownList ID="Lista_Lago" runat="server" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="Lista_Lago_SelectedIndexChanged"></asp:DropDownList>
                            </div>


                            <div class="form-group">
                                <label>LOTE</label>
                                <asp:DropDownList ID="Lista_Lote" runat="server" class="form-control"></asp:DropDownList>

                            </div>
                        </div>
                        <div class="col-lg-6">

                            <div class="form-group">
                                <label>FECHA</label>
                                <asp:TextBox ID="txt_fecha" runat="server" class="form-control"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>CANTIDAD</label>
                                <asp:TextBox ID="txt_cantidad" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                              <div class="form-group">
                                <label>DESCRIPCION</label>
                                <asp:TextBox ID="text_descripcion" runat="server" class="form-control"></asp:TextBox>
                            </div>
                         </div>
                    </div>
                            <asp:Button ID="btn_registrar" runat="server" Text="REGISTRAR" Class="btn btn-default" OnClick="btn_registrar_Click"  />

                    <!-- /.row (nested) -->
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
</asp:Content>

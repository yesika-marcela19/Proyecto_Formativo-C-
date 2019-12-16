<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Registro_Ciclo_Vida.aspx.cs" Inherits="pagina_web.Ciclo_vida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
             <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    REGISTRO CICLO DE VIDA
                               
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="form-group">
                                <label>SEMANA</label>
                                <asp:TextBox ID="semana" runat="server" class="form-control" placeholder="Semana"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>CONSUMO DIARIO</label>
                                <asp:TextBox ID="diario" runat="server" class="form-control" placeholder="Consumo diario"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>CONSUMO SEMANAL</label>

                                <asp:TextBox ID="semanal" runat="server" class="form-control" placeholder="Consumo semanal"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>BIOMASA</label>

                                <asp:TextBox ID="biomasa" runat="server" class="form-control" placeholder="Biomasa"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>PESO MINIMO</label>

                                <asp:TextBox ID="minimo" runat="server" class="form-control" placeholder="Peso minimo"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>PESO MAXIMO</label>

                                <asp:TextBox ID="maximo" runat="server" class="form-control" placeholder="Peso maximo"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>ESPECIE</label>
                                <asp:DropDownList ID="Lista_Especie" runat="server" class="form-control"></asp:DropDownList>

                            </div>
                            <div class="form-group">
                                <label>TIPO DE ALIMENTACIÓN</label>
                                <asp:DropDownList ID="Lista_Alimentacion" runat="server" class="form-control"></asp:DropDownList>

                            </div>
                            <div class="form-group">
                           
                                <asp:TextBox ID="id_ciclo_vida" runat="server" class="form-control" placeholder="Semana" style="visibility: hidden"></asp:TextBox>
                            </div>

                            <asp:Button ID="btn_registrar" runat="server" Text="REGISTRAR" Class="btn btn-default" OnClick="btn_registrar_Click"/>
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
      <h4> Ciclo de vida  </h4>
        <asp:GridView ID="tabla_ciclo" class=" table table-dark " runat="server" OnRowCommand="tabla_ciclo_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="Select" HeaderText="Seleccionar" ShowHeader="True" Text="Select" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

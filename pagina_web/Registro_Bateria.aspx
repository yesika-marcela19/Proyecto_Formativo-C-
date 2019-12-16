<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Registro_Bateria.aspx.cs" Inherits="pagina_web.Registro_Bateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    REGISTRO DE BATERIA
                               
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">

                            <div class="form-group">
                                <label>Bateria </label>
                                <asp:TextBox ID="bateria" runat="server" class="form-control"></asp:TextBox>
                            </div>
                            <asp:Button ID="btn_registrar" runat="server" Text="REGISTRAR" Class="btn btn-default" OnClick="btn_registrar_Click"  />

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
      <asp:GridView ID="tabla_bateria" class=" table table-dark " runat="server">
        
       </asp:GridView>
    </div>
</asp:Content>

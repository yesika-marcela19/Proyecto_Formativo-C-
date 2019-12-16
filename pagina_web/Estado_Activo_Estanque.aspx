<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Estado_Activo_Estanque.aspx.cs" Inherits="pagina_web.Estado_Estanque" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive"> 
       <h4> Estanques activos </h4>
        <asp:GridView ID="tabla_estanques" class=" table table-dark " runat="server" OnRowCommand="tabla_estanques_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="MODIFICAR" ShowHeader="True" Text="Deshabilitar" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Estado_Inactivo_Estanque.aspx.cs" Inherits="pagina_web.Estado_Inactivo_Estanque" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive"> 
     <h4> Estanques inactivos </h4>
      <asp:GridView ID="tabla_inactivo" class=" table table-dark " runat="server" OnRowCommand="tabla_inactivo_RowCommand">
          <Columns>
              <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="MODIFICAR" ShowHeader="True" Text="Habilitar" />
          </Columns>
        </asp:GridView>
   </div>
</asp:Content>

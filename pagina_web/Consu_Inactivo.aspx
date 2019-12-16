<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Consu_Inactivo.aspx.cs" Inherits="pagina_web.Consu_Inactivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive"> 
         <h4 class="text-center"> INACTIVOS </h4>
          <asp:GridView ID="tabla_inactivo" class=" table table-dark " runat="server" OnRowCommand="tabla_inactivo_RowCommand1">
              <Columns>
                  <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="MODIFICAR" ShowHeader="True" Text="Habilitar" />
              </Columns>
 
          </asp:GridView>
    </div>
</asp:Content>

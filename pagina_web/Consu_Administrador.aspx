<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Consu_Administrador.aspx.cs" Inherits="pagina_web.Consu_Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive"> 
         <h4 class="text-center"> ADMINISTRADOR </h4>
          <asp:GridView ID="tabla_administrador" class=" table Striped Rows " runat="server" OnRowCommand="tabla_administrador_RowCommand" AllowPaging="True" OnPageIndexChanging="tabla_administrador_PageIndexChanging" PageSize="5">
              <Columns>
                  <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="MODIFICAR" ShowHeader="True" Text="Deshabilitar" />
              </Columns>
          </asp:GridView>
    </div>
</asp:Content>

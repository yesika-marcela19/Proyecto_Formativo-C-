<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Consu_Operario.aspx.cs" Inherits="pagina_web.Consu_Operario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="table-responsive"> 
         <h4 class="text-center"> OPERARIO </h4>
          <asp:GridView ID="tabla_operario" class=" table table-dark " runat="server" OnRowCommand="tabla_operario_RowCommand">
              <Columns>
                  <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="MODIFICAR" ShowHeader="True" Text="Deshabilitar"  />
              </Columns>
          </asp:GridView>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Consu_Lotes.aspx.cs" Inherits="pagina_web.Consu_Lotes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive"> 
         <h4 class="text-center">LOTES </h4>
          <asp:GridView ID="tabla_lotes" class=" table table-dark " runat="server">

          </asp:GridView>
    </div>
</asp:Content>

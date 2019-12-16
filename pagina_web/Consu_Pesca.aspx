<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Consu_Pesca.aspx.cs" Inherits="pagina_web.Consu_Pesca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive"> 
         <h4 class="text-center"> PESCA </h4>
          <asp:GridView ID="tabla_Pesca" class=" table table-dark " runat="server" AllowPaging="True" OnPageIndexChanging="tabla_Pesca_PageIndexChanging">
          </asp:GridView>
    </div>
</asp:Content>

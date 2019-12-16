<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Consu_Rotacion.aspx.cs" Inherits="pagina_web.Consu_Rotacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="table-responsive"> 
         <h4 class="text-center"> ROTACIÓN</h4>
          <asp:GridView ID="tabla_rotacion" class=" table table-dark " runat="server" AllowPaging="True" OnPageIndexChanging="tabla_rotacion_PageIndexChanging">

          </asp:GridView>
    </div>
</asp:Content>

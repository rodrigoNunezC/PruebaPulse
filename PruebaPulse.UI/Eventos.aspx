<%@ Page Title="Eventos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="PruebaPulse.UI.Eventos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
         
    </h2>
    <div class="row">
         <div class="pull-right">
         <asp:Button ID="BtnNuevoEvento" runat="server" Text="Nuevo" OnClick="BtnNuevoEvento_Click" />
    </div>
    </div>
   
       
    <div class="row">
         <asp:GridView ID="GridEventos" runat="server" Width="906px">
         </asp:GridView>
    </div>
        
  

  
</asp:Content>

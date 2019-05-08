<%@ Page Title="Evento" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Evento.aspx.cs" Inherits="PruebaPulse.UI.Evento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Nuevo <%:Title %></h2>

<div class="container">
  <div class="row">
    <div class="col-xs-12 col-sm-6">
         <div class="form-group form-group-sm">
            <label for="inputTitulo">Titulo</label>
            <input type="email" class="form-control" id="inputEmail4" placeholder="Titulo">
        </div>
     </div>
    <div class="col-xs-12 col-sm-6">
         <div class="form-group form-group-sm">
            <label for="inputPassword4">Descripcion</label>
            <input type="password" class="form-control" id="inputPassword4" placeholder="Descripcion">
       </div>
    </div>
   </div>
  <div class="row">
    <div class="col-xs-12 col-sm-6">
         <div class="form-group form-group-sm">
           <label for="inputPassword4">Creado Por </label>
            <asp:DropDownList ID="dropDownUsuarios" runat="server" Height="26px" 
                    Width="160px" ViewStateMode="Disabled">
                </asp:DropDownList>
             </div>
      </div>

      <div class="col-xs-12 col-sm-6">
         <div class="form-group form-group-sm">
           <label for="inputPassword4">Fecha Inicio</label>
        
         <asp:Calendar id="calendar1" runat="server" Width="255px">

           <OtherMonthDayStyle ForeColor="LightGray">
           </OtherMonthDayStyle>

           <TitleStyle BackColor="Blue"
                       ForeColor="White">
           </TitleStyle>

           <DayStyle BackColor="gray">
           </DayStyle>

           <SelectedDayStyle BackColor="LightGray"
                             Font-Bold="True">
           </SelectedDayStyle>

      </asp:Calendar>
      </div>


   </div>
     
     <div class="row">
         <div class="pull-right">
            <asp:Button ID="BtnGuardarEvento" runat="server" Text="Guardar" OnClick="BtnGuardarEvento_Click" />
        </div>
    </div>
  

  </div>

  
  


  
    </div>
</asp:Content>

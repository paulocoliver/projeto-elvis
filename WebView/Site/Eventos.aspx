<%@ Page Title="" Language="C#" MasterPageFile="~/Site/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="Trabalho.WebView.Site.Eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Site/Css/Eventos.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2> Eventos </h2>

    <% foreach(Trabalho.Types.EventoType evento in eventos){ %>
       
     <div class="box-eventos">
        <address  class="col-sm-12">
          <strong><% Response.Write(evento.Titulo); %></strong><br />
          <% Response.Write(evento.Local); %><br />
          Data: <% Response.Write(evento.dataIni + " ~ " +evento.dataEnd); %>
        </address>

        <div class="col-sm-12">
               <% Response.Write(evento.Descricao); %>
        </div>
        <div class="clearfix"></div>
    </div>
       
    <% } %>
</asp:Content>

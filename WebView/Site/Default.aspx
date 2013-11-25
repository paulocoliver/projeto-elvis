<%@ Page Title="" Language="C#" MasterPageFile="~/Site/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Trabalho.WebView.Site.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="">
        <% Response.Write(texto); %>
    </div>
</asp:Content>

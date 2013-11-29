<%@ Page ValidateRequest="false" Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="Trabalho.WebView.Painel.PaginaInicial" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/Js/ckeditor/ckeditor.js"></script>
    <script src="/Js/ckeditor/adapters/jquery.js"></script>
    <script src="/Js/PaginaInicial.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="page-header">
	    <h1>Editar Conteúdo da Página Inicial</h1>
    </div>

    <div class="form-horizontal">

        <div class="form-group">
            <div class="col-sm-12">
                <textarea id="texto" style="height: 700px; width:100%; resize:none;" name="texto" class="form-control"><% Response.Write(texto); %></textarea>
            </div>
        </div>

        <div class="clearfix"></div><br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-lg btn-primary" style="float:right;max-width:100px;" />
    </div>

</asp:Content>

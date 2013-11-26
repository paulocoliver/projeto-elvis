<%@ Page Title="Empresas" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Empresas.aspx.cs" Inherits="Trabalho.WebView.Painel.Empresas" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
	    <h1>Empresas</h1>
    </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-striped">
        <Columns>
            <asp:BoundField DataField="IdEmpresa" HeaderText="Id" />
            <asp:BoundField DataField="RazaoSocial" HeaderText="Razão Social" />
            <asp:BoundField DataField="Nome" HeaderText="Nome Fantasia" />
            <asp:BoundField DataField="DataCadastro" HeaderText="Data Cadastro" />
            <asp:BoundField DataField="DataVencimento" HeaderText="Data Vencimento" />
            <asp:HyperLinkField DataNavigateUrlFields="idEmpresa" DataNavigateUrlFormatString="Empresas_view.aspx?id={0}" DataTextField="idEmpresa" DataTextFormatString="&lt;span class=&quot;glyphicon glyphicon-zoom-in&quot;&gt;&lt;/span&gt;" HeaderText="Detalhes">
            <ControlStyle CssClass="btn btn-info" />
            <ItemStyle CssClass="text-center" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataNavigateUrlFields="idEmpresa" DataNavigateUrlFormatString="Empresas_efetuar_baixa.aspx?id={0}" DataTextField="idEmpresa" DataTextFormatString="&lt;span class=&quot;glyphicon glyphicon-download-alt&quot;&gt;&lt;/span&gt;" HeaderText="Efetuar Baixa" >
                <ControlStyle CssClass="btn btn-success" />
                <ItemStyle CssClass="text-center" />
            </asp:HyperLinkField>
        </Columns>
    </asp:GridView>
</asp:Content>

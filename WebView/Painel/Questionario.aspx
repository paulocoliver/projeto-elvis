<%@ Page Title="Questionario empresa" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Questionario.aspx.cs" Inherits="Trabalho.WebView.Empresa.Questionario" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
	    <h1>Questionário empresa <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-info" PostBackUrl="~/Painel/Questionario_add.aspx"><i class="glyphicon glyphicon-plus-sign"></i> Adicionar</asp:LinkButton></h1>
    </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-striped">
        <Columns>
            <asp:BoundField DataField="idQuestionario" HeaderText="ID" />
            <asp:BoundField DataField="descricao" HeaderText="Descrição" />
            <asp:BoundField DataField="TipoFormat" HeaderText="Tipo" />
            <asp:HyperLinkField DataNavigateUrlFields="idQuestionario" DataNavigateUrlFormatString="Questionario_add.aspx?id={0}" DataTextField="idQuestionario" DataTextFormatString="&lt;span class=&quot;glyphicon glyphicon-pencil&quot;&gt;&lt;/span&gt;" HeaderText="Editar">
            <ControlStyle CssClass="btn btn-info" />
            <ItemStyle CssClass="text-center" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataNavigateUrlFields="idQuestionario" DataNavigateUrlFormatString="Questionario_del.aspx?id={0}" DataTextField="idQuestionario" DataTextFormatString="&lt;span class=&quot;glyphicon glyphicon-trash&quot;&gt;&lt;/span&gt;" HeaderText="Apagar">
            <ControlStyle CssClass="btn btn-danger confirm-delete" />
            <ItemStyle CssClass="text-center" />
            </asp:HyperLinkField>
        </Columns>
    </asp:GridView>
</asp:Content>
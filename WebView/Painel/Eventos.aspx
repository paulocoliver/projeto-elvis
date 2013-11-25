<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="WebView.Painel.Eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="page-header">
	    <h1>Eventos Associação <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-info" PostBackUrl="~/Painel/Eventos_add.aspx"><i class="glyphicon glyphicon-plus-sign"></i> Adicionar</asp:LinkButton></h1>
    </div>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="table table-striped table-striped">
         <Columns>
             <asp:BoundField DataField="idEvento" HeaderText="Código" SortExpression="idEvento" />
             <asp:BoundField DataField="Titulo" HeaderText="Título" SortExpression="Titulo" />
             <asp:BoundField DataField="Local" HeaderText="Local" SortExpression="Local" />
             <asp:BoundField DataField="dataIni" HeaderText="Inicio" SortExpression="dataIni" />
             <asp:BoundField DataField="dataEnd" HeaderText="Fm" SortExpression="dataEnd" />
             <asp:HyperLinkField DataNavigateUrlFields="idEvento" DataNavigateUrlFormatString="Eventos_add.aspx?id={0}" DataTextField="idEvento" DataTextFormatString="&lt;span class=&quot;glyphicon glyphicon-pencil&quot;&gt;&lt;/span&gt;" HeaderText="Editar">
                <ControlStyle CssClass="btn btn-info" />
                <ItemStyle CssClass="text-center" />
             </asp:HyperLinkField>
             <asp:HyperLinkField DataNavigateUrlFields="idEvento" DataNavigateUrlFormatString="Eventos_del.aspx?id={0}" DataTextField="idEvento" DataTextFormatString="&lt;span class=&quot;glyphicon glyphicon-trash&quot;&gt;&lt;/span&gt;" HeaderText="Apagar">
                <ControlStyle CssClass="btn btn-danger confirm-delete" />
                <ItemStyle CssClass="text-center" />
             </asp:HyperLinkField>
         </Columns>
     </asp:GridView>
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="select" TypeName="Trabalho.DAL_MYSQL.EventoDAL">
         <SelectParameters>
             <asp:SessionParameter DefaultValue="1" Name="idAssociacao" SessionField="idAssociacao" Type="Int32" />
         </SelectParameters>
     </asp:ObjectDataSource>
    <br />
</asp:Content>

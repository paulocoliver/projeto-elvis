<%@ Page Title="" Language="C#" MasterPageFile="~/Painel-Empresa/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="Trabalho.WebView.Painel_Empresa.Pagamento" %>
<%@ MasterType VirtualPath="~/Painel-Empresa/Layout/Layout.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="page-header">
	    <h1>Meus Pagamentos <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-info" PostBackUrl="~/Painel-Empresa/Efetuar_Pagamento.aspx"><i class="glyphicon glyphicon-plus-sign"></i> Efetuar Pagamento</asp:LinkButton>
          
        </h1>

        <div id="expira">
            <label for="">Tempo Restante : </label>
            <asp:Label ID="lbExpira" runat="server"></asp:Label>   
        </div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="table table-striped table-striped">
            <Columns>
                <asp:BoundField DataField="IdPagamento" HeaderText="Código" SortExpression="IdPagamento" />
                <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                <asp:BoundField DataField="Data" HeaderText="Data" SortExpression="Data" />
            </Columns>
        </asp:GridView>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Trabalho.Types.PagamentoType" DeleteMethod="delete" InsertMethod="insert" SelectMethod="select" TypeName="Trabalho.DAL_MYSQL.PagamentoDAL" UpdateMethod="update">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="7" Name="idEmpresa" SessionField="idEmpresa" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
         
    </div>
</asp:Content>

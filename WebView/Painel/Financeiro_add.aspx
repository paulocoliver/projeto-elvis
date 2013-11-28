<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Financeiro_add.aspx.cs" Inherits="Trabalho.WebView.Painel.Financeiro_add" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
	    <h1><%= _TitlePage %></h1>
    </div>

    <div class="form-horizontal">
        <div class="form-group">
            <label class="col-sm-2 control-label">Descrição</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtTitulo" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Valor</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtValor" runat="server" class="form-control mask-money" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Data</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtData" type="date" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Tipo</label>
            <div class="col-sm-5">
                <asp:RadioButtonList ID="RdoTipo" runat="server">
                    <asp:ListItem Value="receita" Selected="True"> Receita</asp:ListItem>
                    <asp:ListItem Value="despesa"> Despesa</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-2">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-info" OnClick="btnSalvar_Click" />
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(function() {
            $(".mask-money").maskMoney({ thousands: '', decimal: ',' });
        });
    </script>

</asp:Content>

<%@ Page Title="Financeiro" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Financeiro.aspx.cs" Inherits="Trabalho.WebView.Painel.Financeiro" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="page-header">
	    <h1>Financeiro</h1>
    </div>

    <div class="well" postbackurl="Financeiro.aspx">
            <label class="col-sm-2">Mês</label>
            <div class="col-sm-3">
                <asp:DropDownList ID="cmb_mes" runat="server">
                    <asp:ListItem Value="01">Janeiro</asp:ListItem>
                    <asp:ListItem Value="02">Fevereiro</asp:ListItem>
                    <asp:ListItem Value="03">Março</asp:ListItem>
                    <asp:ListItem Value="04">Abril</asp:ListItem>
                    <asp:ListItem Value="05">Maio</asp:ListItem>
                    <asp:ListItem Value="06">Junho</asp:ListItem>
                    <asp:ListItem Value="07">Julho</asp:ListItem>
                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                    <asp:ListItem Value="09">Setembro</asp:ListItem>
                    <asp:ListItem Value="10">Outubro</asp:ListItem>
                    <asp:ListItem Value="11">Novembro</asp:ListItem>
                    <asp:ListItem Value="12">Dezembro</asp:ListItem>
                </asp:DropDownList>
            </div>
            <label class="col-sm-2">Ano</label>
            <div class="col-sm-3">
                <asp:DropDownList ID="cmb_ano" runat="server">
                    <asp:ListItem Value="2013">2013</asp:ListItem>
                    <asp:ListItem Value="2014">2014</asp:ListItem>
                    <asp:ListItem Value="2015">2015</asp:ListItem>
                    <asp:ListItem Value="2016">2016</asp:ListItem>
                </asp:DropDownList>
            </div>
        <div class="col-sm-2">
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>

    </div>

    
    <table class="table table-striped table-striped">
        <tr>
            <th>Descrição</th>
            <th>Data</th>
            <th>Valor (R$)</th>
        </tr>
        <tr>
            <td colspan="2" class="text-right">Saldo do mês anterior</td>
            <td>
                <%
                string labelTipo = "success";
                if (saldoAnterior < 0)
                        labelTipo = "danger";    
                %>
                <strong class="label label-<%= labelTipo %>"><%= saldoAnterior %></strong>
            </td>
        </tr>
        <%
        foreach (Trabalho.Types.FinanceiroType res in DadosFinanceiros)
        {
            labelTipo = "success";
            if (res.Tipo == "despesa")
                labelTipo = "danger";

            saldoAnterior = saldoAnterior + res.Valor;
        %>
        <tr>
            <td><%= res.Titulo %></td>
            <td><%= res.DataFormat %></td>
            <td>
                <span class="label label-<%= labelTipo %>"><%= res.Valor.ToString() %></span>
            </td>
        </tr>
        <%
        }
        %>

        <tr>
            <td colspan="2" class="text-right">Saldo do mês</td>
            <td>
                <%
                labelTipo = "success";
                if (saldoAnterior < 0)
                        labelTipo = "danger";    
                %>
                <strong class="label label-<%= labelTipo %>"><%= saldoAnterior %></strong>
            </td>
        </tr>
    </table>

</asp:Content>

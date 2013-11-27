<%@ Page Title="Financeiro" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Financeiro.aspx.cs" Inherits="Trabalho.WebView.Painel.Financeiro" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="page-header">
	    <h1>Financeiro</h1>
    </div>

    <div class="form-inline" style="margin-bottom:20px;">
        <div class="form-group">
            <label for="cmb_mes">Mês</label>
            <asp:DropDownList ID="cmb_mes" runat="server" CssClass="form-control" Width="150px">
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
        <div class="form-group">
            <label for="cmb_ano">Ano</label>
            <asp:DropDownList ID="cmb_ano" runat="server" CssClass="form-control" Width="120px">
                <asp:ListItem Value="2013">2013</asp:ListItem>
                <asp:ListItem Value="2014">2014</asp:ListItem>
                <asp:ListItem Value="2015">2015</asp:ListItem>
                <asp:ListItem Value="2016">2016</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button1" runat="server" Text="OK" CssClass="btn btn-info" PostBackUrl="~/Painel/Financeiro.aspx" Width="100px" />
       
        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-info pull-right" PostBackUrl="~/Painel/Financeiro_add.aspx"><i class="glyphicon glyphicon-plus-sign"></i> Adicionar</asp:LinkButton>
    </div>

    
    <table class="table table-striped table-striped">
        <tr>
            <th>Descrição</th>
            <th>Data</th>
            <th>Valor (R$)</th>
            <th style="width: 100px;"></th>
        </tr>
        <tr>
            <td colspan="2" class="text-right">Saldo do mês anterior</td>
            <td  colspan="2">
                <%
                string labelTipo = "default";
                if (saldoAnterior < 0)
                    labelTipo = "danger";
                else if(saldoAnterior > 0)
                    labelTipo = "success";
                %>
                <strong class="label label-<%= labelTipo %>"><%= saldoAnterior.ToString("00.00") %></strong>
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
            <td><%= res.Data %></td>
            <td>
                <span class="label label-<%= labelTipo %>"><%= res.Valor.ToString("00.00") %></span>
            </td>
            <td class="text-center">
                <a href="Financeiro_add.aspx?id=<%= res.IdFinanceiro %>" class="btn btn-info"><i class="glyphicon glyphicon-pencil"></i></a>
                <a href="Financeiro_del.aspx?id=<%= res.IdFinanceiro %>" class="btn btn-danger confirm-delete"><i class="glyphicon glyphicon-trash"></i></a>
            </td>
        </tr>
        <%
        }
        %>

        <tr>
            <td colspan="2" class="text-right">Saldo do mês</td>
            <td>
                <%
                labelTipo = "default";
                if (saldoAnterior < 0)
                    labelTipo = "danger";
                else if (saldoAnterior > 0)
                    labelTipo = "success";  
                %>
                <strong class="label label-<%= labelTipo %>"><%= saldoAnterior.ToString("00.00") %></strong>
            </td>
           
        </tr>
    </table>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Empresas_view.aspx.cs" Inherits="Trabalho.WebView.Painel.Empresas_view" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-info" PostBackUrl="~/Painel/Empresas.aspx"><i class="glyphicon glyphicon-arrow-left"></i> Voltar</asp:LinkButton>
        <br />
	    <h1>Detalhes da Empresa</h1>
    </div>

    <div class="form-horizontal">
        <div class="form-group">
            <label class="col-sm-2 control-label">ID</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.IdAssociacao %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Razão Social</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.RazaoSocial %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Nome Fantasia</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.Nome %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">CNPJ</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.CNPJ %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">IE</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.IE %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">CEP</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.CEP %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Endereço</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.Endereco %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Complemento</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.Complemento %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Email</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.Email %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Site</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.Site %></p>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Data Cadastro</label>
            <div class="col-sm-10">
                <p class="form-control-static"><%= DadosEmpresa.DataCadastro %></p>
            </div>
        </div>
    </div>

    <div class="page-header">
        <h1><small>Respostas do questionário </small></h1>
    </div>

    <%
    /*foreach (Trabalho.Types.QuestionarioRespostaType resposta in RespostasQuestionario)
    {
    
    <div class="panel panel-default">
        <div class="panel-heading">
          <h3 class="panel-title"><%= resposta.Pergunta </h3>
        </div>
        <div class="panel-body">
          <%= resposta.Resposta.Replace("\n", "<br />") 
        </div>
      </div>
    
    }*/
    %>


</asp:Content>

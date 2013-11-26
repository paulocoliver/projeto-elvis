<%@ Page Language="C#"  MasterPageFile="~/Site/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Trabalho.WebView.Site.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login Empresa</title>
    <link rel="stylesheet" href="http://netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="/Site/Css/Login.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
          <div class="form-signin">
            <h2 class="form-signin-heading">Login Empresa</h2>
        
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" class="form-control" placeholder="Senha" TextMode="Password"></asp:TextBox>
            <br />        
            <asp:Button ID="BtnEntrar" runat="server" Text="Entrar" class="btn btn-lg btn-primary btn-block" OnClick="BtnEntrar_Click"/>
            <br />
            <a href="Cadastrar.aspx">Cadastrar Empresa</a>
        </div>
    </div>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="http://netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</asp:Content>
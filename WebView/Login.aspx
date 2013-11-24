<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Trabalho.WebView.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Associação</title>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="Css/Login.css"/>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="form-signin">
            <h2 class="form-signin-heading">Login Associação</h2>
        
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" class="form-control" placeholder="Senha" TextMode="Password"></asp:TextBox>
            <br />        
            <asp:Button ID="BtnEntrar" runat="server" Text="Entrar" class="btn btn-lg btn-primary btn-block" OnClick="BtnEntrar_Click"/>
            <br />
            <a href="Cadastro.aspx">Cadastrar Associação</a>
        </form>
    </div>

    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>

</body>
</html>

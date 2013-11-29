<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Trabalho.WebView.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Associação</title>
    <link type="text/css" rel="stylesheet" href="../bootstrap/css/bootstrap.min.css"/> 
    <link rel="stylesheet" href="Css/Login.css"/>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="form-signin validateForm">
            <h2 class="form-signin-heading">Login Associação</h2>
        
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Usuario" required="required"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" class="form-control" placeholder="Senha" TextMode="Password" required="required"></asp:TextBox>
            <br />        
            <asp:Button ID="BtnEntrar" runat="server" Text="Entrar" class="btn btn-lg btn-primary btn-block" OnClick="BtnEntrar_Click"/>
            <br />
            <a href="Cadastro.aspx">Cadastrar Associação</a>
        </form>
    </div>

    <script type="text/javascript" src="../Js/jQuery-1.9.1.js"></script>
    <script type="text/javascript" src="../bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="../Js/validation/jquery.validate.js"></script>
    <script type="text/javascript" src="../Js/validation/localization/messages_pt_BR.js"></script>
    <script type="text/javascript">
    $(".validateForm").validate();
    </script>
</body>
</html>

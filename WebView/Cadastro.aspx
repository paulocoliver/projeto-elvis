<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Trabalho.WebView.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Associação</title>
    <link type="text/css" rel="stylesheet" href="../bootstrap/css/bootstrap.min.css"/> 
    <link rel="stylesheet" href="Css/Login.css"/>
</head>
<body>
   <div class="container">
        <form id="form1" runat="server" class="form-signin validateForm">
            <h2 class="form-signin-heading">Cadastrar Associação</h2>
            <asp:TextBox ID="txtNome" runat="server" class="form-control" placeholder="Nome da Associação" required="required"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtUrl" runat="server" class="form-control" placeholder="URL" required="required"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Usuario" required="required"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" class="form-control" placeholder="Senha" required="required"></asp:TextBox>
            <br />        
            <asp:Button ID="BtnEntrar" runat="server" Text="Salvar" class="btn btn-lg btn-primary btn-block" OnClick="BtnEntrar_Click"/>
            <br />
            <a href="Login.aspx">Login Associação</a>
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

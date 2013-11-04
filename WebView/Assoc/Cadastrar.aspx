<%@ Page Title="" Language="C#" MasterPageFile="~/Assoc/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="Trabalho.WebView.Assoc.Cadastrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <link href="/Assoc/Css/Cadastro.css" rel="stylesheet"/>
   <link href="/Assoc/Js/select2/select2.css" rel="stylesheet"/>

   <script type="text/javascript" src="/Assoc/Js/select2/select2.js"></script>
   <script type="text/javascript" src="/Assoc/Js/Cadastrar.js"></script>

</asp:Content>

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="form-cadastro">

        <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbSenha" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" pattern="[\w\d]{6,20}" title="Formato: 6-20 caracteres números e/ou letras." maxlength="20" type="password" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbRazaoSocial" runat="server" Text="Razão Social"></asp:Label>
        <asp:TextBox ID="txtRazaoSocial" runat="server" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbCNPJ" runat="server" Text="CNPJ"></asp:Label>
        <asp:TextBox ID="txtCNPJ" runat="server" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbIE" runat="server" Text="IE"></asp:Label>
        <asp:TextBox ID="txtIE" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lbCEP" runat="server" Text="CEP"></asp:Label>
        <asp:TextBox ID="txtCEP" runat="server" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbPais" runat="server" Text="Pais"></asp:Label>
        <asp:DropDownList ID="selectPais" runat="server"></asp:DropDownList>

        <asp:Label ID="lbEstado" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="txtEstado" runat="server" required="required"></asp:TextBox>

        <asp:Label ID="lbCidade" runat="server" Text="Cidade"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server" required="required"></asp:TextBox>
        <br />

        <asp:Label ID="lbEndereco" runat="server" Text="Endereco"></asp:Label>
        <asp:TextBox ID="txtEndereco" runat="server" required="required"></asp:TextBox>
        <br />
        
        <asp:Label ID="lbComplemento" runat="server" Text="Complemento"></asp:Label>
        <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lbSite" runat="server" Text="Site"></asp:Label>
        <asp:TextBox ID="txtSite" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lbLogo" runat="server" Text="Logo"></asp:Label>
        <asp:FileUpload ID="Logo" runat="server" />
        <br />

        <input id="Submit1" type="submit" value="submit" /><br />
    </div>
</asp:Content>

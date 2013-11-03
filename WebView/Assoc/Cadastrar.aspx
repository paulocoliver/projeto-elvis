<%@ Page Title="" Language="C#" MasterPageFile="~/Assoc/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="WebView.Assoc.Cadastrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        @import '/Assoc/Css/Cadastro.css';
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="form-cadastro">
        <asp:Label ID="lbRazaoSocial" runat="server" Text="Razão Social"></asp:Label>
        <input id="txtRazaoSocial" type="text" required="required" />
        <br />

        <asp:Label ID="lbNome" runat="server" Text="Nome"></asp:Label>
        <input id="txtNome" type="text" required="required" />
        <br />

        <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
        <input id="txtEmail" type="text" required="required" />
        <br />

        <asp:Label ID="lbCNPJ" runat="server" Text="CNPJ"></asp:Label>
        <input id="txtCNPJ" type="text" required="required" />
        <br />

        <asp:Label ID="lbIE" runat="server" Text="IE"></asp:Label>
        <input id="txtIE" type="text" />
        <br />

        <asp:Label ID="lbCEP" runat="server" Text="CEP"></asp:Label>
        <input id="txtCEP" type="text" required="required" />
        <br />

        <asp:Label ID="lbPais" runat="server" Text="Pais"></asp:Label>
        <input id="txtPais" type="text" required="required" />
        
        <asp:Label ID="lbEstado" runat="server" Text="Estado"></asp:Label>
        <input id="txtEstado" type="text" required="required" />

        <asp:Label ID="lbCidade" runat="server" Text="Cidade"></asp:Label>
        <input id="txtCidade" type="text" required="required" />
        <br />

        <asp:Label ID="lbEndereco" runat="server" Text="Endereco"></asp:Label>
        <input id="txtEndereco" type="text" required="required" />
        <br />
        
        <asp:Label ID="lbComplemento" runat="server" Text="Complemento"></asp:Label>
        <input id="txtComplemento" type="text" />
        <br />

        <asp:Label ID="lbSite" runat="server" Text="Site"></asp:Label>
        <input id="txtSite" type="text" />
        <br />

        <asp:Label ID="lbLogo" runat="server" Text="Logo"></asp:Label>
        <input id="Logo" type="file" />
        <br />

        <input id="Submit1" type="submit" value="submit" /><br />
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Painel-Empresa/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Informacoes-basicas.aspx.cs" Inherits="Trabalho.WebView.Painel_Empresa.Informacoes_basicas" %>
<%@ MasterType VirtualPath="~/Painel-Empresa/Layout/Layout.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <link href="/Site/Css/Cadastro.css" rel="stylesheet"/>
   <link href="/Site/Js/select2/select2.css" rel="stylesheet"/>

   <script type="text/javascript" src="/Site/Js/select2/select2.js"></script>
   <script type="text/javascript" src="/Site/Js/Cadastrar.js"></script>

</asp:Content>

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="form-signup">
            <h2 class="form-signin-heading">Informações Básicas</h2>

            <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox class="form-control" ID="txtEmail" type="email" runat="server" required="required"></asp:TextBox>
            <br />

            <asp:Label ID="lbRazaoSocial" runat="server" Text="Razão Social"></asp:Label>
            <asp:TextBox class="form-control" ID="txtRazaoSocial" runat="server" required="required"></asp:TextBox>
            <br />

            <asp:Label ID="lbNome" runat="server" Text="Nome Fantasia"></asp:Label>
            <asp:TextBox class="form-control" ID="txtNome" runat="server" required="required"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />

            <asp:Label ID="lbCNPJ" runat="server" Text="CNPJ"></asp:Label>
            <asp:TextBox class="form-control" ID="txtCNPJ" runat="server" pattern="[\w]{2}\.[\w]{2}\.[\w]{3}\/[\w]{4}-[\w]{2}" title="Formato: 11.11.111/1111-11" required="required"></asp:TextBox>
            <br />

            <asp:Label ID="lbIE" runat="server" Text="IE"></asp:Label>
            <asp:TextBox class="form-control" ID="txtIE" runat="server" pattern="[\w]{3}\.[\w]{3}\.[\w]{3}\.[\w]{3}"></asp:TextBox>
            <br />

            <asp:Label ID="lbPais" runat="server" Text="Pais"></asp:Label>
            <asp:DropDownList  ID="selectPais" runat="server"></asp:DropDownList>

            <asp:Label ID="lbEstado" runat="server" Text="Estado"></asp:Label>
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>

            <asp:Label ID="lbCidade" runat="server" Text="Cidade"></asp:Label>
            <asp:TextBox  ID="txtCidade" runat="server"></asp:TextBox>
            <br />

            <div class="clearfix" style="margin-bottom:10px"></div>

            <asp:Label ID="lbEndereco" runat="server" Text="Endereco"></asp:Label>
            <asp:TextBox class="form-control" ID="txtEndereco" runat="server" required="required"></asp:TextBox>
            <br />
        
            <asp:Label ID="lbCEP" runat="server" Text="CEP"></asp:Label>
            <asp:TextBox class="form-control" ID="txtCEP" runat="server" pattern="[\w]{2}\.[\w]{3}-[\w]{3}" required="required"></asp:TextBox>
            <br />

            <asp:Label ID="lbComplemento" runat="server" Text="Complemento"></asp:Label>
            <asp:TextBox class="form-control" ID="txtComplemento" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lbSite" runat="server" Text="Site"></asp:Label>
            <asp:TextBox class="form-control" ID="txtSite" runat="server"></asp:TextBox>
            <br />
       
            <input id="Submit1" type="submit" value="submit"  class="btn btn-lg btn-primary"  style="float:right"/>
            <div class="clearfix"></div><br />
        </div>
      
    </div>
</asp:Content>

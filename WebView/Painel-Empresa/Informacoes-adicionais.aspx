<%@ Page Title="" Language="C#" MasterPageFile="~/Painel-Empresa/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Informacoes-adicionais.aspx.cs" Inherits="Trabalho.WebView.Painel_Empresa.Questionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Painel-Empresa/Css/Questionario.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="form-horizontal" style="max-width:670px">
            <h2 class="form-signin-heading">Informações Adicionais</h2>
            <% foreach (Trabalho.Types.QuestionarioType questionario in questionarios) {
                 switch(questionario.TipoFormat){             
                     case "Select" :
                         createSelect(questionario);
                     break;
                  
                     default :
                        createInput(questionario);
                     break;         
                 }
                 Response.Write("<br />");
            }%>

            <input id="Submit1" type="submit" value="submit"  class="btn btn-lg btn-primary"  style="float:right"/>
            <div class="clearfix"></div><br />
        </div>
    </div>
</asp:Content>

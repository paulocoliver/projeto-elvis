<%@ Page  ValidateRequest="false" Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Eventos_add.aspx.cs" Inherits="Trabalho.WebView.Painel.Eventos_add" %>
<%@ MasterType VirtualPath="~/Layout/Layout.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="/Js/ckeditor/ckeditor.js"></script>
    <script src="/Js/ckeditor/adapters/jquery.js"></script>
    <script src="/Js/Evento.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
	    <h1>Adicionar Evento</h1>
    </div>

     <div class="form-horizontal">

        <div class="form-group">
            <label class="col-sm-2 control-label">Título</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTitulo" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>

         <div class="form-group">
            <label class="col-sm-2 control-label">Descrição</label>
            <div class="col-sm-10">
                <textarea id="Descricao" style="height: 300px; resize:none;"cols="20" name="descricao" class="form-control"><% Response.Write(_Descricao); %></textarea>
            </div>
        </div>

        <div class="form-group">
            <label class="col-sm-2 control-label">Local</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtLocal" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>

         <div class="form-group form-inline">
           
              <label class="control-label col-sm-2">Data Início</label>
              <div class="col-sm-3" >
                    <asp:TextBox ID="txtDataInicio" type="datetime-local" runat="server" class="form-control" ></asp:TextBox>
              </div>
          
              <label class="control-label col-sm-2">Data Termino</label>
              <div class="col-sm-3">
                    <asp:TextBox ID="txtDataFim" type="datetime-local" runat="server" class="form-control" ></asp:TextBox>
              </div>
        </div>
        <div class="clearfix"></div>
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-lg btn-primary" style="float:right;max-width:100px;" OnClick="btnSalvar_Click" />

    </div>
</asp:Content>

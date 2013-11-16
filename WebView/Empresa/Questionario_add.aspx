<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Questionario_add.aspx.cs" Inherits="Trabalho.WebView.Empresa.Questionario_add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
	    <h1>Adicionar questão</h1>
    </div>

    <div class="form-horizontal">
        <div class="form-group">
            <label class="col-sm-2 control-label">Titulo</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtPergunta" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Tipo</label>
            <div class="col-sm-10 controls">
                <asp:DropDownList ID="cmb_tipo" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Text_N">Text</asp:ListItem>
                    <asp:ListItem Value="Password_N">Password</asp:ListItem>
                    <asp:ListItem Value="Select_S">Select</asp:ListItem>
                    <asp:ListItem Value="Checkbox_S">Checkbox</asp:ListItem>
                    <asp:ListItem Value="Radio_S">Radio</asp:ListItem>
                    <asp:ListItem Value="Email_N">Email</asp:ListItem>
                    <asp:ListItem Value="URL_N">URL</asp:ListItem>
                    <asp:ListItem Value="File_N">File</asp:ListItem>
                    <asp:ListItem Value="Date_N">Date</asp:ListItem>
                    <asp:ListItem Value="Time_N">Time</asp:ListItem>
                    <asp:ListItem Value="Color_N">Color</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <fieldset style="display: none;">
		    <legend>Opções  <button id="add-option" class="btn btn-info btn-xs" type="button"><i class="glyphicon glyphicon-plus-sign"></i> Adicionar</button></legend>
		    <div id="box_opcoes">
            <%
            foreach (Trabalho.Types.QuestionarioOpcaoType questaoRow in OpcoesQuestionario)
            {
            %>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Opção</label>
                    <div class="col-sm-6">
                        <div class="input-group">
                            <input type="text" name="options[]" value="<%= questaoRow.Descricao %>" class="form-control"/>
                            <span class="input-group-btn">
                                 <button class="btn btn-danger remove-option" type="button"><i class="glyphicon glyphicon-minus-sign"></i></button>
                            </span>
                        </div>
                    </div>
                </div>
            <%
            }
            %>
            </div>
	    </fieldset>

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-info" OnClick="btnSalvar_Click" />
            </div>
        </div>

    </div>

    <script type="text/javascript">
        var pergunta_tipo = $("#ContentPlaceHolder1_cmb_tipo");
        function has_options() {
            var valor = pergunta_tipo.val();
            valor = valor.split("_");
            var id = valor[0];
            var option = valor[1];

            if (option == 'S') {
                $("#box_opcoes").parent().css("display", "block");
            } else {
                $("#box_opcoes").parent().css("display", "none");
            }
        }
        pergunta_tipo.on("change", function () {
            has_options();
        });
        has_options();

        $("#add-option").on("click", function () {
            $("#box_opcoes").append('<div class="form-group"><label class="col-sm-2 control-label">Opção</label><div class="col-sm-6"><div class="input-group"><input type="text" name="options[]" value="" class="form-control"/><span class="input-group-btn"><button class="btn btn-danger remove-option" type="button"><i class="glyphicon glyphicon-minus-sign"></i></button></span></div></div></div>');
        });
        $("#box_opcoes").on("click", ".remove-option", function () {
            $(this).closest('.form-group').remove();
        });

    </script>

</asp:Content>

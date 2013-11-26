<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Efetuar_Pagamento.aspx.cs" Inherits="Trabalho.WebView.Painel_Empresa.Efetuar_Pagamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">

        window.onload = function () {
            document.getElementById("form1").submit();
        };
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="application/x-www-form-urlencoded" action="https://www.paypal.com/cgi-bin/webscr" method="post">
        
        <dt id="cmd-label">&nbsp;</dt>
        <dd id="cmd-element">
            <input type="hidden" name="cmd" value="_xclick-subscriptions" id="cmd">
        </dd>

        <dt id="charset-label">&nbsp;</dt>
        <dd id="charset-element">
            <input type="hidden" name="charset" value="utf-8" id="charset">
        </dd>

        <dt id="url-label">&nbsp;</dt>
        <dd id="url-element">
            <input type="hidden" name="url" value="https://www.paypal.com/cgi-bin/webscr" id="url">
        </dd>

        <dt id="business-label">&nbsp;</dt>
        <dd id="business-element">
            <input type="hidden" name="business" value="ro.damascenoo-facilitator@gmail.com" id="business">
        </dd>

        <dt id="lc-label">&nbsp;</dt>
        <dd id="lc-element">
            <input type="hidden" name="lc" value="EN" id="lc">
        </dd>

        <dt id="item_name-label">&nbsp;</dt>
        <dd id="item_name-element">
            <input type="hidden" name="item_name" value="mensalidade" id="item_name">
        </dd>

        <dt id="item_number-label">&nbsp;</dt>
        <dd id="item_number-element">
            <input type="hidden" name="item_number" value="1" id="item_number">
        </dd>

        <dt id="no_note-label">&nbsp;</dt>
        <dd id="no_note-element">
            <input type="hidden" name="no_note" value="1" id="no_note">
        </dd>

        <dt id="src-label">&nbsp;</dt>
        <dd id="src-element">
            <input type="hidden" name="src" value="1" id="src">
        </dd>

        <dt id="a1-label">&nbsp;</dt>
        <dd id="a1-element">
            <input type="hidden" name="a1" value="10" id="a1">
        </dd>

        <dt id="p1-label">&nbsp;</dt>
        <dd id="p1-element">
            <input type="hidden" name="p1" value="1" id="p1">
        </dd>

        <dt id="t1-label">&nbsp;</dt>
        <dd id="t1-element">
            <input type="hidden" name="t1" value="M" id="t1">
        </dd>

        <dt id="a3-label">&nbsp;</dt>
        <dd id="a3-element">
            <input type="hidden" name="a3" value="10" id="a3">
        </dd>

        <dt id="p3-label">&nbsp;</dt>
        <dd id="p3-element">
            <input type="hidden" name="p3" value="1" id="p3">
        </dd>

        <dt id="t3-label">&nbsp;</dt>
        <dd id="t3-element">
            <input type="hidden" name="t3" value="M" id="t3">
        </dd>

        <dt id="currency_code-label">&nbsp;</dt>
        <dd id="currency_code-element">
            <input type="hidden" name="currency_code" value="USD" id="currency_code">
        </dd>

        <dt id="bn-label">&nbsp;</dt>
        <dd id="bn-element">
            <input type="hidden" name="bn" value="PP-SubscriptionsBF:btn_subscribeCC_LG.gif:NonHostedGuest" id="bn">
        </dd>

    </form>
</body>
</html>

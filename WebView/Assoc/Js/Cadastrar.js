function estadoFormatResult(estado) {
    var markup = "<table class='movie-result'><tr><td class='movie-info'>";
    markup += "<div class='movie-title'>" + estado.Descricao + "</div>";
    markup += "</td></tr></table>"
    return markup;
}
function estadoFormatSelection(estado) {
    return estado.Descricao;
}

function cidadeFormatResult(cidade) {
    var markup = "<table class='movie-result'><tr><td class='movie-info'>";
    markup += "<div class='movie-title'>" + cidade.Descricao + "</div>";
    markup += "</td></tr></table>"
    return markup;
}
function cidadeFormatSelection(cidade) {
    return cidade.Descricao;
}

$(document).ready(function () {
       
    $("#ContentPlaceHolder1_txtCNPJ").mask("99.99.999/9999-99");
    $("#ContentPlaceHolder1_txtIE").mask("999.999.999.999"); 
    $("#ContentPlaceHolder1_txtCEP").mask("999.999.999.999");

    $("#ContentPlaceHolder1_selectPais").select2({
        placeHolder: "Selecione o Pais",
    }).on("select2-selecting", function (e) {
        var idPais = e.val;
        
        if (idPais !== "") {
            $.ajax({
                type: "GET",
                url: "/Assoc/Ajax/buscar-estados.ashx?id=" + idPais,
                dataType: "json"
            }).done(function (json) {
                
                if (json.Success == true) {
                    
                    $("#ContentPlaceHolder1_txtEstado").select2({
                        data: json.Estados,
                        placeHolder: "Selecione o Estado",
                        id: "idEstado",
                        formatResult: estadoFormatResult,
                        formatSelection: estadoFormatSelection
                    });
                    selectCidade([]);

                    if (json.Estados.length) {
                        $("#ContentPlaceHolder1_txtEstado").select2("open");
                    }
                }
                if (json.Msg)
                    alert(json.msg);
            });
        }
    });
   
    
    $("#ContentPlaceHolder1_txtEstado").select2({
        data: [],
        placeHolder: "Selecione o Estado",
        id : "idEstado",
        formatResult: estadoFormatResult,
        formatSelection: estadoFormatSelection
    }).on("select2-selecting", function (e) {

        $.ajax({
            type: "GET",
            url: "/Assoc/Ajax/Buscar-Cidades.ashx?id=" + e.val,
            dataType: "json"
        }).done(function (json) {

            if (json.Success == true) {
                
                selectCidade(json.Cidades);
                if (json.Cidades.length) {
                    $("#ContentPlaceHolder1_txtCidade").select2("open");
                }
            }
            if (json.Msg)
                alert(json.msg);
        });
    });

    function selectCidade(data) {
        $("#ContentPlaceHolder1_txtCidade").select2({
            data: data,
            placeHolder: "Selecione a Cidade",
            id: "idCidade",
            formatResult: cidadeFormatResult,
            formatSelection: cidadeFormatSelection
        });
    }
    selectCidade([]);
});
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
       
    var id_pais    = $("#ContentPlaceHolder1_selectPais").val();
    var id_estado = $("#ContentPlaceHolder1_txtEstado").val();
    var id_cidade = $("#ContentPlaceHolder1_txtCidade").val();

    $("#ContentPlaceHolder1_txtCNPJ").mask("99.99.999/9999-99");
    $("#ContentPlaceHolder1_txtIE").mask("999.999.999.999"); 
    $("#ContentPlaceHolder1_txtCEP").mask("99.999-999");

    $("#ContentPlaceHolder1_selectPais").select2({
        placeHolder: "Selecione o Pais",
    }).on("select2-selecting", function (e) {
        carregarEstados(e.val)
    });
    
    $("#ContentPlaceHolder1_txtEstado").select2({
        data: [],
        placeHolder: "Selecione o Estado",
        id : "idEstado",
        formatResult: estadoFormatResult,
        formatSelection: estadoFormatSelection
    }).on("select2-selecting", function (e) {
        carregarCidades(e.val);
    });

    function createCidade( data ) {
        $("#ContentPlaceHolder1_txtCidade").select2({
            data: data,
            placeHolder: "Selecione a Cidade",
            id: "idCidade",
            formatResult: cidadeFormatResult,
            formatSelection: cidadeFormatSelection
        });
    }
    createCidade([]);

    function carregarEstados(idPais, idEstado) {
        if (idPais !== "") {
            $.ajax({
                type: "GET",
                url: "/Site/Ajax/buscar-estados.ashx?id=" + idPais,
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
                    createCidade([]);

                    if (json.Estados.length && !idEstado) {
                        $("#ContentPlaceHolder1_txtEstado").select2("open");
                    }
                }
                if (json.Msg)
                    alert(json.msg);
            });
        }
    }
    function carregarCidades(idEstado, idCidade) {
        $.ajax({
            type: "GET",
            url: "/Site/Ajax/Buscar-Cidades.ashx?id=" + idEstado,
            dataType: "json"
        }).done(function (json) {

            if (json.Success == true) {
                createCidade(json.Cidades);
                if (json.Cidades.length && !idCidade) {
                    $("#ContentPlaceHolder1_txtCidade").select2("open");
                }
            }
            if (json.Msg)
                alert(json.msg);
        });
    }

    if (id_pais) {
        carregarEstados(id_pais, id_estado)
    }
    if (id_estado) {
        carregarCidades(id_estado, id_cidade);
    }
});
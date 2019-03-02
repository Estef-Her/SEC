$(function () {

    $("#form1").validate({
        rules: {
            campoTextoCapital: { number: true },
            campoTextoNacimiento: { number: true },
            campoTextoTasa: { number: true }
        },
        messages: {
            'campoTextoCapital': {
                number: jQuery('.input_txtCapital').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 48 || tecla.charCode > 57) return false;
                })
            },
            'campoTextoTasa': {
                number: jQuery('.input_txtTasa').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 46 || tecla.charCode > 57 || tecla.charCode==47) return false;
                })
            },
        }
    });
});
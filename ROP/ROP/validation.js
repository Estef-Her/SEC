$(function () {

    $("#form1").validate({
        rules: {
            txtCapital: { number: true },
            txtNacim: { number: true },
            txtTasa: { number: true }
        },
        messages: {
            'txtCapital': {
                number: jQuery('.input_txtCapital').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 48 || tecla.charCode > 57) return false;
                })
            },
            'txtNacim': {
                number: jQuery('.input_txtNacim').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 47 || tecla.charCode > 57) return false;
                })
            },
            'txtTasa': {
                number: jQuery('.input_txtTasa').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 46 || tecla.charCode > 57 || tecla.charCode==47) return false;
                })
            },
        }
    });
});
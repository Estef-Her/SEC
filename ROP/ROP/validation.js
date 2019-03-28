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
                    if (31 < tecla.charCode && tecla.charCode < 44 || 44 < tecla.charCode && tecla.charCode < 48 || tecla.charCode > 57) return false;
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

$(function () {
    $("#form1").validate({
        rules: {
            rendimiento1: { required: true, number: true },
            rendimiento2: { required: true, number: true },
            rendimiento3: { required: true, number: true },
            rendimiento4: { required: true, number: true },
            rendimiento5: { required: true, number: true },
            rendimiento6: { required: true, number: true },
            rendimiento7: { required: true, number: true },
            rendimiento8: { required: true, number: true },
            rendimiento9: { required: true, number: true },
            rendimiento10: { required: true, number: true },
            rendimiento11: { required: true, number: true },
            rendimiento12: { required: true, number: true },
            comision1: { required: true, number: true },
            comision2: { required: true, number: true },
            comision3: { required: true, number: true },
            comision4: { required: true, number: true },
            comision5: { required: true, number: true },
            comision6: { required: true, number: true },
            comision7: { required: true, number: true },
            comision8: { required: true, number: true },
            comision9: { required: true, number: true },
            comision10: { required: true, number: true },
            comision11: { required: true, number: true },
            comision12: { required: true, number: true }
        },
        messages: {
            'rendimiento1': {
                number: jQuery('.rendimiento1').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento2': {
                number: jQuery('.rendimiento2').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento3': {
                number: jQuery('.rendimiento3').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento4': {
                number: jQuery('.rendimiento4').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento5': {
                number: jQuery('.rendimiento5').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento6': {
                number: jQuery('.rendimiento6').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento7': {
                number: jQuery('.rendimiento7').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento8': {
                number: jQuery('.rendimiento8').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento9': {
                number: jQuery('.rendimiento9').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento10': {
                number: jQuery('.rendimiento10').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento11': {
                number: jQuery('.rendimiento11').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'rendimiento12': {
                number: jQuery('.rendimiento12').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision1': {
                number: jQuery('.comision1').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision2': {
                number: jQuery('.comision2').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision3': {
                number: jQuery('.comision3').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision4': {
                number: jQuery('.comision4').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision5': {
                number: jQuery('.comision5').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision6': {
                number: jQuery('.comision6').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision7': {
                number: jQuery('.comision7').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision8': {
                number: jQuery('.comision8').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision9': {
                number: jQuery('.comision9').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision10': {
                number: jQuery('.comision10').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision11': {
                number: jQuery('.comision11').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
            'comision12': {
                number: jQuery('.comision12').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            }
        }
    });
});

$(function () {
    $("#form1").validate({
        rules: {
            campoTextoSalario: { number: true },
            campoTextoAporte: { number: true }
        },
        messages: {
            'campoTextoSalario': {
                number: jQuery('.campoTextoSalario').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 44 || 44 < tecla.charCode && tecla.charCode < 48 || tecla.charCode > 57) return false;
                })
            },
            'campoTextoAporte': {
                number: jQuery('.campoTextoAporte').keypress(function (tecla) {
                    if (31 < tecla.charCode && tecla.charCode < 46 || tecla.charCode > 57 || tecla.charCode == 47) return false;
                })
            },
        }
    });
});
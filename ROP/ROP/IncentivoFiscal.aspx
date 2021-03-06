﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IncentivoFiscal.aspx.vb" Inherits="ROP.IncentivoFiscal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }

        /*.etiqueta{
            text-align:center;
        }*/
    </style>
    <link href="Content/style.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Scripts/jquery.validate.js"></script>
    <script src="validation.js"></script>
    
</head>
<body>

    <div id="menuContent" runat="server">
        <!-- #Include virtual="~/MenuCalculadoras.aspx" -->
    </div>


            <div class="container">
                <div class="info"><h3>Cálculo estimado del incentivo fiscal de una pensión</h3></div>    
            
            
            <form id="form1" runat="server" class="table-form register-form form-horizontal">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
            <div class="form form-group">



            <asp:TextBox ID="campoTextoSalario" class="campoTextoSalario form-control" runat="server" placeholder="Salario mensual actual" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="campoTextoSalario" ErrorMessage="* Campo Requerido" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:TextBox ID="campoTextoAporte" class="campoTextoAporte form-control" runat="server" placeholder="Aporte al plan voluntario" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed2"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="campoTextoAporte" ErrorMessage="* Campo Requerido" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>

            <asp:Button ID="botonCalcular" runat="server" Text="Calcular" />
            <asp:Button ID="botonLimpiar" runat="server" Text="Limpiar datos" />

            <br/>
            <br/>

            <%--Tercero:--%>

                <asp:Label ID="primeraEtiqueta" runat="server" Visible="false"><b>RESULTADOS</b></asp:Label>
                <br />
                <br />
                <asp:Label ID="segundaEtiqueta" runat="server" Text="Monto máximo permitido que se puede exonerar" Visible="false"></asp:Label>
                <br />
                <br />
                <b ID="terceraEtiqueta" runat="server" Visible="false">Sin Plan Voluntario</b>
                <br />
                <asp:Label ID="cuartaEtiqueta" runat="server" Visible="false"></asp:Label>
                <br />
                <b ID="quintaEtiqueta" runat="server" Visible="false">Con Plan Voluntario</b>
                <br />
                <asp:Label ID="sextaEtiqueta" runat="server" Visible="false"></asp:Label>
                <br />
                <br />

                <%--Cuarto--%>

                    <asp:Label ID="septimaEtiqueta" runat="server" Text="Salario sobre el que se determinará el impuesto sobre la renta y las cargas sociales. Si el aporte es menor o igual al 10% del salario bruto, entonces puede exonerar la totalidad del aporte. Si no, solo puede exonerar el 10% del salario bruto" Visible="false"></asp:Label>
                    <br />
                <br />
                <b ID="octavaEtiqueta" runat="server" Visible="false">Sin Plan Voluntario</b>
                <br />
                <asp:Label ID="novenaEtiqueta" runat="server" Visible="false"></asp:Label>
                <br />
                <b ID="decimaEtiqueta" runat="server" Visible="false">Con Plan Voluntario</b>
                <br />
                <asp:Label ID="undecimaEtiqueta" runat="server" Visible="false"></asp:Label>
                <br />
                <br />

                    <%--Quinto--%>

                    <asp:Label ID="duodecimaEtiqueta" runat="server" Text="Monto del impuesto sobre la renta (tramos de renta fijados por la administración tributaria)" Visible="false"></asp:Label>
                    <br />
                    <asp:Label ID="etiquetaDoce" runat="server" Text="15% sobre el exceso de ¢1,199,000.00" Visible="false"></asp:Label>
                    <br />
                    <asp:Label ID="etiquetaTrece" runat="server" Text="10% sobre el exceso de ¢799,000.00 y hasta ¢1,199,000.00" Visible="false"></asp:Label>
                    <br />
                    <asp:Label ID="etiquetaCatorce" runat="server" Text="0% hasta ¢799,000.00" Visible="false"></asp:Label>
                    <br />
                <br />
                <b ID="etiquetaQuince" runat="server" Visible="false">Sin Plan Voluntario</b>
                <br />
                <asp:Label ID="etiquetaDieciseis" runat="server" Visible="false"></asp:Label>
                <br />
                <b ID="etiquetaDiecisiete" runat="server" Visible="false">Con Plan Voluntario</b>
                <br />
                <asp:Label ID="etiquetaDieciocho" runat="server" Visible="false"></asp:Label>
                <br />
                <br />

                <%--Sexto--%>

                <asp:Label ID="etiquetaDiecinueve" runat="server" Text="Monto de las cargas sociales" Visible="false"></asp:Label>
                <br />
                <asp:Label ID="etiquetaVeinte" runat="server" Text="5,50% del Régimen de Enfermedad y Maternidad" Visible="false"></asp:Label>
                <br />
                <asp:Label ID="etiquetaVeintiuno" runat="server" Text="3,34% del Régimen de Invalidez, Vejez y Muerte" Visible="false"></asp:Label>
                <br />
                <br />
                <b ID="etiquetaVeintidos" runat="server" Visible="false">Sin Plan Voluntario</b>
                <br />
                <asp:Label ID="etiquetaVeintitres" runat="server" Visible="false"></asp:Label>
                <br />
                <b ID="etiquetaVeinticuatro" runat="server" Visible="false">Con Plan Voluntario</b>
                <br />
                <asp:Label ID="etiquetaFaltante" runat="server" Visible="false"></asp:Label>
                <br />
                <br />

                <%--Setimo--%>
                <asp:Label ID="etiquetaVeinticinco" runat="server" Text="Total que se debe pagar del impuesto sobre la renta y cargas sociales." Visible="false"></asp:Label>
                <br />
                <br />
                <b ID="etiquetaVeintiseis" runat="server" Visible="false">Sin Plan Voluntario</b>
                <br />
                <asp:Label ID="etiquetaVeintisiete" runat="server" Visible="false"></asp:Label>
                <br />
                <b ID="etiquetaVeintiocho" runat="server" Visible="false">Con Plan Voluntario</b>
                <br />
                <asp:Label ID="etiquetaVeintinueve" runat="server" Visible="false"></asp:Label>
                <br />
                <br />

                <%--Octavo--%>

                <asp:Label ID="etiquetaTreinta" runat="server" Text="Como se puede observar en los resultados anteriores, cuando se aporta a un plan voluntario se paga menos impuestos y cargas sociales" Visible="false"></asp:Label>
                <br />
                <br />
                <asp:Label ID="etiquetaTreintaiuno" runat="server" Visible="false" ForeColor="Black"></asp:Label>

                <br />
                <br />

                <%--Noveno--%>

                <asp:Label ID="etiquetaTreintaidos" runat="server" Text="En conclusión, del aporte definido para el plan voluntario solo se tuvo que sacar del salario el monto producto de la resta del aporte y el pago de impuestos y cargas sociales" Visible="false"></asp:Label>
                <br />
                <br />
                <asp:Label ID="etiquetaTreintaitres" runat="server" Visible="false" ForeColor="Black"></asp:Label>
        </div>
                         </ContentTemplate>
                </asp:UpdatePanel>
    </form>
    </div>
</body>
</html>

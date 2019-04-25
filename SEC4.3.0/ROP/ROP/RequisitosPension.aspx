<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RequisitosPension.aspx.vb" Inherits="ROP.RequisitosPension" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="~/Content/jquery.datepicker.css"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Scripts/jquery.validate.js"></script>
    <script src="validation.js"></script>
</head>
<body>
        <div id="menuContent" runat="server">
            <!-- #Include virtual="~/MenuCalculadoras.aspx" -->
        </div>
        <div class="container">
                <div class="info"><h3>Cálculo estimado de requisitos para la obtención de una pensión por vejez</h3></div> 
        </div>
    
       <div class="form">
        <form id="form1" class="register-form" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderColor="Red" ControlToValidate="campoTextoNacimiento" ErrorMessage="* Digite una fecha válida " Font-Italic="True" ForeColor="Red" ValidationExpression="([0][1-9]|[12][0-9]|3[01])(\/|-)([0][1-9]|[1][0-2])\2(\d{4})"></asp:RegularExpressionValidator> --%>               
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <!--Fecha de nacimiento -->
                   <div class="input-group">
                   <asp:TextBox ID="campoTextoNacimiento" runat="server" class="form-control" placeholder="Nacimiento (dd/mm/aaaa)" data-select="datepicker" AutoCompleteType="Disabled"></asp:TextBox>
                   <span class="input-group-addon"></span>
                   </div>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="campoTextoNacimiento" ErrorMessage="* Digite fecha de nacimiento " Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            
       
                <!--Cotización realizadas -->
                    <div class="input-group">
                        <asp:TextBox ID="campoNumerosCotizaciones" runat="server" placeholder="Cotizaciones realizadas " class="input_txtCotizacion form-control" AutoCompleteType="Disabled" ></asp:TextBox> 
                        <span class="input-group-addon"></span>
                    </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="campoTextoNacimiento" ErrorMessage="* Digite las cotizaciones realizadas " Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <br/>
                

                <!-- Género-->
                    <div style="float:none;">
                        <label>Sexo:</label>
                        <asp:DropDownList runat="server" ID="listaSexo">
                            <asp:ListItem Selected="True" Value="1">Masculino</asp:ListItem>
                            <asp:ListItem Value="2">Femenino</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                <br/>

                 <!--Boton Calcular -->
                 <asp:Button ID="botonCalcular" runat="server" Text="Calcular" />
                 <br/>
                 
                 <!-- Boton de limpiar-->
                 <asp:Button ID="botonLimpiar" runat="server" Text="Limpiar datos" CausesValidation="False" />
                 <br />
                 <br />

                <asp:Label id="etiqueta" runat="server" visible="false" ></asp:Label>
                 

            </ContentTemplate>
            </asp:UpdatePanel>
           </form>  
        </div>
      <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.0/jquery.js"></script>
      <script type="text/javascript" src="Scripts/jquery.datepicker.js"></script>
</body>
</html>

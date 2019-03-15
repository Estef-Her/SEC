<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="ROP.ROP" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
        <script type="text/javascript" src="Scripts/jquery.validate.js"></script>
        <script src="validation.js"></script>
        <title>Retiro programado de pensión</title>
        <link rel="stylesheet" href="~/Content/jquery.datepicker.css"/>
        <link href="Content/bootstrap.css" rel="stylesheet" />
        <link href="Content/style.css" rel="stylesheet" />
    </head>
    <body>
        <div ID="menuContent" runat="server">
            <!-- #Include virtual="~/MenuCalculadoras.aspx" -->
        </div>
        <div class="container">
            <div class="info"><h3>Cálculo estimado del retiro programado de una pensión</h3></div>    
        </div>

        <div class="form">
            <form id="form1" class="register-form" runat="server" >
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderColor="Red" ControlToValidate="campoTextoNacimiento" ErrorMessage="* Digite una fecha válida " Font-Italic="True" ForeColor="Red" ValidationExpression="([0][1-9]|[12][0-9]|3[01])(\/|-)([0][1-9]|[1][0-2])\2(\d{4})"></asp:RegularExpressionValidator>                
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                   <!--Fecha de nacimiento -->

                   <asp:TextBox ID="campoTextoNacimiento" runat="server" input type="text" class="form-control" placeholder="Nacimiento (dd/mm/aaaa)" data-select="datepicker" AutoCompleteType="Disabled"></asp:TextBox>
                       <p>
                        &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="campoTextoNacimiento" ErrorMessage="* Digite fecha de nacimiento " Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;</p>

                    <!--Capital de pensión -->
                
                    <div class="input-group">
                        <span class="input-group-addon">₡</span>
                        <asp:TextBox ID="campoTextoCapital" runat="server" input type="text" class="input_txtCapital form-control" placeholder=" Capital de pensión" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed"></asp:TextBox>
                    </div>
                    <p>
                    &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="campoTextoCapital" ErrorMessage="* Digite un capital de pensión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </p>

                    <!--Tasa de interés técnica -->
                    <div class="input-group">
                        <span class="input-group-addon">Tasa interés técnica</span>
                        <asp:TextBox ID="campoTextoTasa" runat="server" input type="text" class="input_txtTasa form-control" AutoCompleteType="Disabled" Text="3"></asp:TextBox>
                        <span class="input-group-addon">%</span>
                    </div>
                    <p>
                    &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="campoTextoTasa" ErrorMessage="* Digite una tasa de interés técnica" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </p>

                    <br />

                    <div class="tasa">
                      <p><strong>Nota:</strong> La tasa de interés técnica es fijada por la SUPEN. Actualmente es del 3%</p>
                      <br />
                      <br /> 
                    </div>

                    <br />
                    <br />
                    <br />

                    <!-- Género-->
                    <div style="float:left;">
                        <label>Sexo:</label>
                    </div>

                    <br />
                
                    <asp:RadioButtonList ID="listaSexo" runat="server"  RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="left" >
                                    <asp:ListItem class="radio-inline" Selected="True" Value="1">Masculino</asp:ListItem>
                                    <asp:ListItem class="radio-inline" Value="2">Femenino</asp:ListItem>
                    </asp:RadioButtonList>

                    <br />

                    <!--Boton Calcular -->
                    <asp:Button ID="botonCalcular" runat="server" Text="Calcular" />

                    <!--Respuesta luego visible -->
          
                    <asp:Label ID="etiquetaVanuLarga" runat="server" Visible="False" Text="El valor actuarial necesario unitario (VANU) es de: "></asp:Label>
                    <asp:Label ID="etiquetaVanuCorta" runat="server" Visible="False" ForeColor="#000000" Width="30%" Font-Bold="true"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="etiquetaRopLarga" runat="server" Visible="False" Text="En esta modalidad, el capital de pensión dividido entre el VANU da como resultado un monto estimado de pensión de: "></asp:Label>
                    <asp:Label ID="etiquetaRopCorta" runat="server" Visible="False" ForeColor="#000000" Width="30%" Font-Bold="true"></asp:Label>
              
                    <!-- Boton de limpiar-->
                    <asp:Button ID="botonLimpiar" runat="server" Text="Limpiar datos" CausesValidation="False" />

                </ContentTemplate>
                </asp:UpdatePanel>
            </form>
        </div>

        <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.0/jquery.js"></script>
        <script type="text/javascript" src="Scripts/jquery.datepicker.js"></script>
    </body>
</html>
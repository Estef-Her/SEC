<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="ROP.ROP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="/Content/style.css" rel="stylesheet" /> 
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
<script type="text/javascript" src="Scripts/jquery.validate.js"></script>
<script src="validation.js"></script>
    <title></title>
<link rel="stylesheet" href="/Content/jquery.datepicker.css"/>
</head>
<body style="height: 364px">
        <form id="form1" runat="server">
        <ul>
          <li><a class="active" href="#home">Inicio</a></li>
        </ul>
    <h1>Cálculo estimado del retiro programado</h1>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div>
                        <p>
                            <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento:"></asp:Label>
                            <%--<asp:Textbox ID="txtNacim1" runat="server" input type="date" style="margin-left: 15px" ></asp:TextBox>--%>
	                            <asp:Textbox runat="server" input type="text"  name="date" ID="txtNacim" class="input_txtNacim" data-select="datepicker"></asp:TextBox>
                            
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderColor="Red" ControlToValidate="txtNacim" ErrorMessage="*Digite una fecha valida " Font-Italic="True" ForeColor="Red" ValidationExpression="([0][1-9]|[12][0-9]|3[01])(\/|-)([0][1-9]|[1][0-2])\2(\d{4})"></asp:RegularExpressionValidator>
                            
                        </p>
                        <p>
                            &nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNacim" ErrorMessage="* Digite una fecha " Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        </p>
                        <p>
                            <asp:Label ID="Label2" runat="server" Text="Capital de pensión:"></asp:Label>
                            <asp:span class="SimboloColones">₡</asp:span> <asp:TextBox ID="txtCapital" runat="server" style="margin-left: 8px" class="input_txtCapital" ></asp:TextBox>
                        </p>
                        <p>
                            &nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCapital" ErrorMessage="* Digite un monto" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        </p>
                        <p>
                            <asp:Label ID="lblTasa" runat="server" Text="Tasa de interés técnica: "></asp:Label>
                            <asp:TextBox ID="txtTasa" runat="server" style="margin-left: 8px" class="input_txtTasa" ></asp:TextBox>
                            <asp:Label ID="lblP" runat="server" Text="%"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblMens" runat="server" Text="La tasa de interés técnica es aprobada por la SUPEN, actualmente está fijada en 3%"></asp:Label>
                        </p>
                        <p>
                            &nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTasa" ErrorMessage="* Digite una tasa de interes" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        </p>
                        <asp:Label ID="Label3" runat="server" Text="Sexo:"></asp:Label>
                        <asp:RadioButtonList ID="radioListSexo" runat="server">
                            <asp:ListItem Selected="True" Value="1">Masculino</asp:ListItem>
                            <asp:ListItem Value="2">Femenino</asp:ListItem>
                        </asp:RadioButtonList>
                        <p>
                            <input type="reset" value="Limpiar Datos">
                            <asp:Button ID="btnConsultar" runat="server" Text="Calcular" />
                        </p>
                        <p style="margin-left: 200px">
                            <asp:Label ID="Label4" runat="server" Visible="False" Text="El monto de estimado de la pension en la modalidad de retiro programado(ROP) es de:"></asp:Label>
                            <asp:TextBox ID="txtEstimado" runat="server" Visible="false" style="margin-left: 8px"></asp:TextBox>
                        </p>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </form>



<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.0/jquery.js"></script>
<script type="text/javascript" src="Scripts/jquery.datepicker.js"></script>
</body>
</html>
